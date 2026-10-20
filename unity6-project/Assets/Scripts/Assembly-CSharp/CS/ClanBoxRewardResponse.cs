using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20009B6")]
	public class ClanBoxRewardResponse
	{
		[Token(Token = "0x4002F69")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string String;

		[Token(Token = "0x4002F6A")]
		[FieldOffset(Offset = "0x8")]
		public bool isMail;

		[Token(Token = "0x4002F6B")]
		[FieldOffset(Offset = "0xC")]
		public List<CSContent> rewards;

		[Token(Token = "0x6004CF4")]
		[Address(RVA = "0x23EB57C", Offset = "0x23EB57C", VA = "0x23EB57C")]
		public ClanBoxRewardResponse()
		{
		}
	}
}
