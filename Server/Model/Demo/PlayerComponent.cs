using System.Collections.Generic;
using System.Linq;

namespace ET
{
	[ComponentOf(typeof(Scene))]
	public class PlayerComponent : Entity, IAwake, IDestroy
	{
		public readonly Dictionary<long, Player> idPlayers = new Dictionary<long, Player>();
		
		public int Count
		{
			get
			{
				return this.idPlayers.Count;
			}
		}
		
	}
}