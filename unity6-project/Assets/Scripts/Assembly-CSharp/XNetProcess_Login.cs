using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000809")]
public class XNetProcess_Login : XNetProcessLoginBase
{
	[Token(Token = "0x4002326")]
	[FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4002327")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4002328")]
	[FieldOffset(Offset = "0x8")]
	private static NetCallback _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4002329")]
	[FieldOffset(Offset = "0xC")]
	private static Action _003C_003Ef__am_0024cache3;

	[Token(Token = "0x170008F4")]
	public override bool IsProcessed
	{
		[Token(Token = "0x600404E")]
		[Address(RVA = "0x1EBA338", Offset = "0x1EBA338", VA = "0x1EBA338", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170008F5")]
	public override string Name
	{
		[Token(Token = "0x6004051")]
		[Address(RVA = "0x1EBB308", Offset = "0x1EBB308", VA = "0x1EBB308", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600404D")]
	[Address(RVA = "0x1EBA330", Offset = "0x1EBA330", VA = "0x1EBA330")]
	public XNetProcess_Login()
	{
	}

	[Token(Token = "0x600404F")]
	[Address(RVA = "0x1EBA418", Offset = "0x1EBA418", VA = "0x1EBA418", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6004050")]
	[Address(RVA = "0x1EBA4D4", Offset = "0x1EBA4D4", VA = "0x1EBA4D4", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6004052")]
	[Address(RVA = "0x1EBB380", Offset = "0x1EBB380", VA = "0x1EBB380", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6004053")]
	[Address(RVA = "0x1EBB4CC", Offset = "0x1EBB4CC", VA = "0x1EBB4CC")]
	private void ReLoginNexon()
	{
	}

	[Token(Token = "0x6004054")]
	[Address(RVA = "0x1EBB7A8", Offset = "0x1EBB7A8", VA = "0x1EBB7A8", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x6004055")]
	[Address(RVA = "0x1EBCE04", Offset = "0x1EBCE04", VA = "0x1EBCE04")]
	private static void _003CWork_003Em__1BD(ApiReturnCode nErrorCode, string strErrorMsg, JObject source)
	{
	}

	[Token(Token = "0x6004056")]
	[Address(RVA = "0x1EBD574", Offset = "0x1EBD574", VA = "0x1EBD574")]
	private void _003CHandleResponse_User_003Em__1BE(ApiReturnCode errno, string errmsg, JObject json)
	{
	}

	[Token(Token = "0x6004057")]
	[Address(RVA = "0x1EBD9D4", Offset = "0x1EBD9D4", VA = "0x1EBD9D4")]
	private static void _003CHandleResponse_User_003Em__1BF()
	{
	}

	[Token(Token = "0x6004058")]
	[Address(RVA = "0x1EBD9E0", Offset = "0x1EBD9E0", VA = "0x1EBD9E0")]
	private static void _003CHandleResponse_User_003Em__1C0(ApiReturnCode errno, string errmsg, JObject json)
	{
	}

	[Token(Token = "0x6004059")]
	[Address(RVA = "0x1EBDCE0", Offset = "0x1EBDCE0", VA = "0x1EBDCE0")]
	private static void _003CHandleResponse_User_003Em__1C1()
	{
	}
}
