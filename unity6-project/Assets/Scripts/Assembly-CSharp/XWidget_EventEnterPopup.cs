using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000EAE")]
public class XWidget_EventEnterPopup : XUIBaseWidget
{
	[Token(Token = "0x4004D17")]
	[FieldOffset(Offset = "0x1C")]
	private UIPanel m_panel;

	[Token(Token = "0x4004D18")]
	[FieldOffset(Offset = "0x20")]
	public XWidget_EventRewardPopup firstReward;

	[Token(Token = "0x4004D19")]
	[FieldOffset(Offset = "0x24")]
	public XWidget_EventRewardPopup milestoneReward;

	[Token(Token = "0x4004D1A")]
	[FieldOffset(Offset = "0x28")]
	public UITable costTable;

	[Token(Token = "0x4004D1B")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblCost;

	[Token(Token = "0x4004D1C")]
	[FieldOffset(Offset = "0x30")]
	public UI2DSprite sprCost;

	[Token(Token = "0x4004D1D")]
	[FieldOffset(Offset = "0x34")]
	private Action onRefresh;

	[Token(Token = "0x4004D1E")]
	[FieldOffset(Offset = "0x38")]
	private EventGameModeInfo eventModeInfo;

	[Token(Token = "0x4004D1F")]
	[FieldOffset(Offset = "0x3C")]
	private bool isFreeEnter;

	[Token(Token = "0x4004D20")]
	[FieldOffset(Offset = "0x40")]
	public XWidget_Button btnOK;

	[Token(Token = "0x17000DFC")]
	public UIPanel Panel
	{
		[Token(Token = "0x6006D70")]
		[Address(RVA = "0x15FAADC", Offset = "0x15FAADC", VA = "0x15FAADC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006D6F")]
	[Address(RVA = "0x15FAAD4", Offset = "0x15FAAD4", VA = "0x15FAAD4")]
	public XWidget_EventEnterPopup()
	{
	}

	[Token(Token = "0x6006D71")]
	[Address(RVA = "0x15FABC4", Offset = "0x15FABC4", VA = "0x15FABC4")]
	public void Show(EventGameModeClearRecord record, EventGameModeInfo eventModeInfo, EventGameRewardGroup rewardGroupInfo, Action refresh)
	{
	}

	[Token(Token = "0x6006D72")]
	[Address(RVA = "0x15FB130", Offset = "0x15FB130", VA = "0x15FB130")]
	private void ShowNotiNotOpenTime()
	{
	}

	[Token(Token = "0x6006D73")]
	[Address(RVA = "0x15FB26C", Offset = "0x15FB26C", VA = "0x15FB26C")]
	public void RequestPayEvnetModeOpenCost()
	{
	}

	[Token(Token = "0x6006D74")]
	[Address(RVA = "0x15FB5A4", Offset = "0x15FB5A4", VA = "0x15FB5A4")]
	private void _003CRequestPayEvnetModeOpenCost_003Em__407(ApiReturnCode nErrorCode, string strErrorMessage, JObject jsonData)
	{
	}
}
