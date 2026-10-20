using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007FD")]
public class XNetProcess_SetTutorialGroup : XNetProcess_GameBase
{
	[Token(Token = "0x170008E7")]
	public override string Name
	{
		[Token(Token = "0x6003FFE")]
		[Address(RVA = "0x1EC7830", Offset = "0x1EC7830", VA = "0x1EC7830", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003FFB")]
	[Address(RVA = "0x1EC7648", Offset = "0x1EC7648", VA = "0x1EC7648")]
	public XNetProcess_SetTutorialGroup()
	{
	}

	[Token(Token = "0x6003FFC")]
	[Address(RVA = "0x1EC7650", Offset = "0x1EC7650", VA = "0x1EC7650", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003FFD")]
	[Address(RVA = "0x1EC770C", Offset = "0x1EC770C", VA = "0x1EC770C", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003FFF")]
	[Address(RVA = "0x1EC78A8", Offset = "0x1EC78A8", VA = "0x1EC78A8", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6004000")]
	[Address(RVA = "0x1EC78B0", Offset = "0x1EC78B0", VA = "0x1EC78B0", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
