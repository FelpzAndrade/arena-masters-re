using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007F4")]
public class XNetProcess_Buy_Talent_Point : XNetProcess_GameBase
{
	[Token(Token = "0x170008DE")]
	public override string Name
	{
		[Token(Token = "0x6003FC8")]
		[Address(RVA = "0x212F27C", Offset = "0x212F27C", VA = "0x212F27C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003FC5")]
	[Address(RVA = "0x212F094", Offset = "0x212F094", VA = "0x212F094")]
	public XNetProcess_Buy_Talent_Point()
	{
	}

	[Token(Token = "0x6003FC6")]
	[Address(RVA = "0x212F09C", Offset = "0x212F09C", VA = "0x212F09C", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003FC7")]
	[Address(RVA = "0x212F158", Offset = "0x212F158", VA = "0x212F158", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003FC9")]
	[Address(RVA = "0x212F2F4", Offset = "0x212F2F4", VA = "0x212F2F4", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003FCA")]
	[Address(RVA = "0x212F2F8", Offset = "0x212F2F8", VA = "0x212F2F8", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
