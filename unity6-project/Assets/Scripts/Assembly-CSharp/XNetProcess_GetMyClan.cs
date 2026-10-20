using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200077D")]
public class XNetProcess_GetMyClan : XNetProcess_GameBase
{
	[Token(Token = "0x1700085F")]
	public override string Name
	{
		[Token(Token = "0x6003CF2")]
		[Address(RVA = "0x213DE78", Offset = "0x213DE78", VA = "0x213DE78", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003CF0")]
	[Address(RVA = "0x213DDB4", Offset = "0x213DDB4", VA = "0x213DDB4")]
	public XNetProcess_GetMyClan()
	{
	}

	[Token(Token = "0x6003CF1")]
	[Address(RVA = "0x213DDBC", Offset = "0x213DDBC", VA = "0x213DDBC", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003CF3")]
	[Address(RVA = "0x213DEF0", Offset = "0x213DEF0", VA = "0x213DEF0", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003CF4")]
	[Address(RVA = "0x213E014", Offset = "0x213E014", VA = "0x213E014", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003CF5")]
	[Address(RVA = "0x213E018", Offset = "0x213E018", VA = "0x213E018", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
