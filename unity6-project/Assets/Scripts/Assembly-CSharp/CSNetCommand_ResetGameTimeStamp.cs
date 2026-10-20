using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007B7")]
public class CSNetCommand_ResetGameTimeStamp : XNetProcess_GameBase
{
	[Token(Token = "0x170008A1")]
	public override string Name
	{
		[Token(Token = "0x6003E5E")]
		[Address(RVA = "0x21F2A1C", Offset = "0x21F2A1C", VA = "0x21F2A1C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E5B")]
	[Address(RVA = "0x21F27E4", Offset = "0x21F27E4", VA = "0x21F27E4")]
	public CSNetCommand_ResetGameTimeStamp()
	{
	}

	[Token(Token = "0x6003E5C")]
	[Address(RVA = "0x21F27EC", Offset = "0x21F27EC", VA = "0x21F27EC", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E5D")]
	[Address(RVA = "0x21F28A8", Offset = "0x21F28A8", VA = "0x21F28A8", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E5F")]
	[Address(RVA = "0x21F2A94", Offset = "0x21F2A94", VA = "0x21F2A94", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E60")]
	[Address(RVA = "0x21F2A9C", Offset = "0x21F2A9C", VA = "0x21F2A9C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
