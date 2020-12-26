namespace Rein.Core.RegistrySystem
{
    using System;

    public sealed class MetaRegistry : Registry<MetaRegistry, Registry>
    {
        internal static void CreateIfNeeded() => _instance ??= new();
        protected override Boolean acceptsProcedural => false;
    }
}