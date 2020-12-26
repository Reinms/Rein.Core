namespace Rein.Core.RegistrySystem
{
    using System;

    public static class RegistryXtn
    {
        public static Boolean TryGetDef<TRegistry, TDef, TBackend>(this Registry<TRegistry, TDef, TBackend>.Index index, out Registry<TRegistry, TDef, TBackend>.Element? element)
            where TRegistry : Registry<TRegistry, TDef, TBackend>, new()
            where TDef : Registry<TRegistry, TDef, TBackend>.IRegistryDef
            where TBackend : struct, Registry<TRegistry, TDef, TBackend>.IRegistryBackend
            => Registry<TRegistry, TDef, TBackend>.TryGetElement(index, out element);
    }
}