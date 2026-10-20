using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E42")]
internal class XUILobbyState_CharMain : XUILobbyState
{
	[Token(Token = "0x4004B3E")]
	[FieldOffset(Offset = "0x1C")]
	private GameObject topBanner;

	[Token(Token = "0x4004B3F")]
	[FieldOffset(Offset = "0x20")]
	private XPanel_CharMain widget;

	[Token(Token = "0x6006A2A")]
	[Address(RVA = "0x109E7F8", Offset = "0x109E7F8", VA = "0x109E7F8")]
	public XUILobbyState_CharMain()
	{
	}

	[Token(Token = "0x6006A2B")]
	[Address(RVA = "0x109E800", Offset = "0x109E800", VA = "0x109E800", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006A2C")]
	[Address(RVA = "0x109E808", Offset = "0x109E808", VA = "0x109E808", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006A2D")]
	[Address(RVA = "0x109E88C", Offset = "0x109E88C", VA = "0x109E88C", Slot = "12")]
	public override LobbyBackground GetLobbyBackgroundType()
	{
		return default(LobbyBackground);
	}

	[Token(Token = "0x6006A2E")]
	[Address(RVA = "0x109E894", Offset = "0x109E894", VA = "0x109E894", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006A2F")]
	[Address(RVA = "0x109E8B4", Offset = "0x109E8B4", VA = "0x109E8B4", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006A30")]
	[Address(RVA = "0x109E984", Offset = "0x109E984", VA = "0x109E984", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006A31")]
	[Address(RVA = "0x109ECEC", Offset = "0x109ECEC", VA = "0x109ECEC", Slot = "16")]
	public override void OnHide()
	{
	}
}
