using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000992")]
	public class Netdata_CreationDesc
	{
		[Token(Token = "0x2000993")]
		public class CharDesc
		{
			[Token(Token = "0x4002F41")]
			[FieldOffset(Offset = "0x8")]
			public int charId;

			[Token(Token = "0x4002F42")]
			[FieldOffset(Offset = "0xC")]
			public int level;

			[Token(Token = "0x4002F43")]
			[FieldOffset(Offset = "0x10")]
			public int skinId;

			[Token(Token = "0x4002F44")]
			[FieldOffset(Offset = "0x14")]
			public Netdata_EquipedItem[] equiped_items;

			[Token(Token = "0x4002F45")]
			[FieldOffset(Offset = "0x18")]
			public SkillSpecialized specialized_skill_list;

			[Token(Token = "0x6004CD0")]
			[Address(RVA = "0x233FF88", Offset = "0x233FF88", VA = "0x233FF88")]
			public CharDesc()
			{
			}
		}

		[Token(Token = "0x4002F35")]
		[FieldOffset(Offset = "0x8")]
		public bool isNPC;

		[Token(Token = "0x4002F36")]
		[FieldOffset(Offset = "0x9")]
		public bool isBalanceRegulate;

		[Token(Token = "0x4002F37")]
		[FieldOffset(Offset = "0xA")]
		public bool isPVP;

		[Token(Token = "0x4002F38")]
		[FieldOffset(Offset = "0xC")]
		public int relicId;

		[Token(Token = "0x4002F39")]
		[FieldOffset(Offset = "0x10")]
		public int relicLevel;

		[Token(Token = "0x4002F3A")]
		[FieldOffset(Offset = "0x14")]
		public int charIndex;

		[Token(Token = "0x4002F3B")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<int, int> talentSkillPage;

		[Token(Token = "0x4002F3C")]
		[FieldOffset(Offset = "0x1C")]
		public List<int> orderCharIDList;

		[Token(Token = "0x4002F3D")]
		[FieldOffset(Offset = "0x20")]
		public int emblemID;

		[Token(Token = "0x4002F3E")]
		[FieldOffset(Offset = "0x24")]
		public CharDesc[] charDesc;

		[Token(Token = "0x4002F3F")]
		[FieldOffset(Offset = "0x28")]
		public bool PetIsNotShowed;

		[Token(Token = "0x4002F40")]
		[FieldOffset(Offset = "0x2C")]
		public CharDesc petDesc;

		[Token(Token = "0x6004CCF")]
		[Address(RVA = "0x233FF6C", Offset = "0x233FF6C", VA = "0x233FF6C")]
		public Netdata_CreationDesc()
		{
		}
	}
}
