using Il2CppDummyDll;

[Token(Token = "0x2000E44")]
public class XUILobbyState_Clan : XUILobbyState
{
	[Token(Token = "0x4004B41")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_Clan pnlClan;

	[Token(Token = "0x6006A3B")]
	[Address(RVA = "0x109F214", Offset = "0x109F214", VA = "0x109F214")]
	public XUILobbyState_Clan()
	{
	}

	[Token(Token = "0x6006A3C")]
	[Address(RVA = "0x109F21C", Offset = "0x109F21C", VA = "0x109F21C", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006A3D")]
	[Address(RVA = "0x109F224", Offset = "0x109F224", VA = "0x109F224", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006A3E")]
	[Address(RVA = "0x109F2A8", Offset = "0x109F2A8", VA = "0x109F2A8", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006A3F")]
	[Address(RVA = "0x109F300", Offset = "0x109F300", VA = "0x109F300", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006A40")]
	[Address(RVA = "0x109F31C", Offset = "0x109F31C", VA = "0x109F31C", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006A41")]
	[Address(RVA = "0x109F3D0", Offset = "0x109F3D0", VA = "0x109F3D0", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006A42")]
	[Address(RVA = "0x109F404", Offset = "0x109F404", VA = "0x109F404", Slot = "16")]
	public override void OnHide()
	{
	}

	[Token(Token = "0x6006A43")]
	[Address(RVA = "0x109F510", Offset = "0x109F510", VA = "0x109F510", Slot = "15")]
	public override void OnPop()
	{
	}
}
