using System;
using CS;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20005BB")]
public sealed class XPlayer
{
	[Token(Token = "0x4001BA1")]
	[FieldOffset(Offset = "0x8")]
	public int charId;

	[Token(Token = "0x4001BA2")]
	[FieldOffset(Offset = "0xC")]
	public int charId2;

	[Token(Token = "0x4001BA3")]
	[FieldOffset(Offset = "0x10")]
	public int charSkinId;

	[Token(Token = "0x4001BA4")]
	[FieldOffset(Offset = "0x14")]
	public int charSkinId2;

	[Token(Token = "0x4001BA5")]
	[FieldOffset(Offset = "0x18")]
	public bool mine;

	[Token(Token = "0x4001BA6")]
	[FieldOffset(Offset = "0x1C")]
	public int id;

	[Token(Token = "0x4001BA7")]
	[FieldOffset(Offset = "0x20")]
	public string iconName;

	[Token(Token = "0x4001BA8")]
	[FieldOffset(Offset = "0x24")]
	public int level;

	[Token(Token = "0x4001BA9")]
	[FieldOffset(Offset = "0x28")]
	public int level2;

	[Token(Token = "0x4001BAA")]
	[FieldOffset(Offset = "0x2C")]
	public string aid;

	[Token(Token = "0x4001BAB")]
	[FieldOffset(Offset = "0x30")]
	public string nickname;

	[Token(Token = "0x4001BAC")]
	[FieldOffset(Offset = "0x34")]
	public string countryCode;

	[Token(Token = "0x4001BAD")]
	[FieldOffset(Offset = "0x38")]
	public string characterName;

	[Token(Token = "0x4001BAE")]
	[FieldOffset(Offset = "0x3C")]
	public short profileIconId;

	[Token(Token = "0x4001BAF")]
	[FieldOffset(Offset = "0x3E")]
	public short titleId;

	[Token(Token = "0x4001BB0")]
	[FieldOffset(Offset = "0x40")]
	public int relicId;

	[Token(Token = "0x4001BB1")]
	[FieldOffset(Offset = "0x44")]
	public int relicLevel;

	[Token(Token = "0x4001BB2")]
	[FieldOffset(Offset = "0x48")]
	public bool isPlacementTest;

	[Token(Token = "0x4001BB3")]
	[FieldOffset(Offset = "0x4C")]
	public string clanName;

	[Token(Token = "0x4001BB4")]
	[FieldOffset(Offset = "0x50")]
	public int clanMarkId;

	[Token(Token = "0x4001BB5")]
	[FieldOffset(Offset = "0x54")]
	public int clanColorId;

	[Token(Token = "0x4001BB6")]
	[FieldOffset(Offset = "0x58")]
	public int petId;

	[Token(Token = "0x4001BB7")]
	[FieldOffset(Offset = "0x5C")]
	private XPlayerRecord m_PlayerRecord;

	[Token(Token = "0x4001BB8")]
	[FieldOffset(Offset = "0x60")]
	private long m_nChecksum;

	[Token(Token = "0x4001BB9")]
	[FieldOffset(Offset = "0x68")]
	public bool IsReady;

	[Token(Token = "0x4001BBA")]
	[FieldOffset(Offset = "0x6C")]
	private int Ping__BackingField;

	[Token(Token = "0x1700076D")]
	public XPlayerRecord PlayerRecord
	{
		[Token(Token = "0x60030E8")]
		[Address(RVA = "0xAB5EB0", Offset = "0xAB5EB0", VA = "0xAB5EB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60030E9")]
		[Address(RVA = "0xAB5EA8", Offset = "0xAB5EA8", VA = "0xAB5EA8")]
		set
		{
		}
	}

	[Token(Token = "0x1700076E")]
	public int Ping
	{
		[Token(Token = "0x60030EA")]
		[Address(RVA = "0xB26E94", Offset = "0xB26E94", VA = "0xB26E94")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60030EB")]
		[Address(RVA = "0xB24B1C", Offset = "0xB24B1C", VA = "0xB24B1C")]
		set
		{
		}
	}

	[Token(Token = "0x60030E3")]
	[Address(RVA = "0xAB5DF8", Offset = "0xAB5DF8", VA = "0xAB5DF8")]
	public XPlayer()
	{
	}

	[Token(Token = "0x60030E4")]
	[Address(RVA = "0xB264F8", Offset = "0xB264F8", VA = "0xB264F8")]
	public XPlayer(XPlayer other)
	{
	}

	[Token(Token = "0x60030E5")]
	[Address(RVA = "0xB2699C", Offset = "0xB2699C", VA = "0xB2699C")]
	private long MakeChecksum()
	{
		return default(long);
	}

	[Token(Token = "0x60030E6")]
	[Address(RVA = "0xB26BCC", Offset = "0xB26BCC", VA = "0xB26BCC")]
	internal string[] GetCharactersInfoString()
	{
		return null;
	}

	[Token(Token = "0x60030E7")]
	[Address(RVA = "0xB18F70", Offset = "0xB18F70", VA = "0xB18F70")]
	public bool CheckChecksum()
	{
		return default(bool);
	}

	[Token(Token = "0x60030EC")]
	[Address(RVA = "0xB26E9C", Offset = "0xB26E9C", VA = "0xB26E9C")]
	public NetData_TeamInfo Generate_NetData_TeamInfo()
	{
		return null;
	}

	[Token(Token = "0x60030ED")]
	[Address(RVA = "0xB26F60", Offset = "0xB26F60", VA = "0xB26F60")]
	public void SetFrom_NetDataTeamInfo(NetData_TeamInfo netTeamInfo)
	{
	}

	[Token(Token = "0x60030EE")]
	[Address(RVA = "0xB26F90", Offset = "0xB26F90", VA = "0xB26F90")]
	public NetData_Record Generate_NetData_Record()
	{
		return null;
	}

	[Token(Token = "0x60030EF")]
	[Address(RVA = "0xB236A4", Offset = "0xB236A4", VA = "0xB236A4")]
	public void SetFrom_NetDataRecord(NetData_Record netDataRecord)
	{
	}

	[Token(Token = "0x60030F0")]
	[Address(RVA = "0xB18FA0", Offset = "0xB18FA0", VA = "0xB18FA0")]
	public NetData_PlayerInfo Generate_MyNetData_PlayerInfo(XGameModeType type)
	{
		return null;
	}

	[Token(Token = "0x60030F1")]
	[Address(RVA = "0xB274B0", Offset = "0xB274B0", VA = "0xB274B0")]
	public void SetFrom_NetData_PlayerInfo(NetData_PlayerInfo netData)
	{
	}
}
