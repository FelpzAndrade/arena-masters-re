using System.Security.Cryptography;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B98")]
	public class DESEncryptor
	{
		[Token(Token = "0x60053F3")]
		[Address(RVA = "0x1CDAB94", Offset = "0x1CDAB94", VA = "0x1CDAB94")]
		public DESEncryptor()
		{
		}

		[Token(Token = "0x60053F4")]
		[Address(RVA = "0x1CDAB9C", Offset = "0x1CDAB9C", VA = "0x1CDAB9C")]
		public static byte[] Encrypt(byte[] input, string password)
		{
			return null;
		}

		[Token(Token = "0x60053F5")]
		[Address(RVA = "0x1CDB154", Offset = "0x1CDB154", VA = "0x1CDB154")]
		public static byte[] Decrypt(byte[] input, string password)
		{
			return null;
		}

		[Token(Token = "0x60053F6")]
		[Address(RVA = "0x1CDB43C", Offset = "0x1CDB43C", VA = "0x1CDB43C")]
		public static string Encrypt(string text, string password)
		{
			return null;
		}

		[Token(Token = "0x60053F7")]
		[Address(RVA = "0x1CDB584", Offset = "0x1CDB584", VA = "0x1CDB584")]
		public static string Decrypt(string text, string password)
		{
			return null;
		}

		[Token(Token = "0x60053F8")]
		[Address(RVA = "0x1CDAE84", Offset = "0x1CDAE84", VA = "0x1CDAE84")]
		private static byte[] Transform(byte[] input, ICryptoTransform CryptoTransform)
		{
			return null;
		}
	}
}
