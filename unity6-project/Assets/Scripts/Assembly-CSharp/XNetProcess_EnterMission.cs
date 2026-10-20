using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007B1")]
public class XNetProcess_EnterMission : XNetProcess_GameBase
{
	[Token(Token = "0x1700089A")]
	public override string Name
	{
		[Token(Token = "0x6003E38")]
		[Address(RVA = "0x2137A90", Offset = "0x2137A90", VA = "0x2137A90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E35")]
	[Address(RVA = "0x2137808", Offset = "0x2137808", VA = "0x2137808")]
	public XNetProcess_EnterMission()
	{
	}

	[Token(Token = "0x6003E36")]
	[Address(RVA = "0x2137810", Offset = "0x2137810", VA = "0x2137810", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E37")]
	[Address(RVA = "0x21378CC", Offset = "0x21378CC", VA = "0x21378CC", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E39")]
	[Address(RVA = "0x2137B08", Offset = "0x2137B08", VA = "0x2137B08", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E3A")]
	[Address(RVA = "0x2137BCC", Offset = "0x2137BCC", VA = "0x2137BCC", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
