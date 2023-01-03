namespace ET
{
    public static class ItemHelper
    {
        public static Item GetItem(Scene zoneScene, long itemId, ItemContainerType itemContainerType)
        {
            if (itemContainerType == ItemContainerType.Bag)
            {
                // TODO @zlb
                // return zoneScene.GetComponent<Bag>()
            }
            else if (itemContainerType == ItemContainerType.RoleInfo)
            {
                return zoneScene.GetComponent<EquipmentsComponent>().GetItemById(itemId);
            }
            return null;
        }
    }
}