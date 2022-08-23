﻿using System;
using ET.EventType;
using UnityEngine;
using UnityEngine.Rendering;

namespace ET
{
    public class ChangePosition_SyncGameObjectPos: AEvent<EventType.ChangePosition>
    {
        protected override async void Run(EventType.ChangePosition args)
        {
            GameObjectComponent gameObjectComponent = args.Unit.GetComponent<GameObjectComponent>();
            if (gameObjectComponent == null)
            {
                return;
            }
            
            Transform transform = gameObjectComponent.GameObject.transform;
            transform.position = args.Unit.Position;
        
            SortingGroup sortingGroup = transform.GetComponent<SortingGroup>();
        
            if (sortingGroup == null)
            {
                return;
            }
        
            sortingGroup.sortingOrder = (int) -args.Unit.Position.y;
            
            await ETTask.CompletedTask;
        }
    }
}