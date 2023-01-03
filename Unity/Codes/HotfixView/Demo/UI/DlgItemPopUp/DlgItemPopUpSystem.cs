using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
	[FriendClass(typeof(DlgItemPopUp))]
	public static  class DlgItemPopUpSystem
	{

		public static void RegisterUIEvent(this DlgItemPopUp self)
		{
			self.RegisterCloseEvent<DlgItemPopUp>(self.View.E_CloseButton);
			self.View.E_EntrysLoopVerticalScrollRect.AddItemRefreshListener(self.OnEntryLoopHandler);
			self.View.E_EquipButton.AddListenerAsync(self.OnEquipItemHandler);
		}

		public static void ShowWindow(this DlgItemPopUp self, Entity contextData = null)
		{
		}

		public static void OnEntryLoopHandler(this DlgItemPopUp self, Transform transform, int index)
		{
			Scroll_Item_entry scrollItemEntry = self.ScrollItemEntries[index].BindTrans(transform);
			Item item = ItemHelper.GetItem(self.ZoneScene(), self.ItemId, self.ItemContainerType);
			AttributeEntry entry = item.GetComponent<EquipInfoComponent>().EntryList[index];
			scrollItemEntry.E_EntryNameText.text = PlayerNumericConfigCategory.Instance.Get(entry.Key).Name + ":";
			bool isPrecent = PlayerNumericConfigCategory.Instance.Get(entry.Key).isPrecent > 0;
			scrollItemEntry.E_EntryValueText.text = "+" + (isPrecent? $"{(entry.Value / 10000.0f).ToString("0.00")}%" : entry.Value.ToString());
		}

		public static async ETTask OnEquipItemHandler(this DlgItemPopUp self)
		{
			try
			{
				int errorCode = await ItemApplyHelper.EquipItem(self.ZoneScene(), self.ItemId);
				if (errorCode != ErrorCode.ERR_Success)
				{
					Log.Error(errorCode.ToString());
					return;
				}
				self.ZoneScene().GetComponent<UIComponent>().HideWindow(WindowID.WindowID_ItemPopUp);
				// self.ZoneScene().GetComponent<UIComponent>().GetDlgLogic<>()
			}
			catch (Exception e)
			{
				Log.Error(e.ToString());
			}
		}

	}
}
