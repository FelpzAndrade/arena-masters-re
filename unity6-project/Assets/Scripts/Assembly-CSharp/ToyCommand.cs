using System;
using Il2CppDummyDll;

[Token(Token = "0x2000BDB")]
public class ToyCommand : ICommand
{
	[Token(Token = "0x4003C28")]
	[FieldOffset(Offset = "0x8")]
	public Action Work;

	[Token(Token = "0x60055C3")]
	[Address(RVA = "0x1D54B88", Offset = "0x1D54B88", VA = "0x1D54B88")]
	public ToyCommand()
	{
	}

	[Token(Token = "0x60055C4")]
	[Address(RVA = "0x1D4FA34", Offset = "0x1D4FA34", VA = "0x1D4FA34")]
	public static void ExecuteByPool(Action action)
	{
	}

	[Token(Token = "0x60055C5")]
	[Address(RVA = "0x1D54B90", Offset = "0x1D54B90", VA = "0x1D54B90")]
	public void ExecuteByPool()
	{
	}

	[Token(Token = "0x60055C6")]
	[Address(RVA = "0x1D54D08", Offset = "0x1D54D08", VA = "0x1D54D08", Slot = "4")]
	public void Execute()
	{
	}
}
