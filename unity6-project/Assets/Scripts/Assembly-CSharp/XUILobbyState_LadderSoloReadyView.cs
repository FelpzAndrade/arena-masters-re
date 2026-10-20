using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E4F")]
public class XUILobbyState_LadderSoloReadyView : XUILobbyState
{
	[Token(Token = "0x4004B4D")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_GameReadyView pnlGameReadyView;

	[Token(Token = "0x17000DB6")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006AA0")]
		[Address(RVA = "0x10A2F48", Offset = "0x10A2F48", VA = "0x10A2F48", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006A9C")]
	[Address(RVA = "0x10A2E94", Offset = "0x10A2E94", VA = "0x10A2E94")]
	public XUILobbyState_LadderSoloReadyView()
	{
	}

	[Token(Token = "0x6006A9D")]
	[Address(RVA = "0x10A2E9C", Offset = "0x10A2E9C", VA = "0x10A2E9C", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006A9E")]
	[Address(RVA = "0x10A2EA4", Offset = "0x10A2EA4", VA = "0x10A2EA4", Slot = "12")]
	public override LobbyBackground GetLobbyBackgroundType()
	{
		return default(LobbyBackground);
	}

	[Token(Token = "0x6006A9F")]
	[Address(RVA = "0x10A2EAC", Offset = "0x10A2EAC", VA = "0x10A2EAC", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006AA1")]
	[Address(RVA = "0x10A3040", Offset = "0x10A3040", VA = "0x10A3040", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006AA2")]
	[Address(RVA = "0x10A3098", Offset = "0x10A3098", VA = "0x10A3098", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006AA3")]
	[Address(RVA = "0x10A30B4", Offset = "0x10A30B4", VA = "0x10A30B4", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006AA4")]
	[Address(RVA = "0x10A3184", Offset = "0x10A3184", VA = "0x10A3184", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006AA5")]
	[Address(RVA = "0x10A33E0", Offset = "0x10A33E0", VA = "0x10A33E0", Slot = "15")]
	public override void OnPop()
	{
	}

	[Token(Token = "0x6006AA6")]
	[Address(RVA = "0x10A3414", Offset = "0x10A3414", VA = "0x10A3414", Slot = "16")]
	public override void OnHide()
	{
	}
}
