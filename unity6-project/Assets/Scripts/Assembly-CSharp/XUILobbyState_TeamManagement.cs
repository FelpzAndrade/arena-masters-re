using Il2CppDummyDll;

[Token(Token = "0x2000E66")]
public class XUILobbyState_TeamManagement : XUILobbyState
{
	[Token(Token = "0x4004B6D")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_TeamManagement pnlTeamManagement;

	[Token(Token = "0x6006B8A")]
	[Address(RVA = "0x10AE9CC", Offset = "0x10AE9CC", VA = "0x10AE9CC")]
	public XUILobbyState_TeamManagement()
	{
	}

	[Token(Token = "0x6006B8B")]
	[Address(RVA = "0x10AE9D4", Offset = "0x10AE9D4", VA = "0x10AE9D4", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006B8C")]
	[Address(RVA = "0x10AE9DC", Offset = "0x10AE9DC", VA = "0x10AE9DC", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006B8D")]
	[Address(RVA = "0x10AEA60", Offset = "0x10AEA60", VA = "0x10AEA60", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006B8E")]
	[Address(RVA = "0x10AEAB8", Offset = "0x10AEAB8", VA = "0x10AEAB8", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006B8F")]
	[Address(RVA = "0x10AEAD4", Offset = "0x10AEAD4", VA = "0x10AEAD4", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006B90")]
	[Address(RVA = "0x10AEB88", Offset = "0x10AEB88", VA = "0x10AEB88", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006B91")]
	[Address(RVA = "0x10AEE80", Offset = "0x10AEE80", VA = "0x10AEE80", Slot = "15")]
	public override void OnPop()
	{
	}

	[Token(Token = "0x6006B92")]
	[Address(RVA = "0x10AEEDC", Offset = "0x10AEEDC", VA = "0x10AEEDC", Slot = "16")]
	public override void OnHide()
	{
	}
}
