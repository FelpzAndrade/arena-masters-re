using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000ECB")]
public class XWidget_FusionEquip : XWidget_ItemDetail
{
	[Token(Token = "0x2000ECC")]
	private sealed class _003CDirectComplete_003Ec__AnonStorey20F
	{
		[Token(Token = "0x4004DE8")]
		[FieldOffset(Offset = "0x8")]
		internal List<GameObject> consumeList;

		[Token(Token = "0x4004DE9")]
		[FieldOffset(Offset = "0xC")]
		internal int i;

		[Token(Token = "0x4004DEA")]
		[FieldOffset(Offset = "0x10")]
		internal XItem item;

		[Token(Token = "0x4004DEB")]
		[FieldOffset(Offset = "0x14")]
		internal XWidget_FusionEquip _003C_003Ef__this;

		[Token(Token = "0x6006E4B")]
		[Address(RVA = "0x1432754", Offset = "0x1432754", VA = "0x1432754")]
		public _003CDirectComplete_003Ec__AnonStorey20F()
		{
		}

		[Token(Token = "0x6006E4C")]
		[Address(RVA = "0x1432C4C", Offset = "0x1432C4C", VA = "0x1432C4C")]
		internal void _003C_003Em__417()
		{
		}

		[Token(Token = "0x6006E4D")]
		[Address(RVA = "0x1432D3C", Offset = "0x1432D3C", VA = "0x1432D3C")]
		internal void _003C_003Em__418()
		{
		}

		[Token(Token = "0x6006E4E")]
		[Address(RVA = "0x1432E18", Offset = "0x1432E18", VA = "0x1432E18")]
		internal void _003C_003Em__419()
		{
		}
	}

	[Token(Token = "0x2000ECD")]
	private sealed class _003CDirectComplete_003Ec__AnonStorey20E
	{
		[Token(Token = "0x4004DEC")]
		[FieldOffset(Offset = "0x8")]
		internal XWidget_TweenPosItemIcon mat;

		[Token(Token = "0x4004DED")]
		[FieldOffset(Offset = "0xC")]
		internal _003CDirectComplete_003Ec__AnonStorey20F _003C_003Ef__ref_0024527;

		[Token(Token = "0x4004DEE")]
		[FieldOffset(Offset = "0x10")]
		internal XWidget_FusionEquip _003C_003Ef__this;

		[Token(Token = "0x6006E4F")]
		[Address(RVA = "0x143275C", Offset = "0x143275C", VA = "0x143275C")]
		public _003CDirectComplete_003Ec__AnonStorey20E()
		{
		}

		[Token(Token = "0x6006E50")]
		[Address(RVA = "0x14329A0", Offset = "0x14329A0", VA = "0x14329A0")]
		internal void _003C_003Em__414()
		{
		}

		[Token(Token = "0x6006E51")]
		[Address(RVA = "0x1432A08", Offset = "0x1432A08", VA = "0x1432A08")]
		internal void _003C_003Em__415()
		{
		}

		[Token(Token = "0x6006E52")]
		[Address(RVA = "0x1432B70", Offset = "0x1432B70", VA = "0x1432B70")]
		internal void _003C_003Em__416()
		{
		}
	}

	[Token(Token = "0x4004DC8")]
	[FieldOffset(Offset = "0xB4")]
	public XWiget_GridBuilder gridConsumeItem;

	[Token(Token = "0x4004DC9")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject[] materialItemEffectArray;

	[Token(Token = "0x4004DCA")]
	[FieldOffset(Offset = "0xBC")]
	public GameObject resultItemEffect;

	[Token(Token = "0x4004DCB")]
	[FieldOffset(Offset = "0xC0")]
	public XWidget_Button btnConfirm;

	[Token(Token = "0x4004DCC")]
	[FieldOffset(Offset = "0xC4")]
	public Transform transformResultItem;

	[Token(Token = "0x4004DCD")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel lblInfo;

	[Token(Token = "0x4004DCE")]
	[FieldOffset(Offset = "0xCC")]
	private XListView_InvenItem m_invenItemList;

	[Token(Token = "0x4004DCF")]
	[FieldOffset(Offset = "0xD0")]
	private UIDirector m_director;

	[Token(Token = "0x4004DD0")]
	[FieldOffset(Offset = "0xD4")]
	public XWidget_TweenPosItemIcon m_targetItemIcon;

	[Token(Token = "0x4004DD1")]
	[FieldOffset(Offset = "0xD8")]
	public XWidget_TweenPosItemIcon m_resultItemIcon;

	[Token(Token = "0x4004DD2")]
	[FieldOffset(Offset = "0xDC")]
	public Transform targetItemTransform;

	[Token(Token = "0x4004DD3")]
	[FieldOffset(Offset = "0xE0")]
	public Transform resultItemTransform;

	[Token(Token = "0x4004DD4")]
	[FieldOffset(Offset = "0xE4")]
	private XItem m_targetItem;

	[Token(Token = "0x4004DD5")]
	[FieldOffset(Offset = "0xE8")]
	public UISprite sprSlot;

	[Token(Token = "0x4004DD6")]
	[FieldOffset(Offset = "0xEC")]
	public XUIDiscountTag DiscountTag;

	[Token(Token = "0x4004DD7")]
	[FieldOffset(Offset = "0xF0")]
	public float effectDelayOnTweenStart;

	[Token(Token = "0x4004DD8")]
	[FieldOffset(Offset = "0xF4")]
	public float completePopupDelay;

	[Token(Token = "0x4004DD9")]
	[FieldOffset(Offset = "0xF8")]
	private List<string> fusionItemIIDList;

	[Token(Token = "0x4004DDA")]
	[FieldOffset(Offset = "0xFC")]
	private List<string> m_selectedConsumedFusionItems;

	[Token(Token = "0x4004DDB")]
	[FieldOffset(Offset = "0x100")]
	private bool m_isEnoughGold;

	[Token(Token = "0x4004DDC")]
	[FieldOffset(Offset = "0x104")]
	private CSProtoInfoManager_Item m_protoItem;

	[Token(Token = "0x4004DDD")]
	[FieldOffset(Offset = "0x108")]
	private XMyInfo m_userInfo;

	[Token(Token = "0x4004DDE")]
	[FieldOffset(Offset = "0x10C")]
	private Dictionary<int, string> m_materialIconPath;

	[Token(Token = "0x4004DDF")]
	[FieldOffset(Offset = "0x110")]
	private bool m_isStartFusion;

	[Token(Token = "0x4004DE0")]
	[FieldOffset(Offset = "0x114")]
	public string UIFusionStartSoundKey;

	[Token(Token = "0x4004DE1")]
	[FieldOffset(Offset = "0x118")]
	public string UIFusionMaterialCombineSoundKey;

	[Token(Token = "0x4004DE2")]
	[FieldOffset(Offset = "0x11C")]
	public string UIFusionConfirmDlgSoundKey;

	[Token(Token = "0x4004DE3")]
	[FieldOffset(Offset = "0x120")]
	public string UIButtonFailSoundKey;

	[Token(Token = "0x4004DE4")]
	[FieldOffset(Offset = "0x124")]
	private XItem m_consumeItem;

	[Token(Token = "0x4004DE5")]
	[FieldOffset(Offset = "0x128")]
	private FusionDescription m_fusionDescription;

	[Token(Token = "0x4004DE6")]
	[FieldOffset(Offset = "0x12C")]
	private Action<XItem, InventoryModeType> m_onComplete;

	[Token(Token = "0x4004DE7")]
	[FieldOffset(Offset = "0x130")]
	private Action m_onClose;

	[Token(Token = "0x6006E38")]
	[Address(RVA = "0x1430190", Offset = "0x1430190", VA = "0x1430190")]
	public XWidget_FusionEquip()
	{
	}

	[Token(Token = "0x6006E39")]
	[Address(RVA = "0x14303D4", Offset = "0x14303D4", VA = "0x14303D4")]
	private void InitItem()
	{
	}

	[Token(Token = "0x6006E3A")]
	[Address(RVA = "0x1430594", Offset = "0x1430594", VA = "0x1430594")]
	public void Awake()
	{
	}

	[Token(Token = "0x6006E3B")]
	[Address(RVA = "0x143074C", Offset = "0x143074C", VA = "0x143074C")]
	public void ShowWarnning()
	{
	}

	[Token(Token = "0x6006E3C")]
	[Address(RVA = "0x1430888", Offset = "0x1430888", VA = "0x1430888")]
	private void Update()
	{
	}

	[Token(Token = "0x6006E3D")]
	[Address(RVA = "0x14308B4", Offset = "0x14308B4", VA = "0x14308B4")]
	public void Build(CSProtoInfoManager_Item m_protoItem, XMyInfo m_userInfo, XUIInvenItemList invenItemList, Action<XItem, InventoryModeType> onComplete, Action onClose)
	{
	}

	[Token(Token = "0x6006E3E")]
	[Address(RVA = "0x1430C50", Offset = "0x1430C50", VA = "0x1430C50")]
	public void ClearSelectConsumeFusionItemList()
	{
	}

	[Token(Token = "0x6006E3F")]
	[Address(RVA = "0x1430AAC", Offset = "0x1430AAC", VA = "0x1430AAC")]
	private void ResetUI()
	{
	}

	[Token(Token = "0x6006E40")]
	[Address(RVA = "0x1430EBC", Offset = "0x1430EBC", VA = "0x1430EBC")]
	private void BuildItemIcons()
	{
	}

	[Token(Token = "0x6006E41")]
	[Address(RVA = "0x1430D04", Offset = "0x1430D04", VA = "0x1430D04")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6006E42")]
	[Address(RVA = "0x143131C", Offset = "0x143131C", VA = "0x143131C")]
	private void ApplyHotTimeDiscount(FusionDescription fusionDesc)
	{
	}

	[Token(Token = "0x6006E43")]
	[Address(RVA = "0x14315E8", Offset = "0x14315E8", VA = "0x14315E8")]
	private void ShowFusionCost(FusionDescription fusionDesc)
	{
	}

	[Token(Token = "0x6006E44")]
	[Address(RVA = "0x1431A24", Offset = "0x1431A24", VA = "0x1431A24", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6006E45")]
	[Address(RVA = "0x14312B0", Offset = "0x14312B0", VA = "0x14312B0")]
	private FusionDescription GetFusionDescription()
	{
		return null;
	}

	[Token(Token = "0x6006E46")]
	[Address(RVA = "0x1431880", Offset = "0x1431880", VA = "0x1431880")]
	private void CheckFusionCondition(FusionDescription fusionDescription)
	{
	}

	[Token(Token = "0x6006E47")]
	[Address(RVA = "0x1431A5C", Offset = "0x1431A5C", VA = "0x1431A5C")]
	public bool GetIsStartFusion()
	{
		return default(bool);
	}

	[Token(Token = "0x6006E48")]
	[Address(RVA = "0x1431A64", Offset = "0x1431A64", VA = "0x1431A64")]
	public void OnClick_Fusion()
	{
	}

	[Token(Token = "0x6006E49")]
	[Address(RVA = "0x1431F9C", Offset = "0x1431F9C", VA = "0x1431F9C")]
	public void DirectComplete(XItem item)
	{
	}

	[Token(Token = "0x6006E4A")]
	[Address(RVA = "0x1432764", Offset = "0x1432764", VA = "0x1432764")]
	private void _003COnClick_Fusion_003Em__413(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
