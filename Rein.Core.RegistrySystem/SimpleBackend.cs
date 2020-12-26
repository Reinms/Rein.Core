namespace Rein.Core.RegistrySystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Rein.Core.NetUtils;

    //DO NOT SIMPLIFY THESE GENERIC TYPES, VISUAL STUDIO IS UNABLE TO HANDLE IT AND WILL HARD LOCK REPEATEDLY ON STARTUP. SERIOUSLY... DON'T...
    public struct SimpleBackend<TRegistry, TDef> : Registry<TRegistry, TDef, SimpleBackend<TRegistry, TDef>>.IRegistryBackend
        where TRegistry : Registry<TRegistry, TDef, SimpleBackend<TRegistry, TDef>>, new()
        where TDef : Registry<TRegistry, TDef, SimpleBackend<TRegistry, TDef>>.IRegistryDef
    {
        private Dictionary<String, Registry<TRegistry, TDef, SimpleBackend<TRegistry, TDef>>.Element> guidToElement;
        private Registry<TRegistry, TDef, SimpleBackend<TRegistry, TDef>>.Element[] elementsArray;

        public Boolean Init()
        {
            this.guidToElement = new();
            return true;
        }

        public Boolean TryEnable() => true;
        public Boolean TryDisable() => true;


        public Registry<TRegistry, TDef, SimpleBackend<TRegistry, TDef>>.Element? this[Registry<TRegistry, TDef, SimpleBackend<TRegistry, TDef>>.Index index]
        {
            get
            {
                if((UInt64)index >= this.count) return null;
                return this.elementsArray[(UInt64)index];
            }
        }

        public Registry<TRegistry, TDef, SimpleBackend<TRegistry, TDef>>.Element? this[String guid]
        {
            get => this.guidToElement.TryGetValue(guid, out var elem) ? elem : null;
            private set
            {
                this.guidToElement[guid] = value!;
            }
        }
        public IEnumerable<Registry<TRegistry, TDef, SimpleBackend<TRegistry, TDef>>.Element> EnumerateElements() => this.guidToElement.Values.Where(HasToken);    
        public UInt64 count { get; private set; }
        public Boolean CreateDefaultDefsIfNeeded()
        {
            this.count = 0ul;
            this.elementsArray = Array.Empty<Registry<TRegistry, TDef, SimpleBackend<TRegistry, TDef>>.Element>();
            foreach(var (_, elem) in this.guidToElement)
            {
                elem.index = Registry<TRegistry, TDef, SimpleBackend<TRegistry, TDef>>.Index.Invalid;
                if(elem.hasToken)
                {
                    elem.regToken!.element = null;
                }
                elem.regToken = null;
            }
            return true;
        }
        public Boolean SetFromGuidMap(IEnumerable<(String guid, Registry<TRegistry, TDef, SimpleBackend<TRegistry, TDef>>.RegistrationToken token)> map)
        {
            this.ProcessMap(map);
            return true;
        }
        public Boolean SupplyAdditionalMap(IEnumerable<(String guid, Registry<TRegistry, TDef, SimpleBackend<TRegistry, TDef>>.RegistrationToken token)> map)
        {
            this.ProcessMap(map);
            return true;
        }
        public Boolean Finalize()
        {
            this.elementsArray = this.EnumerateElements().ToArray();
            for(this.count = 0ul; this.count < (UInt64)this.elementsArray.LongLength; this.count++)
            {
                this.elementsArray[this.count].index = (Registry<TRegistry, TDef, SimpleBackend<TRegistry, TDef>>.Index)this.count;
            }
            return true;
        }

        
        private void ProcessMap(IEnumerable<(String guid, Registry<TRegistry, TDef, SimpleBackend<TRegistry, TDef>>.RegistrationToken token)> map)
        {
            foreach(var (guid, tok) in map)
            {
                var elem = this[guid] ??= new(guid);
                if(elem.regToken is Registry<TRegistry, TDef, SimpleBackend<TRegistry, TDef>>.RegistrationToken oldTok)
                {
                    oldTok.element = null;
                }
                elem.regToken = tok;
                tok.element = elem;
            }
        }
        private static Boolean HasToken(Registry<TRegistry, TDef, SimpleBackend<TRegistry, TDef>>.Element a) => a.hasToken;
    }
}