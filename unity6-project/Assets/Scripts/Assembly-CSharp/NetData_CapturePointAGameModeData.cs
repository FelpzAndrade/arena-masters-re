using Il2CppDummyDll;

[Token(Token = "0x2000511")]
public class NetData_CapturePointAGameModeData
{
	[Token(Token = "0x40019C1")]
	[FieldOffset(Offset = "0x8")]
	public short CapturePointTeam;

	[Token(Token = "0x40019C2")]
	[FieldOffset(Offset = "0xA")]
	public short CapturingTeam;

	[Token(Token = "0x40019C3")]
	[FieldOffset(Offset = "0xC")]
	public float CapturePointValue;

	[Token(Token = "0x40019C4")]
	[FieldOffset(Offset = "0x10")]
	public short ATeamScore;

	[Token(Token = "0x40019C5")]
	[FieldOffset(Offset = "0x12")]
	public short BTeamScore;

	[Token(Token = "0x40019C6")]
	[FieldOffset(Offset = "0x14")]
	public float ATeamElapsedTime;

	[Token(Token = "0x40019C7")]
	[FieldOffset(Offset = "0x18")]
	public float BTeamElapsedTime;

	[Token(Token = "0x40019C8")]
	[FieldOffset(Offset = "0x1C")]
	public float restElapsedTime;

	[Token(Token = "0x40019C9")]
	[FieldOffset(Offset = "0x20")]
	public short round;

	[Token(Token = "0x6002B9A")]
	[Address(RVA = "0x135DD88", Offset = "0x135DD88", VA = "0x135DD88")]
	public NetData_CapturePointAGameModeData()
	{
	}
}
