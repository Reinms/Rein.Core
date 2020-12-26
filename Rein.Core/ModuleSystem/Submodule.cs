namespace Rein.Core.ModuleSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Text;

    internal class SubmoduleInitializer
    {
        internal static void Init<T>()
            where T : Submodule<T>
        {

        }
    }

    public abstract class Submodule
    {
        private protected Boolean _loaded { get; set; }
        protected abstract Boolean TryEnable(out Exception ex);
        protected abstract Boolean TryDisable(out Exception ex);
    }

    public abstract class Submodule<TSelf> : Submodule
        where TSelf : Submodule<TSelf>
    {


        private protected static TSelf instance;
        public static Boolean loaded => instance._loaded;
    }

    public sealed class TestSubmodule : Submodule<TestSubmodule>
    {
        protected override Boolean TryDisable(out Exception ex) => throw new NotImplementedException();
        protected override Boolean TryEnable(out Exception ex) => throw new NotImplementedException();
    }
}