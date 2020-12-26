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
    public class RegistrySystemGenerator : BaseSourceGenerator
    {
        public override String id => typeof(RegistrySystemGenerator).FullName;

        public override void OnExecute(GeneratorExecutionContext context)
        {
            static Boolean InheritsRegistry(INamedTypeSymbol nts, INamedTypeSymbol top, out ITypeSymbol defTs, out ITypeSymbol backendTs)
            {
                if(nts.IsStatic || nts.BaseType is not INamedTypeSymbol baseNts || !baseNts.IsGenericType)
                {
                    defTs = backendTs = null;
                    return false;
                }

                if(baseNts.GloballyQualifiedTypeName() == "global::Rein.Core.RegistrySystem.Registry" && baseNts.TypeArguments.Length == 3 && baseNts.TypeArguments[0].GloballyQualifiedTypeName() == top.GloballyQualifiedTypeName())
                {
                    defTs = baseNts.TypeArguments[1];
                    backendTs = baseNts.TypeArguments[2];
                    return true;
                }
                return InheritsRegistry(baseNts, top, out defTs, out backendTs);
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
                if(InheritsRegistry(di, di, out var defI, out var backI))
                {
                    generatedCalls.Add($"global::Rein.Core.RegistrySystem.RegistryInitializer.Init<{di.GloballyQualifiedTypeName(true)}, {defI.GloballyQualifiedTypeName(true)}, {backI.GloballyQualifiedTypeName(true)}>();");
                }
            }

            base.EmitSource(
$@"internal static partial class Module
{{
    private static partial void InitRegistrySystem()
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

