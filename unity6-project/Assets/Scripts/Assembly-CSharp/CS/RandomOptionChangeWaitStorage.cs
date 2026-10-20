using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000972")]
	public class RandomOptionChangeWaitStorage
	{
		[Token(Token = "0x4002EBA")]
		[FieldOffset(Offset = "0x8")]
		public string targetIID;

		[Token(Token = "0x4002EBB")]
		[FieldOffset(Offset = "0xC")]
		public string targetCID;

		[Token(Token = "0x4002EBC")]
		[FieldOffset(Offset = "0x10")]
		public EquipmentSlot targetSlot;

		[Token(Token = "0x4002EBD")]
		[FieldOffset(Offset = "0x14")]
		public List<int> RandomOptionChangeWaitList;

		[Token(Token = "0x4002EBE")]
		[FieldOffset(Offset = "0x18")]
		private int SelectedChangeIndex__BackingField;

		[Token(Token = "0x17000AD4")]
		public int SelectedChangeIndex
		{
			[Token(Token = "0x6004C15")]
			[Address(RVA = "0x21BFEE0", Offset = "0x21BFEE0", VA = "0x21BFEE0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004C16")]
			[Address(RVA = "0x21BFEE8", Offset = "0x21BFEE8", VA = "0x21BFEE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000AD5")]
		public bool IsEmpty
		{
			[Token(Token = "0x6004C17")]
			[Address(RVA = "0x21BFEF0", Offset = "0x21BFEF0", VA = "0x21BFEF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000AD6")]
		public int WaitListCount
		{
			[Token(Token = "0x6004C18")]
			[Address(RVA = "0x21BFF9C", Offset = "0x21BFF9C", VA = "0x21BFF9C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6004C14")]
		[Address(RVA = "0x21BFE34", Offset = "0x21BFE34", VA = "0x21BFE34")]
		public RandomOptionChangeWaitStorage()
		{
		}

		[Token(Token = "0x6004C19")]
		[Address(RVA = "0x21C0030", Offset = "0x21C0030", VA = "0x21C0030")]
		public int GetChangeRandomOptionID(int index)
		{
			return default(int);
		}

		[Token(Token = "0x6004C1A")]
		[Address(RVA = "0x21C0114", Offset = "0x21C0114", VA = "0x21C0114")]
		public void Clear()
		{
		}
	}
}
