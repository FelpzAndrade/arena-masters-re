using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000784")]
public class XNetProcess_LeaveClan : XNetProcess_GameBase
{
	[Token(Token = "0x17000866")]
	public override string Name
	{
		[Token(Token = "0x6003D1C")]
		[Address(RVA = "0x1EB9410", Offset = "0x1EB9410", VA = "0x1EB9410", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003D1A")]
	[Address(RVA = "0x1EB934C", Offset = "0x1EB934C", VA = "0x1EB934C")]
	public XNetProcess_LeaveClan()
	{
	}

	[Token(Token = "0x6003D1B")]
	[Address(RVA = "0x1EB9354", Offset = "0x1EB9354", VA = "0x1EB9354", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003D1D")]
	[Address(RVA = "0x1EB9488", Offset = "0x1EB9488", VA = "0x1EB9488", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003D1E")]
	[Address(RVA = "0x1EB95AC", Offset = "0x1EB95AC", VA = "0x1EB95AC", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003D1F")]
	[Address(RVA = "0x1EB95B4", Offset = "0x1EB95B4", VA = "0x1EB95B4", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
