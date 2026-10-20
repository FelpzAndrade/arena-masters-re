using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D52")]
public class XWidget_WelcomeProfileIcon : MonoBehaviour
{
	[Token(Token = "0x4004480")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprChar;

	[Token(Token = "0x4004481")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprCharTitle;

	[Token(Token = "0x4004482")]
	[FieldOffset(Offset = "0x14")]
	protected bool m_isShow;

	[Token(Token = "0x4004483")]
	[FieldOffset(Offset = "0x18")]
	private float m_show_KeepTime;

	[Token(Token = "0x4004484")]
	[FieldOffset(Offset = "0x1C")]
	private float m_show_ElapsedTime;

	[Token(Token = "0x4004485")]
	[FieldOffset(Offset = "0x20")]
	protected Action endShowAction;

	[Token(Token = "0x4004486")]
	[FieldOffset(Offset = "0x24")]
	private UIWidget _widget;

	[Token(Token = "0x60061C9")]
	[Address(RVA = "0x1B33C80", Offset = "0x1B33C80", VA = "0x1B33C80")]
	public XWidget_WelcomeProfileIcon()
	{
	}

	[Token(Token = "0x60061CA")]
	[Address(RVA = "0x1B33C90", Offset = "0x1B33C90", VA = "0x1B33C90")]
	public void SetAlpha(float alpha)
	{
	}

	[Token(Token = "0x60061CB")]
	[Address(RVA = "0x1B33D9C", Offset = "0x1B33D9C", VA = "0x1B33D9C")]
	public void Show(int profileIconID, int titleID, float durationTime)
	{
	}

	[Token(Token = "0x60061CC")]
	[Address(RVA = "0x1B34110", Offset = "0x1B34110", VA = "0x1B34110")]
	protected void SetEndAction(Action action)
	{
	}

	[Token(Token = "0x60061CD")]
	[Address(RVA = "0x1B33EEC", Offset = "0x1B33EEC", VA = "0x1B33EEC")]
	protected void ResetElapedTime()
	{
	}

	[Token(Token = "0x60061CE")]
	[Address(RVA = "0x1B34004", Offset = "0x1B34004", VA = "0x1B34004")]
	protected void SetCharTitle(int titleID)
	{
	}

	[Token(Token = "0x60061CF")]
	[Address(RVA = "0x1B33EF8", Offset = "0x1B33EF8", VA = "0x1B33EF8")]
	protected void SetProfileIcon(int profileIconId)
	{
	}

	[Token(Token = "0x60061D0")]
	[Address(RVA = "0x1B34118", Offset = "0x1B34118", VA = "0x1B34118")]
	public void Hide()
	{
	}

	[Token(Token = "0x60061D1")]
	[Address(RVA = "0x1B3414C", Offset = "0x1B3414C", VA = "0x1B3414C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60061D2")]
	[Address(RVA = "0x1B34174", Offset = "0x1B34174", VA = "0x1B34174")]
	private void UpdateMultiKill(float deltaTime)
	{
	}
}
