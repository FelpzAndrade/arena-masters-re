using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B04")]
	public sealed class CSItemBalanceInfo
	{
		[Token(Token = "0x400363C")]
		[FieldOffset(Offset = "0x8")]
		public float iPerformeceRatio_common;

		[Token(Token = "0x400363D")]
		[FieldOffset(Offset = "0xC")]
		public float iPerformeceRatio_uncommon;

		[Token(Token = "0x400363E")]
		[FieldOffset(Offset = "0x10")]
		public float iPerformeceRatio_rare;

		[Token(Token = "0x400363F")]
		[FieldOffset(Offset = "0x14")]
		public float iPerformeceRatio_epic;

		[Token(Token = "0x4003640")]
		[FieldOffset(Offset = "0x18")]
		public float iPerformeceRatio_legend;

		[Token(Token = "0x4003641")]
		[FieldOffset(Offset = "0x1C")]
		public float iPerformeceRatio_ancient;

		[Token(Token = "0x4003642")]
		[FieldOffset(Offset = "0x20")]
		public int iXP_common;

		[Token(Token = "0x4003643")]
		[FieldOffset(Offset = "0x24")]
		public int iXP_uncommon;

		[Token(Token = "0x4003644")]
		[FieldOffset(Offset = "0x28")]
		public int iXP_rare;

		[Token(Token = "0x4003645")]
		[FieldOffset(Offset = "0x2C")]
		public int iXP_epic;

		[Token(Token = "0x4003646")]
		[FieldOffset(Offset = "0x30")]
		public int iXP_legend;

		[Token(Token = "0x4003647")]
		[FieldOffset(Offset = "0x34")]
		public int iXP_ancient;

		[Token(Token = "0x6005120")]
		[Address(RVA = "0x22356E0", Offset = "0x22356E0", VA = "0x22356E0")]
		public CSItemBalanceInfo()
		{
		}

		[Token(Token = "0x6005121")]
		[Address(RVA = "0x22356E8", Offset = "0x22356E8", VA = "0x22356E8")]
		public void Cooking()
		{
		}
	}
}
