using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D2A")]
public class XUIIngameCustomMessage : MonoBehaviour
{
	[Token(Token = "0x4004354")]
	public const string RelayMatchWin = "UI_new/imtex/imtex_winner";

	[Token(Token = "0x4004355")]
	public const string RelayMatchLose = "UI_new/imtex/imtex_ko";

	[Token(Token = "0x4004356")]
	public const string RelayMatchDraw = "UI_new/imtex/imtex_draw";

	[Token(Token = "0x4004357")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprResult;

	[Token(Token = "0x4004358")]
	[FieldOffset(Offset = "0x10")]
	public TweenAlpha hideTimer;

	[Token(Token = "0x4004359")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map16;

	[Token(Token = "0x600609B")]
	[Address(RVA = "0x1090D4C", Offset = "0x1090D4C", VA = "0x1090D4C")]
	public XUIIngameCustomMessage()
	{
	}

	[Token(Token = "0x600609C")]
	[Address(RVA = "0x1090D54", Offset = "0x1090D54", VA = "0x1090D54")]
	public void Build(string strMsgKey, float duration)
	{
	}

	[Token(Token = "0x600609D")]
	[Address(RVA = "0x1090F20", Offset = "0x1090F20", VA = "0x1090F20")]
	private void SoundPlay(string strMsgKey)
	{
	}

	[Token(Token = "0x600609E")]
	[Address(RVA = "0x1091250", Offset = "0x1091250", VA = "0x1091250")]
	public void Hide()
	{
	}
}
