using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007CA")]
public class XNetProcess_ChangeRandomOption : XNetProcess_GameBase
{
	[Token(Token = "0x170008B6")]
	public override string Name
	{
		[Token(Token = "0x6003ED1")]
		[Address(RVA = "0x2130D84", Offset = "0x2130D84", VA = "0x2130D84", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003ECE")]
	[Address(RVA = "0x2130B9C", Offset = "0x2130B9C", VA = "0x2130B9C")]
	public XNetProcess_ChangeRandomOption()
	{
	}

	[Token(Token = "0x6003ECF")]
	[Address(RVA = "0x2130BA4", Offset = "0x2130BA4", VA = "0x2130BA4", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003ED0")]
	[Address(RVA = "0x2130C60", Offset = "0x2130C60", VA = "0x2130C60", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003ED2")]
	[Address(RVA = "0x2130DFC", Offset = "0x2130DFC", VA = "0x2130DFC", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003ED3")]
	[Address(RVA = "0x2130E00", Offset = "0x2130E00", VA = "0x2130E00", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
