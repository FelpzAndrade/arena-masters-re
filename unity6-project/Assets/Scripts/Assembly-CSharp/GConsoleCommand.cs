using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x200002B")]
public class GConsoleCommand
{
	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public string helpText;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Func<string, string> method;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string description;

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x1F2F240", Offset = "0x1F2F240", VA = "0x1F2F240")]
	public GConsoleCommand(string description, Func<string, string> method, [Optional] string helpText)
	{
	}
}
