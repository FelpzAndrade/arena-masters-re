using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007B2")]
public class XNetProcess_EnterSkyTower : XNetProcess_GameBase
{
	[Token(Token = "0x1700089B")]
	public override string Name
	{
		[Token(Token = "0x6003E3E")]
		[Address(RVA = "0x2137E6C", Offset = "0x2137E6C", VA = "0x2137E6C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E3B")]
	[Address(RVA = "0x2137BE4", Offset = "0x2137BE4", VA = "0x2137BE4")]
	public XNetProcess_EnterSkyTower()
	{
	}

	[Token(Token = "0x6003E3C")]
	[Address(RVA = "0x2137BEC", Offset = "0x2137BEC", VA = "0x2137BEC", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E3D")]
	[Address(RVA = "0x2137CA8", Offset = "0x2137CA8", VA = "0x2137CA8", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E3F")]
	[Address(RVA = "0x2137EE4", Offset = "0x2137EE4", VA = "0x2137EE4", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E40")]
	[Address(RVA = "0x2137FA8", Offset = "0x2137FA8", VA = "0x2137FA8", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
