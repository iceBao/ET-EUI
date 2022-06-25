

namespace ET
{
	public static class SessionPlayerComponentSystem
	{
		public class SessionPlayerComponentDestroySystem: DestroySystem<SessionPlayerComponent>
		{
			public override void Destroy(SessionPlayerComponent self)
			{
				// TODO
				// Player player = Game.EventSystem.Get(self.PlayerInstanceId) as Player;
				// bool disConnect = false;
				// // 发送断线消息
				// if (disConnect)
				// {
				// 	// 主动断开
				// 	await DisconnectHelper.KickPlayer(player);
				// }
				// else
				// {
				// }
				ActorLocationSenderComponent.Instance.Send(self.PlayerId, new G2M_SessionDisconnect());
				self.Domain.GetComponent<PlayerComponent>()?.Remove(self.AccountId);
				
			}
		}

		public static Player GetMyPlayer(this SessionPlayerComponent self)
		{
			return self.Domain.GetComponent<PlayerComponent>().Get(self.AccountId);
		}
	}
}
