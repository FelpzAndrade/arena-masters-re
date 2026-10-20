using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x20008C9")]
public class Regulator : IRegulator
{
	[Token(Token = "0x4002AD1")]
	[FieldOffset(Offset = "0x8")]
	private long m_UpdateTickMS;

	[Token(Token = "0x4002AD2")]
	[FieldOffset(Offset = "0x10")]
	private Stopwatch m_kTimeTick;

	[Token(Token = "0x60046F2")]
	[Address(RVA = "0x20EBC14", Offset = "0x20EBC14", VA = "0x20EBC14")]
	public Regulator(long _UpdateTickMS)
	{
	}

	[Token(Token = "0x60046F3")]
	[Address(RVA = "0x20EBCE0", Offset = "0x20EBCE0", VA = "0x20EBCE0")]
	public void RestartUpdateTickMS(long _UpdateTickMS)
	{
	}

	[Token(Token = "0x60046F4")]
	[Address(RVA = "0x20EBD34", Offset = "0x20EBD34", VA = "0x20EBD34", Slot = "4")]
	public void Start()
	{
	}

	[Token(Token = "0x60046F5")]
	[Address(RVA = "0x20EBD60", Offset = "0x20EBD60", VA = "0x20EBD60", Slot = "5")]
	public void Stop()
	{
	}

	[Token(Token = "0x60046F6")]
	[Address(RVA = "0x20EBD8C", Offset = "0x20EBD8C", VA = "0x20EBD8C", Slot = "6")]
	public void Reset()
	{
	}

	[Token(Token = "0x60046F7")]
	[Address(RVA = "0x20EBCF0", Offset = "0x20EBCF0", VA = "0x20EBCF0", Slot = "7")]
	public void Restart()
	{
	}

	[Token(Token = "0x60046F8")]
	[Address(RVA = "0x20EBDB8", Offset = "0x20EBDB8", VA = "0x20EBDB8", Slot = "8")]
	public bool IsUpdate()
	{
		return default(bool);
	}

	[Token(Token = "0x60046F9")]
	[Address(RVA = "0x20EBE40", Offset = "0x20EBE40", VA = "0x20EBE40")]
	private double GetElapsedMSTick()
	{
		return default(double);
	}

	[Token(Token = "0x60046FA")]
	[Address(RVA = "0x20EBE14", Offset = "0x20EBE14", VA = "0x20EBE14", Slot = "9")]
	public bool IsRunning()
	{
		return default(bool);
	}
}
