using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F37")]
public class XListView_InvenItem : XUIListView
{
	[Token(Token = "0x2000F38")]
	protected abstract class XUIInvenListData
	{
		protected XUIInvenListData()
		{
		}

		[Token(Token = "0x2000F39")]
		protected class InvenComparer : IComparer<XItem>
		{
			[Token(Token = "0x6007158")]
			[Address(RVA = "0x1E10E3C", Offset = "0x1E10E3C", VA = "0x1E10E3C")]
			public InvenComparer()
			{
			}

			[Token(Token = "0x6007159")]
			[Address(RVA = "0x1E11F58", Offset = "0x1E11F58", VA = "0x1E11F58", Slot = "4")]
			public int Compare(XItem left, XItem right)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000F3A")]
		private sealed class _003CFilterItemOnInventoryMode_003Ec__AnonStorey22B
		{
			[Token(Token = "0x400503E")]
			[FieldOffset(Offset = "0x8")]
			internal string refineTargetItemIID;

			[Token(Token = "0x600715A")]
			[Address(RVA = "0x1E117D8", Offset = "0x1E117D8", VA = "0x1E117D8")]
			public _003CFilterItemOnInventoryMode_003Ec__AnonStorey22B()
			{
			}

			[Token(Token = "0x600715B")]
			[Address(RVA = "0x1E11C84", Offset = "0x1E11C84", VA = "0x1E11C84")]
			internal bool _003C_003Em__47A(XItem x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000F3B")]
		private sealed class _003CFilterItemOnInventoryMode_003Ec__AnonStorey22C
		{
			[Token(Token = "0x400503F")]
			[FieldOffset(Offset = "0x8")]
			internal int needLv;

			[Token(Token = "0x600715C")]
			[Address(RVA = "0x1E117E0", Offset = "0x1E117E0", VA = "0x1E117E0")]
			public _003CFilterItemOnInventoryMode_003Ec__AnonStorey22C()
			{
			}

			[Token(Token = "0x600715D")]
			[Address(RVA = "0x1E11DBC", Offset = "0x1E11DBC", VA = "0x1E11DBC")]
			internal bool _003C_003Em__47E(XItem x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000F3C")]
		private sealed class _003CFilterItemOnInventoryMode_003Ec__AnonStorey22D
		{
			[Token(Token = "0x4005040")]
			[FieldOffset(Offset = "0x8")]
			internal int transcend1Lv;

			[Token(Token = "0x4005041")]
			[FieldOffset(Offset = "0xC")]
			internal int transcend2Lv;

			[Token(Token = "0x600715E")]
			[Address(RVA = "0x1E117E8", Offset = "0x1E117E8", VA = "0x1E117E8")]
			public _003CFilterItemOnInventoryMode_003Ec__AnonStorey22D()
			{
			}

			[Token(Token = "0x600715F")]
			[Address(RVA = "0x1E11E00", Offset = "0x1E11E00", VA = "0x1E11E00")]
			internal bool _003C_003Em__47F(XItem x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4005036")]
		[FieldOffset(Offset = "0x8")]
		protected XListView_InvenItem m_ListView;

		[Token(Token = "0x4005037")]
		[FieldOffset(Offset = "0xC")]
		protected List<XItem> m_mainListData;

		[Token(Token = "0x4005038")]
		[FieldOffset(Offset = "0x10")]
		protected List<XItem> m_subListData;

		[Token(Token = "0x4005039")]
		[FieldOffset(Offset = "0x0")]
		private static Func<XItem, bool> _003C_003Ef__am_0024cache3;

		[Token(Token = "0x400503A")]
		[FieldOffset(Offset = "0x4")]
		private static Func<XItem, bool> _003C_003Ef__am_0024cache4;

		[Token(Token = "0x400503B")]
		[FieldOffset(Offset = "0x8")]
		private static Func<XItem, bool> _003C_003Ef__am_0024cache5;

		[Token(Token = "0x400503C")]
		[FieldOffset(Offset = "0xC")]
		private static Func<XItem, bool> _003C_003Ef__am_0024cache6;

		[Token(Token = "0x400503D")]
		[FieldOffset(Offset = "0x10")]
		private static Func<XItem, bool> _003C_003Ef__am_0024cache7;

		[Token(Token = "0x17000E6E")]
		public abstract ItemGroupType GroupType
		{
			[Token(Token = "0x600714A")]
			get;
		}

		[Token(Token = "0x17000E6F")]
		public List<XItem> List
		{
			[Token(Token = "0x600714E")]
			[Address(RVA = "0x1E0E0E0", Offset = "0x1E0E0E0", VA = "0x1E0E0E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007148")]
		[Address(RVA = "0x1E0F7E0", Offset = "0x1E0F7E0", VA = "0x1E0F7E0")]
		public XUIInvenListData(XListView_InvenItem listView)
		{
		}

		[Token(Token = "0x6007149")]
		[Address(RVA = "0x1E0E2F0", Offset = "0x1E0E2F0", VA = "0x1E0E2F0")]
		public void InitData(XListView_InvenItem listView)
		{
		}

		[Token(Token = "0x600714B")]
		protected abstract List<XItem> GetList();

		[Token(Token = "0x600714C")]
		protected abstract List<XItem> GetETCSortList(List<XItem> list);

		[Token(Token = "0x600714D")]
		[Address(RVA = "0x1E10DB0", Offset = "0x1E10DB0", VA = "0x1E10DB0", Slot = "7")]
		protected virtual IComparer<XItem> GetComparer()
		{
			return null;
		}

		[Token(Token = "0x600714F")]
		[Address(RVA = "0x1E0E430", Offset = "0x1E0E430", VA = "0x1E0E430")]
		public void FilterItemList(InventoryModeType inventoryModeType)
		{
		}

		[Token(Token = "0x6007150")]
		[Address(RVA = "0x1E0EA5C", Offset = "0x1E0EA5C", VA = "0x1E0EA5C")]
		public void FillEmptySpace()
		{
		}

		[Token(Token = "0x6007151")]
		[Address(RVA = "0x1E0E888", Offset = "0x1E0E888", VA = "0x1E0E888")]
		public int GetIndex(string iid)
		{
			return default(int);
		}

		[Token(Token = "0x6007152")]
		[Address(RVA = "0x1E10E44", Offset = "0x1E10E44", VA = "0x1E10E44", Slot = "8")]
		protected virtual List<XItem> FilterItemOnInventoryMode(List<XItem> originData)
		{
			return null;
		}

		[Token(Token = "0x6007153")]
		[Address(RVA = "0x1E117F0", Offset = "0x1E117F0", VA = "0x1E117F0")]
		private static bool _003CFilterItemOnInventoryMode_003Em__479(XItem x)
		{
			return default(bool);
		}

		[Token(Token = "0x6007154")]
		[Address(RVA = "0x1E11800", Offset = "0x1E11800", VA = "0x1E11800")]
		private static bool _003CFilterItemOnInventoryMode_003Em__47B(XItem x)
		{
			return default(bool);
		}

		[Token(Token = "0x6007155")]
		[Address(RVA = "0x1E119E0", Offset = "0x1E119E0", VA = "0x1E119E0")]
		private static bool _003CFilterItemOnInventoryMode_003Em__47C(XItem x)
		{
			return default(bool);
		}

		[Token(Token = "0x6007156")]
		[Address(RVA = "0x1E11BC0", Offset = "0x1E11BC0", VA = "0x1E11BC0")]
		private static bool _003CFilterItemOnInventoryMode_003Em__47D(XItem x)
		{
			return default(bool);
		}

		[Token(Token = "0x6007157")]
		[Address(RVA = "0x1E11C38", Offset = "0x1E11C38", VA = "0x1E11C38")]
		private static bool _003CFilterItemOnInventoryMode_003Em__480(XItem x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000F3D")]
	protected class XUIInvenList_All : XUIInvenListData
	{
		[Token(Token = "0x4005042")]
		[FieldOffset(Offset = "0x0")]
		private static Func<XItem, bool> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x17000E70")]
		public override ItemGroupType GroupType
		{
			[Token(Token = "0x6007161")]
			[Address(RVA = "0x1E0FAC0", Offset = "0x1E0FAC0", VA = "0x1E0FAC0", Slot = "4")]
			get
			{
				return default(ItemGroupType);
			}
		}

		[Token(Token = "0x6007160")]
		[Address(RVA = "0x1E0E798", Offset = "0x1E0E798", VA = "0x1E0E798")]
		public XUIInvenList_All(XListView_InvenItem listView)
		{
		}

		[Token(Token = "0x6007162")]
		[Address(RVA = "0x1E0FAC8", Offset = "0x1E0FAC8", VA = "0x1E0FAC8", Slot = "5")]
		protected override List<XItem> GetList()
		{
			return null;
		}

		[Token(Token = "0x6007163")]
		[Address(RVA = "0x1E0FC78", Offset = "0x1E0FC78", VA = "0x1E0FC78", Slot = "6")]
		protected override List<XItem> GetETCSortList(List<XItem> list)
		{
			return null;
		}

		[Token(Token = "0x6007164")]
		[Address(RVA = "0x1E0FC80", Offset = "0x1E0FC80", VA = "0x1E0FC80")]
		private static bool _003CGetList_003Em__481(XItem x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000F3E")]
	protected class XUIInvenList_Weapon : XUIInvenListData
	{
		[Token(Token = "0x4005043")]
		[FieldOffset(Offset = "0x0")]
		private static Func<XItem, bool> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x17000E71")]
		public override ItemGroupType GroupType
		{
			[Token(Token = "0x6007166")]
			[Address(RVA = "0x1E10B7C", Offset = "0x1E10B7C", VA = "0x1E10B7C", Slot = "4")]
			get
			{
				return default(ItemGroupType);
			}
		}

		[Token(Token = "0x6007165")]
		[Address(RVA = "0x1E0E7C0", Offset = "0x1E0E7C0", VA = "0x1E0E7C0")]
		public XUIInvenList_Weapon(XListView_InvenItem listView)
		{
		}

		[Token(Token = "0x6007167")]
		[Address(RVA = "0x1E10B84", Offset = "0x1E10B84", VA = "0x1E10B84", Slot = "5")]
		protected override List<XItem> GetList()
		{
			return null;
		}

		[Token(Token = "0x6007168")]
		[Address(RVA = "0x1E10D34", Offset = "0x1E10D34", VA = "0x1E10D34", Slot = "6")]
		protected override List<XItem> GetETCSortList(List<XItem> list)
		{
			return null;
		}

		[Token(Token = "0x6007169")]
		[Address(RVA = "0x1E10D3C", Offset = "0x1E10D3C", VA = "0x1E10D3C")]
		private static bool _003CGetList_003Em__482(XItem x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000F3F")]
	protected class XUIInvenList_Armor : XUIInvenListData
	{
		[Token(Token = "0x4005044")]
		[FieldOffset(Offset = "0x0")]
		private static Func<XItem, bool> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x17000E72")]
		public override ItemGroupType GroupType
		{
			[Token(Token = "0x600716B")]
			[Address(RVA = "0x1E0FCD0", Offset = "0x1E0FCD0", VA = "0x1E0FCD0", Slot = "4")]
			get
			{
				return default(ItemGroupType);
			}
		}

		[Token(Token = "0x600716A")]
		[Address(RVA = "0x1E0E7E8", Offset = "0x1E0E7E8", VA = "0x1E0E7E8")]
		public XUIInvenList_Armor(XListView_InvenItem listView)
		{
		}

		[Token(Token = "0x600716C")]
		[Address(RVA = "0x1E0FCD8", Offset = "0x1E0FCD8", VA = "0x1E0FCD8", Slot = "5")]
		protected override List<XItem> GetList()
		{
			return null;
		}

		[Token(Token = "0x600716D")]
		[Address(RVA = "0x1E0FE88", Offset = "0x1E0FE88", VA = "0x1E0FE88", Slot = "6")]
		protected override List<XItem> GetETCSortList(List<XItem> list)
		{
			return null;
		}

		[Token(Token = "0x600716E")]
		[Address(RVA = "0x1E0FE90", Offset = "0x1E0FE90", VA = "0x1E0FE90")]
		private static bool _003CGetList_003Em__483(XItem x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000F40")]
	protected class XUIInvenList_Accessory : XUIInvenListData
	{
		[Token(Token = "0x4005045")]
		[FieldOffset(Offset = "0x0")]
		private static Func<XItem, bool> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x17000E73")]
		public override ItemGroupType GroupType
		{
			[Token(Token = "0x6007170")]
			[Address(RVA = "0x1E0F808", Offset = "0x1E0F808", VA = "0x1E0F808", Slot = "4")]
			get
			{
				return default(ItemGroupType);
			}
		}

		[Token(Token = "0x600716F")]
		[Address(RVA = "0x1E0E810", Offset = "0x1E0E810", VA = "0x1E0E810")]
		public XUIInvenList_Accessory(XListView_InvenItem listView)
		{
		}

		[Token(Token = "0x6007171")]
		[Address(RVA = "0x1E0F810", Offset = "0x1E0F810", VA = "0x1E0F810", Slot = "5")]
		protected override List<XItem> GetList()
		{
			return null;
		}

		[Token(Token = "0x6007172")]
		[Address(RVA = "0x1E0F9C0", Offset = "0x1E0F9C0", VA = "0x1E0F9C0", Slot = "6")]
		protected override List<XItem> GetETCSortList(List<XItem> list)
		{
			return null;
		}

		[Token(Token = "0x6007173")]
		[Address(RVA = "0x1E0F9C8", Offset = "0x1E0F9C8", VA = "0x1E0F9C8")]
		private static bool _003CGetList_003Em__484(XItem x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000F41")]
	protected class XUIInvenList_ETC : XUIInvenListData
	{
		[Token(Token = "0x2000F42")]
		private class EquipmentComparer : IComparer<XItem>
		{
			[Token(Token = "0x600717A")]
			[Address(RVA = "0x1E1018C", Offset = "0x1E1018C", VA = "0x1E1018C")]
			public EquipmentComparer()
			{
			}

			[Token(Token = "0x600717B")]
			[Address(RVA = "0x1E104FC", Offset = "0x1E104FC", VA = "0x1E104FC", Slot = "4")]
			public int Compare(XItem left, XItem right)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000F43")]
		private sealed class _003CGetETCSortList_003Ec__AnonStorey22E
		{
			[Token(Token = "0x4005047")]
			[FieldOffset(Offset = "0x8")]
			internal int i;

			[Token(Token = "0x600717C")]
			[Address(RVA = "0x1E10420", Offset = "0x1E10420", VA = "0x1E10420")]
			public _003CGetETCSortList_003Ec__AnonStorey22E()
			{
			}

			[Token(Token = "0x600717D")]
			[Address(RVA = "0x1E104A8", Offset = "0x1E104A8", VA = "0x1E104A8")]
			internal bool _003C_003Em__486(XItem o)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4005046")]
		[FieldOffset(Offset = "0x0")]
		private static Func<XItem, bool> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x17000E74")]
		public override ItemGroupType GroupType
		{
			[Token(Token = "0x6007175")]
			[Address(RVA = "0x1E0FF48", Offset = "0x1E0FF48", VA = "0x1E0FF48", Slot = "4")]
			get
			{
				return default(ItemGroupType);
			}
		}

		[Token(Token = "0x6007174")]
		[Address(RVA = "0x1E0E838", Offset = "0x1E0E838", VA = "0x1E0E838")]
		public XUIInvenList_ETC(XListView_InvenItem listView)
		{
		}

		[Token(Token = "0x6007176")]
		[Address(RVA = "0x1E0FF50", Offset = "0x1E0FF50", VA = "0x1E0FF50", Slot = "5")]
		protected override List<XItem> GetList()
		{
			return null;
		}

		[Token(Token = "0x6007177")]
		[Address(RVA = "0x1E10100", Offset = "0x1E10100", VA = "0x1E10100", Slot = "7")]
		protected override IComparer<XItem> GetComparer()
		{
			return null;
		}

		[Token(Token = "0x6007178")]
		[Address(RVA = "0x1E10194", Offset = "0x1E10194", VA = "0x1E10194", Slot = "6")]
		protected override List<XItem> GetETCSortList(List<XItem> list)
		{
			return null;
		}

		[Token(Token = "0x6007179")]
		[Address(RVA = "0x1E10428", Offset = "0x1E10428", VA = "0x1E10428")]
		private static bool _003CGetList_003Em__485(XItem x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000F44")]
	protected class XUIInvenList_Test : XUIInvenListData
	{
		[Token(Token = "0x2000F45")]
		private class EquipmentComparer : IComparer<XItem>
		{
			[Token(Token = "0x6007183")]
			[Address(RVA = "0x1E10A70", Offset = "0x1E10A70", VA = "0x1E10A70")]
			public EquipmentComparer()
			{
			}

			[Token(Token = "0x6007184")]
			[Address(RVA = "0x1E10A80", Offset = "0x1E10A80", VA = "0x1E10A80", Slot = "4")]
			public int Compare(XItem left, XItem right)
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000E75")]
		public override ItemGroupType GroupType
		{
			[Token(Token = "0x600717F")]
			[Address(RVA = "0x1E106D8", Offset = "0x1E106D8", VA = "0x1E106D8", Slot = "4")]
			get
			{
				return default(ItemGroupType);
			}
		}

		[Token(Token = "0x600717E")]
		[Address(RVA = "0x1E0E860", Offset = "0x1E0E860", VA = "0x1E0E860")]
		public XUIInvenList_Test(XListView_InvenItem listView)
		{
		}

		[Token(Token = "0x6007180")]
		[Address(RVA = "0x1E106E0", Offset = "0x1E106E0", VA = "0x1E106E0", Slot = "5")]
		protected override List<XItem> GetList()
		{
			return null;
		}

		[Token(Token = "0x6007181")]
		[Address(RVA = "0x1E109E4", Offset = "0x1E109E4", VA = "0x1E109E4", Slot = "7")]
		protected override IComparer<XItem> GetComparer()
		{
			return null;
		}

		[Token(Token = "0x6007182")]
		[Address(RVA = "0x1E10A78", Offset = "0x1E10A78", VA = "0x1E10A78", Slot = "6")]
		protected override List<XItem> GetETCSortList(List<XItem> list)
		{
			return null;
		}
	}

	[Token(Token = "0x2000F46")]
	private sealed class _003CChangeMode_003Ec__AnonStorey229
	{
		[Token(Token = "0x4005048")]
		[FieldOffset(Offset = "0x8")]
		internal InventoryModeType inventoryModeType;

		[Token(Token = "0x6007185")]
		[Address(RVA = "0x1E0EFD8", Offset = "0x1E0EFD8", VA = "0x1E0EFD8")]
		public _003CChangeMode_003Ec__AnonStorey229()
		{
		}

		[Token(Token = "0x6007186")]
		[Address(RVA = "0x1E0F6D0", Offset = "0x1E0F6D0", VA = "0x1E0F6D0")]
		internal void _003C_003Em__476(XUIInvenItem invenItem)
		{
		}
	}

	[Token(Token = "0x2000F47")]
	private sealed class _003CGetInvenUIItem_003Ec__AnonStorey22A
	{
		[Token(Token = "0x4005049")]
		[FieldOffset(Offset = "0x8")]
		internal string itemiid;

		[Token(Token = "0x6007187")]
		[Address(RVA = "0x1E0F278", Offset = "0x1E0F278", VA = "0x1E0F278")]
		public _003CGetInvenUIItem_003Ec__AnonStorey22A()
		{
		}

		[Token(Token = "0x6007188")]
		[Address(RVA = "0x1E0F704", Offset = "0x1E0F704", VA = "0x1E0F704")]
		internal bool _003C_003Em__478(XUIInvenItem ui)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400502B")]
	[FieldOffset(Offset = "0x78")]
	private string refineItemAddSound;

	[Token(Token = "0x400502C")]
	[FieldOffset(Offset = "0x7C")]
	private string refineItemRemoveSound;

	[Token(Token = "0x400502D")]
	[FieldOffset(Offset = "0x80")]
	public int numberOnALine;

	[Token(Token = "0x400502E")]
	[FieldOffset(Offset = "0x84")]
	public XWidget_ListGroupBuilder listGroup;

	[Token(Token = "0x400502F")]
	[FieldOffset(Offset = "0x88")]
	public UILabel itemCount;

	[Token(Token = "0x4005030")]
	[FieldOffset(Offset = "0x8C")]
	public Action onItemSelectRefresh;

	[Token(Token = "0x4005031")]
	[FieldOffset(Offset = "0x90")]
	public Action<SelectRetType, XItem> onWarningPopupShow;

	[Token(Token = "0x4005032")]
	[FieldOffset(Offset = "0x94")]
	private bool m_completeLoading;

	[Token(Token = "0x4005033")]
	[FieldOffset(Offset = "0x98")]
	private XInvenSelectedList InvenSelectedList;

	[Token(Token = "0x4005034")]
	[FieldOffset(Offset = "0x9C")]
	public Action<XItem> m_itemClickAction;

	[Token(Token = "0x4005035")]
	[FieldOffset(Offset = "0xA0")]
	protected XUIInvenListData m_invenList;

	[Token(Token = "0x17000E68")]
	public InventoryModeType InventoryModeType
	{
		[Token(Token = "0x6007124")]
		[Address(RVA = "0x1E0C980", Offset = "0x1E0C980", VA = "0x1E0C980")]
		get
		{
			return default(InventoryModeType);
		}
	}

	[Token(Token = "0x17000E69")]
	public List<string> SelectedIIDList
	{
		[Token(Token = "0x6007125")]
		[Address(RVA = "0x1E0C9D4", Offset = "0x1E0C9D4", VA = "0x1E0C9D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E6A")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x6007126")]
		[Address(RVA = "0x1E0C9EC", Offset = "0x1E0C9EC", VA = "0x1E0C9EC", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E6B")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x6007127")]
		[Address(RVA = "0x1E0CA64", Offset = "0x1E0CA64", VA = "0x1E0CA64", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E6C")]
	protected override int InfoListCount
	{
		[Token(Token = "0x6007128")]
		[Address(RVA = "0x1E0CA6C", Offset = "0x1E0CA6C", VA = "0x1E0CA6C", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E6D")]
	protected List<XItem> ItemList
	{
		[Token(Token = "0x6007137")]
		[Address(RVA = "0x1E0CB60", Offset = "0x1E0CB60", VA = "0x1E0CB60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007123")]
	[Address(RVA = "0x1E0C880", Offset = "0x1E0C880", VA = "0x1E0C880")]
	public XListView_InvenItem()
	{
	}

	[Token(Token = "0x6007129")]
	[Address(RVA = "0x1E0CC14", Offset = "0x1E0CC14", VA = "0x1E0CC14", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}

	[Token(Token = "0x600712A")]
	[Address(RVA = "0x1E0CFC0", Offset = "0x1E0CFC0", VA = "0x1E0CFC0")]
	public bool SelectItem(XItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x600712B")]
	[Address(RVA = "0x1E0D178", Offset = "0x1E0D178", VA = "0x1E0D178")]
	public void UnSelectItem(XItem item)
	{
	}

	[Token(Token = "0x600712C")]
	[Address(RVA = "0x1E0D040", Offset = "0x1E0D040", VA = "0x1E0D040")]
	private void RefreshSelect()
	{
	}

	[Token(Token = "0x600712D")]
	[Address(RVA = "0x1E0D398", Offset = "0x1E0D398", VA = "0x1E0D398")]
	public void ClearSelectedList()
	{
	}

	[Token(Token = "0x600712E")]
	[Address(RVA = "0x1E0D3E4", Offset = "0x1E0D3E4", VA = "0x1E0D3E4")]
	public void ForcedAddSelectItem(XItem item)
	{
	}

	[Token(Token = "0x600712F")]
	[Address(RVA = "0x1E0D444", Offset = "0x1E0D444", VA = "0x1E0D444")]
	public void SetRefineTargetItem(XItem item)
	{
	}

	[Token(Token = "0x6007130")]
	[Address(RVA = "0x1E0D654", Offset = "0x1E0D654", VA = "0x1E0D654")]
	public int GetRefineExpTotal()
	{
		return default(int);
	}

	[Token(Token = "0x6007131")]
	[Address(RVA = "0x1E0D678", Offset = "0x1E0D678", VA = "0x1E0D678")]
	public int GetLastChangeExp()
	{
		return default(int);
	}

	[Token(Token = "0x6007132")]
	[Address(RVA = "0x1E0D478", Offset = "0x1E0D478", VA = "0x1E0D478")]
	private XInvenSelectedList_Refine GetRefineSelectList()
	{
		return null;
	}

	[Token(Token = "0x6007133")]
	[Address(RVA = "0x1E0D69C", Offset = "0x1E0D69C", VA = "0x1E0D69C")]
	private XInvenSelectedList_Transcendence GetTranscendSelectList()
	{
		return null;
	}

	[Token(Token = "0x6007134")]
	[Address(RVA = "0x1E0D768", Offset = "0x1E0D768", VA = "0x1E0D768")]
	public void InvenItem_OnClick(XUIInvenItem invenItemUI)
	{
	}

	[Token(Token = "0x6007135")]
	[Address(RVA = "0x1E0DC34", Offset = "0x1E0DC34", VA = "0x1E0DC34", Slot = "7")]
	public override void OnAwake()
	{
	}

	[Token(Token = "0x6007136")]
	[Address(RVA = "0x1E0DFD0", Offset = "0x1E0DFD0", VA = "0x1E0DFD0", Slot = "14")]
	protected override GameObject GetPrefabInfo()
	{
		return null;
	}

	[Token(Token = "0x6007138")]
	[Address(RVA = "0x1E0E0E8", Offset = "0x1E0E0E8", VA = "0x1E0E0E8")]
	public List<XItem> GetSelectItemList()
	{
		return null;
	}

	[Token(Token = "0x6007139")]
	[Address(RVA = "0x1E0D544", Offset = "0x1E0D544", VA = "0x1E0D544")]
	public void Refresh()
	{
	}

	[Token(Token = "0x600713A")]
	[Address(RVA = "0x1E0E478", Offset = "0x1E0E478", VA = "0x1E0E478")]
	public List<XItem> GetInvenItemList()
	{
		return null;
	}

	[Token(Token = "0x600713B")]
	[Address(RVA = "0x1E0E47C", Offset = "0x1E0E47C", VA = "0x1E0E47C")]
	public void Build(ItemGroupType groupType, Action<XItem> itemClickAction)
	{
	}

	[Token(Token = "0x600713C")]
	[Address(RVA = "0x1E0D068", Offset = "0x1E0D068", VA = "0x1E0D068")]
	public void GoToSelected()
	{
	}

	[Token(Token = "0x600713D")]
	[Address(RVA = "0x1E0EA04", Offset = "0x1E0EA04", VA = "0x1E0EA04", Slot = "10")]
	public override void BuildList()
	{
	}

	[Token(Token = "0x600713E")]
	[Address(RVA = "0x1E0EB40", Offset = "0x1E0EB40", VA = "0x1E0EB40")]
	public void RefreshCount()
	{
	}

	[Token(Token = "0x600713F")]
	[Address(RVA = "0x1E0ED64", Offset = "0x1E0ED64", VA = "0x1E0ED64")]
	public void ChangeMode(InventoryModeType inventoryModeType)
	{
	}

	[Token(Token = "0x6007140")]
	[Address(RVA = "0x1E0DCD0", Offset = "0x1E0DCD0", VA = "0x1E0DCD0")]
	public void ChangeSelectList(InventoryModeType inventoryModeType)
	{
	}

	[Token(Token = "0x6007141")]
	[Address(RVA = "0x1E0D1E4", Offset = "0x1E0D1E4", VA = "0x1E0D1E4")]
	public void RefreshListItems()
	{
	}

	[Token(Token = "0x6007142")]
	[Address(RVA = "0x1E0EFE0", Offset = "0x1E0EFE0", VA = "0x1E0EFE0")]
	public XUIInvenItem GetFirstInvenUIItem()
	{
		return null;
	}

	[Token(Token = "0x6007143")]
	[Address(RVA = "0x1E0F170", Offset = "0x1E0F170", VA = "0x1E0F170")]
	public XUIInvenItem GetInvenUIItem(string itemiid)
	{
		return null;
	}

	[Token(Token = "0x6007144")]
	[Address(RVA = "0x1E0F4D4", Offset = "0x1E0F4D4", VA = "0x1E0F4D4")]
	public bool FindInvenUIItem(string itemiid)
	{
		return default(bool);
	}

	[Token(Token = "0x6007145")]
	[Address(RVA = "0x1E0F280", Offset = "0x1E0F280", VA = "0x1E0F280")]
	private XUIInvenItem GetInvenUIItem(Func<XUIInvenItem, bool> findAction)
	{
		return null;
	}

	[Token(Token = "0x6007146")]
	[Address(RVA = "0x1E0F634", Offset = "0x1E0F634", VA = "0x1E0F634")]
	private int _003CPushDatum_003Em__475(string iid)
	{
		return default(int);
	}

	[Token(Token = "0x6007147")]
	[Address(RVA = "0x1E0F660", Offset = "0x1E0F660", VA = "0x1E0F660")]
	private void _003CRefreshListItems_003Em__477(XUIInvenItem invenItem)
	{
	}
}
