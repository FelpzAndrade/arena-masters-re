using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007FA")]
public class XNetProcess_ReserveTransfer : XNetProcess_GameBase
{
	[Token(Token = "0x170008E4")]
	public override string Name
	{
		[Token(Token = "0x6003FEC")]
		[Address(RVA = "0x1EC5E6C", Offset = "0x1EC5E6C", VA = "0x1EC5E6C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003FE9")]
	[Address(RVA = "0x1EC5C84", Offset = "0x1EC5C84", VA = "0x1EC5C84")]
	public XNetProcess_ReserveTransfer()
	{
	}

	[Token(Token = "0x6003FEA")]
	[Address(RVA = "0x1EC5C8C", Offset = "0x1EC5C8C", VA = "0x1EC5C8C", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003FEB")]
	[Address(RVA = "0x1EC5D48", Offset = "0x1EC5D48", VA = "0x1EC5D48", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003FED")]
	[Address(RVA = "0x1EC5EE4", Offset = "0x1EC5EE4", VA = "0x1EC5EE4", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003FEE")]
	[Address(RVA = "0x1EC5EEC", Offset = "0x1EC5EEC", VA = "0x1EC5EEC", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
