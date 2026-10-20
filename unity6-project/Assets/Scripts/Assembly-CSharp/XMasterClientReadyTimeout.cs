using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000573")]
public class XMasterClientReadyTimeout
{
	[Token(Token = "0x4001AE4")]
	[FieldOffset(Offset = "0x8")]
	private int m_nCountTime;

	[Token(Token = "0x4001AE5")]
	[FieldOffset(Offset = "0xC")]
	private float m_fElapsedTime;

	[Token(Token = "0x4001AE6")]
	[FieldOffset(Offset = "0x10")]
	private int m_nCounter;

	[Token(Token = "0x4001AE7")]
	[FieldOffset(Offset = "0x14")]
	private bool m_bUpdate;

	[Token(Token = "0x6002E50")]
	[Address(RVA = "0x1E2D48C", Offset = "0x1E2D48C", VA = "0x1E2D48C")]
	public XMasterClientReadyTimeout()
	{
	}

	[Token(Token = "0x6002E51")]
	[Address(RVA = "0x1E2D49C", Offset = "0x1E2D49C", VA = "0x1E2D49C")]
	public void Init(int nCountTime)
	{
	}

	[Token(Token = "0x6002E52")]
	[Address(RVA = "0x1E2D4B4", Offset = "0x1E2D4B4", VA = "0x1E2D4B4")]
	public bool Update(bool bMasterClient, GameModeInfo gameModeInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E53")]
	[Address(RVA = "0x1E2D808", Offset = "0x1E2D808", VA = "0x1E2D808")]
	private void SendReadyTimeoutMessage(int _nCounter)
	{
	}

	[Token(Token = "0x6002E54")]
	[Address(RVA = "0x1E2D684", Offset = "0x1E2D684", VA = "0x1E2D684")]
	public void ShowMessage(int n)
	{
	}

	[Token(Token = "0x6002E55")]
	[Address(RVA = "0x1E2D554", Offset = "0x1E2D554", VA = "0x1E2D554")]
	private bool CheckStart(GameModeInfo gameModeInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E56")]
	[Address(RVA = "0x1E2D978", Offset = "0x1E2D978", VA = "0x1E2D978")]
	private void CountStart()
	{
	}

	[Token(Token = "0x6002E57")]
	[Address(RVA = "0x1E2D9A0", Offset = "0x1E2D9A0", VA = "0x1E2D9A0")]
	private void CountStop()
	{
	}

	[Token(Token = "0x6002E58")]
	[Address(RVA = "0x1E2D9B4", Offset = "0x1E2D9B4", VA = "0x1E2D9B4")]
	public void SyncTimeCount(int _count)
	{
	}
}
