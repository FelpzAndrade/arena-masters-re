using Il2CppDummyDll;

[Token(Token = "0x20005A1")]
public class XGameModeState_Setting : XGameModeState
{
	[Token(Token = "0x600302D")]
	[Address(RVA = "0x141C8DC", Offset = "0x141C8DC", VA = "0x141C8DC")]
	public XGameModeState_Setting()
	{
	}

	[Token(Token = "0x600302E")]
	[Address(RVA = "0x141C8E4", Offset = "0x141C8E4", VA = "0x141C8E4", Slot = "15")]
	public override XGameModeStateType GetGameModeStateType()
	{
		return default(XGameModeStateType);
	}

	[Token(Token = "0x600302F")]
	[Address(RVA = "0x141C8EC", Offset = "0x141C8EC", VA = "0x141C8EC", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6003030")]
	[Address(RVA = "0x141CBF0", Offset = "0x141CBF0", VA = "0x141CBF0", Slot = "19")]
	public virtual void RequestStartGame()
	{
	}
}
