using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000DD8")]
public class XPanel_CustomRoomList : XUIBasePanel
{
	[Token(Token = "0x4004819")]
	[FieldOffset(Offset = "0x10")]
	private List<XUICustomRoomInfo> m_list;

	[Token(Token = "0x400481A")]
	[FieldOffset(Offset = "0x14")]
	public XUICustomRoomList cutsomRoomList;

	[Token(Token = "0x400481B")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_FriendlyInpuPassword PasswordInputBox;

	[Token(Token = "0x400481C")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView scrollView;

	[Token(Token = "0x600661D")]
	[Address(RVA = "0x16B4D54", Offset = "0x16B4D54", VA = "0x16B4D54")]
	public XPanel_CustomRoomList()
	{
	}

	[Token(Token = "0x600661E")]
	[Address(RVA = "0x16B4E00", Offset = "0x16B4E00", VA = "0x16B4E00")]
	public void Build()
	{
	}

	[Token(Token = "0x600661F")]
	[Address(RVA = "0x16B5E1C", Offset = "0x16B5E1C", VA = "0x16B5E1C")]
	public void OnClick_RoomItem(CustomRoomInfo roomInfo)
	{
	}

	[Token(Token = "0x6006620")]
	[Address(RVA = "0x16B5FF0", Offset = "0x16B5FF0", VA = "0x16B5FF0")]
	public void OnClickRefresh()
	{
	}

	[Token(Token = "0x6006621")]
	[Address(RVA = "0x16B6424", Offset = "0x16B6424", VA = "0x16B6424")]
	private void _003COnClickRefresh_003Em__35B()
	{
	}
}
