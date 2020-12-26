namespace Rein.Core.RegistrySystem
{
    // TODO: Check stage valid before access
    internal enum Stage
    {
        Invalid = -1,
        PreInit,
        Init,
        Finalized,
    }
}