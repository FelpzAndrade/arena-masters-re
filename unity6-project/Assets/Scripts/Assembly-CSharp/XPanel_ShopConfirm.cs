using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E28")]
public class XPanel_ShopConfirm : MonoBehaviour
{
	[Token(Token = "0x2000E29")]
	private sealed class _003CBuildSingleContent_003Ec__AnonStorey1B5
	{
		[Token(Token = "0x4004A6A")]
		[FieldOffset(Offset = "0x8")]
		internal CSContent content;

		[Token(Token = "0x4004A6B")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_ShopConfirm _003C_003Ef__this;

		[Token(Token = "0x6006937")]
		[Address(RVA = "0xAC7278", Offset = "0xAC7278", VA = "0xAC7278")]
		public _003CBuildSingleContent_003Ec__AnonStorey1B5()
		{
		}

		[Token(Token = "0x6006938")]
		[Address(RVA = "0xAC7B84", Offset = "0xAC7B84", VA = "0xAC7B84")]
		internal void _003C_003Em__333()
		{
		}

		[Token(Token = "0x6006939")]
		[Address(RVA = "0xAC7C00", Offset = "0xAC7C00", VA = "0xAC7C00")]
		internal void _003C_003Em__334()
		{
		}

		[Token(Token = "0x600693A")]
		[Address(RVA = "0xAC7C5C", Offset = "0xAC7C5C", VA = "0xAC7C5C")]
		internal void _003C_003Em__335()
		{
		}
	}

	[Token(Token = "0x2000E2A")]
	private sealed class _003CBuildMultiContent_003Ec__AnonStorey1B6
	{
		[Token(Token = "0x4004A6C")]
		[FieldOffset(Offset = "0x8")]
		internal List<CSContent> contents;

		[Token(Token = "0x4004A6D")]
		[FieldOffset(Offset = "0xC")]
		internal IShopItem shopitem;

		[Token(Token = "0x4004A6E")]
		[FieldOffset(Offset = "0x10")]
		internal XPanel_ShopConfirm _003C_003Ef__this;

		[Token(Token = "0x600693B")]
		[Address(RVA = "0xAC7378", Offset = "0xAC7378", VA = "0xAC7378")]
		public _003CBuildMultiContent_003Ec__AnonStorey1B6()
		{
		}

		[Token(Token = "0x600693C")]
		[Address(RVA = "0xAC79F8", Offset = "0xAC79F8", VA = "0xAC79F8")]
		internal void _003C_003Em__336()
		{
		}
	}

	[Token(Token = "0x4004A3D")]
	[FieldOffset(Offset = "0xC")]
	public Transform root;

	[Token(Token = "0x4004A3E")]
	[FieldOffset(Offset = "0x10")]
	private readonly string Path_SingleContent;

	[Token(Token = "0x4004A3F")]
	[FieldOffset(Offset = "0x14")]
	private readonly string Path_MultiContents;

	[Token(Token = "0x4004A40")]
	[FieldOffset(Offset = "0x18")]
	private readonly string Path_SingleGacha;

	[Token(Token = "0x4004A41")]
	[FieldOffset(Offset = "0x1C")]
	private readonly string Path_SingleGacha_m;

	[Token(Token = "0x4004A42")]
	[FieldOffset(Offset = "0x20")]
	private readonly string Path_BonusItem;

	[Token(Token = "0x4004A43")]
	[FieldOffset(Offset = "0x24")]
	private GameObject _frameForSingle;

	[Token(Token = "0x4004A44")]
	[FieldOffset(Offset = "0x28")]
	private GameObject _frameForMulti;

	[Token(Token = "0x4004A45")]
	[FieldOffset(Offset = "0x2C")]
	private XWidget_GachaItem _singleContentIcon;

	[Token(Token = "0x4004A46")]
	[FieldOffset(Offset = "0x30")]
	private XWidget_GachaCardBox _singleContentIcon_Multi;

	[Token(Token = "0x4004A47")]
	[FieldOffset(Offset = "0x34")]
	private XWidget_ShopBonusItem _shop_bonusItem;

	[Token(Token = "0x4004A48")]
	[FieldOffset(Offset = "0x38")]
	public XWidget_Button rebuyButton;

	[Token(Token = "0x4004A49")]
	[FieldOffset(Offset = "0x3C")]
	public XWidget_Button confirmButton;

	[Token(Token = "0x4004A4A")]
	[FieldOffset(Offset = "0x40")]
	public UIGrid gridBtns;

	[Token(Token = "0x4004A4B")]
	[FieldOffset(Offset = "0x44")]
	private XWidget_GachaItemCardDirection gachaItemCardDirection;

	[Token(Token = "0x4004A4C")]
	[FieldOffset(Offset = "0x48")]
	private UILabel lblToMailSingle;

	[Token(Token = "0x4004A4D")]
	[FieldOffset(Offset = "0x4C")]
	private UILabel lblToMailMulti;

	[Token(Token = "0x4004A4E")]
	[FieldOffset(Offset = "0x50")]
	private UILabel lblBuyItemComment;

	[Token(Token = "0x4004A4F")]
	[FieldOffset(Offset = "0x54")]
	private UILabel lblBuyItemComment_Center;

	[Token(Token = "0x4004A50")]
	[FieldOffset(Offset = "0x58")]
	private UILabel lblArenaCoinInsateadOf;

	[Token(Token = "0x4004A51")]
	[FieldOffset(Offset = "0x5C")]
	private UIGrid gridLabels;

	[Token(Token = "0x4004A52")]
	[FieldOffset(Offset = "0x60")]
	public float m_shopBoxDelay;

	[Token(Token = "0x4004A53")]
	[FieldOffset(Offset = "0x64")]
	public float buildContentDelayForSingle;

	[Token(Token = "0x4004A54")]
	[FieldOffset(Offset = "0x68")]
	public float buildContentDelayForMulti;

	[Token(Token = "0x4004A55")]
	[FieldOffset(Offset = "0x6C")]
	public float m_effectDelay;

	[Token(Token = "0x4004A56")]
	[FieldOffset(Offset = "0x70")]
	public float boxOpenOpenSoundBeforeDelay;

	[Token(Token = "0x4004A57")]
	[FieldOffset(Offset = "0x74")]
	public float boxOpenOpenSoundAfterDelay;

	[Token(Token = "0x4004A58")]
	[FieldOffset(Offset = "0x78")]
	public float effectMultiDurationDelayForSound;

	[Token(Token = "0x4004A59")]
	[FieldOffset(Offset = "0x7C")]
	public float effectMultiDurationInfo;

	[Token(Token = "0x4004A5A")]
	[FieldOffset(Offset = "0x80")]
	public float boxSoundDelay;

	[Token(Token = "0x4004A5B")]
	[FieldOffset(Offset = "0x84")]
	public float startBoxDelay;

	[Token(Token = "0x4004A5C")]
	[FieldOffset(Offset = "0x88")]
	public float perBoxDelay;

	[Token(Token = "0x4004A5D")]
	[FieldOffset(Offset = "0x8C")]
	private Vector3 normalGachaBoxPosition;

	[Token(Token = "0x4004A5E")]
	[FieldOffset(Offset = "0x98")]
	private Vector3 miniGachaBoxPosition;

	[Token(Token = "0x4004A5F")]
	[FieldOffset(Offset = "0xA4")]
	private Netdata_BuyShopItem m_acquisitions;

	[Token(Token = "0x4004A60")]
	[FieldOffset(Offset = "0xA8")]
	private Action m_rebuy;

	[Token(Token = "0x4004A61")]
	[FieldOffset(Offset = "0xAC")]
	private UIDirector m_direction;

	[Token(Token = "0x4004A62")]
	[FieldOffset(Offset = "0xB0")]
	private List<CSContent> m_contents;

	[Token(Token = "0x4004A63")]
	[FieldOffset(Offset = "0xB4")]
	private bool m_directionSkipped;

	[Token(Token = "0x4004A64")]
	[FieldOffset(Offset = "0xB8")]
	private int m_restoreGoldCount;

	[Token(Token = "0x4004A65")]
	[FieldOffset(Offset = "0xBC")]
	public string UIBoxOpenApparSoundKey;

	[Token(Token = "0x4004A66")]
	[FieldOffset(Offset = "0xC0")]
	public string UIBoxOpenOpenSoundKey;

	[Token(Token = "0x4004A67")]
	[FieldOffset(Offset = "0xC4")]
	private IShopItem m_shopItem;

	[Token(Token = "0x4004A68")]
	[FieldOffset(Offset = "0xC8")]
	private bool ProcessRebuy__BackingField;

	[Token(Token = "0x4004A69")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<CSContent> _003C_003Ef__am_0024cache2C;

	[Token(Token = "0x17000D93")]
	public GameObject frameForSingle
	{
		[Token(Token = "0x6006919")]
		[Address(RVA = "0xAC4A00", Offset = "0xAC4A00", VA = "0xAC4A00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D94")]
	public GameObject frameForMulti
	{
		[Token(Token = "0x600691A")]
		[Address(RVA = "0xAC4B90", Offset = "0xAC4B90", VA = "0xAC4B90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D95")]
	public XWidget_GachaItem singleContentIcon
	{
		[Token(Token = "0x600691B")]
		[Address(RVA = "0xAC4D20", Offset = "0xAC4D20", VA = "0xAC4D20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D96")]
	public XWidget_GachaCardBox singleContentIcon_Multi
	{
		[Token(Token = "0x600691C")]
		[Address(RVA = "0xAC4ED8", Offset = "0xAC4ED8", VA = "0xAC4ED8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D97")]
	public XWidget_ShopBonusItem ShopBonusItem
	{
		[Token(Token = "0x600691D")]
		[Address(RVA = "0xAC5090", Offset = "0xAC5090", VA = "0xAC5090")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D98")]
	public bool IsDirecting
	{
		[Token(Token = "0x600692C")]
		[Address(RVA = "0xAC7720", Offset = "0xAC7720", VA = "0xAC7720")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000D99")]
	public bool ProcessRebuy
	{
		[Token(Token = "0x600692D")]
		[Address(RVA = "0xAC7778", Offset = "0xAC7778", VA = "0xAC7778")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600692E")]
		[Address(RVA = "0xAC5DC4", Offset = "0xAC5DC4", VA = "0xAC5DC4")]
		private set
		{
		}
	}

	[Token(Token = "0x6006918")]
	[Address(RVA = "0xAC47FC", Offset = "0xAC47FC", VA = "0xAC47FC")]
	public XPanel_ShopConfirm()
	{
	}

	[Token(Token = "0x600691E")]
	[Address(RVA = "0xAC5248", Offset = "0xAC5248", VA = "0xAC5248")]
	private Netdata_BuyShopItem SetAcquisitions(ref Netdata_BuyShopItem acquisitions)
	{
		return null;
	}

	[Token(Token = "0x600691F")]
	[Address(RVA = "0xAC54AC", Offset = "0xAC54AC", VA = "0xAC54AC")]
	private bool IsContainFreeCurrency()
	{
		return default(bool);
	}

	[Token(Token = "0x6006920")]
	[Address(RVA = "0xAC55F4", Offset = "0xAC55F4", VA = "0xAC55F4")]
	public void Build(IShopItem shopitem, Netdata_BuyShopItem acquisitions, Action rebuy)
	{
	}

	[Token(Token = "0x6006921")]
	[Address(RVA = "0xAC7228", Offset = "0xAC7228", VA = "0xAC7228")]
	private bool IsBonusGold(CSContent content)
	{
		return default(bool);
	}

	[Token(Token = "0x6006922")]
	[Address(RVA = "0xAC6D24", Offset = "0xAC6D24", VA = "0xAC6D24")]
	public int GetRestoreGoldCount(List<CSContent> contents)
	{
		return default(int);
	}

	[Token(Token = "0x6006923")]
	[Address(RVA = "0xAC5DCC", Offset = "0xAC5DCC", VA = "0xAC5DCC")]
	public void Show()
	{
	}

	[Token(Token = "0x6006924")]
	[Address(RVA = "0xAC5FBC", Offset = "0xAC5FBC", VA = "0xAC5FBC")]
	private void BuildSingleContent(IShopItem shopItem, CSContent content)
	{
	}

	[Token(Token = "0x6006925")]
	[Address(RVA = "0xAC72E0", Offset = "0xAC72E0", VA = "0xAC72E0")]
	private void HideDisable()
	{
	}

	[Token(Token = "0x6006926")]
	[Address(RVA = "0xAC732C", Offset = "0xAC732C", VA = "0xAC732C")]
	private void ShowDisable()
	{
	}

	[Token(Token = "0x6006927")]
	[Address(RVA = "0xAC6EF0", Offset = "0xAC6EF0", VA = "0xAC6EF0")]
	private void BuildMultiContent(IShopItem shopitem, List<CSContent> contents)
	{
	}

	[Token(Token = "0x6006928")]
	[Address(RVA = "0xAC7458", Offset = "0xAC7458", VA = "0xAC7458")]
	private void Update()
	{
	}

	[Token(Token = "0x6006929")]
	[Address(RVA = "0xAC7484", Offset = "0xAC7484", VA = "0xAC7484")]
	private void AllDisable()
	{
	}

	[Token(Token = "0x600692A")]
	[Address(RVA = "0xAC7488", Offset = "0xAC7488", VA = "0xAC7488")]
	public void Hide()
	{
	}

	[Token(Token = "0x600692B")]
	[Address(RVA = "0xAC75EC", Offset = "0xAC75EC", VA = "0xAC75EC")]
	public void OnClickClose()
	{
	}

	[Token(Token = "0x600692F")]
	[Address(RVA = "0xAC7780", Offset = "0xAC7780", VA = "0xAC7780")]
	public void OnClickRebuy()
	{
	}

	[Token(Token = "0x6006930")]
	[Address(RVA = "0xAC77C0", Offset = "0xAC77C0", VA = "0xAC77C0")]
	private void Rebuy()
	{
	}

	[Token(Token = "0x6006931")]
	[Address(RVA = "0xAC7824", Offset = "0xAC7824", VA = "0xAC7824")]
	public void EnableButtons()
	{
	}

	[Token(Token = "0x6006932")]
	[Address(RVA = "0xAC7864", Offset = "0xAC7864", VA = "0xAC7864")]
	public bool IsToMailActive(bool isMulti)
	{
		return default(bool);
	}

	[Token(Token = "0x6006933")]
	[Address(RVA = "0xAC7280", Offset = "0xAC7280", VA = "0xAC7280")]
	private void SetActiveArenaCoinInsateadOf(CSContent content)
	{
	}

	[Token(Token = "0x6006934")]
	[Address(RVA = "0xAC7380", Offset = "0xAC7380", VA = "0xAC7380")]
	private void AssignLabelArenaCoinInsateadOf()
	{
	}

	[Token(Token = "0x6006935")]
	[Address(RVA = "0xAC5468", Offset = "0xAC5468", VA = "0xAC5468")]
	private bool IsExcludeContent(CSContent content)
	{
		return default(bool);
	}

	[Token(Token = "0x6006936")]
	[Address(RVA = "0xAC79C4", Offset = "0xAC79C4", VA = "0xAC79C4")]
	private static bool _003CIsContainFreeCurrency_003Em__332(CSContent x)
	{
		return default(bool);
	}
}
