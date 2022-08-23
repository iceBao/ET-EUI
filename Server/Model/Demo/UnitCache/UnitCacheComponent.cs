using System.Collections.Generic;
using System.Reflection;

namespace ET
{
    public class UnitCacheComponent : Entity, IAwake, IDestroy
    { 
        public Dictionary<string, UnitCache> UnitCaches = new Dictionary<string, UnitCache>();

        public List<string> UnitCacheKeyList = new List<string>();
    }
}