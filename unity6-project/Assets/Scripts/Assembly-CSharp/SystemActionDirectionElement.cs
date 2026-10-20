using System;
using Il2CppDummyDll;

[Token(Token = "0x2000CDD")]
public class SystemActionDirectionElement : UIDirectionElement
{
	[Token(Token = "0x4004195")]
	[FieldOffset(Offset = "0x8")]
	private bool isFinished;

	[Token(Token = "0x4004196")]
	[FieldOffset(Offset = "0x9")]
	private bool isStarted;

	[Token(Token = "0x4004197")]
	[FieldOffset(Offset = "0xC")]
	private Action action;

	[Token(Token = "0x6005CE8")]
	[Address(RVA = "0x1D49594", Offset = "0x1D49594", VA = "0x1D49594")]
	public SystemActionDirectionElement(Action action)
	{
	}

	[Token(Token = "0x6005CE9")]
	[Address(RVA = "0x1D495B4", Offset = "0x1D495B4", VA = "0x1D495B4", Slot = "4")]
	public void Start()
	{
	}

	[Token(Token = "0x6005CEA")]
	[Address(RVA = "0x1D495EC", Offset = "0x1D495EC", VA = "0x1D495EC", Slot = "5")]
	public void Update()
	{
	}

	[Token(Token = "0x6005CEB")]
	[Address(RVA = "0x1D495F0", Offset = "0x1D495F0", VA = "0x1D495F0", Slot = "7")]
	public void Skip()
	{
	}

	[Token(Token = "0x6005CEC")]
	[Address(RVA = "0x1D49600", Offset = "0x1D49600", VA = "0x1D49600", Slot = "6")]
	public bool IsFinished()
	{
		return default(bool);
	}
}
