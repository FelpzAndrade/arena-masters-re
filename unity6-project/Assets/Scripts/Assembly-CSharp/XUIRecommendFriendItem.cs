using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001033")]
public class XUIRecommendFriendItem : MonoBehaviour
{
	[Token(Token = "0x4005713")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblName;

	[Token(Token = "0x4005714")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblLevel;

	[Token(Token = "0x4005715")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblLastTime;

	[Token(Token = "0x4005716")]
	[FieldOffset(Offset = "0x18")]
	public UI2DSprite sprImage;

	[Token(Token = "0x4005717")]
	[FieldOffset(Offset = "0x1C")]
	public UI2DSprite sprTitle;

	[Token(Token = "0x4005718")]
	[FieldOffset(Offset = "0x20")]
	public UI2DSprite sprFlag;

	[Token(Token = "0x4005719")]
	[FieldOffset(Offset = "0x24")]
	private Friend m_user;

	[Token(Token = "0x400571A")]
	[FieldOffset(Offset = "0x28")]
	public XWidget_Button btnFriendRequest;

	[Token(Token = "0x400571B")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache8;

	[Token(Token = "0x60078C2")]
	[Address(RVA = "0x19157BC", Offset = "0x19157BC", VA = "0x19157BC")]
	public XUIRecommendFriendItem()
	{
	}

	[Token(Token = "0x60078C3")]
	[Address(RVA = "0x19157C4", Offset = "0x19157C4", VA = "0x19157C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60078C4")]
	[Address(RVA = "0x191593C", Offset = "0x191593C", VA = "0x191593C")]
	public void Build(Friend user)
	{
	}

	[Token(Token = "0x60078C5")]
	[Address(RVA = "0x1915F90", Offset = "0x1915F90", VA = "0x1915F90")]
	private void SetLastTime(Friend user)
	{
	}

	[Token(Token = "0x60078C6")]
	[Address(RVA = "0x191624C", Offset = "0x191624C", VA = "0x191624C")]
	public void OnClick_RequestFriend()
	{
	}

	[Token(Token = "0x60078C7")]
	[Address(RVA = "0x1916308", Offset = "0x1916308", VA = "0x1916308")]
	private static void _003CAwake_003Em__509()
	{
	}
}
