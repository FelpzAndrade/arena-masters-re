using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AC7")]
	public class CSEventAttendanceBookItem
	{
		[Token(Token = "0x400327F")]
		[FieldOffset(Offset = "0x8")]
		public int id;

		[Token(Token = "0x4003280")]
		[FieldOffset(Offset = "0xC")]
		public int group;

		[Token(Token = "0x4003281")]
		[FieldOffset(Offset = "0x10")]
		public string str_start_date;

		[Token(Token = "0x4003282")]
		[FieldOffset(Offset = "0x14")]
		public string str_end_date;

		[Token(Token = "0x4003283")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		[Token(Token = "0x4003284")]
		[FieldOffset(Offset = "0x1C")]
		public string popup_image;

		[Token(Token = "0x4003285")]
		[FieldOffset(Offset = "0x20")]
		public int day;

		[Token(Token = "0x4003286")]
		[FieldOffset(Offset = "0x24")]
		public string str_main_des;

		[Token(Token = "0x4003287")]
		[FieldOffset(Offset = "0x28")]
		public string str_sub_des;

		[Token(Token = "0x4003288")]
		[FieldOffset(Offset = "0x2C")]
		public string str_des;

		[Token(Token = "0x4003289")]
		[FieldOffset(Offset = "0x30")]
		public string reward_image;

		[Token(Token = "0x400328A")]
		[FieldOffset(Offset = "0x34")]
		public CSContentType reward_type1;

		[Token(Token = "0x400328B")]
		[FieldOffset(Offset = "0x38")]
		public int reward_id1;

		[Token(Token = "0x400328C")]
		[FieldOffset(Offset = "0x3C")]
		public int reward_amount1;

		[Token(Token = "0x400328D")]
		[FieldOffset(Offset = "0x40")]
		public CSContentType reward_type2;

		[Token(Token = "0x400328E")]
		[FieldOffset(Offset = "0x44")]
		public int reward_id2;

		[Token(Token = "0x400328F")]
		[FieldOffset(Offset = "0x48")]
		public int reward_amount2;

		[Token(Token = "0x4003290")]
		[FieldOffset(Offset = "0x4C")]
		public string strShowEffect;

		[Token(Token = "0x4003291")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isShowEffect;

		[Token(Token = "0x4003292")]
		[FieldOffset(Offset = "0x54")]
		[XmlIgnore]
		public List<CSContent> rewardList;

		[Token(Token = "0x4003293")]
		[FieldOffset(Offset = "0x58")]
		public DateTime start_date;

		[Token(Token = "0x4003294")]
		[FieldOffset(Offset = "0x68")]
		public DateTime end_date;

		[Token(Token = "0x17000B30")]
		public bool IsShowEffect
		{
			[Token(Token = "0x6004F18")]
			[Address(RVA = "0x222C224", Offset = "0x222C224", VA = "0x222C224")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6004F17")]
		[Address(RVA = "0x222C110", Offset = "0x222C110", VA = "0x222C110")]
		public CSEventAttendanceBookItem()
		{
		}

		[Token(Token = "0x6004F19")]
		[Address(RVA = "0x222C22C", Offset = "0x222C22C", VA = "0x222C22C")]
		public bool Cooking()
		{
			return default(bool);
		}
	}
}
