using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B05")]
	public sealed class ItemBalanceInfoRarity
	{
		[Token(Token = "0x4003648")]
		[FieldOffset(Offset = "0x8")]
		public ItemRarity itemRarity;

		[Token(Token = "0x4003649")]
		[FieldOffset(Offset = "0xC")]
		public List<float> itemPerformance_List;

		[Token(Token = "0x400364A")]
		[FieldOffset(Offset = "0x10")]
		public List<int> itemXP_List;

		[Token(Token = "0x6005122")]
		[Address(RVA = "0x2339C6C", Offset = "0x2339C6C", VA = "0x2339C6C")]
		public ItemBalanceInfoRarity()
		{
		}
	}
}
