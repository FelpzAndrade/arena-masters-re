using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200081B")]
public class XNetProcess_SetUserData : XNetProcess_GameBase
{
	[Token(Token = "0x1700090C")]
	public override bool showLoadingIcon
	{
		[Token(Token = "0x60040D1")]
		[Address(RVA = "0x1EC78D0", Offset = "0x1EC78D0", VA = "0x1EC78D0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700090D")]
	public override string Name
	{
		[Token(Token = "0x60040D4")]
		[Address(RVA = "0x1EC7AB8", Offset = "0x1EC7AB8", VA = "0x1EC7AB8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60040D0")]
	[Address(RVA = "0x1EC78C8", Offset = "0x1EC78C8", VA = "0x1EC78C8")]
	public XNetProcess_SetUserData()
	{
	}

	[Token(Token = "0x60040D2")]
	[Address(RVA = "0x1EC78D8", Offset = "0x1EC78D8", VA = "0x1EC78D8", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x60040D3")]
	[Address(RVA = "0x1EC7994", Offset = "0x1EC7994", VA = "0x1EC7994", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x60040D5")]
	[Address(RVA = "0x1EC7B30", Offset = "0x1EC7B30", VA = "0x1EC7B30", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x60040D6")]
	[Address(RVA = "0x1EC7B38", Offset = "0x1EC7B38", VA = "0x1EC7B38", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
