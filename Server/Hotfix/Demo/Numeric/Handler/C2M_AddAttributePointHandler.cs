﻿using System;

namespace ET
{
    public class C2M_AddAttributePointHandler :AMActorLocationRpcHandler<Unit, C2M_AddAttributePoint, M2C_AddAttributePoint>
    {
        protected override async ETTask Run(Unit unit, C2M_AddAttributePoint request, M2C_AddAttributePoint response, Action reply)
        {
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            int targetNumericType = request.NumericType;

            if (!PlayerNumericConfigCategory.Instance.Contain(targetNumericType))
            {
                response.Error = ErrorCode.ERR_NumericTypeNotExist;
                reply();
                return;
            }

            PlayerNumericConfig config = PlayerNumericConfigCategory.Instance.Get(targetNumericType);
            if (config.isAddPoint == 0)
            {
                response.Error = ErrorCode.ERR_NumericTypeNotAddPoint;
                reply();
                return;
            }

            int attributePointCount = numericComponent.GetAsInt(NumericType.AttributePoint);

            if (attributePointCount <= 0)
            {
                response.Error = ErrorCode.ERR_AddPointNotEnough;
                reply();
                return;
            }

            --attributePointCount;
            numericComponent.Set(NumericType.AttributePoint, attributePointCount);

            int targetAttributeCount = numericComponent.GetAsInt(targetNumericType) + 1;
            numericComponent.Set(targetNumericType, targetAttributeCount);

            //await numericComponent.AddOrUpdateUnitCache();
            await ETTask.CompletedTask;
            reply();
        }
    }
}