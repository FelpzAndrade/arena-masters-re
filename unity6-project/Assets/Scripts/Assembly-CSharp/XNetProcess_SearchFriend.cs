using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200079D")]
public class XNetProcess_SearchFriend : XNetProcess_GameBase
{
	[Token(Token = "0x17000880")]
	public override string Name
	{
		[Token(Token = "0x6003DB4")]
		[Address(RVA = "0x1EC6610", Offset = "0x1EC6610", VA = "0x1EC6610", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003DB1")]
	[Address(RVA = "0x1EC6428", Offset = "0x1EC6428", VA = "0x1EC6428")]
	public XNetProcess_SearchFriend()
	{
	}

	[Token(Token = "0x6003DB2")]
	[Address(RVA = "0x1EC6430", Offset = "0x1EC6430", VA = "0x1EC6430", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003DB3")]
	[Address(RVA = "0x1EC64EC", Offset = "0x1EC64EC", VA = "0x1EC64EC", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003DB5")]
	[Address(RVA = "0x1EC6688", Offset = "0x1EC6688", VA = "0x1EC6688", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003DB6")]
	[Address(RVA = "0x1EC6690", Offset = "0x1EC6690", VA = "0x1EC6690", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
