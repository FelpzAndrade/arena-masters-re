using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200077B")]
public class XNetProcess_ChatWrite : XNetProcessBase
{
	[Token(Token = "0x1700085B")]
	public override string Name
	{
		[Token(Token = "0x6003CE1")]
		[Address(RVA = "0x2131F98", Offset = "0x2131F98", VA = "0x2131F98", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700085C")]
	public override float TimeoutSeconds
	{
		[Token(Token = "0x6003CE2")]
		[Address(RVA = "0x2132010", Offset = "0x2132010", VA = "0x2132010", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6003CDE")]
	[Address(RVA = "0x2131DB0", Offset = "0x2131DB0", VA = "0x2131DB0")]
	public XNetProcess_ChatWrite()
	{
	}

	[Token(Token = "0x6003CDF")]
	[Address(RVA = "0x2131DB8", Offset = "0x2131DB8", VA = "0x2131DB8", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003CE0")]
	[Address(RVA = "0x2131E74", Offset = "0x2131E74", VA = "0x2131E74", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003CE3")]
	[Address(RVA = "0x213201C", Offset = "0x213201C", VA = "0x213201C", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003CE4")]
	[Address(RVA = "0x2132024", Offset = "0x2132024", VA = "0x2132024", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x6003CE5")]
	[Address(RVA = "0x213202C", Offset = "0x213202C", VA = "0x213202C", Slot = "15")]
	protected override void OnTimeout()
	{
	}

	[Token(Token = "0x6003CE6")]
	[Address(RVA = "0x2132248", Offset = "0x2132248", VA = "0x2132248", Slot = "16")]
	protected override void RetryProcess()
	{
	}
}
