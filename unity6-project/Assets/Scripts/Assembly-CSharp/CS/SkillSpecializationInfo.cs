using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B64")]
	public sealed class SkillSpecializationInfo
	{
		[Token(Token = "0x4003966")]
		[FieldOffset(Offset = "0x8")]
		public int m_skill_id;

		[Token(Token = "0x4003967")]
		[FieldOffset(Offset = "0xC")]
		public string m_name;

		[Token(Token = "0x4003968")]
		[FieldOffset(Offset = "0x10")]
		public int m_specialization_id;

		[Token(Token = "0x4003969")]
		[FieldOffset(Offset = "0x14")]
		public int m_level;

		[Token(Token = "0x400396A")]
		[FieldOffset(Offset = "0x18")]
		public SpecializeType m_type;

		[Token(Token = "0x400396B")]
		[FieldOffset(Offset = "0x1C")]
		public string m_target_id;

		[Token(Token = "0x400396C")]
		[FieldOffset(Offset = "0x20")]
		[XmlIgnore]
		public List<int> m_target_id_list;

		[Token(Token = "0x400396D")]
		[FieldOffset(Offset = "0x24")]
		public string m_desc;

		[Token(Token = "0x400396E")]
		[FieldOffset(Offset = "0x28")]
		public string strIcon;

		[Token(Token = "0x400396F")]
		[FieldOffset(Offset = "0x2C")]
		public float m_damageRatio;

		[Token(Token = "0x4003970")]
		[FieldOffset(Offset = "0x30")]
		public CharStatus StatusGrowth;

		[Token(Token = "0x4003971")]
		[FieldOffset(Offset = "0x34")]
		private int MaxLevel__BackingField;

		[Token(Token = "0x17000C27")]
		public int MaxLevel
		{
			[Token(Token = "0x60052F8")]
			[Address(RVA = "0x21E2608", Offset = "0x21E2608", VA = "0x21E2608")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60052F9")]
			[Address(RVA = "0x21E2610", Offset = "0x21E2610", VA = "0x21E2610")]
			set
			{
			}
		}

		[Token(Token = "0x60052F7")]
		[Address(RVA = "0x21E24F0", Offset = "0x21E24F0", VA = "0x21E24F0")]
		public SkillSpecializationInfo()
		{
		}
	}
}
