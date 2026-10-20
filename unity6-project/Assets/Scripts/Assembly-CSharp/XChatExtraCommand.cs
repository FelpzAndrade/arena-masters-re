using System;
using Il2CppDummyDll;

[Token(Token = "0x20003D8")]
public class XChatExtraCommand
{
	[Token(Token = "0x4001354")]
	[FieldOffset(Offset = "0x8")]
	private string Desc__BackingField;

	[Token(Token = "0x4001355")]
	[FieldOffset(Offset = "0xC")]
	private Func<XChatExtraCommandContext, bool> Function__BackingField;

	[Token(Token = "0x1700054E")]
	public string Desc
	{
		[Token(Token = "0x6001F6B")]
		[Address(RVA = "0x1AC1C04", Offset = "0x1AC1C04", VA = "0x1AC1C04")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F6C")]
		[Address(RVA = "0x1AC1BF4", Offset = "0x1AC1BF4", VA = "0x1AC1BF4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700054F")]
	public Func<XChatExtraCommandContext, bool> Function
	{
		[Token(Token = "0x6001F6D")]
		[Address(RVA = "0x1AC1C0C", Offset = "0x1AC1C0C", VA = "0x1AC1C0C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F6E")]
		[Address(RVA = "0x1AC1BFC", Offset = "0x1AC1BFC", VA = "0x1AC1BFC")]
		private set
		{
		}
	}

	[Token(Token = "0x6001F6A")]
	[Address(RVA = "0x1AC1BCC", Offset = "0x1AC1BCC", VA = "0x1AC1BCC")]
	public XChatExtraCommand(string _desc, Func<XChatExtraCommandContext, bool> _function)
	{
	}
}
