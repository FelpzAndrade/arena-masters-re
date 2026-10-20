using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F9F")]
public class XWidget_LobbyBanner : MonoBehaviour
{
	[Token(Token = "0x2000FA0")]
	private sealed class _003CSetClickActionForCafeLink_003Ec__AnonStorey240
	{
		[Token(Token = "0x40052B4")]
		[FieldOffset(Offset = "0x8")]
		internal int articleId;

		[Token(Token = "0x600747A")]
		[Address(RVA = "0x145A8FC", Offset = "0x145A8FC", VA = "0x145A8FC")]
		public _003CSetClickActionForCafeLink_003Ec__AnonStorey240()
		{
		}

		[Token(Token = "0x600747B")]
		[Address(RVA = "0x145A994", Offset = "0x145A994", VA = "0x145A994")]
		internal void _003C_003Em__4BF(string unused)
		{
		}
	}

	[Token(Token = "0x40052AD")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprBackground;

	[Token(Token = "0x40052AE")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblTitle;

	[Token(Token = "0x40052AF")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblDesc;

	[Token(Token = "0x40052B0")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblSubDesc;

	[Token(Token = "0x40052B1")]
	[FieldOffset(Offset = "0x1C")]
	public XWiget_GridBuilder rankerBuilder;

	[Token(Token = "0x40052B2")]
	[FieldOffset(Offset = "0x20")]
	private string m_link;

	[Token(Token = "0x40052B3")]
	[FieldOffset(Offset = "0x24")]
	private Action<string> m_clickAction;

	[Token(Token = "0x600746F")]
	[Address(RVA = "0x145A1D0", Offset = "0x145A1D0", VA = "0x145A1D0")]
	public XWidget_LobbyBanner()
	{
	}

	[Token(Token = "0x6007470")]
	[Address(RVA = "0x145A294", Offset = "0x145A294", VA = "0x145A294")]
	public void SetTitle(string text)
	{
	}

	[Token(Token = "0x6007471")]
	[Address(RVA = "0x145A2A8", Offset = "0x145A2A8", VA = "0x145A2A8")]
	public void SetDesc(string desc)
	{
	}

	[Token(Token = "0x6007472")]
	[Address(RVA = "0x145A2BC", Offset = "0x145A2BC", VA = "0x145A2BC")]
	public void SetDesc(string desc, Vector3 localPos, NGUIText.Alignment Alignment = NGUIText.Alignment.Left)
	{
	}

	[Token(Token = "0x6007473")]
	[Address(RVA = "0x145A348", Offset = "0x145A348", VA = "0x145A348")]
	public void SetSubDesc(string subDesc)
	{
	}

	[Token(Token = "0x6007474")]
	[Address(RVA = "0x145A35C", Offset = "0x145A35C", VA = "0x145A35C")]
	public void SetSubDesc(string desc, Vector3 localPos, NGUIText.Alignment Alignment = NGUIText.Alignment.Left)
	{
	}

	[Token(Token = "0x6007475")]
	[Address(RVA = "0x145A3E8", Offset = "0x145A3E8", VA = "0x145A3E8")]
	public void SetBackground(string path)
	{
	}

	[Token(Token = "0x6007476")]
	[Address(RVA = "0x145A548", Offset = "0x145A548", VA = "0x145A548")]
	public void BuildRanker(int buildCount, Action<int, XUILobbyRankerItem> buildAction)
	{
	}

	[Token(Token = "0x6007477")]
	[Address(RVA = "0x145A658", Offset = "0x145A658", VA = "0x145A658")]
	public void SetClickAction(string link, Action<string> clickAction)
	{
	}

	[Token(Token = "0x6007478")]
	[Address(RVA = "0x145A664", Offset = "0x145A664", VA = "0x145A664")]
	public void SetClickActionForCafeLink(string link)
	{
	}

	[Token(Token = "0x6007479")]
	[Address(RVA = "0x145A904", Offset = "0x145A904", VA = "0x145A904")]
	public void OnClick_Banner()
	{
	}
}
