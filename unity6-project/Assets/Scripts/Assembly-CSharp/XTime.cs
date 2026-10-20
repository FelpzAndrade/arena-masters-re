using System;
using Il2CppDummyDll;

[Token(Token = "0x2000682")]
public class XTime
{
	[Token(Token = "0x4001FA8")]
	[FieldOffset(Offset = "0x8")]
	private long m_nLastServerTime;

	[Token(Token = "0x4001FA9")]
	[FieldOffset(Offset = "0x10")]
	private long m_LastDateTime;

	[Token(Token = "0x4001FAA")]
	[FieldOffset(Offset = "0x18")]
	private long m_UTC_ServerClientDiff;

	[Token(Token = "0x4001FAB")]
	[FieldOffset(Offset = "0x20")]
	private long m_nLastServerLocalTime;

	[Token(Token = "0x4001FAC")]
	[FieldOffset(Offset = "0x28")]
	private long m_LastLocalDateTime;

	[Token(Token = "0x4001FAD")]
	[FieldOffset(Offset = "0x30")]
	private long m_Local_ServerClientDiff;

	[Token(Token = "0x4001FAE")]
	[FieldOffset(Offset = "0x38")]
	private long m_forceDiffTick;

	[Token(Token = "0x17000803")]
	public virtual DateTime ClientUTCNow
	{
		[Token(Token = "0x60036FE")]
		[Address(RVA = "0x1847D04", Offset = "0x1847D04", VA = "0x1847D04", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x17000804")]
	public virtual DateTime ClientLocalNow
	{
		[Token(Token = "0x60036FF")]
		[Address(RVA = "0x1847DAC", Offset = "0x1847DAC", VA = "0x1847DAC", Slot = "5")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x17000805")]
	public long ServerTime
	{
		[Token(Token = "0x6003700")]
		[Address(RVA = "0x1847E54", Offset = "0x1847E54", VA = "0x1847E54")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6003701")]
		[Address(RVA = "0x1847ED8", Offset = "0x1847ED8", VA = "0x1847ED8")]
		set
		{
		}
	}

	[Token(Token = "0x17000806")]
	public long ServerLocalTime
	{
		[Token(Token = "0x6003702")]
		[Address(RVA = "0x1847F6C", Offset = "0x1847F6C", VA = "0x1847F6C")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6003703")]
		[Address(RVA = "0x1847FF4", Offset = "0x1847FF4", VA = "0x1847FF4")]
		set
		{
		}
	}

	[Token(Token = "0x17000807")]
	public DateTime ServerLocalDateTime
	{
		[Token(Token = "0x6003704")]
		[Address(RVA = "0x1848088", Offset = "0x1848088", VA = "0x1848088")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x17000808")]
	public DateTime ServerDateTime
	{
		[Token(Token = "0x6003705")]
		[Address(RVA = "0x18480C8", Offset = "0x18480C8", VA = "0x18480C8")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x60036FD")]
	[Address(RVA = "0x1847C14", Offset = "0x1847C14", VA = "0x1847C14")]
	public XTime()
	{
	}

	[Token(Token = "0x6003706")]
	[Address(RVA = "0x1848108", Offset = "0x1848108", VA = "0x1848108")]
	public long DifferenceServerUtc_ServerLocal()
	{
		return default(long);
	}

	[Token(Token = "0x6003707")]
	[Address(RVA = "0x1848134", Offset = "0x1848134", VA = "0x1848134")]
	public long DifferenceServerUtc_ClientLocal()
	{
		return default(long);
	}

	[Token(Token = "0x6003708")]
	[Address(RVA = "0x18481B4", Offset = "0x18481B4", VA = "0x18481B4")]
	public DateTime ChangeServerUTCToClientLocalTime(DateTime recordedServerUTCTime)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6003709")]
	[Address(RVA = "0x1848258", Offset = "0x1848258", VA = "0x1848258")]
	public void AddForceTick(long tick)
	{
	}
}
