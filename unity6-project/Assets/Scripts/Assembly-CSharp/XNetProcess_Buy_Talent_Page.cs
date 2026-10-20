using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007F5")]
public class XNetProcess_Buy_Talent_Page : XNetProcess_GameBase
{
	[Token(Token = "0x170008DF")]
	public override string Name
	{
		[Token(Token = "0x6003FCE")]
		[Address(RVA = "0x212F010", Offset = "0x212F010", VA = "0x212F010", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003FCB")]
	[Address(RVA = "0x212EE28", Offset = "0x212EE28", VA = "0x212EE28")]
	public XNetProcess_Buy_Talent_Page()
	{
	}

	[Token(Token = "0x6003FCC")]
	[Address(RVA = "0x212EE30", Offset = "0x212EE30", VA = "0x212EE30", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003FCD")]
	[Address(RVA = "0x212EEEC", Offset = "0x212EEEC", VA = "0x212EEEC", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003FCF")]
	[Address(RVA = "0x212F088", Offset = "0x212F088", VA = "0x212F088", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003FD0")]
	[Address(RVA = "0x212F08C", Offset = "0x212F08C", VA = "0x212F08C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
