using Il2CppDummyDll;

[Token(Token = "0x2000E43")]
public class XUILobbyState_CharSkill : XUILobbyState
{
	[Token(Token = "0x4004B40")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_CharSkill pnlCharSkill;

	[Token(Token = "0x6006A32")]
	[Address(RVA = "0x109EDCC", Offset = "0x109EDCC", VA = "0x109EDCC")]
	public XUILobbyState_CharSkill()
	{
	}

	[Token(Token = "0x6006A33")]
	[Address(RVA = "0x109EDD4", Offset = "0x109EDD4", VA = "0x109EDD4", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006A34")]
	[Address(RVA = "0x109EDDC", Offset = "0x109EDDC", VA = "0x109EDDC", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006A35")]
	[Address(RVA = "0x109EE60", Offset = "0x109EE60", VA = "0x109EE60", Slot = "12")]
	public override LobbyBackground GetLobbyBackgroundType()
	{
		return default(LobbyBackground);
	}

	[Token(Token = "0x6006A36")]
	[Address(RVA = "0x109EE68", Offset = "0x109EE68", VA = "0x109EE68", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006A37")]
	[Address(RVA = "0x109EE84", Offset = "0x109EE84", VA = "0x109EE84", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006A38")]
	[Address(RVA = "0x109EF38", Offset = "0x109EF38", VA = "0x109EF38", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006A39")]
	[Address(RVA = "0x109F0EC", Offset = "0x109F0EC", VA = "0x109F0EC", Slot = "15")]
	public override void OnPop()
	{
	}

	[Token(Token = "0x6006A3A")]
	[Address(RVA = "0x109F134", Offset = "0x109F134", VA = "0x109F134", Slot = "16")]
	public override void OnHide()
	{
	}
}
