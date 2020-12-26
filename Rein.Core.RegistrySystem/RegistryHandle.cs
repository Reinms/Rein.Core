namespace Rein.Core.RegistrySystem
{
    using System;

    public abstract class RegistryHandle
    {
        private protected abstract Registry target { get; }

        internal Boolean initCompleted => target._stage == Stage.Finalized;
        internal MetaRegistry.RegistrationToken? regToken => target.regToken;
    }
}