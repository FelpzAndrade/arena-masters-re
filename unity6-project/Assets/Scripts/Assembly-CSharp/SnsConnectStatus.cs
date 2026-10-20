using Il2CppDummyDll;

[Token(Token = "0x2000BDF")]
public class SnsConnectStatus
{
	[Token(Token = "0x4003C37")]
	[FieldOffset(Offset = "0x0")]
	public static string facebookName;

	[Token(Token = "0x4003C38")]
	[FieldOffset(Offset = "0x4")]
	public static string twitterName;

	[Token(Token = "0x4003C39")]
	[FieldOffset(Offset = "0x8")]
	public static string googleName;

	[Token(Token = "0x4003C3A")]
	[FieldOffset(Offset = "0x8")]
	public string name;

	[Token(Token = "0x4003C3B")]
	[FieldOffset(Offset = "0xC")]
	public int type;

	[Token(Token = "0x4003C3C")]
	[FieldOffset(Offset = "0x10")]
	public bool isConnect;

	[Token(Token = "0x60055EA")]
	[Address(RVA = "0x1D40804", Offset = "0x1D40804", VA = "0x1D40804")]
	public SnsConnectStatus()
	{
	}
}
