using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000815")]
public class XNetProcess_ChangeUsername : XNetProcess_GameBase
{
	[Token(Token = "0x4002332")]
	[FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17000905")]
	public override string Name
	{
		[Token(Token = "0x60040AD")]
		[Address(RVA = "0x2130FF0", Offset = "0x2130FF0", VA = "0x2130FF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60040AA")]
	[Address(RVA = "0x2130E08", Offset = "0x2130E08", VA = "0x2130E08")]
	public XNetProcess_ChangeUsername()
	{
	}

	[Token(Token = "0x60040AB")]
	[Address(RVA = "0x2130E10", Offset = "0x2130E10", VA = "0x2130E10", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x60040AC")]
	[Address(RVA = "0x2130ECC", Offset = "0x2130ECC", VA = "0x2130ECC", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x60040AE")]
	[Address(RVA = "0x2131068", Offset = "0x2131068", VA = "0x2131068", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x60040AF")]
	[Address(RVA = "0x213118C", Offset = "0x213118C", VA = "0x213118C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x60040B0")]
	[Address(RVA = "0x213137C", Offset = "0x213137C", VA = "0x213137C")]
	private static void _003CWork_003Em__1CB(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
