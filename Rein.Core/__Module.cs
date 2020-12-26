using WeaverAnnotations.Attributes;
using WeaverAnnotations.Attributes.PromoteToModule;

[assembly:PromoteToModule]
[assembly:Hooks.HookGen(typeof(RoR2.CharacterBody))]

[Promote]
internal static partial class Module
{
    static Module()
    {
        InitSubmoduleSystem();
        InitRegistrySystem();
    }
    private static partial void InitSubmoduleSystem();
    private static partial void InitRegistrySystem();
}