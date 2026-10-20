using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000906")]
	public class NameChecker
	{
		[Token(Token = "0x4002B77")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int allow_to_spaces;

		[Token(Token = "0x4002B78")]
		[FieldOffset(Offset = "0x8")]
		private NameFilter m_name_filter;

		[Token(Token = "0x4002B79")]
		[FieldOffset(Offset = "0x4")]
		private static Func<char, bool> _003C_003Ef__am_0024cache2;

		[Token(Token = "0x600484A")]
		[Address(RVA = "0x233BDAC", Offset = "0x233BDAC", VA = "0x233BDAC")]
		public NameChecker(NameFilter name_filter)
		{
		}

		[Token(Token = "0x600484C")]
		[Address(RVA = "0x233BE50", Offset = "0x233BE50", VA = "0x233BE50")]
		private bool check_special_str(string val)
		{
			return default(bool);
		}

		[Token(Token = "0x600484D")]
		[Address(RVA = "0x233BF18", Offset = "0x233BF18", VA = "0x233BF18")]
		public bool check_spaces_in_the_string(string val)
		{
			return default(bool);
		}

		[Token(Token = "0x600484E")]
		[Address(RVA = "0x233C184", Offset = "0x233C184", VA = "0x233C184")]
		public ApiReturnCode check(string val)
		{
			return default(ApiReturnCode);
		}

		[Token(Token = "0x600484F")]
		[Address(RVA = "0x233C22C", Offset = "0x233C22C", VA = "0x233C22C")]
		public ApiReturnCode CheckForMatchingRoomName(string val)
		{
			return default(ApiReturnCode);
		}

		[Token(Token = "0x6004850")]
		[Address(RVA = "0x233C204", Offset = "0x233C204", VA = "0x233C204")]
		private bool check_game_contents(string val)
		{
			return default(bool);
		}

		[Token(Token = "0x6004851")]
		[Address(RVA = "0x233C4D8", Offset = "0x233C4D8", VA = "0x233C4D8")]
		public ApiReturnCode check_for_korean_region_special_str(string val)
		{
			return default(ApiReturnCode);
		}

		[Token(Token = "0x6004852")]
		[Address(RVA = "0x233CFAC", Offset = "0x233CFAC", VA = "0x233CFAC")]
		private static bool _003Ccheck_spaces_in_the_string_003Em__1EA(char f)
		{
			return default(bool);
		}
	}
}
