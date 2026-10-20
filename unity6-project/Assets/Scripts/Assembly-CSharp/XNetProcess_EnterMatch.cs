using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007B3")]
public class XNetProcess_EnterMatch : XNetProcess_GameBase
{
	[Token(Token = "0x4002305")]
	[FieldOffset(Offset = "0x34")]
	private XGameModeType m_game_mode;

	[Token(Token = "0x1700089C")]
	public override string Name
	{
		[Token(Token = "0x6003E44")]
		[Address(RVA = "0x2137784", Offset = "0x2137784", VA = "0x2137784", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E41")]
	[Address(RVA = "0x213759C", Offset = "0x213759C", VA = "0x213759C")]
	public XNetProcess_EnterMatch()
	{
	}

	[Token(Token = "0x6003E42")]
	[Address(RVA = "0x21375A4", Offset = "0x21375A4", VA = "0x21375A4", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E43")]
	[Address(RVA = "0x2137660", Offset = "0x2137660", VA = "0x2137660", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E45")]
	[Address(RVA = "0x21377FC", Offset = "0x21377FC", VA = "0x21377FC", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E46")]
	[Address(RVA = "0x2137800", Offset = "0x2137800", VA = "0x2137800", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
