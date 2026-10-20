using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200081A")]
public class XNetProcess_LinkAccount : XNetProcessLoginBase
{
	[Token(Token = "0x1700090B")]
	public override string Name
	{
		[Token(Token = "0x60040CD")]
		[Address(RVA = "0x1EBA0E8", Offset = "0x1EBA0E8", VA = "0x1EBA0E8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60040CA")]
	[Address(RVA = "0x1EB9E10", Offset = "0x1EB9E10", VA = "0x1EB9E10")]
	public XNetProcess_LinkAccount()
	{
	}

	[Token(Token = "0x60040CB")]
	[Address(RVA = "0x1EB9E18", Offset = "0x1EB9E18", VA = "0x1EB9E18", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x60040CC")]
	[Address(RVA = "0x1EB9ED4", Offset = "0x1EB9ED4", VA = "0x1EB9ED4", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x60040CE")]
	[Address(RVA = "0x1EBA160", Offset = "0x1EBA160", VA = "0x1EBA160", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x60040CF")]
	[Address(RVA = "0x1EBA168", Offset = "0x1EBA168", VA = "0x1EBA168", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
