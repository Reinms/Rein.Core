namespace Rein.Core.RegistrySystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Registry : MetaRegistry.IRegistryDef
    {
        public abstract String guid { get; }
        public MetaRegistry.RegistrationToken? regToken { get; set; }
        internal abstract RegistryHandle _handle { get; }
        internal Stage _stage { get; set; } = Stage.PreInit;
        protected internal virtual IEnumerable<RegistryHandle> dependencies => Enumerable.Empty<RegistryHandle>();
        /// <summary>
        /// MUST BE CONSTANT RETURN
        /// </summary>
        protected virtual SByte priority => 0;
        protected virtual Boolean acceptsProcedural => true;
        protected virtual void OnInitFinished() { }

        protected internal abstract Boolean Init();
    }
}
