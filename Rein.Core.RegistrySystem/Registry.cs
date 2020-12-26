namespace Rein.Core.RegistrySystem
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using Rein.Core.NetUtils;

    public abstract class Registry<TRegistry, TDef, TBackend> : Registry
        where TRegistry : Registry<TRegistry, TDef, TBackend>, new()
        where TDef : Registry<TRegistry, TDef, TBackend>.IRegistryDef
        where TBackend : struct, Registry<TRegistry, TDef, TBackend>.IRegistryBackend
    {
        #region Overrides
        public sealed override String guid { get; } = $"{typeof(TRegistry).Assembly.GetName().Name}::{typeof(TRegistry).FullName}";
        internal sealed override RegistryHandle _handle { get; } = handle;
        protected internal sealed override Boolean Init() => TryInit();
        #endregion


        #region Overrideables
        protected virtual Boolean OnStandardTokensCreated() => true;
        protected virtual Boolean CreateAdditionalDefs() => true;
        protected virtual Boolean FirstTimeInit() => true;
        protected virtual void OnTokenRegister(RegistrationToken token) { }
        protected virtual void OnTokenUnregister(RegistrationToken token) { }
        #endregion

        #region Abstracts

        #endregion


        #region Singleton
        private protected static TBackend? _backend;
        private protected static TRegistry? _instance;
        protected static TBackend backend => _backend ?? throw new InvalidOperationException();
        protected static TRegistry instance => _instance ?? throw new InvalidOperationException();

        protected Registry() : base()
        {
            if(_instance is not null) throw new InvalidOperationException();
            _instance = (TRegistry)this;
            _backend = new();
            backend.Init();
        }
        #endregion


        #region External interface
        public static Boolean tokensRegisteredOnAdd => instance.autoRegisterTokens;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static RegistrationToken Add(TDef def)
        {
            //Use stacktrace to find calling method for debugging.
            //TODO: Add some configuration to determine if the adding method discovery runs
            var trace = new StackTrace(false);
            var frame = trace?.GetFrame(1);
            if((frame?.HasMethod() ?? false) && frame.GetMethod() is MethodBase method)
            {
                return _Add(def, false, method);
            }

            return _Add(def, false);
        }
        public static Boolean TryGetElement(Index index, out Element? element)
        {
            element = default;
            if(MetaRegistry.stage == Stage.Finalized && stage == Stage.Finalized)
            {
                return (element = backend[index]) is not null;
            }
            return false;
        }
        public static Boolean TryGetElement(String guid, out Element? element)
        {
            element = default;
            if(MetaRegistry.stage == Stage.Finalized && stage == Stage.Finalized)
            {
                return (element = backend[guid]) is not null;
            }
            return false;
        }

        public static IEnumerable<RegistrationToken> FindRegTokens(String guid, Boolean includeUnregistered) => FindRegTokens(a => a.guid == guid, includeUnregistered);
        public static IEnumerable<RegistrationToken> FindRegTokens(Func<RegistrationToken, Boolean> condition, Boolean includeUnregistered) => includeUnregistered ? RegistrationToken.instancesList.Where(condition) : RegistrationToken.instancesList.Where(a => a.isRegistered).Where(condition);

        public static UInt64 count => backend.count;
        public static RegistryHandle handle => new Handle();
        #endregion


        #region External Events
        public static event Action<RegistrationToken> onProceduralTokenCreated = (_) => { };
        public static event Action onStandardTokensCreated = () => { };
        public static event Action onStandardElementsFinalized = () => { };
        public static event Action onRegistryRebuild = () => { };
        #endregion


        #region Protected Interface
        protected static RegistrationToken _Add(TDef def, Boolean isBase, MethodBase addedBy = null)
        {
            RegistrationToken tok = null!;
            if(stage == Stage.PreInit)
            {
                tok = new(def, isBase, false);
                if(tokensRegisteredOnAdd) tok.Register();
            } else if(stage == Stage.Init || (stage == Stage.Finalized && MetaRegistry.stage == Stage.Init))
            {
                tok = new(def, isBase, true);
                if(tokensRegisteredOnAdd) tok.Register();
                pendingProceduralTokens.Enqueue(tok);
            } else
            {
                tok = new(def, isBase, false);
                if(tokensRegisteredOnAdd) tok.Register();
            }
            return tok;
        }
        #endregion


        #region Internal Interface
        internal static Boolean ProcessProceduralTokens()
        {
            var map = Enumerable.Empty<(String guid, RegistrationToken tok)>();
            while(pendingProceduralTokens.TryDequeue(out var tok))
            {
                map = map.Append((tok.guid, tok));
                onProceduralTokenCreated(tok);
            }
            return backend.SupplyAdditionalMap(map);
        }
        internal static Stage stage { get => instance._stage; set => instance._stage = value; }
        internal static Int32 proceduralCounter => pendingProceduralTokens.Count;
        internal static IEnumerable<RegistryHandle> dependencyHandles => instance.dependencies;
        #endregion


        #region Internal Events


        #endregion


        #region State tracking
        private static Boolean firstInitComplete = false;
        private static Boolean backendEnabled = false;
        #endregion


        #region Init Process
        internal static Boolean TryInit()
        {
            if(!CheckDependencies())
            {
                //TODO: Log Error
                if(!DisableBackend())
                {
                    //TODO: Log Fatal error
                }
                return false;
            }
            if(stage != Stage.PreInit)
            {
                //TODO: Log Error
                if(!DisableBackend())
                {
                    //TODO: Log Fatal error
                }
                return false;
            }
            if(!FirstInit())
            {
                //TODO: Log Error
                if(!DisableBackend())
                {
                    //TODO: Log Fatal error
                }
                return false;
            }
            if(!EnableBackend())
            {
                //TODO: Log Error
                if(!DisableBackend())
                {
                    //TODO: Log Fatal error
                }
                return false;
            }
            if(!GetDefaultTokens())
            {
                //TODO: Log Error
                if(!DisableBackend())
                {
                    //TODO: Log Fatal error
                }
                return false;
            }
            if(!UnassignOutstandingTokens())
            {
                //TODO: Log Error
                if(!DisableBackend())
                {
                    //TODO: Log Fatal error;
                }
                return false;
            }
            if(!onStandardTokensCreated.SafeInvoke(out var errors))
            {
                //TODO: Iterate and log errors

                //Does not stop execution because this event is an extension point and should not be used for implementation critical behaviours.
            }
            if(!RunOnStandardTokensCreated())
            {
                //TODO: Log Error
                if(!DisableBackend())
                {
                    //TODO: Log Fatal error;
                }
                return false;
            }
            stage = Stage.Init;
            if(!ProcessStandardTokens())
            {
                //TODO: Log Error
                if(!DisableBackend())
                {
                    //TODO: Log Fatal error
                }
                return false;
            }
            stage = Stage.Finalized;
            //TODO: Log success
            return true;
        }


        private static Boolean CheckDependencies()
        {
            var success = true;
            foreach(var handle in dependencyHandles)
            {
                if(!handle.initCompleted)
                {
                    //TODO: Log error
                    success = false;
                }
            }
            return success;
        }


        private static Boolean FirstInit()
        {
            if(!firstInitComplete)
            {
                var success = true;
                success &= backend.Init();
                if(!success)
                {
                    //TODO: Log error
                }
                success &= RunFirstInit();
                firstInitComplete = true;
                return success;
            }
            return true;
        }

        private static Boolean RunFirstInit()
        {
            return instance.FirstTimeInit();
        }

        private static Boolean EnableBackend()
        {
            var success = true;
            if(!backendEnabled)
            {
                success = backend.TryEnable();
            }

            backendEnabled = true;
            return success;
        }

        private static Boolean DisableBackend()
        {
            var success = true;
            if(backendEnabled)
            {
                success = backend.TryDisable();
            }
            backendEnabled = false;
            return success;
        }

        private static Boolean GetDefaultTokens()
        {
            return backend.CreateDefaultDefsIfNeeded() && CreateAdditionalDefaultDefs();
        }
        private static Boolean CreateAdditionalDefaultDefs()
        {
            return instance.CreateAdditionalDefs();
        }

        private static Boolean UnassignOutstandingTokens()
        {
            foreach(var tok in RegistrationToken.instancesList)
            {
                if(tok is not null)
                {
                    tok.element = null;
                }
            }
            return true;
        }

        private static Boolean RunOnStandardTokensCreated()
        {
            return instance.OnStandardTokensCreated();
        }

        private static Boolean ProcessStandardTokens()
        {
            static Boolean IsRegistered(RegistrationToken tok) => tok.isRegistered;
            static Boolean IsBase(RegistrationToken tok) => tok.isBase;
            static Boolean IsNotBase(RegistrationToken tok) => !tok.isBase;
            static String guid(RegistrationToken tok) => tok.guid;
            Dictionary<String, RegistrationToken> guidToCurrentToken = new();
            var activeTokens = RegistrationToken.instancesList.Where(IsRegistered);
            foreach(var tok in activeTokens.Where(IsBase))
            {
                if(guidToCurrentToken.TryGetValue(tok.guid, out var ctok))
                {
                    //TODO: Log override message here
                    ctok.isOverriden = true;
                }
                guidToCurrentToken[tok.guid] = tok;
            }
            foreach(var tok in activeTokens.Where(IsNotBase))
            {
                if(guidToCurrentToken.TryGetValue(tok.guid, out var ctok))
                {
                    //TODO: Log override message here
                    ctok.isOverriden = true;
                }
                guidToCurrentToken[tok.guid] = tok;
            }

            return backend.SetFromGuidMap(guidToCurrentToken.AsPairs());
        }
        #endregion


        #region Private Data
        private static readonly ConcurrentQueue<RegistrationToken> pendingProceduralTokens = new();
        #endregion

        #region Private Functions
        private static void OnTokenRegistration(RegistrationToken token)
        {
            instance.OnTokenRegister(token);
        }
        private static void OnTokenUnregistration(RegistrationToken token)
        {
            instance.OnTokenUnregister(token);
        }

        #endregion


        #region Nested Types
        public interface IRegistryBackend
        {
            /// <summary>
            /// Called a single time on registry creation.
            /// Should only be used to set values for fields and similar.
            /// Use Enable for anything that has meaningful impact like hooks and undo those things in Disable
            /// </summary>
            /// <returns>False if any errors occur</returns>
            Boolean Init();

            /// <summary>
            /// The number of currently active elements
            /// </summary>
            UInt64 count { get; }

            /// <summary>
            /// Should never throw, return null in case of errors
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            Element? this[Index index] { get; }
            /// <summary>
            /// Should never throw, return null in case of errors
            /// </summary>
            /// <param name="guid"></param>
            /// <returns></returns>
            Element? this[String guid] { get; }

            Boolean SetFromGuidMap(IEnumerable<(String guid, RegistrationToken token)> map);
            Boolean SupplyAdditionalMap(IEnumerable<(String guid, RegistrationToken token)> map);

            IEnumerable<Element> EnumerateElements();

            /// <summary>
            /// Run any modifying changes that need to occur for this backend.
            /// </summary>
            /// <returns>False if any errors occured</returns>
            Boolean TryEnable();
            /// <summary>
            /// Undo any modifying changed performed in Enable
            /// </summary>
            /// <returns>False if any errors occured</returns>
            Boolean TryDisable();

            /// <summary>
            /// Should create the registration tokens for the base game elements, if they have not been created already.
            /// </summary>
            /// <returns>False if any errors occur</returns>
            Boolean CreateDefaultDefsIfNeeded();

            /// <summary>
            /// This is called after all elements have been created, should in general only be used to optimize storage (Example: converting from a dictionary to array)
            /// </summary>
            /// <returns>False if any errors occur</returns>
            Boolean Finalize();
        }
        public interface IRegistryDef
        {
            /// <summary>
            /// MUST BE CONSTANT RETURN
            /// </summary>
            String guid { get; }
            /// <summary>
            /// MUST BE A SIMPLE GET SET PROPERTY, DO NOT SET MANUALLY
            /// </summary>
            RegistrationToken regToken { get; set; }
        }
        public enum Index : UInt64
        {
            Invalid = ~0ul,
        }
        //This is stored in TBackend
        public sealed class Element
        {
            public RegistrationToken? regToken { get; internal set; }
            public String guid { get; }
            private Index _index = Index.Invalid;

            public Boolean hasToken => this.regToken is not null;
            public Index index { get => this.hasToken ? this._index : Index.Invalid; internal set => this._index = value; }
            public Boolean active => this.index != Index.Invalid;

            internal Element(String guid)
            {
                this.guid = guid;
            }
        }

        public sealed class RegistrationToken
        {
            internal static readonly List<RegistrationToken> instancesList = new();
            internal static UInt64 ctr = 0ul;
            public TDef def { get; }
            public Element? element { get; internal set; }


            public String guid => this.def.guid;


            /// <summary>
            /// Is this part of the base game?
            /// </summary>
            public Boolean isBase { get; }
            /// <summary>
            /// Is this created procedurally?
            /// If true, then the isDestroyed property can also be true and should be checked.
            /// </summary>
            public Boolean isProcedural { get; }

            /// <summary>
            /// Only meaningful for procedural RegistrationTokens, indicates of this is a token from a previous registry lifecycle.
            /// Non procedural RegistrationTokens are not bound to a specific lifecycle.
            /// After being destroyed, def can still be accessed
            /// It is the responsibility of the creator to ensure that any references to a destroyed token are dereferenced
            /// </summary>
            public Boolean isDestroyed { get; private set; }

            /// <summary>
            /// Will this token be considered when the 
            /// </summary>
            public Boolean isRegistered { get; internal set; }

            /// <summary>
            /// Has this token's guid been overriden by another with the same guid?
            /// </summary>
            public Boolean isOverriden { get; internal set; }


            public void Register()
            {
                if(!this.isRegistered)
                {
                    this.isRegistered = true;
                    OnTokenRegistration(this);
                }
            }

            public void UnRegister()
            {
                if(this.isRegistered)
                {
                    this.isRegistered = false;
                    OnTokenUnregistration(this);
                }
            }



            /// <summary>
            /// Only assigned if debugging is set (Debugging disable not implemented though lol)
            /// </summary>
            internal MethodBase? addedBy { get; }

            /// <summary>
            /// A unique id for this token. Will reflect the order it was added in except for procedurals which will be delayed, and may be recreated on reset.
            /// Relative order is deterministic with call order of Add
            /// </summary>
            internal UInt64 id { get; }

            internal RegistrationToken(TDef def, Boolean isBase, Boolean isProcedural)
            {
                (this.def, this.isBase, this.isProcedural, this.id) = (def, isBase, isProcedural, ctr++);
                if(isProcedural) onRegistryRebuild += this.Destroy;
                instancesList.Add(this);
            }
            internal RegistrationToken(TDef def, Boolean isBase, Boolean isProcedural, MethodBase addedBy) : this(def, isBase, isProcedural)
            {
                this.addedBy = addedBy;
            }
            private void Destroy()
            {
                if(this.isDestroyed || !this.isProcedural) return;
                this.isDestroyed = true;
                instancesList.Remove(this);
                onRegistryRebuild -= this.Destroy;
                this.element = null;
            }
        }
        private sealed class Handle : RegistryHandle
        {
            private protected sealed override Registry target => instance;
        }
        #endregion
    }
}