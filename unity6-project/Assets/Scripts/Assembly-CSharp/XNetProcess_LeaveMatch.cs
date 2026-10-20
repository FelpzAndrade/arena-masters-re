using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007B4")]
public class XNetProcess_LeaveMatch : XNetProcess_GameBase
{
	[Token(Token = "0x1700089D")]
	public override string Name
	{
		[Token(Token = "0x6003E4A")]
		[Address(RVA = "0x1EB97C4", Offset = "0x1EB97C4", VA = "0x1EB97C4", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E47")]
	[Address(RVA = "0x1EB95DC", Offset = "0x1EB95DC", VA = "0x1EB95DC")]
	public XNetProcess_LeaveMatch()
	{
	}

	[Token(Token = "0x6003E48")]
	[Address(RVA = "0x1EB95E4", Offset = "0x1EB95E4", VA = "0x1EB95E4", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E49")]
	[Address(RVA = "0x1EB96A0", Offset = "0x1EB96A0", VA = "0x1EB96A0", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E4B")]
	[Address(RVA = "0x1EB983C", Offset = "0x1EB983C", VA = "0x1EB983C", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E4C")]
	[Address(RVA = "0x1EB9844", Offset = "0x1EB9844", VA = "0x1EB9844", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
