using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000778")]
public class XNetProcess_Skin_Unlock : XNetProcess_GameBase
{
	[Token(Token = "0x17000858")]
	public override string Name
	{
		[Token(Token = "0x6003CCF")]
		[Address(RVA = "0x1EC8728", Offset = "0x1EC8728", VA = "0x1EC8728", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003CCC")]
	[Address(RVA = "0x1EC8540", Offset = "0x1EC8540", VA = "0x1EC8540")]
	public XNetProcess_Skin_Unlock()
	{
	}

	[Token(Token = "0x6003CCD")]
	[Address(RVA = "0x1EC8548", Offset = "0x1EC8548", VA = "0x1EC8548", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003CCE")]
	[Address(RVA = "0x1EC8604", Offset = "0x1EC8604", VA = "0x1EC8604", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003CD0")]
	[Address(RVA = "0x1EC87A0", Offset = "0x1EC87A0", VA = "0x1EC87A0", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003CD1")]
	[Address(RVA = "0x1EC87A8", Offset = "0x1EC87A8", VA = "0x1EC87A8", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
