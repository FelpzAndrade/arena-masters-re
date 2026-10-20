using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json;

[Token(Token = "0x2000623")]
public class XLocalData
{
	[Token(Token = "0x4001D86")]
	[FieldOffset(Offset = "0x8")]
	public ConnectEnum.RegionType region;

	[Token(Token = "0x4001D87")]
	[FieldOffset(Offset = "0xC")]
	public Dictionary<string, XAccountLocalData> accountLocalDataDic;

	[Token(Token = "0x4001D88")]
	[FieldOffset(Offset = "0x10")]
	public int LastChattingChannel;

	[Token(Token = "0x4001D89")]
	[FieldOffset(Offset = "0x14")]
	public string LastChattingChannelLanguage;

	[Token(Token = "0x4001D8A")]
	[FieldOffset(Offset = "0x18")]
	public List<string> Google_NameList;

	[Token(Token = "0x4001D8B")]
	[FieldOffset(Offset = "0x1C")]
	public bool Terms_state;

	[Token(Token = "0x4001D8C")]
	[FieldOffset(Offset = "0x20")]
	public int Terms_version;

	[Token(Token = "0x4001D8D")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<int, int> RelicShowed;

	[Token(Token = "0x4001D8E")]
	[FieldOffset(Offset = "0x28")]
	public int TalentPointCount;

	[Token(Token = "0x4001D8F")]
	[FieldOffset(Offset = "0x2C")]
	public int TitleCount;

	[Token(Token = "0x4001D90")]
	[FieldOffset(Offset = "0x30")]
	public int NewItemCount;

	[Token(Token = "0x4001D91")]
	[FieldOffset(Offset = "0x34")]
	public int CharacterCount;

	[Token(Token = "0x4001D92")]
	[FieldOffset(Offset = "0x38")]
	public int TotalSkinCount;

	[Token(Token = "0x4001D93")]
	[FieldOffset(Offset = "0x3C")]
	public int TotalSkillPointCount;

	[Token(Token = "0x4001D94")]
	[FieldOffset(Offset = "0x40")]
	public int PetCount;

	[Token(Token = "0x4001D95")]
	[FieldOffset(Offset = "0x48")]
	public DateTime DayItemPopupLastTime;

	[Token(Token = "0x4001D96")]
	[FieldOffset(Offset = "0x58")]
	public DateTime EventAttendanceLastTime;

	[Token(Token = "0x4001D97")]
	[FieldOffset(Offset = "0x68")]
	public Dictionary<int, DateTime> PopupShopLastTimeList;

	[Token(Token = "0x4001D98")]
	[FieldOffset(Offset = "0x6C")]
	public int tapjoyTutorialFunnelCount;

	[Token(Token = "0x4001D99")]
	[FieldOffset(Offset = "0x70")]
	public int tapjoyLevelupFunnelCount;

	[Token(Token = "0x4001D9A")]
	[FieldOffset(Offset = "0x74")]
	public bool isFacebookInstall;

	[Token(Token = "0x4001D9B")]
	[FieldOffset(Offset = "0x78")]
	public string tapjoySurveyResult;

	[Token(Token = "0x4001D9C")]
	[FieldOffset(Offset = "0x7C")]
	public Dictionary<int, int> mySkillRecord;

	[Token(Token = "0x4001D9D")]
	[FieldOffset(Offset = "0x80")]
	public Dictionary<string, int> myAchievement;

	[Token(Token = "0x4001D9E")]
	[FieldOffset(Offset = "0x84")]
	public bool isAutoConnectGamePlatform;

	[Token(Token = "0x4001D9F")]
	[FieldOffset(Offset = "0x85")]
	public bool IsOnBoosterItem;

	[Token(Token = "0x4001DA0")]
	[FieldOffset(Offset = "0x86")]
	public bool IsOnBoosterGold;

	[Token(Token = "0x4001DA1")]
	[FieldOffset(Offset = "0x87")]
	public bool IsOnBoosterPromstone;

	[Token(Token = "0x4001DA2")]
	[FieldOffset(Offset = "0x88")]
	public XQuickMatchOptionData QuickMatchOptionData;

	[Token(Token = "0x4001DA3")]
	[FieldOffset(Offset = "0x90")]
	public DateTime StartMannerDownScoreTime;

	[Token(Token = "0x4001DA4")]
	[FieldOffset(Offset = "0xA0")]
	public int StartMannerDownScore;

	[Token(Token = "0x4001DA5")]
	[FieldOffset(Offset = "0xA8")]
	public DateTime BadMannerClickTime;

	[Token(Token = "0x4001DA6")]
	[FieldOffset(Offset = "0xB8")]
	public int RemainBadMannerClick;

	[Token(Token = "0x4001DA7")]
	[FieldOffset(Offset = "0xBC")]
	public Dictionary<int, bool> LocalPushIdDictionary;

	[Token(Token = "0x4001DA8")]
	[FieldOffset(Offset = "0xC0")]
	public int LocalChatTabInLobby;

	[Token(Token = "0x4001DA9")]
	[FieldOffset(Offset = "0xC4")]
	[JsonIgnore]
	private string currentLoginAID;

	[Token(Token = "0x4001DAA")]
	[FieldOffset(Offset = "0xC8")]
	[JsonIgnore]
	private int m_matchingSupplementationCount;

	[Token(Token = "0x4001DAB")]
	[FieldOffset(Offset = "0xCC")]
	[JsonIgnore]
	private bool m_bMatchingSupplementation;

	[Token(Token = "0x4001DAC")]
	[FieldOffset(Offset = "0xCD")]
	[JsonIgnore]
	private bool m_bRankMatchingSupplementation;

	[Token(Token = "0x4001DAD")]
	[FieldOffset(Offset = "0xD0")]
	[JsonIgnore]
	public int TestPing;

	[Token(Token = "0x4001DAE")]
	[FieldOffset(Offset = "0xD4")]
	[JsonIgnore]
	public string TestRegionServerKey;

	[Token(Token = "0x4001DAF")]
	[FieldOffset(Offset = "0xD8")]
	public Random SystemRandom;

	[Token(Token = "0x4001DB0")]
	[FieldOffset(Offset = "0xDC")]
	[JsonIgnore]
	public bool SyncStartMove;

	[Token(Token = "0x4001DB1")]
	[FieldOffset(Offset = "0xE0")]
	[JsonIgnore]
	public int SyncStartMoveRate;

	[Token(Token = "0x4001DB2")]
	[FieldOffset(Offset = "0xE4")]
	[JsonIgnore]
	public int SyncTurnAngle;

	[Token(Token = "0x4001DB3")]
	[FieldOffset(Offset = "0xE8")]
	[JsonIgnore]
	public bool IsMoveMotionSyncOn;

	[Token(Token = "0x4001DB4")]
	[FieldOffset(Offset = "0xE9")]
	[JsonIgnore]
	public bool IsMovingSkillSyncOn;

	[Token(Token = "0x4001DB5")]
	[FieldOffset(Offset = "0xEA")]
	[JsonIgnore]
	public bool TestNexonComAccount;

	[Token(Token = "0x4001DB6")]
	[FieldOffset(Offset = "0xEC")]
	[JsonIgnore]
	public string TestAndroidID;

	[Token(Token = "0x60034D9")]
	[Address(RVA = "0x1E1A778", Offset = "0x1E1A778", VA = "0x1E1A778")]
	public XLocalData()
	{
	}

	[Token(Token = "0x60034DA")]
	[Address(RVA = "0x1E1AB60", Offset = "0x1E1AB60", VA = "0x1E1AB60")]
	public void SetCurrentLoginAID(string aid)
	{
	}

	[Token(Token = "0x60034DB")]
	[Address(RVA = "0x1E1AB68", Offset = "0x1E1AB68", VA = "0x1E1AB68")]
	public void ClearMySkillRecord()
	{
	}

	[Token(Token = "0x60034DC")]
	[Address(RVA = "0x1E1AD3C", Offset = "0x1E1AD3C", VA = "0x1E1AD3C")]
	public void AddMySkillRecord(int id, int damage)
	{
	}

	[Token(Token = "0x60034DD")]
	[Address(RVA = "0x1E1AEC4", Offset = "0x1E1AEC4", VA = "0x1E1AEC4", Slot = "4")]
	public virtual void SaveLocalData()
	{
	}

	[Token(Token = "0x60034DE")]
	[Address(RVA = "0x1E1AF78", Offset = "0x1E1AF78", VA = "0x1E1AF78", Slot = "5")]
	public virtual void ResetTerms()
	{
	}

	[Token(Token = "0x60034DF")]
	[Address(RVA = "0x1E1B038", Offset = "0x1E1B038", VA = "0x1E1B038", Slot = "6")]
	public virtual void ResetGameEvalutate()
	{
	}

	[Token(Token = "0x60034E0")]
	[Address(RVA = "0x1E1B160", Offset = "0x1E1B160", VA = "0x1E1B160")]
	public CharPartyId GetLastSelectParty()
	{
		return default(CharPartyId);
	}

	[Token(Token = "0x60034E1")]
	[Address(RVA = "0x1E1B24C", Offset = "0x1E1B24C", VA = "0x1E1B24C", Slot = "7")]
	public virtual void ResetPartyLocalData()
	{
	}

	[Token(Token = "0x60034E2")]
	[Address(RVA = "0x1E1B3B0", Offset = "0x1E1B3B0", VA = "0x1E1B3B0", Slot = "8")]
	public virtual void ResetEventShopPopupTime()
	{
	}

	[Token(Token = "0x60034E3")]
	[Address(RVA = "0x1E1B534", Offset = "0x1E1B534", VA = "0x1E1B534", Slot = "9")]
	public virtual void SetSelectParty(CharPartyId party, bool CreateIfNotExist = true)
	{
	}

	[Token(Token = "0x60034E4")]
	[Address(RVA = "0x1E1B710", Offset = "0x1E1B710", VA = "0x1E1B710", Slot = "10")]
	public virtual XPartyLocalData GetPartyLocalData(CharPartyId partyId, bool CreateIfNotExist = true)
	{
		return null;
	}

	[Token(Token = "0x60034E5")]
	[Address(RVA = "0x1E1B8F0", Offset = "0x1E1B8F0", VA = "0x1E1B8F0", Slot = "11")]
	public virtual XAccountLocalData GetCurrentAccountData()
	{
		return null;
	}

	[Token(Token = "0x60034E6")]
	[Address(RVA = "0x1E1BA24", Offset = "0x1E1BA24", VA = "0x1E1BA24", Slot = "12")]
	public virtual int GetTagSkillLocalData(int charID)
	{
		return default(int);
	}

	[Token(Token = "0x60034E7")]
	[Address(RVA = "0x1E1BB48", Offset = "0x1E1BB48", VA = "0x1E1BB48", Slot = "13")]
	public virtual void SetTagSkillLocalData(int charID, int tagSkillID)
	{
	}

	[Token(Token = "0x60034E8")]
	[Address(RVA = "0x1E1BD10", Offset = "0x1E1BD10", VA = "0x1E1BD10", Slot = "14")]
	public virtual void SetPartyTalentPage(CharPartyId partyID, int selectTalentPage)
	{
	}

	[Token(Token = "0x60034E9")]
	[Address(RVA = "0x1E1BE24", Offset = "0x1E1BE24", VA = "0x1E1BE24")]
	public bool IsNewRelic(Dictionary<int, int> newShowList)
	{
		return default(bool);
	}

	[Token(Token = "0x60034EA")]
	[Address(RVA = "0x1E1BFC0", Offset = "0x1E1BFC0", VA = "0x1E1BFC0", Slot = "15")]
	public virtual void SetShowedRelic(Dictionary<int, int> newShowList)
	{
	}

	[Token(Token = "0x60034EB")]
	[Address(RVA = "0x1E1C2D8", Offset = "0x1E1C2D8", VA = "0x1E1C2D8")]
	public void SetTitleCount(int titleCount)
	{
	}

	[Token(Token = "0x60034EC")]
	[Address(RVA = "0x1E1C398", Offset = "0x1E1C398", VA = "0x1E1C398")]
	public void ResetTeamMangeData()
	{
	}

	[Token(Token = "0x60034ED")]
	[Address(RVA = "0x1E1C440", Offset = "0x1E1C440", VA = "0x1E1C440")]
	public void SaveRegionData(ConnectEnum.RegionType region)
	{
	}

	[Token(Token = "0x60034EE")]
	[Address(RVA = "0x1E1C500", Offset = "0x1E1C500", VA = "0x1E1C500")]
	public void UpdateMatchingSupplementation(int matchingRoomPing, bool ForceMatchingSupplement = false)
	{
	}

	[Token(Token = "0x60034EF")]
	[Address(RVA = "0x1E1C79C", Offset = "0x1E1C79C", VA = "0x1E1C79C")]
	public bool IsMatchingSupplementation()
	{
		return default(bool);
	}

	[Token(Token = "0x60034F0")]
	[Address(RVA = "0x1E1C78C", Offset = "0x1E1C78C", VA = "0x1E1C78C")]
	public void ResetMatchingSupplementation()
	{
	}

	[Token(Token = "0x60034F1")]
	[Address(RVA = "0x1E1C7A4", Offset = "0x1E1C7A4", VA = "0x1E1C7A4")]
	public void UpdateRankMatchingSupplementation(int roomPingGroup, bool ForceMatchingSupplement = false)
	{
	}

	[Token(Token = "0x60034F2")]
	[Address(RVA = "0x1E1C940", Offset = "0x1E1C940", VA = "0x1E1C940")]
	public bool IsRankMatchingSupplementation()
	{
		return default(bool);
	}

	[Token(Token = "0x60034F3")]
	[Address(RVA = "0x1E1C934", Offset = "0x1E1C934", VA = "0x1E1C934")]
	public void ResetRankMatchingSupplementation()
	{
	}

	[Token(Token = "0x60034F4")]
	[Address(RVA = "0x1E1C948", Offset = "0x1E1C948", VA = "0x1E1C948")]
	public void SaveEventAttendanceLastShowTime(DateTime time)
	{
	}
}
