using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007F2")]
public class XNetProcess_Talent_Upgrade : XNetProcess_GameBase
{
	[Token(Token = "0x170008DC")]
	public override string Name
	{
		[Token(Token = "0x6003FBC")]
		[Address(RVA = "0x1EC92B0", Offset = "0x1EC92B0", VA = "0x1EC92B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003FB9")]
	[Address(RVA = "0x1EC90C8", Offset = "0x1EC90C8", VA = "0x1EC90C8")]
	public XNetProcess_Talent_Upgrade()
	{
	}

	[Token(Token = "0x6003FBA")]
	[Address(RVA = "0x1EC90D0", Offset = "0x1EC90D0", VA = "0x1EC90D0", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003FBB")]
	[Address(RVA = "0x1EC918C", Offset = "0x1EC918C", VA = "0x1EC918C", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003FBD")]
	[Address(RVA = "0x1EC9328", Offset = "0x1EC9328", VA = "0x1EC9328", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003FBE")]
	[Address(RVA = "0x1EC9330", Offset = "0x1EC9330", VA = "0x1EC9330", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
