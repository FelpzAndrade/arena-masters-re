using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B0B")]
	public sealed class ItemSetInfo
	{
		[Token(Token = "0x400364E")]
		[XmlIgnore]
		public const string iconPath_Weapon = "icon_set_weapon";

		[Token(Token = "0x400364F")]
		[XmlIgnore]
		public const string iconPath_Armor = "icon_set_armor";

		[Token(Token = "0x4003650")]
		[XmlIgnore]
		public const string iconPath_Gloves = "icon_set_glove";

		[Token(Token = "0x4003651")]
		[XmlIgnore]
		public const string iconPath_Shoes = "icon_set_shoes";

		[Token(Token = "0x4003652")]
		[XmlIgnore]
		public const string iconPath_Necklace = "icon_set_necklace";

		[Token(Token = "0x4003653")]
		[XmlIgnore]
		public const string iconPath_Ring = "icon_set_ring";

		[Token(Token = "0x4003654")]
		[XmlIgnore]
		public const string iconPath_Brooch = "icon_set_brooch";

		[Token(Token = "0x4003655")]
		[XmlIgnore]
		public const string iconPath_Bracelet = "icon_set_bracelet";

		[Token(Token = "0x4003656")]
		[XmlIgnore]
		public const string iconPath_Earring = "icon_set_earring";

		[Token(Token = "0x4003657")]
		[FieldOffset(Offset = "0x8")]
		public int setId;

		[Token(Token = "0x4003658")]
		[FieldOffset(Offset = "0xC")]
		public string setName;

		[Token(Token = "0x4003659")]
		[FieldOffset(Offset = "0x10")]
		public string set_buff_name;

		[Token(Token = "0x400365A")]
		[FieldOffset(Offset = "0x14")]
		public int item1_id;

		[Token(Token = "0x400365B")]
		[FieldOffset(Offset = "0x18")]
		public int item2_id;

		[Token(Token = "0x400365C")]
		[FieldOffset(Offset = "0x1C")]
		public int item3_id;

		[Token(Token = "0x400365D")]
		[FieldOffset(Offset = "0x20")]
		public int item4_id;

		[Token(Token = "0x400365E")]
		[FieldOffset(Offset = "0x24")]
		public int setCount2_BuffId;

		[Token(Token = "0x400365F")]
		[FieldOffset(Offset = "0x28")]
		public int setCount3_BuffId;

		[Token(Token = "0x4003660")]
		[FieldOffset(Offset = "0x2C")]
		public int setCount4_BuffId;

		[Token(Token = "0x4003661")]
		[FieldOffset(Offset = "0x30")]
		[XmlIgnore]
		public Dictionary<int, EquipmentSlot> setItemEquipTypeDic;

		[Token(Token = "0x4003662")]
		[FieldOffset(Offset = "0x34")]
		[XmlIgnore]
		public List<int> setBuffIdList;

		[Token(Token = "0x600513A")]
		[Address(RVA = "0x2339D4C", Offset = "0x2339D4C", VA = "0x2339D4C")]
		public ItemSetInfo()
		{
		}

		[Token(Token = "0x600513B")]
		[Address(RVA = "0x2339E98", Offset = "0x2339E98", VA = "0x2339E98")]
		public static string GetIconPath(EquipmentSlot itemType)
		{
			return null;
		}
	}
}
