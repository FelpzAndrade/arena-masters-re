using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008D3")]
	public class CSFileLoader_RawBytes : CSFileLoaderBase
	{
		[Token(Token = "0x4002AEE")]
		[FieldOffset(Offset = "0xC")]
		private byte[] data;

		[Token(Token = "0x6004724")]
		[Address(RVA = "0x222EBA0", Offset = "0x222EBA0", VA = "0x222EBA0")]
		public CSFileLoader_RawBytes(string filename, byte[] data)
		{
		}

		[Token(Token = "0x6004725")]
		[Address(RVA = "0x222EBC8", Offset = "0x222EBC8", VA = "0x222EBC8")]
		public CSFileLoader_RawBytes(string data)
		{
		}

		[Token(Token = "0x6004726")]
		[Address(RVA = "0x222ED20", Offset = "0x222ED20", VA = "0x222ED20")]
		public byte[] GetBytes()
		{
			return null;
		}

		[Token(Token = "0x6004727")]
		[Address(RVA = "0x222ED28", Offset = "0x222ED28", VA = "0x222ED28", Slot = "4")]
		public override string Load()
		{
			return null;
		}
	}
}
