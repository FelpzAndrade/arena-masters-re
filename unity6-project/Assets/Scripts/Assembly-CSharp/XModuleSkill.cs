using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200048A")]
public class XModuleSkill : XModuleBase
{
	[Token(Token = "0x200048B")]
	private struct UltimateSkillInfoCaching
	{
		[Token(Token = "0x40016E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int nSkillID;

		[Token(Token = "0x40016E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Vector3 pos;

		[Token(Token = "0x40016EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Quaternion dir;

		[Token(Token = "0x40016EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool currentSkillCanceled;

		[Token(Token = "0x40016EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public XModuleEntity target;

		[Token(Token = "0x40016ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool bUsedByHandleMetaProperty;

		[Token(Token = "0x40016EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MetaPropertyCondition condition;

		[Token(Token = "0x40016EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CSSkillInfo skillInfo;

		[Token(Token = "0x40016F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool isCaching;
	}

	[Token(Token = "0x40016D4")]
	private const MetaPropertyCondition hitMetaCondition = (MetaPropertyCondition)131;

	[Token(Token = "0x40016D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private XUltimateSkillCharger m_ultimateSkillCharger;

	[Token(Token = "0x40016D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Vector3 m_vecDummyLocApplied;

	[Token(Token = "0x40016D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 m_vecDummyLocScaled;

	[Token(Token = "0x40016D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private List<XSkill> m_ActiveSkills;

	[Token(Token = "0x40016D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isSkillMoving;

	[Token(Token = "0x40016DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private XSkill m_CurrentSkill;

	[Token(Token = "0x40016DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform m_skillColliderRoot;

	[Token(Token = "0x40016DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Dictionary<int, int> m_talentSkillPage;

	[Token(Token = "0x40016DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<SkillPassiveTiming, List<int>> m_passiveSkillDictionary;

	[Token(Token = "0x40016DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Dictionary<int, CoolTimeEntry> coolTimes;

	[Token(Token = "0x40016DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<int> removableCoolTime;

	[Token(Token = "0x40016E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private KeyValuePair<int, float> m_reservedSkill;

	[Token(Token = "0x40016E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Func<int, bool> m_useReservedSkill;

	[Token(Token = "0x40016E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<XSkill> removableSkill;

	[Token(Token = "0x40016E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool isUlitimateCinemaPlaying;

	[Token(Token = "0x40016E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private UltimateSkillInfoCaching m_ultimateSkillInfoCaching;

	[Token(Token = "0x40016E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private StringBuilder m_stringBuilder;

	[Token(Token = "0x40016E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private bool m_canChargeUlt;

	[Token(Token = "0x40016E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
	private bool IsMoveInputSuspend__BackingField;

	[Token(Token = "0x1700062F")]
	public XUltimateSkillCharger UltimateSkillCharger
	{
		[Token(Token = "0x60026D0")]
		[Address(RVA = "0xB68524", Offset = "0xB68524", VA = "0xB68524")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000630")]
	public CSSkillInfo DefaultSkillInfo
	{
		[Token(Token = "0x60026D1")]
		[Address(RVA = "0xB8E5E8", Offset = "0xB8E5E8", VA = "0xB8E5E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000631")]
	public CSSkillInfo UltimateSkillInfo
	{
		[Token(Token = "0x60026D2")]
		[Address(RVA = "0xB8E628", Offset = "0xB8E628", VA = "0xB8E628")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000632")]
	public Transform SkillColliderRoot
	{
		[Token(Token = "0x60026D3")]
		[Address(RVA = "0xB8E660", Offset = "0xB8E660", VA = "0xB8E660")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000633")]
	public bool IsSkillMoving
	{
		[Token(Token = "0x60026D4")]
		[Address(RVA = "0xB8E668", Offset = "0xB8E668", VA = "0xB8E668")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000634")]
	public bool IsMoveInputSuspend
	{
		[Token(Token = "0x60026D5")]
		[Address(RVA = "0xB8E670", Offset = "0xB8E670", VA = "0xB8E670")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60026D6")]
		[Address(RVA = "0xB8E678", Offset = "0xB8E678", VA = "0xB8E678")]
		private set
		{
		}
	}

	[Token(Token = "0x17000635")]
	public float CurrentSkillElapsedTime
	{
		[Token(Token = "0x60026E6")]
		[Address(RVA = "0xB81938", Offset = "0xB81938", VA = "0xB81938")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000636")]
	public int CurrentSkillID
	{
		[Token(Token = "0x60026E7")]
		[Address(RVA = "0xB81904", Offset = "0xB81904", VA = "0xB81904")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60026CF")]
	[Address(RVA = "0xB8E338", Offset = "0xB8E338", VA = "0xB8E338")]
	public XModuleSkill()
	{
	}

	[Token(Token = "0x60026D7")]
	[Address(RVA = "0xB8E680", Offset = "0xB8E680", VA = "0xB8E680")]
	public bool UsePassiveSkillList(SkillPassiveTiming passiveTiming, float accFactor = 1f)
	{
		return default(bool);
	}

	[Token(Token = "0x60026D8")]
	[Address(RVA = "0xB8EB38", Offset = "0xB8EB38", VA = "0xB8EB38", Slot = "24")]
	public override void OnActorTag()
	{
	}

	[Token(Token = "0x60026D9")]
	[Address(RVA = "0xB8FB0C", Offset = "0xB8FB0C", VA = "0xB8FB0C", Slot = "23")]
	public override void OnActorChangeModel(CSCharacterInfo characterInfo, SkinInfo skinInfo)
	{
	}

	[Token(Token = "0x60026DA")]
	[Address(RVA = "0xB8FB10", Offset = "0xB8FB10", VA = "0xB8FB10", Slot = "17")]
	public override void OnActorInit(XModuleActor.CreationDesc desc)
	{
	}

	[Token(Token = "0x60026DB")]
	[Address(RVA = "0xB8FBE0", Offset = "0xB8FBE0", VA = "0xB8FBE0", Slot = "18")]
	public override void OnAfterActorInit(XModuleActor.CreationDesc actor)
	{
	}

	[Token(Token = "0x60026DC")]
	[Address(RVA = "0xB8FE34", Offset = "0xB8FE34", VA = "0xB8FE34", Slot = "38")]
	public override void OnActorKill(int streakKillCount)
	{
	}

	[Token(Token = "0x60026DD")]
	[Address(RVA = "0xB8FE40", Offset = "0xB8FE40", VA = "0xB8FE40", Slot = "16")]
	public override void OnActorRevive()
	{
	}

	[Token(Token = "0x60026DE")]
	[Address(RVA = "0xB8FE4C", Offset = "0xB8FE4C", VA = "0xB8FE4C", Slot = "25")]
	public override void OnGainBuff(XBuff buff)
	{
	}

	[Token(Token = "0x60026DF")]
	[Address(RVA = "0xB8FE98", Offset = "0xB8FE98", VA = "0xB8FE98", Slot = "39")]
	public override void OnActorDodge()
	{
	}

	[Token(Token = "0x60026E0")]
	[Address(RVA = "0xB906F4", Offset = "0xB906F4", VA = "0xB906F4", Slot = "37")]
	public override void OnActorDie(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x60026E1")]
	[Address(RVA = "0xB909EC", Offset = "0xB909EC", VA = "0xB909EC", Slot = "32")]
	public override void OnMotionControlStart(XMotionControlBase mc)
	{
	}

	[Token(Token = "0x60026E2")]
	[Address(RVA = "0xB909F0", Offset = "0xB909F0", VA = "0xB909F0", Slot = "34")]
	public override void OnHitActor(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x60026E3")]
	[Address(RVA = "0xB90BF4", Offset = "0xB90BF4", VA = "0xB90BF4", Slot = "35")]
	public override void OnHitMe(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x60026E4")]
	[Address(RVA = "0xB90F3C", Offset = "0xB90F3C", VA = "0xB90F3C", Slot = "49")]
	public override void OnEnterDeathsDoor()
	{
	}

	[Token(Token = "0x60026E5")]
	[Address(RVA = "0xB818F4", Offset = "0xB818F4", VA = "0xB818F4")]
	public bool IsUsingSkill()
	{
		return default(bool);
	}

	[Token(Token = "0x60026E8")]
	[Address(RVA = "0xB761C4", Offset = "0xB761C4", VA = "0xB761C4")]
	public bool CanMove()
	{
		return default(bool);
	}

	[Token(Token = "0x60026E9")]
	[Address(RVA = "0xB73930", Offset = "0xB73930", VA = "0xB73930")]
	public bool IsDirectionFixed()
	{
		return default(bool);
	}

	[Token(Token = "0x60026EA")]
	[Address(RVA = "0xB90F48", Offset = "0xB90F48", VA = "0xB90F48")]
	private CoolTimeEntry GetNewCoolTimeEntry(float remain)
	{
		return null;
	}

	[Token(Token = "0x60026EB")]
	[Address(RVA = "0xB90FF0", Offset = "0xB90FF0", VA = "0xB90FF0")]
	public void StartCooldown(XModuleActor actor, XSkill skill, bool isRelicSkill = false)
	{
	}

	[Token(Token = "0x60026EC")]
	[Address(RVA = "0xB39290", Offset = "0xB39290", VA = "0xB39290")]
	public void AdjustCooltime(int nSkillID, float delta_cooltime)
	{
	}

	[Token(Token = "0x60026ED")]
	[Address(RVA = "0xB91950", Offset = "0xB91950", VA = "0xB91950")]
	private void Update_Cooltime(float deltaTime)
	{
	}

	[Token(Token = "0x60026EE")]
	[Address(RVA = "0xB7EFB4", Offset = "0xB7EFB4", VA = "0xB7EFB4")]
	public float GetRemainCooltime(int id)
	{
		return default(float);
	}

	[Token(Token = "0x60026EF")]
	[Address(RVA = "0xB91C68", Offset = "0xB91C68", VA = "0xB91C68")]
	public float GetRemainCooltimeRatio(CSSkillInfo skillInfo, bool isRelicSkill)
	{
		return default(float);
	}

	[Token(Token = "0x60026F0")]
	[Address(RVA = "0xB918B0", Offset = "0xB918B0", VA = "0xB918B0")]
	public bool IsCooldown(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x60026F1")]
	[Address(RVA = "0xB91CDC", Offset = "0xB91CDC", VA = "0xB91CDC")]
	public void ResetAllCooltime()
	{
	}

	[Token(Token = "0x60026F2")]
	[Address(RVA = "0xB91244", Offset = "0xB91244", VA = "0xB91244")]
	public float GetCooltime(XModuleActor actor, CSSkillInfo info, bool isRelicSkill = false, int skillLevel = 0)
	{
		return default(float);
	}

	[Token(Token = "0x60026F3")]
	[Address(RVA = "0xB39288", Offset = "0xB39288", VA = "0xB39288")]
	public Dictionary<int, CoolTimeEntry> GetCoolTimes()
	{
		return null;
	}

	[Token(Token = "0x60026F4")]
	[Address(RVA = "0xB91D74", Offset = "0xB91D74", VA = "0xB91D74")]
	public void SetCoolTimes(Dictionary<int, CoolTimeEntry> skillCoolTimes)
	{
	}

	[Token(Token = "0x60026F5")]
	[Address(RVA = "0xB8EB7C", Offset = "0xB8EB7C", VA = "0xB8EB7C")]
	protected void ClearPassiveSKillDict()
	{
	}

	[Token(Token = "0x60026F6")]
	[Address(RVA = "0xB8EC4C", Offset = "0xB8EC4C", VA = "0xB8EC4C")]
	private void CreateTalentPassiveSkill(Dictionary<int, int> talentSkillPage)
	{
	}

	[Token(Token = "0x60026F7")]
	[Address(RVA = "0xB91D7C", Offset = "0xB91D7C", VA = "0xB91D7C")]
	protected void AddPassiveSkillToDict(CSSkillInfo skillInfo)
	{
	}

	[Token(Token = "0x60026F8")]
	[Address(RVA = "0xB91F28", Offset = "0xB91F28", VA = "0xB91F28")]
	protected void RemovePassiveSkillToDict(CSSkillInfo skillInfo)
	{
	}

	[Token(Token = "0x60026F9")]
	[Address(RVA = "0xB4E408", Offset = "0xB4E408", VA = "0xB4E408")]
	public void RemoveCharacterPassiveSkill()
	{
	}

	[Token(Token = "0x60026FA")]
	[Address(RVA = "0xB8F2D4", Offset = "0xB8F2D4", VA = "0xB8F2D4")]
	private void CreateItemPassiveSkill()
	{
	}

	[Token(Token = "0x60026FB")]
	[Address(RVA = "0xB4E6A8", Offset = "0xB4E6A8", VA = "0xB4E6A8")]
	public void CreateCharacterpassiveSkill()
	{
	}

	[Token(Token = "0x60026FC")]
	[Address(RVA = "0xB92094", Offset = "0xB92094", VA = "0xB92094", Slot = "6")]
	public override void OnUpdate(float dt)
	{
	}

	[Token(Token = "0x60026FD")]
	[Address(RVA = "0xB92864", Offset = "0xB92864", VA = "0xB92864")]
	private void UpdateReservable()
	{
	}

	[Token(Token = "0x60026FE")]
	[Address(RVA = "0xB92B0C", Offset = "0xB92B0C", VA = "0xB92B0C")]
	private void UpdateAiming(XSkill skill)
	{
	}

	[Token(Token = "0x60026FF")]
	[Address(RVA = "0xB92304", Offset = "0xB92304", VA = "0xB92304")]
	private void Update_CurrentSkill(float deltaTime)
	{
	}

	[Token(Token = "0x6002700")]
	[Address(RVA = "0xB92F94", Offset = "0xB92F94", VA = "0xB92F94")]
	public void ReserveSkillOnCurrentSkillFinished(int id, Func<int, bool> useSkill, float timeAdd)
	{
	}

	[Token(Token = "0x6002701")]
	[Address(RVA = "0xB92C48", Offset = "0xB92C48", VA = "0xB92C48")]
	private void CompleteCurrentSkill()
	{
	}

	[Token(Token = "0x6002702")]
	[Address(RVA = "0xB929FC", Offset = "0xB929FC", VA = "0xB929FC")]
	private bool HasReservedSkill()
	{
		return default(bool);
	}

	[Token(Token = "0x6002703")]
	[Address(RVA = "0xB920D4", Offset = "0xB920D4", VA = "0xB920D4")]
	private void Update_Skills(float deltaTime)
	{
	}

	[Token(Token = "0x6002704")]
	[Address(RVA = "0xB930C4", Offset = "0xB930C4", VA = "0xB930C4")]
	private void ClearAllSkills()
	{
	}

	[Token(Token = "0x6002705")]
	[Address(RVA = "0xB93068", Offset = "0xB93068", VA = "0xB93068")]
	private void FinishSkill(XSkill skill)
	{
	}

	[Token(Token = "0x6002706")]
	[Address(RVA = "0xB93210", Offset = "0xB93210", VA = "0xB93210")]
	private void ReleasSkillModule(XSkill skill)
	{
	}

	[Token(Token = "0x6002707")]
	[Address(RVA = "0xB932D8", Offset = "0xB932D8", VA = "0xB932D8")]
	private XSkill BuildSkill(CSSkillInfo info, XModuleEntity target)
	{
		return null;
	}

	[Token(Token = "0x6002708")]
	[Address(RVA = "0xB76A88", Offset = "0xB76A88", VA = "0xB76A88")]
	public bool CanUseCharacterSkill(int skillId)
	{
		return default(bool);
	}

	[Token(Token = "0x6002709")]
	[Address(RVA = "0xB76C48", Offset = "0xB76C48", VA = "0xB76C48")]
	public string GetSkillAni(int skillId)
	{
		return null;
	}

	[Token(Token = "0x600270A")]
	[Address(RVA = "0xB9333C", Offset = "0xB9333C", VA = "0xB9333C")]
	protected bool CheckBuffIncludeCondition(List<int> checkBuffList)
	{
		return default(bool);
	}

	[Token(Token = "0x600270B")]
	[Address(RVA = "0xB93450", Offset = "0xB93450", VA = "0xB93450", Slot = "51")]
	public override void OnStartUlitmateCinema(int skillID)
	{
	}

	[Token(Token = "0x600270C")]
	[Address(RVA = "0xB935AC", Offset = "0xB935AC", VA = "0xB935AC", Slot = "53")]
	public override void OnEndCinemaAnimation()
	{
	}

	[Token(Token = "0x600270D")]
	[Address(RVA = "0xB93B60", Offset = "0xB93B60", VA = "0xB93B60")]
	private bool IsPossibleUseSkill()
	{
		return default(bool);
	}

	[Token(Token = "0x600270E")]
	[Address(RVA = "0xB93B74", Offset = "0xB93B74", VA = "0xB93B74")]
	private bool CheckUltimateCinemaCondition(int skillID)
	{
		return default(bool);
	}

	[Token(Token = "0x600270F")]
	[Address(RVA = "0xB93CDC", Offset = "0xB93CDC", VA = "0xB93CDC")]
	private void StartUltimateCinema(int nSkillID, Vector3 pos, Quaternion dir, bool currentSkillCanceled, XModuleEntity target, bool bUsedByHandleMetaProperty, MetaPropertyCondition condition, CSSkillInfo skillInfo)
	{
	}

	[Token(Token = "0x6002710")]
	[Address(RVA = "0xB7F090", Offset = "0xB7F090", VA = "0xB7F090")]
	public bool UseSkill(int nSkillID, Vector3 pos, Quaternion dir, bool currentSkillCanceled, [Optional] XModuleEntity target, bool bUsedByHandleMetaProperty = false, MetaPropertyCondition condition = MetaPropertyCondition.None)
	{
		return default(bool);
	}

	[Token(Token = "0x6002711")]
	[Address(RVA = "0xB937B4", Offset = "0xB937B4", VA = "0xB937B4")]
	private bool _UseUltimateSkill(int nSkillID, Vector3 pos, Quaternion dir, bool currentSkillCanceled, XModuleEntity target, bool bUsedByHandleMetaProperty, MetaPropertyCondition condition, CSSkillInfo skillInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6002712")]
	[Address(RVA = "0xB93EB0", Offset = "0xB93EB0", VA = "0xB93EB0")]
	private bool _UseSkill(CSSkillInfo skillInfo, Vector3 pos, Quaternion dir, bool currentSkillCanceled, bool bUsedByHandleMetaProperty, XModuleEntity syncTarget, MetaPropertyCondition condition = MetaPropertyCondition.None)
	{
		return default(bool);
	}

	[Token(Token = "0x6002713")]
	[Address(RVA = "0xB94A28", Offset = "0xB94A28", VA = "0xB94A28")]
	public bool UseRelicSkill(int nSkillID, Vector3 pos, Quaternion dir)
	{
		return default(bool);
	}

	[Token(Token = "0x6002714")]
	[Address(RVA = "0xB7FE00", Offset = "0xB7FE00", VA = "0xB7FE00")]
	public bool _UseRelicSkill(CSSkillInfo skillInfo, Vector3 pos, Quaternion dir, [Optional] XModuleEntity syncTarget)
	{
		return default(bool);
	}

	[Token(Token = "0x6002715")]
	[Address(RVA = "0xB94C30", Offset = "0xB94C30", VA = "0xB94C30")]
	private bool CheckUseOverlapped(CSSkillInfo skillInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6002716")]
	[Address(RVA = "0xB8E934", Offset = "0xB8E934", VA = "0xB8E934")]
	private bool UsePassiveSkill(int nSkillID, float accFactor, Vector3 pos, Quaternion dir)
	{
		return default(bool);
	}

	[Token(Token = "0x6002717")]
	[Address(RVA = "0xB806B0", Offset = "0xB806B0", VA = "0xB806B0")]
	public bool _UsePassiveSkill(CSSkillInfo skillInfo, Vector3 pos, Quaternion dir, [Optional] XModuleEntity syncTarget)
	{
		return default(bool);
	}

	[Token(Token = "0x6002718")]
	[Address(RVA = "0xB93C78", Offset = "0xB93C78", VA = "0xB93C78")]
	private bool IsUlt(int nSkillID)
	{
		return default(bool);
	}

	[Token(Token = "0x6002719")]
	[Address(RVA = "0xB94D2C", Offset = "0xB94D2C", VA = "0xB94D2C")]
	private bool IsExistDummyLoc()
	{
		return default(bool);
	}

	[Token(Token = "0x600271A")]
	[Address(RVA = "0xB94980", Offset = "0xB94980", VA = "0xB94980")]
	public void ResetSkillMove()
	{
	}

	[Token(Token = "0x600271B")]
	[Address(RVA = "0xB92454", Offset = "0xB92454", VA = "0xB92454")]
	private void UpdateSkillMove(float deltaTime)
	{
	}

	[Token(Token = "0x600271C")]
	[Address(RVA = "0xB94E18", Offset = "0xB94E18", VA = "0xB94E18")]
	private bool TryCheckNull()
	{
		return default(bool);
	}

	[Token(Token = "0x600271D")]
	[Address(RVA = "0xB94EA8", Offset = "0xB94EA8", VA = "0xB94EA8", Slot = "13")]
	public override void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[Token(Token = "0x600271E")]
	[Address(RVA = "0xB94FB8", Offset = "0xB94FB8", VA = "0xB94FB8")]
	public void OnSkillCollision_Wall()
	{
	}

	[Token(Token = "0x600271F")]
	[Address(RVA = "0xB951A4", Offset = "0xB951A4", VA = "0xB951A4", Slot = "40")]
	public override void OnGameObjectDestroy()
	{
	}

	[Token(Token = "0x6002720")]
	[Address(RVA = "0xB951AC", Offset = "0xB951AC", VA = "0xB951AC", Slot = "30")]
	public override void OnSkillFinished(XSkill skill)
	{
	}

	[Token(Token = "0x6002721")]
	[Address(RVA = "0xB92AE4", Offset = "0xB92AE4", VA = "0xB92AE4")]
	public bool IsCurrentSkillCancelable(CSCharacterSkillInfo.SkillType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6002722")]
	[Address(RVA = "0xB41F58", Offset = "0xB41F58", VA = "0xB41F58")]
	public bool IsCurrentSkillMovable()
	{
		return default(bool);
	}

	[Token(Token = "0x6002723")]
	[Address(RVA = "0xB41F80", Offset = "0xB41F80", VA = "0xB41F80")]
	public string GetIdleAnimation()
	{
		return null;
	}

	[Token(Token = "0x6002724")]
	[Address(RVA = "0xB42454", Offset = "0xB42454", VA = "0xB42454")]
	public string GetSkillAnimation()
	{
		return null;
	}

	[Token(Token = "0x6002725")]
	[Address(RVA = "0xB421C4", Offset = "0xB421C4", VA = "0xB421C4")]
	public string GetSkillRunAnimation(Vector3 directionOnWorldSpace)
	{
		return null;
	}

	[Token(Token = "0x6002726")]
	[Address(RVA = "0xB9072C", Offset = "0xB9072C", VA = "0xB9072C")]
	private void ClearOnDieSkill()
	{
	}

	[Token(Token = "0x6002727")]
	[Address(RVA = "0xB38EFC", Offset = "0xB38EFC", VA = "0xB38EFC")]
	public bool CancelCurrentSkill()
	{
		return default(bool);
	}

	[Token(Token = "0x6002728")]
	[Address(RVA = "0xB92F08", Offset = "0xB92F08", VA = "0xB92F08")]
	private void FinishCurrentSkillMotion()
	{
	}

	[Token(Token = "0x6002729")]
	[Address(RVA = "0xB954C0", Offset = "0xB954C0", VA = "0xB954C0")]
	private void FinishMetaUseSkill()
	{
	}

	[Token(Token = "0x600272A")]
	[Address(RVA = "0xB956A4", Offset = "0xB956A4", VA = "0xB956A4")]
	public bool CancelReserveSkill()
	{
		return default(bool);
	}

	[Token(Token = "0x600272B")]
	[Address(RVA = "0xB95758", Offset = "0xB95758", VA = "0xB95758")]
	private bool IsCurrentSkillNotPersistence()
	{
		return default(bool);
	}

	[Token(Token = "0x600272C")]
	[Address(RVA = "0xB95428", Offset = "0xB95428", VA = "0xB95428")]
	private bool IsCurrentSkillPersistence()
	{
		return default(bool);
	}

	[Token(Token = "0x600272D")]
	[Address(RVA = "0xB94A08", Offset = "0xB94A08", VA = "0xB94A08")]
	protected bool IsHitMetaProperty(MetaPropertyCondition condition)
	{
		return default(bool);
	}

	[Token(Token = "0x600272E")]
	[Address(RVA = "0xB90144", Offset = "0xB90144", VA = "0xB90144")]
	private bool HandleMetaProperty(MetaPropertyCondition condition, ModuleEventArgument_Hit arg)
	{
		return default(bool);
	}

	[Token(Token = "0x600272F")]
	[Address(RVA = "0xB61510", Offset = "0xB61510", VA = "0xB61510")]
	public void ChargeUltOnBeaten(float attackerDamage)
	{
	}

	[Token(Token = "0x6002730")]
	[Address(RVA = "0xB61648", Offset = "0xB61648", VA = "0xB61648")]
	public void ChargeUltOnHit(float ultimateCharge)
	{
	}

	[Token(Token = "0x6002731")]
	[Address(RVA = "0xB957F4", Offset = "0xB957F4", VA = "0xB957F4")]
	public void EnableHitCharge()
	{
	}

	[Token(Token = "0x6002732")]
	[Address(RVA = "0xB951A8", Offset = "0xB951A8", VA = "0xB951A8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002733")]
	[Address(RVA = "0xB95800", Offset = "0xB95800", VA = "0xB95800")]
	public string GetPassiveList_ToString()
	{
		return null;
	}

	[Token(Token = "0x6002734")]
	[Address(RVA = "0xB95D50", Offset = "0xB95D50", VA = "0xB95D50", Slot = "26")]
	public override void OnSkillStart(XSkill skill)
	{
	}
}
