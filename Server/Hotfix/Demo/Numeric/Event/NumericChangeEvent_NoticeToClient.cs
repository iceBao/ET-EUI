using ET.EventType;

namespace ET
{
    public class NumericChangeEvent_NoticeToClient : AEventClass<EventType.NumbericChange>
    {
        protected override void Run(object a)
        {
            NumbericChange args = a as NumbericChange;
            if (!(args.Parent is Unit unit))
            {
                return;
            }

            unit.GetComponent<NumericNoticeComponent>()?.NoticeImmediately(args);
        }
    }
}