using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x20007E5")]
public class XNetProcess_BuyCurrency : XNetProcess_GameBase
{
	[Token(Token = "0x400230D")]
	[FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache0;

	[Token(Token = "0x170008CF")]
	public override string Name
	{
		[Token(Token = "0x6003F6D")]
		[Address(RVA = "0x212F79C", Offset = "0x212F79C", VA = "0x212F79C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F6A")]
	[Address(RVA = "0x212F5B4", Offset = "0x212F5B4", VA = "0x212F5B4")]
	public XNetProcess_BuyCurrency()
	{
	}

	[Token(Token = "0x6003F6B")]
	[Address(RVA = "0x212F5BC", Offset = "0x212F5BC", VA = "0x212F5BC", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F6C")]
	[Address(RVA = "0x212F678", Offset = "0x212F678", VA = "0x212F678", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F6E")]
	[Address(RVA = "0x212F814", Offset = "0x212F814", VA = "0x212F814", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003F6F")]
	[Address(RVA = "0x212F938", Offset = "0x212F938", VA = "0x212F938", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x6003F70")]
	[Address(RVA = "0x212F940", Offset = "0x212F940", VA = "0x212F940")]
	private static void _003CWork_003Em__1B0(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
