using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000850")]
public class XPhotonNetworkRoundTrip
{
	[Token(Token = "0x40023EB")]
	private const int m_SeedCount = 3;

	[Token(Token = "0x40023EC")]
	[FieldOffset(Offset = "0x8")]
	private Regulator RoundTripUpdater;

	[Token(Token = "0x40023ED")]
	[FieldOffset(Offset = "0xC")]
	private Regulator SendPingUpdater;

	[Token(Token = "0x40023EE")]
	[FieldOffset(Offset = "0x10")]
	private Queue<int> liRoundTripTime;

	[Token(Token = "0x40023EF")]
	[FieldOffset(Offset = "0x14")]
	private int m_avgRoundTrip;

	[Token(Token = "0x60044F5")]
	[Address(RVA = "0xB0B488", Offset = "0xB0B488", VA = "0xB0B488")]
	public XPhotonNetworkRoundTrip()
	{
	}

	[Token(Token = "0x60044F6")]
	[Address(RVA = "0xB0C018", Offset = "0xB0C018", VA = "0xB0C018")]
	public void Init(int updateInterval)
	{
	}

	[Token(Token = "0x60044F7")]
	[Address(RVA = "0xB0C300", Offset = "0xB0C300", VA = "0xB0C300")]
	public void Update(bool _firstUpdate = false)
	{
	}

	[Token(Token = "0x60044F8")]
	[Address(RVA = "0xB0D228", Offset = "0xB0D228", VA = "0xB0D228")]
	public int GetPing()
	{
		return default(int);
	}

	[Token(Token = "0x60044F9")]
	[Address(RVA = "0xB24920", Offset = "0xB24920", VA = "0xB24920")]
	private bool IsEnableSendPingState()
	{
		return default(bool);
	}
}
