using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2001009")]
public class XMakeDescription
{
	[Token(Token = "0x600779B")]
	[Address(RVA = "0x1E29D34", Offset = "0x1E29D34", VA = "0x1E29D34")]
	public XMakeDescription()
	{
	}

	[Token(Token = "0x600779C")]
	[Address(RVA = "0x1E29D3C", Offset = "0x1E29D3C", VA = "0x1E29D3C")]
	public string GetDescription(string desc, CharStatus defaultStatus, int buffID1 = 0, int buffID2 = 0, int buffID3 = 0)
	{
		return null;
	}

	[Token(Token = "0x600779D")]
	[Address(RVA = "0x1E2A94C", Offset = "0x1E2A94C", VA = "0x1E2A94C")]
	public string GetDescription(SkillSpecializationInfo specializationInfo)
	{
		return null;
	}

	[Token(Token = "0x600779E")]
	[Address(RVA = "0x1E2ABE0", Offset = "0x1E2ABE0", VA = "0x1E2ABE0")]
	public string GetDescription(CSSkillInfo skillInfo, string desc, int level, [Optional] SkillSpecializationInfo[] statusGrowth)
	{
		return null;
	}

	[Token(Token = "0x600779F")]
	[Address(RVA = "0x1E29F60", Offset = "0x1E29F60", VA = "0x1E29F60")]
	private string MakeNameDescription(string desc)
	{
		return null;
	}

	[Token(Token = "0x60077A0")]
	[Address(RVA = "0x1E2B0BC", Offset = "0x1E2B0BC", VA = "0x1E2B0BC")]
	private bool ReplaceNextSkill(out CSSkillInfo nextSkillInfo, ref string desc, int skillID)
	{
		nextSkillInfo = default;
		return default(bool);
	}

	[Token(Token = "0x60077A1")]
	[Address(RVA = "0x1E2B790", Offset = "0x1E2B790", VA = "0x1E2B790")]
	public CSSkillInfo GetNextSkill(string detailPrefix, string desc)
	{
		return null;
	}

	[Token(Token = "0x60077A2")]
	[Address(RVA = "0x1E2A5CC", Offset = "0x1E2A5CC", VA = "0x1E2A5CC")]
	private string MakeDescriptionForBuffImpl(string text, int buffid, int index)
	{
		return null;
	}

	[Token(Token = "0x60077A3")]
	[Address(RVA = "0x1E2A3FC", Offset = "0x1E2A3FC", VA = "0x1E2A3FC")]
	private string MakeDescriptionForSkillInfoImpl(string desc, string prefix, CharStatus defaultStatus)
	{
		return null;
	}

	[Token(Token = "0x60077A4")]
	[Address(RVA = "0x1E2AB1C", Offset = "0x1E2AB1C", VA = "0x1E2AB1C")]
	private string MakeNotContainStatus_SkillSpecialization(string desc, SkillSpecializationInfo specializationInfo)
	{
		return null;
	}

	[Token(Token = "0x60077A5")]
	[Address(RVA = "0x1E2AFE0", Offset = "0x1E2AFE0", VA = "0x1E2AFE0")]
	private string MakeNotContainStatus_Skill(string desc, float damageRtio, float healRatioPerMaxHp)
	{
		return null;
	}

	[Token(Token = "0x60077A6")]
	[Address(RVA = "0x1E2BB1C", Offset = "0x1E2BB1C", VA = "0x1E2BB1C")]
	public string MakeColorDescriotion(string text)
	{
		return null;
	}

	[Token(Token = "0x60077A7")]
	[Address(RVA = "0x1E2BC94", Offset = "0x1E2BC94", VA = "0x1E2BC94")]
	private string MakeDescriptionForStatusImpl(string text, string prefix, CharStatus status)
	{
		return null;
	}

	[Token(Token = "0x60077A8")]
	[Address(RVA = "0x1E2BE4C", Offset = "0x1E2BE4C", VA = "0x1E2BE4C")]
	private string MakeNotContainStatusImpl(string prefix, string desc, string fieldName, float value, bool isRatio)
	{
		return null;
	}
}
