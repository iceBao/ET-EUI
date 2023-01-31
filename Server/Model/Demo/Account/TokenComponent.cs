using System.Collections.Generic;

namespace ET
{
    [ComponentOf()]
    public class TokenComponent : Entity,IAwake
    {
        public Dictionary<long, string> TokenDictionary = new Dictionary<long, string>();
    }
}