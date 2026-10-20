using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E47")]
public class XUILobbyState_Friend : XUILobbyState
{
	[Token(Token = "0x4004B44")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_Friend pnlFriend;

	[Token(Token = "0x17000DAF")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006A57")]
		[Address(RVA = "0x109FFCC", Offset = "0x109FFCC", VA = "0x109FFCC", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006A55")]
	[Address(RVA = "0x109FFBC", Offset = "0x109FFBC", VA = "0x109FFBC")]
	public XUILobbyState_Friend()
	{
	}

	[Token(Token = "0x6006A56")]
	[Address(RVA = "0x109FFC4", Offset = "0x109FFC4", VA = "0x109FFC4", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006A58")]
	[Address(RVA = "0x10A00C4", Offset = "0x10A00C4", VA = "0x10A00C4", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006A59")]
	[Address(RVA = "0x10A0148", Offset = "0x10A0148", VA = "0x10A0148", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006A5A")]
	[Address(RVA = "0x10A0164", Offset = "0x10A0164", VA = "0x10A0164", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006A5B")]
	[Address(RVA = "0x10A0228", Offset = "0x10A0228", VA = "0x10A0228", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006A5C")]
	[Address(RVA = "0x10A0550", Offset = "0x10A0550", VA = "0x10A0550", Slot = "16")]
	public override void OnHide()
	{
	}
}
