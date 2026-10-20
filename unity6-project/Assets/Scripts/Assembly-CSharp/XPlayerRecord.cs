using System;
using CS;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20005BC")]
public sealed class XPlayerRecord
{
	[Token(Token = "0x4001BBB")]
	[FieldOffset(Offset = "0x8")]
	public CSPlayerState lastState;

	[Token(Token = "0x4001BBC")]
	[FieldOffset(Offset = "0xC")]
	public CSWinlose[] RoundResult;

	[Token(Token = "0x4001BBD")]
	[FieldOffset(Offset = "0x10")]
	public int stayAsHuman;

	[Token(Token = "0x4001BBE")]
	[FieldOffset(Offset = "0x14")]
	public XTeamEnum team;

	[Token(Token = "0x4001BBF")]
	[FieldOffset(Offset = "0x18")]
	public ObscuredInt hitCount;

	[Token(Token = "0x4001BC0")]
	[FieldOffset(Offset = "0x28")]
	public ObscuredInt killCount;

	[Token(Token = "0x4001BC1")]
	[FieldOffset(Offset = "0x38")]
	public ObscuredInt killZombieCount;

	[Token(Token = "0x4001BC2")]
	[FieldOffset(Offset = "0x48")]
	public ObscuredInt assistCount;

	[Token(Token = "0x4001BC3")]
	[FieldOffset(Offset = "0x58")]
	public ObscuredInt deathCount;

	[Token(Token = "0x4001BC4")]
	[FieldOffset(Offset = "0x68")]
	public ObscuredInt boxCount;

	[Token(Token = "0x4001BC5")]
	[FieldOffset(Offset = "0x78")]
	public ObscuredInt param1;

	[Token(Token = "0x4001BC6")]
	[FieldOffset(Offset = "0x88")]
	public ObscuredInt param2;

	[Token(Token = "0x4001BC7")]
	[FieldOffset(Offset = "0x98")]
	public ObscuredInt totalScore;

	[Token(Token = "0x4001BC8")]
	[FieldOffset(Offset = "0xA8")]
	public ObscuredInt tagZombieToHumanCount;

	[Token(Token = "0x4001BC9")]
	[FieldOffset(Offset = "0xB8")]
	public ObscuredInt zombieInfectCnt;

	[Token(Token = "0x4001BCA")]
	[FieldOffset(Offset = "0xC8")]
	public ObscuredInt rank;

	[Token(Token = "0x4001BCB")]
	[FieldOffset(Offset = "0xD8")]
	public bool escaped;

	[Token(Token = "0x4001BCC")]
	[FieldOffset(Offset = "0xDC")]
	public ObscuredInt earnGold;

	[Token(Token = "0x4001BCD")]
	[FieldOffset(Offset = "0xEC")]
	public bool host;

	[Token(Token = "0x4001BCE")]
	[FieldOffset(Offset = "0xED")]
	public bool isCharDataLoaded;

	[Token(Token = "0x4001BCF")]
	[FieldOffset(Offset = "0xF0")]
	public ObscuredFloat hp;

	[Token(Token = "0x4001BD0")]
	[FieldOffset(Offset = "0x104")]
	public ObscuredFloat ultCharge;

	[Token(Token = "0x4001BD1")]
	[FieldOffset(Offset = "0x118")]
	public ObscuredShort elo;

	[Token(Token = "0x4001BD2")]
	[FieldOffset(Offset = "0x120")]
	public int gameState;

	[Token(Token = "0x4001BD3")]
	[FieldOffset(Offset = "0x124")]
	public ObscuredInt hpRatio;

	[Token(Token = "0x1700076F")]
	public bool mvp
	{
		[Token(Token = "0x60030F4")]
		[Address(RVA = "0x1C8222C", Offset = "0x1C8222C", VA = "0x1C8222C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000770")]
	public int RoundWinCount
	{
		[Token(Token = "0x60030F5")]
		[Address(RVA = "0x1C82300", Offset = "0x1C82300", VA = "0x1C82300")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000771")]
	public int RoundLoseCount
	{
		[Token(Token = "0x60030F6")]
		[Address(RVA = "0x1C82364", Offset = "0x1C82364", VA = "0x1C82364")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000772")]
	public int RoundDrawCount
	{
		[Token(Token = "0x60030F7")]
		[Address(RVA = "0x1C823C8", Offset = "0x1C823C8", VA = "0x1C823C8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000773")]
	public bool IsDuelPerfectWin
	{
		[Token(Token = "0x60030F8")]
		[Address(RVA = "0x1C8242C", Offset = "0x1C8242C", VA = "0x1C8242C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60030F2")]
	[Address(RVA = "0x1C8209C", Offset = "0x1C8209C", VA = "0x1C8209C")]
	public XPlayerRecord()
	{
	}

	[Token(Token = "0x60030F3")]
	[Address(RVA = "0x1C8213C", Offset = "0x1C8213C", VA = "0x1C8213C")]
	public XPlayerRecord(XPlayerRecord other)
	{
	}

	[Token(Token = "0x60030F9")]
	[Address(RVA = "0x1C82500", Offset = "0x1C82500", VA = "0x1C82500")]
	public PlayerGameRecord MakeGameRecord()
	{
		return null;
	}

	[Token(Token = "0x60030FA")]
	[Address(RVA = "0x1C82738", Offset = "0x1C82738", VA = "0x1C82738")]
	public void SetPlayerGameRecord(PlayerGameRecord gameRecord)
	{
	}

	[Token(Token = "0x60030FB")]
	[Address(RVA = "0x1C82954", Offset = "0x1C82954", VA = "0x1C82954")]
	public void SetPlayerGameRecordPoliceVsThief(PlayerGameRecord gameRecord)
	{
	}
}
