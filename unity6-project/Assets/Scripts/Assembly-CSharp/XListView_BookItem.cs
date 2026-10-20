using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F27")]
public class XListView_BookItem : XUIListView
{
	[Token(Token = "0x2000F28")]
	protected abstract class XUIIllustratedBookListData
	{
		protected XUIIllustratedBookListData()
		{
		}

		[Token(Token = "0x2000F29")]
		protected class ItemComparer : IComparer<CSItemInfo>
		{
			[Token(Token = "0x60070F3")]
			[Address(RVA = "0x1E07C00", Offset = "0x1E07C00", VA = "0x1E07C00")]
			public ItemComparer()
			{
			}

			[Token(Token = "0x60070F4")]
			[Address(RVA = "0x1E085AC", Offset = "0x1E085AC", VA = "0x1E085AC", Slot = "4")]
			public int Compare(CSItemInfo left, CSItemInfo right)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000F2A")]
		protected class EquipmentItem
		{
			[Token(Token = "0x4005018")]
			[FieldOffset(Offset = "0x8")]
			private List<int> DicList;

			[Token(Token = "0x4005019")]
			[FieldOffset(Offset = "0x0")]
			private static Func<CSItemInfo, bool> _003C_003Ef__am_0024cache1;

			[Token(Token = "0x60070F5")]
			[Address(RVA = "0x1E07690", Offset = "0x1E07690", VA = "0x1E07690")]
			public EquipmentItem()
			{
			}

			[Token(Token = "0x60070F6")]
			[Address(RVA = "0x1E0773C", Offset = "0x1E0773C", VA = "0x1E0773C")]
			public List<CSItemInfo> EquipItem(List<CSItemInfo> item)
			{
				return null;
			}

			[Token(Token = "0x60070F7")]
			[Address(RVA = "0x1E07A80", Offset = "0x1E07A80", VA = "0x1E07A80")]
			public List<CSItemInfo> DictionaryItem(List<CSItemInfo> item)
			{
				return null;
			}

			[Token(Token = "0x60070F8")]
			[Address(RVA = "0x1E0787C", Offset = "0x1E0787C", VA = "0x1E0787C")]
			public void DictionaryList()
			{
			}

			[Token(Token = "0x60070F9")]
			[Address(RVA = "0x1E08410", Offset = "0x1E08410", VA = "0x1E08410")]
			public int CheckList(int ID)
			{
				return default(int);
			}

			[Token(Token = "0x60070FA")]
			[Address(RVA = "0x1E08534", Offset = "0x1E08534", VA = "0x1E08534")]
			private static bool _003CEquipItem_003Em__46A(CSItemInfo x)
			{
				return default(bool);
			}

			[Token(Token = "0x60070FB")]
			[Address(RVA = "0x1E08570", Offset = "0x1E08570", VA = "0x1E08570")]
			private bool _003CDictionaryItem_003Em__46B(CSItemInfo x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000F2B")]
		private sealed class _003CChangeSubTab_003Ec__AnonStorey228
		{
			[Token(Token = "0x400501A")]
			[FieldOffset(Offset = "0x8")]
			internal int index;

			[Token(Token = "0x60070FC")]
			[Address(RVA = "0x1E07E64", Offset = "0x1E07E64", VA = "0x1E07E64")]
			public _003CChangeSubTab_003Ec__AnonStorey228()
			{
			}

			[Token(Token = "0x60070FD")]
			[Address(RVA = "0x1E083CC", Offset = "0x1E083CC", VA = "0x1E083CC")]
			internal bool _003C_003Em__463(CSItemInfo x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4005013")]
		[FieldOffset(Offset = "0x8")]
		protected XListView_BookItem m_listView;

		[Token(Token = "0x4005014")]
		[FieldOffset(Offset = "0xC")]
		protected List<CSItemInfo> mainList;

		[Token(Token = "0x4005015")]
		[FieldOffset(Offset = "0x10")]
		protected List<CSItemInfo> subList;

		[Token(Token = "0x4005016")]
		[FieldOffset(Offset = "0x14")]
		private int m_index;

		[Token(Token = "0x4005017")]
		[FieldOffset(Offset = "0x18")]
		private XWidget_ToggleTab_Btn[] m_tabs;

		[Token(Token = "0x17000E5D")]
		public abstract EquipmentSlot Type
		{
			[Token(Token = "0x60070E8")]
			get;
		}

		[Token(Token = "0x17000E5E")]
		public List<CSItemInfo> List
		{
			[Token(Token = "0x60070E9")]
			[Address(RVA = "0x1E07C08", Offset = "0x1E07C08", VA = "0x1E07C08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60070E4")]
		[Address(RVA = "0x1E06508", Offset = "0x1E06508", VA = "0x1E06508")]
		public XUIIllustratedBookListData(XListView_BookItem listView)
		{
		}

		[Token(Token = "0x60070E5")]
		[Address(RVA = "0x1E07530", Offset = "0x1E07530", VA = "0x1E07530")]
		public void InitData(XListView_BookItem listView)
		{
		}

		[Token(Token = "0x60070E6")]
		[Address(RVA = "0x1E07B74", Offset = "0x1E07B74", VA = "0x1E07B74", Slot = "4")]
		protected virtual IComparer<CSItemInfo> GetComparer()
		{
			return null;
		}

		[Token(Token = "0x60070E7")]
		protected abstract List<CSItemInfo> GetList();

		[Token(Token = "0x60070EA")]
		[Address(RVA = "0x1E07C10", Offset = "0x1E07C10", VA = "0x1E07C10")]
		public void ChangeSubTab(int index)
		{
		}

		[Token(Token = "0x60070EB")]
		[Address(RVA = "0x1E07E6C", Offset = "0x1E07E6C", VA = "0x1E07E6C")]
		public void BuildSubTabs(XWiget_GridBuilder subTabGrid)
		{
		}

		[Token(Token = "0x60070EC")]
		[Address(RVA = "0x1E08390", Offset = "0x1E08390", VA = "0x1E08390")]
		private void SetSubTabPosition(Transform subTab, float xPos)
		{
		}

		[Token(Token = "0x60070ED")]
		[Address(RVA = "0x1E0839C", Offset = "0x1E0839C", VA = "0x1E0839C")]
		private void _003CBuildSubTabs_003Em__464()
		{
		}

		[Token(Token = "0x60070EE")]
		[Address(RVA = "0x1E083A4", Offset = "0x1E083A4", VA = "0x1E083A4")]
		private void _003CBuildSubTabs_003Em__465()
		{
		}

		[Token(Token = "0x60070EF")]
		[Address(RVA = "0x1E083AC", Offset = "0x1E083AC", VA = "0x1E083AC")]
		private void _003CBuildSubTabs_003Em__466()
		{
		}

		[Token(Token = "0x60070F0")]
		[Address(RVA = "0x1E083B4", Offset = "0x1E083B4", VA = "0x1E083B4")]
		private void _003CBuildSubTabs_003Em__467()
		{
		}

		[Token(Token = "0x60070F1")]
		[Address(RVA = "0x1E083BC", Offset = "0x1E083BC", VA = "0x1E083BC")]
		private void _003CBuildSubTabs_003Em__468()
		{
		}

		[Token(Token = "0x60070F2")]
		[Address(RVA = "0x1E083C4", Offset = "0x1E083C4", VA = "0x1E083C4")]
		private void _003CBuildSubTabs_003Em__469()
		{
		}
	}

	[Token(Token = "0x2000F2C")]
	protected class XUIBookList_Wepon : XUIIllustratedBookListData
	{
		[Token(Token = "0x400501B")]
		[FieldOffset(Offset = "0x0")]
		private static Func<CSItemInfo, bool> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x17000E5F")]
		public override EquipmentSlot Type
		{
			[Token(Token = "0x60070FF")]
			[Address(RVA = "0x1E07308", Offset = "0x1E07308", VA = "0x1E07308", Slot = "6")]
			get
			{
				return default(EquipmentSlot);
			}
		}

		[Token(Token = "0x60070FE")]
		[Address(RVA = "0x1E072E0", Offset = "0x1E072E0", VA = "0x1E072E0")]
		public XUIBookList_Wepon(XListView_BookItem listView)
		{
		}

		[Token(Token = "0x6007100")]
		[Address(RVA = "0x1E07310", Offset = "0x1E07310", VA = "0x1E07310", Slot = "5")]
		protected override List<CSItemInfo> GetList()
		{
			return null;
		}

		[Token(Token = "0x6007101")]
		[Address(RVA = "0x1E07500", Offset = "0x1E07500", VA = "0x1E07500")]
		private static bool _003CGetList_003Em__46C(CSItemInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000F2D")]
	protected class XUIBookList_Armor : XUIIllustratedBookListData
	{
		[Token(Token = "0x400501C")]
		[FieldOffset(Offset = "0x0")]
		private static Func<CSItemInfo, bool> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x17000E60")]
		public override EquipmentSlot Type
		{
			[Token(Token = "0x6007103")]
			[Address(RVA = "0x2038188", Offset = "0x2038188", VA = "0x2038188", Slot = "6")]
			get
			{
				return default(EquipmentSlot);
			}
		}

		[Token(Token = "0x6007102")]
		[Address(RVA = "0x2038178", Offset = "0x2038178", VA = "0x2038178")]
		public XUIBookList_Armor(XListView_BookItem listView)
		{
		}

		[Token(Token = "0x6007104")]
		[Address(RVA = "0x2038190", Offset = "0x2038190", VA = "0x2038190", Slot = "5")]
		protected override List<CSItemInfo> GetList()
		{
			return null;
		}

		[Token(Token = "0x6007105")]
		[Address(RVA = "0x2038380", Offset = "0x2038380", VA = "0x2038380")]
		private static bool _003CGetList_003Em__46D(CSItemInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000F2E")]
	protected class XUIBookList_Shoes : XUIIllustratedBookListData
	{
		[Token(Token = "0x400501D")]
		[FieldOffset(Offset = "0x0")]
		private static Func<CSItemInfo, bool> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x17000E61")]
		public override EquipmentSlot Type
		{
			[Token(Token = "0x6007107")]
			[Address(RVA = "0x1E070B8", Offset = "0x1E070B8", VA = "0x1E070B8", Slot = "6")]
			get
			{
				return default(EquipmentSlot);
			}
		}

		[Token(Token = "0x6007106")]
		[Address(RVA = "0x1E07090", Offset = "0x1E07090", VA = "0x1E07090")]
		public XUIBookList_Shoes(XListView_BookItem listView)
		{
		}

		[Token(Token = "0x6007108")]
		[Address(RVA = "0x1E070C0", Offset = "0x1E070C0", VA = "0x1E070C0", Slot = "5")]
		protected override List<CSItemInfo> GetList()
		{
			return null;
		}

		[Token(Token = "0x6007109")]
		[Address(RVA = "0x1E072B0", Offset = "0x1E072B0", VA = "0x1E072B0")]
		private static bool _003CGetList_003Em__46E(CSItemInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000F2F")]
	protected class XUIBookList_Glove : XUIIllustratedBookListData
	{
		[Token(Token = "0x400501E")]
		[FieldOffset(Offset = "0x0")]
		private static Func<CSItemInfo, bool> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x17000E62")]
		public override EquipmentSlot Type
		{
			[Token(Token = "0x600710B")]
			[Address(RVA = "0x1E069C8", Offset = "0x1E069C8", VA = "0x1E069C8", Slot = "6")]
			get
			{
				return default(EquipmentSlot);
			}
		}

		[Token(Token = "0x600710A")]
		[Address(RVA = "0x1E069A0", Offset = "0x1E069A0", VA = "0x1E069A0")]
		public XUIBookList_Glove(XListView_BookItem listView)
		{
		}

		[Token(Token = "0x600710C")]
		[Address(RVA = "0x1E069D0", Offset = "0x1E069D0", VA = "0x1E069D0", Slot = "5")]
		protected override List<CSItemInfo> GetList()
		{
			return null;
		}

		[Token(Token = "0x600710D")]
		[Address(RVA = "0x1E06BC0", Offset = "0x1E06BC0", VA = "0x1E06BC0")]
		private static bool _003CGetList_003Em__46F(CSItemInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000F30")]
	protected class XUIBookList_Ring : XUIIllustratedBookListData
	{
		[Token(Token = "0x400501F")]
		[FieldOffset(Offset = "0x0")]
		private static Func<CSItemInfo, bool> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x17000E63")]
		public override EquipmentSlot Type
		{
			[Token(Token = "0x600710F")]
			[Address(RVA = "0x1E06E68", Offset = "0x1E06E68", VA = "0x1E06E68", Slot = "6")]
			get
			{
				return default(EquipmentSlot);
			}
		}

		[Token(Token = "0x600710E")]
		[Address(RVA = "0x1E06E40", Offset = "0x1E06E40", VA = "0x1E06E40")]
		public XUIBookList_Ring(XListView_BookItem listView)
		{
		}

		[Token(Token = "0x6007110")]
		[Address(RVA = "0x1E06E70", Offset = "0x1E06E70", VA = "0x1E06E70", Slot = "5")]
		protected override List<CSItemInfo> GetList()
		{
			return null;
		}

		[Token(Token = "0x6007111")]
		[Address(RVA = "0x1E07060", Offset = "0x1E07060", VA = "0x1E07060")]
		private static bool _003CGetList_003Em__470(CSItemInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000F31")]
	protected class XUIBookList_Necklace : XUIIllustratedBookListData
	{
		[Token(Token = "0x4005020")]
		[FieldOffset(Offset = "0x0")]
		private static Func<CSItemInfo, bool> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x17000E64")]
		public override EquipmentSlot Type
		{
			[Token(Token = "0x6007113")]
			[Address(RVA = "0x1E06C18", Offset = "0x1E06C18", VA = "0x1E06C18", Slot = "6")]
			get
			{
				return default(EquipmentSlot);
			}
		}

		[Token(Token = "0x6007112")]
		[Address(RVA = "0x1E06BF0", Offset = "0x1E06BF0", VA = "0x1E06BF0")]
		public XUIBookList_Necklace(XListView_BookItem listView)
		{
		}

		[Token(Token = "0x6007114")]
		[Address(RVA = "0x1E06C20", Offset = "0x1E06C20", VA = "0x1E06C20", Slot = "5")]
		protected override List<CSItemInfo> GetList()
		{
			return null;
		}

		[Token(Token = "0x6007115")]
		[Address(RVA = "0x1E06E10", Offset = "0x1E06E10", VA = "0x1E06E10")]
		private static bool _003CGetList_003Em__471(CSItemInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000F32")]
	protected class XUIBookList_Brooch : XUIIllustratedBookListData
	{
		[Token(Token = "0x4005021")]
		[FieldOffset(Offset = "0x0")]
		private static Func<CSItemInfo, bool> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x17000E65")]
		public override EquipmentSlot Type
		{
			[Token(Token = "0x6007117")]
			[Address(RVA = "0x1E06530", Offset = "0x1E06530", VA = "0x1E06530", Slot = "6")]
			get
			{
				return default(EquipmentSlot);
			}
		}

		[Token(Token = "0x6007116")]
		[Address(RVA = "0x1E064E0", Offset = "0x1E064E0", VA = "0x1E064E0")]
		public XUIBookList_Brooch(XListView_BookItem listView)
		{
		}

		[Token(Token = "0x6007118")]
		[Address(RVA = "0x1E06538", Offset = "0x1E06538", VA = "0x1E06538", Slot = "5")]
		protected override List<CSItemInfo> GetList()
		{
			return null;
		}

		[Token(Token = "0x6007119")]
		[Address(RVA = "0x1E06720", Offset = "0x1E06720", VA = "0x1E06720")]
		private static bool _003CGetList_003Em__472(CSItemInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000F33")]
	protected class XUIBookList_Bracelet : XUIIllustratedBookListData
	{
		[Token(Token = "0x4005022")]
		[FieldOffset(Offset = "0x0")]
		private static Func<CSItemInfo, bool> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x17000E66")]
		public override EquipmentSlot Type
		{
			[Token(Token = "0x600711B")]
			[Address(RVA = "0x20383AC", Offset = "0x20383AC", VA = "0x20383AC", Slot = "6")]
			get
			{
				return default(EquipmentSlot);
			}
		}

		[Token(Token = "0x600711A")]
		[Address(RVA = "0x2038180", Offset = "0x2038180", VA = "0x2038180")]
		public XUIBookList_Bracelet(XListView_BookItem listView)
		{
		}

		[Token(Token = "0x600711C")]
		[Address(RVA = "0x20383B4", Offset = "0x20383B4", VA = "0x20383B4", Slot = "5")]
		protected override List<CSItemInfo> GetList()
		{
			return null;
		}

		[Token(Token = "0x600711D")]
		[Address(RVA = "0x20385A4", Offset = "0x20385A4", VA = "0x20385A4")]
		private static bool _003CGetList_003Em__473(CSItemInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000F34")]
	protected class XUIBookList_Earring : XUIIllustratedBookListData
	{
		[Token(Token = "0x4005023")]
		[FieldOffset(Offset = "0x0")]
		private static Func<CSItemInfo, bool> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x17000E67")]
		public override EquipmentSlot Type
		{
			[Token(Token = "0x600711F")]
			[Address(RVA = "0x1E06778", Offset = "0x1E06778", VA = "0x1E06778", Slot = "6")]
			get
			{
				return default(EquipmentSlot);
			}
		}

		[Token(Token = "0x600711E")]
		[Address(RVA = "0x1E06750", Offset = "0x1E06750", VA = "0x1E06750")]
		public XUIBookList_Earring(XListView_BookItem listView)
		{
		}

		[Token(Token = "0x6007120")]
		[Address(RVA = "0x1E06780", Offset = "0x1E06780", VA = "0x1E06780", Slot = "5")]
		protected override List<CSItemInfo> GetList()
		{
			return null;
		}

		[Token(Token = "0x6007121")]
		[Address(RVA = "0x1E06970", Offset = "0x1E06970", VA = "0x1E06970")]
		private static bool _003CGetList_003Em__474(CSItemInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4005011")]
	[FieldOffset(Offset = "0x78")]
	protected XUIIllustratedBookListData m_dataList;

	[Token(Token = "0x4005012")]
	[FieldOffset(Offset = "0x7C")]
	public int numberOnAline;

	[Token(Token = "0x17000E59")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x60070DC")]
		[Address(RVA = "0x2037990", Offset = "0x2037990", VA = "0x2037990", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E5A")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x60070DD")]
		[Address(RVA = "0x2037A08", Offset = "0x2037A08", VA = "0x2037A08", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E5B")]
	protected override int InfoListCount
	{
		[Token(Token = "0x60070DE")]
		[Address(RVA = "0x2037A10", Offset = "0x2037A10", VA = "0x2037A10", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E5C")]
	protected List<CSItemInfo> ItemList
	{
		[Token(Token = "0x60070DF")]
		[Address(RVA = "0x2037ABC", Offset = "0x2037ABC", VA = "0x2037ABC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60070DB")]
	[Address(RVA = "0x20378E4", Offset = "0x20378E4", VA = "0x20378E4")]
	public XListView_BookItem()
	{
	}

	[Token(Token = "0x60070E0")]
	[Address(RVA = "0x2037B74", Offset = "0x2037B74", VA = "0x2037B74")]
	public void Build(EquipmentSlot type, XWiget_GridBuilder subTabGrid)
	{
	}

	[Token(Token = "0x60070E1")]
	[Address(RVA = "0x2037FB8", Offset = "0x2037FB8", VA = "0x2037FB8", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}

	[Token(Token = "0x60070E2")]
	[Address(RVA = "0x2037B98", Offset = "0x2037B98", VA = "0x2037B98")]
	private void SetEquipmentType(EquipmentSlot type)
	{
	}

	[Token(Token = "0x60070E3")]
	[Address(RVA = "0x2037F8C", Offset = "0x2037F8C", VA = "0x2037F8C")]
	private void BuildSubTab(XWiget_GridBuilder subTabGrid)
	{
	}
}
