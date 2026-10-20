using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000607")]
public class XGameConst
{
	[Token(Token = "0x4001CDE")]
	[FieldOffset(Offset = "0x0")]
	public static float AIRBORNE_SPEED;

	[Token(Token = "0x4001CDF")]
	[FieldOffset(Offset = "0x4")]
	public static float THROW_VERTICAL_SPEED;

	[Token(Token = "0x4001CE0")]
	[FieldOffset(Offset = "0x8")]
	public static float THROW_HORIZENTAL_SPEED;

	[Token(Token = "0x4001CE1")]
	[FieldOffset(Offset = "0xC")]
	public static float KNOCKBACK_SPEED;

	[Token(Token = "0x4001CE2")]
	[FieldOffset(Offset = "0x10")]
	public static float SNEAK_TIME;

	[Token(Token = "0x4001CE3")]
	[FieldOffset(Offset = "0x14")]
	public static int CHAT_CHANNEL_MAX_USERS;

	[Token(Token = "0x4001CE4")]
	[FieldOffset(Offset = "0x18")]
	public static int CHAT_MAX_CHANNEL;

	[Token(Token = "0x60033F0")]
	[Address(RVA = "0x19BDF1C", Offset = "0x19BDF1C", VA = "0x19BDF1C")]
	public XGameConst()
	{
	}

	[Token(Token = "0x60033F2")]
	[Address(RVA = "0x19BE018", Offset = "0x19BE018", VA = "0x19BE018")]
	public static void SetFromConstXml(CSProtoInfoManager_GameConst gameConst)
	{
	}
}
