using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007F3")]
public class XNetProcess_Talent_Reset : XNetProcess_GameBase
{
	[Token(Token = "0x170008DD")]
	public override string Name
	{
		[Token(Token = "0x6003FC2")]
		[Address(RVA = "0x1EC9040", Offset = "0x1EC9040", VA = "0x1EC9040", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003FBF")]
	[Address(RVA = "0x1EC8E58", Offset = "0x1EC8E58", VA = "0x1EC8E58")]
	public XNetProcess_Talent_Reset()
	{
	}

	[Token(Token = "0x6003FC0")]
	[Address(RVA = "0x1EC8E60", Offset = "0x1EC8E60", VA = "0x1EC8E60", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003FC1")]
	[Address(RVA = "0x1EC8F1C", Offset = "0x1EC8F1C", VA = "0x1EC8F1C", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003FC3")]
	[Address(RVA = "0x1EC90B8", Offset = "0x1EC90B8", VA = "0x1EC90B8", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003FC4")]
	[Address(RVA = "0x1EC90C0", Offset = "0x1EC90C0", VA = "0x1EC90C0", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
