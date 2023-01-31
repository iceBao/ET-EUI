﻿namespace ET
{
    public class AdventureCheckComponentDestroySystem: DestroySystem<AdventureCheckComponent>
    {
        public override void Destroy(AdventureCheckComponent self)
        {
            self.ResetAdventureInfo();
        }
    }

    [FriendClass(typeof(AdventureCheckComponent))]
    public static class AdventureCheckComponentSystem
    {
        public static bool CheckBattleWinResult(this AdventureCheckComponent self, int battleRound)
        {
            self.ResetAdventureInfo();

            NumericComponent numericComponent = self.GetParent<Unit>().GetComponent<NumericComponent>();
            int levelId = numericComponent.GetAsInt(NumericType.AdventureState);
            // 模拟对战
            bool isSimulationNormal = self.SimulationBattle(levelId, battleRound);

            if (!isSimulationNormal)
            {
                Log.Error("模拟对战失败");
                return false;
            }
            
            //判断角色是否能在战斗中存活
            if (self.MonsterTotalDamage >= numericComponent.GetAsInt(NumericType.MaxHp))
            {
                Log.Error("角色无法存活");
                return false;
            }


            if (self.UnitTtalDamage < self.TotalMonsterHp)
            {
                Log.Error("角色伤害不足");
                return false;
            }
            
            //判定战斗动画时间是否正常
            long playAnimatinonTime = TimeHelper.ServerNow() - numericComponent.GetAsLong(NumericType.AdventureStartTime);
            if (playAnimatinonTime < self.AnimationTotalTime)
            {
                Log.Error("动画时间不足");
                return false;
            }

            return true;
        }

        public static void ResetAdventureInfo(this AdventureCheckComponent self)
        {
            self.Round = 0;
            self.AnimationTotalTime = 0;
            self.MonsterTotalDamage = 0;
            self.UnitTtalDamage = 0;
            self.TotalMonsterHp = 0;
            self.EnemyHpDictionary.Clear();
        }

        public static bool SimulationBattle(this AdventureCheckComponent self, int levelId, int battleRound)
        {
            // 创建怪物信息
            BattleLevelConfig battleLevelConfig = BattleLevelConfigCategory.Instance.Get(levelId);
            for (int i = 0; i < battleLevelConfig.MonsterIds.Length; i++)
            {
                UnitConfig unitConfig = UnitConfigCategory.Instance.Get(battleLevelConfig.MonsterIds[i]);
                self.EnemyHpDictionary.Add(i,unitConfig.MaxHP);
                self.TotalMonsterHp += unitConfig.MaxHP;
            }
            
            //开始模拟对战
            for (int i = 0; i < battleRound; i++)
            {
                if (self.Round % 2 == 0)
                {
                    //玩家回合
                    int targetIndex = self.GetFirstAliveEnemyIndex(levelId);
                    if (targetIndex < 0)
                    {
                        Log.Error($"targetIndex error: {targetIndex}");
                        return false;
                    }

                    int damage = self.GetParent<Unit>().GetComponent<NumericComponent>().GetAsInt(NumericType.DamageValue);
                    self.EnemyHpDictionary[targetIndex] -= damage;
                    self.UnitTtalDamage += damage;
                    self.AnimationTotalTime += 1000;
                }
                else
                {
                    //敌人回合
                    for (int j = 0; j < battleLevelConfig.MonsterIds.Length; j++)
                    {
                        if (self.EnemyHpDictionary[j] <= 0)
                        {
                            continue;
                        }

                        self.MonsterTotalDamage += UnitConfigCategory.Instance.Get(battleLevelConfig.MonsterIds[j]).DamageValue;
                        self.AnimationTotalTime += 1000;
                    }

                    ++self.Round;
                }
            }

            return true;
        }

        public static int GetFirstAliveEnemyIndex(this AdventureCheckComponent self, int levelId)
        {
            BattleLevelConfig battleLevelConfig = BattleLevelConfigCategory.Instance.Get(levelId);
            for (int i = 0; i < battleLevelConfig.MonsterIds.Length; i++)
            {
                if (self.EnemyHpDictionary[i] > 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}