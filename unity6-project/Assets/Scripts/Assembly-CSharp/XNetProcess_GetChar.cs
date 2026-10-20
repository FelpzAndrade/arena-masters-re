using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000775")]
public class XNetProcess_GetChar : XNetProcess_GameBase
{
	[Token(Token = "0x17000855")]
	public override string Name
	{
		[Token(Token = "0x6003CBD")]
		[Address(RVA = "0x213B188", Offset = "0x213B188", VA = "0x213B188", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003CBA")]
	[Address(RVA = "0x213AFA0", Offset = "0x213AFA0", VA = "0x213AFA0")]
	public XNetProcess_GetChar()
	{
	}

	[Token(Token = "0x6003CBB")]
	[Address(RVA = "0x213AFA8", Offset = "0x213AFA8", VA = "0x213AFA8", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003CBC")]
	[Address(RVA = "0x213B064", Offset = "0x213B064", VA = "0x213B064", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003CBE")]
	[Address(RVA = "0x213B200", Offset = "0x213B200", VA = "0x213B200", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003CBF")]
	[Address(RVA = "0x213B204", Offset = "0x213B204", VA = "0x213B204", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
