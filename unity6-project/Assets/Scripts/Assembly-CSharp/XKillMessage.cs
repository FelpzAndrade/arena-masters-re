using Il2CppDummyDll;

[Token(Token = "0x20004F4")]
public class XKillMessage
{
	[Token(Token = "0x40018FB")]
	[FieldOffset(Offset = "0x8")]
	public KillMessageType killMessageType;

	[Token(Token = "0x40018FC")]
	[FieldOffset(Offset = "0xC")]
	public bool isEnemy;

	[Token(Token = "0x40018FD")]
	[FieldOffset(Offset = "0x10")]
	public int charID;

	[Token(Token = "0x40018FE")]
	[FieldOffset(Offset = "0x14")]
	public int skinID;

	[Token(Token = "0x40018FF")]
	[FieldOffset(Offset = "0x18")]
	public int killCount;

	[Token(Token = "0x4001900")]
	[FieldOffset(Offset = "0x1C")]
	public string userName;

	[Token(Token = "0x4001901")]
	[FieldOffset(Offset = "0x20")]
	public int profileIconID;

	[Token(Token = "0x4001902")]
	[FieldOffset(Offset = "0x24")]
	public int titleID;

	[Token(Token = "0x4001903")]
	[FieldOffset(Offset = "0x28")]
	public float showElepseTime;

	[Token(Token = "0x6002AC6")]
	[Address(RVA = "0x1D381B4", Offset = "0x1D381B4", VA = "0x1D381B4")]
	public XKillMessage()
	{
	}
}
