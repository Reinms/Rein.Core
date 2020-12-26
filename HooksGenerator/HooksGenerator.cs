namespace HooksGenerator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Reflection.Metadata.Ecma335;
    using System.Runtime.CompilerServices;

    using dnlib.DotNet;

    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using Microsoft.CodeAnalysis.CSharp.Syntax;

    using BaseSourceGenerator;

    [Generator]
    public class HooksGenerator : BaseSourceGenerator
    {
        public override String id => typeof(HooksGenerator).FullName;
        private static readonly Dictionary<String, AssemblyDef> referencedAssemblies = new();
        public override void OnExecute(GeneratorExecutionContext context)
        {
            var rec = context.SyntaxReceiver as Reciever;
            var typelist = Enumerable.Empty<(Boolean safe, TypeInfo info)>();

            foreach(var v in context.Compilation.References)
            {
                AssemblyDef asm = null;
                try
                {
                    asm = AssemblyDef.Load(File.ReadAllBytes(v.Display));
                } catch { }
                if(asm is not null)
                {
                    referencedAssemblies[asm.FullName] = asm;
                }
            }
            foreach(var atrib in rec.attributes)
            {
                var model = context.Compilation.GetSemanticModel(atrib.SyntaxTree, true);
                var typeinfo = model.GetTypeInfo(atrib);
                var def = typeinfo.ConvertedType?.OriginalDefinition;
                if(def is not null)
                {
                    if(def.ContainingModule.MetadataName == typeof(Hooks.HookGenAttribute).Module.Name && def.MetadataName == typeof(Hooks.HookGenAttribute).Name)
                    {
                        typelist = typelist.Concat(atrib.ArgumentList.Arguments.SelectMany(GetTypeInfoFromAtribArg).Select(t => (true, model.GetTypeInfo(t))));
                    } else if(def.ContainingModule.MetadataName == typeof(Hooks.UnsafeHookGenAttribute).Module.Name && def.MetadataName == typeof(Hooks.UnsafeHookGenAttribute).Name)
                    {
                        typelist = typelist.Concat(atrib.ArgumentList.Arguments.SelectMany(GetTypeInfoFromAtribArg).Select(t => (false, model.GetTypeInfo(t))));
                    }
                }
            }

            var pre = typelist.Select(t => (t.safe, t.info.ConvertedType)).Where(t => t.ConvertedType is not null && t.ConvertedType.ContainingAssembly is not null);

            var dict = new Dictionary<ITypeSymbol, GenerationInfo>();
            foreach(var v in pre)
            {
                if(dict.TryGetValue(v.ConvertedType, out var info) && !info.safe) continue;
                dict[v.ConvertedType] = new(v.safe, v.ConvertedType);
            }

            foreach(var group in dict.GroupBy(t => t.Value.type.ContainingAssembly))
            {
                var str = group.Key.Identity.GetDisplayName();
                if(referencedAssemblies.TryGetValue(str, out var asm))
                {
                    foreach(var t in group.Select(a => a.Value))
                    {
                        var def = asm.Find(t.fullName, false);
                        if(def is not null)
                        {
                            GenerateHookEvents(def, t, context);
                        }
                    }
                }
            }
        }

        private static int hooknum = 0;


        private void GenerateHookEvents(TypeDef td, GenerationInfo info, GeneratorExecutionContext ctx)
        {
            if(td.HasGenericParameters) return;
            foreach(var m in td.Methods)
            {
                GenerateMethodEvent(m, info, ctx);
            }
        }

        private void GenerateMethodEvent(MethodDef md, GenerationInfo info, GeneratorExecutionContext ctx)
        {
            if(md.HasGenericParameters) return;
            //if(info.safe && !md.IsNoInlining)
            //{
            //    if(md.IsAggressiveInlining) return;
            //    var size = md.Body.Instructions.Aggregate(0, (i, ins) => i + ins.GetSize());
            //    if(size <= 20) return;
            //}
            base.EmitSource(
$@"namespace Hooks{(String.IsNullOrWhiteSpace(md.DeclaringType.Namespace) ? "" : $".{md.DeclaringType.Namespace}")}
{{
    using global::System.Linq;
{String.Join("\n", Nest(md.DeclaringType,
$@"internal static class {HookEventName(md)}
{{
    {GetMethodBase(md)}
    {GetOrigDelegate(md)}
    {GetHookDelegate(md)}
    internal static event Hook On
    {{
        add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
        remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
    }}
    internal static event global::MonoMod.Cil.ILContext.Manipulator IL
    {{
        add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
        remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
    }}
}}").Split('\n').Select(s => $"    {s}"))}
}}");
        }

        private static String Nest(TypeDef def, String text)
        {
            if(def is null) return text;
            var inside = String.Join("\n", text.Split('\n').Select(a => $"    {a}"));
            return Nest(def.DeclaringType,
$@"internal static partial class {def.Name}
{{
{inside}
}}");
        }

        private static String HookEventName(MethodDef md)
        {
            if(md.DeclaringType.FindMethods(md.Name).Count() <= 1)
            {
                return md.Name.Replace(".", "_");
            }
            return $"{md.Name.Replace(".", "_")}__{GetNameSafeRep(md.ReturnType)}__{String.Join("_", md.Parameters.Select(p => GetNameSafeRep(p.Type)))}";
        }

        private static String GetOrigDelegate(MethodDef md)
        {
            var sig = md.MethodSig;
            int arg = 0;
            return $"internal delegate {ReturnTypeName(sig.RetType)} Orig({String.Join(", ", GetOrigArgs(md))});";
        }
        private static IEnumerable<String> GetOrigArgs(MethodDef md)
        {
            var res = Enumerable.Empty<String>();
            if(md.HasThis)
            {
                res = res.Append($"{GetSourceRep(md.DeclaringType.ToTypeSig())} self");
            }
            int i = 0;
            foreach(var p in md.Parameters)
            {
                var name = p.Name;
                if(String.IsNullOrWhiteSpace(name))
                {
                    name = $"arg_{i++}";
                }
                res = res.Append($"{GetSourceRep(p.Type)} {name}");
            }

            return res;
        }


        private static String ReturnTypeName(TypeSig ts)
        {
            if(ts.ReflectionFullName == typeof(void).FullName)
            {
                return "void";
            }

            return GetTypeName(ts);
        }

        private static String GetTypeName(TypeSig ts)
        {
            return GetSourceRep(ts);
        }

        private static String GetHookDelegate(MethodDef md)
        {
            var sig = md.MethodSig;
            int arg = 0;
            return $"internal delegate {ReturnTypeName(sig.RetType)} Hook({String.Join(", ", Enumerable.Repeat("Orig orig", 1).Concat(GetOrigArgs(md)))});";
        }

        private static String GetMethodBase(MethodDef md)
        {
            return $"private static readonly global::System.Reflection.MethodBase method = typeof({GetSourceRep(md.DeclaringType.ToTypeSig())}).GetMethods({String.Join(" | ", GetBindingFlags(md))}){String.Join("", GetMethodFilters(md))}.FirstOrDefault() ?? throw new global::System.MissingMethodException();";
        }
        private static IEnumerable<String> GetMethodFilters(MethodDef md)
        {
            IEnumerable<String> res = new String[]
            {
                $"m => m.GetParameters().Length == {md.Parameters.Count}",
                $"m => m.ReturnParameter.ParameterType.FullName == \"{md.ReturnType.ReflectionFullName}\"",
            };
            var parameters = md.Parameters;
            for(Int32 i = 0; i < parameters.Count; ++i)
            {
                var p = parameters[i];
                res = res.Append($"m => m.GetParameters()[{i}].ParameterType.FullName == \"{p.Type.ReflectionFullName}\"");
            }
            return res.Select(s => $".Where({s})");
        }
        private static IEnumerable<String> GetBindingFlags(MethodDef md)
        {
            var res = Enumerable.Empty<String>();
            var bf = "global::System.Reflection.BindingFlags.";

            if(md.IsStatic)
            {
                res = res.Append($"{bf}Static");
            } else
            {
                res = res.Append($"{bf}Instance");
            }
            res = res.Append($"{bf}Public");
            res = res.Append($"{bf}NonPublic");
            return res;
        }


        private static String GetSourceRep(TypeSig sig)
        {
            return _GetSourceRep(sig);
        }

        private static String _GetSourceRep(TypeSig sig) => sig switch
        {
            GenericInstSig r => SourceGenericRep(r),
            ByRefSig r => $"ref {GetSourceRep(r.Next)}",
            TypeSig ts => $"global::{UnmangleGenericSourceRep(ts.FullName.Replace("/", "."))}",
        };
        private static String UnmangleGenericSourceRep(String fullname)
        {
            var ind = fullname.IndexOf('`');
            if(ind != -1)
            {
                return fullname.Remove(ind);
            }
            return fullname;
        }
        private static String SourceGenericRep(GenericInstSig sig)
        {
            return $"{GetSourceRep(sig.GenericType)}<{String.Join(", ", sig.GenericArguments.Select(GetSourceRep))}>";
        }


        private static String GetNameSafeRep(TypeSig sig)
        {
            var res = _GetNameSafeRep(sig);
            if(res.Contains('[') || res.Contains('<') || res.Contains('`'))
            {
                return $"ERR: {sig.GetType().Name}";
            }
            return res;
        }

        private static String _GetNameSafeRep(TypeSig sig) => sig switch
        {
            ArraySig r => $"{GetNameSafeRep(r.Next)}_Array",
            SZArraySig r => $"{GetNameSafeRep(r.Next)}_Array",
            PtrSig r => $"{GetNameSafeRep(r.Next)}_Ptr",
            GenericInstSig r => NameSafeGenericRep(r),



            TypeSig ts => ts.FullName.Replace('.', '_').Replace("`", "_"),
        };

        private static String NameSafeGenericRep(GenericInstSig sig)
        {
            return $"{GetNameSafeRep(sig.GenericType)}_{String.Join("_", sig.GenericArguments.Select(GetNameSafeRep))}";
        }


        private readonly struct GenerationInfo
        {
            internal Boolean safe { get; }
            internal ITypeSymbol type { get; }

            internal GenerationInfo(Boolean safe, ITypeSymbol type) => (this.safe, this.type) = (safe, type);

            internal String fullName => $"{GetNestedNamespace(this.type.ContainingNamespace)}{GetNestedName(this.type)}";


            private static String GetNestedName(ITypeSymbol type) => type.ContainingType is ITypeSymbol par ? $"{GetNestedName(par)}/{type.MetadataName}" : type.MetadataName;
            private static String GetNestedNamespace(INamespaceOrTypeSymbol type) => type is not null ? type.ContainingNamespace is INamespaceSymbol par ? $"{GetNestedNamespace(par)}{type.MetadataName}." : type.MetadataName : "";
        }

        private static IEnumerable<TypeSyntax> GetTypeInfoFromAtribArg(AttributeArgumentSyntax arg) => GetTypeInfoFromArg(arg.Expression);
        private static IEnumerable<TypeSyntax> GetTypeInfoFromArg(ExpressionSyntax arg) => arg switch
        {
            TypeOfExpressionSyntax tof => Enumerable.Repeat(tof.Type, 1),
            ImplicitArrayCreationExpressionSyntax arr => arr.Initializer.Expressions.SelectMany(GetTypeInfoFromArg),
            ArrayCreationExpressionSyntax arr => arr.Initializer.Expressions.SelectMany(GetTypeInfoFromArg),
            _ => Enumerable.Empty<TypeSyntax>(),
        };




        public override SyntaxNotificationReciever GetSyntaxNotificationReciever() => new Reciever();

        private class Reciever : SyntaxNotificationReciever
        {
            internal readonly List<AttributeSyntax> attributes = new();
            public override void OnNodeVisited(SyntaxNode syntaxNode)
            {
                if(syntaxNode.IsKind(SyntaxKind.Attribute) && syntaxNode is AttributeSyntax atrib) this.attributes.Add(atrib);
            }
        }
    }
}
namespace Hooks
{
    using System;

    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = true, Inherited = false)]
    public sealed class HookGenAttribute : Attribute
    {
        public HookGenAttribute(params Type[] types) {{}}
    }

    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = true, Inherited = false)]
    public sealed class UnsafeHookGenAttribute : Attribute
    {

    }
}
