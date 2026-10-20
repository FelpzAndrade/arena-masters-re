using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B72")]
	public class CSStageInfo
	{
		[Token(Token = "0x40039C0")]
		[FieldOffset(Offset = "0x8")]
		public int index;

		[Token(Token = "0x40039C1")]
		[FieldOffset(Offset = "0xC")]
		public string strMapName;

		[Token(Token = "0x40039C2")]
		[FieldOffset(Offset = "0x10")]
		public string strMapDes;

		[Token(Token = "0x40039C3")]
		[FieldOffset(Offset = "0x14")]
		public int group;

		[Token(Token = "0x40039C4")]
		[FieldOffset(Offset = "0x18")]
		public int stageNumber;

		[Token(Token = "0x40039C5")]
		[FieldOffset(Offset = "0x1C")]
		public MissionType missionType;

		[Token(Token = "0x40039C6")]
		[FieldOffset(Offset = "0x20")]
		public CSStageGameModeType gameModeType;

		[Token(Token = "0x40039C7")]
		[FieldOffset(Offset = "0x24")]
		public CSStageType modeType;

		[Token(Token = "0x40039C8")]
		[FieldOffset(Offset = "0x28")]
		public CSStageDifficulty difficulty;

		[Token(Token = "0x40039C9")]
		[FieldOffset(Offset = "0x2C")]
		public FieldType fieldType;

		[Token(Token = "0x40039CA")]
		[FieldOffset(Offset = "0x30")]
		public int level;

		[Token(Token = "0x40039CB")]
		[FieldOffset(Offset = "0x34")]
		public int combatPower;

		[Token(Token = "0x40039CC")]
		[FieldOffset(Offset = "0x38")]
		public CSFarmingType farmingType;

		[Token(Token = "0x40039CD")]
		[FieldOffset(Offset = "0x3C")]
		public int score;

		[Token(Token = "0x40039CE")]
		[FieldOffset(Offset = "0x40")]
		public string strAvailableDayOfWeeks;

		[Token(Token = "0x40039CF")]
		[FieldOffset(Offset = "0x44")]
		public CSDailyDungeonDays availableDayOfWeeks;

		[Token(Token = "0x40039D0")]
		[FieldOffset(Offset = "0x48")]
		public int playLimitGroup;

		[Token(Token = "0x40039D1")]
		[FieldOffset(Offset = "0x4C")]
		public int playLimitCount;

		[Token(Token = "0x40039D2")]
		[FieldOffset(Offset = "0x50")]
		public string coolTime;

		[Token(Token = "0x40039D3")]
		[FieldOffset(Offset = "0x54")]
		public Currency costType;

		[Token(Token = "0x40039D4")]
		[FieldOffset(Offset = "0x58")]
		public int costCount;

		[Token(Token = "0x40039D5")]
		[FieldOffset(Offset = "0x5C")]
		public int enterClearIndex;

		[Token(Token = "0x40039D6")]
		[FieldOffset(Offset = "0x60")]
		public int limitTeamLevel;

		[Token(Token = "0x40039D7")]
		[FieldOffset(Offset = "0x64")]
		public int limitCharLevel;

		[Token(Token = "0x40039D8")]
		[FieldOffset(Offset = "0x68")]
		public string levelData;

		[Token(Token = "0x40039D9")]
		[FieldOffset(Offset = "0x6C")]
		public int goalKillCount;

		[Token(Token = "0x40039DA")]
		[FieldOffset(Offset = "0x70")]
		public string missionObjectivesText;

		[Token(Token = "0x40039DB")]
		[FieldOffset(Offset = "0x74")]
		public int respawnTime;

		[Token(Token = "0x40039DC")]
		[FieldOffset(Offset = "0x78")]
		public string icon;

		[Token(Token = "0x40039DD")]
		[FieldOffset(Offset = "0x7C")]
		public string strBGM;

		[Token(Token = "0x40039DE")]
		[FieldOffset(Offset = "0x80")]
		public string bGE;

		[Token(Token = "0x40039DF")]
		[FieldOffset(Offset = "0x84")]
		public string bossIcon;

		[Token(Token = "0x40039E0")]
		[FieldOffset(Offset = "0x88")]
		public int timeLimit;

		[Token(Token = "0x40039E1")]
		[FieldOffset(Offset = "0x8C")]
		public string strUseAutoFight;

		[Token(Token = "0x40039E2")]
		[FieldOffset(Offset = "0x90")]
		public bool useAutoFight;

		[Token(Token = "0x40039E3")]
		[FieldOffset(Offset = "0x94")]
		public string strUseTicket;

		[Token(Token = "0x40039E4")]
		[FieldOffset(Offset = "0x98")]
		public bool useTicket;

		[Token(Token = "0x40039E5")]
		[FieldOffset(Offset = "0x9C")]
		public string strRevive;

		[Token(Token = "0x40039E6")]
		[FieldOffset(Offset = "0xA0")]
		public bool revive;

		[Token(Token = "0x40039E7")]
		[FieldOffset(Offset = "0xA4")]
		public string strNotifyItem;

		[Token(Token = "0x40039E8")]
		[FieldOffset(Offset = "0xA8")]
		public string strMapNotifyItem;

		[Token(Token = "0x40039E9")]
		[FieldOffset(Offset = "0xAC")]
		public int minGold;

		[Token(Token = "0x40039EA")]
		[FieldOffset(Offset = "0xB0")]
		public int maxGold;

		[Token(Token = "0x40039EB")]
		[FieldOffset(Offset = "0xB4")]
		public int soulStone;

		[Token(Token = "0x40039EC")]
		[FieldOffset(Offset = "0xB8")]
		public int dropGacha1;

		[Token(Token = "0x40039ED")]
		[FieldOffset(Offset = "0xBC")]
		public int dropGacha2;

		[Token(Token = "0x40039EE")]
		[FieldOffset(Offset = "0xC0")]
		public int dropGacha3;

		[Token(Token = "0x40039EF")]
		[FieldOffset(Offset = "0xC4")]
		public int dropGacha4;

		[Token(Token = "0x40039F0")]
		[FieldOffset(Offset = "0xC8")]
		public CSContentType firstClearRewardType;

		[Token(Token = "0x40039F1")]
		[FieldOffset(Offset = "0xCC")]
		public int firstClearRewardId;

		[Token(Token = "0x40039F2")]
		[FieldOffset(Offset = "0xD0")]
		public int firstClearRewardAmount;

		[Token(Token = "0x40039F3")]
		[FieldOffset(Offset = "0xD4")]
		public CSContentType ticketClearRewardType;

		[Token(Token = "0x40039F4")]
		[FieldOffset(Offset = "0xD8")]
		public int ticketClearRewardId;

		[Token(Token = "0x40039F5")]
		[FieldOffset(Offset = "0xDC")]
		public int ticketClearRewardCount;

		[Token(Token = "0x40039F6")]
		[FieldOffset(Offset = "0xE0")]
		[XmlIgnore]
		public List<int> notifyItems;

		[Token(Token = "0x40039F7")]
		[FieldOffset(Offset = "0xE4")]
		[XmlIgnore]
		public List<int> mapNotifyItems;

		[Token(Token = "0x40039F8")]
		[FieldOffset(Offset = "0xE8")]
		[XmlIgnore]
		public List<int> dropGachas;

		[Token(Token = "0x40039F9")]
		[FieldOffset(Offset = "0xEC")]
		[XmlIgnore]
		public string localizeKeyName;

		[Token(Token = "0x600531A")]
		[Address(RVA = "0x1CD432C", Offset = "0x1CD432C", VA = "0x1CD432C")]
		public CSStageInfo()
		{
		}

		[Token(Token = "0x600531B")]
		[Address(RVA = "0x1CC5120", Offset = "0x1CC5120", VA = "0x1CC5120")]
		public bool Cooking()
		{
			return default(bool);
		}

		[Token(Token = "0x600531C")]
		[Address(RVA = "0x1CD4538", Offset = "0x1CD4538", VA = "0x1CD4538")]
		private bool AddItem(List<int> list, int id)
		{
			return default(bool);
		}
	}
}
