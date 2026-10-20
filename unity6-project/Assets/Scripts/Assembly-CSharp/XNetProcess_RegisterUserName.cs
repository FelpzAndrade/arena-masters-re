using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000812")]
public class XNetProcess_RegisterUserName : XNetProcessLoginBase
{
	[Token(Token = "0x4002330")]
	[FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17000902")]
	public override string Name
	{
		[Token(Token = "0x6004097")]
		[Address(RVA = "0x1EC3AC8", Offset = "0x1EC3AC8", VA = "0x1EC3AC8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004094")]
	[Address(RVA = "0x1EC36DC", Offset = "0x1EC36DC", VA = "0x1EC36DC")]
	public XNetProcess_RegisterUserName()
	{
	}

	[Token(Token = "0x6004095")]
	[Address(RVA = "0x1EC36E4", Offset = "0x1EC36E4", VA = "0x1EC36E4", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6004096")]
	[Address(RVA = "0x1EC37A0", Offset = "0x1EC37A0", VA = "0x1EC37A0", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6004098")]
	[Address(RVA = "0x1EC3B40", Offset = "0x1EC3B40", VA = "0x1EC3B40")]
	private void ShowErrorMessageBoxAndRetry(string title, string msg)
	{
	}

	[Token(Token = "0x6004099")]
	[Address(RVA = "0x1EC3D1C", Offset = "0x1EC3D1C", VA = "0x1EC3D1C", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x600409A")]
	[Address(RVA = "0x1EC3E68", Offset = "0x1EC3E68", VA = "0x1EC3E68", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x600409B")]
	[Address(RVA = "0x1EC4050", Offset = "0x1EC4050", VA = "0x1EC4050")]
	private void _003CShowErrorMessageBoxAndRetry_003Em__1C8()
	{
	}

	[Token(Token = "0x600409C")]
	[Address(RVA = "0x1EC4100", Offset = "0x1EC4100", VA = "0x1EC4100")]
	private static void _003CWork_003Em__1C9(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
