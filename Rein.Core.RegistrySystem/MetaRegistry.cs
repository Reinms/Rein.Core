namespace Rein.Core.RegistrySystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public sealed class MetaRegistry : Registry<MetaRegistry, Registry>
    {
        internal static void CreateIfNeeded() => _instance ??= new();
        protected override Boolean acceptsProcedural => false;
        protected override Boolean autoRegisterTokens => false;

        protected override Boolean OnStandardTokensCreated()
        {
            // TODO: Should add some form of system here to detect what regs should be loaded.

            var tokens = FindRegTokens(static a => true, false);
            foreach(var tok in tokens)
            {
                foreach(var dep in tok.def.dependencies)
                {
                    dep?.regToken?.Register();
                }
            }


            return true;
        }
        public static void InitAll()
        {
            if(!instance.Init())
            {
                //TODO: Log fatal error
                return;
            }

            static Registry GetReg(Element a) => a?.regToken?.def;
            var defs = MakeInitOrder(backend.EnumerateElements().Select(GetReg).Where(NotNull));

            foreach(var d in defs)
            {
                if(!d.Init())
                {
                    //TODO: Log error
                    continue;
                }
            }
        }
        public static void ReloadAll()
        {
            if(stage == Stage.PreInit)
            {
                InitAll();
            } else if(stage == Stage.Finalized)
            {
                InternalReloadAll();
            } else
            {
                // TODO: Fatal Invalid state error
                return;
            }
        }

        private static void InternalReloadAll()
        {
            static Registry GetReg(Element a) => a?.regToken?.def;
            static Boolean NotNull(Registry a) => a is not null;
            var defs = MakeInitOrder(backend.EnumerateElements().Select(GetReg).Where(NotNull));

            foreach(var d in defs)
            {
                //if(!d.Unload())
                //{
                //    //TODO: Log fatal error
                //    continue;
                //}
            }

            foreach(var d in defs)
            {
                //if(!d.Reload())
                //{
                //
                //}
            }
        }

        private static IEnumerable<Registry> MakeInitOrder(IEnumerable<Registry> input) => input
            .OrderBy(Guid)
            .GroupBy(Priority)
            .OrderByDescending(Key)
            .SelectMany(WithDeps)
            .Distinct();

        private static String Guid(Registry a) => a.guid;
        private static SByte Priority(Registry a) => a.priority;
        private static SByte Key(IGrouping<SByte, Registry> a) => a.Key;
        private static IEnumerable<Registry> WithDeps(IGrouping<SByte, Registry> a) => a.SelectMany(NotNullDependencies);
        private static IEnumerable<Registry> NotNullDependencies(Registry a) => a.dependencies.Select((Func<RegistryHandle, Registry>)Registry).Where(NotNull);
        private static Registry Registry(RegistryHandle a) => (a?.regToken?.def);
        private static Boolean NotNull(Registry a) => a is not null;
    }
}