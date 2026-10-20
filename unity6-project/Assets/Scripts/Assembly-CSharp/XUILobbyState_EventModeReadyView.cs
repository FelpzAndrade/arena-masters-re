using Il2CppDummyDll;

[Token(Token = "0x2000E46")]
public class XUILobbyState_EventModeReadyView : XUILobbyState
{
	[Token(Token = "0x4004B43")]
	[FieldOffset(Offset = "0x1C")]
	private XPanel_GameReadyView pnlGameReadyView;

	[Token(Token = "0x6006A4D")]
	[Address(RVA = "0x109FAE4", Offset = "0x109FAE4", VA = "0x109FAE4")]
	public XUILobbyState_EventModeReadyView()
	{
	}

	[Token(Token = "0x6006A4E")]
	[Address(RVA = "0x109FAEC", Offset = "0x109FAEC", VA = "0x109FAEC", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006A4F")]
	[Address(RVA = "0x109FAF4", Offset = "0x109FAF4", VA = "0x109FAF4", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006A50")]
	[Address(RVA = "0x109FB78", Offset = "0x109FB78", VA = "0x109FB78", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006A51")]
	[Address(RVA = "0x109FBD0", Offset = "0x109FBD0", VA = "0x109FBD0", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006A52")]
	[Address(RVA = "0x109FBEC", Offset = "0x109FBEC", VA = "0x109FBEC", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006A53")]
	[Address(RVA = "0x109FCBC", Offset = "0x109FCBC", VA = "0x109FCBC", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006A54")]
	[Address(RVA = "0x109FEB0", Offset = "0x109FEB0", VA = "0x109FEB0", Slot = "16")]
	public override void OnHide()
	{
	}
}
