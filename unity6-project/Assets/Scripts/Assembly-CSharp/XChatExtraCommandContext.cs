using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20003D7")]
public class XChatExtraCommandContext
{
	[Token(Token = "0x4001351")]
	[FieldOffset(Offset = "0x8")]
	private string Sender__BackingField;

	[Token(Token = "0x4001352")]
	[FieldOffset(Offset = "0xC")]
	private string Message__BackingField;

	[Token(Token = "0x4001353")]
	[FieldOffset(Offset = "0x10")]
	private List<string> Params__BackingField;

	[Token(Token = "0x1700054B")]
	public string Sender
	{
		[Token(Token = "0x6001F64")]
		[Address(RVA = "0x1AC1C5C", Offset = "0x1AC1C5C", VA = "0x1AC1C5C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F65")]
		[Address(RVA = "0x1AC1C44", Offset = "0x1AC1C44", VA = "0x1AC1C44")]
		private set
		{
		}
	}

	[Token(Token = "0x1700054C")]
	public string Message
	{
		[Token(Token = "0x6001F66")]
		[Address(RVA = "0x1AC1C64", Offset = "0x1AC1C64", VA = "0x1AC1C64")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F67")]
		[Address(RVA = "0x1AC1C4C", Offset = "0x1AC1C4C", VA = "0x1AC1C4C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700054D")]
	public List<string> Params
	{
		[Token(Token = "0x6001F68")]
		[Address(RVA = "0x1AC1C6C", Offset = "0x1AC1C6C", VA = "0x1AC1C6C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F69")]
		[Address(RVA = "0x1AC1C54", Offset = "0x1AC1C54", VA = "0x1AC1C54")]
		private set
		{
		}
	}

	[Token(Token = "0x6001F63")]
	[Address(RVA = "0x1AC1C14", Offset = "0x1AC1C14", VA = "0x1AC1C14")]
	public XChatExtraCommandContext(string _sender, string _message, List<string> _param)
	{
	}
}
