using System.IO;
using System.Security.Cryptography;
using System.Text;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B97")]
	public class CSMD5Hash
	{
		[Token(Token = "0x4003B24")]
		[FieldOffset(Offset = "0x8")]
		private StringBuilder m_stringBuilder;

		[Token(Token = "0x4003B25")]
		[FieldOffset(Offset = "0xC")]
		private MD5 m_md5;

		[Token(Token = "0x60053EC")]
		[Address(RVA = "0x2238E94", Offset = "0x2238E94", VA = "0x2238E94")]
		public CSMD5Hash()
		{
		}

		[Token(Token = "0x60053ED")]
		[Address(RVA = "0x2238F54", Offset = "0x2238F54", VA = "0x2238F54")]
		public static byte[] GetMD5HashValue(byte[] bytes)
		{
			return null;
		}

		[Token(Token = "0x60053EE")]
		[Address(RVA = "0x2239004", Offset = "0x2239004", VA = "0x2239004")]
		public static byte[] GetMD5HashValue(FileStream file)
		{
			return null;
		}

		[Token(Token = "0x60053EF")]
		[Address(RVA = "0x22390B4", Offset = "0x22390B4", VA = "0x22390B4")]
		public void Update(string source)
		{
		}

		[Token(Token = "0x60053F0")]
		[Address(RVA = "0x223918C", Offset = "0x223918C", VA = "0x223918C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60053F1")]
		[Address(RVA = "0x22391D4", Offset = "0x22391D4", VA = "0x22391D4")]
		public string GetHashValue()
		{
			return null;
		}

		[Token(Token = "0x60053F2")]
		[Address(RVA = "0x22393A8", Offset = "0x22393A8", VA = "0x22393A8")]
		public bool VerifyMd5Hash(string hash)
		{
			return default(bool);
		}
	}
}
