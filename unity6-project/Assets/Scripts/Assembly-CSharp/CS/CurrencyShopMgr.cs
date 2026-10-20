using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000A30")]
	public abstract class CurrencyShopMgr
	{
		[Token(Token = "0x6004D7E")]
		[Address(RVA = "0x1CD6CFC", Offset = "0x1CD6CFC", VA = "0x1CD6CFC")]
		protected CurrencyShopMgr()
		{
		}

		[Token(Token = "0x6004D7F")]
		[Address(RVA = "0x1CDA544", Offset = "0x1CDA544", VA = "0x1CDA544")]
		public static CurrencyShopMgr Create(Currency type)
		{
			return null;
		}

		[Token(Token = "0x6004D80")]
		public abstract int CalcReturn(int count);
	}
}
