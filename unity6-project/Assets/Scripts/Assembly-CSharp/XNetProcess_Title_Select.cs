using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007F8")]
public class XNetProcess_Title_Select : XNetProcess_GameBase
{
	[Token(Token = "0x170008E2")]
	public override string Name
	{
		[Token(Token = "0x6003FE0")]
		[Address(RVA = "0x1EC97EC", Offset = "0x1EC97EC", VA = "0x1EC97EC", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003FDD")]
	[Address(RVA = "0x1EC9604", Offset = "0x1EC9604", VA = "0x1EC9604")]
	public XNetProcess_Title_Select()
	{
	}

	[Token(Token = "0x6003FDE")]
	[Address(RVA = "0x1EC960C", Offset = "0x1EC960C", VA = "0x1EC960C", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003FDF")]
	[Address(RVA = "0x1EC96C8", Offset = "0x1EC96C8", VA = "0x1EC96C8", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003FE1")]
	[Address(RVA = "0x1EC9864", Offset = "0x1EC9864", VA = "0x1EC9864", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003FE2")]
	[Address(RVA = "0x1EC986C", Offset = "0x1EC986C", VA = "0x1EC986C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
