using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E40")]
public class XUILobbyState_ChallengeMain : XUILobbyState
{
	[Token(Token = "0x4004B3A")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_ChallengeMain pnlChallengeMain;

	[Token(Token = "0x4004B3B")]
	[FieldOffset(Offset = "0x20")]
	private bool m_firstShow;

	[Token(Token = "0x17000DAD")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006A17")]
		[Address(RVA = "0x109D708", Offset = "0x109D708", VA = "0x109D708", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006A16")]
	[Address(RVA = "0x109D700", Offset = "0x109D700", VA = "0x109D700")]
	public XUILobbyState_ChallengeMain()
	{
	}

	[Token(Token = "0x6006A18")]
	[Address(RVA = "0x109D800", Offset = "0x109D800", VA = "0x109D800", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006A19")]
	[Address(RVA = "0x109D808", Offset = "0x109D808", VA = "0x109D808", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006A1A")]
	[Address(RVA = "0x109D88C", Offset = "0x109D88C", VA = "0x109D88C", Slot = "12")]
	public override LobbyBackground GetLobbyBackgroundType()
	{
		return default(LobbyBackground);
	}

	[Token(Token = "0x6006A1B")]
	[Address(RVA = "0x109D894", Offset = "0x109D894", VA = "0x109D894", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006A1C")]
	[Address(RVA = "0x109D8B4", Offset = "0x109D8B4", VA = "0x109D8B4", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006A1D")]
	[Address(RVA = "0x109D9D4", Offset = "0x109D9D4", VA = "0x109D9D4", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006A1E")]
	[Address(RVA = "0x109DA30", Offset = "0x109DA30", VA = "0x109DA30", Slot = "16")]
	public override void OnHide()
	{
	}
}
