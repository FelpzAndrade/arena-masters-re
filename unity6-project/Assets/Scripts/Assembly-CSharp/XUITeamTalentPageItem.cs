using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F60")]
public class XUITeamTalentPageItem : MonoBehaviour
{
	[Token(Token = "0x40050C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public GameObject goSprLock;

	[Token(Token = "0x40050C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject bgActive;

	[Token(Token = "0x40050C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public GameObject bgDeactive;

	[Token(Token = "0x40050C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UILabel lblNumber;

	[Token(Token = "0x40050C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Action<int> m_action;

	[Token(Token = "0x40050C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int myPageNumber;

	[Token(Token = "0x40050C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int m_selectNumber;

	[Token(Token = "0x40050C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_block;

	[Token(Token = "0x6007242")]
	[Address(RVA = "0x19370AC", Offset = "0x19370AC", VA = "0x19370AC")]
	public XUITeamTalentPageItem()
	{
	}

	[Token(Token = "0x6007243")]
	[Address(RVA = "0x19370B4", Offset = "0x19370B4", VA = "0x19370B4")]
	public void Build(int pageNumber, [Optional][DefaultParameterValue(false)] bool ShowTP, [Optional] Action<int> action, bool block = false)
	{
	}

	[Token(Token = "0x6007244")]
	[Address(RVA = "0x1937608", Offset = "0x1937608", VA = "0x1937608")]
	public void RefreshBuild(int selectNumber)
	{
	}

	[Token(Token = "0x6007245")]
	[Address(RVA = "0x1937328", Offset = "0x1937328", VA = "0x1937328")]
	private void BuildTP(bool block = false)
	{
	}

	[Token(Token = "0x6007246")]
	[Address(RVA = "0x1937854", Offset = "0x1937854", VA = "0x1937854")]
	private int GetOpenTalentLevel()
	{
		return default(int);
	}

	[Token(Token = "0x6007247")]
	[Address(RVA = "0x1937A04", Offset = "0x1937A04", VA = "0x1937A04")]
	public void OnClick()
	{
	}
}
