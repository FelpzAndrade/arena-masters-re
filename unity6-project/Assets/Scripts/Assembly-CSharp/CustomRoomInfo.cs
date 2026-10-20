using Il2CppDummyDll;

[Token(Token = "0x2000978")]
public class CustomRoomInfo : CSRoomInfo
{
	[Token(Token = "0x4002ED7")]
	[FieldOffset(Offset = "0x3C")]
	public int customSetting;

	[Token(Token = "0x4002ED8")]
	[FieldOffset(Offset = "0x40")]
	public RoomAction action;

	[Token(Token = "0x4002ED9")]
	[FieldOffset(Offset = "0x44")]
	public int customKill;

	[Token(Token = "0x4002EDA")]
	[FieldOffset(Offset = "0x48")]
	public int customTimeSec;

	[Token(Token = "0x6004C2C")]
	[Address(RVA = "0x1E613AC", Offset = "0x1E613AC", VA = "0x1E613AC")]
	public CustomRoomInfo()
	{
	}
}
