using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS.ranking
{
	[Token(Token = "0x2000A23")]
	public class RoyalRewardPackage
	{
		[Token(Token = "0x4002FFE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string String;

		[Token(Token = "0x4002FFF")]
		[FieldOffset(Offset = "0x8")]
		public string rewardGrade;

		[Token(Token = "0x4003000")]
		[FieldOffset(Offset = "0xC")]
		public bool isMail;

		[Token(Token = "0x4003001")]
		[FieldOffset(Offset = "0x10")]
		public List<CSContent> royalRewards;

		[Token(Token = "0x6004D70")]
		[Address(RVA = "0x21C0724", Offset = "0x21C0724", VA = "0x21C0724")]
		public RoyalRewardPackage()
		{
		}
	}
}
