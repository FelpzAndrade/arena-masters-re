using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FA6")]
public class XWidget_LobbyMainButtons : MonoBehaviour
{
	[Token(Token = "0x2000FA7")]
	public class ButtonData
	{
		[Token(Token = "0x40052DC")]
		[FieldOffset(Offset = "0x8")]
		public string key;

		[Token(Token = "0x40052DD")]
		[FieldOffset(Offset = "0xC")]
		public string iconName;

		[Token(Token = "0x40052DE")]
		[FieldOffset(Offset = "0x10")]
		public string textKey;

		[Token(Token = "0x40052DF")]
		[FieldOffset(Offset = "0x14")]
		public Action<XWidget_LobbyMainButton> onBuild;

		[Token(Token = "0x40052E0")]
		[FieldOffset(Offset = "0x18")]
		public Action onClick;

		[Token(Token = "0x40052E1")]
		[FieldOffset(Offset = "0x1C")]
		public Action onClickLock;

		[Token(Token = "0x40052E2")]
		[FieldOffset(Offset = "0x20")]
		public List<ButtonData> subMenus;

		[Token(Token = "0x40052E3")]
		[FieldOffset(Offset = "0x24")]
		public bool hide;

		[Token(Token = "0x6007496")]
		[Address(RVA = "0x145DB7C", Offset = "0x145DB7C", VA = "0x145DB7C")]
		public ButtonData()
		{
		}
	}

	[Token(Token = "0x40052D3")]
	[FieldOffset(Offset = "0xC")]
	public List<ButtonData> datas;

	[Token(Token = "0x40052D4")]
	[FieldOffset(Offset = "0x10")]
	public XWidget_LobbyMainButton lobbyMainButtonQuest;

	[Token(Token = "0x40052D5")]
	[FieldOffset(Offset = "0x14")]
	public XWidget_LobbyMainButton lobbyMainButtonAchievement;

	[Token(Token = "0x40052D6")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_LobbyMainButton lobbyMainButtonItem;

	[Token(Token = "0x40052D7")]
	[FieldOffset(Offset = "0x1C")]
	public XWidget_LobbyMainButton lobbyMainButtonFriend;

	[Token(Token = "0x40052D8")]
	[FieldOffset(Offset = "0x20")]
	public XWidget_LobbyMainButton lobbyMainButtonRanking;

	[Token(Token = "0x40052D9")]
	[FieldOffset(Offset = "0x24")]
	public XWidget_Slide slide;

	[Token(Token = "0x40052DA")]
	[FieldOffset(Offset = "0x28")]
	public UISprite sprArrow;

	[Token(Token = "0x40052DB")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject goNewBadge;

	[Token(Token = "0x6007492")]
	[Address(RVA = "0x145D934", Offset = "0x145D934", VA = "0x145D934")]
	public XWidget_LobbyMainButtons()
	{
	}

	[Token(Token = "0x6007493")]
	[Address(RVA = "0x145D9E0", Offset = "0x145D9E0", VA = "0x145D9E0")]
	public void Build()
	{
	}

	[Token(Token = "0x6007494")]
	[Address(RVA = "0x145DA10", Offset = "0x145DA10", VA = "0x145DA10")]
	public void SetNewBadge(bool isShow)
	{
	}

	[Token(Token = "0x6007495")]
	[Address(RVA = "0x145DAF0", Offset = "0x145DAF0", VA = "0x145DAF0")]
	public void OnClick_SlideButton()
	{
	}
}
