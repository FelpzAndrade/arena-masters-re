using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200081F")]
public class XNetProcess_GetGameRecord : XNetProcess_GameBase
{
	[Token(Token = "0x17000911")]
	public override string Name
	{
		[Token(Token = "0x60040EC")]
		[Address(RVA = "0x213CE90", Offset = "0x213CE90", VA = "0x213CE90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60040E9")]
	[Address(RVA = "0x213CCA8", Offset = "0x213CCA8", VA = "0x213CCA8")]
	public XNetProcess_GetGameRecord()
	{
	}

	[Token(Token = "0x60040EA")]
	[Address(RVA = "0x213CCB0", Offset = "0x213CCB0", VA = "0x213CCB0", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x60040EB")]
	[Address(RVA = "0x213CD6C", Offset = "0x213CD6C", VA = "0x213CD6C", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x60040ED")]
	[Address(RVA = "0x213CF08", Offset = "0x213CF08", VA = "0x213CF08", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x60040EE")]
	[Address(RVA = "0x213CF0C", Offset = "0x213CF0C", VA = "0x213CF0C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
