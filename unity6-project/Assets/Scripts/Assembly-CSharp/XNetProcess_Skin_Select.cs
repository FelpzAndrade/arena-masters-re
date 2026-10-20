using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000779")]
public class XNetProcess_Skin_Select : XNetProcess_GameBase
{
	[Token(Token = "0x17000859")]
	public override string Name
	{
		[Token(Token = "0x6003CD5")]
		[Address(RVA = "0x1EC84A8", Offset = "0x1EC84A8", VA = "0x1EC84A8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003CD2")]
	[Address(RVA = "0x1EC82C0", Offset = "0x1EC82C0", VA = "0x1EC82C0")]
	public XNetProcess_Skin_Select()
	{
	}

	[Token(Token = "0x6003CD3")]
	[Address(RVA = "0x1EC82C8", Offset = "0x1EC82C8", VA = "0x1EC82C8", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003CD4")]
	[Address(RVA = "0x1EC8384", Offset = "0x1EC8384", VA = "0x1EC8384", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003CD6")]
	[Address(RVA = "0x1EC8520", Offset = "0x1EC8520", VA = "0x1EC8520", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003CD7")]
	[Address(RVA = "0x1EC8528", Offset = "0x1EC8528", VA = "0x1EC8528", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
