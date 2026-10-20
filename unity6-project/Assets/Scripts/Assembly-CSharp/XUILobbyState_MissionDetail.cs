using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E54")]
internal class XUILobbyState_MissionDetail : XUILobbyState
{
	[Token(Token = "0x4004B53")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_GameReadyView pnlGameReadyView;

	[Token(Token = "0x4004B54")]
	[FieldOffset(Offset = "0x20")]
	private XGameModeType gameModeType;

	[Token(Token = "0x17000DBC")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006AD2")]
		[Address(RVA = "0x10A531C", Offset = "0x10A531C", VA = "0x10A531C", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006AD1")]
	[Address(RVA = "0x10A5314", Offset = "0x10A5314", VA = "0x10A5314")]
	public XUILobbyState_MissionDetail()
	{
	}

	[Token(Token = "0x6006AD3")]
	[Address(RVA = "0x10A5414", Offset = "0x10A5414", VA = "0x10A5414", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006AD4")]
	[Address(RVA = "0x10A541C", Offset = "0x10A541C", VA = "0x10A541C", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006AD5")]
	[Address(RVA = "0x10A54C0", Offset = "0x10A54C0", VA = "0x10A54C0", Slot = "12")]
	public override LobbyBackground GetLobbyBackgroundType()
	{
		return default(LobbyBackground);
	}

	[Token(Token = "0x6006AD6")]
	[Address(RVA = "0x10A54C8", Offset = "0x10A54C8", VA = "0x10A54C8", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006AD7")]
	[Address(RVA = "0x10A5520", Offset = "0x10A5520", VA = "0x10A5520", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006AD8")]
	[Address(RVA = "0x10A5540", Offset = "0x10A5540", VA = "0x10A5540", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006AD9")]
	[Address(RVA = "0x10A5610", Offset = "0x10A5610", VA = "0x10A5610", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006ADA")]
	[Address(RVA = "0x10A588C", Offset = "0x10A588C", VA = "0x10A588C", Slot = "16")]
	public override void OnHide()
	{
	}
}
