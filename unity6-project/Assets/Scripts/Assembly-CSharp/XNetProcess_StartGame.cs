using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007B6")]
public class XNetProcess_StartGame : XNetProcess_GameBase
{
	[Token(Token = "0x4002306")]
	[FieldOffset(Offset = "0x34")]
	private XGameModeType m_game_mode;

	[Token(Token = "0x1700089F")]
	public override bool showLoadingIcon
	{
		[Token(Token = "0x6003E55")]
		[Address(RVA = "0x1EC8AF4", Offset = "0x1EC8AF4", VA = "0x1EC8AF4", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170008A0")]
	public override string Name
	{
		[Token(Token = "0x6003E57")]
		[Address(RVA = "0x1EC8C20", Offset = "0x1EC8C20", VA = "0x1EC8C20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E53")]
	[Address(RVA = "0x1EC8A30", Offset = "0x1EC8A30", VA = "0x1EC8A30")]
	public XNetProcess_StartGame()
	{
	}

	[Token(Token = "0x6003E54")]
	[Address(RVA = "0x1EC8A38", Offset = "0x1EC8A38", VA = "0x1EC8A38", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E56")]
	[Address(RVA = "0x1EC8AFC", Offset = "0x1EC8AFC", VA = "0x1EC8AFC", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E58")]
	[Address(RVA = "0x1EC8C98", Offset = "0x1EC8C98", VA = "0x1EC8C98", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E59")]
	[Address(RVA = "0x1EC8D60", Offset = "0x1EC8D60", VA = "0x1EC8D60", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E5A")]
	[Address(RVA = "0x1EC8D68", Offset = "0x1EC8D68", VA = "0x1EC8D68", Slot = "15")]
	protected override void OnTimeout()
	{
	}
}
