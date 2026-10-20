using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000803")]
public class XNetProcess_GetUserdata : XNetProcessLoginBase
{
	[Token(Token = "0x170008ED")]
	public override string Name
	{
		[Token(Token = "0x6004025")]
		[Address(RVA = "0x1EB5E1C", Offset = "0x1EB5E1C", VA = "0x1EB5E1C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004022")]
	[Address(RVA = "0x1EB58D8", Offset = "0x1EB58D8", VA = "0x1EB58D8")]
	public XNetProcess_GetUserdata()
	{
	}

	[Token(Token = "0x6004023")]
	[Address(RVA = "0x1EB58E8", Offset = "0x1EB58E8", VA = "0x1EB58E8", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6004024")]
	[Address(RVA = "0x1EB59A4", Offset = "0x1EB59A4", VA = "0x1EB59A4", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6004026")]
	[Address(RVA = "0x1EB5E94", Offset = "0x1EB5E94", VA = "0x1EB5E94", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6004027")]
	[Address(RVA = "0x1EB6154", Offset = "0x1EB6154", VA = "0x1EB6154", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
