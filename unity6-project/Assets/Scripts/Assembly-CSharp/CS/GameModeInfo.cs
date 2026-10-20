using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AE8")]
	public class GameModeInfo
	{
		[Token(Token = "0x40034E2")]
		[FieldOffset(Offset = "0x8")]
		public int m_nID;

		[Token(Token = "0x40034E3")]
		[FieldOffset(Offset = "0xC")]
		public string m_szName;

		[Token(Token = "0x40034E4")]
		[FieldOffset(Offset = "0x10")]
		public XGameModeType m_nType;

		[Token(Token = "0x40034E5")]
		[FieldOffset(Offset = "0x14")]
		public int m_nTime;

		[Token(Token = "0x40034E6")]
		[FieldOffset(Offset = "0x18")]
		public string strTimeOut;

		[Token(Token = "0x40034E7")]
		[FieldOffset(Offset = "0x1C")]
		private bool m_bTimeOut;

		[Token(Token = "0x40034E8")]
		[FieldOffset(Offset = "0x20")]
		public string strGoldenGoal;

		[Token(Token = "0x40034E9")]
		[FieldOffset(Offset = "0x24")]
		private bool m_bGoldenGoal;

		[Token(Token = "0x40034EA")]
		[FieldOffset(Offset = "0x28")]
		public string strMultiplay;

		[Token(Token = "0x40034EB")]
		[FieldOffset(Offset = "0x2C")]
		public bool m_bMultiplay;

		[Token(Token = "0x40034EC")]
		[FieldOffset(Offset = "0x30")]
		public string strUseMatchServer;

		[Token(Token = "0x40034ED")]
		[FieldOffset(Offset = "0x34")]
		public int m_nForcedEntryTime;

		[Token(Token = "0x40034EE")]
		[FieldOffset(Offset = "0x38")]
		public int m_nCountDown;

		[Token(Token = "0x40034EF")]
		[FieldOffset(Offset = "0x3C")]
		public int m_nAutoStartTime;

		[Token(Token = "0x40034F0")]
		[FieldOffset(Offset = "0x40")]
		public string strFirstRandomSpawn;

		[Token(Token = "0x40034F1")]
		[FieldOffset(Offset = "0x44")]
		private bool m_bFirstRandomSpawn;

		[Token(Token = "0x40034F2")]
		[FieldOffset(Offset = "0x48")]
		public string strAutoRespawn;

		[Token(Token = "0x40034F3")]
		[FieldOffset(Offset = "0x4C")]
		private bool m_bAutoRespawn;

		[Token(Token = "0x40034F4")]
		[FieldOffset(Offset = "0x50")]
		public int m_nRespawnTime;

		[Token(Token = "0x40034F5")]
		[FieldOffset(Offset = "0x54")]
		public int m_nPenaltyRespawnTime;

		[Token(Token = "0x40034F6")]
		[FieldOffset(Offset = "0x58")]
		public int m_nMaxInstantRespawnCount;

		[Token(Token = "0x40034F7")]
		[FieldOffset(Offset = "0x5C")]
		public string strInstantRespawn;

		[Token(Token = "0x40034F8")]
		[FieldOffset(Offset = "0x60")]
		private bool m_bInstantRespawn;

		[Token(Token = "0x40034F9")]
		[FieldOffset(Offset = "0x64")]
		public int m_nMinPlayerCount;

		[Token(Token = "0x40034FA")]
		[FieldOffset(Offset = "0x68")]
		public int m_nMaxPlayerCount;

		[Token(Token = "0x40034FB")]
		[FieldOffset(Offset = "0x6C")]
		public XTeamMode m_nTeamMode;

		[Token(Token = "0x40034FC")]
		[FieldOffset(Offset = "0x70")]
		public int m_nRound;

		[Token(Token = "0x40034FD")]
		[FieldOffset(Offset = "0x74")]
		public float m_fRoundTime;

		[Token(Token = "0x40034FE")]
		[FieldOffset(Offset = "0x78")]
		public int m_nPointObjectInteractionTime_4Players;

		[Token(Token = "0x40034FF")]
		[FieldOffset(Offset = "0x7C")]
		public int m_nPointObjectInteractionTime_6Players;

		[Token(Token = "0x4003500")]
		[FieldOffset(Offset = "0x80")]
		public string m_strForcedEntry;

		[Token(Token = "0x4003501")]
		[FieldOffset(Offset = "0x84")]
		private bool m_bForcedEntry;

		[Token(Token = "0x4003502")]
		[FieldOffset(Offset = "0x88")]
		public int m_nGoalKillCount;

		[Token(Token = "0x4003503")]
		[FieldOffset(Offset = "0x8C")]
		public int m_nScoreKill;

		[Token(Token = "0x4003504")]
		[FieldOffset(Offset = "0x90")]
		public int m_nScoreDeath;

		[Token(Token = "0x4003505")]
		[FieldOffset(Offset = "0x94")]
		public int m_nScoreAssist;

		[Token(Token = "0x4003506")]
		[FieldOffset(Offset = "0x98")]
		public int m_nScoreVictory;

		[Token(Token = "0x4003507")]
		[FieldOffset(Offset = "0x9C")]
		public int m_nScoreDefeat;

		[Token(Token = "0x4003508")]
		[FieldOffset(Offset = "0xA0")]
		public int m_nScoreLastManStanding;

		[Token(Token = "0x4003509")]
		[FieldOffset(Offset = "0xA4")]
		public string strSneak;

		[Token(Token = "0x400350A")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_bSneak;

		[Token(Token = "0x400350B")]
		[FieldOffset(Offset = "0xAC")]
		public string strBalancedPlayerStart;

		[Token(Token = "0x400350C")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_bBalancedPlayerStart;

		[Token(Token = "0x400350D")]
		[FieldOffset(Offset = "0xB4")]
		public string strRandomMapSpriteName;

		[Token(Token = "0x400350E")]
		[FieldOffset(Offset = "0xB8")]
		public string strEngName;

		[Token(Token = "0x400350F")]
		[FieldOffset(Offset = "0xBC")]
		public string strLocaleStringKey;

		[Token(Token = "0x4003510")]
		[FieldOffset(Offset = "0xC0")]
		public string strSpriteName;

		[Token(Token = "0x4003511")]
		[FieldOffset(Offset = "0xC4")]
		public string strGoalStringKey;

		[Token(Token = "0x4003512")]
		[FieldOffset(Offset = "0xC8")]
		public string strGoalATeamStringKey;

		[Token(Token = "0x4003513")]
		[FieldOffset(Offset = "0xCC")]
		public string strGoalBTeamStringKey;

		[Token(Token = "0x4003514")]
		[FieldOffset(Offset = "0xD0")]
		public float m_fDamageMod;

		[Token(Token = "0x4003515")]
		[FieldOffset(Offset = "0xD4")]
		public float m_fDefenseMod;

		[Token(Token = "0x4003516")]
		[FieldOffset(Offset = "0xD8")]
		public float m_fHPMod;

		[Token(Token = "0x4003517")]
		[FieldOffset(Offset = "0xDC")]
		public string strChat;

		[Token(Token = "0x4003518")]
		[FieldOffset(Offset = "0xE0")]
		public bool m_bChat;

		[Token(Token = "0x4003519")]
		[FieldOffset(Offset = "0xE4")]
		public string strEmotionChat;

		[Token(Token = "0x400351A")]
		[FieldOffset(Offset = "0xE8")]
		public bool m_bEmotionChat;

		[Token(Token = "0x400351B")]
		[FieldOffset(Offset = "0xEC")]
		public string strMiniMap;

		[Token(Token = "0x400351C")]
		[FieldOffset(Offset = "0xF0")]
		public bool m_bMiniMap;

		[Token(Token = "0x400351D")]
		[FieldOffset(Offset = "0xF4")]
		public string strMiniMapItem;

		[Token(Token = "0x400351E")]
		[FieldOffset(Offset = "0xF8")]
		public bool m_bMiniMapItem;

		[Token(Token = "0x400351F")]
		[FieldOffset(Offset = "0xFC")]
		public string strBehindMesh;

		[Token(Token = "0x4003520")]
		[FieldOffset(Offset = "0x100")]
		public bool m_bBehindMesh;

		[Token(Token = "0x4003521")]
		[FieldOffset(Offset = "0x104")]
		public int m_EndCountDown;

		[Token(Token = "0x4003522")]
		[FieldOffset(Offset = "0x108")]
		public string m_StartVoiceType;

		[Token(Token = "0x4003523")]
		[FieldOffset(Offset = "0x10C")]
		public int m_nZombieScoreStart;

		[Token(Token = "0x4003524")]
		[FieldOffset(Offset = "0x110")]
		public string m_PreLoadChars;

		[Token(Token = "0x4003525")]
		[FieldOffset(Offset = "0x114")]
		public List<int> PreLoadCharIdList;

		[Token(Token = "0x4003526")]
		[FieldOffset(Offset = "0x118")]
		public string m_PreLoadSounds;

		[Token(Token = "0x4003527")]
		[FieldOffset(Offset = "0x11C")]
		public List<string> PreLoadSoundKeyList;

		[Token(Token = "0x4003528")]
		[FieldOffset(Offset = "0x120")]
		public string strVeryVeryNewbie;

		[Token(Token = "0x4003529")]
		[FieldOffset(Offset = "0x124")]
		private bool m_bVeryVeryNewbie;

		[Token(Token = "0x400352A")]
		[FieldOffset(Offset = "0x128")]
		public string strCharTag;

		[Token(Token = "0x400352B")]
		[FieldOffset(Offset = "0x12C")]
		private bool m_bCharTag;

		[Token(Token = "0x400352C")]
		[FieldOffset(Offset = "0x130")]
		public string strCharTagOnPlayState;

		[Token(Token = "0x400352D")]
		[FieldOffset(Offset = "0x134")]
		private bool m_bCharTagOnPlayState;

		[Token(Token = "0x400352E")]
		[FieldOffset(Offset = "0x138")]
		public string mode_parameter;

		[Token(Token = "0x400352F")]
		[FieldOffset(Offset = "0x13C")]
		private bool UseMatchServer__BackingField;

		[Token(Token = "0x17000BAF")]
		public bool TimeOut
		{
			[Token(Token = "0x600507B")]
			[Address(RVA = "0x2334A7C", Offset = "0x2334A7C", VA = "0x2334A7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BB0")]
		public bool GoldenGoal
		{
			[Token(Token = "0x600507C")]
			[Address(RVA = "0x2334A84", Offset = "0x2334A84", VA = "0x2334A84")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BB1")]
		public bool Multiplay
		{
			[Token(Token = "0x600507D")]
			[Address(RVA = "0x2334A8C", Offset = "0x2334A8C", VA = "0x2334A8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BB2")]
		[XmlIgnore]
		public bool UseMatchServer
		{
			[Token(Token = "0x600507E")]
			[Address(RVA = "0x2334A94", Offset = "0x2334A94", VA = "0x2334A94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600507F")]
			[Address(RVA = "0x2334A9C", Offset = "0x2334A9C", VA = "0x2334A9C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000BB3")]
		public bool FirstRandomSpawn
		{
			[Token(Token = "0x6005080")]
			[Address(RVA = "0x2334AA4", Offset = "0x2334AA4", VA = "0x2334AA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BB4")]
		public bool AutoRespawn
		{
			[Token(Token = "0x6005081")]
			[Address(RVA = "0x2334AAC", Offset = "0x2334AAC", VA = "0x2334AAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BB5")]
		public bool InstantRespawn
		{
			[Token(Token = "0x6005082")]
			[Address(RVA = "0x2334AB4", Offset = "0x2334AB4", VA = "0x2334AB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BB6")]
		public bool ForcedEntry
		{
			[Token(Token = "0x6005083")]
			[Address(RVA = "0x2334ABC", Offset = "0x2334ABC", VA = "0x2334ABC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BB7")]
		public bool Sneak
		{
			[Token(Token = "0x6005084")]
			[Address(RVA = "0x2334AC4", Offset = "0x2334AC4", VA = "0x2334AC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BB8")]
		public bool BalancedPlayerStart
		{
			[Token(Token = "0x6005085")]
			[Address(RVA = "0x2334ACC", Offset = "0x2334ACC", VA = "0x2334ACC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BB9")]
		public bool VeryVeryNewbie
		{
			[Token(Token = "0x6005086")]
			[Address(RVA = "0x2334AD4", Offset = "0x2334AD4", VA = "0x2334AD4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BBA")]
		public bool CharTag
		{
			[Token(Token = "0x6005087")]
			[Address(RVA = "0x2334ADC", Offset = "0x2334ADC", VA = "0x2334ADC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000BBB")]
		public bool CharTagOnPlayState
		{
			[Token(Token = "0x6005088")]
			[Address(RVA = "0x2334AE4", Offset = "0x2334AE4", VA = "0x2334AE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600507A")]
		[Address(RVA = "0x23347E8", Offset = "0x23347E8", VA = "0x23347E8")]
		public GameModeInfo()
		{
		}

		[Token(Token = "0x6005089")]
		[Address(RVA = "0x2334AEC", Offset = "0x2334AEC", VA = "0x2334AEC")]
		public bool Cooking()
		{
			return default(bool);
		}

		[Token(Token = "0x600508A")]
		[Address(RVA = "0x2335390", Offset = "0x2335390", VA = "0x2335390")]
		private void CookingPreLoadCharIdList()
		{
		}

		[Token(Token = "0x600508B")]
		[Address(RVA = "0x233551C", Offset = "0x233551C", VA = "0x233551C")]
		private void CookingPreLoadSoundKeyList()
		{
		}
	}
}
