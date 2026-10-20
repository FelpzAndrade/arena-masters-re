using Il2CppDummyDll;
using SimpleJSON;

namespace NPA
{
	[Token(Token = "0x20010A4")]
	public class NPResult
	{
		[Token(Token = "0x4005A85")]
		[FieldOffset(Offset = "0x8")]
		public NPRequestTypeTag requestTag;

		[Token(Token = "0x4005A86")]
		[FieldOffset(Offset = "0xC")]
		public int errorCode;

		[Token(Token = "0x4005A87")]
		[FieldOffset(Offset = "0x10")]
		public JSONNode resultJson;

		[Token(Token = "0x6007D23")]
		[Address(RVA = "0x11CAC64", Offset = "0x11CAC64", VA = "0x11CAC64")]
		public NPResult()
		{
		}
	}
}
