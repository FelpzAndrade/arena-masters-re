using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008D4")]
	public class CSFileLoader_RawString : CSFileLoaderBase
	{
		[Token(Token = "0x4002AEF")]
		[FieldOffset(Offset = "0xC")]
		private string data;

		[Token(Token = "0x6004728")]
		[Address(RVA = "0x222EE20", Offset = "0x222EE20", VA = "0x222EE20")]
		public CSFileLoader_RawString(string filename, string data)
		{
		}

		[Token(Token = "0x6004729")]
		[Address(RVA = "0x222EE48", Offset = "0x222EE48", VA = "0x222EE48")]
		public byte[] GetBytes()
		{
			return null;
		}

		[Token(Token = "0x600472A")]
		[Address(RVA = "0x222EF40", Offset = "0x222EF40", VA = "0x222EF40", Slot = "4")]
		public override string Load()
		{
			return null;
		}
	}
}
