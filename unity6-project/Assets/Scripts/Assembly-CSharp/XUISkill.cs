using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D8B")]
public class XUISkill : MonoBehaviour
{
	[Token(Token = "0x400463D")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprSkillIcon;

	[Token(Token = "0x400463E")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblCoolTime;

	[Token(Token = "0x400463F")]
	[FieldOffset(Offset = "0x14")]
	public UISprite sprCoolTime;

	[Token(Token = "0x4004640")]
	[FieldOffset(Offset = "0x18")]
	public bool m_CoolTimeCheck;

	[Token(Token = "0x4004641")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite sprDisable;

	[Token(Token = "0x4004642")]
	[FieldOffset(Offset = "0x20")]
	private XModuleMyControl m_moduleControl;

	[Token(Token = "0x4004643")]
	[FieldOffset(Offset = "0x24")]
	private XModuleSkill m_moduleSkill;

	[Token(Token = "0x4004644")]
	[FieldOffset(Offset = "0x28")]
	private XModuleActor m_moduleActor;

	[Token(Token = "0x4004645")]
	[FieldOffset(Offset = "0x2C")]
	protected CSSkillInfo m_SkillInfo;

	[Token(Token = "0x4004646")]
	[FieldOffset(Offset = "0x30")]
	private bool m_bCurrentCoolTime;

	[Token(Token = "0x4004647")]
	[FieldOffset(Offset = "0x31")]
	private bool m_autoFire;

	[Token(Token = "0x4004648")]
	[FieldOffset(Offset = "0x34")]
	private float m_autoFireRepeatInterval;

	[Token(Token = "0x4004649")]
	[FieldOffset(Offset = "0x38")]
	private PeriodUpdater updater;

	[Token(Token = "0x400464A")]
	[FieldOffset(Offset = "0x3C")]
	public XKeyEnum m_key;

	[Token(Token = "0x400464B")]
	[FieldOffset(Offset = "0x40")]
	private bool m_isRelicSkill;

	[Token(Token = "0x400464C")]
	[FieldOffset(Offset = "0x44")]
	public string onSkillReadyEffectPath;

	[Token(Token = "0x400464D")]
	[FieldOffset(Offset = "0x48")]
	public GameObject onSkillReadyEffect;

	[Token(Token = "0x400464E")]
	[FieldOffset(Offset = "0x4C")]
	public ParticleSystem[] onSkillReadyEffectPSS;

	[Token(Token = "0x400464F")]
	[FieldOffset(Offset = "0x50")]
	private DateTime lastUpdateSkillTime;

	[Token(Token = "0x4004650")]
	[FieldOffset(Offset = "0x60")]
	private bool m_isComboSkill;

	[Token(Token = "0x4004651")]
	[FieldOffset(Offset = "0x64")]
	private int m_comboLine;

	[Token(Token = "0x4004652")]
	[FieldOffset(Offset = "0x68")]
	private int m_baseComboSkill;

	[Token(Token = "0x4004653")]
	[FieldOffset(Offset = "0x6C")]
	private int m_currentComboUISkillID;

	[Token(Token = "0x4004654")]
	[FieldOffset(Offset = "0x70")]
	private List<int> m_comboSkillIDList;

	[Token(Token = "0x4004655")]
	[FieldOffset(Offset = "0x74")]
	private Dictionary<int, Sprite> m_comboSkillIconsDictionary;

	[Token(Token = "0x4004656")]
	[FieldOffset(Offset = "0x78")]
	private bool m_isUIActive;

	[Token(Token = "0x4004657")]
	[FieldOffset(Offset = "0x7C")]
	private int m_lastRemainCoolTime;

	[Token(Token = "0x4004658")]
	[FieldOffset(Offset = "0x80")]
	private bool isEnableEffect;

	[Token(Token = "0x4004659")]
	[FieldOffset(Offset = "0x84")]
	private Dictionary<int, CoolTimeEntry> SkillCoolTimes__BackingField;

	[Token(Token = "0x17000D3B")]
	public bool IsRelicSkill
	{
		[Token(Token = "0x6006370")]
		[Address(RVA = "0x192912C", Offset = "0x192912C", VA = "0x192912C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006371")]
		[Address(RVA = "0x1929134", Offset = "0x1929134", VA = "0x1929134")]
		set
		{
		}
	}

	[Token(Token = "0x17000D3C")]
	public Dictionary<int, CoolTimeEntry> SkillCoolTimes
	{
		[Token(Token = "0x6006372")]
		[Address(RVA = "0x192913C", Offset = "0x192913C", VA = "0x192913C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006373")]
		[Address(RVA = "0x1929144", Offset = "0x1929144", VA = "0x1929144")]
		private set
		{
		}
	}

	[Token(Token = "0x600636F")]
	[Address(RVA = "0x1929028", Offset = "0x1929028", VA = "0x1929028")]
	public XUISkill()
	{
	}

	[Token(Token = "0x6006374")]
	[Address(RVA = "0x192914C", Offset = "0x192914C", VA = "0x192914C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006375")]
	[Address(RVA = "0x1929430", Offset = "0x1929430", VA = "0x1929430")]
	private void Update()
	{
	}

	[Token(Token = "0x6006376")]
	[Address(RVA = "0x192949C", Offset = "0x192949C", VA = "0x192949C")]
	public void Init(bool disable, XModuleActor objChar, int nSkillID, XKeyEnum key, bool autoFire = false)
	{
	}

	[Token(Token = "0x6006377")]
	[Address(RVA = "0x192A48C", Offset = "0x192A48C", VA = "0x192A48C")]
	private void ShowOnSkillReadyEffect()
	{
	}

	[Token(Token = "0x6006378")]
	[Address(RVA = "0x1929C84", Offset = "0x1929C84", VA = "0x1929C84")]
	private void CachingComboSkillIcons(CSSkillInfo skillInfo)
	{
	}

	[Token(Token = "0x6006379")]
	[Address(RVA = "0x1929EE0", Offset = "0x1929EE0", VA = "0x1929EE0")]
	private void CachingComboSkillID(CSSkillInfo skillInfo)
	{
	}

	[Token(Token = "0x600637A")]
	[Address(RVA = "0x192A5EC", Offset = "0x192A5EC", VA = "0x192A5EC")]
	private void ChangeNextComboSkillIcon(int skillID)
	{
	}

	[Token(Token = "0x600637B")]
	[Address(RVA = "0x192A6E8", Offset = "0x192A6E8", VA = "0x192A6E8")]
	public void SetIsUIActive(bool isUIActive)
	{
	}

	[Token(Token = "0x600637C")]
	[Address(RVA = "0x192A6F0", Offset = "0x192A6F0", VA = "0x192A6F0")]
	public void ReLinkModule(XModuleActor objChar, int _skillID)
	{
	}

	[Token(Token = "0x600637D")]
	[Address(RVA = "0x192A910", Offset = "0x192A910", VA = "0x192A910")]
	private void UpdateDeltaSkillCoolTime(int _skillID)
	{
	}

	[Token(Token = "0x600637E")]
	[Address(RVA = "0x192AA8C", Offset = "0x192AA8C", VA = "0x192AA8C", Slot = "4")]
	protected virtual void SetSkillLock(bool activate, XModuleActor character, int nSkillID)
	{
	}

	[Token(Token = "0x600637F")]
	[Address(RVA = "0x192AA90", Offset = "0x192AA90", VA = "0x192AA90")]
	private void UpdateSkillUI()
	{
	}

	[Token(Token = "0x6006380")]
	[Address(RVA = "0x192AC20", Offset = "0x192AC20", VA = "0x192AC20")]
	private void ChangeCoolTimeUI(int skillID)
	{
	}

	[Token(Token = "0x6006381")]
	[Address(RVA = "0x192AF84", Offset = "0x192AF84", VA = "0x192AF84")]
	private void UpdateSkill()
	{
	}

	[Token(Token = "0x6006382")]
	[Address(RVA = "0x192AF88", Offset = "0x192AF88", VA = "0x192AF88")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x6006383")]
	[Address(RVA = "0x192A38C", Offset = "0x192A38C", VA = "0x192A38C")]
	private void AutoFire(bool isPressed)
	{
	}

	[Token(Token = "0x6006384")]
	[Address(RVA = "0x192AFEC", Offset = "0x192AFEC", VA = "0x192AFEC", Slot = "5")]
	protected virtual void UseSkill()
	{
	}

	[Token(Token = "0x6006385")]
	[Address(RVA = "0x192AFF0", Offset = "0x192AFF0", VA = "0x192AFF0")]
	private void UseSkillAuto()
	{
	}

	[Token(Token = "0x6006386")]
	[Address(RVA = "0x192AC90", Offset = "0x192AC90", VA = "0x192AC90")]
	private void UpdateCoolTime(int skillId)
	{
	}

	[Token(Token = "0x6006387")]
	[Address(RVA = "0x192A0D8", Offset = "0x192A0D8", VA = "0x192A0D8")]
	private void SetCoolTime(bool b, bool bForce = false)
	{
	}

	[Token(Token = "0x6006388")]
	[Address(RVA = "0x1929BA4", Offset = "0x1929BA4", VA = "0x1929BA4")]
	private void SetCoolTimeLabelText(string text)
	{
	}

	[Token(Token = "0x6006389")]
	[Address(RVA = "0x192B0DC", Offset = "0x192B0DC", VA = "0x192B0DC")]
	public void Hide()
	{
	}

	[Token(Token = "0x600638A")]
	[Address(RVA = "0x192B120", Offset = "0x192B120", VA = "0x192B120")]
	public void EnableEffect(bool b)
	{
	}

	[Token(Token = "0x600638B")]
	[Address(RVA = "0x192B29C", Offset = "0x192B29C", VA = "0x192B29C")]
	private void OnActorDestroy()
	{
	}

	[Token(Token = "0x600638C")]
	[Address(RVA = "0x192B2A8", Offset = "0x192B2A8", VA = "0x192B2A8")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x600638D")]
	[Address(RVA = "0x192B33C", Offset = "0x192B33C", VA = "0x192B33C")]
	public void ClearResource()
	{
	}

	[Token(Token = "0x600638E")]
	[Address(RVA = "0x192B36C", Offset = "0x192B36C", VA = "0x192B36C")]
	private void _003CAwake_003Em__319(float delta)
	{
	}
}
