using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000970")]
	public class PlacementTestInfo
	{
		[Token(Token = "0x4002EB5")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<RankType, PtPlayData> DicPtPlayData__BackingField;

		[Token(Token = "0x17000AD3")]
		public Dictionary<RankType, PtPlayData> DicPtPlayData
		{
			[Token(Token = "0x6004C0F")]
			[Address(RVA = "0x21AE2F4", Offset = "0x21AE2F4", VA = "0x21AE2F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C10")]
			[Address(RVA = "0x21AE2EC", Offset = "0x21AE2EC", VA = "0x21AE2EC")]
			set
			{
			}
		}

		[Token(Token = "0x6004C0E")]
		[Address(RVA = "0x21AE240", Offset = "0x21AE240", VA = "0x21AE240")]
		public PlacementTestInfo()
		{
		}
	}
}
