using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000798")]
public class XNetProcess_RequestFriendship : XNetProcess_GameBase
{
	[Token(Token = "0x1700087B")]
	public override string Name
	{
		[Token(Token = "0x6003D96")]
		[Address(RVA = "0x1EC5BC8", Offset = "0x1EC5BC8", VA = "0x1EC5BC8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003D93")]
	[Address(RVA = "0x1EC59E0", Offset = "0x1EC59E0", VA = "0x1EC59E0")]
	public XNetProcess_RequestFriendship()
	{
	}

	[Token(Token = "0x6003D94")]
	[Address(RVA = "0x1EC59E8", Offset = "0x1EC59E8", VA = "0x1EC59E8", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003D95")]
	[Address(RVA = "0x1EC5AA4", Offset = "0x1EC5AA4", VA = "0x1EC5AA4", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003D97")]
	[Address(RVA = "0x1EC5C40", Offset = "0x1EC5C40", VA = "0x1EC5C40", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003D98")]
	[Address(RVA = "0x1EC5C48", Offset = "0x1EC5C48", VA = "0x1EC5C48", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
