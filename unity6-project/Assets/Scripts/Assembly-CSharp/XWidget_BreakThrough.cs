using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D90")]
public class XWidget_BreakThrough : MonoBehaviour
{
	[Token(Token = "0x400466D")]
	[FieldOffset(Offset = "0xC")]
	public Transform transformItemRoot;

	[Token(Token = "0x400466E")]
	[FieldOffset(Offset = "0x10")]
	private XWidget_ContentIcon m_contentIcon;

	[Token(Token = "0x400466F")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblWords;

	[Token(Token = "0x4004670")]
	[FieldOffset(Offset = "0x18")]
	private UITweener[] m_tweens;

	[Token(Token = "0x60063A9")]
	[Address(RVA = "0x15C10C8", Offset = "0x15C10C8", VA = "0x15C10C8")]
	public XWidget_BreakThrough()
	{
	}

	[Token(Token = "0x60063AA")]
	[Address(RVA = "0x15C10D0", Offset = "0x15C10D0", VA = "0x15C10D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60063AB")]
	[Address(RVA = "0x15C1174", Offset = "0x15C1174", VA = "0x15C1174")]
	private void PlayEffects()
	{
	}

	[Token(Token = "0x60063AC")]
	[Address(RVA = "0x15C1294", Offset = "0x15C1294", VA = "0x15C1294")]
	public void Build(int rewardID, int rewardCnt, CSContentType contentType)
	{
	}

	[Token(Token = "0x60063AD")]
	[Address(RVA = "0x15C2000", Offset = "0x15C2000", VA = "0x15C2000")]
	public void Show(string words)
	{
	}

	[Token(Token = "0x60063AE")]
	[Address(RVA = "0x15C207C", Offset = "0x15C207C", VA = "0x15C207C")]
	public void Hide()
	{
	}
}
