using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000774")]
public class XNetProcess_BroadcastMaintenaceProcess : XNetProcessBase
{
	[Token(Token = "0x17000853")]
	public override string Name
	{
		[Token(Token = "0x6003CB4")]
		[Address(RVA = "0x212E480", Offset = "0x212E480", VA = "0x212E480", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000854")]
	public override float TimeoutSeconds
	{
		[Token(Token = "0x6003CB5")]
		[Address(RVA = "0x212E4F8", Offset = "0x212E4F8", VA = "0x212E4F8", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6003CB1")]
	[Address(RVA = "0x212E330", Offset = "0x212E330", VA = "0x212E330")]
	public XNetProcess_BroadcastMaintenaceProcess()
	{
	}

	[Token(Token = "0x6003CB2")]
	[Address(RVA = "0x212E338", Offset = "0x212E338", VA = "0x212E338", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003CB3")]
	[Address(RVA = "0x212E3F4", Offset = "0x212E3F4", VA = "0x212E3F4", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003CB6")]
	[Address(RVA = "0x212E504", Offset = "0x212E504", VA = "0x212E504", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003CB7")]
	[Address(RVA = "0x212E50C", Offset = "0x212E50C", VA = "0x212E50C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x6003CB8")]
	[Address(RVA = "0x212E514", Offset = "0x212E514", VA = "0x212E514", Slot = "15")]
	protected override void OnTimeout()
	{
	}

	[Token(Token = "0x6003CB9")]
	[Address(RVA = "0x212E730", Offset = "0x212E730", VA = "0x212E730", Slot = "16")]
	protected override void RetryProcess()
	{
	}
}
