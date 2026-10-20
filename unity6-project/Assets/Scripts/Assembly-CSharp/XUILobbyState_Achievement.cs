using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E3E")]
public class XUILobbyState_Achievement : XUILobbyState
{
	[Token(Token = "0x4004B39")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_Achievement pnlAchievement;

	[Token(Token = "0x17000DAB")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006A08")]
		[Address(RVA = "0x109CB4C", Offset = "0x109CB4C", VA = "0x109CB4C", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006A07")]
	[Address(RVA = "0x109CB44", Offset = "0x109CB44", VA = "0x109CB44")]
	public XUILobbyState_Achievement()
	{
	}

	[Token(Token = "0x6006A09")]
	[Address(RVA = "0x109CC34", Offset = "0x109CC34", VA = "0x109CC34", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006A0A")]
	[Address(RVA = "0x109CC3C", Offset = "0x109CC3C", VA = "0x109CC3C", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006A0B")]
	[Address(RVA = "0x109CCC0", Offset = "0x109CCC0", VA = "0x109CCC0", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006A0C")]
	[Address(RVA = "0x109CCDC", Offset = "0x109CCDC", VA = "0x109CCDC", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006A0D")]
	[Address(RVA = "0x109CDA0", Offset = "0x109CDA0", VA = "0x109CDA0", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006A0E")]
	[Address(RVA = "0x109CEEC", Offset = "0x109CEEC", VA = "0x109CEEC", Slot = "16")]
	public override void OnHide()
	{
	}
}
