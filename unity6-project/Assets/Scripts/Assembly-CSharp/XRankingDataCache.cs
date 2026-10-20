using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2001010")]
public class XRankingDataCache
{
	[Token(Token = "0x2001011")]
	private enum RankListType
	{
		[Token(Token = "0x4005608")]
		none = 0,
		[Token(Token = "0x4005609")]
		prevDuel = 1,
		[Token(Token = "0x400560A")]
		prevTeam = 2,
		[Token(Token = "0x400560B")]
		prevClan = 3,
		[Token(Token = "0x400560C")]
		currentDuel = 4,
		[Token(Token = "0x400560D")]
		currentTeam = 5,
		[Token(Token = "0x400560E")]
		currentClan = 6,
		[Token(Token = "0x400560F")]
		end = 7
	}

	[Token(Token = "0x2001012")]
	public enum RankReceiveType
	{
		[Token(Token = "0x4005611")]
		None = 0,
		[Token(Token = "0x4005612")]
		False = 1,
		[Token(Token = "0x4005613")]
		True = 2
	}

	[Token(Token = "0x2001013")]
	public class MyRankData
	{
		[Token(Token = "0x4005614")]
		[FieldOffset(Offset = "0x8")]
		private RankReceiveType m_ReceivedReward;

		[Token(Token = "0x4005615")]
		[FieldOffset(Offset = "0xC")]
		private ApiReturnCode ApiCode__BackingField;

		[Token(Token = "0x4005616")]
		[FieldOffset(Offset = "0x10")]
		private Netdata_Ranker RankData__BackingField;

		[Token(Token = "0x4005617")]
		[FieldOffset(Offset = "0x18")]
		private DateTime DateTime__BackingField;

		[Token(Token = "0x17000EED")]
		public ApiReturnCode ApiCode
		{
			[Token(Token = "0x60077E5")]
			[Address(RVA = "0x1CA027C", Offset = "0x1CA027C", VA = "0x1CA027C")]
			get
			{
				return default(ApiReturnCode);
			}
			[Token(Token = "0x60077E6")]
			[Address(RVA = "0x1CA0254", Offset = "0x1CA0254", VA = "0x1CA0254")]
			private set
			{
			}
		}

		[Token(Token = "0x17000EEE")]
		public Netdata_Ranker RankData
		{
			[Token(Token = "0x60077E7")]
			[Address(RVA = "0x1CA0284", Offset = "0x1CA0284", VA = "0x1CA0284")]
			get
			{
				return null;
			}
			[Token(Token = "0x60077E8")]
			[Address(RVA = "0x1CA025C", Offset = "0x1CA025C", VA = "0x1CA025C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000EEF")]
		public DateTime DateTime
		{
			[Token(Token = "0x60077E9")]
			[Address(RVA = "0x1CA028C", Offset = "0x1CA028C", VA = "0x1CA028C")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60077EA")]
			[Address(RVA = "0x1CA0264", Offset = "0x1CA0264", VA = "0x1CA0264")]
			private set
			{
			}
		}

		[Token(Token = "0x17000EF0")]
		public bool ReceivedReward
		{
			[Token(Token = "0x60077EB")]
			[Address(RVA = "0x1CA029C", Offset = "0x1CA029C", VA = "0x1CA029C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60077E4")]
		[Address(RVA = "0x1CA0204", Offset = "0x1CA0204", VA = "0x1CA0204")]
		public MyRankData(ApiReturnCode apiCode, Netdata_Ranker rankData, DateTime dateTime)
		{
		}

		[Token(Token = "0x60077EC")]
		[Address(RVA = "0x1CA02BC", Offset = "0x1CA02BC", VA = "0x1CA02BC")]
		public void ReceiveReward(RankReceiveType receive)
		{
		}

		[Token(Token = "0x60077ED")]
		[Address(RVA = "0x1CA02C4", Offset = "0x1CA02C4", VA = "0x1CA02C4")]
		public bool IsCacheReceivedReward()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001014")]
	public class MyClanRankData
	{
		[Token(Token = "0x4005618")]
		[FieldOffset(Offset = "0x8")]
		private RankReceiveType m_ReceivedReward;

		[Token(Token = "0x4005619")]
		[FieldOffset(Offset = "0xC")]
		private ApiReturnCode ApiCode__BackingField;

		[Token(Token = "0x400561A")]
		[FieldOffset(Offset = "0x10")]
		private ClanRankMetaData ClanRankData__BackingField;

		[Token(Token = "0x400561B")]
		[FieldOffset(Offset = "0x18")]
		private DateTime DateTime__BackingField;

		[Token(Token = "0x400561C")]
		[FieldOffset(Offset = "0x28")]
		private int ClanRankNum__BackingField;

		[Token(Token = "0x17000EF1")]
		public ApiReturnCode ApiCode
		{
			[Token(Token = "0x60077EF")]
			[Address(RVA = "0x1CA01A4", Offset = "0x1CA01A4", VA = "0x1CA01A4")]
			get
			{
				return default(ApiReturnCode);
			}
			[Token(Token = "0x60077F0")]
			[Address(RVA = "0x1CA0174", Offset = "0x1CA0174", VA = "0x1CA0174")]
			private set
			{
			}
		}

		[Token(Token = "0x17000EF2")]
		public ClanRankMetaData ClanRankData
		{
			[Token(Token = "0x60077F1")]
			[Address(RVA = "0x1CA01AC", Offset = "0x1CA01AC", VA = "0x1CA01AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60077F2")]
			[Address(RVA = "0x1CA017C", Offset = "0x1CA017C", VA = "0x1CA017C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000EF3")]
		public DateTime DateTime
		{
			[Token(Token = "0x60077F3")]
			[Address(RVA = "0x1CA01B4", Offset = "0x1CA01B4", VA = "0x1CA01B4")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60077F4")]
			[Address(RVA = "0x1CA0184", Offset = "0x1CA0184", VA = "0x1CA0184")]
			private set
			{
			}
		}

		[Token(Token = "0x17000EF4")]
		public int ClanRankNum
		{
			[Token(Token = "0x60077F5")]
			[Address(RVA = "0x1CA01C4", Offset = "0x1CA01C4", VA = "0x1CA01C4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60077F6")]
			[Address(RVA = "0x1CA019C", Offset = "0x1CA019C", VA = "0x1CA019C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000EF5")]
		public bool ReceivedReward
		{
			[Token(Token = "0x60077F7")]
			[Address(RVA = "0x1CA01CC", Offset = "0x1CA01CC", VA = "0x1CA01CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60077EE")]
		[Address(RVA = "0x1CA0118", Offset = "0x1CA0118", VA = "0x1CA0118")]
		public MyClanRankData(ApiReturnCode apiCode, ClanRankMetaData clanRankData, DateTime dateTime, int clanRankNum, bool receivedReward)
		{
		}

		[Token(Token = "0x60077F8")]
		[Address(RVA = "0x1CA01EC", Offset = "0x1CA01EC", VA = "0x1CA01EC")]
		public void ReceiveReward(RankReceiveType receive)
		{
		}

		[Token(Token = "0x60077F9")]
		[Address(RVA = "0x1CA01F4", Offset = "0x1CA01F4", VA = "0x1CA01F4")]
		public bool IsCacheReceivedReward()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4005603")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<int, RankingList> cacheRankList;

	[Token(Token = "0x4005604")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<int, MyRankData> cacheMyRankDataList;

	[Token(Token = "0x4005605")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, ClanRankingList> cacheClanRankList;

	[Token(Token = "0x4005606")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<int, MyClanRankData> cacheMyClanRankDataList;

	[Token(Token = "0x60077D5")]
	[Address(RVA = "0x1C9F7C4", Offset = "0x1C9F7C4", VA = "0x1C9F7C4")]
	public XRankingDataCache()
	{
	}

	[Token(Token = "0x60077D6")]
	[Address(RVA = "0x1C9F90C", Offset = "0x1C9F90C", VA = "0x1C9F90C")]
	public void CacheRankList(RankType ranktype, RankListViewType viewType, RankingList rankList)
	{
	}

	[Token(Token = "0x60077D7")]
	[Address(RVA = "0x1C9FA54", Offset = "0x1C9FA54", VA = "0x1C9FA54")]
	public void CacheMyRankData(RankType ranktype, RankListViewType viewType, MyRankData data)
	{
	}

	[Token(Token = "0x60077D8")]
	[Address(RVA = "0x1C9FB48", Offset = "0x1C9FB48", VA = "0x1C9FB48")]
	public void CacheClanRankList(RankListViewType viewType, ClanRankingList rankList)
	{
	}

	[Token(Token = "0x60077D9")]
	[Address(RVA = "0x1C9FC14", Offset = "0x1C9FC14", VA = "0x1C9FC14")]
	public void CacheMyClanRankData(RankListViewType viewType, MyClanRankData data)
	{
	}

	[Token(Token = "0x60077DA")]
	[Address(RVA = "0x1C9FCC8", Offset = "0x1C9FCC8", VA = "0x1C9FCC8")]
	public RankingList GetCachedRankList(RankType ranktype, RankListViewType viewType)
	{
		return null;
	}

	[Token(Token = "0x60077DB")]
	[Address(RVA = "0x1C9FDA8", Offset = "0x1C9FDA8", VA = "0x1C9FDA8")]
	public MyRankData GetCachedMyRankData(RankType ranktype, RankListViewType viewType)
	{
		return null;
	}

	[Token(Token = "0x60077DC")]
	[Address(RVA = "0x1C9FE88", Offset = "0x1C9FE88", VA = "0x1C9FE88")]
	public ClanRankingList GetCachedClanRankList(RankListViewType viewType)
	{
		return null;
	}

	[Token(Token = "0x60077DD")]
	[Address(RVA = "0x1C9FF28", Offset = "0x1C9FF28", VA = "0x1C9FF28")]
	public MyClanRankData GetCachedMyClanRankData(RankListViewType viewType)
	{
		return null;
	}

	[Token(Token = "0x60077DE")]
	[Address(RVA = "0x1C9FFC8", Offset = "0x1C9FFC8", VA = "0x1C9FFC8")]
	public void ClearCurrentRankList()
	{
	}

	[Token(Token = "0x60077DF")]
	[Address(RVA = "0x1C9FA00", Offset = "0x1C9FA00", VA = "0x1C9FA00")]
	private RankListType GetRankListType(RankType ranktype, RankListViewType viewType)
	{
		return default(RankListType);
	}

	[Token(Token = "0x60077E0")]
	[Address(RVA = "0x1C9FBFC", Offset = "0x1C9FBFC", VA = "0x1C9FBFC")]
	private RankListType GetClanRankListType(RankListViewType viewType)
	{
		return default(RankListType);
	}

	[Token(Token = "0x60077E1")]
	private void AddCacheList<T>(int key, T rankList, Dictionary<int, T> dicList)
	{
	}

	[Token(Token = "0x60077E2")]
	private T GetCacheList<T>(int key, Dictionary<int, T> dicList)
	{
		return (T)default;
	}

	[Token(Token = "0x60077E3")]
	private void RemoveCacheList<T>(int key, Dictionary<int, T> dicList)
	{
	}
}
