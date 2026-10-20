using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B86")]
	public sealed class CSTrophyRewardXML
	{
		[Token(Token = "0x4003A48")]
		[FieldOffset(Offset = "0x8")]
		public List<CSTrophyReward> dataList;

		[Token(Token = "0x600536E")]
		[Address(RVA = "0x1CD9AD4", Offset = "0x1CD9AD4", VA = "0x1CD9AD4")]
		public CSTrophyRewardXML()
		{
		}

		[Token(Token = "0x600536F")]
		[Address(RVA = "0x1CD9B80", Offset = "0x1CD9B80", VA = "0x1CD9B80")]
		public void Add(CSTrophyReward i)
		{
		}
	}
}
