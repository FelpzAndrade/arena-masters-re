using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200092C")]
	public class PVPLogic
	{
		[Token(Token = "0x200092D")]
		public class PvpReward
		{
			[Token(Token = "0x4002D7C")]
			[FieldOffset(Offset = "0x8")]
			public int teamExp;

			[Token(Token = "0x4002D7D")]
			[FieldOffset(Offset = "0xC")]
			public int combatPoint;

			[Token(Token = "0x4002D7E")]
			[FieldOffset(Offset = "0x10")]
			public int characterPoint;

			[Token(Token = "0x4002D7F")]
			[FieldOffset(Offset = "0x14")]
			public CSContent[] lotteryRewards;

			[Token(Token = "0x4002D80")]
			[FieldOffset(Offset = "0x18")]
			public int victoryPoint;

			[Token(Token = "0x600493A")]
			[Address(RVA = "0x21BB8CC", Offset = "0x21BB8CC", VA = "0x21BB8CC")]
			public PvpReward()
			{
			}
		}

		[Token(Token = "0x200092E")]
		public enum ResetPeriod
		{
			[Token(Token = "0x4002D82")]
			None = 0,
			[Token(Token = "0x4002D83")]
			Day = 1,
			[Token(Token = "0x4002D84")]
			Week = 2
		}

		[Token(Token = "0x200092F")]
		public abstract class Mode
		{
		protected Mode()
		{
		}

			[Token(Token = "0x4002D85")]
			[FieldOffset(Offset = "0x8")]
			protected ProtoInfoManager_GameModeInstance m_protoGameModeInstance;

			[Token(Token = "0x4002D86")]
			[FieldOffset(Offset = "0xC")]
			protected CSProtoInfoManager_GameConst m_protoGameConst;

			[Token(Token = "0x4002D87")]
			[FieldOffset(Offset = "0x10")]
			protected CSProtoInfoManager_GameModeReward m_protoGameModeReward;

			[Token(Token = "0x600493B")]
			[Address(RVA = "0x21BB88C", Offset = "0x21BB88C", VA = "0x21BB88C")]
			public Mode(ProtoInfoManager_GameModeInstance protoGameModeInstance, CSProtoInfoManager_GameConst protoGameConst, CSProtoInfoManager_GameModeReward protoGameModeReward)
			{
			}

			[Token(Token = "0x600493C")]
			[Address(RVA = "0x21BB8BC", Offset = "0x21BB8BC", VA = "0x21BB8BC", Slot = "4")]
			public virtual ResetPeriod GetResetPeriod()
			{
				return default(ResetPeriod);
			}

			[Token(Token = "0x600493D")]
			[Address(RVA = "0x21BB8C4", Offset = "0x21BB8C4", VA = "0x21BB8C4", Slot = "5")]
			public virtual XGameModeType GetModeType()
			{
				return default(XGameModeType);
			}

			[Token(Token = "0x600493E")]
			[Address(RVA = "0x21BB464", Offset = "0x21BB464", VA = "0x21BB464")]
			public ApiReturnCode GetRewardsOnCompleteGame(int userLevel, int modeInstanceID, CSWinlose winlose, int ranking, out PvpReward reward, int fatigue)
			{
				reward = default;
				return default(ApiReturnCode);
			}

			[Token(Token = "0x600493F")]
			[Address(RVA = "0x21BB8D4", Offset = "0x21BB8D4", VA = "0x21BB8D4", Slot = "6")]
			public virtual bool GetRewardTeamExp(int userLevel, int modeInstanceID, CSWinlose winlose, int ranking, ref PvpReward reward, int fatigue)
			{
				return default(bool);
			}

			[Token(Token = "0x6004940")]
			[Address(RVA = "0x21BBAE8", Offset = "0x21BBAE8", VA = "0x21BBAE8")]
			protected void UpdatePVPReward(int modeInstanceID, int ranking, ref PvpReward reward)
			{
			}

			[Token(Token = "0x6004941")]
			[Address(RVA = "0x21BBCB4", Offset = "0x21BBCB4", VA = "0x21BBCB4")]
			protected CSContent[] GetContentsRewards(int userLevel, int modeInstanceID, int ranking, int fatigue)
			{
				return null;
			}

			[Token(Token = "0x6004942")]
			public abstract CSContent[] GetContentsRewards(int userLevel, int modeInstanceID, CSWinlose winlose, int ranking, DateTime dateNowTime, int fatigue);

			[Token(Token = "0x6004943")]
			[Address(RVA = "0x21BC684", Offset = "0x21BC684", VA = "0x21BC684", Slot = "8")]
			public virtual int CalcGameScore(CSWinlose winlose, GameModeInfo gameModeInfo, PlayerGameRecord record)
			{
				return default(int);
			}

			[Token(Token = "0x6004944")]
			[Address(RVA = "0x21BC6F0", Offset = "0x21BC6F0", VA = "0x21BC6F0", Slot = "9")]
			public virtual ApiReturnCode CanEnterByDailyEnterCount(UserDataBase data, XGameModeType type)
			{
				return default(ApiReturnCode);
			}
		}

		[Token(Token = "0x2000930")]
		public class None : Mode
		{
			[Token(Token = "0x6004945")]
			[Address(RVA = "0x21B9F00", Offset = "0x21B9F00", VA = "0x21B9F00")]
			public None(ProtoInfoManager_GameModeInstance protoMission, CSProtoInfoManager_GameConst protoGameConst, CSProtoInfoManager_GameModeReward protoGameModeReward)
			{
			}

			[Token(Token = "0x6004946")]
			[Address(RVA = "0x21BC6F8", Offset = "0x21BC6F8", VA = "0x21BC6F8", Slot = "7")]
			public override CSContent[] GetContentsRewards(int userLevel, int modeInstanceID, CSWinlose winlose, int ranking, DateTime dateNowTime, int fatigue)
			{
				return null;
			}
		}

		[Token(Token = "0x2000931")]
		public class SinglesMode : Mode
		{
		protected SinglesMode()
		{
		}

			[Token(Token = "0x6004947")]
			[Address(RVA = "0x21BB7CC", Offset = "0x21BB7CC", VA = "0x21BB7CC")]
			public SinglesMode(ProtoInfoManager_GameModeInstance protoMission, CSProtoInfoManager_GameConst protoGameConst, CSProtoInfoManager_GameModeReward protoGameModeReward)
			{
			}

			[Token(Token = "0x6004948")]
			[Address(RVA = "0x21BC768", Offset = "0x21BC768", VA = "0x21BC768", Slot = "6")]
			public override bool GetRewardTeamExp(int userLevel, int modeInstanceID, CSWinlose winlose, int ranking, ref PvpReward reward, int fatigue)
			{
				return default(bool);
			}

			[Token(Token = "0x6004949")]
			[Address(RVA = "0x21BC7C8", Offset = "0x21BC7C8", VA = "0x21BC7C8", Slot = "7")]
			public override CSContent[] GetContentsRewards(int userLevel, int modeInstanceID, CSWinlose winlose, int ranking, DateTime dateNowTime, int fatigue)
			{
				return null;
			}
		}

		[Token(Token = "0x2000932")]
		public class TeamMode : Mode
		{
		protected TeamMode()
		{
		}

			[Token(Token = "0x600494A")]
			[Address(RVA = "0x21BB784", Offset = "0x21BB784", VA = "0x21BB784")]
			public TeamMode(ProtoInfoManager_GameModeInstance protoMission, CSProtoInfoManager_GameConst protoGameConst, CSProtoInfoManager_GameModeReward protoGameModeReward)
			{
			}

			[Token(Token = "0x600494B")]
			[Address(RVA = "0x21BC7F4", Offset = "0x21BC7F4", VA = "0x21BC7F4", Slot = "6")]
			public override bool GetRewardTeamExp(int userLevel, int modeInstanceID, CSWinlose winlose, int ranking, ref PvpReward reward, int fatigue)
			{
				return default(bool);
			}

			[Token(Token = "0x600494C")]
			[Address(RVA = "0x21BC854", Offset = "0x21BC854", VA = "0x21BC854", Slot = "7")]
			public override CSContent[] GetContentsRewards(int userLevel, int modeInstanceID, CSWinlose winlose, int ranking, DateTime dateNowTime, int fatigue)
			{
				return null;
			}
		}

		[Token(Token = "0x2000933")]
		public sealed class Zombie : SinglesMode
		{
			[Token(Token = "0x600494D")]
			[Address(RVA = "0x21B9FF0", Offset = "0x21B9FF0", VA = "0x21B9FF0")]
			public Zombie(ProtoInfoManager_GameModeInstance protoMission, CSProtoInfoManager_GameConst protoGameConst, CSProtoInfoManager_GameModeReward protoGameModeReward)
			{
			}

			[Token(Token = "0x600494E")]
			[Address(RVA = "0x21BC880", Offset = "0x21BC880", VA = "0x21BC880", Slot = "5")]
			public override XGameModeType GetModeType()
			{
				return default(XGameModeType);
			}

			[Token(Token = "0x600494F")]
			[Address(RVA = "0x21BC888", Offset = "0x21BC888", VA = "0x21BC888", Slot = "8")]
			public override int CalcGameScore(CSWinlose winlose, GameModeInfo gameModeInfo, PlayerGameRecord record)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000934")]
		public sealed class DeathMatch : SinglesMode
		{
			[Token(Token = "0x6004950")]
			[Address(RVA = "0x21B9F30", Offset = "0x21B9F30", VA = "0x21B9F30")]
			public DeathMatch(ProtoInfoManager_GameModeInstance protoMission, CSProtoInfoManager_GameConst protoGameConst, CSProtoInfoManager_GameModeReward protoGameModeReward)
			{
			}

			[Token(Token = "0x6004951")]
			[Address(RVA = "0x21BB7FC", Offset = "0x21BB7FC", VA = "0x21BB7FC", Slot = "5")]
			public override XGameModeType GetModeType()
			{
				return default(XGameModeType);
			}
		}

		[Token(Token = "0x2000935")]
		public sealed class TeamDeathMatch : TeamMode
		{
			[Token(Token = "0x6004952")]
			[Address(RVA = "0x21B9F60", Offset = "0x21B9F60", VA = "0x21B9F60")]
			public TeamDeathMatch(ProtoInfoManager_GameModeInstance protoMission, CSProtoInfoManager_GameConst protoGameConst, CSProtoInfoManager_GameModeReward protoGameModeReward)
			{
			}

			[Token(Token = "0x6004953")]
			[Address(RVA = "0x21BC7EC", Offset = "0x21BC7EC", VA = "0x21BC7EC", Slot = "5")]
			public override XGameModeType GetModeType()
			{
				return default(XGameModeType);
			}
		}

		[Token(Token = "0x2000936")]
		public sealed class CapturePointA : TeamMode
		{
			[Token(Token = "0x6004954")]
			[Address(RVA = "0x21B9F90", Offset = "0x21B9F90", VA = "0x21B9F90")]
			public CapturePointA(ProtoInfoManager_GameModeInstance protoMission, CSProtoInfoManager_GameConst protoGameConst, CSProtoInfoManager_GameModeReward protoGameModeReward)
			{
			}

			[Token(Token = "0x6004955")]
			[Address(RVA = "0x21BB7BC", Offset = "0x21BB7BC", VA = "0x21BB7BC", Slot = "5")]
			public override XGameModeType GetModeType()
			{
				return default(XGameModeType);
			}
		}

		[Token(Token = "0x2000937")]
		public sealed class ZombieTag : TeamMode
		{
			[Token(Token = "0x6004956")]
			[Address(RVA = "0x21B9FC0", Offset = "0x21B9FC0", VA = "0x21B9FC0")]
			public ZombieTag(ProtoInfoManager_GameModeInstance protoMission, CSProtoInfoManager_GameConst protoGameConst, CSProtoInfoManager_GameModeReward protoGameModeReward)
			{
			}

			[Token(Token = "0x6004957")]
			[Address(RVA = "0x21BC908", Offset = "0x21BC908", VA = "0x21BC908", Slot = "5")]
			public override XGameModeType GetModeType()
			{
				return default(XGameModeType);
			}
		}

		[Token(Token = "0x2000938")]
		public sealed class Duel : TeamMode
		{
			[Token(Token = "0x6004958")]
			[Address(RVA = "0x21BA020", Offset = "0x21BA020", VA = "0x21BA020")]
			public Duel(ProtoInfoManager_GameModeInstance protoMission, CSProtoInfoManager_GameConst protoGameConst, CSProtoInfoManager_GameModeReward protoGameModeReward)
			{
			}

			[Token(Token = "0x6004959")]
			[Address(RVA = "0x21BB80C", Offset = "0x21BB80C", VA = "0x21BB80C", Slot = "5")]
			public override XGameModeType GetModeType()
			{
				return default(XGameModeType);
			}
		}

		[Token(Token = "0x2000939")]
		public sealed class Annihilation : TeamMode
		{
			[Token(Token = "0x600495A")]
			[Address(RVA = "0x21BA050", Offset = "0x21BA050", VA = "0x21BA050")]
			public Annihilation(ProtoInfoManager_GameModeInstance protoMission, CSProtoInfoManager_GameConst protoGameConst, CSProtoInfoManager_GameModeReward protoGameModeReward)
			{
			}

			[Token(Token = "0x600495B")]
			[Address(RVA = "0x21BB7B4", Offset = "0x21BB7B4", VA = "0x21BB7B4", Slot = "5")]
			public override XGameModeType GetModeType()
			{
				return default(XGameModeType);
			}
		}

		[Token(Token = "0x200093A")]
		public sealed class Classic : TeamMode
		{
			[Token(Token = "0x600495C")]
			[Address(RVA = "0x21BA080", Offset = "0x21BA080", VA = "0x21BA080")]
			public Classic(ProtoInfoManager_GameModeInstance protoMission, CSProtoInfoManager_GameConst protoGameConst, CSProtoInfoManager_GameModeReward protoGameModeReward)
			{
			}

			[Token(Token = "0x600495D")]
			[Address(RVA = "0x21BB7C4", Offset = "0x21BB7C4", VA = "0x21BB7C4", Slot = "5")]
			public override XGameModeType GetModeType()
			{
				return default(XGameModeType);
			}
		}

		[Token(Token = "0x200093B")]
		public sealed class Zombie2 : TeamMode
		{
			[Token(Token = "0x600495E")]
			[Address(RVA = "0x21BA0B0", Offset = "0x21BA0B0", VA = "0x21BA0B0")]
			public Zombie2(ProtoInfoManager_GameModeInstance protoMission, CSProtoInfoManager_GameConst protoGameConst, CSProtoInfoManager_GameModeReward protoGameModeReward)
			{
			}

			[Token(Token = "0x600495F")]
			[Address(RVA = "0x21BC900", Offset = "0x21BC900", VA = "0x21BC900", Slot = "5")]
			public override XGameModeType GetModeType()
			{
				return default(XGameModeType);
			}
		}

		[Token(Token = "0x200093C")]
		public sealed class KOF : TeamMode
		{
			[Token(Token = "0x6004960")]
			[Address(RVA = "0x21BA0E0", Offset = "0x21BA0E0", VA = "0x21BA0E0")]
			public KOF(ProtoInfoManager_GameModeInstance protoMission, CSProtoInfoManager_GameConst protoGameConst, CSProtoInfoManager_GameModeReward protoGameModeReward)
			{
			}

			[Token(Token = "0x6004961")]
			[Address(RVA = "0x21BB884", Offset = "0x21BB884", VA = "0x21BB884", Slot = "5")]
			public override XGameModeType GetModeType()
			{
				return default(XGameModeType);
			}
		}

		[Token(Token = "0x200093D")]
		public sealed class PoliceVsThief : TeamMode
		{
			[Token(Token = "0x6004962")]
			[Address(RVA = "0x21BA110", Offset = "0x21BA110", VA = "0x21BA110")]
			public PoliceVsThief(ProtoInfoManager_GameModeInstance protoMission, CSProtoInfoManager_GameConst protoGameConst, CSProtoInfoManager_GameModeReward protoGameModeReward)
			{
			}

			[Token(Token = "0x6004963")]
			[Address(RVA = "0x21BC700", Offset = "0x21BC700", VA = "0x21BC700", Slot = "5")]
			public override XGameModeType GetModeType()
			{
				return default(XGameModeType);
			}

			[Token(Token = "0x6004964")]
			[Address(RVA = "0x21BC708", Offset = "0x21BC708", VA = "0x21BC708", Slot = "8")]
			public override int CalcGameScore(CSWinlose winlose, GameModeInfo gameModeInfo, PlayerGameRecord record)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200093E")]
		public sealed class HideAndSeek : SinglesMode
		{
			[Token(Token = "0x4002D88")]
			[FieldOffset(Offset = "0x14")]
			private int HPRatioScore;

			[Token(Token = "0x4002D89")]
			[FieldOffset(Offset = "0x18")]
			private int TagScore;

			[Token(Token = "0x4002D8A")]
			[FieldOffset(Offset = "0x1C")]
			private int ItemGetScore;

			[Token(Token = "0x4002D8B")]
			[FieldOffset(Offset = "0x20")]
			private int SurviveScore;

			[Token(Token = "0x6004965")]
			[Address(RVA = "0x21BA140", Offset = "0x21BA140", VA = "0x21BA140")]
			public HideAndSeek(ProtoInfoManager_GameModeInstance protoMission, CSProtoInfoManager_GameConst protoGameConst, CSProtoInfoManager_GameModeReward protoGameModeReward, ProtoInfoManager_GameMode protoGameMode)
			{
			}

			[Token(Token = "0x6004966")]
			[Address(RVA = "0x21BB814", Offset = "0x21BB814", VA = "0x21BB814", Slot = "5")]
			public override XGameModeType GetModeType()
			{
				return default(XGameModeType);
			}

			[Token(Token = "0x6004967")]
			[Address(RVA = "0x21BB81C", Offset = "0x21BB81C", VA = "0x21BB81C", Slot = "8")]
			public override int CalcGameScore(CSWinlose winlose, GameModeInfo gameModeInfo, PlayerGameRecord record)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200093F")]
		public sealed class TreasureHunter : TeamMode
		{
			[Token(Token = "0x6004968")]
			[Address(RVA = "0x21BA300", Offset = "0x21BA300", VA = "0x21BA300")]
			public TreasureHunter(ProtoInfoManager_GameModeInstance protoMission, CSProtoInfoManager_GameConst protoGameConst, CSProtoInfoManager_GameModeReward protoGameModeReward)
			{
			}

			[Token(Token = "0x6004969")]
			[Address(RVA = "0x21BC878", Offset = "0x21BC878", VA = "0x21BC878", Slot = "5")]
			public override XGameModeType GetModeType()
			{
				return default(XGameModeType);
			}
		}

		[Token(Token = "0x2000940")]
		public sealed class Defense : TeamMode
		{
			[Token(Token = "0x600496A")]
			[Address(RVA = "0x21BA330", Offset = "0x21BA330", VA = "0x21BA330")]
			public Defense(ProtoInfoManager_GameModeInstance protoMission, CSProtoInfoManager_GameConst protoGameConst, CSProtoInfoManager_GameModeReward protoGameModeReward)
			{
			}

			[Token(Token = "0x600496B")]
			[Address(RVA = "0x21BB804", Offset = "0x21BB804", VA = "0x21BB804", Slot = "5")]
			public override XGameModeType GetModeType()
			{
				return default(XGameModeType);
			}
		}

		[Token(Token = "0x4002D67")]
		[FieldOffset(Offset = "0x8")]
		private Mode m_none;

		[Token(Token = "0x4002D68")]
		[FieldOffset(Offset = "0xC")]
		private Mode m_deathMatch;

		[Token(Token = "0x4002D69")]
		[FieldOffset(Offset = "0x10")]
		private Mode m_teamDeathMatch;

		[Token(Token = "0x4002D6A")]
		[FieldOffset(Offset = "0x14")]
		private Mode m_capturePointA;

		[Token(Token = "0x4002D6B")]
		[FieldOffset(Offset = "0x18")]
		private Mode m_zombieTag;

		[Token(Token = "0x4002D6C")]
		[FieldOffset(Offset = "0x1C")]
		private Mode m_zombie;

		[Token(Token = "0x4002D6D")]
		[FieldOffset(Offset = "0x20")]
		private Mode m_duel;

		[Token(Token = "0x4002D6E")]
		[FieldOffset(Offset = "0x24")]
		private Mode m_Annihilation;

		[Token(Token = "0x4002D6F")]
		[FieldOffset(Offset = "0x28")]
		private Mode m_classic;

		[Token(Token = "0x4002D70")]
		[FieldOffset(Offset = "0x2C")]
		private Mode m_zombie2;

		[Token(Token = "0x4002D71")]
		[FieldOffset(Offset = "0x30")]
		private Mode m_kof;

		[Token(Token = "0x4002D72")]
		[FieldOffset(Offset = "0x34")]
		private Mode m_policeVsThief;

		[Token(Token = "0x4002D73")]
		[FieldOffset(Offset = "0x38")]
		private Mode m_hideAndSeek;

		[Token(Token = "0x4002D74")]
		[FieldOffset(Offset = "0x3C")]
		private Mode m_treasureHunter;

		[Token(Token = "0x4002D75")]
		[FieldOffset(Offset = "0x40")]
		private Mode m_defense;

		[Token(Token = "0x4002D76")]
		[FieldOffset(Offset = "0x44")]
		private ProtoInfoManager_GameModeInstance m_protoGameModeInstance;

		[Token(Token = "0x4002D77")]
		[FieldOffset(Offset = "0x48")]
		private CSProtoInfoManager_GameConst m_protoGameConst;

		[Token(Token = "0x4002D78")]
		[FieldOffset(Offset = "0x4C")]
		private CSProtoInfoManager_PvpReward m_protoPvpReward;

		[Token(Token = "0x4002D79")]
		[FieldOffset(Offset = "0x50")]
		private ProtoInfoManager_GameMode m_protoGameModeInfo;

		[Token(Token = "0x4002D7A")]
		[FieldOffset(Offset = "0x54")]
		private CSProtoInfoManager_GameModeReward m_protoGameModeReward;

		[Token(Token = "0x4002D7B")]
		[FieldOffset(Offset = "0x58")]
		private bool IsLadder__BackingField;

		[Token(Token = "0x170009CC")]
		public bool IsLadder
		{
			[Token(Token = "0x6004926")]
			[Address(RVA = "0x21BA360", Offset = "0x21BA360", VA = "0x21BA360")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004927")]
			[Address(RVA = "0x21BA368", Offset = "0x21BA368", VA = "0x21BA368")]
			private set
			{
			}
		}

		[Token(Token = "0x6004925")]
		[Address(RVA = "0x21B9B88", Offset = "0x21B9B88", VA = "0x21B9B88")]
		public PVPLogic(ProtoInfoManager_GameModeInstance protoGameModeInstance, ProtoInfoManager_GameMode protoGameModeInfo, CSProtoInfoManager_GameConst protoGameConst, CSProtoInfoManager_PvpReward protoPvpReward, CSProtoInfoManager_GameModeReward protoGameModeReward)
		{
		}

		[Token(Token = "0x6004928")]
		[Address(RVA = "0x21BA370", Offset = "0x21BA370", VA = "0x21BA370")]
		public Mode Select(XGameModeType mode)
		{
			return null;
		}

		[Token(Token = "0x6004929")]
		[Address(RVA = "0x21BA600", Offset = "0x21BA600", VA = "0x21BA600")]
		public CSPvpRewardInfo GetCombatPointRewardInfo(UserDataBase userData)
		{
			return null;
		}

		[Token(Token = "0x600492A")]
		[Address(RVA = "0x21BA790", Offset = "0x21BA790", VA = "0x21BA790")]
		public CSPvpRewardInfo XGetCombatPointRewardInfoForUI(UserDataBase userData)
		{
			return null;
		}

		[Token(Token = "0x600492B")]
		[Address(RVA = "0x21BA944", Offset = "0x21BA944", VA = "0x21BA944")]
		public static int GetCombatMissionRewardTotalCount(UserDataBase userData, CSProtoInfoManager_PvpReward protoPvpReward)
		{
			return default(int);
		}

		[Token(Token = "0x600492C")]
		[Address(RVA = "0x21BAA18", Offset = "0x21BAA18", VA = "0x21BAA18")]
		public static int GetCurrentCombatMissionIndex(UserDataBase userData)
		{
			return default(int);
		}

		[Token(Token = "0x600492D")]
		[Address(RVA = "0x21BAB5C", Offset = "0x21BAB5C", VA = "0x21BAB5C")]
		public bool IsAllDailyCombatPointRewardDone(UserDataBase userData)
		{
			return default(bool);
		}

		[Token(Token = "0x600492E")]
		[Address(RVA = "0x21BAB7C", Offset = "0x21BAB7C", VA = "0x21BAB7C")]
		public bool CanTakeReward(UserDataBase data, CSPvpRewardInfo reward)
		{
			return default(bool);
		}

		[Token(Token = "0x600492F")]
		[Address(RVA = "0x21BABC8", Offset = "0x21BABC8", VA = "0x21BABC8")]
		public void IncreaseCombatPointReward(UserDataBase data)
		{
		}

		[Token(Token = "0x6004930")]
		[Address(RVA = "0x21BAD1C", Offset = "0x21BAD1C", VA = "0x21BAD1C")]
		public int CalcGameScore(XGameModeType modeType, GameModeInfo gameModeInfo, CSWinlose winlose, PlayerGameRecord record)
		{
			return default(int);
		}

		[Token(Token = "0x6004931")]
		[Address(RVA = "0x21BADB0", Offset = "0x21BADB0", VA = "0x21BADB0")]
		public ApiReturnCode CanEnterByDailyEnterCount(UserDataBase data, XGameModeType type)
		{
			return default(ApiReturnCode);
		}

		[Token(Token = "0x6004932")]
		[Address(RVA = "0x21BAE20", Offset = "0x21BAE20", VA = "0x21BAE20")]
		public KeyValuePair<Currency, int> GetMissionEnterCost(GameModeInstanceInfo gameModeInstanceInfo)
		{
			return default(KeyValuePair<Currency, int>);
		}

		[Token(Token = "0x6004933")]
		[Address(RVA = "0x21BAF20", Offset = "0x21BAF20", VA = "0x21BAF20")]
		public KeyValuePair<Currency, int> GetMissionStartCost(GameModeInstanceInfo gameModeInstanceInfo, bool isDefector)
		{
			return default(KeyValuePair<Currency, int>);
		}

		[Token(Token = "0x6004934")]
		[Address(RVA = "0x21BB040", Offset = "0x21BB040", VA = "0x21BB040")]
		public KeyValuePair<Currency, int> GetMissionCompleteCost(int modeInstanceID)
		{
			return default(KeyValuePair<Currency, int>);
		}

		[Token(Token = "0x6004935")]
		[Address(RVA = "0x21BB264", Offset = "0x21BB264", VA = "0x21BB264")]
		public bool HasEnoughStamina(GameModeInstanceInfo gameModeInstanceInfo, int userStamina, bool isDefector)
		{
			return default(bool);
		}

		[Token(Token = "0x6004936")]
		[Address(RVA = "0x21BB2BC", Offset = "0x21BB2BC", VA = "0x21BB2BC")]
		public CSContent[] GetContentsLotteryRewards_Client(int userLevel, int modeInstanceID, XGameModeType type, CSWinlose winlose, int ranking, int fatigue)
		{
			return null;
		}

		[Token(Token = "0x6004937")]
		[Address(RVA = "0x21BB410", Offset = "0x21BB410", VA = "0x21BB410")]
		public ApiReturnCode GetRewardsOnCompleteGame(int userLevel, int modeInstanceID, XGameModeType type, CSWinlose winlose, int ranking, out PvpReward reward, int fatigue)
		{
			reward = default;
			return default(ApiReturnCode);
		}

		[Token(Token = "0x6004938")]
		[Address(RVA = "0x21BB654", Offset = "0x21BB654", VA = "0x21BB654")]
		public int RollSectorID(GameModeInstanceInfo gameModeInstanceInfo)
		{
			return default(int);
		}

		[Token(Token = "0x6004939")]
		[Address(RVA = "0x21BB768", Offset = "0x21BB768", VA = "0x21BB768")]
		public static bool IsFatigueMatchType(MatchType matchType)
		{
			return default(bool);
		}
	}
}
