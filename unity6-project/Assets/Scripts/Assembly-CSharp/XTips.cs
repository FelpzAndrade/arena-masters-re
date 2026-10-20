using System;
using CS;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000683")]
public class XTips
{
	[Token(Token = "0x4001FAF")]
	[FieldOffset(Offset = "0x8")]
	public int m_nID;

	[Token(Token = "0x4001FB0")]
	[FieldOffset(Offset = "0xC")]
	public string m_szTip;

	[Token(Token = "0x4001FB1")]
	[FieldOffset(Offset = "0x10")]
	public int nMinLevel;

	[Token(Token = "0x4001FB2")]
	[FieldOffset(Offset = "0x14")]
	public int nMaxLevel;

	[Token(Token = "0x4001FB3")]
	[FieldOffset(Offset = "0x18")]
	public string strDeathMatch;

	[Token(Token = "0x4001FB4")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_bDeathMatch;

	[Token(Token = "0x4001FB5")]
	[FieldOffset(Offset = "0x20")]
	public string strTeamDeathMatch;

	[Token(Token = "0x4001FB6")]
	[FieldOffset(Offset = "0x24")]
	private bool m_bTeamDeathMatch;

	[Token(Token = "0x4001FB7")]
	[FieldOffset(Offset = "0x28")]
	public string strZombie;

	[Token(Token = "0x4001FB8")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_bZombie;

	[Token(Token = "0x4001FB9")]
	[FieldOffset(Offset = "0x30")]
	public string strCapturePointA;

	[Token(Token = "0x4001FBA")]
	[FieldOffset(Offset = "0x34")]
	private bool m_bCapturePointA;

	[Token(Token = "0x4001FBB")]
	[FieldOffset(Offset = "0x38")]
	public string strZombieTag;

	[Token(Token = "0x4001FBC")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_bZombieTag;

	[Token(Token = "0x4001FBD")]
	[FieldOffset(Offset = "0x40")]
	public string strPoliceVsThief;

	[Token(Token = "0x4001FBE")]
	[FieldOffset(Offset = "0x44")]
	private bool m_bPoliceVsThief;

	[Token(Token = "0x4001FBF")]
	[FieldOffset(Offset = "0x48")]
	public string strRelayMatch;

	[Token(Token = "0x4001FC0")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_bRelayMatch;

	[Token(Token = "0x4001FC1")]
	[FieldOffset(Offset = "0x50")]
	public string strClassic;

	[Token(Token = "0x4001FC2")]
	[FieldOffset(Offset = "0x54")]
	private bool m_bClassic;

	[Token(Token = "0x4001FC3")]
	[FieldOffset(Offset = "0x58")]
	public string strSolo;

	[Token(Token = "0x4001FC4")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_bSolo;

	[Token(Token = "0x4001FC5")]
	[FieldOffset(Offset = "0x60")]
	public string strSpecial;

	[Token(Token = "0x4001FC6")]
	[FieldOffset(Offset = "0x64")]
	private bool m_bSpecial;

	[Token(Token = "0x4001FC7")]
	[FieldOffset(Offset = "0x68")]
	public string strHideAndSeek;

	[Token(Token = "0x4001FC8")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_bHideAndSeek;

	[Token(Token = "0x4001FC9")]
	[FieldOffset(Offset = "0x70")]
	public string strMission;

	[Token(Token = "0x4001FCA")]
	[FieldOffset(Offset = "0x74")]
	private bool m_bMission;

	[Token(Token = "0x4001FCB")]
	[FieldOffset(Offset = "0x78")]
	public float tipsRate;

	[Token(Token = "0x600370A")]
	[Address(RVA = "0x1849588", Offset = "0x1849588", VA = "0x1849588")]
	public XTips()
	{
	}

	[Token(Token = "0x600370B")]
	[Address(RVA = "0x18496D8", Offset = "0x18496D8", VA = "0x18496D8")]
	public bool CheckGameMode(XGameModeType nGameModeType)
	{
		return default(bool);
	}

	[Token(Token = "0x600370C")]
	[Address(RVA = "0x18497C8", Offset = "0x18497C8", VA = "0x18497C8")]
	public bool Cooking()
	{
		return default(bool);
	}
}
