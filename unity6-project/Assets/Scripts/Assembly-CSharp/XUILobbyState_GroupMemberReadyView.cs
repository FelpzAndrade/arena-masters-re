using Il2CppDummyDll;

[Token(Token = "0x2000E4A")]
public class XUILobbyState_GroupMemberReadyView : XUILobbyState
{
	[Token(Token = "0x4004B47")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_GroupReadyView pnlGameReadyView;

	[Token(Token = "0x6006A6F")]
	[Address(RVA = "0x10A1468", Offset = "0x10A1468", VA = "0x10A1468")]
	public XUILobbyState_GroupMemberReadyView()
	{
	}

	[Token(Token = "0x6006A70")]
	[Address(RVA = "0x10A1470", Offset = "0x10A1470", VA = "0x10A1470", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006A71")]
	[Address(RVA = "0x10A1478", Offset = "0x10A1478", VA = "0x10A1478", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006A72")]
	[Address(RVA = "0x10A14FC", Offset = "0x10A14FC", VA = "0x10A14FC", Slot = "12")]
	public override LobbyBackground GetLobbyBackgroundType()
	{
		return default(LobbyBackground);
	}

	[Token(Token = "0x6006A73")]
	[Address(RVA = "0x10A1504", Offset = "0x10A1504", VA = "0x10A1504", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006A74")]
	[Address(RVA = "0x10A155C", Offset = "0x10A155C", VA = "0x10A155C", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006A75")]
	[Address(RVA = "0x10A1578", Offset = "0x10A1578", VA = "0x10A1578", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006A76")]
	[Address(RVA = "0x10A1648", Offset = "0x10A1648", VA = "0x10A1648", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006A77")]
	[Address(RVA = "0x10A1794", Offset = "0x10A1794", VA = "0x10A1794", Slot = "15")]
	public override void OnPop()
	{
	}

	[Token(Token = "0x6006A78")]
	[Address(RVA = "0x10A18E4", Offset = "0x10A18E4", VA = "0x10A18E4", Slot = "16")]
	public override void OnHide()
	{
	}
}
