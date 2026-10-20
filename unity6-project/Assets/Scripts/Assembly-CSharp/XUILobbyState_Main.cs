using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E52")]
public class XUILobbyState_Main : XUILobbyState
{
	[Token(Token = "0x4004B50")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_Main gameModeWindow;

	[Token(Token = "0x4004B51")]
	[FieldOffset(Offset = "0x20")]
	private XPanel_TopBanner topBanner;

	[Token(Token = "0x17000DBA")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006ABD")]
		[Address(RVA = "0x10A4510", Offset = "0x10A4510", VA = "0x10A4510", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DBB")]
	protected override bool ShowLobbyNotiIcons
	{
		[Token(Token = "0x6006ABE")]
		[Address(RVA = "0x10A45F8", Offset = "0x10A45F8", VA = "0x10A45F8", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6006ABC")]
	[Address(RVA = "0x10A4508", Offset = "0x10A4508", VA = "0x10A4508")]
	public XUILobbyState_Main()
	{
	}

	[Token(Token = "0x6006ABF")]
	[Address(RVA = "0x10A4600", Offset = "0x10A4600", VA = "0x10A4600", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006AC0")]
	[Address(RVA = "0x10A4608", Offset = "0x10A4608", VA = "0x10A4608", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006AC1")]
	[Address(RVA = "0x10A4610", Offset = "0x10A4610", VA = "0x10A4610", Slot = "12")]
	public override LobbyBackground GetLobbyBackgroundType()
	{
		return default(LobbyBackground);
	}

	[Token(Token = "0x6006AC2")]
	[Address(RVA = "0x10A4618", Offset = "0x10A4618", VA = "0x10A4618", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006AC3")]
	[Address(RVA = "0x10A4670", Offset = "0x10A4670", VA = "0x10A4670", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006AC4")]
	[Address(RVA = "0x10A4690", Offset = "0x10A4690", VA = "0x10A4690", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006AC5")]
	[Address(RVA = "0x10A47E4", Offset = "0x10A47E4", VA = "0x10A47E4", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006AC6")]
	[Address(RVA = "0x10A4B34", Offset = "0x10A4B34", VA = "0x10A4B34", Slot = "16")]
	public override void OnHide()
	{
	}
}
