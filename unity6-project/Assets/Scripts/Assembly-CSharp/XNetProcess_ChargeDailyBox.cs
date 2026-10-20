using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000817")]
public class XNetProcess_ChargeDailyBox : XNetProcess_GameBase
{
	[Token(Token = "0x17000907")]
	public override string Name
	{
		[Token(Token = "0x60040BA")]
		[Address(RVA = "0x2131718", Offset = "0x2131718", VA = "0x2131718", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60040B7")]
	[Address(RVA = "0x2131530", Offset = "0x2131530", VA = "0x2131530")]
	public XNetProcess_ChargeDailyBox()
	{
	}

	[Token(Token = "0x60040B8")]
	[Address(RVA = "0x2131538", Offset = "0x2131538", VA = "0x2131538", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x60040B9")]
	[Address(RVA = "0x21315F4", Offset = "0x21315F4", VA = "0x21315F4", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x60040BB")]
	[Address(RVA = "0x2131790", Offset = "0x2131790", VA = "0x2131790", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x60040BC")]
	[Address(RVA = "0x2131794", Offset = "0x2131794", VA = "0x2131794", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
