using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AEC")]
	public class GameModeInstanceInfo
	{
		[Token(Token = "0x4003536")]
		[FieldOffset(Offset = "0x8")]
		public int nID;

		[Token(Token = "0x4003537")]
		[FieldOffset(Offset = "0xC")]
		public XGameModeType gameModeType;

		[Token(Token = "0x4003538")]
		[FieldOffset(Offset = "0x10")]
		public string gameName;

		[Token(Token = "0x4003539")]
		[FieldOffset(Offset = "0x14")]
		public string gameDes;

		[Token(Token = "0x400353A")]
		[FieldOffset(Offset = "0x18")]
		public string gameDesTitle;

		[Token(Token = "0x400353B")]
		[FieldOffset(Offset = "0x1C")]
		public string gameDesDetail;

		[Token(Token = "0x400353C")]
		[FieldOffset(Offset = "0x20")]
		public CSStageDifficulty gameDesDifficult;

		[Token(Token = "0x400353D")]
		[FieldOffset(Offset = "0x24")]
		public MatchType matchType;

		[Token(Token = "0x400353E")]
		[FieldOffset(Offset = "0x28")]
		public RankType rankType;

		[Token(Token = "0x400353F")]
		[FieldOffset(Offset = "0x2C")]
		public string strRankActivation;

		[Token(Token = "0x4003540")]
		[FieldOffset(Offset = "0x30")]
		private bool m_rankActivation;

		[Token(Token = "0x4003541")]
		[FieldOffset(Offset = "0x34")]
		public string contentsTag;

		[Token(Token = "0x4003542")]
		[FieldOffset(Offset = "0x38")]
		public string strUseMatchServer;

		[Token(Token = "0x4003543")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_bUseMatchServer;

		[Token(Token = "0x4003544")]
		[FieldOffset(Offset = "0x40")]
		public string strIsLadder;

		[Token(Token = "0x4003545")]
		[FieldOffset(Offset = "0x44")]
		private bool m_bIsLadder;

		[Token(Token = "0x4003546")]
		[FieldOffset(Offset = "0x48")]
		public int quickMatchWeight;

		[Token(Token = "0x4003547")]
		[FieldOffset(Offset = "0x4C")]
		public string strAIMode;

		[Token(Token = "0x4003548")]
		[FieldOffset(Offset = "0x50")]
		private bool m_bAIMode;

		[Token(Token = "0x4003549")]
		[FieldOffset(Offset = "0x54")]
		public string strBalanceRegulate;

		[Token(Token = "0x400354A")]
		[FieldOffset(Offset = "0x58")]
		private bool m_bBalanceRegulate;

		[Token(Token = "0x400354B")]
		[FieldOffset(Offset = "0x5C")]
		public string strSectorIDs;

		[Token(Token = "0x400354C")]
		[FieldOffset(Offset = "0x60")]
		public Currency costType;

		[Token(Token = "0x400354D")]
		[FieldOffset(Offset = "0x64")]
		public int costEnter;

		[Token(Token = "0x400354E")]
		[FieldOffset(Offset = "0x68")]
		public int costStart;

		[Token(Token = "0x400354F")]
		[FieldOffset(Offset = "0x6C")]
		public int costComplete;

		[Token(Token = "0x4003550")]
		[FieldOffset(Offset = "0x70")]
		public int teamLevelExp;

		[Token(Token = "0x4003551")]
		[FieldOffset(Offset = "0x74")]
		public int minGold;

		[Token(Token = "0x4003552")]
		[FieldOffset(Offset = "0x78")]
		public int maxGold;

		[Token(Token = "0x4003553")]
		[FieldOffset(Offset = "0x7C")]
		public int ResurrectionCost;

		[Token(Token = "0x4003554")]
		[FieldOffset(Offset = "0x80")]
		public int medalOfWarrior1;

		[Token(Token = "0x4003555")]
		[FieldOffset(Offset = "0x84")]
		public int medalOfWarrior2;

		[Token(Token = "0x4003556")]
		[FieldOffset(Offset = "0x88")]
		public int medalOfWarrior3;

		[Token(Token = "0x4003557")]
		[FieldOffset(Offset = "0x8C")]
		public int medalOfWarrior4;

		[Token(Token = "0x4003558")]
		[FieldOffset(Offset = "0x90")]
		public int medalOfWarrior5;

		[Token(Token = "0x4003559")]
		[FieldOffset(Offset = "0x94")]
		public int medalOfWarrior6;

		[Token(Token = "0x400355A")]
		[FieldOffset(Offset = "0x98")]
		public int medalOfHonor1;

		[Token(Token = "0x400355B")]
		[FieldOffset(Offset = "0x9C")]
		public int medalOfHonor2;

		[Token(Token = "0x400355C")]
		[FieldOffset(Offset = "0xA0")]
		public int medalOfHonor3;

		[Token(Token = "0x400355D")]
		[FieldOffset(Offset = "0xA4")]
		public int medalOfHonor4;

		[Token(Token = "0x400355E")]
		[FieldOffset(Offset = "0xA8")]
		public int medalOfHonor5;

		[Token(Token = "0x400355F")]
		[FieldOffset(Offset = "0xAC")]
		public int medalOfHonor6;

		[Token(Token = "0x4003560")]
		[FieldOffset(Offset = "0xB0")]
		public int combatPoint1;

		[Token(Token = "0x4003561")]
		[FieldOffset(Offset = "0xB4")]
		public int combatPoint2;

		[Token(Token = "0x4003562")]
		[FieldOffset(Offset = "0xB8")]
		public int combatPoint3;

		[Token(Token = "0x4003563")]
		[FieldOffset(Offset = "0xBC")]
		public int combatPoint4;

		[Token(Token = "0x4003564")]
		[FieldOffset(Offset = "0xC0")]
		public int combatPoint5;

		[Token(Token = "0x4003565")]
		[FieldOffset(Offset = "0xC4")]
		public int combatPoint6;

		[Token(Token = "0x4003566")]
		[FieldOffset(Offset = "0xC8")]
		public int characterPoint1;

		[Token(Token = "0x4003567")]
		[FieldOffset(Offset = "0xCC")]
		public int characterPoint2;

		[Token(Token = "0x4003568")]
		[FieldOffset(Offset = "0xD0")]
		public int characterPoint3;

		[Token(Token = "0x4003569")]
		[FieldOffset(Offset = "0xD4")]
		public int characterPoint4;

		[Token(Token = "0x400356A")]
		[FieldOffset(Offset = "0xD8")]
		public int characterPoint5;

		[Token(Token = "0x400356B")]
		[FieldOffset(Offset = "0xDC")]
		public int characterPoint6;

		[Token(Token = "0x400356C")]
		[FieldOffset(Offset = "0xE0")]
		public int rewardLotterry1;

		[Token(Token = "0x400356D")]
		[FieldOffset(Offset = "0xE4")]
		public int rewardLotterry2;

		[Token(Token = "0x400356E")]
		[FieldOffset(Offset = "0xE8")]
		public int rewardLotterry3;

		[Token(Token = "0x400356F")]
		[FieldOffset(Offset = "0xEC")]
		public int rewardLotterry4;

		[Token(Token = "0x4003570")]
		[FieldOffset(Offset = "0xF0")]
		public int rewardLotterry5;

		[Token(Token = "0x4003571")]
		[FieldOffset(Offset = "0xF4")]
		public int rewardLotterry6;

		[Token(Token = "0x4003572")]
		[FieldOffset(Offset = "0xF8")]
		public int victory_point_normal1;

		[Token(Token = "0x4003573")]
		[FieldOffset(Offset = "0xFC")]
		public int victory_point_normal2;

		[Token(Token = "0x4003574")]
		[FieldOffset(Offset = "0x100")]
		public int victory_point_normal3;

		[Token(Token = "0x4003575")]
		[FieldOffset(Offset = "0x104")]
		public int victory_point_normal4;

		[Token(Token = "0x4003576")]
		[FieldOffset(Offset = "0x108")]
		public int victory_point_normal5;

		[Token(Token = "0x4003577")]
		[FieldOffset(Offset = "0x10C")]
		public int victory_point_normal6;

		[Token(Token = "0x4003578")]
		[FieldOffset(Offset = "0x110")]
		public int pvpRewardGroupId;

		[Token(Token = "0x4003579")]
		[FieldOffset(Offset = "0x114")]
		public string str_use_elo_match;

		[Token(Token = "0x400357A")]
		[FieldOffset(Offset = "0x118")]
		private bool m_use_elo_match;

		[Token(Token = "0x400357B")]
		[FieldOffset(Offset = "0x11C")]
		public int order;

		[Token(Token = "0x400357C")]
		[FieldOffset(Offset = "0x120")]
		public string strBGPath;

		[Token(Token = "0x400357D")]
		[FieldOffset(Offset = "0x124")]
		public string strBGColorHex;

		[Token(Token = "0x400357E")]
		[FieldOffset(Offset = "0x128")]
		public string strIconPath;

		[Token(Token = "0x400357F")]
		[FieldOffset(Offset = "0x12C")]
		public ProductLabelType ribbonType;

		[Token(Token = "0x4003580")]
		[FieldOffset(Offset = "0x130")]
		public int elo_bandwidth;

		[Token(Token = "0x4003581")]
		[FieldOffset(Offset = "0x134")]
		public int customBuffID;

		[Token(Token = "0x4003582")]
		[FieldOffset(Offset = "0x138")]
		public int buffID;

		[Token(Token = "0x4003583")]
		[FieldOffset(Offset = "0x13C")]
		public string str_use_item_modifier;

		[Token(Token = "0x4003584")]
		[FieldOffset(Offset = "0x140")]
		private bool m_use_item_modifier;

		[Token(Token = "0x4003585")]
		[FieldOffset(Offset = "0x144")]
		public string str_use_skill_specialize;

		[Token(Token = "0x4003586")]
		[FieldOffset(Offset = "0x148")]
		private bool m_use_skill_specialize;

		[Token(Token = "0x4003587")]
		[FieldOffset(Offset = "0x14C")]
		public string str_use_talent;

		[Token(Token = "0x4003588")]
		[FieldOffset(Offset = "0x150")]
		private bool m_use_talent;

		[Token(Token = "0x4003589")]
		[FieldOffset(Offset = "0x154")]
		public string mode_parameter;

		[Token(Token = "0x400358A")]
		[FieldOffset(Offset = "0x158")]
		public string str_use_relic;

		[Token(Token = "0x400358B")]
		[FieldOffset(Offset = "0x15C")]
		private bool m_use_relic;

		[Token(Token = "0x400358C")]
		[FieldOffset(Offset = "0x160")]
		public int mode_startbuff;

		[Token(Token = "0x400358D")]
		[FieldOffset(Offset = "0x164")]
		public string str_normal_view_show;

		[Token(Token = "0x400358E")]
		[FieldOffset(Offset = "0x168")]
		private bool m_normal_view_show;

		[Token(Token = "0x400358F")]
		[FieldOffset(Offset = "0x16C")]
		public string str_friendly_match_view_show;

		[Token(Token = "0x4003590")]
		[FieldOffset(Offset = "0x170")]
		private bool m_friendly_match_view_show;

		[Token(Token = "0x4003591")]
		[FieldOffset(Offset = "0x174")]
		public int helpID;

		[Token(Token = "0x4003592")]
		[FieldOffset(Offset = "0x178")]
		public string str_show_character_level;

		[Token(Token = "0x4003593")]
		[FieldOffset(Offset = "0x17C")]
		private bool m_show_character_level;

		[Token(Token = "0x4003594")]
		[FieldOffset(Offset = "0x180")]
		public string strPrivateRoomUse;

		[Token(Token = "0x4003595")]
		[FieldOffset(Offset = "0x184")]
		public string strPasswordSetOutput;

		[Token(Token = "0x4003596")]
		[FieldOffset(Offset = "0x188")]
		[XmlIgnore]
		public bool isCorrectionMode;

		[Token(Token = "0x4003597")]
		[FieldOffset(Offset = "0x18C")]
		public List<int> SectorIDList;

		[Token(Token = "0x4003598")]
		[FieldOffset(Offset = "0x190")]
		private bool PrivateRoomUse__BackingField;

		[Token(Token = "0x4003599")]
		[FieldOffset(Offset = "0x191")]
		private bool IsPasswordSetOutput__BackingField;

		[Token(Token = "0x17000BBC")]
		public bool UseMatchServer
		{
			[Token(Token = "0x6005097")]
			[Address(RVA = "0x2335A34", Offset = "0x2335A34", VA = "0x2335A34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BBD")]
		public bool IsLadder
		{
			[Token(Token = "0x6005098")]
			[Address(RVA = "0x2335A3C", Offset = "0x2335A3C", VA = "0x2335A3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BBE")]
		public bool AIMode
		{
			[Token(Token = "0x6005099")]
			[Address(RVA = "0x2335A44", Offset = "0x2335A44", VA = "0x2335A44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BBF")]
		public bool BalanceRegulate
		{
			[Token(Token = "0x600509A")]
			[Address(RVA = "0x2335A4C", Offset = "0x2335A4C", VA = "0x2335A4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BC0")]
		public bool use_elo_match
		{
			[Token(Token = "0x600509B")]
			[Address(RVA = "0x2335A54", Offset = "0x2335A54", VA = "0x2335A54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600509C")]
			[Address(RVA = "0x2335A5C", Offset = "0x2335A5C", VA = "0x2335A5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000BC1")]
		public bool UseItemModifier
		{
			[Token(Token = "0x600509D")]
			[Address(RVA = "0x2335A64", Offset = "0x2335A64", VA = "0x2335A64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BC2")]
		public bool UseSkillSpecialize
		{
			[Token(Token = "0x600509E")]
			[Address(RVA = "0x2335A6C", Offset = "0x2335A6C", VA = "0x2335A6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BC3")]
		public bool UseTalent
		{
			[Token(Token = "0x600509F")]
			[Address(RVA = "0x2335A74", Offset = "0x2335A74", VA = "0x2335A74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BC4")]
		public bool UseRelic
		{
			[Token(Token = "0x60050A0")]
			[Address(RVA = "0x2335A7C", Offset = "0x2335A7C", VA = "0x2335A7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BC5")]
		public bool NormalViewShow
		{
			[Token(Token = "0x60050A1")]
			[Address(RVA = "0x2335A84", Offset = "0x2335A84", VA = "0x2335A84")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BC6")]
		public bool FriendlyMatchViewShow
		{
			[Token(Token = "0x60050A2")]
			[Address(RVA = "0x2335A8C", Offset = "0x2335A8C", VA = "0x2335A8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BC7")]
		public bool Show_character_level
		{
			[Token(Token = "0x60050A3")]
			[Address(RVA = "0x2335A94", Offset = "0x2335A94", VA = "0x2335A94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BC8")]
		[XmlIgnore]
		public bool PrivateRoomUse
		{
			[Token(Token = "0x60050A4")]
			[Address(RVA = "0x2335A9C", Offset = "0x2335A9C", VA = "0x2335A9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60050A5")]
			[Address(RVA = "0x2335AA4", Offset = "0x2335AA4", VA = "0x2335AA4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000BC9")]
		[XmlIgnore]
		public bool IsPasswordSetOutput
		{
			[Token(Token = "0x60050A6")]
			[Address(RVA = "0x2335AAC", Offset = "0x2335AAC", VA = "0x2335AAC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60050A7")]
			[Address(RVA = "0x2335AB4", Offset = "0x2335AB4", VA = "0x2335AB4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000BCA")]
		public int SectorID
		{
			[Token(Token = "0x60050A8")]
			[Address(RVA = "0x2335ABC", Offset = "0x2335ABC", VA = "0x2335ABC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000BCB")]
		public int SectorCount
		{
			[Token(Token = "0x60050A9")]
			[Address(RVA = "0x2335B64", Offset = "0x2335B64", VA = "0x2335B64")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000BCC")]
		public int CostCount
		{
			[Token(Token = "0x60050AA")]
			[Address(RVA = "0x2335BFC", Offset = "0x2335BFC", VA = "0x2335BFC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000BCD")]
		public GameKey GameKey
		{
			[Token(Token = "0x60050AC")]
			[Address(RVA = "0x2335C14", Offset = "0x2335C14", VA = "0x2335C14")]
			get
			{
				return default(GameKey);
			}
		}

		[Token(Token = "0x6005096")]
		[Address(RVA = "0x23357F4", Offset = "0x23357F4", VA = "0x23357F4")]
		public GameModeInstanceInfo()
		{
		}

		[Token(Token = "0x60050AB")]
		[Address(RVA = "0x2335AC4", Offset = "0x2335AC4", VA = "0x2335AC4")]
		public int GetSectorID(int sectorIndex)
		{
			return default(int);
		}

		[Token(Token = "0x60050AD")]
		[Address(RVA = "0x2335C30", Offset = "0x2335C30", VA = "0x2335C30")]
		public bool Cooking()
		{
			return default(bool);
		}

		[Token(Token = "0x60050AE")]
		[Address(RVA = "0x2336498", Offset = "0x2336498", VA = "0x2336498")]
		private void CookingIsCorrectionMode()
		{
		}

		[Token(Token = "0x60050AF")]
		[Address(RVA = "0x233630C", Offset = "0x233630C", VA = "0x233630C")]
		private void CookingSectorList()
		{
		}

		[Token(Token = "0x60050B0")]
		[Address(RVA = "0x23364CC", Offset = "0x23364CC", VA = "0x23364CC")]
		public bool IsRankActivation()
		{
			return default(bool);
		}
	}
}
