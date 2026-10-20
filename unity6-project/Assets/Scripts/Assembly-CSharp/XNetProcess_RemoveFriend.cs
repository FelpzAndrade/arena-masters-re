using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200079B")]
public class XNetProcess_RemoveFriend : XNetProcess_GameBase
{
	[Token(Token = "0x1700087E")]
	public override string Name
	{
		[Token(Token = "0x6003DA8")]
		[Address(RVA = "0x1EC5434", Offset = "0x1EC5434", VA = "0x1EC5434", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003DA5")]
	[Address(RVA = "0x1EC524C", Offset = "0x1EC524C", VA = "0x1EC524C")]
	public XNetProcess_RemoveFriend()
	{
	}

	[Token(Token = "0x6003DA6")]
	[Address(RVA = "0x1EC5254", Offset = "0x1EC5254", VA = "0x1EC5254", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003DA7")]
	[Address(RVA = "0x1EC5310", Offset = "0x1EC5310", VA = "0x1EC5310", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003DA9")]
	[Address(RVA = "0x1EC54AC", Offset = "0x1EC54AC", VA = "0x1EC54AC", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003DAA")]
	[Address(RVA = "0x1EC54B4", Offset = "0x1EC54B4", VA = "0x1EC54B4", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
