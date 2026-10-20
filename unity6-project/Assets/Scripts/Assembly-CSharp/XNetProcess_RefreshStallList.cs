using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007E7")]
public class XNetProcess_RefreshStallList : XNetProcess_GameBase
{
	[Token(Token = "0x170008D1")]
	public override string Name
	{
		[Token(Token = "0x6003F7A")]
		[Address(RVA = "0x1EC2AA4", Offset = "0x1EC2AA4", VA = "0x1EC2AA4", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F77")]
	[Address(RVA = "0x1EC28BC", Offset = "0x1EC28BC", VA = "0x1EC28BC")]
	public XNetProcess_RefreshStallList()
	{
	}

	[Token(Token = "0x6003F78")]
	[Address(RVA = "0x1EC28C4", Offset = "0x1EC28C4", VA = "0x1EC28C4", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F79")]
	[Address(RVA = "0x1EC2980", Offset = "0x1EC2980", VA = "0x1EC2980", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F7B")]
	[Address(RVA = "0x1EC2B1C", Offset = "0x1EC2B1C", VA = "0x1EC2B1C", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003F7C")]
	[Address(RVA = "0x1EC2B24", Offset = "0x1EC2B24", VA = "0x1EC2B24", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
