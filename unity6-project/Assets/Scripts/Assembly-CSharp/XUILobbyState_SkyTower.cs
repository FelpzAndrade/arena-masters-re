using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E63")]
public class XUILobbyState_SkyTower : XUILobbyState
{
	[Token(Token = "0x4004B6A")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_SkyTower pnlSkyTower;

	[Token(Token = "0x17000DD3")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006B6C")]
		[Address(RVA = "0x10AC5D8", Offset = "0x10AC5D8", VA = "0x10AC5D8", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006B6B")]
	[Address(RVA = "0x10AC5D0", Offset = "0x10AC5D0", VA = "0x10AC5D0")]
	public XUILobbyState_SkyTower()
	{
	}

	[Token(Token = "0x6006B6D")]
	[Address(RVA = "0x10AC6D0", Offset = "0x10AC6D0", VA = "0x10AC6D0", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006B6E")]
	[Address(RVA = "0x10AC6D8", Offset = "0x10AC6D8", VA = "0x10AC6D8", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006B6F")]
	[Address(RVA = "0x10AC774", Offset = "0x10AC774", VA = "0x10AC774", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006B70")]
	[Address(RVA = "0x10AC790", Offset = "0x10AC790", VA = "0x10AC790", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006B71")]
	[Address(RVA = "0x10AC860", Offset = "0x10AC860", VA = "0x10AC860", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006B72")]
	[Address(RVA = "0x10AC968", Offset = "0x10AC968", VA = "0x10AC968", Slot = "15")]
	public override void OnPop()
	{
	}

	[Token(Token = "0x6006B73")]
	[Address(RVA = "0x10AC99C", Offset = "0x10AC99C", VA = "0x10AC99C", Slot = "16")]
	public override void OnHide()
	{
	}
}
