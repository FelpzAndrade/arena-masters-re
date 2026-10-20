using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000824")]
public class XNetProcess_UseCoupon : XNetProcess_GameBase
{
	[Token(Token = "0x17000916")]
	public override string Name
	{
		[Token(Token = "0x6004106")]
		[Address(RVA = "0x1ECB5A8", Offset = "0x1ECB5A8", VA = "0x1ECB5A8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004104")]
	[Address(RVA = "0x1ECB4E4", Offset = "0x1ECB4E4", VA = "0x1ECB4E4")]
	public XNetProcess_UseCoupon()
	{
	}

	[Token(Token = "0x6004105")]
	[Address(RVA = "0x1ECB4EC", Offset = "0x1ECB4EC", VA = "0x1ECB4EC", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6004107")]
	[Address(RVA = "0x1ECB620", Offset = "0x1ECB620", VA = "0x1ECB620", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6004108")]
	[Address(RVA = "0x1ECB744", Offset = "0x1ECB744", VA = "0x1ECB744", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6004109")]
	[Address(RVA = "0x1ECB74C", Offset = "0x1ECB74C", VA = "0x1ECB74C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
