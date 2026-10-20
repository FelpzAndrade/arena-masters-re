using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x20007D4")]
public class XNetProcess_CPQComplete : XNetProcessBase
{
	[Token(Token = "0x6003F03")]
	[Address(RVA = "0x2134C44", Offset = "0x2134C44", VA = "0x2134C44")]
	public XNetProcess_CPQComplete()
	{
	}

	[Token(Token = "0x6003F04")]
	[Address(RVA = "0x2134C4C", Offset = "0x2134C4C", VA = "0x2134C4C", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F05")]
	[Address(RVA = "0x2134D08", Offset = "0x2134D08", VA = "0x2134D08", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F06")]
	[Address(RVA = "0x2134E2C", Offset = "0x2134E2C", VA = "0x2134E2C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x6003F07")]
	[Address(RVA = "0x2134E34", Offset = "0x2134E34", VA = "0x2134E34")]
	public static void CPQSuccess(ApiReturnCode nErrorCode, JObject json, int questID)
	{
	}

	[Token(Token = "0x6003F08")]
	[Address(RVA = "0x2135188", Offset = "0x2135188", VA = "0x2135188")]
	public static void CPQCompleteFail(ApiReturnCode nErrorCode, string strErrorMessage, JObject json, int questID)
	{
	}
}
