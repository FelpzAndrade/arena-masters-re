using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000ED7")]
public class XWidget_ItemDetail : XWidget_PopupTween
{
	[Token(Token = "0x2000ED8")]
	private sealed class _003CBuildExp_003Ec__AnonStorey187
	{
		[Token(Token = "0x4004E64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal CSProtoInfoManager_ItemBalance balance;

		[Token(Token = "0x4004E65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal ItemRarity itemRarity;

		[Token(Token = "0x4004E66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XItem item;

		[Token(Token = "0x4004E67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal CSProtoInfoManager_GameConst protoInfoConst;

		[Token(Token = "0x6006EBD")]
		[Address(RVA = "0x14537B8", Offset = "0x14537B8", VA = "0x14537B8")]
		public _003CBuildExp_003Ec__AnonStorey187()
		{
		}

		[Token(Token = "0x6006EBE")]
		[Address(RVA = "0x1454284", Offset = "0x1454284", VA = "0x1454284")]
		internal bool _003C_003Em__266(int val)
		{
			return default(bool);
		}

		[Token(Token = "0x6006EBF")]
		[Address(RVA = "0x14542F8", Offset = "0x14542F8", VA = "0x14542F8")]
		internal void _003C_003Em__267(UILabel label, int val)
		{
		}

		[Token(Token = "0x6006EC0")]
		[Address(RVA = "0x145443C", Offset = "0x145443C", VA = "0x145443C")]
		internal void _003C_003Em__268(UIProgressBar prb, int val)
		{
		}
	}

	[Token(Token = "0x4004E42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public XWidget_ItemBaseInfo itembaseInfo;

	[Token(Token = "0x4004E43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public UILabel lblName;

	[Token(Token = "0x4004E44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform iconParent;

	[Token(Token = "0x4004E45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public UILabel lblGrade;

	[Token(Token = "0x4004E46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public UILabel lblType;

	[Token(Token = "0x4004E47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public UILabel lblLevel;

	[Token(Token = "0x4004E48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public UILabel lblPrice;

	[Token(Token = "0x4004E49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public UILabel lblDesc;

	[Token(Token = "0x4004E4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public XWidget_Builder builderStat;

	[Token(Token = "0x4004E4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public UILabel lblArenaCoinPrice;

	[Token(Token = "0x4004E4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Dictionary<string, XWidget_LabelTriple> statLabels;

	[Token(Token = "0x4004E4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public GameObject statRoot;

	[Token(Token = "0x4004E4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public XWiget_GridBuilder gridrandomOptionStat;

	[Token(Token = "0x4004E4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public GameObject randomOptionRoot;

	[Token(Token = "0x4004E50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public XWiget_GridBuilder gridButtons;

	[Token(Token = "0x4004E51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public XWidget_ProgressBarWithTable prbExp;

	[Token(Token = "0x4004E52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public UIScrollView clippedView;

	[Token(Token = "0x4004E53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public bool UseNameColor;

	[Token(Token = "0x4004E54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
	public bool UseRarityTextBracket;

	[Token(Token = "0x4004E55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject itemPrice;

	[Token(Token = "0x4004E56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public GameObject ArenaCoinPrice;

	[Token(Token = "0x4004E57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject CoolTime;

	[Token(Token = "0x4004E58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public UILabel lblRemainTime;

	[Token(Token = "0x4004E59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected XItem m_item;

	[Token(Token = "0x4004E5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	protected XWidget_ItemIcon m_itemIcon;

	[Token(Token = "0x4004E5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected bool IsUseTranscendStatColor;

	[Token(Token = "0x4004E5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public XWiget_GridBuilder gridSetItemIcon;

	[Token(Token = "0x4004E5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public XWiget_GridBuilder gridSetItemDesc;

	[Token(Token = "0x4004E5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public UILabel lblSetName;

	[Token(Token = "0x4004E5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public UILabel lblSetBuffName;

	[Token(Token = "0x4004E60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public GameObject setItemRoot;

	[Token(Token = "0x4004E61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public UILabel lblSkillName;

	[Token(Token = "0x4004E62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public UILabel lblSkillDesc;

	[Token(Token = "0x4004E63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject itemSkillRoot;

	[Token(Token = "0x17000E1C")]
	public XItem Item
	{
		[Token(Token = "0x6006EA7")]
		[Address(RVA = "0x1452B18", Offset = "0x1452B18", VA = "0x1452B18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006EA6")]
	[Address(RVA = "0x143031C", Offset = "0x143031C", VA = "0x143031C")]
	public XWidget_ItemDetail()
	{
	}

	[Token(Token = "0x6006EA8")]
	[Address(RVA = "0x1452B20", Offset = "0x1452B20", VA = "0x1452B20")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006EA9")]
	[Address(RVA = "0x1442D0C", Offset = "0x1442D0C", VA = "0x1442D0C")]
	public void BuildItemSKillInfo([Optional] XItem item)
	{
	}

	[Token(Token = "0x6006EAA")]
	[Address(RVA = "0x1441688", Offset = "0x1441688", VA = "0x1441688")]
	public void BuildSetItemInfo(XModuleActor curCharacter, [Optional] XItem item)
	{
	}

	[Token(Token = "0x6006EAB")]
	[Address(RVA = "0x14434A0", Offset = "0x14434A0", VA = "0x14434A0", Slot = "19")]
	protected virtual void BuildGrade(CSItemInfo itemInfo)
	{
	}

	[Token(Token = "0x6006EAC")]
	[Address(RVA = "0x14408D8", Offset = "0x14408D8", VA = "0x14408D8")]
	public void Build(XItem item)
	{
	}

	[Token(Token = "0x6006EAD")]
	[Address(RVA = "0x1452DFC", Offset = "0x1452DFC", VA = "0x1452DFC")]
	private void BuildLevel(XItem item)
	{
	}

	[Token(Token = "0x6006EAE")]
	[Address(RVA = "0x14533B0", Offset = "0x14533B0", VA = "0x14533B0", Slot = "20")]
	protected virtual void BuildPrice(XItem item)
	{
	}

	[Token(Token = "0x6006EAF")]
	[Address(RVA = "0x1444210", Offset = "0x1444210", VA = "0x1444210")]
	protected bool IsSellPossible()
	{
		return default(bool);
	}

	[Token(Token = "0x6006EB0")]
	[Address(RVA = "0x145302C", Offset = "0x145302C", VA = "0x145302C")]
	protected void BuildExp(XItem item)
	{
	}

	[Token(Token = "0x6006EB1")]
	[Address(RVA = "0x1443A00", Offset = "0x1443A00", VA = "0x1443A00")]
	protected void SetActiveStatRoot(bool isActive)
	{
	}

	[Token(Token = "0x6006EB2")]
	[Address(RVA = "0x1452C3C", Offset = "0x1452C3C", VA = "0x1452C3C")]
	protected void SetActiveRandomOptionRoot(bool isActive)
	{
	}

	[Token(Token = "0x6006EB3")]
	[Address(RVA = "0x1452B5C", Offset = "0x1452B5C", VA = "0x1452B5C")]
	protected void SetActiveSetRoot(bool isActive)
	{
	}

	[Token(Token = "0x6006EB4")]
	[Address(RVA = "0x1452D1C", Offset = "0x1452D1C", VA = "0x1452D1C")]
	protected void SetActiveItemSkillRoot(bool isActive)
	{
	}

	[Token(Token = "0x6006EB5")]
	[Address(RVA = "0x14537C0", Offset = "0x14537C0", VA = "0x14537C0", Slot = "21")]
	protected virtual void BuildStat(XItem item)
	{
	}

	[Token(Token = "0x6006EB6")]
	[Address(RVA = "0x1453B78", Offset = "0x1453B78", VA = "0x1453B78", Slot = "22")]
	protected virtual void BuildRandomOptionStat(XItem item, XWiget_GridBuilder randoptionBuilder)
	{
	}

	[Token(Token = "0x6006EB7")]
	[Address(RVA = "0x1443AE0", Offset = "0x1443AE0", VA = "0x1443AE0")]
	protected XItem GetCurCharacterItem(EquipmentSlot slot)
	{
		return null;
	}

	[Token(Token = "0x6006EB8")]
	[Address(RVA = "0x1443CF0", Offset = "0x1443CF0", VA = "0x1443CF0")]
	protected string GetStatRGBName(XCharStatusDisplay.StatInfo stat)
	{
		return null;
	}

	[Token(Token = "0x6006EB9")]
	[Address(RVA = "0x1453ECC", Offset = "0x1453ECC", VA = "0x1453ECC")]
	protected string GetRandomStatRGBName(XCharStatusDisplay.StatInfo stat)
	{
		return null;
	}

	[Token(Token = "0x6006EBA")]
	[Address(RVA = "0x1454070", Offset = "0x1454070", VA = "0x1454070", Slot = "23")]
	protected virtual void BuildButtons(XItem item)
	{
	}

	[Token(Token = "0x6006EBB")]
	[Address(RVA = "0x1454074", Offset = "0x1454074", VA = "0x1454074")]
	public void OnEquipmentPopup(XItem equipped)
	{
	}

	[Token(Token = "0x6006EBC")]
	[Address(RVA = "0x145413C", Offset = "0x145413C", VA = "0x145413C")]
	public string GetBasicStatTextValue(string name)
	{
		return null;
	}
}
