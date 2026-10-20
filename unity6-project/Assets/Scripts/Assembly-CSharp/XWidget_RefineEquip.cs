using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000EE1")]
public class XWidget_RefineEquip : XWidget_ItemDetail
{
	[Token(Token = "0x2000EE2")]
	private sealed class _003CBuildExpIncrease_003Ec__AnonStorey219
	{
		[Token(Token = "0x4004ED5")]
		[FieldOffset(Offset = "0x8")]
		internal CSProtoInfoManager_ItemBalance balance;

		[Token(Token = "0x4004ED6")]
		[FieldOffset(Offset = "0xC")]
		internal CSProtoInfoManager_GameConst protoInfoConst;

		[Token(Token = "0x4004ED7")]
		[FieldOffset(Offset = "0x10")]
		internal XWidget_RefineEquip _003C_003Ef__this;

		[Token(Token = "0x6006F24")]
		[Address(RVA = "0x1335AC0", Offset = "0x1335AC0", VA = "0x1335AC0")]
		public _003CBuildExpIncrease_003Ec__AnonStorey219()
		{
		}

		[Token(Token = "0x6006F25")]
		[Address(RVA = "0x13382FC", Offset = "0x13382FC", VA = "0x13382FC")]
		internal string _003C_003Em__431(int val)
		{
			return null;
		}

		[Token(Token = "0x6006F26")]
		[Address(RVA = "0x1338470", Offset = "0x1338470", VA = "0x1338470")]
		internal void _003C_003Em__432(int val)
		{
		}

		[Token(Token = "0x6006F27")]
		[Address(RVA = "0x13384A0", Offset = "0x13384A0", VA = "0x13384A0")]
		internal bool _003C_003Em__433(int val)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000EE3")]
	private sealed class _003COnClick_Refine_003Ec__AnonStorey21A
	{
		[Token(Token = "0x4004ED8")]
		[FieldOffset(Offset = "0x8")]
		internal List<string> materialIDs;

		[Token(Token = "0x4004ED9")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_RefineEquip _003C_003Ef__this;

		[Token(Token = "0x6006F28")]
		[Address(RVA = "0x1337368", Offset = "0x1337368", VA = "0x1337368")]
		public _003COnClick_Refine_003Ec__AnonStorey21A()
		{
		}

		[Token(Token = "0x6006F29")]
		[Address(RVA = "0x1338898", Offset = "0x1338898", VA = "0x1338898")]
		internal void _003C_003Em__436(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x2000EE4")]
	private sealed class _003CDirectComplete_003Ec__AnonStorey21B
	{
		[Token(Token = "0x4004EDA")]
		[FieldOffset(Offset = "0x8")]
		internal XWidget_TweenPosItemIcon mat;

		[Token(Token = "0x4004EDB")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_RefineEquip _003C_003Ef__this;

		[Token(Token = "0x6006F2A")]
		[Address(RVA = "0x1337B2C", Offset = "0x1337B2C", VA = "0x1337B2C")]
		public _003CDirectComplete_003Ec__AnonStorey21B()
		{
		}

		[Token(Token = "0x6006F2B")]
		[Address(RVA = "0x1338594", Offset = "0x1338594", VA = "0x1338594")]
		internal void _003C_003Em__438()
		{
		}

		[Token(Token = "0x6006F2C")]
		[Address(RVA = "0x13385C0", Offset = "0x13385C0", VA = "0x13385C0")]
		internal void _003C_003Em__439()
		{
		}

		[Token(Token = "0x6006F2D")]
		[Address(RVA = "0x1338668", Offset = "0x1338668", VA = "0x1338668")]
		internal void _003C_003Em__43A()
		{
		}

		[Token(Token = "0x6006F2E")]
		[Address(RVA = "0x1338744", Offset = "0x1338744", VA = "0x1338744")]
		internal void _003C_003Em__43B()
		{
		}

		[Token(Token = "0x6006F2F")]
		[Address(RVA = "0x1338870", Offset = "0x1338870", VA = "0x1338870")]
		internal void _003C_003Em__43E()
		{
		}
	}

	[Token(Token = "0x4004EB6")]
	[FieldOffset(Offset = "0xB4")]
	public XWidget_ProgressBarWithTable prbRefineExp;

	[Token(Token = "0x4004EB7")]
	[FieldOffset(Offset = "0xB8")]
	public XWidget_TweenPosItemIcon m_refineItemIcon;

	[Token(Token = "0x4004EB8")]
	[FieldOffset(Offset = "0xBC")]
	public Transform refineItemTransform;

	[Token(Token = "0x4004EB9")]
	[FieldOffset(Offset = "0xC0")]
	public XWiget_GridBuilder gridMaterial;

	[Token(Token = "0x4004EBA")]
	[FieldOffset(Offset = "0xC4")]
	public XUIEffectPool effectPool;

	[Token(Token = "0x4004EBB")]
	[FieldOffset(Offset = "0xC8")]
	public XUIEffectPool originEffectPool;

	[Token(Token = "0x4004EBC")]
	[FieldOffset(Offset = "0xCC")]
	public float effectDelayOnTweenStart;

	[Token(Token = "0x4004EBD")]
	[FieldOffset(Offset = "0xD0")]
	public float completePopupDelay;

	[Token(Token = "0x4004EBE")]
	[FieldOffset(Offset = "0xD4")]
	public UILabel lblAfter;

	[Token(Token = "0x4004EBF")]
	[FieldOffset(Offset = "0xD8")]
	public UIButton btnClose;

	[Token(Token = "0x4004EC0")]
	[FieldOffset(Offset = "0xDC")]
	public XWidget_Button btnConfirm;

	[Token(Token = "0x4004EC1")]
	[FieldOffset(Offset = "0xE0")]
	public UILabel lblSelectCnt;

	[Token(Token = "0x4004EC2")]
	[FieldOffset(Offset = "0xE4")]
	public UIScrollView statScrollView;

	[Token(Token = "0x4004EC3")]
	[FieldOffset(Offset = "0xE8")]
	public UIScrollView materialScrollView;

	[Token(Token = "0x4004EC4")]
	[FieldOffset(Offset = "0xEC")]
	public XUIDiscountTag DiscountTag;

	[Token(Token = "0x4004EC5")]
	[FieldOffset(Offset = "0xF0")]
	private List<Transform> lblEffectPositions;

	[Token(Token = "0x4004EC6")]
	[FieldOffset(Offset = "0xF4")]
	private XUIInvenItemList m_invenItemList;

	[Token(Token = "0x4004EC7")]
	[FieldOffset(Offset = "0xF8")]
	private UIDirector m_director;

	[Token(Token = "0x4004EC8")]
	[FieldOffset(Offset = "0xFC")]
	public Action<XItem> m_onComplete;

	[Token(Token = "0x4004EC9")]
	[FieldOffset(Offset = "0x100")]
	public Action m_onClose;

	[Token(Token = "0x4004ECA")]
	[FieldOffset(Offset = "0x104")]
	private string UIRefineStartSoundKey;

	[Token(Token = "0x4004ECB")]
	[FieldOffset(Offset = "0x108")]
	private string UIRefineMaterialCombineSoundKey;

	[Token(Token = "0x4004ECC")]
	[FieldOffset(Offset = "0x10C")]
	private string UIRefineConfirmDlgSoundKey;

	[Token(Token = "0x4004ECD")]
	[FieldOffset(Offset = "0x110")]
	private string UIButtonFailSoundKey;

	[Token(Token = "0x4004ECE")]
	[FieldOffset(Offset = "0x114")]
	private string m_itemIID;

	[Token(Token = "0x4004ECF")]
	[FieldOffset(Offset = "0x118")]
	private string m_charUID;

	[Token(Token = "0x4004ED0")]
	[FieldOffset(Offset = "0x11C")]
	private EquipmentSlot m_slotType;

	[Token(Token = "0x4004ED1")]
	[FieldOffset(Offset = "0x120")]
	private XWidget_TweenPosItemIcon[] matIcons;

	[Token(Token = "0x4004ED2")]
	[FieldOffset(Offset = "0x124")]
	private bool m_refineProccessing;

	[Token(Token = "0x4004ED3")]
	[FieldOffset(Offset = "0x0")]
	private static Action<UILabel, int> _003C_003Ef__am_0024cache1D;

	[Token(Token = "0x4004ED4")]
	[FieldOffset(Offset = "0x4")]
	private static Action<UIProgressBar, int> _003C_003Ef__am_0024cache1E;

	[Token(Token = "0x6006F06")]
	[Address(RVA = "0x1334364", Offset = "0x1334364", VA = "0x1334364")]
	public XWidget_RefineEquip()
	{
	}

	[Token(Token = "0x6006F07")]
	[Address(RVA = "0x1334508", Offset = "0x1334508", VA = "0x1334508")]
	private void InitItem()
	{
	}

	[Token(Token = "0x6006F08")]
	[Address(RVA = "0x1334610", Offset = "0x1334610", VA = "0x1334610")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006F09")]
	[Address(RVA = "0x1334898", Offset = "0x1334898", VA = "0x1334898")]
	public new bool ActiveSelf()
	{
		return default(bool);
	}

	[Token(Token = "0x6006F0A")]
	[Address(RVA = "0x13348C8", Offset = "0x13348C8", VA = "0x13348C8")]
	public void Build(XItem item, XUIInvenItemList invenItemList, Action<XItem> onComplete, Action onClose)
	{
	}

	[Token(Token = "0x6006F0B")]
	[Address(RVA = "0x1335210", Offset = "0x1335210", VA = "0x1335210")]
	private void SetSelectCnt(int selectCnt)
	{
	}

	[Token(Token = "0x6006F0C")]
	[Address(RVA = "0x1334C08", Offset = "0x1334C08", VA = "0x1334C08")]
	private void BuildTargetItem(XItem item)
	{
	}

	[Token(Token = "0x6006F0D")]
	[Address(RVA = "0x1335800", Offset = "0x1335800", VA = "0x1335800")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6006F0E")]
	[Address(RVA = "0x1335348", Offset = "0x1335348", VA = "0x1335348")]
	public void BuildExpIncrease()
	{
	}

	[Token(Token = "0x6006F0F")]
	[Address(RVA = "0x1335860", Offset = "0x1335860", VA = "0x1335860")]
	public void SetValueExpIncrease(XItem item)
	{
	}

	[Token(Token = "0x6006F10")]
	[Address(RVA = "0x1334DEC", Offset = "0x1334DEC", VA = "0x1334DEC")]
	protected void BuildMaterials()
	{
	}

	[Token(Token = "0x6006F11")]
	[Address(RVA = "0x1335AC8", Offset = "0x1335AC8", VA = "0x1335AC8")]
	protected void MoveMaterialScrollView(int posIndex)
	{
	}

	[Token(Token = "0x6006F12")]
	[Address(RVA = "0x1335B9C", Offset = "0x1335B9C", VA = "0x1335B9C", Slot = "21")]
	protected override void BuildStat(XItem item)
	{
	}

	[Token(Token = "0x6006F13")]
	[Address(RVA = "0x133600C", Offset = "0x133600C", VA = "0x133600C")]
	protected void BuildStat(XItem item, int val)
	{
	}

	[Token(Token = "0x6006F14")]
	[Address(RVA = "0x1336718", Offset = "0x1336718", VA = "0x1336718", Slot = "20")]
	protected override void BuildPrice(XItem item)
	{
	}

	[Token(Token = "0x6006F15")]
	[Address(RVA = "0x133476C", Offset = "0x133476C", VA = "0x133476C")]
	protected void BuildConfirmBtn()
	{
	}

	[Token(Token = "0x6006F16")]
	[Address(RVA = "0x1336814", Offset = "0x1336814", VA = "0x1336814")]
	private int GetPrice(XItem item, List<XItem> mats)
	{
		return default(int);
	}

	[Token(Token = "0x6006F17")]
	[Address(RVA = "0x1336C20", Offset = "0x1336C20", VA = "0x1336C20", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6006F18")]
	[Address(RVA = "0x1336C68", Offset = "0x1336C68", VA = "0x1336C68")]
	private void Update()
	{
	}

	[Token(Token = "0x6006F19")]
	[Address(RVA = "0x1334AEC", Offset = "0x1334AEC", VA = "0x1334AEC")]
	private void SetRefineProccessing(bool isProccessing)
	{
	}

	[Token(Token = "0x6006F1A")]
	[Address(RVA = "0x1336C94", Offset = "0x1336C94", VA = "0x1336C94")]
	public void OnClick_Refine()
	{
	}

	[Token(Token = "0x6006F1B")]
	[Address(RVA = "0x1337370", Offset = "0x1337370", VA = "0x1337370")]
	public void DirectComplete(int matCnt)
	{
	}

	[Token(Token = "0x6006F1C")]
	[Address(RVA = "0x1337B34", Offset = "0x1337B34", VA = "0x1337B34")]
	public void ShowWarninng()
	{
	}

	[Token(Token = "0x6006F1D")]
	[Address(RVA = "0x1337C70", Offset = "0x1337C70", VA = "0x1337C70")]
	private void FinishEffect()
	{
	}

	[Token(Token = "0x6006F1E")]
	[Address(RVA = "0x1337D04", Offset = "0x1337D04", VA = "0x1337D04")]
	private ParticleSystem[] GetEffectsParticleSystem(GameObject effect)
	{
		return null;
	}

	[Token(Token = "0x6006F1F")]
	[Address(RVA = "0x1337D9C", Offset = "0x1337D9C", VA = "0x1337D9C")]
	private static void _003CBuildExpIncrease_003Em__434(UILabel label, int val)
	{
	}

	[Token(Token = "0x6006F20")]
	[Address(RVA = "0x1337E38", Offset = "0x1337E38", VA = "0x1337E38")]
	private static void _003CBuildExpIncrease_003Em__435(UIProgressBar prb, int val)
	{
	}

	[Token(Token = "0x6006F21")]
	[Address(RVA = "0x1337EB8", Offset = "0x1337EB8", VA = "0x1337EB8")]
	private void _003CDirectComplete_003Em__437()
	{
	}

	[Token(Token = "0x6006F22")]
	[Address(RVA = "0x1337EC0", Offset = "0x1337EC0", VA = "0x1337EC0")]
	private void _003CDirectComplete_003Em__43C()
	{
	}

	[Token(Token = "0x6006F23")]
	[Address(RVA = "0x1337F94", Offset = "0x1337F94", VA = "0x1337F94")]
	private void _003CDirectComplete_003Em__43D()
	{
	}
}
