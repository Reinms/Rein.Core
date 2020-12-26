namespace ModuleSystemGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using Microsoft.CodeAnalysis.CSharp.Syntax;

    [Generator]
    public class ModuleSystemGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context) 
            => context.AddSource("Generated submodule initializer",
$@"using Rein.Core.ModuleSystem;
internal static partial class Module
{{
    private static partial void InitSubmoduleSystem()
    {{
        {String.Join(Environment.NewLine, (context.SyntaxReceiver as Reciever).generatedCalls)}
    }}
}}");

        private static Boolean IsSimpleBaseType(SyntaxNode node) => node.IsKind(SyntaxKind.SimpleBaseType);
        private static SimpleBaseTypeSyntax AsSimpleBaseType(SyntaxNode node) => IsSimpleBaseType(node) ? node as SimpleBaseTypeSyntax : null;
        private static GenericNameSyntax GetTypeSyntax(SimpleBaseTypeSyntax node) => node.Type as GenericNameSyntax;
        private static Boolean IsSubmoduleDeclaration(ClassDeclarationSyntax syntax)
            => syntax.BaseList
            ?.ChildNodes()
            ?.SelectWhere(AsSimpleBaseType)
            ?.SelectWhere(GetTypeSyntax)
            ?.Any(a => (a.Identifier.Text == "Submodule") && ((a.TypeArgumentList.Arguments.FirstOrDefault() as IdentifierNameSyntax)?.Identifier.ValueText == syntax.Identifier.ValueText)) ?? false;

        private static String GetInitCallText(ClassDeclarationSyntax syntax) => $"SubmoduleInitializer.Init<{syntax.Identifier.Text}>();";
        public void Initialize(GeneratorInitializationContext context)
        {
            context.RegisterForSyntaxNotifications(() => new Reciever());
        }

        private class Reciever : ISyntaxReceiver
        {
            internal List<String> generatedCalls = new();
            public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
            {
                if(syntaxNode.IsKind(SyntaxKind.ClassDeclaration) && syntaxNode is ClassDeclarationSyntax classDec && IsSubmoduleDeclaration(classDec))
                {
                    this.generatedCalls.Add(GetInitCallText(classDec));
                }
            }
        }
    }
    internal static class LinqXtn
    {
        public static IEnumerable<TTo> SelectWhere<TFrom, TTo>(this IEnumerable<TFrom> from, Func<TFrom, TTo?> fn) => from.Select(fn).Where(NotNull);
        public static Boolean NotNull<T>(this T input) => input is not null;
    }
}

