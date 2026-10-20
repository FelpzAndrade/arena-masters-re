using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000E3B")]
public class Xpanel_FriendlyMatchRoomList : XUIBasePanel
{
	[Token(Token = "0x4004B03")]
	[FieldOffset(Offset = "0x10")]
	private List<FriendlyRoomInfo> m_list;

	[Token(Token = "0x4004B04")]
	[FieldOffset(Offset = "0x14")]
	public XUIFriendlyRoomList friendlyRoomList;

	[Token(Token = "0x4004B05")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_FriendlyRoomMakeBox friendlyRoomMakeBox;

	[Token(Token = "0x4004B06")]
	[FieldOffset(Offset = "0x1C")]
	public XWidget_FriendlyInpuPassword friendlyInputPasswordBox;

	[Token(Token = "0x4004B07")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView scrollView;

	[Token(Token = "0x60069ED")]
	[Address(RVA = "0xFCC748", Offset = "0xFCC748", VA = "0xFCC748")]
	public Xpanel_FriendlyMatchRoomList()
	{
	}

	[Token(Token = "0x60069EE")]
	[Address(RVA = "0xFCC7F4", Offset = "0xFCC7F4", VA = "0xFCC7F4")]
	public void Build()
	{
	}

	[Token(Token = "0x60069EF")]
	[Address(RVA = "0xFCD6F8", Offset = "0xFCD6F8", VA = "0xFCD6F8")]
	public void OnClick_RoomItem(FriendlyRoomInfo roomInfo)
	{
	}

	[Token(Token = "0x60069F0")]
	[Address(RVA = "0xFCD8E4", Offset = "0xFCD8E4", VA = "0xFCD8E4")]
	public void OnClick_MakeRoom()
	{
	}

	[Token(Token = "0x60069F1")]
	[Address(RVA = "0xFCD9D0", Offset = "0xFCD9D0", VA = "0xFCD9D0")]
	public void OnClickRefresh()
	{
	}

	[Token(Token = "0x60069F2")]
	[Address(RVA = "0xFCDE04", Offset = "0xFCDE04", VA = "0xFCDE04")]
	private void _003COnClickRefresh_003Em__3D4()
	{
	}
}
