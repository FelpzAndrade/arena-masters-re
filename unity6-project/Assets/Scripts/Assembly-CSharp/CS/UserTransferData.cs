using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000A53")]
	public class UserTransferData
	{
		[Token(Token = "0x4003014")]
		[FieldOffset(Offset = "0x8")]
		public string TransferKey;

		[Token(Token = "0x4003015")]
		[FieldOffset(Offset = "0xC")]
		public string eMail;

		[Token(Token = "0x6004DA8")]
		[Address(RVA = "0x21EEAC8", Offset = "0x21EEAC8", VA = "0x21EEAC8")]
		public UserTransferData()
		{
		}

		[Token(Token = "0x6004DA9")]
		[Address(RVA = "0x21EEBAC", Offset = "0x21EEBAC", VA = "0x21EEBAC")]
		public UserTransferData(string key, string eMail)
		{
		}
	}
}
