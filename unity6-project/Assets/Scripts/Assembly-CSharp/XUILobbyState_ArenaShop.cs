using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E3F")]
internal class XUILobbyState_ArenaShop : XUILobbyState
{
	[Token(Token = "0x17000DAC")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006A11")]
		[Address(RVA = "0x109CF30", Offset = "0x109CF30", VA = "0x109CF30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006A0F")]
	[Address(RVA = "0x109CF20", Offset = "0x109CF20", VA = "0x109CF20")]
	public XUILobbyState_ArenaShop()
	{
	}

	[Token(Token = "0x6006A10")]
	[Address(RVA = "0x109CF28", Offset = "0x109CF28", VA = "0x109CF28", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006A12")]
	[Address(RVA = "0x109D028", Offset = "0x109D028", VA = "0x109D028", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006A13")]
	[Address(RVA = "0x109D0AC", Offset = "0x109D0AC", VA = "0x109D0AC", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006A14")]
	[Address(RVA = "0x109D348", Offset = "0x109D348", VA = "0x109D348", Slot = "16")]
	public override void OnHide()
	{
	}

	[Token(Token = "0x6006A15")]
	[Address(RVA = "0x109D3B0", Offset = "0x109D3B0", VA = "0x109D3B0", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}
}
