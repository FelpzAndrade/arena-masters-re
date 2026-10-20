using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006CF")]
public class XMySkillControl
{
	[Token(Token = "0x400208A")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<int, LastComboSkillData> m_comboSkillDataDictionary;

	[Token(Token = "0x6003908")]
	[Address(RVA = "0xB75E10", Offset = "0xB75E10", VA = "0xB75E10")]
	public XMySkillControl()
	{
	}

	[Token(Token = "0x6003909")]
	[Address(RVA = "0xB75950", Offset = "0xB75950", VA = "0xB75950")]
	public void UpdateSkillControll(float dt)
	{
	}

	[Token(Token = "0x600390A")]
	[Address(RVA = "0xBA5F2C", Offset = "0xBA5F2C", VA = "0xBA5F2C")]
	private void RemoveComboSkillDatas()
	{
	}

	[Token(Token = "0x600390B")]
	[Address(RVA = "0xB7718C", Offset = "0xB7718C", VA = "0xB7718C")]
	public bool IsProcessingComboSkill(int comboSkillLine)
	{
		return default(bool);
	}

	[Token(Token = "0x600390C")]
	[Address(RVA = "0xB77254", Offset = "0xB77254", VA = "0xB77254")]
	public LastComboSkillData GetLastComboSkillData(int comboSkillLine)
	{
		return null;
	}

	[Token(Token = "0x600390D")]
	[Address(RVA = "0xBA626C", Offset = "0xBA626C", VA = "0xBA626C")]
	private float GetSkillComboTime(GameObject goOwner, CSSkillInfo info)
	{
		return default(float);
	}

	[Token(Token = "0x600390E")]
	[Address(RVA = "0xBA6330", Offset = "0xBA6330", VA = "0xBA6330")]
	private bool TryGetComboSkillID(GameObject goOwner, int nSkillID, out int nActiveSkill)
	{
		nActiveSkill = default;
		return default(bool);
	}

	[Token(Token = "0x600390F")]
	[Address(RVA = "0xBA657C", Offset = "0xBA657C", VA = "0xBA657C")]
	public bool IsCooldown(XModuleSkill moduleSkill, int nSkillID)
	{
		return default(bool);
	}

	[Token(Token = "0x6003910")]
	[Address(RVA = "0xB76D54", Offset = "0xB76D54", VA = "0xB76D54")]
	public bool UseSkill(int nSkillID, GameObject goOwner, XModuleMyControl moduleControl, bool reserve)
	{
		return default(bool);
	}

	[Token(Token = "0x6003911")]
	[Address(RVA = "0xBA65A8", Offset = "0xBA65A8", VA = "0xBA65A8")]
	private bool ActionUseSkill(GameObject goOwner, XModuleMyControl moduleControl, XModuleSkill moduleSkill, int nSkillID, bool currentSkillCanceld)
	{
		return default(bool);
	}

	[Token(Token = "0x6003912")]
	[Address(RVA = "0xBA66A4", Offset = "0xBA66A4", VA = "0xBA66A4")]
	private void RefreshComboSkillData(GameObject goOwner, int nSkillID)
	{
	}

	[Token(Token = "0x6003913")]
	[Address(RVA = "0xBA6990", Offset = "0xBA6990", VA = "0xBA6990")]
	private void RemoveNonChainComboSkill()
	{
	}

	[Token(Token = "0x6003914")]
	[Address(RVA = "0xB770FC", Offset = "0xB770FC", VA = "0xB770FC")]
	public bool UseRelicSkill(int nSkillID, GameObject goOwner, XModuleMyControl moduleControl)
	{
		return default(bool);
	}

	[Token(Token = "0x6003915")]
	[Address(RVA = "0xBA6C74", Offset = "0xBA6C74", VA = "0xBA6C74")]
	private bool ActionUseRelicSkill(GameObject goOwner, XModuleMyControl moduleControl, XModuleSkill moduleSkill, int nSkillID)
	{
		return default(bool);
	}
}
