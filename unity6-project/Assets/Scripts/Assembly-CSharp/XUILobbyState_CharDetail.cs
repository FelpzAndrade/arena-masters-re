using Il2CppDummyDll;

[Token(Token = "0x2000E41")]
internal class XUILobbyState_CharDetail : XUILobbyState
{
	[Token(Token = "0x4004B3C")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_CharDetail widget;

	[Token(Token = "0x4004B3D")]
	[FieldOffset(Offset = "0x20")]
	private XPanel_CharList pnlCharList;

	[Token(Token = "0x6006A1F")]
	[Address(RVA = "0x109DB10", Offset = "0x109DB10", VA = "0x109DB10")]
	public XUILobbyState_CharDetail()
	{
	}

	[Token(Token = "0x6006A20")]
	[Address(RVA = "0x109DB18", Offset = "0x109DB18", VA = "0x109DB18", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006A21")]
	[Address(RVA = "0x109DB20", Offset = "0x109DB20", VA = "0x109DB20", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006A22")]
	[Address(RVA = "0x109DBA4", Offset = "0x109DBA4", VA = "0x109DBA4", Slot = "12")]
	public override LobbyBackground GetLobbyBackgroundType()
	{
		return default(LobbyBackground);
	}

	[Token(Token = "0x6006A23")]
	[Address(RVA = "0x109DBAC", Offset = "0x109DBAC", VA = "0x109DBAC", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006A24")]
	[Address(RVA = "0x109DC04", Offset = "0x109DC04", VA = "0x109DC04", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006A25")]
	[Address(RVA = "0x109DC20", Offset = "0x109DC20", VA = "0x109DC20", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006A26")]
	[Address(RVA = "0x109DD4C", Offset = "0x109DD4C", VA = "0x109DD4C", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006A27")]
	[Address(RVA = "0x109E100", Offset = "0x109E100", VA = "0x109E100")]
	private bool OnClickCharList(int charID)
	{
		return default(bool);
	}

	[Token(Token = "0x6006A28")]
	[Address(RVA = "0x109E240", Offset = "0x109E240", VA = "0x109E240", Slot = "15")]
	public override void OnPop()
	{
	}

	[Token(Token = "0x6006A29")]
	[Address(RVA = "0x109E780", Offset = "0x109E780", VA = "0x109E780", Slot = "16")]
	public override void OnHide()
	{
	}
}
