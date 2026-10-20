using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000816")]
public class XNetProcess_QuestComplete : XNetProcess_GameBase
{
	[Token(Token = "0x17000906")]
	public override string Name
	{
		[Token(Token = "0x60040B4")]
		[Address(RVA = "0x1EC2354", Offset = "0x1EC2354", VA = "0x1EC2354", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60040B1")]
	[Address(RVA = "0x1EC216C", Offset = "0x1EC216C", VA = "0x1EC216C")]
	public XNetProcess_QuestComplete()
	{
	}

	[Token(Token = "0x60040B2")]
	[Address(RVA = "0x1EC2174", Offset = "0x1EC2174", VA = "0x1EC2174", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x60040B3")]
	[Address(RVA = "0x1EC2230", Offset = "0x1EC2230", VA = "0x1EC2230", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x60040B5")]
	[Address(RVA = "0x1EC23CC", Offset = "0x1EC23CC", VA = "0x1EC23CC", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x60040B6")]
	[Address(RVA = "0x1EC23D4", Offset = "0x1EC23D4", VA = "0x1EC23D4", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
