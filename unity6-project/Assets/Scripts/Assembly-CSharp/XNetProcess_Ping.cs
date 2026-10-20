using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x20007A4")]
public class XNetProcess_Ping : XNetProcessBase
{
	[Token(Token = "0x17000886")]
	public override string Name
	{
		[Token(Token = "0x6003DDB")]
		[Address(RVA = "0x1EBFE48", Offset = "0x1EBFE48", VA = "0x1EBFE48", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000887")]
	public override float TimeoutSeconds
	{
		[Token(Token = "0x6003DDC")]
		[Address(RVA = "0x1EBFEC0", Offset = "0x1EBFEC0", VA = "0x1EBFEC0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6003DD8")]
	[Address(RVA = "0x1EBFBA8", Offset = "0x1EBFBA8", VA = "0x1EBFBA8")]
	public XNetProcess_Ping()
	{
	}

	[Token(Token = "0x6003DD9")]
	[Address(RVA = "0x1EBFBB8", Offset = "0x1EBFBB8", VA = "0x1EBFBB8", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003DDA")]
	[Address(RVA = "0x1EBFC74", Offset = "0x1EBFC74", VA = "0x1EBFC74", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003DDD")]
	[Address(RVA = "0x1EBFECC", Offset = "0x1EBFECC", VA = "0x1EBFECC", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003DDE")]
	[Address(RVA = "0x1EBFF8C", Offset = "0x1EBFF8C", VA = "0x1EBFF8C")]
	private bool IsErrorHandle(ApiReturnCode nErrorCode)
	{
		return default(bool);
	}

	[Token(Token = "0x6003DDF")]
	[Address(RVA = "0x1EBFFB8", Offset = "0x1EBFFB8", VA = "0x1EBFFB8", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x6003DE0")]
	[Address(RVA = "0x1EBFFC0", Offset = "0x1EBFFC0", VA = "0x1EBFFC0", Slot = "15")]
	protected override void OnTimeout()
	{
	}

	[Token(Token = "0x6003DE1")]
	[Address(RVA = "0x1EC01DC", Offset = "0x1EC01DC", VA = "0x1EC01DC", Slot = "16")]
	protected override void RetryProcess()
	{
	}

	[Token(Token = "0x6003DE2")]
	[Address(RVA = "0x1EC0358", Offset = "0x1EC0358", VA = "0x1EC0358")]
	private void _003CWork_003Em__1AD(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
