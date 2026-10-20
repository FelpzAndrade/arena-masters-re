using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E5E")]
internal class XUILobbyState_Ranking : XUILobbyState
{
	[Token(Token = "0x4004B63")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_Ranking pnlRanking;

	[Token(Token = "0x17000DC6")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006B39")]
		[Address(RVA = "0x10A9938", Offset = "0x10A9938", VA = "0x10A9938", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006B36")]
	[Address(RVA = "0x10A98A4", Offset = "0x10A98A4", VA = "0x10A98A4")]
	public XUILobbyState_Ranking()
	{
	}

	[Token(Token = "0x6006B37")]
	[Address(RVA = "0x10A98AC", Offset = "0x10A98AC", VA = "0x10A98AC", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006B38")]
	[Address(RVA = "0x10A98B4", Offset = "0x10A98B4", VA = "0x10A98B4", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006B3A")]
	[Address(RVA = "0x10A9A30", Offset = "0x10A9A30", VA = "0x10A9A30", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006B3B")]
	[Address(RVA = "0x10A9A88", Offset = "0x10A9A88", VA = "0x10A9A88", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006B3C")]
	[Address(RVA = "0x10A9AA4", Offset = "0x10A9AA4", VA = "0x10A9AA4", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006B3D")]
	[Address(RVA = "0x10A9B84", Offset = "0x10A9B84", VA = "0x10A9B84", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006B3E")]
	[Address(RVA = "0x10A9D0C", Offset = "0x10A9D0C", VA = "0x10A9D0C", Slot = "15")]
	public override void OnPop()
	{
	}

	[Token(Token = "0x6006B3F")]
	[Address(RVA = "0x10A9D54", Offset = "0x10A9D54", VA = "0x10A9D54", Slot = "16")]
	public override void OnHide()
	{
	}
}
