using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000AA4")]
	public class CSCharacterSkillInfo
	{
		[Token(Token = "0x2000AA5")]
		public enum SkillType
		{
			[Token(Token = "0x4003203")]
			None = -1,
			[Token(Token = "0x4003204")]
			Default_Skill = 0,
			[Token(Token = "0x4003205")]
			Skill_1 = 1,
			[Token(Token = "0x4003206")]
			Skill_2 = 2,
			[Token(Token = "0x4003207")]
			Skill_3 = 3,
			[Token(Token = "0x4003208")]
			Dodge_Skill = 4,
			[Token(Token = "0x4003209")]
			Ultimate_Skill = 5,
			[Token(Token = "0x400320A")]
			Relic_Skill_1 = 6,
			[Token(Token = "0x400320B")]
			Relic_Skill_2 = 7,
			[Token(Token = "0x400320C")]
			Tag = 8,
			[Token(Token = "0x400320D")]
			Greeting = 9,
			[Token(Token = "0x400320E")]
			Passive_Skill_1 = 10,
			[Token(Token = "0x400320F")]
			Passive_Skill_2 = 11
		}

		[Token(Token = "0x40031FF")]
		[FieldOffset(Offset = "0x8")]
		public SkillType Type;

		[Token(Token = "0x4003200")]
		[FieldOffset(Offset = "0xC")]
		public CSSkillInfo SkillInfo;

		[Token(Token = "0x4003201")]
		[FieldOffset(Offset = "0x10")]
		private int ReqLv;

		[Token(Token = "0x17000B20")]
		public bool IsDefaultSkill
		{
			[Token(Token = "0x6004E74")]
			[Address(RVA = "0x22287AC", Offset = "0x22287AC", VA = "0x22287AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B21")]
		public bool IsUltimateSkill
		{
			[Token(Token = "0x6004E75")]
			[Address(RVA = "0x22287C0", Offset = "0x22287C0", VA = "0x22287C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B22")]
		public bool IsTagSkill
		{
			[Token(Token = "0x6004E76")]
			[Address(RVA = "0x22287D4", Offset = "0x22287D4", VA = "0x22287D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B23")]
		public bool IsDodge_Skill
		{
			[Token(Token = "0x6004E77")]
			[Address(RVA = "0x22287E8", Offset = "0x22287E8", VA = "0x22287E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B24")]
		public bool IsPassiveSkill
		{
			[Token(Token = "0x6004E78")]
			[Address(RVA = "0x22287FC", Offset = "0x22287FC", VA = "0x22287FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B25")]
		public bool IsUpgradableSkill
		{
			[Token(Token = "0x6004E7A")]
			[Address(RVA = "0x2228850", Offset = "0x2228850", VA = "0x2228850")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B26")]
		public bool IsCombatSkill
		{
			[Token(Token = "0x6004E7B")]
			[Address(RVA = "0x2228874", Offset = "0x2228874", VA = "0x2228874")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6004E73")]
		[Address(RVA = "0x2228778", Offset = "0x2228778", VA = "0x2228778")]
		public CSCharacterSkillInfo(SkillType type, CSSkillInfo info)
		{
		}

		[Token(Token = "0x6004E79")]
		[Address(RVA = "0x2228814", Offset = "0x2228814", VA = "0x2228814")]
		public int GetRequireLv()
		{
			return default(int);
		}
	}
}
