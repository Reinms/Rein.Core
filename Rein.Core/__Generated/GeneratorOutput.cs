[assembly:GeneratorTarget]
//*:::DiagStart:::HooksGenerator.HooksGenerator*/
//*:::DiagEng:::HooksGenerator.HooksGenerator*/

//*:::CodeStart:::HooksGenerator.HooksGenerator*/
#region Generated Code
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class LoadCommonAssets
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 0).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig();
            internal delegate void Hook(Orig orig);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class GetDisplayName
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.String").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.String Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.String Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class GetSubtitle
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.String").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.String Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.String Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class GetUserName
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.String").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.String Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.String Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class GetColoredUserName
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.String").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.String Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.String Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class WriteBuffs
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "UnityEngine.Networking.NetworkWriter").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::UnityEngine.Networking.NetworkWriter writer);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::UnityEngine.Networking.NetworkWriter writer);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class ReadBuffs
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "UnityEngine.Networking.NetworkReader").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::UnityEngine.Networking.NetworkReader reader);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::UnityEngine.Networking.NetworkReader reader);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class AddBuff
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.BuffIndex").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffIndex buffType);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffIndex buffType);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class RemoveBuff
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.BuffIndex").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffIndex buffType);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffIndex buffType);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class SetBuffCount
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 3).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.BuffIndex").Where(m => m.GetParameters()[2].ParameterType.FullName == "System.Int32").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffIndex buffType, global::System.Int32 newCount);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffIndex buffType, global::System.Int32 newCount);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnBuffFirstStackGained
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.BuffDef").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffDef buffDef);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffDef buffDef);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnBuffFinalStackLost
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.BuffDef").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffDef buffDef);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffDef buffDef);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class GetBuffCount
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Int32").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.BuffIndex").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Int32 Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffIndex buffType);
            internal delegate global::System.Int32 Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffIndex buffType);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class HasBuff
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Boolean").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.BuffIndex").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Boolean Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffIndex buffType);
            internal delegate global::System.Boolean Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffIndex buffType);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class AddTimedBuffAuthority
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 3).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.BuffIndex").Where(m => m.GetParameters()[2].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffIndex buffType, global::System.Single duration);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffIndex buffType, global::System.Single duration);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class CmdAddTimedBuff
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 3).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.BuffIndex").Where(m => m.GetParameters()[2].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffIndex buffType, global::System.Single duration);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffIndex buffType, global::System.Single duration);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class AddTimedBuff
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 3).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.BuffIndex").Where(m => m.GetParameters()[2].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffIndex buffType, global::System.Single duration);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffIndex buffType, global::System.Single duration);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class ClearTimedBuffs
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.BuffIndex").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffIndex buffType);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffIndex buffType);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class UpdateBuffs
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single deltaTime);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single deltaTime);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnClientBuffsChanged
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_master
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "RoR2.CharacterMaster").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::RoR2.CharacterMaster Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::RoR2.CharacterMaster Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_inventory
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "RoR2.Inventory").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::RoR2.Inventory Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::RoR2.Inventory Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_inventory
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.Inventory").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.Inventory value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.Inventory value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_isPlayerControlled
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Boolean").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Boolean Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Boolean Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_isPlayerControlled
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Boolean").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_executeEliteHealthFraction
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Single Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Single Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_executeEliteHealthFraction
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class UpdateHurtBoxesEnabled
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnInventoryChanged
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnEquipmentLost
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.EquipmentDef").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.EquipmentDef equipmentDef);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.EquipmentDef equipmentDef);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnEquipmentGained
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.EquipmentDef").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.EquipmentDef equipmentDef);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.EquipmentDef equipmentDef);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class add_onInventoryChanged
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Action").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Action value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Action value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class remove_onInventoryChanged
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Action").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Action value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Action value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_masterObject
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "UnityEngine.GameObject").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::UnityEngine.GameObject Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::UnityEngine.GameObject Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_masterObject
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "UnityEngine.GameObject").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::UnityEngine.GameObject value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::UnityEngine.GameObject value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class UpdateMasterLink
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_rigidbody
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "UnityEngine.Rigidbody").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::UnityEngine.Rigidbody Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::UnityEngine.Rigidbody Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_rigidbody
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "UnityEngine.Rigidbody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::UnityEngine.Rigidbody value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::UnityEngine.Rigidbody value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_networkIdentity
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "UnityEngine.Networking.NetworkIdentity").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::UnityEngine.Networking.NetworkIdentity Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::UnityEngine.Networking.NetworkIdentity Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_networkIdentity
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "UnityEngine.Networking.NetworkIdentity").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::UnityEngine.Networking.NetworkIdentity value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::UnityEngine.Networking.NetworkIdentity value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_characterMotor
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "RoR2.CharacterMotor").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::RoR2.CharacterMotor Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::RoR2.CharacterMotor Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_characterMotor
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.CharacterMotor").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.CharacterMotor value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.CharacterMotor value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_characterDirection
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "RoR2.CharacterDirection").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::RoR2.CharacterDirection Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::RoR2.CharacterDirection Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_characterDirection
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.CharacterDirection").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.CharacterDirection value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.CharacterDirection value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_teamComponent
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "RoR2.TeamComponent").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::RoR2.TeamComponent Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::RoR2.TeamComponent Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_teamComponent
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.TeamComponent").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.TeamComponent value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.TeamComponent value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_healthComponent
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "RoR2.HealthComponent").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::RoR2.HealthComponent Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::RoR2.HealthComponent Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_healthComponent
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.HealthComponent").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.HealthComponent value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.HealthComponent value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_equipmentSlot
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "RoR2.EquipmentSlot").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::RoR2.EquipmentSlot Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::RoR2.EquipmentSlot Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_equipmentSlot
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.EquipmentSlot").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.EquipmentSlot value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.EquipmentSlot value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_inputBank
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "RoR2.InputBankTest").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::RoR2.InputBankTest Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::RoR2.InputBankTest Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_inputBank
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.InputBankTest").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.InputBankTest value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.InputBankTest value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_skillLocator
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "RoR2.SkillLocator").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::RoR2.SkillLocator Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::RoR2.SkillLocator Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_skillLocator
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.SkillLocator").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.SkillLocator value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.SkillLocator value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_modelLocator
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "RoR2.ModelLocator").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::RoR2.ModelLocator Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::RoR2.ModelLocator Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_modelLocator
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.ModelLocator").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.ModelLocator value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.ModelLocator value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_hurtBoxGroup
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "RoR2.HurtBoxGroup").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::RoR2.HurtBoxGroup Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::RoR2.HurtBoxGroup Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_hurtBoxGroup
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.HurtBoxGroup").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.HurtBoxGroup value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.HurtBoxGroup value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_mainHurtBox
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "RoR2.HurtBox").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::RoR2.HurtBox Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::RoR2.HurtBox Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_mainHurtBox
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.HurtBox").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.HurtBox value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.HurtBox value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_coreTransform
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "UnityEngine.Transform").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::UnityEngine.Transform Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::UnityEngine.Transform Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_coreTransform
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "UnityEngine.Transform").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::UnityEngine.Transform value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::UnityEngine.Transform value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class Awake
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnModelChanged
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "UnityEngine.Transform").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::UnityEngine.Transform modelTransform);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::UnityEngine.Transform modelTransform);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class Start
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class Update
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class FixedUpdate
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnDeathStart
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnTakeDamageServer
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.DamageReport").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.DamageReport damageReport);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.DamageReport damageReport);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnSkillActivated
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.GenericSkill").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.GenericSkill skill);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.GenericSkill skill);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnDestroy
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class GetNormalizedThreatValue
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Single Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Single Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnEnable
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnDisable
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnValidate
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class add_onBodyStartGlobal
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "System.Action`1[[RoR2.CharacterBody, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::System.Action<global::RoR2.CharacterBody> value);
            internal delegate void Hook(Orig orig, global::System.Action<global::RoR2.CharacterBody> value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class remove_onBodyStartGlobal
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "System.Action`1[[RoR2.CharacterBody, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::System.Action<global::RoR2.CharacterBody> value);
            internal delegate void Hook(Orig orig, global::System.Action<global::RoR2.CharacterBody> value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_hasEffectiveAuthority
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Boolean").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Boolean Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Boolean Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_hasEffectiveAuthority
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Boolean").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class UpdateAuthority
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnStartAuthority
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnStopAuthority
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_isSprinting
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Boolean").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Boolean Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Boolean Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_isSprinting
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Boolean").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnSprintStart
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnSprintStop
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class CmdUpdateSprint
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Boolean").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean newIsSprinting);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean newIsSprinting);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class CmdOnSkillActivated
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.SByte").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.SByte skillIndex);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.SByte skillIndex);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_outOfCombat
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Boolean").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Boolean Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Boolean Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_outOfCombat
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Boolean").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_outOfDanger
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Boolean").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Boolean Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Boolean Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_outOfDanger
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Boolean").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnOutOfDangerChanged
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnOutOfCombatAndDangerServer
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class GetNotMoving
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Boolean").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Boolean Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Boolean Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class PerformAutoCalculateLevelStats
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_experience
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Single Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Single Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_experience
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_level
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Single Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Single Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_level
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_maxHealth
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Single Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Single Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_maxHealth
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_maxBarrier
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Single Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Single Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_maxBarrier
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_barrierDecayRate
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Single Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Single Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_barrierDecayRate
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_regen
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Single Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Single Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_regen
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_maxShield
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Single Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Single Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_maxShield
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_moveSpeed
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Single Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Single Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_moveSpeed
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_acceleration
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Single Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Single Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_acceleration
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_jumpPower
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Single Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Single Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_jumpPower
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_maxJumpCount
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Int32").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Int32 Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Int32 Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_maxJumpCount
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Int32").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Int32 value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Int32 value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_maxJumpHeight
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Single Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Single Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_maxJumpHeight
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_damage
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Single Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Single Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_damage
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_attackSpeed
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Single Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Single Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_attackSpeed
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_crit
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Single Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Single Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_crit
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_armor
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Single Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Single Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_armor
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_critHeal
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Single Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Single Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_critHeal
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_cursePenalty
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Single Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Single Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_cursePenalty
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_hasOneShotProtection
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Boolean").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Boolean Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Boolean Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_hasOneShotProtection
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Boolean").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_isGlass
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Boolean").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Boolean Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Boolean Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_isGlass
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Boolean").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_oneShotProtectionFraction
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Single Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Single Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_oneShotProtectionFraction
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class RecalculateStats
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnLevelChanged
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class SetAimTimer
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single duration);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single duration);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_shouldAim
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Boolean").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Boolean Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Boolean Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnDeserialize
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 3).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "UnityEngine.Networking.NetworkReader").Where(m => m.GetParameters()[2].ParameterType.FullName == "System.Boolean").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::UnityEngine.Networking.NetworkReader reader, global::System.Boolean initialState);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::UnityEngine.Networking.NetworkReader reader, global::System.Boolean initialState);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnSerialize
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 3).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Boolean").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "UnityEngine.Networking.NetworkWriter").Where(m => m.GetParameters()[2].ParameterType.FullName == "System.Boolean").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Boolean Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::UnityEngine.Networking.NetworkWriter writer, global::System.Boolean initialState);
            internal delegate global::System.Boolean Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::UnityEngine.Networking.NetworkWriter writer, global::System.Boolean initialState);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_warCryReady
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Boolean").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Boolean Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Boolean Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_warCryReady
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Boolean").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class ActivateWarCryAura
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Int32").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Int32 stacks);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Int32 stacks);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class RpcSyncWarCryReady
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Boolean").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_killCountServer
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Int32").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Int32 Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Int32 Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_killCountServer
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Int32").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Int32 value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Int32 value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class HandleOnKillEffectsServer
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.DamageReport").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.DamageReport damageReport);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.DamageReport damageReport);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class OnKilledOtherServer
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.DamageReport").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.DamageReport damageReport);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.DamageReport damageReport);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class UpdateTeslaCoil
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class AddHelfireDuration
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single duration);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single duration);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class UpdateHelfire
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class UpdateFireTrail
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class UpdateBeetleGuardAllies
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class UpdateAffixPoison
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single deltaTime);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single deltaTime);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class UpdatePowerWardSummon
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_bestFitRadius
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Single Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Single Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class UpdateAllTemporaryVisualEffects
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class UpdateSingleTemporaryVisualEffect
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 6).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.TemporaryVisualEffect&").Where(m => m.GetParameters()[2].ParameterType.FullName == "System.String").Where(m => m.GetParameters()[3].ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[4].ParameterType.FullName == "System.Boolean").Where(m => m.GetParameters()[5].ParameterType.FullName == "System.String").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, ref global::RoR2.TemporaryVisualEffect tempEffect, global::System.String resourceString, global::System.Single effectRadius, global::System.Boolean active, global::System.String childLocatorOverride);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, ref global::RoR2.TemporaryVisualEffect tempEffect, global::System.String resourceString, global::System.Single effectRadius, global::System.Boolean active, global::System.String childLocatorOverride);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_hasCloakBuff
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Boolean").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Boolean Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Boolean Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class GetVisibilityLevel__RoR2_VisibilityLevel__RoR2_CharacterBody_RoR2_CharacterBody
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "RoR2.VisibilityLevel").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::RoR2.VisibilityLevel Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.CharacterBody observer);
            internal delegate global::RoR2.VisibilityLevel Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.CharacterBody observer);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class GetVisibilityLevel__RoR2_VisibilityLevel__RoR2_CharacterBody_RoR2_TeamIndex
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "RoR2.VisibilityLevel").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.TeamIndex").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::RoR2.VisibilityLevel Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.TeamIndex observerTeam);
            internal delegate global::RoR2.VisibilityLevel Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.TeamIndex observerTeam);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class AddSpreadBloom
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class SetSpreadBloom
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 3).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[2].ParameterType.FullName == "System.Boolean").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value, global::System.Boolean canOnlyIncreaseBloom);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value, global::System.Boolean canOnlyIncreaseBloom);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class UpdateSpreadBloom
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single dt);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single dt);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_spreadBloomAngle
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Single Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Single Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class SendConstructTurret
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 5).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[2].ParameterType.FullName == "UnityEngine.Vector3").Where(m => m.GetParameters()[3].ParameterType.FullName == "UnityEngine.Quaternion").Where(m => m.GetParameters()[4].ParameterType.FullName == "RoR2.MasterCatalog+MasterIndex").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.CharacterBody builder, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::RoR2.MasterCatalog.MasterIndex masterIndex);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.CharacterBody builder, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::RoR2.MasterCatalog.MasterIndex masterIndex);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class HandleConstructTurret
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "UnityEngine.Networking.NetworkMessage").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::UnityEngine.Networking.NetworkMessage netMsg);
            internal delegate void Hook(Orig orig, global::UnityEngine.Networking.NetworkMessage netMsg);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_multiKillCount
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Int32").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Int32 Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Int32 Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_multiKillCount
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Int32").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Int32 value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Int32 value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class AddMultiKill
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Int32").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Int32 kills);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Int32 kills);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class UpdateMultiKill
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single deltaTime);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single deltaTime);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_corePosition
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "UnityEngine.Vector3").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::UnityEngine.Vector3 Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::UnityEngine.Vector3 Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_footPosition
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "UnityEngine.Vector3").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::UnityEngine.Vector3 Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::UnityEngine.Vector3 Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_radius
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Single").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Single Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Single Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_radius
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Single value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_aimOrigin
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "UnityEngine.Vector3").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::UnityEngine.Vector3 Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::UnityEngine.Vector3 Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_isElite
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Boolean").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Boolean Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Boolean Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_isElite
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Boolean").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_isBoss
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Boolean").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Boolean Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Boolean Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_isFlying
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Boolean").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Boolean Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Boolean Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class RpcBark
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class CmdRequestVehicleEjection
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class RollCrit
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Boolean").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Boolean Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Boolean Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class RpcUsePreferredInitialStateType
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class SetBodyStateToPreferredInitialState
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class SetLoadoutServer
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.Loadout").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.Loadout loadout);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.Loadout loadout);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_localStartTime
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "RoR2.Run+FixedTimeStamp").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::RoR2.Run.FixedTimeStamp Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::RoR2.Run.FixedTimeStamp Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class set_localStartTime
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.Run+FixedTimeStamp").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.Run.FixedTimeStamp value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.Run.FixedTimeStamp value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class get_isEquipmentActivationAllowed
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Boolean").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate global::System.Boolean Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate global::System.Boolean Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class _ctor
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class _cctor
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 0).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig();
            internal delegate void Hook(Orig orig);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class UNetVersion
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class InvokeCmdCmdAddTimedBuff
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "UnityEngine.Networking.NetworkBehaviour").Where(m => m.GetParameters()[1].ParameterType.FullName == "UnityEngine.Networking.NetworkReader").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::UnityEngine.Networking.NetworkBehaviour obj, global::UnityEngine.Networking.NetworkReader reader);
            internal delegate void Hook(Orig orig, global::UnityEngine.Networking.NetworkBehaviour obj, global::UnityEngine.Networking.NetworkReader reader);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class InvokeCmdCmdUpdateSprint
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "UnityEngine.Networking.NetworkBehaviour").Where(m => m.GetParameters()[1].ParameterType.FullName == "UnityEngine.Networking.NetworkReader").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::UnityEngine.Networking.NetworkBehaviour obj, global::UnityEngine.Networking.NetworkReader reader);
            internal delegate void Hook(Orig orig, global::UnityEngine.Networking.NetworkBehaviour obj, global::UnityEngine.Networking.NetworkReader reader);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class InvokeCmdCmdOnSkillActivated
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "UnityEngine.Networking.NetworkBehaviour").Where(m => m.GetParameters()[1].ParameterType.FullName == "UnityEngine.Networking.NetworkReader").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::UnityEngine.Networking.NetworkBehaviour obj, global::UnityEngine.Networking.NetworkReader reader);
            internal delegate void Hook(Orig orig, global::UnityEngine.Networking.NetworkBehaviour obj, global::UnityEngine.Networking.NetworkReader reader);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class InvokeCmdCmdRequestVehicleEjection
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "UnityEngine.Networking.NetworkBehaviour").Where(m => m.GetParameters()[1].ParameterType.FullName == "UnityEngine.Networking.NetworkReader").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::UnityEngine.Networking.NetworkBehaviour obj, global::UnityEngine.Networking.NetworkReader reader);
            internal delegate void Hook(Orig orig, global::UnityEngine.Networking.NetworkBehaviour obj, global::UnityEngine.Networking.NetworkReader reader);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class CallCmdAddTimedBuff
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 3).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "RoR2.BuffIndex").Where(m => m.GetParameters()[2].ParameterType.FullName == "System.Single").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffIndex buffType, global::System.Single duration);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::RoR2.BuffIndex buffType, global::System.Single duration);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class CallCmdUpdateSprint
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Boolean").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean newIsSprinting);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean newIsSprinting);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class CallCmdOnSkillActivated
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.SByte").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.SByte skillIndex);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.SByte skillIndex);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class CallCmdRequestVehicleEjection
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class InvokeRpcRpcSyncWarCryReady
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "UnityEngine.Networking.NetworkBehaviour").Where(m => m.GetParameters()[1].ParameterType.FullName == "UnityEngine.Networking.NetworkReader").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::UnityEngine.Networking.NetworkBehaviour obj, global::UnityEngine.Networking.NetworkReader reader);
            internal delegate void Hook(Orig orig, global::UnityEngine.Networking.NetworkBehaviour obj, global::UnityEngine.Networking.NetworkReader reader);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class InvokeRpcRpcBark
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "UnityEngine.Networking.NetworkBehaviour").Where(m => m.GetParameters()[1].ParameterType.FullName == "UnityEngine.Networking.NetworkReader").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::UnityEngine.Networking.NetworkBehaviour obj, global::UnityEngine.Networking.NetworkReader reader);
            internal delegate void Hook(Orig orig, global::UnityEngine.Networking.NetworkBehaviour obj, global::UnityEngine.Networking.NetworkReader reader);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class InvokeRpcRpcUsePreferredInitialStateType
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "UnityEngine.Networking.NetworkBehaviour").Where(m => m.GetParameters()[1].ParameterType.FullName == "UnityEngine.Networking.NetworkReader").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::UnityEngine.Networking.NetworkBehaviour obj, global::UnityEngine.Networking.NetworkReader reader);
            internal delegate void Hook(Orig orig, global::UnityEngine.Networking.NetworkBehaviour obj, global::UnityEngine.Networking.NetworkReader reader);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class CallRpcSyncWarCryReady
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 2).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").Where(m => m.GetParameters()[1].ParameterType.FullName == "System.Boolean").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean value);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0, global::System.Boolean value);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class CallRpcBark
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
namespace Hooks.RoR2
{
    using global::System.Linq;
    internal static partial class CharacterBody
    {
        internal static class CallRpcUsePreferredInitialStateType
        {
            private static readonly global::System.Reflection.MethodBase method = typeof(global::RoR2.CharacterBody).GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic).Where(m => m.GetParameters().Length == 1).Where(m => m.ReturnParameter.ParameterType.FullName == "System.Void").Where(m => m.GetParameters()[0].ParameterType.FullName == "RoR2.CharacterBody").FirstOrDefault() ?? throw new global::System.MissingMethodException();
            internal delegate void Orig(global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal delegate void Hook(Orig orig, global::RoR2.CharacterBody self, global::RoR2.CharacterBody arg_0);
            internal static event Hook On
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Add<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Remove<Hook>(method, value);
            }
            internal static event global::MonoMod.Cil.ILContext.Manipulator IL
            {
                add => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Modify<Hook>(method, value);
                remove => global::MonoMod.RuntimeDetour.HookGen.HookEndpointManager.Unmodify<Hook>(method, value);
            }
        }
    }
}
#endregion
//*:::CodeEnd:::HooksGenerator.HooksGenerator*/

//*:::DiagStart:::InitGenerator.ModuleSystemGenerator*/
//*:::DiagEng:::InitGenerator.ModuleSystemGenerator*/

//*:::CodeStart:::InitGenerator.ModuleSystemGenerator*/
#region Generated Code
internal static partial class Module
{
    private static partial void InitSubmoduleSystem()
    {
        global::Rein.Core.ModuleSystem.SubmoduleInitializer.Init<global::Rein.Core.ModuleSystem.TestSubmodule>();
    }
}

#endregion
//*:::CodeEnd:::InitGenerator.ModuleSystemGenerator*/

//*:::DiagStart:::InitGenerator.RegistrySystemGenerator*/
//*:::DiagEng:::InitGenerator.RegistrySystemGenerator*/

//*:::CodeStart:::InitGenerator.RegistrySystemGenerator*/
#region Generated Code
internal static partial class Module
{
    private static partial void InitRegistrySystem()
    {
        global::Rein.Core.RegistrySystem.RegistryInitializer.Init<global::Rein.Core.RegistrySystem.MetaRegistry, global::Rein.Core.RegistrySystem.Registry, global::Rein.Core.RegistrySystem.SimpleBackend<global::Rein.Core.RegistrySystem.MetaRegistry, global::Rein.Core.RegistrySystem.Registry>>();
    }
}

#endregion
//*:::CodeEnd:::InitGenerator.RegistrySystemGenerator*/

