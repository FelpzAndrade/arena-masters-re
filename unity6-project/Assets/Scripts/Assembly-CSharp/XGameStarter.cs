using CS;
using Il2CppDummyDll;

[Token(Token = "0x20004E5")]
public class XGameStarter
{
	[Token(Token = "0x20004E6")]
	protected enum StarterState
	{
		[Token(Token = "0x40018D1")]
		PVP = 0,
		[Token(Token = "0x40018D2")]
		PVE = 1,
		[Token(Token = "0x40018D3")]
		PVPEvent = 2,
		[Token(Token = "0x40018D4")]
		CUSTOM_ROOM = 3
	}

	[Token(Token = "0x40018CF")]
	[FieldOffset(Offset = "0x8")]
	protected StarterState m_state;

	[Token(Token = "0x6002A7A")]
	[Address(RVA = "0x1D11DFC", Offset = "0x1D11DFC", VA = "0x1D11DFC")]
	public XGameStarter()
	{
	}

	[Token(Token = "0x6002A7B")]
	[Address(RVA = "0x1D11E04", Offset = "0x1D11E04", VA = "0x1D11E04")]
	public bool IsPVP()
	{
		return default(bool);
	}

	[Token(Token = "0x6002A7C")]
	[Address(RVA = "0x1D11E18", Offset = "0x1D11E18", VA = "0x1D11E18")]
	public bool IsPVPEvent()
	{
		return default(bool);
	}

	[Token(Token = "0x6002A7D")]
	[Address(RVA = "0x1D11E2C", Offset = "0x1D11E2C", VA = "0x1D11E2C")]
	public bool IsPVE()
	{
		return default(bool);
	}

	[Token(Token = "0x6002A7E")]
	[Address(RVA = "0x1D11E3C", Offset = "0x1D11E3C", VA = "0x1D11E3C")]
	public bool IsCustomRoom()
	{
		return default(bool);
	}

	[Token(Token = "0x6002A7F")]
	[Address(RVA = "0x1D11E50", Offset = "0x1D11E50", VA = "0x1D11E50", Slot = "4")]
	public virtual XGameModeType GetGameModeType()
	{
		return default(XGameModeType);
	}

	[Token(Token = "0x6002A80")]
	[Address(RVA = "0x1D11E58", Offset = "0x1D11E58", VA = "0x1D11E58")]
	protected static bool HandleApiReturnCode(ApiReturnCode ret, int limitTeamLevel)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A81")]
	[Address(RVA = "0x1D1249C", Offset = "0x1D1249C", VA = "0x1D1249C", Slot = "5")]
	public virtual bool Start()
	{
		return default(bool);
	}

	[Token(Token = "0x6002A82")]
	[Address(RVA = "0x1D124A0", Offset = "0x1D124A0", VA = "0x1D124A0")]
	public bool CheckStartCondition()
	{
		return default(bool);
	}
}
