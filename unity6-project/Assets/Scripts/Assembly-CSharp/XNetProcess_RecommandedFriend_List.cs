using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000796")]
public class XNetProcess_RecommandedFriend_List : XNetProcess_GameBase
{
	[Token(Token = "0x17000879")]
	public override string Name
	{
		[Token(Token = "0x6003D8A")]
		[Address(RVA = "0x1EC25C4", Offset = "0x1EC25C4", VA = "0x1EC25C4", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003D87")]
	[Address(RVA = "0x1EC23DC", Offset = "0x1EC23DC", VA = "0x1EC23DC")]
	public XNetProcess_RecommandedFriend_List()
	{
	}

	[Token(Token = "0x6003D88")]
	[Address(RVA = "0x1EC23E4", Offset = "0x1EC23E4", VA = "0x1EC23E4", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003D89")]
	[Address(RVA = "0x1EC24A0", Offset = "0x1EC24A0", VA = "0x1EC24A0", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003D8B")]
	[Address(RVA = "0x1EC263C", Offset = "0x1EC263C", VA = "0x1EC263C", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003D8C")]
	[Address(RVA = "0x1EC2644", Offset = "0x1EC2644", VA = "0x1EC2644", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
