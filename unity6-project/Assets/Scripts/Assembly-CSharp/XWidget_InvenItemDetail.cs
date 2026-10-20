using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000ECE")]
public class XWidget_InvenItemDetail : XWidget_ItemDetail
{
	[Token(Token = "0x2000ECF")]
	private sealed class _003CHideSec_003Ec__IteratorAC : IDisposable
	{
		[Token(Token = "0x4004E18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal float _003CelaspedTime_003E__0;

		[Token(Token = "0x4004E19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal float sec;

		[Token(Token = "0x4004E1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int _0024PC;

		[Token(Token = "0x4004E1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x4004E1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal float _003C_0024_003Esec;

		[Token(Token = "0x4004E1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal XWidget_InvenItemDetail _003C_003Ef__this;

		[Token(Token = "0x17000E17")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6006E85")]
			[Address(RVA = "0x1448DCC", Offset = "0x1448DCC", VA = "0x1448DCC", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000E18")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006E86")]
			[Address(RVA = "0x1448DD4", Offset = "0x1448DD4", VA = "0x1448DD4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6006E84")]
		[Address(RVA = "0x1448250", Offset = "0x1448250", VA = "0x1448250")]
		public _003CHideSec_003Ec__IteratorAC()
		{
		}

		[Token(Token = "0x6006E85")]
		[Address(RVA = "0x1448DCC", Offset = "0x1448DCC", VA = "0x1448DCC", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6006E86")]
		[Address(RVA = "0x1448DD4", Offset = "0x1448DD4", VA = "0x1448DD4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6006E87")]
		[Address(RVA = "0x1448DDC", Offset = "0x1448DDC", VA = "0x1448DDC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006E88")]
		[Address(RVA = "0x1448E98", Offset = "0x1448E98", VA = "0x1448E98", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6006E89")]
		[Address(RVA = "0x1448EA4", Offset = "0x1448EA4", VA = "0x1448EA4", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000ED0")]
	private sealed class _003CBuildCoolTimeOnSec_003Ec__IteratorAD : IDisposable
	{
		[Token(Token = "0x4004E1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4004E1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4004E20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XWidget_InvenItemDetail _003C_003Ef__this;

		[Token(Token = "0x17000E19")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6006E8B")]
			[Address(RVA = "0x1448AE8", Offset = "0x1448AE8", VA = "0x1448AE8", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000E1A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006E8C")]
			[Address(RVA = "0x1448AF0", Offset = "0x1448AF0", VA = "0x1448AF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6006E8A")]
		[Address(RVA = "0x1448ABC", Offset = "0x1448ABC", VA = "0x1448ABC")]
		public _003CBuildCoolTimeOnSec_003Ec__IteratorAD()
		{
		}

		[Token(Token = "0x6006E8B")]
		[Address(RVA = "0x1448AE8", Offset = "0x1448AE8", VA = "0x1448AE8", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6006E8C")]
		[Address(RVA = "0x1448AF0", Offset = "0x1448AF0", VA = "0x1448AF0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6006E8D")]
		[Address(RVA = "0x1448AF8", Offset = "0x1448AF8", VA = "0x1448AF8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006E8E")]
		[Address(RVA = "0x1448C14", Offset = "0x1448C14", VA = "0x1448C14", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6006E8F")]
		[Address(RVA = "0x1448C20", Offset = "0x1448C20", VA = "0x1448C20", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000ED1")]
	private sealed class _003CSetButtonLink_003Ec__AnonStorey210
	{
		[Token(Token = "0x4004E21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal bool isEquipedItem;

		[Token(Token = "0x4004E22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal string strTranscend;

		[Token(Token = "0x4004E23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal string strPromotion;

		[Token(Token = "0x4004E24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal string strFusion;

		[Token(Token = "0x4004E25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal string strSell;

		[Token(Token = "0x4004E26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal bool disable;

		[Token(Token = "0x4004E27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal XWidget_InvenItemDetail _003C_003Ef__this;

		[Token(Token = "0x6006E90")]
		[Address(RVA = "0x1444E24", Offset = "0x1444E24", VA = "0x1444E24")]
		public _003CSetButtonLink_003Ec__AnonStorey210()
		{
		}

		[Token(Token = "0x6006E91")]
		[Address(RVA = "0x1448F38", Offset = "0x1448F38", VA = "0x1448F38")]
		internal void _003C_003Em__41B()
		{
		}

		[Token(Token = "0x6006E92")]
		[Address(RVA = "0x1449034", Offset = "0x1449034", VA = "0x1449034")]
		internal void _003C_003Em__41C()
		{
		}

		[Token(Token = "0x6006E93")]
		[Address(RVA = "0x1449130", Offset = "0x1449130", VA = "0x1449130")]
		internal void _003C_003Em__41D()
		{
		}

		[Token(Token = "0x6006E94")]
		[Address(RVA = "0x144922C", Offset = "0x144922C", VA = "0x144922C")]
		internal void _003C_003Em__41E()
		{
		}

		[Token(Token = "0x6006E95")]
		[Address(RVA = "0x144931C", Offset = "0x144931C", VA = "0x144931C")]
		internal void _003C_003Em__41F()
		{
		}
	}

	[Token(Token = "0x2000ED2")]
	private sealed class _003CShowUnEquipPopup_003Ec__AnonStorey211
	{
		[Token(Token = "0x4004E28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action on_Confirm;

		[Token(Token = "0x4004E29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XWidget_InvenItemDetail _003C_003Ef__this;

		[Token(Token = "0x6006E96")]
		[Address(RVA = "0x1445900", Offset = "0x1445900", VA = "0x1445900")]
		public _003CShowUnEquipPopup_003Ec__AnonStorey211()
		{
		}

		[Token(Token = "0x6006E97")]
		[Address(RVA = "0x14493C0", Offset = "0x14493C0", VA = "0x14493C0")]
		internal void _003C_003Em__420()
		{
		}
	}

	[Token(Token = "0x2000ED3")]
	private sealed class _003CEquip_003Ec__AnonStorey212
	{
		[Token(Token = "0x4004E2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XItem item;

		[Token(Token = "0x4004E2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal EquipmentSlot slot;

		[Token(Token = "0x4004E2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XWidget_InvenItemDetail _003C_003Ef__this;

		[Token(Token = "0x6006E98")]
		[Address(RVA = "0x1445E24", Offset = "0x1445E24", VA = "0x1445E24")]
		public _003CEquip_003Ec__AnonStorey212()
		{
		}

		[Token(Token = "0x6006E99")]
		[Address(RVA = "0x1448CB4", Offset = "0x1448CB4", VA = "0x1448CB4")]
		internal void _003C_003Em__421(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x2000ED4")]
	private sealed class _003CUnequip_003Ec__AnonStorey213
	{
		[Token(Token = "0x4004E2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action callBack;

		[Token(Token = "0x4004E2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XWidget_InvenItemDetail _003C_003Ef__this;

		[Token(Token = "0x6006E9A")]
		[Address(RVA = "0x14461F0", Offset = "0x14461F0", VA = "0x14461F0")]
		public _003CUnequip_003Ec__AnonStorey213()
		{
		}

		[Token(Token = "0x6006E9B")]
		[Address(RVA = "0x14493F0", Offset = "0x14493F0", VA = "0x14493F0")]
		internal void _003C_003Em__422(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x4004DEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string PATH_ITEMDETAILPOPUP;

	[Token(Token = "0x4004DF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public UITable equipStatTableRoot;

	[Token(Token = "0x4004DF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject goEquipmemtRoot;

	[Token(Token = "0x4004DF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public GameObject goEtcRoot;

	[Token(Token = "0x4004DF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public XWidget_TweenPosItemIcon equipItemIcon;

	[Token(Token = "0x4004DF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public XWidget_TweenPosItemIcon etcItemIcon;

	[Token(Token = "0x4004DF5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public XWidget_Builder builderMajorStat;

	[Token(Token = "0x4004DF6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public UIGrid btnEquipmentGrid;

	[Token(Token = "0x4004DF7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public UIGrid btnEtcGrid;

	[Token(Token = "0x4004DF8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public XWidget_Button btnEquipAndRelease;

	[Token(Token = "0x4004DF9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public XWidget_Button btnTranscendence;

	[Token(Token = "0x4004DFA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public XWidget_Button btnPromotion;

	[Token(Token = "0x4004DFB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public XWidget_Button btnFusion;

	[Token(Token = "0x4004DFC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public XWidget_Button btnRefine;

	[Token(Token = "0x4004DFD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public XWidget_Button btnOptionChange;

	[Token(Token = "0x4004DFE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public XWidget_Button btnEquipmentSell;

	[Token(Token = "0x4004DFF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public XWidget_Button btnEtcSell;

	[Token(Token = "0x4004E00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public XWidget_Button btnEtcUse;

	[Token(Token = "0x4004E01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public GameObject btnRoot;

	[Token(Token = "0x4004E02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public UILabel lblEquipmentGrade;

	[Token(Token = "0x4004E03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Action m_onRefresh;

	[Token(Token = "0x4004E04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public Action<EquipmentSlot> m_onEquip;

	[Token(Token = "0x4004E05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Action<XItem> m_onUnequipCallback;

	[Token(Token = "0x4004E06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private XWidget_Inventory m_inventory;

	[Token(Token = "0x4004E07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private string m_itemIID;

	[Token(Token = "0x4004E08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private string m_charUID;

	[Token(Token = "0x4004E09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private EquipmentSlot m_equipSlot;

	[Token(Token = "0x4004E0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	private int radomOptionCnt;

	[Token(Token = "0x4004E0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private int itemMaxLv;

	[Token(Token = "0x4004E0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private bool isEquipmentable;

	[Token(Token = "0x4004E0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x125")]
	private bool isItemLvMax;

	[Token(Token = "0x4004E0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x126")]
	private bool isTranscendOptionChangeable;

	[Token(Token = "0x4004E0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x127")]
	private bool isTranscendable;

	[Token(Token = "0x4004E10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private bool isPromotionable;

	[Token(Token = "0x4004E11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
	private bool isFusionable;

	[Token(Token = "0x4004E12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12A")]
	private bool isRefineable;

	[Token(Token = "0x4004E13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12B")]
	private bool isAcientRarity;

	[Token(Token = "0x4004E14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private bool isCoolTimeNotification;

	[Token(Token = "0x4004E15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private float warnningDuration;

	[Token(Token = "0x4004E16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	public XTutorialObjContainer pnlTutorial;

	[Token(Token = "0x4004E17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private bool m_isProcessing;

	[Token(Token = "0x6006E53")]
	[Address(RVA = "0x143FEB8", Offset = "0x143FEB8", VA = "0x143FEB8")]
	public XWidget_InvenItemDetail()
	{
	}

	[Token(Token = "0x6006E55")]
	[Address(RVA = "0x143FF54", Offset = "0x143FF54", VA = "0x143FF54")]
	public static XWidget_InvenItemDetail CreateItemDetailPopup(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6006E56")]
	[Address(RVA = "0x14400F4", Offset = "0x14400F4", VA = "0x14400F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006E57")]
	[Address(RVA = "0x1440104", Offset = "0x1440104", VA = "0x1440104")]
	public void SetUnEquipAction(Action<XItem> unequipCallBack)
	{
	}

	[Token(Token = "0x6006E58")]
	[Address(RVA = "0x144010C", Offset = "0x144010C", VA = "0x144010C")]
	public void Build(XItem item, XWidget_Inventory inventory, Action onRefresh, Action<EquipmentSlot> onEquip)
	{
	}

	[Token(Token = "0x6006E59")]
	[Address(RVA = "0x1440664", Offset = "0x1440664", VA = "0x1440664")]
	public void Show(XItem item, XWidget_Inventory inventory)
	{
	}

	[Token(Token = "0x6006E5A")]
	[Address(RVA = "0x14401F0", Offset = "0x14401F0", VA = "0x14401F0")]
	private new void Build(XItem item)
	{
	}

	[Token(Token = "0x6006E5B")]
	[Address(RVA = "0x144081C", Offset = "0x144081C", VA = "0x144081C")]
	public void BuildRoot(XItem item)
	{
	}

	[Token(Token = "0x6006E5C")]
	[Address(RVA = "0x14432F4", Offset = "0x14432F4", VA = "0x14432F4", Slot = "19")]
	protected override void BuildGrade(CSItemInfo itemInfo)
	{
	}

	[Token(Token = "0x6006E5D")]
	[Address(RVA = "0x14435F4", Offset = "0x14435F4", VA = "0x14435F4", Slot = "23")]
	protected override void BuildButtons(XItem item)
	{
	}

	[Token(Token = "0x6006E5E")]
	[Address(RVA = "0x14435F8", Offset = "0x14435F8", VA = "0x14435F8", Slot = "21")]
	protected override void BuildStat(XItem item)
	{
	}

	[Token(Token = "0x6006E5F")]
	[Address(RVA = "0x1440438", Offset = "0x1440438", VA = "0x1440438")]
	private void RepositionStat()
	{
	}

	[Token(Token = "0x6006E60")]
	[Address(RVA = "0x1443C80", Offset = "0x1443C80", VA = "0x1443C80")]
	private void BuildStatLabel(XCharStatusDisplay.StatInfo statInfo, XWidget_LabelTriple statLabel)
	{
	}

	[Token(Token = "0x6006E61")]
	[Address(RVA = "0x1441270", Offset = "0x1441270", VA = "0x1441270")]
	public void BuildItemCheckBoolean(XItem item, bool characterActorIsNotOwned, bool petActorIsNotOwned)
	{
	}

	[Token(Token = "0x6006E62")]
	[Address(RVA = "0x1442F8C", Offset = "0x1442F8C", VA = "0x1442F8C")]
	public void BuildButton(XItem item)
	{
	}

	[Token(Token = "0x6006E63")]
	[Address(RVA = "0x1444AE4", Offset = "0x1444AE4", VA = "0x1444AE4")]
	private void ButtonActiveSetting(XItem item)
	{
	}

	[Token(Token = "0x6006E64")]
	[Address(RVA = "0x144427C", Offset = "0x144427C", VA = "0x144427C")]
	private bool IsEtcUseable()
	{
		return default(bool);
	}

	[Token(Token = "0x6006E65")]
	[Address(RVA = "0x1444C34", Offset = "0x1444C34", VA = "0x1444C34")]
	private bool IsEtcUseableItemType()
	{
		return default(bool);
	}

	[Token(Token = "0x6006E66")]
	[Address(RVA = "0x1444CE0", Offset = "0x1444CE0", VA = "0x1444CE0")]
	private string GetItemEquippedCharacterUID()
	{
		return null;
	}

	[Token(Token = "0x6006E67")]
	[Address(RVA = "0x14442C0", Offset = "0x14442C0", VA = "0x14442C0")]
	private void SetButtonLink(XItem item)
	{
	}

	[Token(Token = "0x6006E68")]
	[Address(RVA = "0x14450A8", Offset = "0x14450A8", VA = "0x14450A8")]
	private bool CanSellSoulStone(CSItemInfo itemInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6006E69")]
	[Address(RVA = "0x1445240", Offset = "0x1445240", VA = "0x1445240")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6006E6A")]
	[Address(RVA = "0x1445488", Offset = "0x1445488", VA = "0x1445488")]
	public void Refresh(XItem item)
	{
	}

	[Token(Token = "0x6006E6B")]
	[Address(RVA = "0x1444E2C", Offset = "0x1444E2C", VA = "0x1444E2C")]
	private bool GetIsEquipedItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6006E6C")]
	[Address(RVA = "0x14454B0", Offset = "0x14454B0", VA = "0x14454B0")]
	public void SetUIStackZeroItem()
	{
	}

	[Token(Token = "0x6006E6D")]
	[Address(RVA = "0x1445690", Offset = "0x1445690", VA = "0x1445690")]
	private void ShowUnEquipPopup(string modeText, Action on_Confirm)
	{
	}

	[Token(Token = "0x6006E6E")]
	[Address(RVA = "0x1445908", Offset = "0x1445908", VA = "0x1445908")]
	private void Equip()
	{
	}

	[Token(Token = "0x6006E6F")]
	[Address(RVA = "0x1445E2C", Offset = "0x1445E2C", VA = "0x1445E2C")]
	private void Unequip([Optional] Action callBack)
	{
	}

	[Token(Token = "0x6006E70")]
	[Address(RVA = "0x14461F8", Offset = "0x14461F8", VA = "0x14461F8")]
	private void ShowWarnningMessage(string localeKey)
	{
	}

	[Token(Token = "0x6006E71")]
	[Address(RVA = "0x1446330", Offset = "0x1446330", VA = "0x1446330")]
	public void OnClick_EquipAndRelease()
	{
	}

	[Token(Token = "0x6006E72")]
	[Address(RVA = "0x1446364", Offset = "0x1446364", VA = "0x1446364")]
	public void OnClick_Transcendence()
	{
	}

	[Token(Token = "0x6006E73")]
	[Address(RVA = "0x1446774", Offset = "0x1446774", VA = "0x1446774")]
	public void OnClick_TranscendenceOption()
	{
	}

	[Token(Token = "0x6006E74")]
	[Address(RVA = "0x1446B6C", Offset = "0x1446B6C", VA = "0x1446B6C")]
	public void OnClick_Promotion()
	{
	}

	[Token(Token = "0x6006E75")]
	[Address(RVA = "0x1447018", Offset = "0x1447018", VA = "0x1447018")]
	public void OnClick_Refine()
	{
	}

	[Token(Token = "0x6006E76")]
	[Address(RVA = "0x1447444", Offset = "0x1447444", VA = "0x1447444")]
	public void OnClick_Fusion()
	{
	}

	[Token(Token = "0x6006E77")]
	[Address(RVA = "0x14478BC", Offset = "0x14478BC", VA = "0x14478BC")]
	public void OnClick_Sell()
	{
	}

	[Token(Token = "0x6006E78")]
	[Address(RVA = "0x1447AAC", Offset = "0x1447AAC", VA = "0x1447AAC")]
	public void OnClick_Use()
	{
	}

	[Token(Token = "0x6006E79")]
	[Address(RVA = "0x144802C", Offset = "0x144802C", VA = "0x144802C")]
	public void OnClick_Use_Disable()
	{
	}

	[Token(Token = "0x6006E7A")]
	[Address(RVA = "0x1448178", Offset = "0x1448178", VA = "0x1448178")]
	public void HideInSec(float sec)
	{
	}

	[Token(Token = "0x6006E7B")]
	[Address(RVA = "0x144819C", Offset = "0x144819C", VA = "0x144819C")]
	[DebuggerHidden]
	private IEnumerator HideSec(float sec)
	{
		return null;
	}

	[Token(Token = "0x6006E7C")]
	[Address(RVA = "0x1440780", Offset = "0x1440780", VA = "0x1440780")]
	private void ClearTutorialObject()
	{
	}

	[Token(Token = "0x6006E7D")]
	[Address(RVA = "0x1448258", Offset = "0x1448258", VA = "0x1448258")]
	private void SetTutorialObject()
	{
	}

	[Token(Token = "0x6006E7E")]
	[Address(RVA = "0x1448370", Offset = "0x1448370", VA = "0x1448370")]
	public new void OnClick_Close()
	{
	}

	[Token(Token = "0x6006E7F")]
	[Address(RVA = "0x1448508", Offset = "0x1448508", VA = "0x1448508")]
	protected double BuildCoolTime()
	{
		return default(double);
	}

	[Token(Token = "0x6006E80")]
	[Address(RVA = "0x14432C4", Offset = "0x14432C4", VA = "0x14432C4")]
	public void CalculateItemCoolTime()
	{
	}

	[Token(Token = "0x6006E81")]
	[Address(RVA = "0x1448A18", Offset = "0x1448A18", VA = "0x1448A18")]
	[DebuggerHidden]
	private IEnumerator BuildCoolTimeOnSec()
	{
		return null;
	}

	[Token(Token = "0x6006E82")]
	[Address(RVA = "0x1448AC4", Offset = "0x1448AC4", VA = "0x1448AC4")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6006E83")]
	[Address(RVA = "0x1448ACC", Offset = "0x1448ACC", VA = "0x1448ACC")]
	private void _003CShow_003Em__41A()
	{
	}
}
