using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200080B")]
public class XNetProcess_GetMaildata : XNetProcessLoginBase
{
	[Token(Token = "0x170008F7")]
	public override string Name
	{
		[Token(Token = "0x6004064")]
		[Address(RVA = "0x213D8E0", Offset = "0x213D8E0", VA = "0x213D8E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004061")]
	[Address(RVA = "0x213D6F8", Offset = "0x213D6F8", VA = "0x213D6F8")]
	public XNetProcess_GetMaildata()
	{
	}

	[Token(Token = "0x6004062")]
	[Address(RVA = "0x213D700", Offset = "0x213D700", VA = "0x213D700", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6004063")]
	[Address(RVA = "0x213D7BC", Offset = "0x213D7BC", VA = "0x213D7BC", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6004065")]
	[Address(RVA = "0x213D958", Offset = "0x213D958", VA = "0x213D958", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6004066")]
	[Address(RVA = "0x213D960", Offset = "0x213D960", VA = "0x213D960", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
