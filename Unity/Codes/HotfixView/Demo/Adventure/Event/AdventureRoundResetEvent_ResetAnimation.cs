using ET.EventType;

namespace ET
{
    public class AdventureRoundResetEvent_ResetAnimation : AEvent<EventType.AdventureRoundReset>
    {
        protected override async void Run(AdventureRoundReset args)
        {
            Unit unit = UnitHelper.GetMyUnitFromCurrentScene(args.ZoneScene.CurrentScene());
            unit?.GetComponent<AnimatorComponent>()?.Play(MotionType.Idle);

            await ETTask.CompletedTask;
        }
    }
}