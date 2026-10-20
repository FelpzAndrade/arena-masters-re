using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000822")]
public class XNetCommand_GetOtherUserdata : XNetProcess_GameBase
{
	[Token(Token = "0x17000914")]
	public override float networkLoadingPanelDelay
	{
		[Token(Token = "0x60040FE")]
		[Address(RVA = "0xBA70FC", Offset = "0xBA70FC", VA = "0xBA70FC", Slot = "19")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000915")]
	public override string Name
	{
		[Token(Token = "0x60040FF")]
		[Address(RVA = "0xBA7108", Offset = "0xBA7108", VA = "0xBA7108", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60040FB")]
	[Address(RVA = "0xBA6F14", Offset = "0xBA6F14", VA = "0xBA6F14")]
	public XNetCommand_GetOtherUserdata()
	{
	}

	[Token(Token = "0x60040FC")]
	[Address(RVA = "0xBA6F1C", Offset = "0xBA6F1C", VA = "0xBA6F1C", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x60040FD")]
	[Address(RVA = "0xBA6FD8", Offset = "0xBA6FD8", VA = "0xBA6FD8", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6004100")]
	[Address(RVA = "0xBA7180", Offset = "0xBA7180", VA = "0xBA7180", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6004101")]
	[Address(RVA = "0xBA7188", Offset = "0xBA7188", VA = "0xBA7188", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
