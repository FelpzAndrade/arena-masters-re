using System;
using Il2CppDummyDll;

[Token(Token = "0x2001060")]
public class XUIMgr_Title : XUIMgrBase
{
	[Token(Token = "0x4005872")]
	[FieldOffset(Offset = "0x0")]
	public static bool seeSplash;

	[Token(Token = "0x4005873")]
	[FieldOffset(Offset = "0x14")]
	private XPanel_Title m_pnlTitle;

	[Token(Token = "0x4005874")]
	[FieldOffset(Offset = "0x18")]
	private XPanel_Login m_pnlLogin;

	[Token(Token = "0x4005875")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_Splash m_pnlSplash;

	[Token(Token = "0x4005876")]
	[FieldOffset(Offset = "0x20")]
	private XPanel_TouchToPlay m_pnlTouchToPlay;

	[Token(Token = "0x4005877")]
	[FieldOffset(Offset = "0x24")]
	private XPanel_PatchOpening m_pnlPatchOpening;

	[Token(Token = "0x4005878")]
	[FieldOffset(Offset = "0x28")]
	private XPanel_Refund m_pnlRefundPopup;

	[Token(Token = "0x17000F41")]
	private XPanel_Title pnlTitle
	{
		[Token(Token = "0x6007BA3")]
		[Address(RVA = "0x10CF8C4", Offset = "0x10CF8C4", VA = "0x10CF8C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F42")]
	private XPanel_Login pnlLogin
	{
		[Token(Token = "0x6007BA4")]
		[Address(RVA = "0x10CF9C0", Offset = "0x10CF9C0", VA = "0x10CF9C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F43")]
	private XPanel_Splash pnlSplash
	{
		[Token(Token = "0x6007BA5")]
		[Address(RVA = "0x10CFACC", Offset = "0x10CFACC", VA = "0x10CFACC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F44")]
	private XPanel_TouchToPlay pnlTouchToPlay
	{
		[Token(Token = "0x6007BA6")]
		[Address(RVA = "0x10CFBE4", Offset = "0x10CFBE4", VA = "0x10CFBE4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F45")]
	private XPanel_PatchOpening pnlPatchOpening
	{
		[Token(Token = "0x6007BA7")]
		[Address(RVA = "0x10CFCF0", Offset = "0x10CFCF0", VA = "0x10CFCF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F46")]
	private XPanel_Refund pnlRefundPopup
	{
		[Token(Token = "0x6007BA8")]
		[Address(RVA = "0x10CFDEC", Offset = "0x10CFDEC", VA = "0x10CFDEC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007B9F")]
	[Address(RVA = "0x10B1EFC", Offset = "0x10B1EFC", VA = "0x10B1EFC")]
	public XUIMgr_Title()
	{
	}

	[Token(Token = "0x6007BA1")]
	[Address(RVA = "0x10CF824", Offset = "0x10CF824", VA = "0x10CF824", Slot = "4")]
	public override string GetPrefabPath()
	{
		return null;
	}

	[Token(Token = "0x6007BA2")]
	[Address(RVA = "0x10CF89C", Offset = "0x10CF89C", VA = "0x10CF89C", Slot = "6")]
	public override void Clear()
	{
	}

	[Token(Token = "0x6007BA9")]
	[Address(RVA = "0x10CFEE8", Offset = "0x10CFEE8", VA = "0x10CFEE8", Slot = "5")]
	public override void Init()
	{
	}

	[Token(Token = "0x6007BAA")]
	[Address(RVA = "0x10D0068", Offset = "0x10D0068", VA = "0x10D0068")]
	public void SplashInit(EventDelegate titleInit)
	{
	}

	[Token(Token = "0x6007BAB")]
	[Address(RVA = "0x10D003C", Offset = "0x10D003C", VA = "0x10D003C")]
	public void SplashHide()
	{
	}

	[Token(Token = "0x6007BAC")]
	[Address(RVA = "0x10D009C", Offset = "0x10D009C", VA = "0x10D009C")]
	public void TitleInit()
	{
	}

	[Token(Token = "0x6007BAD")]
	[Address(RVA = "0x10D00E4", Offset = "0x10D00E4", VA = "0x10D00E4")]
	public void RefreshRegionButtonText()
	{
	}

	[Token(Token = "0x6007BAE")]
	[Address(RVA = "0x10D023C", Offset = "0x10D023C", VA = "0x10D023C")]
	public bool ShowPatchOpening()
	{
		return default(bool);
	}

	[Token(Token = "0x6007BAF")]
	[Address(RVA = "0x10D0514", Offset = "0x10D0514", VA = "0x10D0514")]
	public void ChangeCompleteDownloadPatchOpening(Action onHideCallback)
	{
	}

	[Token(Token = "0x6007BB0")]
	[Address(RVA = "0x10D05F8", Offset = "0x10D05F8", VA = "0x10D05F8")]
	public void UpdatePatchOpening(float curPercent)
	{
	}

	[Token(Token = "0x6007BB1")]
	[Address(RVA = "0x10D06E4", Offset = "0x10D06E4", VA = "0x10D06E4", Slot = "11")]
	protected override void BackUpdateFunc()
	{
	}

	[Token(Token = "0x6007BB2")]
	[Address(RVA = "0x10D0794", Offset = "0x10D0794", VA = "0x10D0794", Slot = "12")]
	protected override bool PreBackStateCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6007BB3")]
	[Address(RVA = "0x10D092C", Offset = "0x10D092C", VA = "0x10D092C", Slot = "13")]
	protected override void BackFunc()
	{
	}

	[Token(Token = "0x6007BB4")]
	[Address(RVA = "0x10D0A3C", Offset = "0x10D0A3C", VA = "0x10D0A3C")]
	public void ShowNetworkLoadingIcon(bool bshow)
	{
	}

	[Token(Token = "0x6007BB5")]
	[Address(RVA = "0x10D0BFC", Offset = "0x10D0BFC", VA = "0x10D0BFC")]
	private void ShowTouchScreen(bool bShow)
	{
	}

	[Token(Token = "0x6007BB6")]
	[Address(RVA = "0x10D0CEC", Offset = "0x10D0CEC", VA = "0x10D0CEC")]
	public void ShowTitleObject()
	{
	}

	[Token(Token = "0x6007BB7")]
	[Address(RVA = "0x10D0D18", Offset = "0x10D0D18", VA = "0x10D0D18")]
	public void ShowRegionPopup()
	{
	}

	[Token(Token = "0x6007BB8")]
	[Address(RVA = "0x10D0E00", Offset = "0x10D0E00", VA = "0x10D0E00")]
	public void ShowTouchToPlay()
	{
	}

	[Token(Token = "0x6007BB9")]
	[Address(RVA = "0x10D10A0", Offset = "0x10D10A0", VA = "0x10D10A0")]
	public void HideTouchToPlay()
	{
	}

	[Token(Token = "0x6007BBA")]
	[Address(RVA = "0x10D12AC", Offset = "0x10D12AC", VA = "0x10D12AC")]
	public void ShowLogin()
	{
	}

	[Token(Token = "0x6007BBB")]
	[Address(RVA = "0x10D12E8", Offset = "0x10D12E8", VA = "0x10D12E8")]
	public void RefreshLogin()
	{
	}

	[Token(Token = "0x6007BBC")]
	[Address(RVA = "0x10D1314", Offset = "0x10D1314", VA = "0x10D1314")]
	public void HideLogin()
	{
	}

	[Token(Token = "0x6007BBD")]
	[Address(RVA = "0x10D13FC", Offset = "0x10D13FC", VA = "0x10D13FC")]
	public void ShowRefundPopup()
	{
	}

	[Token(Token = "0x6007BBE")]
	[Address(RVA = "0x10D1428", Offset = "0x10D1428", VA = "0x10D1428")]
	public bool IsLoginButtonSelected()
	{
		return default(bool);
	}

	[Token(Token = "0x6007BBF")]
	[Address(RVA = "0x10D0FB0", Offset = "0x10D0FB0", VA = "0x10D0FB0")]
	public void SetEnableRegionChange(bool bEnable)
	{
	}
}
