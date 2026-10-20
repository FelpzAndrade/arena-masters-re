using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E64")]
internal class XUILobbyState_SpecialDungeonStage : XUILobbyState
{
	[Token(Token = "0x4004B6B")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_GameReadyView pnlGameReadyView;

	[Token(Token = "0x17000DD4")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006B75")]
		[Address(RVA = "0x10ACA84", Offset = "0x10ACA84", VA = "0x10ACA84", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006B74")]
	[Address(RVA = "0x10ACA7C", Offset = "0x10ACA7C", VA = "0x10ACA7C")]
	public XUILobbyState_SpecialDungeonStage()
	{
	}

	[Token(Token = "0x6006B76")]
	[Address(RVA = "0x10ACB7C", Offset = "0x10ACB7C", VA = "0x10ACB7C", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006B77")]
	[Address(RVA = "0x10ACB84", Offset = "0x10ACB84", VA = "0x10ACB84", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006B78")]
	[Address(RVA = "0x10ACC08", Offset = "0x10ACC08", VA = "0x10ACC08", Slot = "12")]
	public override LobbyBackground GetLobbyBackgroundType()
	{
		return default(LobbyBackground);
	}

	[Token(Token = "0x6006B79")]
	[Address(RVA = "0x10ACC10", Offset = "0x10ACC10", VA = "0x10ACC10", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006B7A")]
	[Address(RVA = "0x10ACC68", Offset = "0x10ACC68", VA = "0x10ACC68", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006B7B")]
	[Address(RVA = "0x10ACC84", Offset = "0x10ACC84", VA = "0x10ACC84", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006B7C")]
	[Address(RVA = "0x10ACD54", Offset = "0x10ACD54", VA = "0x10ACD54", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006B7D")]
	[Address(RVA = "0x10AD0D4", Offset = "0x10AD0D4", VA = "0x10AD0D4", Slot = "16")]
	public override void OnHide()
	{
	}
}
