using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200095C")]
	public struct GameKey
	{
		[Token(Token = "0x4002E56")]
		[FieldOffset(Offset = "0x0")]
		public MatchType MatchType;

		[Token(Token = "0x4002E57")]
		[FieldOffset(Offset = "0x4")]
		public XGameModeType Mode;

		[Token(Token = "0x6004B47")]
		[Address(RVA = "0x23342F8", Offset = "0x23342F8", VA = "0x23342F8")]
		public GameKey(MatchType matchType, XGameModeType mode)
		{
			this = default;
		}

		[Token(Token = "0x6004B48")]
		[Address(RVA = "0x2334414", Offset = "0x2334414", VA = "0x2334414", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
