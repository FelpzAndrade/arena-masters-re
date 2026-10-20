using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000805")]
public class XNetProcess_GetTutorialInfo : XNetProcess_GameBase
{
	[Token(Token = "0x400231B")]
	[FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache0;

	[Token(Token = "0x170008F0")]
	public override string Name
	{
		[Token(Token = "0x6004032")]
		[Address(RVA = "0x1EB5590", Offset = "0x1EB5590", VA = "0x1EB5590", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600402F")]
	[Address(RVA = "0x1EB53A8", Offset = "0x1EB53A8", VA = "0x1EB53A8")]
	public XNetProcess_GetTutorialInfo()
	{
	}

	[Token(Token = "0x6004030")]
	[Address(RVA = "0x1EB53B0", Offset = "0x1EB53B0", VA = "0x1EB53B0", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6004031")]
	[Address(RVA = "0x1EB546C", Offset = "0x1EB546C", VA = "0x1EB546C", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6004033")]
	[Address(RVA = "0x1EB5608", Offset = "0x1EB5608", VA = "0x1EB5608", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6004034")]
	[Address(RVA = "0x1EB5610", Offset = "0x1EB5610", VA = "0x1EB5610", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x6004035")]
	[Address(RVA = "0x1EB57B8", Offset = "0x1EB57B8", VA = "0x1EB57B8")]
	private static void _003CHandleResponse_User_003Em__1B8(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
