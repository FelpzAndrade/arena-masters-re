using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E72")]
public class XWidget_SkillSpecializationItem : XWidget_SkillIcon
{
	[Token(Token = "0x4004BAD")]
	[FieldOffset(Offset = "0x24")]
	private int m_maxLevel;

	[Token(Token = "0x4004BAE")]
	[FieldOffset(Offset = "0x28")]
	public UILabel lblLevel;

	[Token(Token = "0x4004BAF")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject skillLevelUpEffect;

	[Token(Token = "0x4004BB0")]
	[FieldOffset(Offset = "0x30")]
	private SkillSpecializationInfo SpecializationInfo__BackingField;

	[Token(Token = "0x4004BB1")]
	[FieldOffset(Offset = "0x34")]
	private int Level__BackingField;

	[Token(Token = "0x17000DDA")]
	public SkillSpecializationInfo SpecializationInfo
	{
		[Token(Token = "0x6006BD0")]
		[Address(RVA = "0x1B0847C", Offset = "0x1B0847C", VA = "0x1B0847C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006BD1")]
		[Address(RVA = "0x1B08484", Offset = "0x1B08484", VA = "0x1B08484")]
		private set
		{
		}
	}

	[Token(Token = "0x17000DDB")]
	public int Level
	{
		[Token(Token = "0x6006BD2")]
		[Address(RVA = "0x1B0848C", Offset = "0x1B0848C", VA = "0x1B0848C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006BD3")]
		[Address(RVA = "0x1B08494", Offset = "0x1B08494", VA = "0x1B08494")]
		private set
		{
		}
	}

	[Token(Token = "0x6006BCF")]
	[Address(RVA = "0x1B08474", Offset = "0x1B08474", VA = "0x1B08474")]
	public XWidget_SkillSpecializationItem()
	{
	}

	[Token(Token = "0x6006BD4")]
	[Address(RVA = "0x1B0849C", Offset = "0x1B0849C", VA = "0x1B0849C")]
	public void Build(SkillSpecializationInfo specializationInfo, int level, int maxLevel)
	{
	}

	[Token(Token = "0x6006BD5")]
	[Address(RVA = "0x1B087D0", Offset = "0x1B087D0", VA = "0x1B087D0")]
	public void RefreshNextLevel()
	{
	}

	[Token(Token = "0x6006BD6")]
	[Address(RVA = "0x1B08640", Offset = "0x1B08640", VA = "0x1B08640")]
	protected void BuildLevel(int level, int maxLevel)
	{
	}

	[Token(Token = "0x6006BD7")]
	[Address(RVA = "0x1B0899C", Offset = "0x1B0899C", VA = "0x1B0899C")]
	public bool IsMaxLevel()
	{
		return default(bool);
	}
}
