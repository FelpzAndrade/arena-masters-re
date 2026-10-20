using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E4E")]
public class XUILobbyState_LadderMain : XUILobbyState
{
	[Token(Token = "0x4004B4B")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_LadderMain pnlLadderMain;

	[Token(Token = "0x4004B4C")]
	[FieldOffset(Offset = "0x20")]
	private bool m_firstShow;

	[Token(Token = "0x17000DB5")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006A96")]
		[Address(RVA = "0x10A2B00", Offset = "0x10A2B00", VA = "0x10A2B00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006A91")]
	[Address(RVA = "0x10A2A0C", Offset = "0x10A2A0C", VA = "0x10A2A0C")]
	public XUILobbyState_LadderMain()
	{
	}

	[Token(Token = "0x6006A92")]
	[Address(RVA = "0x10A2A14", Offset = "0x10A2A14", VA = "0x10A2A14", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006A93")]
	[Address(RVA = "0x10A2A1C", Offset = "0x10A2A1C", VA = "0x10A2A1C", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006A94")]
	[Address(RVA = "0x10A2AA0", Offset = "0x10A2AA0", VA = "0x10A2AA0", Slot = "12")]
	public override LobbyBackground GetLobbyBackgroundType()
	{
		return default(LobbyBackground);
	}

	[Token(Token = "0x6006A95")]
	[Address(RVA = "0x10A2AA8", Offset = "0x10A2AA8", VA = "0x10A2AA8", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006A97")]
	[Address(RVA = "0x10A2BF8", Offset = "0x10A2BF8", VA = "0x10A2BF8", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006A98")]
	[Address(RVA = "0x10A2C18", Offset = "0x10A2C18", VA = "0x10A2C18", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006A99")]
	[Address(RVA = "0x10A2D38", Offset = "0x10A2D38", VA = "0x10A2D38", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006A9A")]
	[Address(RVA = "0x10A2D94", Offset = "0x10A2D94", VA = "0x10A2D94", Slot = "15")]
	public override void OnPop()
	{
	}

	[Token(Token = "0x6006A9B")]
	[Address(RVA = "0x10A2D98", Offset = "0x10A2D98", VA = "0x10A2D98", Slot = "16")]
	public override void OnHide()
	{
	}
}
