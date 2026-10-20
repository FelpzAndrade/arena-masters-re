using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x200068B")]
public class TutorialGroup
{
	[Token(Token = "0x200068C")]
	private sealed class _003CTryGetIndexInGroup_003Ec__AnonStorey12B
	{
		[Token(Token = "0x400200E")]
		[FieldOffset(Offset = "0x8")]
		internal int order;

		[Token(Token = "0x6003732")]
		[Address(RVA = "0x1D5AF5C", Offset = "0x1D5AF5C", VA = "0x1D5AF5C")]
		public _003CTryGetIndexInGroup_003Ec__AnonStorey12B()
		{
		}

		[Token(Token = "0x6003733")]
		[Address(RVA = "0x1D5BC90", Offset = "0x1D5BC90", VA = "0x1D5BC90")]
		internal bool _003C_003Em__18A(TutorialDataBase x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4002002")]
	[FieldOffset(Offset = "0x8")]
	public Dictionary<int, List<TutorialDataBase>> scriptList;

	[Token(Token = "0x4002003")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<int, string> groupStartSceneList;

	[Token(Token = "0x4002004")]
	[FieldOffset(Offset = "0x10")]
	private List<int> groupFinishOrder;

	[Token(Token = "0x4002005")]
	[FieldOffset(Offset = "0x14")]
	private List<int> rewardUpOrders;

	[Token(Token = "0x4002006")]
	[FieldOffset(Offset = "0x18")]
	private SortedDictionary<int, bool> bgActiveDic;

	[Token(Token = "0x4002007")]
	[FieldOffset(Offset = "0x1C")]
	public bool Skipable;

	[Token(Token = "0x4002008")]
	[FieldOffset(Offset = "0x20")]
	public int id;

	[Token(Token = "0x4002009")]
	[FieldOffset(Offset = "0x24")]
	public int lastOrder;

	[Token(Token = "0x400200A")]
	[FieldOffset(Offset = "0x28")]
	private bool isSort;

	[Token(Token = "0x400200B")]
	[FieldOffset(Offset = "0x29")]
	public bool isExistTutorialStartType;

	[Token(Token = "0x400200C")]
	[FieldOffset(Offset = "0x2C")]
	private int NotClearedReward__BackingField;

	[Token(Token = "0x400200D")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<TutorialDataBase> _003C_003Ef__am_0024cacheB;

	[Token(Token = "0x17000809")]
	public int NotClearedReward
	{
		[Token(Token = "0x6003721")]
		[Address(RVA = "0x1D59938", Offset = "0x1D59938", VA = "0x1D59938")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003722")]
		[Address(RVA = "0x1D59940", Offset = "0x1D59940", VA = "0x1D59940")]
		private set
		{
		}
	}

	[Token(Token = "0x6003720")]
	[Address(RVA = "0x1D597C8", Offset = "0x1D597C8", VA = "0x1D597C8")]
	public TutorialGroup(int tutorialID)
	{
	}

	[Token(Token = "0x6003723")]
	[Address(RVA = "0x1D59948", Offset = "0x1D59948", VA = "0x1D59948")]
	public void Sort()
	{
	}

	[Token(Token = "0x6003724")]
	[Address(RVA = "0x1D59BE0", Offset = "0x1D59BE0", VA = "0x1D59BE0")]
	public void SetPrevTutorialRewardUp(int rewardCnt)
	{
	}

	[Token(Token = "0x6003725")]
	[Address(RVA = "0x1D59BE8", Offset = "0x1D59BE8", VA = "0x1D59BE8")]
	public void Add(TutorialInfo info)
	{
	}

	[Token(Token = "0x6003726")]
	[Address(RVA = "0x1D5ACD8", Offset = "0x1D5ACD8", VA = "0x1D5ACD8")]
	public bool TryGetIndexInGroup(int order, out int groupID, out int index)
	{
		groupID = default;
		index = default;
		return default(bool);
	}

	[Token(Token = "0x6003727")]
	[Address(RVA = "0x1D5AF64", Offset = "0x1D5AF64", VA = "0x1D5AF64")]
	public string GetStartSceneByOrder(int order)
	{
		return null;
	}

	[Token(Token = "0x6003728")]
	[Address(RVA = "0x1D5B04C", Offset = "0x1D5B04C", VA = "0x1D5B04C")]
	public string GetStartSceneByGroup(int group)
	{
		return null;
	}

	[Token(Token = "0x6003729")]
	[Address(RVA = "0x1D5B07C", Offset = "0x1D5B07C", VA = "0x1D5B07C")]
	public int GetFirstOrderInGroup(int groupID)
	{
		return default(int);
	}

	[Token(Token = "0x600372A")]
	[Address(RVA = "0x1D5B19C", Offset = "0x1D5B19C", VA = "0x1D5B19C")]
	public bool ForceGroupSkipable(int order)
	{
		return default(bool);
	}

	[Token(Token = "0x600372B")]
	[Address(RVA = "0x1D5B23C", Offset = "0x1D5B23C", VA = "0x1D5B23C")]
	public int GetRewardUp(int groupID, int index)
	{
		return default(int);
	}

	[Token(Token = "0x600372C")]
	[Address(RVA = "0x1D5B7A8", Offset = "0x1D5B7A8", VA = "0x1D5B7A8")]
	public bool TryGetShowBG(int groupID, int index, out string bgPath)
	{
		bgPath = default;
		return default(bool);
	}

	[Token(Token = "0x600372D")]
	[Address(RVA = "0x1D5B5A4", Offset = "0x1D5B5A4", VA = "0x1D5B5A4")]
	private int GetArgToInt(int order)
	{
		return default(int);
	}

	[Token(Token = "0x600372E")]
	[Address(RVA = "0x1D5B6B0", Offset = "0x1D5B6B0", VA = "0x1D5B6B0")]
	public int GetRewardFinalUp()
	{
		return default(int);
	}

	[Token(Token = "0x600372F")]
	[Address(RVA = "0x1D5BB00", Offset = "0x1D5BB00", VA = "0x1D5BB00")]
	public TutorialDataBase GetTutorialData(int order)
	{
		return null;
	}

	[Token(Token = "0x6003730")]
	[Address(RVA = "0x1D5BC04", Offset = "0x1D5BC04", VA = "0x1D5BC04")]
	public int GetLastGroup()
	{
		return default(int);
	}

	[Token(Token = "0x6003731")]
	[Address(RVA = "0x1D5BC44", Offset = "0x1D5BC44", VA = "0x1D5BC44")]
	private static int _003CSort_003Em__189(TutorialDataBase a, TutorialDataBase b)
	{
		return default(int);
	}
}
