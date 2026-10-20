using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E4B")]
public class XUILobbyState_Help : XUILobbyState
{
	[Token(Token = "0x4004B48")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_Help pnlHelp;

	[Token(Token = "0x17000DB2")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006A7A")]
		[Address(RVA = "0x10A1C4C", Offset = "0x10A1C4C", VA = "0x10A1C4C", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006A79")]
	[Address(RVA = "0x10A1C44", Offset = "0x10A1C44", VA = "0x10A1C44")]
	public XUILobbyState_Help()
	{
	}

	[Token(Token = "0x6006A7B")]
	[Address(RVA = "0x10A1D34", Offset = "0x10A1D34", VA = "0x10A1D34", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006A7C")]
	[Address(RVA = "0x10A1D3C", Offset = "0x10A1D3C", VA = "0x10A1D3C", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006A7D")]
	[Address(RVA = "0x10A1DC0", Offset = "0x10A1DC0", VA = "0x10A1DC0", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006A7E")]
	[Address(RVA = "0x10A1DDC", Offset = "0x10A1DDC", VA = "0x10A1DDC", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006A7F")]
	[Address(RVA = "0x10A1E90", Offset = "0x10A1E90", VA = "0x10A1E90", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006A80")]
	[Address(RVA = "0x10A2150", Offset = "0x10A2150", VA = "0x10A2150", Slot = "16")]
	public override void OnHide()
	{
	}
}
