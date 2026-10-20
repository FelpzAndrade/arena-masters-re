using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000820")]
public class XNetProcess_GetBestRankGameRecord : XNetProcess_GameBase
{
	[Token(Token = "0x17000912")]
	public override string Name
	{
		[Token(Token = "0x60040F2")]
		[Address(RVA = "0x213A7D8", Offset = "0x213A7D8", VA = "0x213A7D8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60040EF")]
	[Address(RVA = "0x213A5F0", Offset = "0x213A5F0", VA = "0x213A5F0")]
	public XNetProcess_GetBestRankGameRecord()
	{
	}

	[Token(Token = "0x60040F0")]
	[Address(RVA = "0x213A5F8", Offset = "0x213A5F8", VA = "0x213A5F8", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x60040F1")]
	[Address(RVA = "0x213A6B4", Offset = "0x213A6B4", VA = "0x213A6B4", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x60040F3")]
	[Address(RVA = "0x213A850", Offset = "0x213A850", VA = "0x213A850", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x60040F4")]
	[Address(RVA = "0x213A854", Offset = "0x213A854", VA = "0x213A854", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
