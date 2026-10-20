using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000802")]
public class XNetProcess_GetOTPToken : XNetProcessLoginBase
{
	[Token(Token = "0x4002318")]
	[FieldOffset(Offset = "0x38")]
	private string getCompleteHashKey;

	[Token(Token = "0x4002319")]
	[FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache1;

	[Token(Token = "0x170008EC")]
	public override string Name
	{
		[Token(Token = "0x600401D")]
		[Address(RVA = "0x21406FC", Offset = "0x21406FC", VA = "0x21406FC", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600401A")]
	[Address(RVA = "0x2140458", Offset = "0x2140458", VA = "0x2140458")]
	public XNetProcess_GetOTPToken()
	{
	}

	[Token(Token = "0x600401B")]
	[Address(RVA = "0x214051C", Offset = "0x214051C", VA = "0x214051C", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x600401C")]
	[Address(RVA = "0x21405D8", Offset = "0x21405D8", VA = "0x21405D8", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x600401E")]
	[Address(RVA = "0x2140774", Offset = "0x2140774", VA = "0x2140774", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x600401F")]
	[Address(RVA = "0x2140834", Offset = "0x2140834", VA = "0x2140834", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x6004020")]
	[Address(RVA = "0x21409F8", Offset = "0x21409F8", VA = "0x21409F8")]
	private void _003CWork_003Em__1B5(ApiReturnCode nErrorCode, string strErrorMsg, JObject source)
	{
	}

	[Token(Token = "0x6004021")]
	[Address(RVA = "0x2140BF4", Offset = "0x2140BF4", VA = "0x2140BF4")]
	private static void _003CHandleResponse_User_003Em__1B6(ApiReturnCode errno, string errmsg, JObject json)
	{
	}
}
