using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000E50")]
public class XUILobbyState_LadderTeamReadyView : XUILobbyState
{
	[Token(Token = "0x4004B4E")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_GameReadyView pnlGameReadyView;

	[Token(Token = "0x17000DB7")]
	protected override List<Currency> TopbannerCurrencyList
	{
		[Token(Token = "0x6006AAC")]
		[Address(RVA = "0x10A35F0", Offset = "0x10A35F0", VA = "0x10A35F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006AA7")]
	[Address(RVA = "0x10A3520", Offset = "0x10A3520", VA = "0x10A3520")]
	public XUILobbyState_LadderTeamReadyView()
	{
	}

	[Token(Token = "0x6006AA8")]
	[Address(RVA = "0x10A3528", Offset = "0x10A3528", VA = "0x10A3528", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006AA9")]
	[Address(RVA = "0x10A3544", Offset = "0x10A3544", VA = "0x10A3544", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006AAA")]
	[Address(RVA = "0x10A354C", Offset = "0x10A354C", VA = "0x10A354C", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006AAB")]
	[Address(RVA = "0x10A35E8", Offset = "0x10A35E8", VA = "0x10A35E8", Slot = "12")]
	public override LobbyBackground GetLobbyBackgroundType()
	{
		return default(LobbyBackground);
	}

	[Token(Token = "0x6006AAD")]
	[Address(RVA = "0x10A36E8", Offset = "0x10A36E8", VA = "0x10A36E8", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006AAE")]
	[Address(RVA = "0x10A3740", Offset = "0x10A3740", VA = "0x10A3740", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006AAF")]
	[Address(RVA = "0x10A3810", Offset = "0x10A3810", VA = "0x10A3810", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006AB0")]
	[Address(RVA = "0x10A3A6C", Offset = "0x10A3A6C", VA = "0x10A3A6C", Slot = "15")]
	public override void OnPop()
	{
	}

	[Token(Token = "0x6006AB1")]
	[Address(RVA = "0x10A3AA0", Offset = "0x10A3AA0", VA = "0x10A3AA0", Slot = "16")]
	public override void OnHide()
	{
	}
}
