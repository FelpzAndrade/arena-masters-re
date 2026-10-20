using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000621")]
public class XAccountLocalData
{
	[Token(Token = "0x4001D7D")]
	[FieldOffset(Offset = "0x8")]
	public DateTime EventAttendanceLastShowTime;

	[Token(Token = "0x4001D7E")]
	[FieldOffset(Offset = "0x18")]
	public int LastSelectedParty;

	[Token(Token = "0x4001D7F")]
	[FieldOffset(Offset = "0x1C")]
	public Dictionary<int, XPartyLocalData> partyLocalData;

	[Token(Token = "0x4001D80")]
	[FieldOffset(Offset = "0x20")]
	public IncreasableDictionary<int> tagSkillData;

	[Token(Token = "0x4001D81")]
	[FieldOffset(Offset = "0x24")]
	public bool Game_evaluate_done_state;

	[Token(Token = "0x4001D82")]
	[FieldOffset(Offset = "0x28")]
	public int Game_evaluate_winning_streak_count;

	[Token(Token = "0x4001D83")]
	[FieldOffset(Offset = "0x2C")]
	public KeyValuePair<int, int> clanBoxProgress;

	[Token(Token = "0x60034D0")]
	[Address(RVA = "0x17B5E0C", Offset = "0x17B5E0C", VA = "0x17B5E0C")]
	public XAccountLocalData()
	{
	}

	[Token(Token = "0x60034D1")]
	[Address(RVA = "0x17B5EEC", Offset = "0x17B5EEC", VA = "0x17B5EEC", Slot = "4")]
	public virtual void SetSelectParty(CharPartyId party)
	{
	}

	[Token(Token = "0x60034D2")]
	[Address(RVA = "0x17B5EF4", Offset = "0x17B5EF4", VA = "0x17B5EF4", Slot = "5")]
	public virtual XPartyLocalData GetPartyLocalData(CharPartyId partyId, bool CreateIfNotExist = true)
	{
		return null;
	}

	[Token(Token = "0x60034D3")]
	[Address(RVA = "0x17B6040", Offset = "0x17B6040", VA = "0x17B6040")]
	public CharPartyId GetLastSelectParty()
	{
		return default(CharPartyId);
	}

	[Token(Token = "0x60034D4")]
	[Address(RVA = "0x17B6048", Offset = "0x17B6048", VA = "0x17B6048", Slot = "6")]
	public virtual void ResetPartyLocalData()
	{
	}

	[Token(Token = "0x60034D5")]
	[Address(RVA = "0x17B60E0", Offset = "0x17B60E0", VA = "0x17B60E0", Slot = "7")]
	public virtual int GetTagSkillData(int charID)
	{
		return default(int);
	}

	[Token(Token = "0x60034D6")]
	[Address(RVA = "0x17B6184", Offset = "0x17B6184", VA = "0x17B6184", Slot = "8")]
	public virtual void ResetGameEvalutate()
	{
	}
}
