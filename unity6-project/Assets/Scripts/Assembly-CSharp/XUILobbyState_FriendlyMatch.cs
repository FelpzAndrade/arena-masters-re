using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E48")]
public class XUILobbyState_FriendlyMatch : XUILobbyState
{
	[Token(Token = "0x4004B45")]
	[FieldOffset(Offset = "0x1C")]
	private Xpanel_FriendlyMatchRoomList pnlFriendlyMatchRoomList;

	[Token(Token = "0x17000DB0")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006A5F")]
		[Address(RVA = "0x10A0640", Offset = "0x10A0640", VA = "0x10A0640", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006A5D")]
	[Address(RVA = "0x10A0630", Offset = "0x10A0630", VA = "0x10A0630")]
	public XUILobbyState_FriendlyMatch()
	{
	}

	[Token(Token = "0x6006A5E")]
	[Address(RVA = "0x10A0638", Offset = "0x10A0638", VA = "0x10A0638", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006A60")]
	[Address(RVA = "0x10A0738", Offset = "0x10A0738", VA = "0x10A0738", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006A61")]
	[Address(RVA = "0x10A07BC", Offset = "0x10A07BC", VA = "0x10A07BC", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006A62")]
	[Address(RVA = "0x10A07D8", Offset = "0x10A07D8", VA = "0x10A07D8", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006A63")]
	[Address(RVA = "0x10A08F8", Offset = "0x10A08F8", VA = "0x10A08F8", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006A64")]
	[Address(RVA = "0x10A0950", Offset = "0x10A0950", VA = "0x10A0950", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006A65")]
	[Address(RVA = "0x10A0A9C", Offset = "0x10A0A9C", VA = "0x10A0A9C", Slot = "16")]
	public override void OnHide()
	{
	}
}
