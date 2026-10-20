using Il2CppDummyDll;

[Token(Token = "0x2000E65")]
internal class XUILobbyState_Stage : XUILobbyState
{
	[Token(Token = "0x4004B6C")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_GameReadyView pnlGameReadyView;

	[Token(Token = "0x6006B7E")]
	[Address(RVA = "0x10AD1E0", Offset = "0x10AD1E0", VA = "0x10AD1E0")]
	public XUILobbyState_Stage()
	{
	}

	[Token(Token = "0x6006B7F")]
	[Address(RVA = "0x10AD1E8", Offset = "0x10AD1E8", VA = "0x10AD1E8", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006B80")]
	[Address(RVA = "0x10AD1F0", Offset = "0x10AD1F0", VA = "0x10AD1F0", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006B81")]
	[Address(RVA = "0x10AD648", Offset = "0x10AD648", VA = "0x10AD648", Slot = "12")]
	public override LobbyBackground GetLobbyBackgroundType()
	{
		return default(LobbyBackground);
	}

	[Token(Token = "0x6006B82")]
	[Address(RVA = "0x10AD2F0", Offset = "0x10AD2F0", VA = "0x10AD2F0")]
	private bool IsAIMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6006B83")]
	[Address(RVA = "0x10AD440", Offset = "0x10AD440", VA = "0x10AD440")]
	private bool IsFriendly()
	{
		return default(bool);
	}

	[Token(Token = "0x6006B84")]
	[Address(RVA = "0x10AD57C", Offset = "0x10AD57C", VA = "0x10AD57C")]
	private bool IsCustomRoom()
	{
		return default(bool);
	}

	[Token(Token = "0x6006B85")]
	[Address(RVA = "0x10AD650", Offset = "0x10AD650", VA = "0x10AD650", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006B86")]
	[Address(RVA = "0x10AD6A8", Offset = "0x10AD6A8", VA = "0x10AD6A8", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006B87")]
	[Address(RVA = "0x10AD6C4", Offset = "0x10AD6C4", VA = "0x10AD6C4", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006B88")]
	[Address(RVA = "0x10AD794", Offset = "0x10AD794", VA = "0x10AD794", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006B89")]
	[Address(RVA = "0x10AE730", Offset = "0x10AE730", VA = "0x10AE730", Slot = "16")]
	public override void OnHide()
	{
	}
}
