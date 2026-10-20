using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E60")]
public class XUILobbyState_RankingRewardRecivePopup : XUILobbyState
{
	[Token(Token = "0x4004B65")]
	[FieldOffset(Offset = "0x1C")]
	private XWidget_RankingRewardPopup widgetRewardRecievePopup;

	[Token(Token = "0x17000DCC")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006B4C")]
		[Address(RVA = "0x10AA940", Offset = "0x10AA940", VA = "0x10AA940", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DCD")]
	public override bool IsPopup
	{
		[Token(Token = "0x6006B4E")]
		[Address(RVA = "0x10AAA54", Offset = "0x10AAA54", VA = "0x10AAA54", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000DCE")]
	private XGameModeType GameModeType
	{
		[Token(Token = "0x6006B50")]
		[Address(RVA = "0x10AAA64", Offset = "0x10AAA64", VA = "0x10AAA64")]
		get
		{
			return default(XGameModeType);
		}
	}

	[Token(Token = "0x17000DCF")]
	private RankType RankType
	{
		[Token(Token = "0x6006B51")]
		[Address(RVA = "0x10AAB98", Offset = "0x10AAB98", VA = "0x10AAB98")]
		get
		{
			return default(RankType);
		}
	}

	[Token(Token = "0x6006B4B")]
	[Address(RVA = "0x10AA938", Offset = "0x10AA938", VA = "0x10AA938")]
	public XUILobbyState_RankingRewardRecivePopup()
	{
	}

	[Token(Token = "0x6006B4D")]
	[Address(RVA = "0x10AAA38", Offset = "0x10AAA38", VA = "0x10AAA38", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006B4F")]
	[Address(RVA = "0x10AAA5C", Offset = "0x10AAA5C", VA = "0x10AAA5C", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006B52")]
	[Address(RVA = "0x10AACCC", Offset = "0x10AACCC", VA = "0x10AACCC", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006B53")]
	[Address(RVA = "0x10AAEF0", Offset = "0x10AAEF0", VA = "0x10AAEF0", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006B54")]
	[Address(RVA = "0x10AB39C", Offset = "0x10AB39C", VA = "0x10AB39C", Slot = "16")]
	public override void OnHide()
	{
	}
}
