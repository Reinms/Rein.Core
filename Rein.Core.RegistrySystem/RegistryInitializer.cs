namespace Rein.Core.RegistrySystem
{
    public static class RegistryInitializer
    {
        public static void Init<TRegistry, TDef, TBackend>()
            where TRegistry : Registry<TRegistry, TDef, TBackend>, new()
            where TDef : Registry<TRegistry, TDef, TBackend>.IRegistryDef
            where TBackend : struct, Registry<TRegistry, TDef, TBackend>.IRegistryBackend
        {
            MetaRegistry.CreateIfNeeded();
            //MetaRegistry is given special treatment because registering it with itself would mean adding numerous checks within it to ensure it does not initialize itself.
            if(typeof(TRegistry) == typeof(MetaRegistry)) return;
            try
            {
                var cat = new TRegistry();
                cat.regToken = MetaRegistry.Add(cat);
            } catch { }

        }
    }
}