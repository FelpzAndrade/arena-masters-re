using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007D1")]
public class XNetProcess_PopMail : XNetProcess_GameBase
{
	[Token(Token = "0x400230C")]
	[FieldOffset(Offset = "0x34")]
	private string m_uid;

	[Token(Token = "0x170008BD")]
	public override string Name
	{
		[Token(Token = "0x6003EFB")]
		[Address(RVA = "0x1EC1C6C", Offset = "0x1EC1C6C", VA = "0x1EC1C6C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003EF8")]
	[Address(RVA = "0x1EC1A84", Offset = "0x1EC1A84", VA = "0x1EC1A84")]
	public XNetProcess_PopMail()
	{
	}

	[Token(Token = "0x6003EF9")]
	[Address(RVA = "0x1EC1A8C", Offset = "0x1EC1A8C", VA = "0x1EC1A8C", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003EFA")]
	[Address(RVA = "0x1EC1B48", Offset = "0x1EC1B48", VA = "0x1EC1B48", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003EFC")]
	[Address(RVA = "0x1EC1CE4", Offset = "0x1EC1CE4", VA = "0x1EC1CE4", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003EFD")]
	[Address(RVA = "0x1EC1CEC", Offset = "0x1EC1CEC", VA = "0x1EC1CEC", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
