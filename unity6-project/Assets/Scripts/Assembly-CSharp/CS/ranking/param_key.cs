using Il2CppDummyDll;

namespace CS.ranking
{
	[Token(Token = "0x2000A1A")]
	public struct param_key
	{
		[Token(Token = "0x4002FD8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string reward;

		[Token(Token = "0x4002FD9")]
		[FieldOffset(Offset = "0x4")]
		public static readonly string ranking_week;

		[Token(Token = "0x4002FDA")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string ranking_data;

		[Token(Token = "0x4002FDB")]
		[FieldOffset(Offset = "0xC")]
		public static readonly string ranking_dataByDiff;

		[Token(Token = "0x4002FDC")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string user_ranking;

		[Token(Token = "0x4002FDD")]
		[FieldOffset(Offset = "0x14")]
		public static readonly string user_rankingByDiff;

		[Token(Token = "0x4002FDE")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string ranker_detail;
	}
}
