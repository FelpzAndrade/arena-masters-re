using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007AE")]
public class XNetProcess_EnterDungeon : XNetProcess_GameBase
{
	[Token(Token = "0x4002303")]
	[FieldOffset(Offset = "0x34")]
	private XGameModeType m_game_mode;

	[Token(Token = "0x17000897")]
	public override string Name
	{
		[Token(Token = "0x6003E26")]
		[Address(RVA = "0x2135FC4", Offset = "0x2135FC4", VA = "0x2135FC4", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E23")]
	[Address(RVA = "0x2135D3C", Offset = "0x2135D3C", VA = "0x2135D3C")]
	public XNetProcess_EnterDungeon()
	{
	}

	[Token(Token = "0x6003E24")]
	[Address(RVA = "0x2135D44", Offset = "0x2135D44", VA = "0x2135D44", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E25")]
	[Address(RVA = "0x2135E00", Offset = "0x2135E00", VA = "0x2135E00", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E27")]
	[Address(RVA = "0x213603C", Offset = "0x213603C", VA = "0x213603C", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E28")]
	[Address(RVA = "0x2136100", Offset = "0x2136100", VA = "0x2136100", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
