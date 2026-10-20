using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007AA")]
public class XNetProcess_CompleteMission : XNetProcess_GameBase
{
	[Token(Token = "0x17000891")]
	public override bool showLoadingIcon
	{
		[Token(Token = "0x6003E0B")]
		[Address(RVA = "0x213430C", Offset = "0x213430C", VA = "0x213430C", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000892")]
	public override string Name
	{
		[Token(Token = "0x6003E0D")]
		[Address(RVA = "0x2134438", Offset = "0x2134438", VA = "0x2134438", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E09")]
	[Address(RVA = "0x2134248", Offset = "0x2134248", VA = "0x2134248")]
	public XNetProcess_CompleteMission()
	{
	}

	[Token(Token = "0x6003E0A")]
	[Address(RVA = "0x2134250", Offset = "0x2134250", VA = "0x2134250", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E0C")]
	[Address(RVA = "0x2134314", Offset = "0x2134314", VA = "0x2134314", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E0E")]
	[Address(RVA = "0x21344B0", Offset = "0x21344B0", VA = "0x21344B0", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E0F")]
	[Address(RVA = "0x21344B4", Offset = "0x21344B4", VA = "0x21344B4", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
