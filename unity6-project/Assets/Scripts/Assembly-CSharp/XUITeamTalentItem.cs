using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F5F")]
public class XUITeamTalentItem : MonoBehaviour
{
	[Token(Token = "0x40050B4")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprIcon;

	[Token(Token = "0x40050B5")]
	[FieldOffset(Offset = "0x10")]
	public UIBasicSprite sprArrow_down;

	[Token(Token = "0x40050B6")]
	[FieldOffset(Offset = "0x14")]
	public UIBasicSprite sprArrow_up;

	[Token(Token = "0x40050B7")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblLevel;

	[Token(Token = "0x40050B8")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject goSprHide;

	[Token(Token = "0x40050B9")]
	[FieldOffset(Offset = "0x20")]
	private TalentInfo m_talentInfo;

	[Token(Token = "0x40050BA")]
	[FieldOffset(Offset = "0x24")]
	private Action<TalentInfo> m_action;

	[Token(Token = "0x40050BB")]
	[FieldOffset(Offset = "0x28")]
	public XUIEffectPool effectPool;

	[Token(Token = "0x40050BC")]
	[FieldOffset(Offset = "0x2C")]
	private int m_index;

	[Token(Token = "0x40050BD")]
	[FieldOffset(Offset = "0x30")]
	private int m_level;

	[Token(Token = "0x40050BE")]
	[FieldOffset(Offset = "0x34")]
	public GameObject goSprSelect;

	[Token(Token = "0x40050BF")]
	[FieldOffset(Offset = "0x38")]
	private Action<XUITeamTalentItem> m_itemAction;

	[Token(Token = "0x40050C0")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject goSprLock;

	[Token(Token = "0x40050C1")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map17;

	[Token(Token = "0x17000E97")]
	public int TalentID
	{
		[Token(Token = "0x600722C")]
		[Address(RVA = "0x19352B4", Offset = "0x19352B4", VA = "0x19352B4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600722B")]
	[Address(RVA = "0x19352AC", Offset = "0x19352AC", VA = "0x19352AC")]
	public XUITeamTalentItem()
	{
	}

	[Token(Token = "0x600722D")]
	[Address(RVA = "0x19352C8", Offset = "0x19352C8", VA = "0x19352C8")]
	public void GetComponentAction(Action<TalentInfo> action, Action<XUITeamTalentItem> itemAction)
	{
	}

	[Token(Token = "0x600722E")]
	[Address(RVA = "0x19352D4", Offset = "0x19352D4", VA = "0x19352D4")]
	public void Build(int attackLearnedTP, int defenceLearnedTP, TalentInfo talentInfo, string pageNumber, int groupItemCount = 1, int Index = 0)
	{
	}

	[Token(Token = "0x600722F")]
	[Address(RVA = "0x1936250", Offset = "0x1936250", VA = "0x1936250")]
	private void BuildArrow(string pageNumber, TalentInfo talentInfo, int itemIndex, int groupItemCount, int attackLearnedTP, int defenceLearnedTP)
	{
	}

	[Token(Token = "0x6007230")]
	[Address(RVA = "0x19368E8", Offset = "0x19368E8", VA = "0x19368E8")]
	private void SetArrowActive(int precedence, int groupItemCount, string color)
	{
	}

	[Token(Token = "0x6007231")]
	[Address(RVA = "0x1936A78", Offset = "0x1936A78", VA = "0x1936A78")]
	private void SetLearnArrow(int precedenceNumber, int index, bool groupMaxItemCount, bool attackType)
	{
	}

	[Token(Token = "0x6007232")]
	[Address(RVA = "0x19360F0", Offset = "0x19360F0", VA = "0x19360F0")]
	private void BuildArrowForm(int groupItemCount)
	{
	}

	[Token(Token = "0x6007233")]
	[Address(RVA = "0x1936CD8", Offset = "0x1936CD8", VA = "0x1936CD8")]
	private void SetArrowHeight(UIBasicSprite sprUp, int upHeight, UIBasicSprite sprDown, int downHeight)
	{
	}

	[Token(Token = "0x6007234")]
	[Address(RVA = "0x1936BA0", Offset = "0x1936BA0", VA = "0x1936BA0")]
	private void SetArrowRotation(GameObject go, float x, float y, float z)
	{
	}

	[Token(Token = "0x6007235")]
	[Address(RVA = "0x1936C50", Offset = "0x1936C50", VA = "0x1936C50")]
	private void SetArrowPositionY(GameObject go, float y)
	{
	}

	[Token(Token = "0x6007236")]
	[Address(RVA = "0x1935D24", Offset = "0x1935D24", VA = "0x1935D24")]
	private void SetColorAndDepth(UIBasicSprite sprite, string type, int depth)
	{
	}

	[Token(Token = "0x6007237")]
	[Address(RVA = "0x1936658", Offset = "0x1936658", VA = "0x1936658")]
	private int GetPrecedenceNumber(List<TalentInfo> list, TalentInfo talentInfo, string pageNumber)
	{
		return default(int);
	}

	[Token(Token = "0x6007238")]
	[Address(RVA = "0x1936D24", Offset = "0x1936D24", VA = "0x1936D24")]
	public void SetSelectSprite(bool state)
	{
	}

	[Token(Token = "0x6007239")]
	[Address(RVA = "0x1935B18", Offset = "0x1935B18", VA = "0x1935B18")]
	public string BuildLevel(string pageNumber, TalentInfo talentInfo)
	{
		return null;
	}

	[Token(Token = "0x600723A")]
	[Address(RVA = "0x1936D68", Offset = "0x1936D68", VA = "0x1936D68")]
	private int GetLevel(string pageNumber, TalentInfo talentInfo)
	{
		return default(int);
	}

	[Token(Token = "0x600723B")]
	[Address(RVA = "0x1936E94", Offset = "0x1936E94", VA = "0x1936E94")]
	public KeyValuePair<int, int>? GetStat(string pageNumber, int statID)
	{
		return null;
	}

	[Token(Token = "0x600723C")]
	[Address(RVA = "0x19368B0", Offset = "0x19368B0", VA = "0x19368B0")]
	private bool IsPossibleToTalent(TalentInfo talentInfo, bool bLearn, int nLevel, int nConditionLevel, int talentPoint, int attackLearnedTP, int defenceLearnedTP)
	{
		return default(bool);
	}

	[Token(Token = "0x600723D")]
	[Address(RVA = "0x1935CF8", Offset = "0x1935CF8", VA = "0x1935CF8")]
	private bool CheckLock(TalentInfo talentInfo, int nLevel, int attackLearnedTP, int defenceLearnedTP)
	{
		return default(bool);
	}

	[Token(Token = "0x600723E")]
	[Address(RVA = "0x1936524", Offset = "0x1936524", VA = "0x1936524")]
	public bool IsExistGroup(string pageNumber, int group_number)
	{
		return default(bool);
	}

	[Token(Token = "0x600723F")]
	[Address(RVA = "0x19369A0", Offset = "0x19369A0", VA = "0x19369A0")]
	public bool IsExistStat(string pageNumber, int id)
	{
		return default(bool);
	}

	[Token(Token = "0x6007240")]
	[Address(RVA = "0x1935910", Offset = "0x1935910", VA = "0x1935910")]
	private CSSkillInfo GetSkillInfo(int skillID)
	{
		return null;
	}

	[Token(Token = "0x6007241")]
	[Address(RVA = "0x1936F84", Offset = "0x1936F84", VA = "0x1936F84")]
	public void OnClick_TalentDetail()
	{
	}
}
