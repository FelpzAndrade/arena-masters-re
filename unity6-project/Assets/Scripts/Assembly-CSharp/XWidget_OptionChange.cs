using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000EDB")]
public class XWidget_OptionChange : XWidget_ItemDetail
{
	[Token(Token = "0x2000EDC")]
	private sealed class _003CSendChangeOption_003Ec__AnonStorey216
	{
		[Token(Token = "0x4004E93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal bool isClose;

		[Token(Token = "0x4004E94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		internal bool isEquippedItem;

		[Token(Token = "0x4004E95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal EquipmentSlot equipSlot;

		[Token(Token = "0x4004E96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int selectedChangeOptionIndex;

		[Token(Token = "0x4004E97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal List<int> prevOptionList;

		[Token(Token = "0x4004E98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal Action closeCallback;

		[Token(Token = "0x4004E99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal XWidget_OptionChange _003C_003Ef__this;

		[Token(Token = "0x6006EED")]
		[Address(RVA = "0x1305DB4", Offset = "0x1305DB4", VA = "0x1305DB4")]
		public _003CSendChangeOption_003Ec__AnonStorey216()
		{
		}

		[Token(Token = "0x6006EEE")]
		[Address(RVA = "0x1306E14", Offset = "0x1306E14", VA = "0x1306E14")]
		internal void _003C_003Em__428(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x2000EDD")]
	private sealed class _003CBuildDirection_003Ec__AnonStorey217
	{
		[Token(Token = "0x4004E9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XWidget_Selectable_Label label;

		[Token(Token = "0x4004E9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XWidget_NGUITween tween;

		[Token(Token = "0x6006EEF")]
		[Address(RVA = "0x13067B8", Offset = "0x13067B8", VA = "0x13067B8")]
		public _003CBuildDirection_003Ec__AnonStorey217()
		{
		}

		[Token(Token = "0x6006EF0")]
		[Address(RVA = "0x1306C04", Offset = "0x1306C04", VA = "0x1306C04")]
		internal void _003C_003Em__42D()
		{
		}

		[Token(Token = "0x6006EF1")]
		[Address(RVA = "0x1306D08", Offset = "0x1306D08", VA = "0x1306D08")]
		internal void _003C_003Em__42E()
		{
		}
	}

	[Token(Token = "0x4004E74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public UILabel lblGoldPrice;

	[Token(Token = "0x4004E75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public UILabel lblStoneCount;

	[Token(Token = "0x4004E76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public UI2DSprite sprStoneIcon;

	[Token(Token = "0x4004E77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public XWidget_Builder builderRandomOption;

	[Token(Token = "0x4004E78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private XWidget_Selectable_Label[] randomOptionLabels;

	[Token(Token = "0x4004E79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public XWidget_Builder builderChangableOptionList;

	[Token(Token = "0x4004E7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public XWidget_Builder builderChangeWaitList;

	[Token(Token = "0x4004E7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private List<XWidget_Selectable_Label> randOpWaitLabels;

	[Token(Token = "0x4004E7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public XWidget_Selectable_Label randSelectOpLabel;

	[Token(Token = "0x4004E7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public XWidget_Button btnConfirm;

	[Token(Token = "0x4004E7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public Transform optionChangeItemTransform;

	[Token(Token = "0x4004E7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private XWidget_TweenPosItemIcon m_targetItemIcon;

	[Token(Token = "0x4004E80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private int m_selectChangeOptionIndex;

	[Token(Token = "0x4004E81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private int m_selectChangeOptionWaitListIndex;

	[Token(Token = "0x4004E82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private string UIOptionChangeSoundKey;

	[Token(Token = "0x4004E83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Action<XItem, int, List<int>> m_onComplete;

	[Token(Token = "0x4004E84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private Action<XItem, int, int> m_onCheck;

	[Token(Token = "0x4004E85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private Action m_onClose;

	[Token(Token = "0x4004E86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private bool isWaitListExist;

	[Token(Token = "0x4004E87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private XItem m_changeWaitListItem;

	[Token(Token = "0x4004E88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private List<int> m_displayOptionWiatIDLists;

	[Token(Token = "0x4004E89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public GameObject goEnhanceEffect;

	[Token(Token = "0x4004E8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	public TweenAlpha whiteBlinkTween;

	[Token(Token = "0x4004E8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public float delayWhiteBlinkShow;

	[Token(Token = "0x4004E8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	public float delayFirstOptionShow;

	[Token(Token = "0x4004E8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public float delayOneOpShowTime;

	[Token(Token = "0x4004E8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public float delayOneOpEffectShowTime;

	[Token(Token = "0x4004E8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private UIDirector m_direction;

	[Token(Token = "0x4004E90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private bool isDirectionProcessing;

	[Token(Token = "0x4004E91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private XWidget_BetterOptionPopup m_betterOptionPopup;

	[Token(Token = "0x4004E92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private bool isSended;

	[Token(Token = "0x17000E1E")]
	public XWidget_BetterOptionPopup BetterOptionPopup
	{
		[Token(Token = "0x6006ECB")]
		[Address(RVA = "0x1301DB4", Offset = "0x1301DB4", VA = "0x1301DB4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006ECA")]
	[Address(RVA = "0x1301C98", Offset = "0x1301C98", VA = "0x1301C98")]
	public XWidget_OptionChange()
	{
	}

	[Token(Token = "0x6006ECC")]
	[Address(RVA = "0x1301EBC", Offset = "0x1301EBC", VA = "0x1301EBC")]
	public void Awake()
	{
	}

	[Token(Token = "0x6006ECD")]
	[Address(RVA = "0x1302050", Offset = "0x1302050", VA = "0x1302050")]
	public void Show(XItem transcendItem, Action<XItem, int, int> onCheck, Action<XItem, int, List<int>> onComplete, Action onClose, [Optional] List<int> changeWaitList, int selectChangeOptionIndex = -1)
	{
	}

	[Token(Token = "0x6006ECE")]
	[Address(RVA = "0x13041D4", Offset = "0x13041D4", VA = "0x13041D4")]
	private void RepositionAll()
	{
	}

	[Token(Token = "0x6006ECF")]
	[Address(RVA = "0x13025E0", Offset = "0x13025E0", VA = "0x13025E0")]
	private void BuildOption(XItem transcendItem, int selectChangeOptionWaitIndex)
	{
	}

	[Token(Token = "0x6006ED0")]
	[Address(RVA = "0x1302A00", Offset = "0x1302A00", VA = "0x1302A00")]
	private void BuildChangableRandomOptionList(XItem targetItem)
	{
	}

	[Token(Token = "0x6006ED1")]
	[Address(RVA = "0x1302F34", Offset = "0x1302F34", VA = "0x1302F34")]
	private void BuildChangableWaitList(XItem targetItem, List<int> changeWaitList)
	{
	}

	[Token(Token = "0x6006ED2")]
	[Address(RVA = "0x1304588", Offset = "0x1304588", VA = "0x1304588")]
	private string GetOptionValueString(float value, bool includeRatioString = false)
	{
		return null;
	}

	[Token(Token = "0x6006ED3")]
	[Address(RVA = "0x13048D8", Offset = "0x13048D8", VA = "0x13048D8")]
	private void GetCostCondition(out int needGold, out int needStone, out bool isFulfilGold, out bool isFulfilStone)
	{
		isFulfilGold = default;
		isFulfilStone = default;
		needGold = default;
		needStone = default;
	}

	[Token(Token = "0x6006ED4")]
	[Address(RVA = "0x13038CC", Offset = "0x13038CC", VA = "0x13038CC")]
	private void BuildCost()
	{
	}

	[Token(Token = "0x6006ED5")]
	[Address(RVA = "0x1304A98", Offset = "0x1304A98", VA = "0x1304A98")]
	private Currency GetStoneCurrencyType()
	{
		return default(Currency);
	}

	[Token(Token = "0x6006ED6")]
	[Address(RVA = "0x1304AD4", Offset = "0x1304AD4", VA = "0x1304AD4")]
	public void ChangeSelectChangeOptionIndex(bool isSelect, int index)
	{
	}

	[Token(Token = "0x6006ED7")]
	[Address(RVA = "0x1304BAC", Offset = "0x1304BAC", VA = "0x1304BAC")]
	public void ChangeSelectChangeOptionWaitListIndex(bool isSelect, int index)
	{
	}

	[Token(Token = "0x6006ED8")]
	[Address(RVA = "0x1303CCC", Offset = "0x1303CCC", VA = "0x1303CCC")]
	private void BuildBtnConfirm()
	{
	}

	[Token(Token = "0x6006ED9")]
	[Address(RVA = "0x1304D18", Offset = "0x1304D18", VA = "0x1304D18")]
	private bool HasWaitList()
	{
		return default(bool);
	}

	[Token(Token = "0x6006EDA")]
	[Address(RVA = "0x1304E48", Offset = "0x1304E48", VA = "0x1304E48")]
	public void OnClick_WarningPopup()
	{
	}

	[Token(Token = "0x6006EDB")]
	[Address(RVA = "0x13050BC", Offset = "0x13050BC", VA = "0x13050BC")]
	public void OnClick_Confirm()
	{
	}

	[Token(Token = "0x6006EDC")]
	[Address(RVA = "0x13057FC", Offset = "0x13057FC", VA = "0x13057FC")]
	public void OnSendChangeOptionPacket()
	{
	}

	[Token(Token = "0x6006EDD")]
	[Address(RVA = "0x130532C", Offset = "0x130532C", VA = "0x130532C")]
	public void ShowOptionSelectCheckConfirmPopup()
	{
	}

	[Token(Token = "0x6006EDE")]
	[Address(RVA = "0x1304700", Offset = "0x1304700", VA = "0x1304700")]
	private int GetCurrentChangeSelectRandonInfoID()
	{
		return default(int);
	}

	[Token(Token = "0x6006EDF")]
	[Address(RVA = "0x1305828", Offset = "0x1305828", VA = "0x1305828")]
	private void SendChangeOption(int selectedChangeOptionIndex, int selectChangeOptionWaitListIndex, [Optional][DefaultParameterValue(false)] bool isClose, [Optional] Action closeCallback)
	{
	}

	[Token(Token = "0x6006EE0")]
	[Address(RVA = "0x130540C", Offset = "0x130540C", VA = "0x130540C")]
	private void SendGetChangeOptionWaitList(int selectedChangeOptionIndex)
	{
	}

	[Token(Token = "0x6006EE1")]
	[Address(RVA = "0x1305DBC", Offset = "0x1305DBC", VA = "0x1305DBC", Slot = "18")]
	public override void OnClick_Close()
	{
	}

	[Token(Token = "0x6006EE2")]
	[Address(RVA = "0x1305E00", Offset = "0x1305E00", VA = "0x1305E00", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6006EE3")]
	[Address(RVA = "0x1306114", Offset = "0x1306114", VA = "0x1306114")]
	private void BaseHide()
	{
	}

	[Token(Token = "0x6006EE4")]
	[Address(RVA = "0x1302358", Offset = "0x1302358", VA = "0x1302358")]
	private void DirectionItemReset()
	{
	}

	[Token(Token = "0x6006EE5")]
	[Address(RVA = "0x130618C", Offset = "0x130618C", VA = "0x130618C")]
	private void BuildDirection()
	{
	}

	[Token(Token = "0x6006EE6")]
	[Address(RVA = "0x13067C0", Offset = "0x13067C0", VA = "0x13067C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6006EE7")]
	[Address(RVA = "0x13067EC", Offset = "0x13067EC", VA = "0x13067EC")]
	private void _003COnClick_Confirm_003Em__427()
	{
	}

	[Token(Token = "0x6006EE8")]
	[Address(RVA = "0x13067F4", Offset = "0x13067F4", VA = "0x13067F4")]
	private void _003CSendGetChangeOptionWaitList_003Em__429(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}

	[Token(Token = "0x6006EE9")]
	[Address(RVA = "0x130697C", Offset = "0x130697C", VA = "0x130697C")]
	private void _003CHide_003Em__42A()
	{
	}

	[Token(Token = "0x6006EEA")]
	[Address(RVA = "0x1306A44", Offset = "0x1306A44", VA = "0x1306A44")]
	private void _003CBuildDirection_003Em__42B()
	{
	}

	[Token(Token = "0x6006EEB")]
	[Address(RVA = "0x1306A90", Offset = "0x1306A90", VA = "0x1306A90")]
	private void _003CBuildDirection_003Em__42C()
	{
	}

	[Token(Token = "0x6006EEC")]
	[Address(RVA = "0x1306AFC", Offset = "0x1306AFC", VA = "0x1306AFC")]
	private void _003CBuildDirection_003Em__42F()
	{
	}
}
