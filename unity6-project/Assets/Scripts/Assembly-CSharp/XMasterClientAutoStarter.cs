using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000572")]
public class XMasterClientAutoStarter
{
	[Token(Token = "0x4001AE0")]
	[FieldOffset(Offset = "0x8")]
	private int m_nCountTime;

	[Token(Token = "0x4001AE1")]
	[FieldOffset(Offset = "0xC")]
	private float m_fElapsedTime;

	[Token(Token = "0x4001AE2")]
	[FieldOffset(Offset = "0x10")]
	private int m_nCounter;

	[Token(Token = "0x4001AE3")]
	[FieldOffset(Offset = "0x14")]
	private bool m_bUpdate;

	[Token(Token = "0x6002E49")]
	[Address(RVA = "0x1E2CB54", Offset = "0x1E2CB54", VA = "0x1E2CB54")]
	public XMasterClientAutoStarter()
	{
	}

	[Token(Token = "0x6002E4A")]
	[Address(RVA = "0x1E2CB64", Offset = "0x1E2CB64", VA = "0x1E2CB64")]
	public void Init(int nCountTime)
	{
	}

	[Token(Token = "0x6002E4B")]
	[Address(RVA = "0x1E2CB7C", Offset = "0x1E2CB7C", VA = "0x1E2CB7C")]
	public bool Update(bool bMasterClient, GameModeInfo gameModeInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E4C")]
	[Address(RVA = "0x1E2CE88", Offset = "0x1E2CE88", VA = "0x1E2CE88")]
	public void ShowMessage(int n)
	{
	}

	[Token(Token = "0x6002E4D")]
	[Address(RVA = "0x1E2CD58", Offset = "0x1E2CD58", VA = "0x1E2CD58")]
	private bool CheckStart(GameModeInfo gameModeInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E4E")]
	[Address(RVA = "0x1E2D00C", Offset = "0x1E2D00C", VA = "0x1E2D00C")]
	private void CountStart()
	{
	}

	[Token(Token = "0x6002E4F")]
	[Address(RVA = "0x1E2D034", Offset = "0x1E2D034", VA = "0x1E2D034")]
	private void CountStop()
	{
	}
}
