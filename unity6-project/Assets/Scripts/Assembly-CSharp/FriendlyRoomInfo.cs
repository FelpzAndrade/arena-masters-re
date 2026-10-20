using System;
using Il2CppDummyDll;

[Token(Token = "0x2000977")]
public class FriendlyRoomInfo : CSRoomInfo
{
	[Token(Token = "0x4002ED6")]
	[FieldOffset(Offset = "0x3C")]
	public Action<FriendlyRoomInfo> ClickAction;

	[Token(Token = "0x6004C2B")]
	[Address(RVA = "0x1F2800C", Offset = "0x1F2800C", VA = "0x1F2800C")]
	public FriendlyRoomInfo()
	{
	}
}
