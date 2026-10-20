using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D8F")]
public class XUIUltimateSkill : MonoBehaviour
{
	[Token(Token = "0x4004660")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprSkillIcon;

	[Token(Token = "0x4004661")]
	[FieldOffset(Offset = "0x10")]
	public UISprite sprChargePoint;

	[Token(Token = "0x4004662")]
	[FieldOffset(Offset = "0x14")]
	private XModuleSkill m_moduleSkill;

	[Token(Token = "0x4004663")]
	[FieldOffset(Offset = "0x18")]
	private XModuleActor m_ownObject;

	[Token(Token = "0x4004664")]
	[FieldOffset(Offset = "0x1C")]
	private CSSkillInfo m_SkillInfo;

	[Token(Token = "0x4004665")]
	[FieldOffset(Offset = "0x20")]
	private XUltimateSkillCharger m_charger;

	[Token(Token = "0x4004666")]
	[FieldOffset(Offset = "0x24")]
	private PeriodUpdater updater;

	[Token(Token = "0x4004667")]
	[FieldOffset(Offset = "0x28")]
	public UISprite sprDisable;

	[Token(Token = "0x4004668")]
	[FieldOffset(Offset = "0x2C")]
	public XKeyEnum keyEnum;

	[Token(Token = "0x4004669")]
	[FieldOffset(Offset = "0x30")]
	public Transform effectParent;

	[Token(Token = "0x400466A")]
	[FieldOffset(Offset = "0x34")]
	public string EnableEffectPath;

	[Token(Token = "0x400466B")]
	[FieldOffset(Offset = "0x38")]
	public GameObject enableEffect;

	[Token(Token = "0x400466C")]
	[FieldOffset(Offset = "0x3C")]
	public ParticleSystem[] ultEffects;

	[Token(Token = "0x600639B")]
	[Address(RVA = "0x193A634", Offset = "0x193A634", VA = "0x193A634")]
	public XUIUltimateSkill()
	{
	}

	[Token(Token = "0x600639C")]
	[Address(RVA = "0x193A6C8", Offset = "0x193A6C8", VA = "0x193A6C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600639D")]
	[Address(RVA = "0x193A998", Offset = "0x193A998", VA = "0x193A998")]
	private void Update()
	{
	}

	[Token(Token = "0x600639E")]
	[Address(RVA = "0x193AA04", Offset = "0x193AA04", VA = "0x193AA04")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600639F")]
	[Address(RVA = "0x193AA18", Offset = "0x193AA18", VA = "0x193AA18")]
	public void Init(bool disable, XModuleActor actor, int nSkillID, XKeyEnum key)
	{
	}

	[Token(Token = "0x60063A0")]
	[Address(RVA = "0x193AEC8", Offset = "0x193AEC8", VA = "0x193AEC8")]
	public void ReLinkModule(XModuleActor actor, int _skillID)
	{
	}

	[Token(Token = "0x60063A1")]
	[Address(RVA = "0x193AEFC", Offset = "0x193AEFC", VA = "0x193AEFC")]
	private void UpdateSkill()
	{
	}

	[Token(Token = "0x60063A2")]
	[Address(RVA = "0x193B04C", Offset = "0x193B04C", VA = "0x193B04C")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x60063A3")]
	[Address(RVA = "0x193B058", Offset = "0x193B058", VA = "0x193B058")]
	private void UseSkill()
	{
	}

	[Token(Token = "0x60063A4")]
	[Address(RVA = "0x193AF0C", Offset = "0x193AF0C", VA = "0x193AF0C")]
	private void UpdateChargePoint()
	{
	}

	[Token(Token = "0x60063A5")]
	[Address(RVA = "0x193AD40", Offset = "0x193AD40", VA = "0x193AD40")]
	public void EnableEffect(bool b)
	{
	}

	[Token(Token = "0x60063A6")]
	[Address(RVA = "0x193B154", Offset = "0x193B154", VA = "0x193B154")]
	public void Hide()
	{
	}

	[Token(Token = "0x60063A7")]
	[Address(RVA = "0x193B188", Offset = "0x193B188", VA = "0x193B188")]
	public void ClearResource()
	{
	}

	[Token(Token = "0x60063A8")]
	[Address(RVA = "0x193B1B8", Offset = "0x193B1B8", VA = "0x193B1B8")]
	private void _003CAwake_003Em__31A(float delta)
	{
	}
}
