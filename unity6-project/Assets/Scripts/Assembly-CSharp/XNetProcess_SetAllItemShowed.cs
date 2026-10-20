using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007C5")]
public class XNetProcess_SetAllItemShowed : XNetProcess_GameBase
{
	[Token(Token = "0x170008B0")]
	public override bool showLoadingIcon
	{
		[Token(Token = "0x6003EB0")]
		[Address(RVA = "0x1EC7160", Offset = "0x1EC7160", VA = "0x1EC7160", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170008B1")]
	public override string Name
	{
		[Token(Token = "0x6003EB3")]
		[Address(RVA = "0x1EC7348", Offset = "0x1EC7348", VA = "0x1EC7348", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003EAF")]
	[Address(RVA = "0x1EC7158", Offset = "0x1EC7158", VA = "0x1EC7158")]
	public XNetProcess_SetAllItemShowed()
	{
	}

	[Token(Token = "0x6003EB1")]
	[Address(RVA = "0x1EC7168", Offset = "0x1EC7168", VA = "0x1EC7168", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003EB2")]
	[Address(RVA = "0x1EC7224", Offset = "0x1EC7224", VA = "0x1EC7224", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003EB4")]
	[Address(RVA = "0x1EC73C0", Offset = "0x1EC73C0", VA = "0x1EC73C0", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003EB5")]
	[Address(RVA = "0x1EC73C8", Offset = "0x1EC73C8", VA = "0x1EC73C8", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
