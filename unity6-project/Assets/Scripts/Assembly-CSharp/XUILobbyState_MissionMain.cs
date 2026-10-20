using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E55")]
internal class XUILobbyState_MissionMain : XUILobbyState
{
	[Token(Token = "0x4004B55")]
	[FieldOffset(Offset = "0x1C")]
	private GameObject topBanner;

	[Token(Token = "0x4004B56")]
	[FieldOffset(Offset = "0x20")]
	private XPanel_MissionMain missionMain;

	[Token(Token = "0x4004B57")]
	[FieldOffset(Offset = "0x24")]
	private bool IsBuildComlete;

	[Token(Token = "0x17000DBD")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006ADC")]
		[Address(RVA = "0x10A59A0", Offset = "0x10A59A0", VA = "0x10A59A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006ADB")]
	[Address(RVA = "0x10A5998", Offset = "0x10A5998", VA = "0x10A5998")]
	public XUILobbyState_MissionMain()
	{
	}

	[Token(Token = "0x6006ADD")]
	[Address(RVA = "0x10A5A98", Offset = "0x10A5A98", VA = "0x10A5A98", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006ADE")]
	[Address(RVA = "0x10A5AA0", Offset = "0x10A5AA0", VA = "0x10A5AA0", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006ADF")]
	[Address(RVA = "0x10A5B3C", Offset = "0x10A5B3C", VA = "0x10A5B3C", Slot = "12")]
	public override LobbyBackground GetLobbyBackgroundType()
	{
		return default(LobbyBackground);
	}

	[Token(Token = "0x6006AE0")]
	[Address(RVA = "0x10A5B44", Offset = "0x10A5B44", VA = "0x10A5B44", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006AE1")]
	[Address(RVA = "0x10A5B64", Offset = "0x10A5B64", VA = "0x10A5B64", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006AE2")]
	[Address(RVA = "0x10A5C34", Offset = "0x10A5C34", VA = "0x10A5C34", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006AE3")]
	[Address(RVA = "0x10A61B0", Offset = "0x10A61B0", VA = "0x10A61B0", Slot = "15")]
	public override void OnPop()
	{
	}

	[Token(Token = "0x6006AE4")]
	[Address(RVA = "0x10A6224", Offset = "0x10A6224", VA = "0x10A6224", Slot = "16")]
	public override void OnHide()
	{
	}
}
