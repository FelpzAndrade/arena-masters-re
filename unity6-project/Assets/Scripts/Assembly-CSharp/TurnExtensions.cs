using Il2CppDummyDll;

[Token(Token = "0x200031B")]
public static class TurnExtensions
{
	[Token(Token = "0x4001046")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string TurnPropKey;

	[Token(Token = "0x4001047")]
	[FieldOffset(Offset = "0x4")]
	public static readonly string TurnStartPropKey;

	[Token(Token = "0x4001048")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string FinishedTurnPropKey;

	[Token(Token = "0x6001AAB")]
	[Address(RVA = "0x1D58378", Offset = "0x1D58378", VA = "0x1D58378")]
	public static void SetTurn(this Room room, int turn, bool setStartTime = false)
	{
	}

	[Token(Token = "0x6001AAC")]
	[Address(RVA = "0x1D585B4", Offset = "0x1D585B4", VA = "0x1D585B4")]
	public static int GetTurn(this RoomInfo room)
	{
		return default(int);
	}

	[Token(Token = "0x6001AAD")]
	[Address(RVA = "0x1D58760", Offset = "0x1D58760", VA = "0x1D58760")]
	public static int GetTurnStart(this RoomInfo room)
	{
		return default(int);
	}

	[Token(Token = "0x6001AAE")]
	[Address(RVA = "0x1D5890C", Offset = "0x1D5890C", VA = "0x1D5890C")]
	public static int GetFinishedTurn(this PhotonPlayer player)
	{
		return default(int);
	}

	[Token(Token = "0x6001AAF")]
	[Address(RVA = "0x1D58B8C", Offset = "0x1D58B8C", VA = "0x1D58B8C")]
	public static void SetFinishedTurn(this PhotonPlayer player, int turn)
	{
	}
}
