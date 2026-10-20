using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007A8")]
public class XNetProcess_CompleteStage : XNetProcess_GameBase
{
	[Token(Token = "0x1700088D")]
	public override bool showLoadingIcon
	{
		[Token(Token = "0x6003DFD")]
		[Address(RVA = "0x213480C", Offset = "0x213480C", VA = "0x213480C", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700088E")]
	public override string Name
	{
		[Token(Token = "0x6003DFF")]
		[Address(RVA = "0x2134938", Offset = "0x2134938", VA = "0x2134938", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003DFB")]
	[Address(RVA = "0x2134748", Offset = "0x2134748", VA = "0x2134748")]
	public XNetProcess_CompleteStage()
	{
	}

	[Token(Token = "0x6003DFC")]
	[Address(RVA = "0x2134750", Offset = "0x2134750", VA = "0x2134750", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003DFE")]
	[Address(RVA = "0x2134814", Offset = "0x2134814", VA = "0x2134814", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E00")]
	[Address(RVA = "0x21349B0", Offset = "0x21349B0", VA = "0x21349B0", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E01")]
	[Address(RVA = "0x21349B4", Offset = "0x21349B4", VA = "0x21349B4", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
