using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007CF")]
public class XNetProcess_GetMailList : XNetProcess_GameBase
{
	[Token(Token = "0x170008BB")]
	public override string Name
	{
		[Token(Token = "0x6003EEF")]
		[Address(RVA = "0x213DD30", Offset = "0x213DD30", VA = "0x213DD30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003EEC")]
	[Address(RVA = "0x213DB48", Offset = "0x213DB48", VA = "0x213DB48")]
	public XNetProcess_GetMailList()
	{
	}

	[Token(Token = "0x6003EED")]
	[Address(RVA = "0x213DB50", Offset = "0x213DB50", VA = "0x213DB50", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003EEE")]
	[Address(RVA = "0x213DC0C", Offset = "0x213DC0C", VA = "0x213DC0C", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003EF0")]
	[Address(RVA = "0x213DDA8", Offset = "0x213DDA8", VA = "0x213DDA8", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003EF1")]
	[Address(RVA = "0x213DDAC", Offset = "0x213DDAC", VA = "0x213DDAC", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
