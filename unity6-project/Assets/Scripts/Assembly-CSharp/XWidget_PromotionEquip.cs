using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000C93")]
public class XWidget_PromotionEquip : XWidget_ItemDetail
{
	[Token(Token = "0x2000C94")]
	private sealed class _003CDirectComplete_003Ec__AnonStorey188
	{
		[Token(Token = "0x400400E")]
		[FieldOffset(Offset = "0x8")]
		internal XItem resultItem;

		[Token(Token = "0x400400F")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_PromotionEquip _003C_003Ef__this;

		[Token(Token = "0x6005ADF")]
		[Address(RVA = "0x13234F0", Offset = "0x13234F0", VA = "0x13234F0")]
		public _003CDirectComplete_003Ec__AnonStorey188()
		{
		}

		[Token(Token = "0x6005AE0")]
		[Address(RVA = "0x1323C3C", Offset = "0x1323C3C", VA = "0x1323C3C")]
		internal void _003C_003Em__26A()
		{
		}

		[Token(Token = "0x6005AE1")]
		[Address(RVA = "0x1323DE0", Offset = "0x1323DE0", VA = "0x1323DE0")]
		internal void _003C_003Em__26B()
		{
		}

		[Token(Token = "0x6005AE2")]
		[Address(RVA = "0x1323ED0", Offset = "0x1323ED0", VA = "0x1323ED0")]
		internal void _003C_003Em__26C()
		{
		}

		[Token(Token = "0x6005AE3")]
		[Address(RVA = "0x1323FAC", Offset = "0x1323FAC", VA = "0x1323FAC")]
		internal void _003C_003Em__26D()
		{
		}

		[Token(Token = "0x6005AE4")]
		[Address(RVA = "0x1324110", Offset = "0x1324110", VA = "0x1324110")]
		internal void _003C_003Em__26F()
		{
		}
	}

	[Token(Token = "0x4003FF4")]
	[FieldOffset(Offset = "0xB4")]
	public UILabel lblNeedStoneCnt;

	[Token(Token = "0x4003FF5")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel lblNeedGoldCnt;

	[Token(Token = "0x4003FF6")]
	[FieldOffset(Offset = "0xBC")]
	public Transform resultIconParnt;

	[Token(Token = "0x4003FF7")]
	[FieldOffset(Offset = "0xC0")]
	public XWidget_TweenPosItemIcon m_promItemIcon;

	[Token(Token = "0x4003FF8")]
	[FieldOffset(Offset = "0xC4")]
	public Transform promItemTransform;

	[Token(Token = "0x4003FF9")]
	[FieldOffset(Offset = "0xC8")]
	public XWidget_TweenPosItemIcon m_resultIcon;

	[Token(Token = "0x4003FFA")]
	[FieldOffset(Offset = "0xCC")]
	public Transform resultItemTransform;

	[Token(Token = "0x4003FFB")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject originalItemEffect;

	[Token(Token = "0x4003FFC")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject resultItemEffect;

	[Token(Token = "0x4003FFD")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject goPromotionInfoText;

	[Token(Token = "0x4003FFE")]
	[FieldOffset(Offset = "0xDC")]
	private UIDirector m_director;

	[Token(Token = "0x4003FFF")]
	[FieldOffset(Offset = "0xE0")]
	public UI2DSprite sprStone;

	[Token(Token = "0x4004000")]
	[FieldOffset(Offset = "0xE4")]
	public UI2DSprite sprGold;

	[Token(Token = "0x4004001")]
	[FieldOffset(Offset = "0xE8")]
	public XWidget_Button btnConfirm;

	[Token(Token = "0x4004002")]
	[FieldOffset(Offset = "0xEC")]
	public UIScrollView statScrollView;

	[Token(Token = "0x4004003")]
	[FieldOffset(Offset = "0xF0")]
	public XUIDiscountTag DiscountTagGold;

	[Token(Token = "0x4004004")]
	[FieldOffset(Offset = "0xF4")]
	public XUIDiscountTag DiscountTagStone;

	[Token(Token = "0x4004005")]
	[FieldOffset(Offset = "0xF8")]
	private XItem m_resultItem;

	[Token(Token = "0x4004006")]
	[FieldOffset(Offset = "0xFC")]
	private XUIInvenItemList m_invenItemList;

	[Token(Token = "0x4004007")]
	[FieldOffset(Offset = "0x100")]
	private Action<XItem> m_onComplete;

	[Token(Token = "0x4004008")]
	[FieldOffset(Offset = "0x104")]
	private Action m_onClose;

	[Token(Token = "0x4004009")]
	[FieldOffset(Offset = "0x108")]
	public string UIPromotionStartSoundKey;

	[Token(Token = "0x400400A")]
	[FieldOffset(Offset = "0x10C")]
	public string UIPromotionMaterialCombineSoundKey;

	[Token(Token = "0x400400B")]
	[FieldOffset(Offset = "0x110")]
	public string UIPromotionConfirmDlgSoundKey;

	[Token(Token = "0x400400C")]
	[FieldOffset(Offset = "0x114")]
	public string UIButtonFailSoundKey;

	[Token(Token = "0x400400D")]
	[FieldOffset(Offset = "0x118")]
	private bool IsDirecting__BackingField;

	[Token(Token = "0x17000CC2")]
	public bool IsDirecting
	{
		[Token(Token = "0x6005ACB")]
		[Address(RVA = "0x1321600", Offset = "0x1321600", VA = "0x1321600")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005ACC")]
		[Address(RVA = "0x1321608", Offset = "0x1321608", VA = "0x1321608")]
		private set
		{
		}
	}

	[Token(Token = "0x6005AC9")]
	[Address(RVA = "0x1321350", Offset = "0x1321350", VA = "0x1321350")]
	public XWidget_PromotionEquip()
	{
	}

	[Token(Token = "0x6005ACA")]
	[Address(RVA = "0x1321440", Offset = "0x1321440", VA = "0x1321440")]
	private void InitItem()
	{
	}

	[Token(Token = "0x6005ACD")]
	[Address(RVA = "0x1321610", Offset = "0x1321610", VA = "0x1321610")]
	private void Update()
	{
	}

	[Token(Token = "0x6005ACE")]
	[Address(RVA = "0x132163C", Offset = "0x132163C", VA = "0x132163C")]
	public void ShowWarnning()
	{
	}

	[Token(Token = "0x6005ACF")]
	[Address(RVA = "0x13217E8", Offset = "0x13217E8", VA = "0x13217E8")]
	public void Build(XUIInvenItemList invenItemList, Action<XItem> onComplete, Action onClose)
	{
	}

	[Token(Token = "0x6005AD0")]
	[Address(RVA = "0x13219EC", Offset = "0x13219EC", VA = "0x13219EC")]
	public void Refresh(XItem item)
	{
	}

	[Token(Token = "0x6005AD1")]
	[Address(RVA = "0x1322D30", Offset = "0x1322D30", VA = "0x1322D30")]
	public void BuildItemIcons()
	{
	}

	[Token(Token = "0x6005AD2")]
	[Address(RVA = "0x1322878", Offset = "0x1322878", VA = "0x1322878")]
	public void BuildCost(bool isEnoughStone, bool isEnoughGold)
	{
	}

	[Token(Token = "0x6005AD3")]
	[Address(RVA = "0x1322F4C", Offset = "0x1322F4C", VA = "0x1322F4C")]
	private void BuildLabel(UILabel lbl, Color textColor, string text)
	{
	}

	[Token(Token = "0x6005AD4")]
	[Address(RVA = "0x1321E5C", Offset = "0x1321E5C", VA = "0x1321E5C")]
	public void BuildResultStat()
	{
	}

	[Token(Token = "0x6005AD5")]
	[Address(RVA = "0x1321C18", Offset = "0x1321C18", VA = "0x1321C18")]
	public XItem GetNextRarityItem()
	{
		return null;
	}

	[Token(Token = "0x6005AD6")]
	[Address(RVA = "0x1322544", Offset = "0x1322544", VA = "0x1322544")]
	private bool CheckPromotionStone()
	{
		return default(bool);
	}

	[Token(Token = "0x6005AD7")]
	[Address(RVA = "0x13226F0", Offset = "0x13226F0", VA = "0x13226F0")]
	private bool CheckPromotionGold()
	{
		return default(bool);
	}

	[Token(Token = "0x6005AD8")]
	[Address(RVA = "0x1323058", Offset = "0x1323058", VA = "0x1323058")]
	public void DirectComplete(XItem resultItem)
	{
	}

	[Token(Token = "0x6005AD9")]
	[Address(RVA = "0x13234F8", Offset = "0x13234F8", VA = "0x13234F8", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6005ADA")]
	[Address(RVA = "0x132355C", Offset = "0x132355C", VA = "0x132355C", Slot = "21")]
	protected override void BuildStat(XItem resultItem)
	{
	}

	[Token(Token = "0x6005ADB")]
	[Address(RVA = "0x1323560", Offset = "0x1323560", VA = "0x1323560")]
	public void OnClick_Promotion()
	{
	}

	[Token(Token = "0x6005ADC")]
	[Address(RVA = "0x1323A58", Offset = "0x1323A58", VA = "0x1323A58")]
	public void OnClick_Tutorial()
	{
	}

	[Token(Token = "0x6005ADD")]
	[Address(RVA = "0x1323A5C", Offset = "0x1323A5C", VA = "0x1323A5C")]
	private void _003CBuild_003Em__269()
	{
	}

	[Token(Token = "0x6005ADE")]
	[Address(RVA = "0x1323AB4", Offset = "0x1323AB4", VA = "0x1323AB4")]
	private void _003COnClick_Promotion_003Em__26E(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
