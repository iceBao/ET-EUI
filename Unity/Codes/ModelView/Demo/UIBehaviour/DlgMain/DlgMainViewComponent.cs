
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ComponentOf(typeof(UIBaseWindow))]
	[EnableMethod]
	public  class DlgMainViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.Text E_RoleLevelText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_RoleLevelText == null )
     			{
		    		this.m_E_RoleLevelText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"image/E_RoleLevel");
     			}
     			return this.m_E_RoleLevelText;
     		}
     	}

		public UnityEngine.UI.Image E_HeadImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_HeadImage == null )
     			{
		    		this.m_E_HeadImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"image/E_Head");
     			}
     			return this.m_E_HeadImage;
     		}
     	}

		public UnityEngine.UI.Text E_GoldText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_GoldText == null )
     			{
		    		this.m_E_GoldText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"image/E_Gold");
     			}
     			return this.m_E_GoldText;
     		}
     	}

		public UnityEngine.UI.Text E_ExpText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ExpText == null )
     			{
		    		this.m_E_ExpText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"image/E_Exp");
     			}
     			return this.m_E_ExpText;
     		}
     	}

		public UnityEngine.UI.Button EButton_PlayerButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_PlayerButton == null )
     			{
		    		this.m_EButton_PlayerButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EButton_Player");
     			}
     			return this.m_EButton_PlayerButton;
     		}
     	}

		public UnityEngine.UI.Image EButton_PlayerImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_PlayerImage == null )
     			{
		    		this.m_EButton_PlayerImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EButton_Player");
     			}
     			return this.m_EButton_PlayerImage;
     		}
     	}

		public UnityEngine.UI.Text ELabel_PlayerText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELabel_PlayerText == null )
     			{
		    		this.m_ELabel_PlayerText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"EButton_Player/ELabel_Player");
     			}
     			return this.m_ELabel_PlayerText;
     		}
     	}

		public UnityEngine.UI.Button EButton_StrengthenButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_StrengthenButton == null )
     			{
		    		this.m_EButton_StrengthenButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EButton_Strengthen");
     			}
     			return this.m_EButton_StrengthenButton;
     		}
     	}

		public UnityEngine.UI.Image EButton_StrengthenImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_StrengthenImage == null )
     			{
		    		this.m_EButton_StrengthenImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EButton_Strengthen");
     			}
     			return this.m_EButton_StrengthenImage;
     		}
     	}

		public UnityEngine.UI.Text ELabel_StrengthenText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELabel_StrengthenText == null )
     			{
		    		this.m_ELabel_StrengthenText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"EButton_Strengthen/ELabel_Strengthen");
     			}
     			return this.m_ELabel_StrengthenText;
     		}
     	}

		public UnityEngine.UI.Button EButton_AdventureButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_AdventureButton == null )
     			{
		    		this.m_EButton_AdventureButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EButton_Adventure");
     			}
     			return this.m_EButton_AdventureButton;
     		}
     	}

		public UnityEngine.UI.Image EButton_AdventureImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_AdventureImage == null )
     			{
		    		this.m_EButton_AdventureImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EButton_Adventure");
     			}
     			return this.m_EButton_AdventureImage;
     		}
     	}

		public UnityEngine.UI.Text ELabel_AdventureText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELabel_AdventureText == null )
     			{
		    		this.m_ELabel_AdventureText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"EButton_Adventure/ELabel_Adventure");
     			}
     			return this.m_ELabel_AdventureText;
     		}
     	}

		public UnityEngine.UI.Button EButton_TaskButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_TaskButton == null )
     			{
		    		this.m_EButton_TaskButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EButton_Task");
     			}
     			return this.m_EButton_TaskButton;
     		}
     	}

		public UnityEngine.UI.Image EButton_TaskImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_TaskImage == null )
     			{
		    		this.m_EButton_TaskImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EButton_Task");
     			}
     			return this.m_EButton_TaskImage;
     		}
     	}

		public UnityEngine.UI.Text ELabel_TaskText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELabel_TaskText == null )
     			{
		    		this.m_ELabel_TaskText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"EButton_Task/ELabel_Task");
     			}
     			return this.m_ELabel_TaskText;
     		}
     	}

		public UnityEngine.UI.Button EButton_ShopButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_ShopButton == null )
     			{
		    		this.m_EButton_ShopButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EButton_Shop");
     			}
     			return this.m_EButton_ShopButton;
     		}
     	}

		public UnityEngine.UI.Image EButton_ShopImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_EButton_ShopImage == null )
     			{
		    		this.m_EButton_ShopImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EButton_Shop");
     			}
     			return this.m_EButton_ShopImage;
     		}
     	}

		public UnityEngine.UI.Text ELabel_ShopText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELabel_ShopText == null )
     			{
		    		this.m_ELabel_ShopText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"EButton_Shop/ELabel_Shop");
     			}
     			return this.m_ELabel_ShopText;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_RoleLevelText = null;
			this.m_E_HeadImage = null;
			this.m_E_GoldText = null;
			this.m_E_ExpText = null;
			this.m_EButton_PlayerButton = null;
			this.m_EButton_PlayerImage = null;
			this.m_ELabel_PlayerText = null;
			this.m_EButton_StrengthenButton = null;
			this.m_EButton_StrengthenImage = null;
			this.m_ELabel_StrengthenText = null;
			this.m_EButton_AdventureButton = null;
			this.m_EButton_AdventureImage = null;
			this.m_ELabel_AdventureText = null;
			this.m_EButton_TaskButton = null;
			this.m_EButton_TaskImage = null;
			this.m_ELabel_TaskText = null;
			this.m_EButton_ShopButton = null;
			this.m_EButton_ShopImage = null;
			this.m_ELabel_ShopText = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Text m_E_RoleLevelText = null;
		private UnityEngine.UI.Image m_E_HeadImage = null;
		private UnityEngine.UI.Text m_E_GoldText = null;
		private UnityEngine.UI.Text m_E_ExpText = null;
		private UnityEngine.UI.Button m_EButton_PlayerButton = null;
		private UnityEngine.UI.Image m_EButton_PlayerImage = null;
		private UnityEngine.UI.Text m_ELabel_PlayerText = null;
		private UnityEngine.UI.Button m_EButton_StrengthenButton = null;
		private UnityEngine.UI.Image m_EButton_StrengthenImage = null;
		private UnityEngine.UI.Text m_ELabel_StrengthenText = null;
		private UnityEngine.UI.Button m_EButton_AdventureButton = null;
		private UnityEngine.UI.Image m_EButton_AdventureImage = null;
		private UnityEngine.UI.Text m_ELabel_AdventureText = null;
		private UnityEngine.UI.Button m_EButton_TaskButton = null;
		private UnityEngine.UI.Image m_EButton_TaskImage = null;
		private UnityEngine.UI.Text m_ELabel_TaskText = null;
		private UnityEngine.UI.Button m_EButton_ShopButton = null;
		private UnityEngine.UI.Image m_EButton_ShopImage = null;
		private UnityEngine.UI.Text m_ELabel_ShopText = null;
		public Transform uiTransform = null;
	}
}
