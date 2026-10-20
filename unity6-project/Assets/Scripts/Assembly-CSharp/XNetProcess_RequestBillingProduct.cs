using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200039B")]
internal class XNetProcess_RequestBillingProduct : XNetProcess_GameBase
{
	[Token(Token = "0x170004F8")]
	public override string Name
	{
		[Token(Token = "0x6001D99")]
		[Address(RVA = "0x1EC5948", Offset = "0x1EC5948", VA = "0x1EC5948", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001D96")]
	[Address(RVA = "0x1EC5760", Offset = "0x1EC5760", VA = "0x1EC5760")]
	public XNetProcess_RequestBillingProduct()
	{
	}

	[Token(Token = "0x6001D97")]
	[Address(RVA = "0x1EC5768", Offset = "0x1EC5768", VA = "0x1EC5768", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6001D98")]
	[Address(RVA = "0x1EC5824", Offset = "0x1EC5824", VA = "0x1EC5824", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6001D9A")]
	[Address(RVA = "0x1EC59C0", Offset = "0x1EC59C0", VA = "0x1EC59C0", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6001D9B")]
	[Address(RVA = "0x1EC59C8", Offset = "0x1EC59C8", VA = "0x1EC59C8", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
