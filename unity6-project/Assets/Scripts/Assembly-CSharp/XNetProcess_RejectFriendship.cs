using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200079A")]
public class XNetProcess_RejectFriendship : XNetProcess_GameBase
{
	[Token(Token = "0x1700087D")]
	public override string Name
	{
		[Token(Token = "0x6003DA2")]
		[Address(RVA = "0x1EC4518", Offset = "0x1EC4518", VA = "0x1EC4518", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003D9F")]
	[Address(RVA = "0x1EC4330", Offset = "0x1EC4330", VA = "0x1EC4330")]
	public XNetProcess_RejectFriendship()
	{
	}

	[Token(Token = "0x6003DA0")]
	[Address(RVA = "0x1EC4338", Offset = "0x1EC4338", VA = "0x1EC4338", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003DA1")]
	[Address(RVA = "0x1EC43F4", Offset = "0x1EC43F4", VA = "0x1EC43F4", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003DA3")]
	[Address(RVA = "0x1EC4590", Offset = "0x1EC4590", VA = "0x1EC4590", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003DA4")]
	[Address(RVA = "0x1EC4598", Offset = "0x1EC4598", VA = "0x1EC4598", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
