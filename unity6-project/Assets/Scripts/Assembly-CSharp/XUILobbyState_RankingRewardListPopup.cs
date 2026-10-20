using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E5F")]
public class XUILobbyState_RankingRewardListPopup : XUILobbyState
{
	[Token(Token = "0x4004B64")]
	[FieldOffset(Offset = "0x1C")]
	private XWidget_RankRewardList widgetRewardListPopup;

	[Token(Token = "0x17000DC7")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006B41")]
		[Address(RVA = "0x10A9E68", Offset = "0x10A9E68", VA = "0x10A9E68", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DC8")]
	public override bool IsPopup
	{
		[Token(Token = "0x6006B43")]
		[Address(RVA = "0x10A9F7C", Offset = "0x10A9F7C", VA = "0x10A9F7C", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000DC9")]
	private XGameModeType GameModeType
	{
		[Token(Token = "0x6006B45")]
		[Address(RVA = "0x10A9F8C", Offset = "0x10A9F8C", VA = "0x10A9F8C")]
		get
		{
			return default(XGameModeType);
		}
	}

	[Token(Token = "0x17000DCA")]
	private RankType RankType
	{
		[Token(Token = "0x6006B46")]
		[Address(RVA = "0x10AA0C0", Offset = "0x10AA0C0", VA = "0x10AA0C0")]
		get
		{
			return default(RankType);
		}
	}

	[Token(Token = "0x17000DCB")]
	private ClanRankType ClanRankType
	{
		[Token(Token = "0x6006B47")]
		[Address(RVA = "0x10AA1F4", Offset = "0x10AA1F4", VA = "0x10AA1F4")]
		get
		{
			return default(ClanRankType);
		}
	}

	[Token(Token = "0x6006B40")]
	[Address(RVA = "0x10A9E60", Offset = "0x10A9E60", VA = "0x10A9E60")]
	public XUILobbyState_RankingRewardListPopup()
	{
	}

	[Token(Token = "0x6006B42")]
	[Address(RVA = "0x10A9F60", Offset = "0x10A9F60", VA = "0x10A9F60", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006B44")]
	[Address(RVA = "0x10A9F84", Offset = "0x10A9F84", VA = "0x10A9F84", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006B48")]
	[Address(RVA = "0x10AA328", Offset = "0x10AA328", VA = "0x10AA328", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006B49")]
	[Address(RVA = "0x10AA54C", Offset = "0x10AA54C", VA = "0x10AA54C", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006B4A")]
	[Address(RVA = "0x10AA858", Offset = "0x10AA858", VA = "0x10AA858", Slot = "16")]
	public override void OnHide()
	{
	}
}
