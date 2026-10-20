using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200077C")]
public class XNetProcess_ChatLoad : XNetProcessBase
{
	[Token(Token = "0x1700085D")]
	public override string Name
	{
		[Token(Token = "0x6003CEA")]
		[Address(RVA = "0x2131984", Offset = "0x2131984", VA = "0x2131984", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700085E")]
	public override float TimeoutSeconds
	{
		[Token(Token = "0x6003CEB")]
		[Address(RVA = "0x21319FC", Offset = "0x21319FC", VA = "0x21319FC", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6003CE7")]
	[Address(RVA = "0x213179C", Offset = "0x213179C", VA = "0x213179C")]
	public XNetProcess_ChatLoad()
	{
	}

	[Token(Token = "0x6003CE8")]
	[Address(RVA = "0x21317A4", Offset = "0x21317A4", VA = "0x21317A4", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003CE9")]
	[Address(RVA = "0x2131860", Offset = "0x2131860", VA = "0x2131860", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003CEC")]
	[Address(RVA = "0x2131A08", Offset = "0x2131A08", VA = "0x2131A08", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003CED")]
	[Address(RVA = "0x2131A10", Offset = "0x2131A10", VA = "0x2131A10", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x6003CEE")]
	[Address(RVA = "0x2131A18", Offset = "0x2131A18", VA = "0x2131A18", Slot = "15")]
	protected override void OnTimeout()
	{
	}

	[Token(Token = "0x6003CEF")]
	[Address(RVA = "0x2131C34", Offset = "0x2131C34", VA = "0x2131C34", Slot = "16")]
	protected override void RetryProcess()
	{
	}
}
