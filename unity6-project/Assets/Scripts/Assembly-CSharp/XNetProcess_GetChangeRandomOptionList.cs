using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007CB")]
public class XNetProcess_GetChangeRandomOptionList : XNetProcess_GameBase
{
	[Token(Token = "0x170008B7")]
	public override string Name
	{
		[Token(Token = "0x6003ED7")]
		[Address(RVA = "0x213AF1C", Offset = "0x213AF1C", VA = "0x213AF1C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003ED4")]
	[Address(RVA = "0x213AD34", Offset = "0x213AD34", VA = "0x213AD34")]
	public XNetProcess_GetChangeRandomOptionList()
	{
	}

	[Token(Token = "0x6003ED5")]
	[Address(RVA = "0x213AD3C", Offset = "0x213AD3C", VA = "0x213AD3C", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003ED6")]
	[Address(RVA = "0x213ADF8", Offset = "0x213ADF8", VA = "0x213ADF8", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003ED8")]
	[Address(RVA = "0x213AF94", Offset = "0x213AF94", VA = "0x213AF94", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003ED9")]
	[Address(RVA = "0x213AF98", Offset = "0x213AF98", VA = "0x213AF98", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
