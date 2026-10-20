using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000EA")]
	public class JRaw : JValue
	{
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xF980CC", Offset = "0xF980CC", VA = "0xF980CC")]
		public JRaw(JRaw other)
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xF98140", Offset = "0xF98140", VA = "0xF98140")]
		public JRaw(object rawJson)
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xF98168", Offset = "0xF98168", VA = "0xF98168")]
		public static JRaw Create(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xF984FC", Offset = "0xF984FC", VA = "0xF984FC", Slot = "11")]
		internal override JToken CloneToken()
		{
			return null;
		}
	}
}
