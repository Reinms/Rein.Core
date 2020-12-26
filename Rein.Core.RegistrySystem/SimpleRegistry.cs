namespace Rein.Core.RegistrySystem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Registry<TRegistry, TDef> : Registry<TRegistry, TDef, SimpleBackend<TRegistry, TDef>>
        where TRegistry : Registry<TRegistry, TDef, SimpleBackend<TRegistry, TDef>>, new()
        where TDef : Registry<TRegistry, TDef, SimpleBackend<TRegistry, TDef>>.IRegistryDef
    {

    }
}
