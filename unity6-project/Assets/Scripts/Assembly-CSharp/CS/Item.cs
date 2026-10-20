using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace CS
{
	[Token(Token = "0x2000947")]
	public class Item
	{
		[Token(Token = "0x4002DF5")]
		[FieldOffset(Offset = "0x8")]
		[JsonIgnore]
		private List<int> m_RandomOptionList;

		[Token(Token = "0x4002DF6")]
		[FieldOffset(Offset = "0xC")]
		private string IID__BackingField;

		[Token(Token = "0x4002DF7")]
		[FieldOffset(Offset = "0x10")]
		private int nItemID__BackingField;

		[Token(Token = "0x4002DF8")]
		[FieldOffset(Offset = "0x14")]
		private int StackCount__BackingField;

		[Token(Token = "0x4002DF9")]
		[FieldOffset(Offset = "0x18")]
		private bool IsShowed__BackingField;

		[Token(Token = "0x4002DFA")]
		[FieldOffset(Offset = "0x1C")]
		private int nEhchantXP__BackingField;

		[Token(Token = "0x17000A36")]
		public string IID
		{
			[Token(Token = "0x6004A64")]
			[Address(RVA = "0x2339954", Offset = "0x2339954", VA = "0x2339954")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A65")]
			[Address(RVA = "0x233995C", Offset = "0x233995C", VA = "0x233995C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A37")]
		public int nItemID
		{
			[Token(Token = "0x6004A66")]
			[Address(RVA = "0x2339964", Offset = "0x2339964", VA = "0x2339964")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004A67")]
			[Address(RVA = "0x233996C", Offset = "0x233996C", VA = "0x233996C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A38")]
		public int StackCount
		{
			[Token(Token = "0x6004A68")]
			[Address(RVA = "0x2339974", Offset = "0x2339974", VA = "0x2339974")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004A69")]
			[Address(RVA = "0x233997C", Offset = "0x233997C", VA = "0x233997C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A39")]
		public bool IsShowed
		{
			[Token(Token = "0x6004A6A")]
			[Address(RVA = "0x2339984", Offset = "0x2339984", VA = "0x2339984")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A6B")]
			[Address(RVA = "0x233998C", Offset = "0x233998C", VA = "0x233998C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A3A")]
		public int nEhchantXP
		{
			[Token(Token = "0x6004A6C")]
			[Address(RVA = "0x2339994", Offset = "0x2339994", VA = "0x2339994")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004A6D")]
			[Address(RVA = "0x233999C", Offset = "0x233999C", VA = "0x233999C")]
			set
			{
			}
		}

		[Token(Token = "0x17000A3B")]
		public List<int> RandomOptionList
		{
			[Token(Token = "0x6004A6E")]
			[Address(RVA = "0x23399A4", Offset = "0x23399A4", VA = "0x23399A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A6F")]
			[Address(RVA = "0x2339A54", Offset = "0x2339A54", VA = "0x2339A54")]
			set
			{
			}
		}

		[Token(Token = "0x6004A63")]
		[Address(RVA = "0x23398A8", Offset = "0x23398A8", VA = "0x23398A8")]
		public Item()
		{
		}

		[Token(Token = "0x6004A70")]
		[Address(RVA = "0x2339A5C", Offset = "0x2339A5C", VA = "0x2339A5C")]
		public Netdata_Item ToNetData()
		{
			return null;
		}

		[Token(Token = "0x6004A71")]
		[Address(RVA = "0x2339B3C", Offset = "0x2339B3C", VA = "0x2339B3C")]
		public Netdata_EquipedItem ToEquippedItemNetData()
		{
			return default(Netdata_EquipedItem);
		}
	}
}
