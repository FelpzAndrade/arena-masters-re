using Il2CppDummyDll;

[Token(Token = "0x2000E58")]
internal class XUILobbyState_Option : XUILobbyState
{
	[Token(Token = "0x4004B5A")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_Option m_pnlOption;

	[Token(Token = "0x17000DBF")]
	public override bool IsPopup
	{
		[Token(Token = "0x6006AFB")]
		[Address(RVA = "0x10A70BC", Offset = "0x10A70BC", VA = "0x10A70BC", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6006AF9")]
	[Address(RVA = "0x10A7098", Offset = "0x10A7098", VA = "0x10A7098")]
	public XUILobbyState_Option()
	{
	}

	[Token(Token = "0x6006AFA")]
	[Address(RVA = "0x10A70A0", Offset = "0x10A70A0", VA = "0x10A70A0", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006AFC")]
	[Address(RVA = "0x10A70C4", Offset = "0x10A70C4", VA = "0x10A70C4", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006AFD")]
	[Address(RVA = "0x10A711C", Offset = "0x10A711C", VA = "0x10A711C", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006AFE")]
	[Address(RVA = "0x10A7124", Offset = "0x10A7124", VA = "0x10A7124", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006AFF")]
	[Address(RVA = "0x10A71D8", Offset = "0x10A71D8", VA = "0x10A71D8", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006B00")]
	[Address(RVA = "0x10A72E0", Offset = "0x10A72E0", VA = "0x10A72E0", Slot = "16")]
	public override void OnHide()
	{
	}
}
