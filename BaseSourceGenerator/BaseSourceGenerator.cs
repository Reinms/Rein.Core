namespace BaseSourceGenerator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Reflection.Metadata;
    using System.Text;

    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using Microsoft.CodeAnalysis.CSharp.Syntax;
    using Microsoft.CodeAnalysis.Text;

    public abstract class BaseSourceGenerator : ISourceGenerator
    {
        /// <summary>
        /// A unique ID for this generator
        /// </summary>
        public abstract String id { get; }

        /// <summary>
        /// Adds source to the target file, should only be called during execute
        /// </summary>
        /// <param name="text">The source to emit</param>
        protected void EmitSource(String text)
        {
            if(!this.acceptsOutput) return;
            this.code.Add(text);
        }

        /// <summary>
        /// Logs a warning
        /// </summary>
        /// <param name="info">Info about why warning was logged</param>
        protected void Warning(String info)
        {
            this.warnings.Add(info);
        }
        /// <summary>
        /// Logs an error
        /// </summary>
        /// <param name="info">Info about why error was logged</param>
        protected void Error(String info)
        {
            this.errors.Add(info);
        }

        /// <summary>
        /// Adds a message
        /// </summary>
        /// <param name="info">The message</param>
        protected void Message(String info)
        {
            this.messages.Add(info);
        }

        public virtual void OnExecute(GeneratorExecutionContext context) { }
        public virtual void OnInitialize(GeneratorInitializationContext context) { }
        public virtual SyntaxNotificationReciever GetSyntaxNotificationReciever() => new SyntaxNotificationReciever();
        public class SyntaxNotificationReciever : ISyntaxReceiver
        {
            internal List<AttributeSyntax> candidates = new();
            public virtual void OnNodeVisited(SyntaxNode node) { }

            public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
            {
                if(syntaxNode.IsKind(SyntaxKind.Attribute) && syntaxNode is AttributeSyntax atrib) this.candidates.Add(atrib);

                this.OnNodeVisited(syntaxNode);
            }
        }

        public void Execute(GeneratorExecutionContext context)
        {
            var rec = context.SyntaxReceiver as SyntaxNotificationReciever;
            if(rec is null) return;

            String path = null;
            Int32 line = -1;
            foreach(var atr in rec.candidates)
            {
                var model = context.Compilation.GetSemanticModel(atr.SyntaxTree, true);
                var def = model.GetTypeInfo(atr).ConvertedType?.OriginalDefinition;
                if(def is null) continue;
                if(def.ContainingModule?.MetadataName == typeof(GeneratorTargetAttribute).Module.Name && def.MetadataName == typeof(GeneratorTargetAttribute).Name)
                {
                    path = atr.SyntaxTree.FilePath;
                    line = atr.GetLocation().GetLineSpan().EndLinePosition.Line;
                    break;
                }
            }
            if(path is null) return;

            var id = this.id;
            var curText = File.ReadAllText(path);
            var shouldEmitCode = false;
            this.acceptsOutput = true;
            try
            {
                this.OnExecute(context);
                shouldEmitCode = true;
            } catch(Exception e)
            {
                this.errors.Add(e.ToString());
            }
            this.acceptsOutput = false;

            String diagStartTag = $"//*:::DiagStart:::{id}*/";
            var diagStart = curText.IndexOf(diagStartTag);
            String diagEndTag = $"//*:::DiagEng:::{id}*/";
            var diagEnd = curText.IndexOf(diagEndTag);
            var diagBuilder = new StringBuilder();

            diagBuilder.AppendLine(diagStartTag);
            foreach(var err in this.errors)
            {
                foreach(var v in err.Split('\n'))
                {
                    diagBuilder.Append($"#error {v}");
                }
                diagBuilder.AppendLine();
            }
            foreach(var warn in this.warnings)
            {
                foreach(var v in warn.Split('\n'))
                {
                    diagBuilder.Append($"#warning {v}");
                }
                diagBuilder.AppendLine();
            }
            foreach(var message in this.messages)
            {
                foreach(var v in message.Split('\n'))
                {
                    diagBuilder.Append($"//message: {v}");
                }
                diagBuilder.AppendLine();
            }
            diagBuilder.AppendLine(diagEndTag);

            if(diagStart == -1 || diagEnd == -1)
            {
                curText = new StringBuilder(curText).AppendLine(diagBuilder.ToString()).ToString();
            } else
            {
                var sub = curText.Substring(diagStart, diagEnd + diagEndTag.Length - diagStart);
                curText = curText.Replace(sub, diagBuilder.ToString());
            }

            if(shouldEmitCode)
            {
                String codeStartTag = $"//*:::CodeStart:::{id}*/";
                var codeStart = curText.IndexOf(codeStartTag);
                String codeEndTag = $"//*:::CodeEnd:::{id}*/";
                var codeEnd = curText.IndexOf(codeEndTag);
                var codeBuilder = new StringBuilder();

                codeBuilder.AppendLine(codeStartTag);
                codeBuilder.AppendLine("#region Generated Code");
                foreach(var code in this.code)
                {
                    codeBuilder.AppendLine(code);
                }
                codeBuilder.AppendLine("#endregion");
                codeBuilder.AppendLine(codeEndTag);

                if(codeStart == -1 || codeEnd == -1)
                {
                    curText = new StringBuilder(curText).AppendLine(codeBuilder.ToString()).ToString();
                } else
                {
                    var sub = curText.Substring(codeStart, codeEnd + codeEndTag.Length - codeStart);
                    curText = curText.Replace(sub, codeBuilder.ToString());
                }

            }

            var tnl = $"{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}";
            var nnl = $"{Environment.NewLine}{Environment.NewLine}";
            while(curText.IndexOf($"{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}") != -1)
            {
                curText = curText.Replace(tnl, nnl);
            }

            File.WriteAllText(path, curText);
        }
        public void Initialize(GeneratorInitializationContext context)
        {
            this.OnInitialize(context);
            context.RegisterForSyntaxNotifications(this.GetSyntaxNotificationReciever);
        }

        private Boolean acceptsOutput = false;

        private List<String> errors = new();
        private List<String> warnings = new();
        private List<String> messages = new();
        private List<String> code = new();
    }

    public static class HelperXtn
    {
        public static String GloballyQualifiedTypeName(this ITypeSymbol symbol, Boolean withGenerics = false)
        {
            static String RecName(INamespaceOrTypeSymbol symbol)
            {
                if(symbol is ITypeSymbol ts)
                {
                    if(ts.ContainingType is null)
                    {
                        if(ts.ContainingNamespace is null)
                        {
                            return ts.Name;
                        }
                        return $"{RecName(ts.ContainingNamespace)}.{ts.Name}";
                    } else
                    {
                        return $"{RecName(symbol.ContainingType)}.{ts.Name}";
                    }
                }
                if(symbol is INamespaceSymbol ns)
                {
                    if(ns.ContainingNamespace is null || String.IsNullOrWhiteSpace(ns.ContainingNamespace.Name))
                    {
                        return ns.Name;
                    }
                    return $"{RecName(ns.ContainingNamespace)}.{ns.Name}";
                }
                return null;
            }

            return $"global::{RecName(symbol)}{(withGenerics ? symbol.GetGenerics() : "")}";
        }

        public static String GetGenerics(this ITypeSymbol symbol)
        {
            if(symbol is not INamedTypeSymbol nts || nts.TypeArguments.Length <= 0 || !nts.IsGenericType || nts.TypeParameters.Length <= 0) return "";

            return $"<{String.Join(", ", nts.TypeArguments.Select(s => s.GloballyQualifiedTypeName(true)))}>";
        }
    }
}
[System.AttributeUsage(System.AttributeTargets.Assembly, AllowMultiple = false)]
public sealed class GeneratorTargetAttribute : System.Attribute { }