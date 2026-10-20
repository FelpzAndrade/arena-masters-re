using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20009D1")]
	public class CSExpReward
	{
		[Token(Token = "0x4002FA5")]
		[FieldOffset(Offset = "0x8")]
		public int before;

		[Token(Token = "0x4002FA6")]
		[FieldOffset(Offset = "0xC")]
		public int after;

		[Token(Token = "0x17000AF3")]
		public int amount
		{
			[Token(Token = "0x6004D11")]
			[Address(RVA = "0x222E990", Offset = "0x222E990", VA = "0x222E990")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6004D10")]
		[Address(RVA = "0x222E988", Offset = "0x222E988", VA = "0x222E988")]
		public CSExpReward()
		{
		}
	}
}
