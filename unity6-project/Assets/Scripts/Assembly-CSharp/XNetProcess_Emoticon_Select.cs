using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000792")]
public class XNetProcess_Emoticon_Select : XNetProcess_GameBase
{
	[Token(Token = "0x17000875")]
	public override string Name
	{
		[Token(Token = "0x6003D72")]
		[Address(RVA = "0x2135CB8", Offset = "0x2135CB8", VA = "0x2135CB8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003D6F")]
	[Address(RVA = "0x2135AD0", Offset = "0x2135AD0", VA = "0x2135AD0")]
	public XNetProcess_Emoticon_Select()
	{
	}

	[Token(Token = "0x6003D70")]
	[Address(RVA = "0x2135AD8", Offset = "0x2135AD8", VA = "0x2135AD8", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003D71")]
	[Address(RVA = "0x2135B94", Offset = "0x2135B94", VA = "0x2135B94", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003D73")]
	[Address(RVA = "0x2135D30", Offset = "0x2135D30", VA = "0x2135D30", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003D74")]
	[Address(RVA = "0x2135D34", Offset = "0x2135D34", VA = "0x2135D34", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
