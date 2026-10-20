using Il2CppDummyDll;

[Token(Token = "0x2000E4D")]
public class XUILobbyState_InvenExtend : XUILobbyState
{
	[Token(Token = "0x4004B4A")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_InvenExtend m_pnlInvenExtend;

	[Token(Token = "0x17000DB4")]
	public override bool IsPopup
	{
		[Token(Token = "0x6006A8D")]
		[Address(RVA = "0x10A2768", Offset = "0x10A2768", VA = "0x10A2768", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6006A8A")]
	[Address(RVA = "0x10A273C", Offset = "0x10A273C", VA = "0x10A273C")]
	public XUILobbyState_InvenExtend()
	{
	}

	[Token(Token = "0x6006A8B")]
	[Address(RVA = "0x10A2744", Offset = "0x10A2744", VA = "0x10A2744", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006A8C")]
	[Address(RVA = "0x10A274C", Offset = "0x10A274C", VA = "0x10A274C", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006A8E")]
	[Address(RVA = "0x10A2770", Offset = "0x10A2770", VA = "0x10A2770", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006A8F")]
	[Address(RVA = "0x10A2824", Offset = "0x10A2824", VA = "0x10A2824", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006A90")]
	[Address(RVA = "0x10A292C", Offset = "0x10A292C", VA = "0x10A292C", Slot = "16")]
	public override void OnHide()
	{
	}
}
