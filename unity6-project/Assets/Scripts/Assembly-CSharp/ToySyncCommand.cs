using System;
using Il2CppDummyDll;

[Token(Token = "0x2000BDC")]
public class ToySyncCommand : ICommand
{
	[Token(Token = "0x4003C29")]
	[FieldOffset(Offset = "0x8")]
	public long TimeoutMilsec;

	[Token(Token = "0x4003C2A")]
	[FieldOffset(Offset = "0x10")]
	public bool IsTimeout;

	[Token(Token = "0x4003C2B")]
	[FieldOffset(Offset = "0x14")]
	public Action Work;

	[Token(Token = "0x60055C7")]
	[Address(RVA = "0x1D57924", Offset = "0x1D57924", VA = "0x1D57924")]
	public ToySyncCommand()
	{
	}

	[Token(Token = "0x60055C8")]
	[Address(RVA = "0x1D5793C", Offset = "0x1D5793C", VA = "0x1D5793C", Slot = "4")]
	public void Execute()
	{
	}

	[Token(Token = "0x60055C9")]
	[Address(RVA = "0x1D57A58", Offset = "0x1D57A58", VA = "0x1D57A58")]
	private void WaitProcessing()
	{
	}

	[Token(Token = "0x60055CA")]
	[Address(RVA = "0x1D57B20", Offset = "0x1D57B20", VA = "0x1D57B20")]
	private bool IsProcessing()
	{
		return default(bool);
	}

	[Token(Token = "0x60055CB")]
	[Address(RVA = "0x1D57BD4", Offset = "0x1D57BD4", VA = "0x1D57BD4")]
	private void _003CExecute_003Em__228(object state)
	{
	}
}
