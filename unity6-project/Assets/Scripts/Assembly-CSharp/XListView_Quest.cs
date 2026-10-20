using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F4D")]
public class XListView_Quest : XUIListView
{
	[Token(Token = "0x2000F4E")]
	private sealed class _003CSetQuestTabsList_003Ec__AnonStorey22F
	{
		[Token(Token = "0x400505A")]
		[FieldOffset(Offset = "0x8")]
		internal QuestGroup group;

		[Token(Token = "0x60071B4")]
		[Address(RVA = "0x1E14FE8", Offset = "0x1E14FE8", VA = "0x1E14FE8")]
		public _003CSetQuestTabsList_003Ec__AnonStorey22F()
		{
		}

		[Token(Token = "0x60071B5")]
		[Address(RVA = "0x1E15234", Offset = "0x1E15234", VA = "0x1E15234")]
		internal bool _003C_003Em__487(QuestInfo w)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000F4F")]
	private sealed class _003CGetClesrQuestTabsList_003Ec__AnonStorey230
	{
		[Token(Token = "0x400505B")]
		[FieldOffset(Offset = "0x8")]
		internal QuestGroup group;

		[Token(Token = "0x60071B6")]
		[Address(RVA = "0x1E14FF0", Offset = "0x1E14FF0", VA = "0x1E14FF0")]
		public _003CGetClesrQuestTabsList_003Ec__AnonStorey230()
		{
		}

		[Token(Token = "0x60071B7")]
		[Address(RVA = "0x1E15200", Offset = "0x1E15200", VA = "0x1E15200")]
		internal bool _003C_003Em__488(QuestInfo w)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400504F")]
	[FieldOffset(Offset = "0x78")]
	private bool m_needRefreshList;

	[Token(Token = "0x4005050")]
	[FieldOffset(Offset = "0x7C")]
	private List<QuestInfo> m_list;

	[Token(Token = "0x4005051")]
	[FieldOffset(Offset = "0x80")]
	private List<QuestInfo> tab_list;

	[Token(Token = "0x4005052")]
	[FieldOffset(Offset = "0x84")]
	private List<QuestInfo> m_questDoneList;

	[Token(Token = "0x4005053")]
	[FieldOffset(Offset = "0x88")]
	private Action m_hideAction;

	[Token(Token = "0x4005054")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject allClearItem;

	[Token(Token = "0x4005055")]
	[FieldOffset(Offset = "0x90")]
	private QuestGroup m_type;

	[Token(Token = "0x4005056")]
	[FieldOffset(Offset = "0x94")]
	private InitializeType m_InitType;

	[Token(Token = "0x4005057")]
	[FieldOffset(Offset = "0x0")]
	private static Func<QuestInfo, int> _003C_003Ef__am_0024cache8;

	[Token(Token = "0x4005058")]
	[FieldOffset(Offset = "0x4")]
	private static Func<QuestInfo, int> _003C_003Ef__am_0024cache9;

	[Token(Token = "0x4005059")]
	[FieldOffset(Offset = "0x8")]
	private static Func<QuestInfo, int> _003C_003Ef__am_0024cacheA;

	[Token(Token = "0x17000E7D")]
	protected override string ItemPrefabName
	{
		[Token(Token = "0x60071A0")]
		[Address(RVA = "0x1E138E4", Offset = "0x1E138E4", VA = "0x1E138E4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E7E")]
	protected override int BuildItemSettingCount
	{
		[Token(Token = "0x60071A1")]
		[Address(RVA = "0x1E1395C", Offset = "0x1E1395C", VA = "0x1E1395C", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E7F")]
	protected override int InfoListCount
	{
		[Token(Token = "0x60071A2")]
		[Address(RVA = "0x1E13964", Offset = "0x1E13964", VA = "0x1E13964", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E80")]
	public InitializeType InitType
	{
		[Token(Token = "0x60071A3")]
		[Address(RVA = "0x1E139FC", Offset = "0x1E139FC", VA = "0x1E139FC")]
		get
		{
			return default(InitializeType);
		}
	}

	[Token(Token = "0x17000E81")]
	public int QuestItemCount
	{
		[Token(Token = "0x60071A4")]
		[Address(RVA = "0x1E13A04", Offset = "0x1E13A04", VA = "0x1E13A04")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E82")]
	public QuestGroup Group
	{
		[Token(Token = "0x60071A5")]
		[Address(RVA = "0x1E13A9C", Offset = "0x1E13A9C", VA = "0x1E13A9C")]
		get
		{
			return default(QuestGroup);
		}
		[Token(Token = "0x60071A6")]
		[Address(RVA = "0x1E13AA4", Offset = "0x1E13AA4", VA = "0x1E13AA4")]
		private set
		{
		}
	}

	[Token(Token = "0x600719F")]
	[Address(RVA = "0x1E137D4", Offset = "0x1E137D4", VA = "0x1E137D4")]
	public XListView_Quest()
	{
	}

	[Token(Token = "0x60071A7")]
	[Address(RVA = "0x1E13AA8", Offset = "0x1E13AA8", VA = "0x1E13AA8")]
	public void Build(QuestGroup type, Action hideAction)
	{
	}

	[Token(Token = "0x60071A8")]
	[Address(RVA = "0x1E13AF8", Offset = "0x1E13AF8", VA = "0x1E13AF8")]
	private void SetQuestListType(QuestGroup type)
	{
	}

	[Token(Token = "0x60071A9")]
	[Address(RVA = "0x1E13C74", Offset = "0x1E13C74", VA = "0x1E13C74")]
	private void SetMainQuestListSetting()
	{
	}

	[Token(Token = "0x60071AA")]
	[Address(RVA = "0x1E14E94", Offset = "0x1E14E94", VA = "0x1E14E94")]
	private void AddQuestDoneList(QuestInfo quest)
	{
	}

	[Token(Token = "0x60071AB")]
	[Address(RVA = "0x1E145E4", Offset = "0x1E145E4", VA = "0x1E145E4")]
	public List<QuestInfo> SetQuestTabsList(QuestGroup group)
	{
		return null;
	}

	[Token(Token = "0x60071AC")]
	[Address(RVA = "0x1E14720", Offset = "0x1E14720", VA = "0x1E14720")]
	public List<QuestInfo> GetClesrQuestTabsList(QuestGroup group)
	{
		return null;
	}

	[Token(Token = "0x60071AD")]
	[Address(RVA = "0x1E1485C", Offset = "0x1E1485C", VA = "0x1E1485C")]
	private void SortedList(List<QuestInfo> clearQuestList)
	{
	}

	[Token(Token = "0x60071AE")]
	[Address(RVA = "0x1E150A8", Offset = "0x1E150A8", VA = "0x1E150A8", Slot = "12")]
	protected override void PushDatum(GameObject go, int index)
	{
	}

	[Token(Token = "0x60071AF")]
	[Address(RVA = "0x1E15194", Offset = "0x1E15194", VA = "0x1E15194")]
	public void ReserveRefresh()
	{
	}

	[Token(Token = "0x60071B0")]
	[Address(RVA = "0x1E14FF8", Offset = "0x1E14FF8", VA = "0x1E14FF8")]
	private void BuildAllClearItem(QuestInfo questItem)
	{
	}

	[Token(Token = "0x60071B1")]
	[Address(RVA = "0x1E151A0", Offset = "0x1E151A0", VA = "0x1E151A0")]
	private static int _003CSortedList_003Em__489(QuestInfo o)
	{
		return default(int);
	}

	[Token(Token = "0x60071B2")]
	[Address(RVA = "0x1E151C0", Offset = "0x1E151C0", VA = "0x1E151C0")]
	private static int _003CSortedList_003Em__48A(QuestInfo o)
	{
		return default(int);
	}

	[Token(Token = "0x60071B3")]
	[Address(RVA = "0x1E151E0", Offset = "0x1E151E0", VA = "0x1E151E0")]
	private static int _003CSortedList_003Em__48B(QuestInfo o)
	{
		return default(int);
	}
}
