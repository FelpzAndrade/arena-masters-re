using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CEA")]
public class InterfaceTeamMember : InterfaceCharacter
{
	[Token(Token = "0x40041D4")]
	[FieldOffset(Offset = "0x80")]
	public UILabel lblCool;

	[Token(Token = "0x40041D5")]
	[FieldOffset(Offset = "0x84")]
	public UISprite sprDisablePrb;

	[Token(Token = "0x40041D6")]
	[FieldOffset(Offset = "0x88")]
	public UISprite sprPortraitDisable;

	[Token(Token = "0x40041D7")]
	[FieldOffset(Offset = "0x8C")]
	public XWidget_RoudTripTime roundTripTime;

	[Token(Token = "0x40041D8")]
	[FieldOffset(Offset = "0x90")]
	public UIButton btnBan;

	[Token(Token = "0x40041D9")]
	[FieldOffset(Offset = "0x94")]
	public GameObject btnSpectator;

	[Token(Token = "0x40041DA")]
	[FieldOffset(Offset = "0x98")]
	public UISprite sprFriendlyTeamBg;

	[Token(Token = "0x40041DB")]
	[FieldOffset(Offset = "0x9C")]
	private bool m_disabled;

	[Token(Token = "0x40041DC")]
	[FieldOffset(Offset = "0xA0")]
	private Action m_banButtonClick;

	[Token(Token = "0x40041DD")]
	[FieldOffset(Offset = "0xA4")]
	private Action m_spectatorButtonClick;

	[Token(Token = "0x40041DE")]
	[FieldOffset(Offset = "0xA8")]
	private int lastCool;

	[Token(Token = "0x17000CF1")]
	protected override bool enableUltEffect
	{
		[Token(Token = "0x6005D39")]
		[Address(RVA = "0xD8E818", Offset = "0xD8E818", VA = "0xD8E818", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6005D38")]
	[Address(RVA = "0xD8E764", Offset = "0xD8E764", VA = "0xD8E764")]
	public InterfaceTeamMember()
	{
	}

	[Token(Token = "0x6005D3A")]
	[Address(RVA = "0xD8E820", Offset = "0xD8E820", VA = "0xD8E820")]
	public void SetBanButtonClickAction(Action banButtonClick)
	{
	}

	[Token(Token = "0x6005D3B")]
	[Address(RVA = "0xD8E828", Offset = "0xD8E828", VA = "0xD8E828")]
	public void SetSpectatorButtonClickAction(Action spectatorButtonClick)
	{
	}

	[Token(Token = "0x6005D3C")]
	[Address(RVA = "0xD8E830", Offset = "0xD8E830", VA = "0xD8E830")]
	public void Disable(bool val)
	{
	}

	[Token(Token = "0x6005D3D")]
	[Address(RVA = "0xD8E92C", Offset = "0xD8E92C", VA = "0xD8E92C")]
	public void SetOffline()
	{
	}

	[Token(Token = "0x6005D3E")]
	[Address(RVA = "0xD8EA2C", Offset = "0xD8EA2C", VA = "0xD8EA2C")]
	private bool IsShowCoolTime()
	{
		return default(bool);
	}

	[Token(Token = "0x6005D3F")]
	[Address(RVA = "0xD8EB08", Offset = "0xD8EB08", VA = "0xD8EB08")]
	public void SetCoolTimeLabel(float remainCoolTime)
	{
	}

	[Token(Token = "0x6005D40")]
	[Address(RVA = "0xD8EC58", Offset = "0xD8EC58", VA = "0xD8EC58")]
	internal void UpdateRoundTripTime(int ping)
	{
	}

	[Token(Token = "0x6005D41")]
	[Address(RVA = "0xD8ED38", Offset = "0xD8ED38", VA = "0xD8ED38")]
	public void OnClickBtnBanPlayer()
	{
	}

	[Token(Token = "0x6005D42")]
	[Address(RVA = "0xD8ED4C", Offset = "0xD8ED4C", VA = "0xD8ED4C")]
	public void OnClickBtnSpectatorPlayer()
	{
	}

	[Token(Token = "0x6005D43")]
	[Address(RVA = "0xD8ED60", Offset = "0xD8ED60", VA = "0xD8ED60")]
	internal void ShowPlayerBanButton()
	{
	}

	[Token(Token = "0x6005D44")]
	[Address(RVA = "0xD8EDA0", Offset = "0xD8EDA0", VA = "0xD8EDA0")]
	internal void HidePlayerBanButton()
	{
	}

	[Token(Token = "0x6005D45")]
	[Address(RVA = "0xD8EDE0", Offset = "0xD8EDE0", VA = "0xD8EDE0")]
	internal void ShowPlayerSpectatorButton()
	{
	}

	[Token(Token = "0x6005D46")]
	[Address(RVA = "0xD8EE10", Offset = "0xD8EE10", VA = "0xD8EE10")]
	internal void HidePlayerSpectatorButton()
	{
	}

	[Token(Token = "0x6005D47")]
	[Address(RVA = "0xD8EE40", Offset = "0xD8EE40", VA = "0xD8EE40")]
	internal void SetTeamInfo(string nickName)
	{
	}
}
