using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000EE9")]
public class XWidget_TranscendenceEquip : XWidget_ItemDetail
{
	[Token(Token = "0x2000EEA")]
	private enum SelectType
	{
		[Token(Token = "0x4004F03")]
		None = 0,
		[Token(Token = "0x4004F04")]
		Select = 1,
		[Token(Token = "0x4004F05")]
		Deselect = 2
	}

	[Token(Token = "0x2000EEB")]
	private sealed class _003CDirectComplete_003Ec__AnonStorey21D
	{
		[Token(Token = "0x4004F06")]
		[FieldOffset(Offset = "0x8")]
		internal Vector3 originItemPos;

		[Token(Token = "0x4004F07")]
		[FieldOffset(Offset = "0x14")]
		internal Vector3 materialItemPos;

		[Token(Token = "0x4004F08")]
		[FieldOffset(Offset = "0x20")]
		internal XItem resultItem;

		[Token(Token = "0x4004F09")]
		[FieldOffset(Offset = "0x24")]
		internal XWidget_TranscendenceEquip _003C_003Ef__this;

		[Token(Token = "0x6006F62")]
		[Address(RVA = "0x1B2AB90", Offset = "0x1B2AB90", VA = "0x1B2AB90")]
		public _003CDirectComplete_003Ec__AnonStorey21D()
		{
		}

		[Token(Token = "0x6006F63")]
		[Address(RVA = "0x1B2AF00", Offset = "0x1B2AF00", VA = "0x1B2AF00")]
		internal void _003C_003Em__441()
		{
		}

		[Token(Token = "0x6006F64")]
		[Address(RVA = "0x1B2B240", Offset = "0x1B2B240", VA = "0x1B2B240")]
		internal void _003C_003Em__442()
		{
		}

		[Token(Token = "0x6006F65")]
		[Address(RVA = "0x1B2B28C", Offset = "0x1B2B28C", VA = "0x1B2B28C")]
		internal void _003C_003Em__443()
		{
		}

		[Token(Token = "0x6006F66")]
		[Address(RVA = "0x1B2B3B4", Offset = "0x1B2B3B4", VA = "0x1B2B3B4")]
		internal void _003C_003Em__444()
		{
		}

		[Token(Token = "0x6006F67")]
		[Address(RVA = "0x1B2B400", Offset = "0x1B2B400", VA = "0x1B2B400")]
		internal void _003C_003Em__445()
		{
		}

		[Token(Token = "0x6006F68")]
		[Address(RVA = "0x1B2B4DC", Offset = "0x1B2B4DC", VA = "0x1B2B4DC")]
		internal void _003C_003Em__446()
		{
		}

		[Token(Token = "0x6006F69")]
		[Address(RVA = "0x1B2B668", Offset = "0x1B2B668", VA = "0x1B2B668")]
		internal void _003C_003Em__447()
		{
		}

		[Token(Token = "0x6006F6A")]
		[Address(RVA = "0x1B2B744", Offset = "0x1B2B744", VA = "0x1B2B744")]
		internal void _003C_003Em__448()
		{
		}
	}

	[Token(Token = "0x4004EEB")]
	[FieldOffset(Offset = "0x0")]
	public static int SELECT_MATARIAL_MAX_COUNT;

	[Token(Token = "0x4004EEC")]
	[FieldOffset(Offset = "0xB4")]
	public UI2DSprite sprStone;

	[Token(Token = "0x4004EED")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel lblTranscendenceNeedCost;

	[Token(Token = "0x4004EEE")]
	[FieldOffset(Offset = "0xBC")]
	public Transform originItemTransform;

	[Token(Token = "0x4004EEF")]
	[FieldOffset(Offset = "0xC0")]
	public Transform materialTransform;

	[Token(Token = "0x4004EF0")]
	[FieldOffset(Offset = "0xC4")]
	public Transform resultTransform;

	[Token(Token = "0x4004EF1")]
	[FieldOffset(Offset = "0xC8")]
	public XWidget_TweenPosItemIcon m_originItemIcon;

	[Token(Token = "0x4004EF2")]
	[FieldOffset(Offset = "0xCC")]
	public XWidget_TweenPosItemIcon m_materialIcon;

	[Token(Token = "0x4004EF3")]
	[FieldOffset(Offset = "0xD0")]
	public XWidget_TweenPosItemIcon m_resultIcon;

	[Token(Token = "0x4004EF4")]
	[FieldOffset(Offset = "0xD4")]
	public XUIEffectPool effectPool;

	[Token(Token = "0x4004EF5")]
	[FieldOffset(Offset = "0xD8")]
	private UIDirector m_director;

	[Token(Token = "0x4004EF6")]
	[FieldOffset(Offset = "0xDC")]
	public XWidget_Button btnConfirm;

	[Token(Token = "0x4004EF7")]
	[FieldOffset(Offset = "0xE0")]
	public UIScrollView statScrollView;

	[Token(Token = "0x4004EF8")]
	[FieldOffset(Offset = "0xE4")]
	private XItem m_materialItem;

	[Token(Token = "0x4004EF9")]
	[FieldOffset(Offset = "0xE8")]
	private XItem m_resultItem;

	[Token(Token = "0x4004EFA")]
	[FieldOffset(Offset = "0xEC")]
	private Action<XItem> m_onComplete;

	[Token(Token = "0x4004EFB")]
	[FieldOffset(Offset = "0xF0")]
	private Action m_onClose;

	[Token(Token = "0x4004EFC")]
	[FieldOffset(Offset = "0xF4")]
	private XUIInvenItemList m_invenItemList;

	[Token(Token = "0x4004EFD")]
	[FieldOffset(Offset = "0xF8")]
	public string UITranscendenceStartSoundKey;

	[Token(Token = "0x4004EFE")]
	[FieldOffset(Offset = "0xFC")]
	public string UITranscendenceMaterialCombineSoundKey;

	[Token(Token = "0x4004EFF")]
	[FieldOffset(Offset = "0x100")]
	public string UITranscendenceConfirmDlgSoundKey;

	[Token(Token = "0x4004F00")]
	[FieldOffset(Offset = "0x104")]
	public string UIButtonFailSoundKey;

	[Token(Token = "0x4004F01")]
	[FieldOffset(Offset = "0x108")]
	private bool IsDirecting__BackingField;

	[Token(Token = "0x17000E22")]
	public bool IsDirecting
	{
		[Token(Token = "0x6006F4B")]
		[Address(RVA = "0x1B27DD8", Offset = "0x1B27DD8", VA = "0x1B27DD8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006F4C")]
		[Address(RVA = "0x1B27DE0", Offset = "0x1B27DE0", VA = "0x1B27DE0")]
		private set
		{
		}
	}

	[Token(Token = "0x6006F49")]
	[Address(RVA = "0x1B27C64", Offset = "0x1B27C64", VA = "0x1B27C64")]
	public XWidget_TranscendenceEquip()
	{
	}

	[Token(Token = "0x6006F4D")]
	[Address(RVA = "0x1B27DE8", Offset = "0x1B27DE8", VA = "0x1B27DE8")]
	private void InitItem()
	{
	}

	[Token(Token = "0x6006F4E")]
	[Address(RVA = "0x1B281E0", Offset = "0x1B281E0", VA = "0x1B281E0")]
	private void Update()
	{
	}

	[Token(Token = "0x6006F4F")]
	[Address(RVA = "0x1B2820C", Offset = "0x1B2820C", VA = "0x1B2820C")]
	public void ShowWarnning()
	{
	}

	[Token(Token = "0x6006F50")]
	[Address(RVA = "0x1B283B8", Offset = "0x1B283B8", VA = "0x1B283B8")]
	public void Build(Action<XItem> onComplete, Action onClose, XUIInvenItemList invenList)
	{
	}

	[Token(Token = "0x6006F51")]
	[Address(RVA = "0x1B28660", Offset = "0x1B28660", VA = "0x1B28660")]
	private void RefreshSelectItem(List<string> selectIIDs)
	{
	}

	[Token(Token = "0x6006F52")]
	[Address(RVA = "0x1B285C0", Offset = "0x1B285C0", VA = "0x1B285C0")]
	public void Refresh(List<string> selectIIDs)
	{
	}

	[Token(Token = "0x6006F53")]
	[Address(RVA = "0x1B28600", Offset = "0x1B28600", VA = "0x1B28600")]
	public void SetBtnConfirm()
	{
	}

	[Token(Token = "0x6006F54")]
	[Address(RVA = "0x1B2988C", Offset = "0x1B2988C", VA = "0x1B2988C")]
	private bool IsEnoughPromotionStone()
	{
		return default(bool);
	}

	[Token(Token = "0x6006F55")]
	[Address(RVA = "0x1B28BD0", Offset = "0x1B28BD0", VA = "0x1B28BD0")]
	public void BuildItemIcons()
	{
	}

	[Token(Token = "0x6006F56")]
	[Address(RVA = "0x1B28EA0", Offset = "0x1B28EA0", VA = "0x1B28EA0")]
	protected void BuildTranscendencePrice(XItem item)
	{
	}

	[Token(Token = "0x6006F57")]
	[Address(RVA = "0x1B2916C", Offset = "0x1B2916C", VA = "0x1B2916C")]
	public void BuildResultStat()
	{
	}

	[Token(Token = "0x6006F58")]
	[Address(RVA = "0x1B299A8", Offset = "0x1B299A8", VA = "0x1B299A8")]
	private int GetTranscendencePrice()
	{
		return default(int);
	}

	[Token(Token = "0x6006F59")]
	[Address(RVA = "0x1B28870", Offset = "0x1B28870", VA = "0x1B28870")]
	public XItem GetTranscendenceItem()
	{
		return null;
	}

	[Token(Token = "0x6006F5A")]
	[Address(RVA = "0x1B29E84", Offset = "0x1B29E84", VA = "0x1B29E84", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6006F5B")]
	[Address(RVA = "0x1B29EDC", Offset = "0x1B29EDC", VA = "0x1B29EDC", Slot = "21")]
	protected override void BuildStat(XItem resultItem)
	{
	}

	[Token(Token = "0x6006F5C")]
	[Address(RVA = "0x1B29EE0", Offset = "0x1B29EE0", VA = "0x1B29EE0", Slot = "22")]
	protected override void BuildRandomOptionStat(XItem item, XWiget_GridBuilder randoptionBuilder)
	{
	}

	[Token(Token = "0x6006F5D")]
	[Address(RVA = "0x1B29EE4", Offset = "0x1B29EE4", VA = "0x1B29EE4")]
	public void OnClick_Transcendence()
	{
	}

	[Token(Token = "0x6006F5E")]
	[Address(RVA = "0x1B2A3F0", Offset = "0x1B2A3F0", VA = "0x1B2A3F0")]
	private void ShowErrorUI(ApiReturnCode retCode)
	{
	}

	[Token(Token = "0x6006F5F")]
	[Address(RVA = "0x1B2A550", Offset = "0x1B2A550", VA = "0x1B2A550")]
	public void OnClick_Tutorial()
	{
	}

	[Token(Token = "0x6006F60")]
	[Address(RVA = "0x1B2A554", Offset = "0x1B2A554", VA = "0x1B2A554")]
	public void DirectComplete(XItem resultItem)
	{
	}

	[Token(Token = "0x6006F61")]
	[Address(RVA = "0x1B2AB98", Offset = "0x1B2AB98", VA = "0x1B2AB98")]
	private void _003COnClick_Transcendence_003Em__440(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
