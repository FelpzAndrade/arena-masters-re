using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000A60")]
	public class DataChanged
	{
		[Token(Token = "0x4003073")]
		[FieldOffset(Offset = "0x8")]
		public bool userData;

		[Token(Token = "0x4003074")]
		[FieldOffset(Offset = "0x9")]
		public bool userResource;

		[Token(Token = "0x4003075")]
		[FieldOffset(Offset = "0xA")]
		public bool stallItem;

		[Token(Token = "0x17000AFC")]
		public bool Any
		{
			[Token(Token = "0x6004DC1")]
			[Address(RVA = "0x1CDA718", Offset = "0x1CDA718", VA = "0x1CDA718")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6004DC0")]
		[Address(RVA = "0x1CDA710", Offset = "0x1CDA710", VA = "0x1CDA710")]
		public DataChanged()
		{
		}
	}
}
