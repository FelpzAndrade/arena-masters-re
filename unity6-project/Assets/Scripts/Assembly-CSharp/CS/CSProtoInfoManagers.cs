using System.Text;
using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B92")]
	public abstract class CSProtoInfoManagers
	{
		[Token(Token = "0x2000B93")]
		public static class DataFilePath
		{
			[Token(Token = "0x4003AD3")]
			public const string AppdataPath = "~/App_Data/GameData/";

			[Token(Token = "0x4003AD4")]
			public const string FilterdataPath = "~/App_Data/FilterData/";

			[Token(Token = "0x4003AD5")]
			public const string GoogleApiPath = "~/App_Data/";

			[Token(Token = "0x4003AD6")]
			public const string Const = "const.xml";

			[Token(Token = "0x4003AD7")]
			public const string Character = "character.xml";

			[Token(Token = "0x4003AD8")]
			public const string Shop = "shop.xml";

			[Token(Token = "0x4003AD9")]
			public const string ArenaShop = "ArenaShop.xml";

			[Token(Token = "0x4003ADA")]
			public const string Skill = "skill.xml";

			[Token(Token = "0x4003ADB")]
			public const string SkillEffect = "skill_effect.xml";

			[Token(Token = "0x4003ADC")]
			public const string SkillSound = "skill_sound.xml";

			[Token(Token = "0x4003ADD")]
			public const string Buff = "buff.xml";

			[Token(Token = "0x4003ADE")]
			public const string BuffEffect = "buff_effect.xml";

			[Token(Token = "0x4003ADF")]
			public const string Balance = "balance.xml";

			[Token(Token = "0x4003AE0")]
			public const string BalanceNpc = "npc_balance.xml";

			[Token(Token = "0x4003AE1")]
			public const string BalanceArenaNpc = "npc_arena_balance.xml";

			[Token(Token = "0x4003AE2")]
			public const string TeamLevel = "team_level.xml";

			[Token(Token = "0x4003AE3")]
			public const string UserInitials = "user_initials.xml";

			[Token(Token = "0x4003AE4")]
			public const string Item = "item.xml";

			[Token(Token = "0x4003AE5")]
			public const string AttendanceBook = "attendance_book.xml";

			[Token(Token = "0x4003AE6")]
			public const string TimeInterval = "time_interval.xml";

			[Token(Token = "0x4003AE7")]
			public const string GameModeInstance = "gamemode_instance.xml";

			[Token(Token = "0x4003AE8")]
			public const string GameMode = "gamemode.xml";

			[Token(Token = "0x4003AE9")]
			public const string LotteryBox = "lottery_box.xml";

			[Token(Token = "0x4003AEA")]
			public const string name_allowedchars = "name_allowedchars.txt";

			[Token(Token = "0x4003AEB")]
			public const string name_illegalwords = "name_illegalwords.txt";

			[Token(Token = "0x4003AEC")]
			public const string RankReward = "rank_reward.xml";

			[Token(Token = "0x4003AED")]
			public const string Event = "event.xml";

			[Token(Token = "0x4003AEE")]
			public const string Stage = "stage.xml";

			[Token(Token = "0x4003AEF")]
			public const string Sector = "sector.xml";

			[Token(Token = "0x4003AF0")]
			public const string ItemSet = "itemSet.xml";

			[Token(Token = "0x4003AF1")]
			public const string ItemDictionary = "itemdictionary.xml";

			[Token(Token = "0x4003AF2")]
			public const string ItemBalance = "item_balance.xml";

			[Token(Token = "0x4003AF3")]
			public const string Quset = "quest.xml";

			[Token(Token = "0x4003AF4")]
			public const string RandomOption = "randomoption.xml";

			[Token(Token = "0x4003AF5")]
			public const string PvpReward = "pvp_reward.xml";

			[Token(Token = "0x4003AF6")]
			public const string Talent = "talent.xml";

			[Token(Token = "0x4003AF7")]
			public const string Relic = "relic.xml";

			[Token(Token = "0x4003AF8")]
			public const string SkillSpecialization = "skillspecialization.xml";

			[Token(Token = "0x4003AF9")]
			public const string Title = "title.xml";

			[Token(Token = "0x4003AFA")]
			public const string Skin = "skin.xml";

			[Token(Token = "0x4003AFB")]
			public const string EventAttendanceBook = "event_attendance_book.xml";

			[Token(Token = "0x4003AFC")]
			public const string TutorialCondition = "tutorial_condition.xml";

			[Token(Token = "0x4003AFD")]
			public const string ClanRankReward = "clan_rank_reward.xml";

			[Token(Token = "0x4003AFE")]
			public const string TrophyReward = "trophyreward.xml";

			[Token(Token = "0x4003AFF")]
			public const string FreeRelicSlot = "freerelicslot.xml";

			[Token(Token = "0x4003B00")]
			public const string EventSystem = "eventsystem.xml";

			[Token(Token = "0x4003B01")]
			public const string GameModeOpen = "gamemode_open.xml";

			[Token(Token = "0x4003B02")]
			public const string PremiumTicket = "premiumticket.xml";

			[Token(Token = "0x4003B03")]
			public const string PandoraBox = "pandora_box.xml";

			[Token(Token = "0x4003B04")]
			public const string GameModeReward = "gamemodereward.xml";

			[Token(Token = "0x4003B05")]
			public const string FirstRankReward = "firstrankreward.xml";

			[Token(Token = "0x4003B06")]
			public const string PakageShop = "packageshop.xml";

			[Token(Token = "0x4003B07")]
			public const string Emoticon = "emoticon.xml";

			[Token(Token = "0x4003B08")]
			public const string LobbyButton = "lobby_button.xml";

			[Token(Token = "0x4003B09")]
			public const string ClanBoxReward = "clan_box_reward.xml";

			[Token(Token = "0x4003B0A")]
			public const string CharacterAnim = "character_anim.xml";

			[Token(Token = "0x4003B0B")]
			public const string CharacterSound = "character_sound.xml";

			[Token(Token = "0x4003B0C")]
			public const string CharacterFreeRotation = "free_rotation.xml";

			[Token(Token = "0x4003B0D")]
			public const string EventGameMode = "event_game_mode.xml";

			[Token(Token = "0x4003B0E")]
			public const string EventGameReward = "event_game_reward.xml";

			[Token(Token = "0x4003B0F")]
			public const string Emblem = "emblem.xml";

			[Token(Token = "0x4003B10")]
			public const string Craft = "craft.xml";

			[Token(Token = "0x4003B11")]
			public const string NewUserBenefits = "new_user_benefits.xml";

			[Token(Token = "0x4003B12")]
			public const string CommonValues = "common_values.xml";

			[Token(Token = "0x4003B13")]
			public const string Abuse = "abuse.xml";

			[Token(Token = "0x4003B14")]
			public const string Country = "country.xml";

			[Token(Token = "0x4003B15")]
			public const string DownloadImg = "download_img.xml";

			[Token(Token = "0x4003B16")]
			public const string GameModeSort = "gamemode_sort.xml";

			[Token(Token = "0x4003B17")]
			public const string Language = "language.xml";

			[Token(Token = "0x4003B18")]
			public const string PackageDetail = "packagedetail.xml";

			[Token(Token = "0x4003B19")]
			public const string ShowBox = "show_box.xml";

			[Token(Token = "0x4003B1A")]
			public const string Tips = "tips.xml";

			[Token(Token = "0x4003B1B")]
			public const string TutorialScript = "tutorial_script.xml";

			[Token(Token = "0x4003B1C")]
			public const string Sound = "sound.xml";

			[Token(Token = "0x4003B1D")]
			public const string KillStreak = "kill_streak.xml";

			[Token(Token = "0x4003B1E")]
			public const string Help = "help.xml";

			[Token(Token = "0x4003B1F")]
			public const string ClanMark = "clan_mark.xml";

			[Token(Token = "0x4003B20")]
			public const string ClanLevel = "clan_level.xml";

			[Token(Token = "0x4003B21")]
			public const string BattleRecord = "battle_record.xml";

			[Token(Token = "0x4003B22")]
			public const string BalancePet = "balancepet.xml";
		}

		[Token(Token = "0x2000B94")]
		private class ProtoInfoTypesComparer : IEqualityComparer<ProtoInfoTypes>
		{
			[Token(Token = "0x60053DF")]
			[Address(RVA = "0x1CCBC44", Offset = "0x1CCBC44", VA = "0x1CCBC44")]
			public ProtoInfoTypesComparer()
			{
			}

			[Token(Token = "0x60053E0")]
			[Address(RVA = "0x1CCFFA4", Offset = "0x1CCFFA4", VA = "0x1CCFFA4", Slot = "4")]
			public bool Equals(ProtoInfoTypes t1, ProtoInfoTypes t2)
			{
				return t1 == t2;
			}

			[Token(Token = "0x60053E1")]
			[Address(RVA = "0x1CCFFB4", Offset = "0x1CCFFB4", VA = "0x1CCFFB4", Slot = "5")]
			public int GetHashCode(ProtoInfoTypes type)
			{
				return (int)type;
			}
		}

		[Token(Token = "0x4003ACF")]
		[FieldOffset(Offset = "0x8")]
		private ContentsTags m_ContentsTags;

		[Token(Token = "0x4003AD0")]
		[FieldOffset(Offset = "0xC")]
		protected object m_lock;

		[Token(Token = "0x4003AD1")]
		[FieldOffset(Offset = "0x10")]
		protected Dictionary<ProtoInfoTypes, CSProtoInfoManagerBase> m_container;

		[Token(Token = "0x4003AD2")]
		[FieldOffset(Offset = "0x14")]
		protected Dictionary<ProtoInfoTypes, CSProtoInfoManagerBase> m_reload_container;

		[Token(Token = "0x17000C2E")]
		public virtual CSProtoInfoManager_Shop shop
		{
			[Token(Token = "0x60053A5")]
			[Address(RVA = "0x1CCDFEC", Offset = "0x1CCDFEC", VA = "0x1CCDFEC", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C2F")]
		public virtual CSProtoInfoManager_ArenaShop ArenaShop
		{
			[Token(Token = "0x60053A6")]
			[Address(RVA = "0x1CCE078", Offset = "0x1CCE078", VA = "0x1CCE078", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C30")]
		public virtual CSProtoInfoManager_IronsMission IronsMission
		{
			[Token(Token = "0x60053A7")]
			[Address(RVA = "0x1CCE104", Offset = "0x1CCE104", VA = "0x1CCE104", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C31")]
		public virtual CSProtoInfoManager_Skill skill
		{
			[Token(Token = "0x60053A8")]
			[Address(RVA = "0x1CCE190", Offset = "0x1CCE190", VA = "0x1CCE190", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C32")]
		public virtual CSProtoInfoManager_SkillEffect skillEffect
		{
			[Token(Token = "0x60053A9")]
			[Address(RVA = "0x1CCE21C", Offset = "0x1CCE21C", VA = "0x1CCE21C", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C33")]
		public virtual CSProtoInfoManager_Buff buff
		{
			[Token(Token = "0x60053AA")]
			[Address(RVA = "0x1CCE2A8", Offset = "0x1CCE2A8", VA = "0x1CCE2A8", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C34")]
		public virtual CSProtoInfoManager_BuffEffect buffEffect
		{
			[Token(Token = "0x60053AB")]
			[Address(RVA = "0x1CCE334", Offset = "0x1CCE334", VA = "0x1CCE334", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C35")]
		public virtual CSProtoInfoManager_Character character
		{
			[Token(Token = "0x60053AC")]
			[Address(RVA = "0x1CCE3C0", Offset = "0x1CCE3C0", VA = "0x1CCE3C0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C36")]
		public virtual CSProtoInfoManager_GameConst gameConst
		{
			[Token(Token = "0x60053AD")]
			[Address(RVA = "0x1CCE44C", Offset = "0x1CCE44C", VA = "0x1CCE44C", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C37")]
		public virtual CSProtoInfoManager_Balance balance
		{
			[Token(Token = "0x60053AE")]
			[Address(RVA = "0x1CCE4D8", Offset = "0x1CCE4D8", VA = "0x1CCE4D8", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C38")]
		public virtual CSProtoInfoManager_Balance balanceNpc
		{
			[Token(Token = "0x60053AF")]
			[Address(RVA = "0x1CCE564", Offset = "0x1CCE564", VA = "0x1CCE564", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C39")]
		public virtual CSProtoInfoManager_Balance balanceArenaNPC
		{
			[Token(Token = "0x60053B0")]
			[Address(RVA = "0x1CCE5F0", Offset = "0x1CCE5F0", VA = "0x1CCE5F0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C3A")]
		public virtual CSProtoInfoManager_BalancePet balancePet
		{
			[Token(Token = "0x60053B1")]
			[Address(RVA = "0x1CCE67C", Offset = "0x1CCE67C", VA = "0x1CCE67C", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C3B")]
		public virtual CSProtoInfoManager_TeamLevel teamLevel
		{
			[Token(Token = "0x60053B2")]
			[Address(RVA = "0x1CCE708", Offset = "0x1CCE708", VA = "0x1CCE708", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C3C")]
		public virtual CSProtoInfoManager_Item item
		{
			[Token(Token = "0x60053B3")]
			[Address(RVA = "0x1CCE794", Offset = "0x1CCE794", VA = "0x1CCE794", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C3D")]
		public virtual CSProtoInfoManager_AttendanceBook attendanceBook
		{
			[Token(Token = "0x60053B4")]
			[Address(RVA = "0x1CCE820", Offset = "0x1CCE820", VA = "0x1CCE820", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C3E")]
		public virtual CSProtoInfoManager_EventAttendanceBook eventAttendanceBook
		{
			[Token(Token = "0x60053B5")]
			[Address(RVA = "0x1CCE8AC", Offset = "0x1CCE8AC", VA = "0x1CCE8AC", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C3F")]
		public virtual ProtoInfoManager_GameMode gameMode
		{
			[Token(Token = "0x60053B6")]
			[Address(RVA = "0x1CCE938", Offset = "0x1CCE938", VA = "0x1CCE938", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C40")]
		public virtual ProtoInfoManager_GameModeInstance gameModeInstance
		{
			[Token(Token = "0x60053B7")]
			[Address(RVA = "0x1CCE9C4", Offset = "0x1CCE9C4", VA = "0x1CCE9C4", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C41")]
		public virtual CSProtoInfoManager_LotteryBox lotteryBox
		{
			[Token(Token = "0x60053B8")]
			[Address(RVA = "0x1CCEA50", Offset = "0x1CCEA50", VA = "0x1CCEA50", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C42")]
		public virtual CSProtoInfoManager_TimeInterval timeInterval
		{
			[Token(Token = "0x60053B9")]
			[Address(RVA = "0x1CCEADC", Offset = "0x1CCEADC", VA = "0x1CCEADC", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C43")]
		public virtual CSProtoInfoManager_RankReward rankReward
		{
			[Token(Token = "0x60053BA")]
			[Address(RVA = "0x1CCEB68", Offset = "0x1CCEB68", VA = "0x1CCEB68", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C44")]
		public virtual CSProtoInfoManager_Event Event
		{
			[Token(Token = "0x60053BB")]
			[Address(RVA = "0x1CCEBF4", Offset = "0x1CCEBF4", VA = "0x1CCEBF4", Slot = "28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C45")]
		public virtual CSProtoInfoManager_Stage Stage
		{
			[Token(Token = "0x60053BC")]
			[Address(RVA = "0x1CCEC80", Offset = "0x1CCEC80", VA = "0x1CCEC80", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C46")]
		public virtual CSProtoInfoManager_Sector Sector
		{
			[Token(Token = "0x60053BD")]
			[Address(RVA = "0x1CCED0C", Offset = "0x1CCED0C", VA = "0x1CCED0C", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C47")]
		public virtual CSProtoInfoManager_ItemSet itemSet
		{
			[Token(Token = "0x60053BE")]
			[Address(RVA = "0x1CCED98", Offset = "0x1CCED98", VA = "0x1CCED98", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C48")]
		public virtual CSProtoInfoManager_ItemDictionary ItemDictionary
		{
			[Token(Token = "0x60053BF")]
			[Address(RVA = "0x1CCEE24", Offset = "0x1CCEE24", VA = "0x1CCEE24", Slot = "32")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C49")]
		public virtual CSProtoInfoManager_RandomOption RandomOption
		{
			[Token(Token = "0x60053C0")]
			[Address(RVA = "0x1CCEEB0", Offset = "0x1CCEEB0", VA = "0x1CCEEB0", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C4A")]
		public virtual CSProtoInfoManager_ItemBalance ItemBalance
		{
			[Token(Token = "0x60053C1")]
			[Address(RVA = "0x1CCEF3C", Offset = "0x1CCEF3C", VA = "0x1CCEF3C", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C4B")]
		public virtual ProtoInfoManager_Quest Quest
		{
			[Token(Token = "0x60053C2")]
			[Address(RVA = "0x1CCEFC8", Offset = "0x1CCEFC8", VA = "0x1CCEFC8", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C4C")]
		public virtual CSProtoInfoManager_PvpReward pvpReward
		{
			[Token(Token = "0x60053C3")]
			[Address(RVA = "0x1CCF054", Offset = "0x1CCF054", VA = "0x1CCF054", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C4D")]
		public virtual ProtoInfoManager_Talent Talent
		{
			[Token(Token = "0x60053C4")]
			[Address(RVA = "0x1CCF0E0", Offset = "0x1CCF0E0", VA = "0x1CCF0E0", Slot = "37")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C4E")]
		public virtual ProtoInfoManager_Relic Relic
		{
			[Token(Token = "0x60053C5")]
			[Address(RVA = "0x1CCF16C", Offset = "0x1CCF16C", VA = "0x1CCF16C", Slot = "38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C4F")]
		public virtual ProtoInfoManager_Title Title
		{
			[Token(Token = "0x60053C6")]
			[Address(RVA = "0x1CCF1F8", Offset = "0x1CCF1F8", VA = "0x1CCF1F8", Slot = "39")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C50")]
		public virtual ProtoInfoManager_SkillSpecialization SkillSpecialization
		{
			[Token(Token = "0x60053C7")]
			[Address(RVA = "0x1CCF284", Offset = "0x1CCF284", VA = "0x1CCF284", Slot = "40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C51")]
		public virtual ProtoInfoManager_Skin Skin
		{
			[Token(Token = "0x60053C8")]
			[Address(RVA = "0x1CCF310", Offset = "0x1CCF310", VA = "0x1CCF310", Slot = "41")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C52")]
		public virtual CSProtoInfoManager_TutorialCondition TutorialCondition
		{
			[Token(Token = "0x60053C9")]
			[Address(RVA = "0x1CCF39C", Offset = "0x1CCF39C", VA = "0x1CCF39C", Slot = "42")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C53")]
		public virtual CSProtoInfoManager_ClanRankReward ClanRankReward
		{
			[Token(Token = "0x60053CA")]
			[Address(RVA = "0x1CCF428", Offset = "0x1CCF428", VA = "0x1CCF428", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C54")]
		public virtual CSProtoInfoManager_ClanBoxReward ClanBoxReward
		{
			[Token(Token = "0x60053CB")]
			[Address(RVA = "0x1CCF4B4", Offset = "0x1CCF4B4", VA = "0x1CCF4B4", Slot = "44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C55")]
		public virtual CSProtoInfoManager_TrophyReward TrophyReward
		{
			[Token(Token = "0x60053CC")]
			[Address(RVA = "0x1CCF540", Offset = "0x1CCF540", VA = "0x1CCF540", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C56")]
		public virtual ProtoInfoManager_SkillSound SkillSound
		{
			[Token(Token = "0x60053CD")]
			[Address(RVA = "0x1CCF5CC", Offset = "0x1CCF5CC", VA = "0x1CCF5CC", Slot = "46")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C57")]
		public virtual CSProtoInfoManager_CharacterSound CharacterSound
		{
			[Token(Token = "0x60053CE")]
			[Address(RVA = "0x1CCF658", Offset = "0x1CCF658", VA = "0x1CCF658", Slot = "47")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C58")]
		public virtual CSProtoInfoManager_FreeRelicSlot FreeRelicSlot
		{
			[Token(Token = "0x60053CF")]
			[Address(RVA = "0x1CCF6E4", Offset = "0x1CCF6E4", VA = "0x1CCF6E4", Slot = "48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C59")]
		public virtual CSProtoInfoManager_GameModeOpen GameModeOpen
		{
			[Token(Token = "0x60053D0")]
			[Address(RVA = "0x1CCF770", Offset = "0x1CCF770", VA = "0x1CCF770", Slot = "49")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C5A")]
		public virtual CSProtoInfoManager_PremiumTicket PremiumTicket
		{
			[Token(Token = "0x60053D1")]
			[Address(RVA = "0x1CCF7FC", Offset = "0x1CCF7FC", VA = "0x1CCF7FC", Slot = "50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C5B")]
		public virtual CSProtoInfoManager_CharAnim CharAnim
		{
			[Token(Token = "0x60053D2")]
			[Address(RVA = "0x1CCF888", Offset = "0x1CCF888", VA = "0x1CCF888", Slot = "51")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C5C")]
		public virtual CSProtoInfoManager_PandoraBox PandoraBox
		{
			[Token(Token = "0x60053D3")]
			[Address(RVA = "0x1CCF914", Offset = "0x1CCF914", VA = "0x1CCF914", Slot = "52")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C5D")]
		public virtual CSProtoInfoManager_GameModeReward GameModeReward
		{
			[Token(Token = "0x60053D4")]
			[Address(RVA = "0x1CCF9A0", Offset = "0x1CCF9A0", VA = "0x1CCF9A0", Slot = "53")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C5E")]
		public virtual CSProtoInfoManager_FirstRankReward FirstRankReward
		{
			[Token(Token = "0x60053D5")]
			[Address(RVA = "0x1CCFA2C", Offset = "0x1CCFA2C", VA = "0x1CCFA2C", Slot = "54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C5F")]
		public virtual CSProtoInfoManager_PackageShop PackageShop
		{
			[Token(Token = "0x60053D6")]
			[Address(RVA = "0x1CCFAB8", Offset = "0x1CCFAB8", VA = "0x1CCFAB8", Slot = "55")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C60")]
		public virtual CSProtoInfoManager_Emoticon Emoticon
		{
			[Token(Token = "0x60053D7")]
			[Address(RVA = "0x1CCFB44", Offset = "0x1CCFB44", VA = "0x1CCFB44", Slot = "56")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C61")]
		public virtual CSProtoInfoManager_Emblem Emblem
		{
			[Token(Token = "0x60053D8")]
			[Address(RVA = "0x1CCFBD0", Offset = "0x1CCFBD0", VA = "0x1CCFBD0", Slot = "57")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C62")]
		public virtual CSProtoInfoManager_UserInitials userInitials
		{
			[Token(Token = "0x60053D9")]
			[Address(RVA = "0x1CCFC5C", Offset = "0x1CCFC5C", VA = "0x1CCFC5C", Slot = "58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C63")]
		public virtual CSProtoInfoManager_EventGameMode EventGameMode
		{
			[Token(Token = "0x60053DA")]
			[Address(RVA = "0x1CCFCE8", Offset = "0x1CCFCE8", VA = "0x1CCFCE8", Slot = "59")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C64")]
		public virtual CSProtoInfoManager_EventGameReward EventGameReward
		{
			[Token(Token = "0x60053DB")]
			[Address(RVA = "0x1CCFD74", Offset = "0x1CCFD74", VA = "0x1CCFD74", Slot = "60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C65")]
		public virtual CSProtoInfoManager_Craft Craft
		{
			[Token(Token = "0x60053DC")]
			[Address(RVA = "0x1CCFE00", Offset = "0x1CCFE00", VA = "0x1CCFE00", Slot = "61")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C66")]
		public virtual CSProtoInfoManager_NewUserBenefits NewUserBenefits
		{
			[Token(Token = "0x60053DD")]
			[Address(RVA = "0x1CCFE8C", Offset = "0x1CCFE8C", VA = "0x1CCFE8C", Slot = "62")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C67")]
		public virtual CSProtoInfoManager_CommonValues CommonValues
		{
			[Token(Token = "0x60053DE")]
			[Address(RVA = "0x1CCFF18", Offset = "0x1CCFF18", VA = "0x1CCFF18", Slot = "63")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600539B")]
		[Address(RVA = "0x1CCBAFC", Offset = "0x1CCBAFC", VA = "0x1CCBAFC")]
		protected CSProtoInfoManagers()
		{
			m_ContentsTags = new ContentsTags();
			m_lock = new object();
			m_container = new Dictionary<ProtoInfoTypes, CSProtoInfoManagerBase>(new ProtoInfoTypesComparer());
			m_reload_container = new Dictionary<ProtoInfoTypes, CSProtoInfoManagerBase>(new ProtoInfoTypesComparer());
		}

		[Token(Token = "0x600539C")]
		[Address(RVA = "0x1CCBC4C", Offset = "0x1CCBC4C", VA = "0x1CCBC4C")]
		public static string GetDataFilePath(ProtoInfoTypes type)
		{
			return null;
		}

		[Token(Token = "0x600539D")]
		[Address(RVA = "0x1CCC958", Offset = "0x1CCC958", VA = "0x1CCC958")]
		public void Init(CSProtoInfoFactory factory, ProtoInfoFrom from)
		{
			InitContainer(factory, from, ref m_container);
		}

		[Token(Token = "0x600539E")]
		[Address(RVA = "0x1CCC974", Offset = "0x1CCC974", VA = "0x1CCC974")]
		protected void InitContainer(CSProtoInfoFactory factory, ProtoInfoFrom from, ref Dictionary<ProtoInfoTypes, CSProtoInfoManagerBase> container)
		{
			container.Clear();
			StringBuilder warnings = new StringBuilder();
			foreach (int value in Enum.GetValues(typeof(ProtoInfoTypes)))
			{
				if (value == 0)
				{
					continue;
				}
				ProtoInfoTypes type = (ProtoInfoTypes)value;
				CSProtoInfoManagerBase manager = factory.Create(type);
				if (manager == null)
				{
					warnings.AppendFormat("\n {0}", type.ToString());
					continue;
				}
				if (from != ProtoInfoFrom.ServerAndClient && !manager.IsFrom(from))
				{
					continue;
				}
				container.Add(type, manager);
			}
			if (warnings.Length > 0)
			{
				CSLog.Warning("invalid warnings => {0}", warnings.ToString());
			}
		}

		[Token(Token = "0x600539F")]
		[Address(RVA = "0x1CCD04C", Offset = "0x1CCD04C", VA = "0x1CCD04C")]
		public bool CookingAll(bool bDevelopmentServer)
		{
			return default(bool);
		}

		[Token(Token = "0x60053A0")]
		[Address(RVA = "0x1CCD65C", Offset = "0x1CCD65C", VA = "0x1CCD65C")]
		public bool CookingClientProto(bool bDevelopmentServer)
		{
			return default(bool);
		}

		[Token(Token = "0x60053A1")]
		[Address(RVA = "0x1CCDD70", Offset = "0x1CCDD70", VA = "0x1CCDD70", Slot = "4")]
		public virtual void Clear()
		{
			m_container.Clear();
		}

		[Token(Token = "0x60053A2")]
		public abstract bool LoadFromLocalFile(string GameDataDirectory);

		[Token(Token = "0x60053A3")]
		[Address(RVA = "0x1CCDE08", Offset = "0x1CCDE08", VA = "0x1CCDE08")]
		public CSProtoInfoManagerBase Get(ProtoInfoTypes type)
		{
			lock (m_lock)
			{
				return m_container[type];
			}
		}

		[Token(Token = "0x60053A4")]
		[Address(RVA = "0x1CCDFC0", Offset = "0x1CCDFC0", VA = "0x1CCDFC0")]
		public bool CheckContentsTag(string contentsTag)
		{
			return default(bool);
		}
	}
}
