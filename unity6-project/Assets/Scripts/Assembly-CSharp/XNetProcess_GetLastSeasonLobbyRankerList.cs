using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x200080C")]
public class XNetProcess_GetLastSeasonLobbyRankerList : XNetProcessLoginBase
{
	[Token(Token = "0x400232A")]
	[FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache0;

	[Token(Token = "0x170008F8")]
	public override string Name
	{
		[Token(Token = "0x600406A")]
		[Address(RVA = "0x213D0FC", Offset = "0x213D0FC", VA = "0x213D0FC", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004067")]
	[Address(RVA = "0x213CF14", Offset = "0x213CF14", VA = "0x213CF14")]
	public XNetProcess_GetLastSeasonLobbyRankerList()
	{
	}

	[Token(Token = "0x6004068")]
	[Address(RVA = "0x213CF1C", Offset = "0x213CF1C", VA = "0x213CF1C", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6004069")]
	[Address(RVA = "0x213CFD8", Offset = "0x213CFD8", VA = "0x213CFD8", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x600406B")]
	[Address(RVA = "0x213D174", Offset = "0x213D174", VA = "0x213D174", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x600406C")]
	[Address(RVA = "0x213D29C", Offset = "0x213D29C", VA = "0x213D29C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x600406D")]
	[Address(RVA = "0x213D3B4", Offset = "0x213D3B4", VA = "0x213D3B4")]
	private static void _003CWork_003Em__1C2(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
