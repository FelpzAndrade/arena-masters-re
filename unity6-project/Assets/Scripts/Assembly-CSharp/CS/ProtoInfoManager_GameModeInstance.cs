using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000AEE")]
	public class ProtoInfoManager_GameModeInstance : List<GameModeInstanceInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x2000AEF")]
		private sealed class _003CRemoveNotTagedContents_003Ec__AnonStorey155
		{
			[Token(Token = "0x400359F")]
			[FieldOffset(Offset = "0x8")]
			internal CSProtoInfoManagers protos;

			[Token(Token = "0x60050C6")]
			[Address(RVA = "0x21B00D4", Offset = "0x21B00D4", VA = "0x21B00D4")]
			public _003CRemoveNotTagedContents_003Ec__AnonStorey155()
			{
			}

			[Token(Token = "0x60050C7")]
			[Address(RVA = "0x21B1840", Offset = "0x21B1840", VA = "0x21B1840")]
			internal bool _003C_003Em__202(GameModeInstanceInfo info)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400359B")]
		[FieldOffset(Offset = "0x14")]
		private Dictionary<int, GameModeInstanceInfo> m_InstancesByID;

		[Token(Token = "0x400359C")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<MatchType, Dictionary<XGameModeType, GameModeInstanceInfo>> m_InstancesByMatchType;

		[Token(Token = "0x400359D")]
		[FieldOffset(Offset = "0x1C")]
		private Dictionary<MatchType, Dictionary<int, GameModeInstanceInfo>> m_Instances2ByMatchType;

		[Token(Token = "0x400359E")]
		[FieldOffset(Offset = "0x0")]
		private static Predicate<int> _003C_003Ef__am_0024cache3;

		[Token(Token = "0x60050B3")]
		[Address(RVA = "0x21AFBC0", Offset = "0x21AFBC0", VA = "0x21AFBC0")]
		public ProtoInfoManager_GameModeInstance()
		{
		}

		[Token(Token = "0x60050B4")]
		[Address(RVA = "0x21AFD18", Offset = "0x21AFD18", VA = "0x21AFD18", Slot = "33")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x60050B5")]
		[Address(RVA = "0x21AFD28", Offset = "0x21AFD28", VA = "0x21AFD28")]
		private void CookingSectorIDs(GameModeInstanceInfo gameModeInstanceInfo, CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x60050B6")]
		[Address(RVA = "0x21AFFBC", Offset = "0x21AFFBC", VA = "0x21AFFBC", Slot = "35")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x60050B7")]
		[Address(RVA = "0x21B00DC", Offset = "0x21B00DC", VA = "0x21B00DC", Slot = "37")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x60050B8")]
		[Address(RVA = "0x21B09C4", Offset = "0x21B09C4", VA = "0x21B09C4")]
		private Dictionary<XGameModeType, GameModeInstanceInfo> GetTypeDic(MatchType matchType)
		{
			return null;
		}

		[Token(Token = "0x60050B9")]
		[Address(RVA = "0x21B0AAC", Offset = "0x21B0AAC", VA = "0x21B0AAC")]
		private Dictionary<int, GameModeInstanceInfo> GetIdDic(MatchType matchType)
		{
			return null;
		}

		[Token(Token = "0x60050BA")]
		[Address(RVA = "0x21B0B94", Offset = "0x21B0B94", VA = "0x21B0B94", Slot = "38")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x60050BB")]
		[Address(RVA = "0x21B0F58", Offset = "0x21B0F58", VA = "0x21B0F58")]
		public GameModeInstanceInfo GetRankInfo(RankType rankType, MatchType matchType)
		{
			return null;
		}

		[Token(Token = "0x60050BC")]
		[Address(RVA = "0x21B1148", Offset = "0x21B1148", VA = "0x21B1148")]
		public GameModeInstanceInfo GetInfo(MatchType matchType, RankType rankType, XGameModeType gameModeType)
		{
			return null;
		}

		[Token(Token = "0x60050BD")]
		[Address(RVA = "0x21B132C", Offset = "0x21B132C", VA = "0x21B132C")]
		public GameModeInstanceInfo GetInfo(MatchType matchType, XGameModeType gameModeType, bool isFriendlyMatch = false)
		{
			return null;
		}

		[Token(Token = "0x60050BE")]
		[Address(RVA = "0x21B1404", Offset = "0x21B1404", VA = "0x21B1404")]
		public GameModeInstanceInfo GetInfo(XGameModeType type, bool bLadder, bool bAIMode)
		{
			return null;
		}

		[Token(Token = "0x60050BF")]
		[Address(RVA = "0x21B1504", Offset = "0x21B1504", VA = "0x21B1504")]
		public GameModeInstanceInfo GetInfo(int nID)
		{
			return null;
		}

		[Token(Token = "0x60050C0")]
		[Address(RVA = "0x21B14E8", Offset = "0x21B14E8", VA = "0x21B14E8")]
		private MatchType GetMatchTypeByFlag(bool bLadder, bool bAIMode)
		{
			return default(MatchType);
		}

		[Token(Token = "0x60050C1")]
		[Address(RVA = "0x21B15E4", Offset = "0x21B15E4", VA = "0x21B15E4")]
		public List<GameModeInstanceInfo> GetList(bool bLadder, bool bAIMode)
		{
			return null;
		}

		[Token(Token = "0x60050C2")]
		[Address(RVA = "0x21B16BC", Offset = "0x21B16BC", VA = "0x21B16BC")]
		public List<XGameModeType> GetRankMatchModes()
		{
			return null;
		}

		[Token(Token = "0x60050C3")]
		[Address(RVA = "0x21B17E8", Offset = "0x21B17E8", VA = "0x21B17E8")]
		public XGameModeType GetRankGameMode(RankType rankType)
		{
			return default(XGameModeType);
		}

		[Token(Token = "0x60050C4")]
		[Address(RVA = "0x21B180C", Offset = "0x21B180C", VA = "0x21B180C")]
		public XGameModeType GetClanRankGameMode(RankType rankType)
		{
			return default(XGameModeType);
		}

		[Token(Token = "0x60050C5")]
		[Address(RVA = "0x21B1830", Offset = "0x21B1830", VA = "0x21B1830")]
		private static bool _003CCookingSectorIDs_003Em__201(int x)
		{
			return default(bool);
		}
	}
}
