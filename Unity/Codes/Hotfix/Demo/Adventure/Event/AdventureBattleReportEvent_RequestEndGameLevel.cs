﻿using ET.EventType;

namespace ET
{
    public class AdventureBattleReportEvent_RequestEndGameLevel:AEventAsync<EventType.AdventureBattleReport>
    {
        protected override async ETTask Run(AdventureBattleReport args)
        {
            if (args.BattleRoundResult == BattleRoundResult.KeepBattle)
            {
                return;
            }

            int errCode = await AdventureHelper.RequestEndGameLevel(args.ZoneScene, args.BattleRoundResult, args.Round);

            if (errCode != ErrorCode.ERR_Success)
            {
                return;
            }

            await TimerComponent.Instance.WaitAsync(3000);
            
            args.ZoneScene?.CurrentScene()?.GetComponent<AdventureComponent>()?.ResetAdventure();

            await ETTask.CompletedTask;
        }
    }
}