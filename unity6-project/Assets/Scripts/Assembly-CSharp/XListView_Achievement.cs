using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F09")]
public class XListView_Achievement : XUIListView
{
	[Token(Token = "0x2000F0A")]
	protected abstract class XUIAchievementListData
	{
		protected XUIAchievementListData()
		{
		}

		[Token(Token = "0x4004FBD")]
		[FieldOffset(Offset = "0x8")]
		protected List<QuestInfo> m_mainList;

		[Token(Token = "0x4004FBE")]
		[FieldOffset(Offset = "0xC")]
		protected XListView_Achievement m_listView;

		[Token(Token = "0x17000E35")]
		public abstract QuestGroup Type
		{
			[Token(Token = "0x600704B")]
			get;
		}

		[Token(Token = "0x17000E36")]
		public List<QuestInfo> List
		{
			[Token(Token = "0x600704D")]
			[Address(RVA = "0x2036574", Offset = "0x2036574", VA = "0x2036574")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007049")]
		[Address(RVA = "0x2036D3C", Offset = "0x2036D3C", VA = "0x2036D3C")]
		public XUIAchievementListData(XListView_Achievement listView)
		{
		}

		[Token(Token = "0x600704A")]
		[Address(RVA = "0x2036888", Offset = "0x2036888", VA = "0x2036888")]
		public void InitData(XListView_Achievement listView)
		{
		}

		[Token(Token = "0x600704C")]
		protected abstract List<QuestInfo> GetList();
	}

	[Token(Token = "0x2000F0B")]
	protected class XUIAchievementList_Growth : XUIAchievementListData
	{
		[Token(Token = "0x4004FBF")]
		[FieldOffset(Offset = "0x0")]
		private static Func<QuestInfo, bool> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x17000E37")]
		public override QuestGroup Type
		{
			[Token(Token = "0x600704F")]
			[Address(RVA = "0x20371AC", Offset = "0x20371AC", VA = "0x20371AC", Slot = "4")]
			get
			{
				return default(QuestGroup);
			}
		}

		[Token(Token = "0x600704E")]
		[Address(RVA = "0x2036CBC", Offset = "0x2036CBC", VA = "0x2036CBC")]
		public XUIAchievementList_Growth(XListView_Achievement listView)
		{
		}

		[Token(Token = "0x6007050")]
		[Address(RVA = "0x20371B4", Offset = "0x20371B4", VA = "0x20371B4", Slot = "5")]
		protected override List<QuestInfo> GetList()
		{
			return null;
		}

		[Token(Token = "0x6007051")]
		[Address(RVA = "0x20373A4", Offset = "0x20373A4", VA = "0x20373A4")]
		private static bool _003CGetList_003Em__45C(QuestInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000F0C")]
	protected class XUIAchievementList_Battle : XUIAchievementListData
	{
		[Token(Token = "0x4004FC0")]
		[FieldOffset(Offset = "0x0")]
		private static Func<QuestInfo, bool> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x17000E38")]
		public override QuestGroup Type
		{
			[Token(Token = "0x6007053")]
			[Address(RVA = "0x2036D5C", Offset = "0x2036D5C", VA = "0x2036D5C", Slot = "4")]
			get
			{
				return default(QuestGroup);
			}
		}

		[Token(Token = "0x6007052")]
		[Address(RVA = "0x2036CDC", Offset = "0x2036CDC", VA = "0x2036CDC")]
		public XUIAchievementList_Battle(XListView_Achievement listView)
		{
		}

		[Token(Token = "0x6007054")]
		[Address(RVA = "0x2036D64", Offset = "0x2036D64", VA = "0x2036D64", Slot = "5")]
		protected override List<QuestInfo> GetList()
		{
			return null;
		}

		[Token(Token = "0x6007055")]
		[Address(RVA = "0x2036F54", Offset = "0x2036F54", VA = "0x2036F54")]
		private static bool _003CGetList_003Em__45D(QuestInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000F0D")]
	protected class XUIAchievementList_Equipment : XUIAchievementListData
	{
		[Token(Token = "0x4004FC1")]
		[FieldOffset(Offset = "0x0")]
		private static Func<QuestInfo, bool> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x17000E39")]
		public override QuestGroup Type
		{
			[Token(Token = "0x6007057")]
			[Address(RVA = "0x2036F84", Offset = "0x2036F84", VA = "0x2036F84", Slot = "4")]
			get
			{
				return default(QuestGroup);
			}
		}

		[Token(Token = "0x6007056")]
		[Address(RVA = "0x2036CFC", Offset = "0x2036CFC", VA = "0x2036CFC")]
		public XUIAchievementList_Equipment(XListView_Achievement listView)
		{
		}

		[Token(Token = "0x6007058")]
		[Address(RVA = "0x2036F8C", Offset = "0x2036F8C", VA = "0x2036F8C", Slot = "5")]
		protected override List<QuestInfo> GetList()
		{
			return null;
		}

		[Token(Token = "0x6007059")]
		[Address(RVA = "0x203717C", Offset = "0x203717C", VA = "0x203717C")]
		private static bool _003CGetList_003Em__45E(QuestInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000F0E")]
	protected class XUIAchievementList_Social : XUIAchievementListData
	{
		[Token(Token = "0x4004FC2")]
		[FieldOffset(Offset = "0x0")]
		private static Func<QuestInfo, bool> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x17000E3A")]
		public override QuestGroup Type
		{
			[Token(Token = "0x600705B")]
			[Address(RVA = "0x20373D4", Offset = "0x20373D4", VA = "0x20373D4", Slot = "4")]
			get
			{
				return default(QuestGroup);
			}
		}

		[Token(Token = "0x600705A")]
		[Address(RVA = "0x2036D1C", Offset = "0x2036D1C", VA = "0x2036D1C")]
		public XUIAchievementList_Social(XListView_Achievement listView)
		{
		}

		[Token(Token = "0x600705C")]
		[Address(RVA = "0x20373DC", Offset = "0x20373DC", VA = "0x20373DC", Slot = "5")]
		protected override List<QuestInfo> GetList()
		{
			return null;
		}

		[Token(Token = "0x600705D")]
		[Address(RVA = "0x20375CC", Offset = "0x20375CC", VA = "0x20375CC")]
		private static bool _003CGetList_003Em__45F(QuestInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4004FB9")]
	[FieldOffset(Offset = "0x78")]
	private bool m_refreshlist;

	[Token(Token = "0x4004FBA")]
	[FieldOffset(Offset = "0x7C")]
	protected XUIAchievementListData m_dataList;

	[Token(Token = "0x4004FBB")]
	[FieldOffset(Offset = "0x80")]
	private List<QuestInfo> m_list;

	[Token(Token = "0x4004FBC")]
	[FieldOffset(Offset = "0x84")]
	public XPanel_Achievement pnlAchievement;

	[Token(Token = "0x17000E31")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x6007040")]
		[Address(RVA = "0x2035D90", Offset = "0x2035D90", VA = "0x2035D90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E32")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x6007041")]
		[Address(RVA = "0x2035E08", Offset = "0x2035E08", VA = "0x2035E08", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E33")]
	protected override int InfoListCount
	{
		[Token(Token = "0x6007042")]
		[Address(RVA = "0x2035E10", Offset = "0x2035E10", VA = "0x2035E10", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E34")]
	protected List<QuestInfo> AchieveList
	{
		[Token(Token = "0x6007046")]
		[Address(RVA = "0x203637C", Offset = "0x203637C", VA = "0x203637C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600703F")]
	[Address(RVA = "0x2035CB0", Offset = "0x2035CB0", VA = "0x2035CB0")]
	public XListView_Achievement()
	{
	}

	[Token(Token = "0x6007043")]
	[Address(RVA = "0x2035EB8", Offset = "0x2035EB8", VA = "0x2035EB8")]
	private void RefreshList()
	{
	}

	[Token(Token = "0x6007044")]
	[Address(RVA = "0x2036430", Offset = "0x2036430", VA = "0x2036430")]
	public void ReserveRefresh()
	{
	}

	[Token(Token = "0x6007045")]
	[Address(RVA = "0x203643C", Offset = "0x203643C", VA = "0x203643C", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}

	[Token(Token = "0x6007047")]
	[Address(RVA = "0x203657C", Offset = "0x203657C", VA = "0x203657C")]
	public void Build(QuestGroup type)
	{
	}

	[Token(Token = "0x6007048")]
	[Address(RVA = "0x2036600", Offset = "0x2036600", VA = "0x2036600")]
	private void SetAcievementType(QuestGroup type)
	{
	}
}
