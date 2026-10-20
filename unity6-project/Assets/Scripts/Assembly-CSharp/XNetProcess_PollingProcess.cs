using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x20007A5")]
public class XNetProcess_PollingProcess : XNetProcessBase
{
	[Token(Token = "0x4002301")]
	[FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4002302")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x17000888")]
	public override string Name
	{
		[Token(Token = "0x6003DE6")]
		[Address(RVA = "0x1EC08B8", Offset = "0x1EC08B8", VA = "0x1EC08B8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000889")]
	public override float TimeoutSeconds
	{
		[Token(Token = "0x6003DE7")]
		[Address(RVA = "0x1EC0930", Offset = "0x1EC0930", VA = "0x1EC0930", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6003DE3")]
	[Address(RVA = "0x1EC0530", Offset = "0x1EC0530", VA = "0x1EC0530")]
	public XNetProcess_PollingProcess()
	{
	}

	[Token(Token = "0x6003DE4")]
	[Address(RVA = "0x1EC0538", Offset = "0x1EC0538", VA = "0x1EC0538", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003DE5")]
	[Address(RVA = "0x1EC05F4", Offset = "0x1EC05F4", VA = "0x1EC05F4", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003DE8")]
	[Address(RVA = "0x1EC093C", Offset = "0x1EC093C", VA = "0x1EC093C", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003DE9")]
	[Address(RVA = "0x1EC0A64", Offset = "0x1EC0A64", VA = "0x1EC0A64", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x6003DEA")]
	[Address(RVA = "0x1EC0CE0", Offset = "0x1EC0CE0", VA = "0x1EC0CE0", Slot = "15")]
	protected override void OnTimeout()
	{
	}

	[Token(Token = "0x6003DEB")]
	[Address(RVA = "0x1EC0EFC", Offset = "0x1EC0EFC", VA = "0x1EC0EFC", Slot = "16")]
	protected override void RetryProcess()
	{
	}

	[Token(Token = "0x6003DEC")]
	[Address(RVA = "0x1EC1078", Offset = "0x1EC1078", VA = "0x1EC1078")]
	private static void _003CWork_003Em__1AE(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}

	[Token(Token = "0x6003DED")]
	[Address(RVA = "0x1EC1748", Offset = "0x1EC1748", VA = "0x1EC1748")]
	private static void _003CHandleResponse_User_003Em__1AF()
	{
	}
}
