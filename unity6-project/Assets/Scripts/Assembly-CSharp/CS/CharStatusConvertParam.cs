using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000921")]
	public class CharStatusConvertParam
	{
		[Token(Token = "0x4002D47")]
		[FieldOffset(Offset = "0x8")]
		public string inputText;

		[Token(Token = "0x4002D48")]
		[FieldOffset(Offset = "0xC")]
		public string prefix;

		[Token(Token = "0x4002D49")]
		[FieldOffset(Offset = "0x10")]
		public CharStatus status;

		[Token(Token = "0x4002D4A")]
		[FieldOffset(Offset = "0x14")]
		public bool isRatio;

		[Token(Token = "0x4002D4B")]
		[FieldOffset(Offset = "0x15")]
		public bool isMultiplyMinus;

		[Token(Token = "0x4002D4C")]
		[FieldOffset(Offset = "0x18")]
		public string colorText;

		[Token(Token = "0x4002D4D")]
		[FieldOffset(Offset = "0x1C")]
		public string strAttrName;

		[Token(Token = "0x60048F5")]
		[Address(RVA = "0x23EA710", Offset = "0x23EA710", VA = "0x23EA710")]
		public CharStatusConvertParam()
		{
		}
	}
}
