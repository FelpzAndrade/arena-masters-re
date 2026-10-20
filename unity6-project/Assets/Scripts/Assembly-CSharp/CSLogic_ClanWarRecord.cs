using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000926")]
public struct CSLogic_ClanWarRecord
{
	[Token(Token = "0x4002D56")]
	[FieldOffset(Offset = "0x0")]
	private ClanWarRecord m_ClanWarRecord;

	[Token(Token = "0x4002D57")]
	[FieldOffset(Offset = "0x4")]
	private CSWinlose m_winLose;

	[Token(Token = "0x6004904")]
	[Address(RVA = "0x21F2278", Offset = "0x21F2278", VA = "0x21F2278")]
	public CSLogic_ClanWarRecord(ClanWarRecord clanWarRecord, CSWinlose winLose)
	{
		this = default;
	}

	[Token(Token = "0x6004905")]
	[Address(RVA = "0x21F2750", Offset = "0x21F2750", VA = "0x21F2750")]
	public void Update()
	{
	}

	[Token(Token = "0x6004906")]
	[Address(RVA = "0x21F2770", Offset = "0x21F2770", VA = "0x21F2770")]
	private void AdjustWinLose()
	{
	}

	[Token(Token = "0x6004907")]
	[Address(RVA = "0x21F2778", Offset = "0x21F2778", VA = "0x21F2778")]
	private void AdjustWinRate()
	{
	}
}
