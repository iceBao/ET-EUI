namespace ET
{
    public static class ItemHelper
    {
        public static void Clear(Scene zoneScene, ItemContainerType itemContainerType)
        {
            if (itemContainerType == ItemContainerType.Bag)
            {
                zoneScene?.GetComponent<BagComponent>()?.Clear();
            }
            else if (itemContainerType == ItemContainerType.RoleInfo)
            {
                zoneScene?.GetComponent<EquipmentsComponent>()?.Clear();
            }
        }
        
        public static Item GetItem(Scene zoneScene, long itemId, ItemContainerType itemContainerType)
        {
            if (itemContainerType == ItemContainerType.Bag)
            {
                return zoneScene.GetComponent<BagComponent>().GetItemById(itemId);
            }
            else if (itemContainerType == ItemContainerType.RoleInfo)
            {
                return zoneScene.GetComponent<EquipmentsComponent>().GetItemById(itemId);
            }
            
            return null;
        }

        public static void AddItem(Scene zoneScene, Item item, ItemContainerType itemContainerType)
        {
            if (itemContainerType == ItemContainerType.Bag)
            {
                zoneScene.GetComponent<BagComponent>().AddItem(item);
            }
            else if (itemContainerType == ItemContainerType.RoleInfo)
            {
                zoneScene.GetComponent<EquipmentsComponent>().AddEquipItem(item);
            }
        }

        public static void RemoveItemById(Scene zoneScene, long itemId, ItemContainerType itemContainerType)
        {
            Item item = GetItem(zoneScene, itemId, itemContainerType);
            if (itemContainerType == ItemContainerType.Bag)
            {
                zoneScene.GetComponent<BagComponent>().RemoveItem(item);
            }
            else if(itemContainerType == ItemContainerType.RoleInfo)
            {
                zoneScene.GetComponent<EquipmentsComponent>().UnloadEquipItem(item);
            }
        }

        public static void RemoveItem(Scene zoneScene, Item item, ItemContainerType itemContainerType)
        {
            if (itemContainerType == ItemContainerType.Bag)
            {
                zoneScene.GetComponent<BagComponent>().RemoveItem(item);
            }
            else if(itemContainerType == ItemContainerType.RoleInfo)
            {
                zoneScene.GetComponent<EquipmentsComponent>().UnloadEquipItem(item);
            }
        }
        
    }
}