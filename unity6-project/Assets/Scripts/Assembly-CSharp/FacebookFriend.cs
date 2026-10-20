using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000BE0")]
public class FacebookFriend
{
	[Token(Token = "0x4003C3D")]
	[FieldOffset(Offset = "0x8")]
	public string memID;

	[Token(Token = "0x4003C3E")]
	[FieldOffset(Offset = "0xC")]
	public string name;

	[Token(Token = "0x4003C3F")]
	[FieldOffset(Offset = "0x10")]
	public string pictureURL;

	[Token(Token = "0x4003C40")]
	[FieldOffset(Offset = "0x14")]
	public Friend data;

	[Token(Token = "0x60055EC")]
	[Address(RVA = "0x1E8B800", Offset = "0x1E8B800", VA = "0x1E8B800")]
	public FacebookFriend()
	{
	}
}
