using Il2CppDummyDll;

[Token(Token = "0x2000E56")]
public class XUILobbyState_NormalModesView : XUILobbyState
{
	[Token(Token = "0x4004B58")]
	[FieldOffset(Offset = "0x1C")]
	public XPanel_NormalModesView pnlModesView;

	[Token(Token = "0x6006AE5")]
	[Address(RVA = "0x10A6304", Offset = "0x10A6304", VA = "0x10A6304")]
	public XUILobbyState_NormalModesView()
	{
	}

	[Token(Token = "0x6006AE6")]
	[Address(RVA = "0x10A630C", Offset = "0x10A630C", VA = "0x10A630C", Slot = "17")]
	public override XLobbyStateTypes GetStateType()
	{
		return default(XLobbyStateTypes);
	}

	[Token(Token = "0x6006AE7")]
	[Address(RVA = "0x10A6314", Offset = "0x10A6314", VA = "0x10A6314", Slot = "18")]
	public override string GetStateName()
	{
		return null;
	}

	[Token(Token = "0x6006AE8")]
	[Address(RVA = "0x10A6398", Offset = "0x10A6398", VA = "0x10A6398", Slot = "7")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006AE9")]
	[Address(RVA = "0x10A63F0", Offset = "0x10A63F0", VA = "0x10A63F0", Slot = "8")]
	public override void Final()
	{
	}

	[Token(Token = "0x6006AEA")]
	[Address(RVA = "0x10A640C", Offset = "0x10A640C", VA = "0x10A640C", Slot = "13")]
	protected override void OnCreated()
	{
	}

	[Token(Token = "0x6006AEB")]
	[Address(RVA = "0x10A652C", Offset = "0x10A652C", VA = "0x10A652C", Slot = "14")]
	public override void OnShow()
	{
	}

	[Token(Token = "0x6006AEC")]
	[Address(RVA = "0x10A661C", Offset = "0x10A661C", VA = "0x10A661C", Slot = "16")]
	public override void OnHide()
	{
	}
}
