using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000FB5")]
public class XWidget_OptionInfoTab : XUIBaseWidget
{
	[Token(Token = "0x2000FB6")]
	public class XLinkAccount
	{
		[Token(Token = "0x4005366")]
		[FieldOffset(Offset = "0x8")]
		private bool m_isProcessed;

		[Token(Token = "0x4005367")]
		[FieldOffset(Offset = "0x9")]
		private bool m_bRequestUserInfo;

		[Token(Token = "0x4005368")]
		[FieldOffset(Offset = "0x0")]
		private static NetCallback _003C_003Ef__am_0024cache2;

		[Token(Token = "0x4005369")]
		[FieldOffset(Offset = "0x4")]
		private static Action _003C_003Ef__am_0024cache3;

		[Token(Token = "0x17000ED5")]
		private bool IsDone
		{
			[Token(Token = "0x6007502")]
			[Address(RVA = "0x130D55C", Offset = "0x130D55C", VA = "0x130D55C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6007501")]
		[Address(RVA = "0x1309F80", Offset = "0x1309F80", VA = "0x1309F80")]
		public XLinkAccount()
		{
		}

		[Token(Token = "0x6007503")]
		[Address(RVA = "0x130B7AC", Offset = "0x130B7AC", VA = "0x130B7AC")]
		public void Work()
		{
		}

		[Token(Token = "0x6007504")]
		[Address(RVA = "0x130CE34", Offset = "0x130CE34", VA = "0x130CE34")]
		public void Update()
		{
		}

		[Token(Token = "0x6007505")]
		[Address(RVA = "0x130D800", Offset = "0x130D800", VA = "0x130D800")]
		private void SendLinkAccountProcess()
		{
		}

		[Token(Token = "0x6007506")]
		[Address(RVA = "0x130DBD0", Offset = "0x130DBD0", VA = "0x130DBD0")]
		private static void _003CSendLinkAccountProcess_003Em__4CC(ApiReturnCode errno, string errmsg, JObject json)
		{
		}

		[Token(Token = "0x6007507")]
		[Address(RVA = "0x130E0AC", Offset = "0x130E0AC", VA = "0x130E0AC")]
		private static void _003CSendLinkAccountProcess_003Em__4CD()
		{
		}
	}

	[Token(Token = "0x2000FB7")]
	private sealed class _003CShowLeaveAccountPopup_003Ec__AnonStorey244
	{
		[Token(Token = "0x400536A")]
		[FieldOffset(Offset = "0x8")]
		internal string strTerminateInput;

		[Token(Token = "0x400536B")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_OptionInfoTab _003C_003Ef__this;

		[Token(Token = "0x6007508")]
		[Address(RVA = "0x130C558", Offset = "0x130C558", VA = "0x130C558")]
		public _003CShowLeaveAccountPopup_003Ec__AnonStorey244()
		{
		}

		[Token(Token = "0x6007509")]
		[Address(RVA = "0x130D2EC", Offset = "0x130D2EC", VA = "0x130D2EC")]
		internal void _003C_003Em__4CA(string strInputText)
		{
		}
	}

	[Token(Token = "0x400534C")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject GoogleLinkAccountInfo;

	[Token(Token = "0x400534D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject FacebookLinkAccountInfo;

	[Token(Token = "0x400534E")]
	[FieldOffset(Offset = "0x24")]
	public GameObject GuestLinkAccountInfo;

	[Token(Token = "0x400534F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject NXComLinkAccountInfo;

	[Token(Token = "0x4005350")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject btnLinkAccount;

	[Token(Token = "0x4005351")]
	[FieldOffset(Offset = "0x30")]
	public GameObject btnLogout;

	[Token(Token = "0x4005352")]
	[FieldOffset(Offset = "0x34")]
	public GameObject btnPlatformConnect;

	[Token(Token = "0x4005353")]
	[FieldOffset(Offset = "0x38")]
	public GameObject btnPlatformDisconnect;

	[Token(Token = "0x4005354")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject btnGoogleAchievement;

	[Token(Token = "0x4005355")]
	[FieldOffset(Offset = "0x40")]
	public UIGrid ButtonGrid1;

	[Token(Token = "0x4005356")]
	[FieldOffset(Offset = "0x44")]
	public GameObject btnCoupon;

	[Token(Token = "0x4005357")]
	[FieldOffset(Offset = "0x48")]
	public XWidget_Button btnRestore;

	[Token(Token = "0x4005358")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel lblGameVersion;

	[Token(Token = "0x4005359")]
	[FieldOffset(Offset = "0x50")]
	public UILabel lblNPACode;

	[Token(Token = "0x400535A")]
	[FieldOffset(Offset = "0x54")]
	public Transform parentRegionBtn;

	[Token(Token = "0x400535B")]
	[FieldOffset(Offset = "0x58")]
	private XWidget_RegionButton regionBtn;

	[Token(Token = "0x400535C")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_isStartLinkAccount;

	[Token(Token = "0x400535D")]
	[FieldOffset(Offset = "0x60")]
	private XLinkAccount m_LinkAccount;

	[Token(Token = "0x400535E")]
	[FieldOffset(Offset = "0x64")]
	public GameObject btnLeaveAccount;

	[Token(Token = "0x400535F")]
	[FieldOffset(Offset = "0x68")]
	private readonly string Path_Credit;

	[Token(Token = "0x4005360")]
	[FieldOffset(Offset = "0x6C")]
	public Transform creditRoot;

	[Token(Token = "0x4005361")]
	[FieldOffset(Offset = "0x70")]
	private GameObject _pnlCredit;

	[Token(Token = "0x4005362")]
	[FieldOffset(Offset = "0x74")]
	private TweenPosition tweenPositionCredit;

	[Token(Token = "0x4005363")]
	[FieldOffset(Offset = "0x78")]
	public GameObject btnPayInfo;

	[Token(Token = "0x4005364")]
	[FieldOffset(Offset = "0x7C")]
	private XWidget_PayInfo _widgetPayInfo;

	[Token(Token = "0x4005365")]
	[FieldOffset(Offset = "0x80")]
	private readonly string Path_PayInfo;

	[Token(Token = "0x17000ED3")]
	public XWidget_PayInfo widgetPayInfo
	{
		[Token(Token = "0x60074E4")]
		[Address(RVA = "0x1309F88", Offset = "0x1309F88", VA = "0x1309F88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ED4")]
	public GameObject PnlCredit
	{
		[Token(Token = "0x60074E5")]
		[Address(RVA = "0x130A088", Offset = "0x130A088", VA = "0x130A088")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074E3")]
	[Address(RVA = "0x1309EBC", Offset = "0x1309EBC", VA = "0x1309EBC")]
	public XWidget_OptionInfoTab()
	{
	}

	[Token(Token = "0x60074E6")]
	[Address(RVA = "0x130A218", Offset = "0x130A218", VA = "0x130A218")]
	private bool IsHideCoupon()
	{
		return default(bool);
	}

	[Token(Token = "0x60074E7")]
	[Address(RVA = "0x130A300", Offset = "0x130A300", VA = "0x130A300")]
	public void BuildTab()
	{
	}

	[Token(Token = "0x60074E8")]
	[Address(RVA = "0x130ADCC", Offset = "0x130ADCC", VA = "0x130ADCC")]
	public void Show()
	{
	}

	[Token(Token = "0x60074E9")]
	[Address(RVA = "0x130AAE4", Offset = "0x130AAE4", VA = "0x130AAE4")]
	private void BuildServerReigon()
	{
	}

	[Token(Token = "0x60074EA")]
	[Address(RVA = "0x130AC88", Offset = "0x130AC88", VA = "0x130AC88")]
	private void BuildPayInfoButton()
	{
	}

	[Token(Token = "0x60074EB")]
	[Address(RVA = "0x130AE28", Offset = "0x130AE28", VA = "0x130AE28")]
	private void RefreshPlatformButton()
	{
	}

	[Token(Token = "0x60074EC")]
	[Address(RVA = "0x130A6B0", Offset = "0x130A6B0", VA = "0x130A6B0")]
	private void RefreshLinkAccount()
	{
	}

	[Token(Token = "0x60074ED")]
	[Address(RVA = "0x130B344", Offset = "0x130B344", VA = "0x130B344")]
	private void Logout()
	{
	}

	[Token(Token = "0x60074EE")]
	[Address(RVA = "0x130B410", Offset = "0x130B410", VA = "0x130B410")]
	public void OnClickLogout()
	{
	}

	[Token(Token = "0x60074EF")]
	[Address(RVA = "0x130B624", Offset = "0x130B624", VA = "0x130B624")]
	public void OnClickLinkAccount()
	{
	}

	[Token(Token = "0x60074F0")]
	[Address(RVA = "0x130B7C0", Offset = "0x130B7C0", VA = "0x130B7C0")]
	public void OnClickPlatformConnect()
	{
	}

	[Token(Token = "0x60074F1")]
	[Address(RVA = "0x130B940", Offset = "0x130B940", VA = "0x130B940")]
	public void OnClickPlatformDisconnect()
	{
	}

	[Token(Token = "0x60074F2")]
	[Address(RVA = "0x130BAC0", Offset = "0x130BAC0", VA = "0x130BAC0")]
	public void OnClickPlatformLogout()
	{
	}

	[Token(Token = "0x60074F3")]
	[Address(RVA = "0x130BC40", Offset = "0x130BC40", VA = "0x130BC40")]
	public void OnButtonClick_OpenCredit()
	{
	}

	[Token(Token = "0x60074F4")]
	[Address(RVA = "0x130BC70", Offset = "0x130BC70", VA = "0x130BC70")]
	public void OnButtonClick_CloseCredit()
	{
	}

	[Token(Token = "0x60074F5")]
	[Address(RVA = "0x130BDAC", Offset = "0x130BDAC", VA = "0x130BDAC")]
	public void OnButtonClick_OpenCustomerCenter()
	{
	}

	[Token(Token = "0x60074F6")]
	[Address(RVA = "0x130BEA4", Offset = "0x130BEA4", VA = "0x130BEA4")]
	public void OnButtonClick_Coupon()
	{
	}

	[Token(Token = "0x60074F7")]
	[Address(RVA = "0x130BF70", Offset = "0x130BF70", VA = "0x130BF70")]
	public void OnButtonClick_OpenHelp()
	{
	}

	[Token(Token = "0x60074F8")]
	[Address(RVA = "0x130C07C", Offset = "0x130C07C", VA = "0x130C07C")]
	public void OnButtonClick_LeaveAccount()
	{
	}

	[Token(Token = "0x60074F9")]
	[Address(RVA = "0x130C34C", Offset = "0x130C34C", VA = "0x130C34C")]
	private void ShowLeaveAccountPopup()
	{
	}

	[Token(Token = "0x60074FA")]
	[Address(RVA = "0x130C560", Offset = "0x130C560", VA = "0x130C560")]
	private void NetProcessLeaveAccount()
	{
	}

	[Token(Token = "0x60074FB")]
	[Address(RVA = "0x130C738", Offset = "0x130C738", VA = "0x130C738")]
	public void OnButtonClick_BillingRestore()
	{
	}

	[Token(Token = "0x60074FC")]
	[Address(RVA = "0x130C828", Offset = "0x130C828", VA = "0x130C828")]
	private void ToyBilling_NotifyBillingRestore(object arg)
	{
	}

	[Token(Token = "0x60074FD")]
	[Address(RVA = "0x130C93C", Offset = "0x130C93C", VA = "0x130C93C")]
	public void OnButtonClick_PayInfo()
	{
	}

	[Token(Token = "0x60074FE")]
	[Address(RVA = "0x130CDE4", Offset = "0x130CDE4", VA = "0x130CDE4")]
	private void Update()
	{
	}

	[Token(Token = "0x60074FF")]
	[Address(RVA = "0x130CE64", Offset = "0x130CE64", VA = "0x130CE64")]
	private void _003COnClickLogout_003Em__4C9()
	{
	}

	[Token(Token = "0x6007500")]
	[Address(RVA = "0x130CE68", Offset = "0x130CE68", VA = "0x130CE68")]
	private void _003CNetProcessLeaveAccount_003Em__4CB(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
