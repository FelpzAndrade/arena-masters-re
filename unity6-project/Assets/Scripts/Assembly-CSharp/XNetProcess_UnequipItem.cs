using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007C1")]
public class XNetProcess_UnequipItem : XNetProcess_GameBase
{
	[Token(Token = "0x170008AB")]
	public override string Name
	{
		[Token(Token = "0x6003E99")]
		[Address(RVA = "0x1ECAC78", Offset = "0x1ECAC78", VA = "0x1ECAC78", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E96")]
	[Address(RVA = "0x1ECAA90", Offset = "0x1ECAA90", VA = "0x1ECAA90")]
	public XNetProcess_UnequipItem()
	{
	}

	[Token(Token = "0x6003E97")]
	[Address(RVA = "0x1ECAA98", Offset = "0x1ECAA98", VA = "0x1ECAA98", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E98")]
	[Address(RVA = "0x1ECAB54", Offset = "0x1ECAB54", VA = "0x1ECAB54", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E9A")]
	[Address(RVA = "0x1ECACF0", Offset = "0x1ECACF0", VA = "0x1ECACF0", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E9B")]
	[Address(RVA = "0x1ECACF8", Offset = "0x1ECACF8", VA = "0x1ECACF8", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
