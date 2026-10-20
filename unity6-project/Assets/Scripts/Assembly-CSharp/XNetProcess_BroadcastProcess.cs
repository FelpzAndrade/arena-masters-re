using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000773")]
public class XNetProcess_BroadcastProcess : XNetProcessBase
{
	[Token(Token = "0x17000851")]
	public override string Name
	{
		[Token(Token = "0x6003CAB")]
		[Address(RVA = "0x212E9FC", Offset = "0x212E9FC", VA = "0x212E9FC", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000852")]
	public override float TimeoutSeconds
	{
		[Token(Token = "0x6003CAC")]
		[Address(RVA = "0x212EA74", Offset = "0x212EA74", VA = "0x212EA74", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6003CA8")]
	[Address(RVA = "0x212E8AC", Offset = "0x212E8AC", VA = "0x212E8AC")]
	public XNetProcess_BroadcastProcess()
	{
	}

	[Token(Token = "0x6003CA9")]
	[Address(RVA = "0x212E8B4", Offset = "0x212E8B4", VA = "0x212E8B4", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003CAA")]
	[Address(RVA = "0x212E970", Offset = "0x212E970", VA = "0x212E970", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003CAD")]
	[Address(RVA = "0x212EA80", Offset = "0x212EA80", VA = "0x212EA80", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003CAE")]
	[Address(RVA = "0x212EA88", Offset = "0x212EA88", VA = "0x212EA88", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x6003CAF")]
	[Address(RVA = "0x212EA90", Offset = "0x212EA90", VA = "0x212EA90", Slot = "15")]
	protected override void OnTimeout()
	{
	}

	[Token(Token = "0x6003CB0")]
	[Address(RVA = "0x212ECAC", Offset = "0x212ECAC", VA = "0x212ECAC", Slot = "16")]
	protected override void RetryProcess()
	{
	}
}
