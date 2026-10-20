using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200046F")]
public class XModuleMesh : XModuleBase
{
	[Token(Token = "0x2000470")]
	private enum HitColorState
	{
		[Token(Token = "0x400165A")]
		None = 0,
		[Token(Token = "0x400165B")]
		Changing = 1
	}

	[Token(Token = "0x400162D")]
	[FieldOffset(Offset = "0x10")]
	private bool m_bSkillEffect;

	[Token(Token = "0x400162E")]
	[FieldOffset(Offset = "0x14")]
	private Color m_skillEffectRimColor;

	[Token(Token = "0x400162F")]
	[FieldOffset(Offset = "0x24")]
	private Color m_skillEffectColor;

	[Token(Token = "0x4001630")]
	[FieldOffset(Offset = "0x34")]
	private float m_skillEffectElapsedTime;

	[Token(Token = "0x4001631")]
	[FieldOffset(Offset = "0x38")]
	private float m_skillEffectDuration;

	[Token(Token = "0x4001632")]
	[FieldOffset(Offset = "0x3C")]
	private int m_skillEffectID;

	[Token(Token = "0x4001633")]
	[FieldOffset(Offset = "0x40")]
	private Color WhiteColor;

	[Token(Token = "0x4001634")]
	[FieldOffset(Offset = "0x50")]
	private Color HitPurposeColorInit;

	[Token(Token = "0x4001635")]
	[FieldOffset(Offset = "0x60")]
	private HitColorState m_hitColorState;

	[Token(Token = "0x4001636")]
	[FieldOffset(Offset = "0x64")]
	private Color m_hitPurposeColor;

	[Token(Token = "0x4001637")]
	[FieldOffset(Offset = "0x74")]
	private Color m_hitColorAccumulationAmount;

	[Token(Token = "0x4001638")]
	[FieldOffset(Offset = "0x84")]
	private float m_fElapsedTime;

	[Token(Token = "0x4001639")]
	[FieldOffset(Offset = "0x88")]
	private Color m_defaultColor;

	[Token(Token = "0x400163A")]
	[FieldOffset(Offset = "0x98")]
	public Transform modelParent;

	[Token(Token = "0x400163B")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject goModel;

	[Token(Token = "0x400163C")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject goShadow;

	[Token(Token = "0x400163D")]
	[FieldOffset(Offset = "0xA4")]
	private SkinnedMeshRenderer[] skinnedMeshRenderers;

	[Token(Token = "0x400163E")]
	[FieldOffset(Offset = "0xA8")]
	private Renderer[] renderers;

	[Token(Token = "0x400163F")]
	[FieldOffset(Offset = "0xAC")]
	private XMaterialChanger m_MaterialChanger;

	[Token(Token = "0x4001640")]
	[FieldOffset(Offset = "0xB0")]
	private Transform m_goDummyLoc;

	[Token(Token = "0x4001641")]
	[FieldOffset(Offset = "0xB4")]
	private float m_goDummyLocLossyScale;

	[Token(Token = "0x4001642")]
	[FieldOffset(Offset = "0xB8")]
	private Color allyColor;

	[Token(Token = "0x4001643")]
	[FieldOffset(Offset = "0xC8")]
	private Color enemyColor;

	[Token(Token = "0x4001644")]
	[FieldOffset(Offset = "0xD8")]
	private bool isBehind;

	[Token(Token = "0x4001645")]
	[FieldOffset(Offset = "0xD9")]
	private bool isDie;

	[Token(Token = "0x4001646")]
	[FieldOffset(Offset = "0xDA")]
	public bool m_isOnGround;

	[Token(Token = "0x4001647")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int _SetbehindHashKey;

	[Token(Token = "0x4001648")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int _RimBrightnessHashKey;

	[Token(Token = "0x4001649")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int _AlphaHashKey;

	[Token(Token = "0x400164A")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int _BehindColorHashKey;

	[Token(Token = "0x400164B")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int _ColorHashKey;

	[Token(Token = "0x400164C")]
	[FieldOffset(Offset = "0x14")]
	private static readonly int _DissolveHashKey;

	[Token(Token = "0x400164D")]
	[FieldOffset(Offset = "0x18")]
	private static readonly int _ShadowEnableHashKey;

	[Token(Token = "0x400164E")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly int _layerMask;

	[Token(Token = "0x400164F")]
	[FieldOffset(Offset = "0xDC")]
	private CSCharacterInfo m_characterInfo;

	[Token(Token = "0x4001650")]
	[FieldOffset(Offset = "0xE0")]
	private SkinInfo m_skinInfo;

	[Token(Token = "0x4001651")]
	[FieldOffset(Offset = "0xE4")]
	private float m_range;

	[Token(Token = "0x4001652")]
	[FieldOffset(Offset = "0xE8")]
	private MeshVisible.HideFlag m_hideFlag;

	[Token(Token = "0x4001653")]
	[FieldOffset(Offset = "0xEC")]
	private bool isOnDissolve;

	[Token(Token = "0x4001654")]
	[FieldOffset(Offset = "0xED")]
	private bool m_isEnemy;

	[Token(Token = "0x4001655")]
	[FieldOffset(Offset = "0xF0")]
	private MeshVisible.State m_visibleState;

	[Token(Token = "0x4001656")]
	[FieldOffset(Offset = "0xF4")]
	private float Height__BackingField;

	[Token(Token = "0x4001657")]
	[FieldOffset(Offset = "0xF8")]
	private float HeightForInterface__BackingField;

	[Token(Token = "0x4001658")]
	[FieldOffset(Offset = "0xFC")]
	private float ColliderRadius__BackingField;

	[Token(Token = "0x17000616")]
	public float Height
	{
		[Token(Token = "0x6002529")]
		[Address(RVA = "0xB4DA80", Offset = "0xB4DA80", VA = "0xB4DA80")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600252A")]
		[Address(RVA = "0xB6A1CC", Offset = "0xB6A1CC", VA = "0xB6A1CC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000617")]
	public float HeightForInterface
	{
		[Token(Token = "0x600252B")]
		[Address(RVA = "0xB65B54", Offset = "0xB65B54", VA = "0xB65B54")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600252C")]
		[Address(RVA = "0xB6A1D4", Offset = "0xB6A1D4", VA = "0xB6A1D4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000618")]
	public float ColliderRadius
	{
		[Token(Token = "0x600252D")]
		[Address(RVA = "0xB4CAD4", Offset = "0xB4CAD4", VA = "0xB4CAD4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600252E")]
		[Address(RVA = "0xB6A1DC", Offset = "0xB6A1DC", VA = "0xB6A1DC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000619")]
	public virtual bool IsVisible
	{
		[Token(Token = "0x6002556")]
		[Address(RVA = "0xB6DA2C", Offset = "0xB6DA2C", VA = "0xB6DA2C", Slot = "59")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700061A")]
	public virtual bool IsHide
	{
		[Token(Token = "0x6002557")]
		[Address(RVA = "0xB6DA3C", Offset = "0xB6DA3C", VA = "0xB6DA3C", Slot = "60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002527")]
	[Address(RVA = "0xB69C3C", Offset = "0xB69C3C", VA = "0xB69C3C")]
	public XModuleMesh()
	{
	}

	[Token(Token = "0x6002528")]
	[Address(RVA = "0xB69EC4", Offset = "0xB69EC4", VA = "0xB69EC4")]
	static XModuleMesh()
	{
	}

	[Token(Token = "0x600252F")]
	[Address(RVA = "0xB6A1E4", Offset = "0xB6A1E4", VA = "0xB6A1E4")]
	private void CacheRenderComponents()
	{
	}

	[Token(Token = "0x6002530")]
	[Address(RVA = "0xB6A2B0", Offset = "0xB6A2B0", VA = "0xB6A2B0")]
	public bool IsRendering()
	{
		return default(bool);
	}

	[Token(Token = "0x6002531")]
	[Address(RVA = "0xB6A394", Offset = "0xB6A394", VA = "0xB6A394", Slot = "17")]
	public override void OnActorInit(XModuleActor.CreationDesc desc)
	{
	}

	[Token(Token = "0x6002532")]
	[Address(RVA = "0xB6AAE0", Offset = "0xB6AAE0", VA = "0xB6AAE0")]
	private void CachingMaterials()
	{
	}

	[Token(Token = "0x6002533")]
	[Address(RVA = "0xB6AB14", Offset = "0xB6AB14", VA = "0xB6AB14")]
	private void SetDefaultMaterials()
	{
	}

	[Token(Token = "0x6002534")]
	[Address(RVA = "0xB6AB48", Offset = "0xB6AB48", VA = "0xB6AB48")]
	private void SetInGameMaterials()
	{
	}

	[Token(Token = "0x6002535")]
	[Address(RVA = "0xB6AB7C", Offset = "0xB6AB7C", VA = "0xB6AB7C")]
	public void SetLobbyMaterials()
	{
	}

	[Token(Token = "0x6002536")]
	[Address(RVA = "0xB6ABB0", Offset = "0xB6ABB0", VA = "0xB6ABB0")]
	public void SetDissolveMaterials()
	{
	}

	[Token(Token = "0x6002537")]
	[Address(RVA = "0xB6ABE4", Offset = "0xB6ABE4", VA = "0xB6ABE4")]
	private void SetBehindMesh(bool set)
	{
	}

	[Token(Token = "0x6002538")]
	[Address(RVA = "0xB6721C", Offset = "0xB6721C", VA = "0xB6721C")]
	public void SetBehindMeshColor(bool isEnemy)
	{
	}

	[Token(Token = "0x6002539")]
	[Address(RVA = "0xB6AE64", Offset = "0xB6AE64", VA = "0xB6AE64")]
	public bool AttachModel(CSCharacterInfo characterInfo, SkinInfo skinInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x600253A")]
	[Address(RVA = "0xB6B7A0", Offset = "0xB6B7A0", VA = "0xB6B7A0", Slot = "23")]
	public override void OnActorChangeModel(CSCharacterInfo characterInfo, SkinInfo skinInfo)
	{
	}

	[Token(Token = "0x600253B")]
	[Address(RVA = "0xB6B7A4", Offset = "0xB6B7A4", VA = "0xB6B7A4", Slot = "24")]
	public override void OnActorTag()
	{
	}

	[Token(Token = "0x600253C")]
	[Address(RVA = "0xB6AA88", Offset = "0xB6AA88", VA = "0xB6AA88")]
	private bool UpdateModel(CSCharacterInfo characterInfo, SkinInfo skinInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x600253D")]
	[Address(RVA = "0xB6B104", Offset = "0xB6B104", VA = "0xB6B104")]
	private void SetScale(CSCharacterInfo characterInfo)
	{
	}

	[Token(Token = "0x600253E")]
	[Address(RVA = "0xB6B1A0", Offset = "0xB6B1A0", VA = "0xB6B1A0")]
	private void SetCharacterControllerBounds(CSCharacterInfo characterInfo)
	{
	}

	[Token(Token = "0x600253F")]
	[Address(RVA = "0xB6BA68", Offset = "0xB6BA68", VA = "0xB6BA68", Slot = "19")]
	public override void OnActorReady()
	{
	}

	[Token(Token = "0x6002540")]
	[Address(RVA = "0xB6BBD4", Offset = "0xB6BBD4", VA = "0xB6BBD4", Slot = "16")]
	public override void OnActorRevive()
	{
	}

	[Token(Token = "0x6002541")]
	[Address(RVA = "0xB6BA10", Offset = "0xB6BA10", VA = "0xB6BA10")]
	private void InitMesh(CSCharacterInfo characterInfo)
	{
	}

	[Token(Token = "0x6002542")]
	[Address(RVA = "0xB6BA6C", Offset = "0xB6BA6C", VA = "0xB6BA6C")]
	private void ResetMesh()
	{
	}

	[Token(Token = "0x6002543")]
	[Address(RVA = "0xB6A788", Offset = "0xB6A788", VA = "0xB6A788")]
	private void InitCharacterShadow(CSCharacterInfo info)
	{
	}

	[Token(Token = "0x6002544")]
	[Address(RVA = "0xB6B86C", Offset = "0xB6B86C", VA = "0xB6B86C")]
	private void ResizeCharacterShadow(CSCharacterInfo info)
	{
	}

	[Token(Token = "0x6002545")]
	[Address(RVA = "0xB6B82C", Offset = "0xB6B82C", VA = "0xB6B82C")]
	public void Final()
	{
	}

	[Token(Token = "0x6002546")]
	[Address(RVA = "0xB6BBF0", Offset = "0xB6BBF0", VA = "0xB6BBF0")]
	private void ResetColorInfo()
	{
	}

	[Token(Token = "0x6002547")]
	[Address(RVA = "0xB6BEA4", Offset = "0xB6BEA4", VA = "0xB6BEA4")]
	private void SetMeshRimBrightness(GameObject goModel, float brightness)
	{
	}

	[Token(Token = "0x6002548")]
	[Address(RVA = "0xB6C330", Offset = "0xB6C330", VA = "0xB6C330")]
	private float CalcDamageRimBrightness(float decrementElapsedTime, float decrementTargetTime)
	{
		return default(float);
	}

	[Token(Token = "0x6002549")]
	[Address(RVA = "0xB6C34C", Offset = "0xB6C34C", VA = "0xB6C34C")]
	private bool IsOcclusionCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600254A")]
	[Address(RVA = "0xB6CBD0", Offset = "0xB6CBD0", VA = "0xB6CBD0", Slot = "6")]
	public override void OnUpdate(float dt)
	{
	}

	[Token(Token = "0x600254B")]
	[Address(RVA = "0xB6D104", Offset = "0xB6D104", VA = "0xB6D104")]
	private void SetHitColor(float dt)
	{
	}

	[Token(Token = "0x600254C")]
	[Address(RVA = "0xB6D260", Offset = "0xB6D260", VA = "0xB6D260")]
	private void SetBehindMesh()
	{
	}

	[Token(Token = "0x600254D")]
	[Address(RVA = "0xB6D054", Offset = "0xB6D054", VA = "0xB6D054")]
	private void SkillEffectColor(float dt)
	{
	}

	[Token(Token = "0x600254E")]
	[Address(RVA = "0xB6C308", Offset = "0xB6C308", VA = "0xB6C308")]
	public void DefaultMeshColor(GameObject obj)
	{
	}

	[Token(Token = "0x600254F")]
	[Address(RVA = "0xB6D538", Offset = "0xB6D538", VA = "0xB6D538")]
	private void ChangeMeshColor(GameObject goModel, Color color)
	{
	}

	[Token(Token = "0x6002550")]
	[Address(RVA = "0xB6D48C", Offset = "0xB6D48C", VA = "0xB6D48C")]
	public void ChangeMeshColor(Color color)
	{
	}

	[Token(Token = "0x6002551")]
	[Address(RVA = "0xB6D3D8", Offset = "0xB6D3D8", VA = "0xB6D3D8")]
	private void ChangeHittedMeshColor(Color color, float weight)
	{
	}

	[Token(Token = "0x6002552")]
	[Address(RVA = "0xB6D7A4", Offset = "0xB6D7A4", VA = "0xB6D7A4")]
	private void SetVisible(bool bVisible)
	{
	}

	[Token(Token = "0x6002553")]
	[Address(RVA = "0xB6D8CC", Offset = "0xB6D8CC", VA = "0xB6D8CC")]
	public void GameResultSetting()
	{
	}

	[Token(Token = "0x6002554")]
	[Address(RVA = "0xB55CE8", Offset = "0xB55CE8", VA = "0xB55CE8")]
	public void SetDissolveWidth(float width)
	{
	}

	[Token(Token = "0x6002555")]
	[Address(RVA = "0xB6D8EC", Offset = "0xB6D8EC", VA = "0xB6D8EC")]
	public void SetVisible(string strGameObjectName, bool bVisible)
	{
	}

	[Token(Token = "0x6002558")]
	[Address(RVA = "0xB6DA50", Offset = "0xB6DA50", VA = "0xB6DA50")]
	public void SetVisibleForce(MeshVisible.State state)
	{
	}

	[Token(Token = "0x6002559")]
	[Address(RVA = "0xB6BC50", Offset = "0xB6BC50", VA = "0xB6BC50")]
	private void UpdateVisibleState(MeshVisible.State state)
	{
	}

	[Token(Token = "0x600255A")]
	[Address(RVA = "0xB6DA54", Offset = "0xB6DA54", VA = "0xB6DA54")]
	private void SetAlpha(float val)
	{
	}

	[Token(Token = "0x600255B")]
	[Address(RVA = "0xB6C0E4", Offset = "0xB6C0E4", VA = "0xB6C0E4")]
	private void SetMeshRimColor(GameObject goModel, Color color)
	{
	}

	[Token(Token = "0x600255C")]
	[Address(RVA = "0xB6D4BC", Offset = "0xB6D4BC", VA = "0xB6D4BC")]
	private void ResetSkillEffect()
	{
	}

	[Token(Token = "0x600255D")]
	[Address(RVA = "0xB6DE24", Offset = "0xB6DE24", VA = "0xB6DE24", Slot = "26")]
	public override void OnSkillStart(XSkill skill)
	{
	}

	[Token(Token = "0x600255E")]
	[Address(RVA = "0xB4CFB8", Offset = "0xB4CFB8", VA = "0xB4CFB8")]
	internal void UpdateVisibleFlagAndMesh(MeshVisible.HideFlag flag, bool val)
	{
	}

	[Token(Token = "0x600255F")]
	[Address(RVA = "0xB4CF80", Offset = "0xB4CF80", VA = "0xB4CF80")]
	internal void UpdateVisibleFlag(MeshVisible.HideFlag flag, bool val)
	{
	}

	[Token(Token = "0x6002560")]
	[Address(RVA = "0xB6E0B8", Offset = "0xB6E0B8", VA = "0xB6E0B8", Slot = "31")]
	public override void OnSkillCanceled(XSkill skill)
	{
	}

	[Token(Token = "0x6002561")]
	[Address(RVA = "0xB6E108", Offset = "0xB6E108", VA = "0xB6E108", Slot = "35")]
	public override void OnHitMe(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x6002562")]
	[Address(RVA = "0xB6E4B4", Offset = "0xB6E4B4", VA = "0xB6E4B4")]
	private void SetHitPurposeColor(ModuleEventArgument_Hit arg, int skinID)
	{
	}

	[Token(Token = "0x6002563")]
	[Address(RVA = "0xB6E730", Offset = "0xB6E730", VA = "0xB6E730", Slot = "40")]
	public override void OnGameObjectDestroy()
	{
	}

	[Token(Token = "0x6002564")]
	[Address(RVA = "0xB6E988", Offset = "0xB6E988", VA = "0xB6E988")]
	private void SetDefaultLayer()
	{
	}

	[Token(Token = "0x6002565")]
	[Address(RVA = "0xB6B630", Offset = "0xB6B630", VA = "0xB6B630")]
	private void InitDummyLoc()
	{
	}

	[Token(Token = "0x6002566")]
	[Address(RVA = "0xB6E9C0", Offset = "0xB6E9C0", VA = "0xB6E9C0")]
	public void ResetDummyLoc()
	{
	}

	[Token(Token = "0x6002567")]
	[Address(RVA = "0xB6EABC", Offset = "0xB6EABC", VA = "0xB6EABC")]
	public bool IsExistDummyLoc()
	{
		return default(bool);
	}

	[Token(Token = "0x6002568")]
	[Address(RVA = "0xB43CA0", Offset = "0xB43CA0", VA = "0xB43CA0")]
	public Vector3 GetDummyLocLocalPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6002569")]
	[Address(RVA = "0xB43CCC", Offset = "0xB43CCC", VA = "0xB43CCC")]
	public float GetDummyLocLossyScale()
	{
		return default(float);
	}

	[Token(Token = "0x600256A")]
	[Address(RVA = "0xB6EB6C", Offset = "0xB6EB6C", VA = "0xB6EB6C", Slot = "37")]
	public override void OnActorDie(ModuleEventArgument_Hit arg)
	{
	}

	[Token(Token = "0x600256B")]
	[Address(RVA = "0xB6EC70", Offset = "0xB6EC70", VA = "0xB6EC70", Slot = "45")]
	public override void OnHide()
	{
	}
}
