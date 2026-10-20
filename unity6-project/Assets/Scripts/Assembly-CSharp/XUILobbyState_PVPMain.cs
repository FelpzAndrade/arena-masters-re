using Il2CppDummyDll;

[Token(Token = "0x2000E5B")]
public class XUILobbyState_PVPMain : XUILobbyState
{
	[Token(Token = "0x4004B5F")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_PlayMain pnlPlayMain;

	[Token(Token = "0x4004B60")]
	[FieldOffset(Offset = "0x20")]
	private bool m_firstShow;

	[Token(Token = "0x6006B19")]
	[Address(RVA = "0x10A904C", Offset = "0x10A904C", VA = "0x10A904C")]
	public XUILobbyState_PVPMain()
	{
	}

	[Token(Token = "0x6006B1A")]
	[Address(RVA = "0x10A9054", Offset = "0x10A9054", VA = "0x10A9054", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006B1B")]
	[Address(RVA = "0x10A905C", Offset = "0x10A905C", VA = "0x10A905C", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006B1C")]
	[Address(RVA = "0x10A90E0", Offset = "0x10A90E0", VA = "0x10A90E0", Slot = "12")]
	public override LobbyBackground GetLobbyBackgroundType()
	{
		return default(LobbyBackground);
	}

	[Token(Token = "0x6006B1D")]
	[Address(RVA = "0x10A90E8", Offset = "0x10A90E8", VA = "0x10A90E8", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006B1E")]
	[Address(RVA = "0x10A9104", Offset = "0x10A9104", VA = "0x10A9104", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006B1F")]
	[Address(RVA = "0x10A9224", Offset = "0x10A9224", VA = "0x10A9224", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006B20")]
	[Address(RVA = "0x10A9280", Offset = "0x10A9280", VA = "0x10A9280", Slot = "16")]
	public override void OnHide()
	{
	}
}
