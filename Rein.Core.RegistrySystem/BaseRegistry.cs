namespace Rein.Core.RegistrySystem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Registry : MetaRegistry.IRegistryDef
    {
        public abstract String guid { get; }
        public MetaRegistry.RegistrationToken? regToken { get; set; }
        internal abstract IRegistryHandle _handle { get; }
        internal Stage _stage { get; set; } = Stage.PreInit;
        protected virtual IEnumerable<IRegistryHandle> dependencies => Enumerable.Empty<IRegistryHandle>();
        /// <summary>
        /// MUST BE CONSTANT RETURN
        /// </summary>
        protected virtual SByte priority => 0;
        protected virtual Boolean acceptsProcedural => true;
        protected virtual void OnInitFinished() { }

        protected internal abstract Boolean Init();
    }
}
