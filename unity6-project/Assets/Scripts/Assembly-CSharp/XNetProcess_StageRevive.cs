using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007BC")]
public class XNetProcess_StageRevive : XNetProcess_GameBase
{
	[Token(Token = "0x170008A7")]
	public override string Name
	{
		[Token(Token = "0x6003E7D")]
		[Address(RVA = "0x1EC89A8", Offset = "0x1EC89A8", VA = "0x1EC89A8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E7A")]
	[Address(RVA = "0x1EC87C0", Offset = "0x1EC87C0", VA = "0x1EC87C0")]
	public XNetProcess_StageRevive()
	{
	}

	[Token(Token = "0x6003E7B")]
	[Address(RVA = "0x1EC87C8", Offset = "0x1EC87C8", VA = "0x1EC87C8", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E7C")]
	[Address(RVA = "0x1EC8884", Offset = "0x1EC8884", VA = "0x1EC8884", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E7E")]
	[Address(RVA = "0x1EC8A20", Offset = "0x1EC8A20", VA = "0x1EC8A20", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E7F")]
	[Address(RVA = "0x1EC8A28", Offset = "0x1EC8A28", VA = "0x1EC8A28", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
