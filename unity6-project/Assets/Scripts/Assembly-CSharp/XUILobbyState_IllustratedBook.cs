using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E4C")]
public class XUILobbyState_IllustratedBook : XUILobbyState
{
	[Token(Token = "0x4004B49")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_IllustratedBook pnlIllustratedBook;

	[Token(Token = "0x17000DB3")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006A82")]
		[Address(RVA = "0x10A2238", Offset = "0x10A2238", VA = "0x10A2238", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006A81")]
	[Address(RVA = "0x10A2230", Offset = "0x10A2230", VA = "0x10A2230")]
	public XUILobbyState_IllustratedBook()
	{
	}

	[Token(Token = "0x6006A83")]
	[Address(RVA = "0x10A2320", Offset = "0x10A2320", VA = "0x10A2320", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006A84")]
	[Address(RVA = "0x10A2328", Offset = "0x10A2328", VA = "0x10A2328", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006A85")]
	[Address(RVA = "0x10A23AC", Offset = "0x10A23AC", VA = "0x10A23AC", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006A86")]
	[Address(RVA = "0x10A2404", Offset = "0x10A2404", VA = "0x10A2404", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006A87")]
	[Address(RVA = "0x10A2420", Offset = "0x10A2420", VA = "0x10A2420", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006A88")]
	[Address(RVA = "0x10A24E4", Offset = "0x10A24E4", VA = "0x10A24E4", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006A89")]
	[Address(RVA = "0x10A2630", Offset = "0x10A2630", VA = "0x10A2630", Slot = "16")]
	public override void OnHide()
	{
	}
}
