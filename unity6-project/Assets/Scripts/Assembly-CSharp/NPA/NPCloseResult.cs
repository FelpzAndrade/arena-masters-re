using Il2CppDummyDll;

namespace NPA
{
	[Token(Token = "0x20010A6")]
	public class NPCloseResult : NPResult
	{
		[Token(Token = "0x4005A89")]
		[FieldOffset(Offset = "0x14")]
		public string screenName;

		[Token(Token = "0x6007D25")]
		[Address(RVA = "0x11DC5E0", Offset = "0x11DC5E0", VA = "0x11DC5E0")]
		public NPCloseResult()
		{
		}
	}
}
