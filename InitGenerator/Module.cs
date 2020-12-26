namespace InitGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using BaseSourceGenerator;

    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using Microsoft.CodeAnalysis.CSharp.Syntax;

    [Generator]
    public class ModuleSystemGenerator : BaseSourceGenerator
    {
        public override String id => typeof(ModuleSystemGenerator).FullName;

        public override void OnExecute(GeneratorExecutionContext context)
        {
            static Boolean InheritsModule(INamedTypeSymbol nts, INamedTypeSymbol top)
            {
                if(nts.IsStatic || nts.BaseType is not INamedTypeSymbol baseNts || !baseNts.IsGenericType) return false;

                if(baseNts.GloballyQualifiedTypeName() == "global::Rein.Core.ModuleSystem.Submodule" && baseNts.TypeArguments.First().GloballyQualifiedTypeName() == top.GloballyQualifiedTypeName())
                {
                    return true;
                }
                return InheritsModule(baseNts, top);
            }


            var rec = context.SyntaxReceiver as Reciever;
            if(rec is null)
            {
                base.Error("No valid syntax reciever, something is really messed up");
                return;
            }
            List<String> generatedCalls = new();
            foreach(var candidate in rec.candidates)
            {
                var model = context.Compilation.GetSemanticModel(candidate.SyntaxTree, true);
                var di = model.GetDeclaredSymbol(candidate);
                if(!di.IsSealed || di.IsAbstract || di.IsGenericType) continue;
                if(InheritsModule(di, di))
                {
                    generatedCalls.Add($"global::Rein.Core.ModuleSystem.SubmoduleInitializer.Init<{di.GloballyQualifiedTypeName()}>();");
                }
            }

            base.EmitSource(
$@"internal static partial class Module
{{
    private static partial void InitSubmoduleSystem()
    {{
{String.Join(Environment.NewLine, generatedCalls.Select(s => $"        {s}"))}
    }}
}}
");
        }
        public override SyntaxNotificationReciever GetSyntaxNotificationReciever() => new Reciever();

        private class Reciever : SyntaxNotificationReciever
        {
            internal List<ClassDeclarationSyntax> candidates = new();
            public override void OnNodeVisited(SyntaxNode syntaxNode)
            {
                if(syntaxNode.IsKind(SyntaxKind.ClassDeclaration) && syntaxNode is ClassDeclarationSyntax classDec)
                {
                    this.candidates.Add(classDec);
                }
            }
        }
    }
}

