using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007B8")]
public class XNetProcess_InstantRespawn : XNetProcess_GameBase
{
	[Token(Token = "0x170008A2")]
	public override string Name
	{
		[Token(Token = "0x6003E64")]
		[Address(RVA = "0x1EB8BE8", Offset = "0x1EB8BE8", VA = "0x1EB8BE8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E61")]
	[Address(RVA = "0x1EB8A00", Offset = "0x1EB8A00", VA = "0x1EB8A00")]
	public XNetProcess_InstantRespawn()
	{
	}

	[Token(Token = "0x6003E62")]
	[Address(RVA = "0x1EB8A08", Offset = "0x1EB8A08", VA = "0x1EB8A08", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E63")]
	[Address(RVA = "0x1EB8AC4", Offset = "0x1EB8AC4", VA = "0x1EB8AC4", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E65")]
	[Address(RVA = "0x1EB8C60", Offset = "0x1EB8C60", VA = "0x1EB8C60", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E66")]
	[Address(RVA = "0x1EB8C68", Offset = "0x1EB8C68", VA = "0x1EB8C68", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
