using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007BA")]
public class XNetProcess_SelectCharPartyMember : XNetProcess_GameBase
{
	[Token(Token = "0x170008A5")]
	public override string Name
	{
		[Token(Token = "0x6003E71")]
		[Address(RVA = "0x1EC68A0", Offset = "0x1EC68A0", VA = "0x1EC68A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E6E")]
	[Address(RVA = "0x1EC66B8", Offset = "0x1EC66B8", VA = "0x1EC66B8")]
	public XNetProcess_SelectCharPartyMember()
	{
	}

	[Token(Token = "0x6003E6F")]
	[Address(RVA = "0x1EC66C0", Offset = "0x1EC66C0", VA = "0x1EC66C0", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E70")]
	[Address(RVA = "0x1EC677C", Offset = "0x1EC677C", VA = "0x1EC677C", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E72")]
	[Address(RVA = "0x1EC6918", Offset = "0x1EC6918", VA = "0x1EC6918", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E73")]
	[Address(RVA = "0x1EC6920", Offset = "0x1EC6920", VA = "0x1EC6920", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
