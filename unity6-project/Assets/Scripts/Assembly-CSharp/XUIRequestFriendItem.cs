using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001034")]
public class XUIRequestFriendItem : MonoBehaviour
{
	[Token(Token = "0x400571C")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblName;

	[Token(Token = "0x400571D")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblLevel;

	[Token(Token = "0x400571E")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblLastTime;

	[Token(Token = "0x400571F")]
	[FieldOffset(Offset = "0x18")]
	public UI2DSprite sprImage;

	[Token(Token = "0x4005720")]
	[FieldOffset(Offset = "0x1C")]
	public UI2DSprite sprTitle;

	[Token(Token = "0x4005721")]
	[FieldOffset(Offset = "0x20")]
	public UI2DSprite sprFlag;

	[Token(Token = "0x4005722")]
	[FieldOffset(Offset = "0x24")]
	private Friend m_user;

	[Token(Token = "0x60078C8")]
	[Address(RVA = "0x1919A58", Offset = "0x1919A58", VA = "0x1919A58")]
	public XUIRequestFriendItem()
	{
	}

	[Token(Token = "0x60078C9")]
	[Address(RVA = "0x1919A60", Offset = "0x1919A60", VA = "0x1919A60")]
	public void Build(Friend user)
	{
	}

	[Token(Token = "0x60078CA")]
	[Address(RVA = "0x1919FD8", Offset = "0x1919FD8", VA = "0x1919FD8")]
	private void SetLastTime(Friend user)
	{
	}

	[Token(Token = "0x60078CB")]
	[Address(RVA = "0x191A294", Offset = "0x191A294", VA = "0x191A294")]
	public void OnClick_FriendEmbracement()
	{
	}

	[Token(Token = "0x60078CC")]
	[Address(RVA = "0x191A350", Offset = "0x191A350", VA = "0x191A350")]
	public void OnClick_FriendRefusal()
	{
	}
}
