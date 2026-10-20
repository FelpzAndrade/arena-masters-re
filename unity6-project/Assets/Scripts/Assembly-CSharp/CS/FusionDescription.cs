using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B01")]
	public sealed class FusionDescription
	{
		[Token(Token = "0x2000B02")]
		public struct Entry
		{
			[Token(Token = "0x4003639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int itemID;

			[Token(Token = "0x400363A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float ratio;
		}

		[Token(Token = "0x4003634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EquipmentSlot slotType;

		[Token(Token = "0x4003635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public ItemRarity rarityType;

		[Token(Token = "0x4003636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int gold;

		[Token(Token = "0x4003637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private List<Entry> resultItemIDs;

		[Token(Token = "0x4003638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_rateSum;

		[Token(Token = "0x600510B")]
		[Address(RVA = "0x2333C04", Offset = "0x2333C04", VA = "0x2333C04")]
		public FusionDescription()
		{
		}

		[Token(Token = "0x600510C")]
		[Address(RVA = "0x2333CB0", Offset = "0x2333CB0", VA = "0x2333CB0")]
		public FusionDescription(EquipmentSlot slotType, ItemRarity rarityType, int gold)
		{
		}

		[Token(Token = "0x600510D")]
		[Address(RVA = "0x2333D74", Offset = "0x2333D74", VA = "0x2333D74")]
		public int GetPrice([Optional] DateTime? serverLocalNow, [Optional] CSHotTimeEventList hottimes)
		{
			return default(int);
		}

		[Token(Token = "0x600510E")]
		[Address(RVA = "0x2333EE4", Offset = "0x2333EE4", VA = "0x2333EE4")]
		public int GetRatio([Optional] DateTime? serverLocalNow, [Optional] CSHotTimeEventList hottimes)
		{
			return default(int);
		}

		[Token(Token = "0x600510F")]
		[Address(RVA = "0x2334024", Offset = "0x2334024", VA = "0x2334024")]
		public void AddItem(int id, float ratio)
		{
		}

		[Token(Token = "0x6005110")]
		[Address(RVA = "0x2334150", Offset = "0x2334150", VA = "0x2334150")]
		public int GetResult(Random random)
		{
			return default(int);
		}
	}
}
