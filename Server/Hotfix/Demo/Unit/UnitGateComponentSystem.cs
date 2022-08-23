namespace ET
{
    public class UnitGateComponentAwakeSystem : AwakeSystem<UnitGateComponent, long>
    {
        public override void Awake(UnitGateComponent self, long a)
        {
            self.GateSessionActorId = a;
        }
    }
    
    public static class UnitGateComponentSystem
    {
        
    }
}