using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007BD")]
public class XNetProcess_HackDetected : XNetProcess_GameBase
{
	[Token(Token = "0x170008A8")]
	public override string Name
	{
		[Token(Token = "0x6003E83")]
		[Address(RVA = "0x1EB74D8", Offset = "0x1EB74D8", VA = "0x1EB74D8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E80")]
	[Address(RVA = "0x1EB72F0", Offset = "0x1EB72F0", VA = "0x1EB72F0")]
	public XNetProcess_HackDetected()
	{
	}

	[Token(Token = "0x6003E81")]
	[Address(RVA = "0x1EB72F8", Offset = "0x1EB72F8", VA = "0x1EB72F8", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E82")]
	[Address(RVA = "0x1EB73B4", Offset = "0x1EB73B4", VA = "0x1EB73B4", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E84")]
	[Address(RVA = "0x1EB7550", Offset = "0x1EB7550", VA = "0x1EB7550", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E85")]
	[Address(RVA = "0x1EB7558", Offset = "0x1EB7558", VA = "0x1EB7558", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
