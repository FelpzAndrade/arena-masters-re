using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D45")]
public class XWidget_ResultExpression : MonoBehaviour
{
	[Token(Token = "0x4004443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UI2DSprite sprExpression;

	[Token(Token = "0x4004444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public TweenScale sprExpresstionTweenScale;

	[Token(Token = "0x4004445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public TweenAlpha sprExpresstionTweenAlpha;

	[Token(Token = "0x4004446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UILabel lblExpression;

	[Token(Token = "0x4004447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public TweenScale lblExpresstionTweenScale;

	[Token(Token = "0x4004448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TweenAlpha lblExpresstionTweenAlpha;

	[Token(Token = "0x4004449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int endEventCheckCount;

	[Token(Token = "0x400444A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool isStartExpression;

	[Token(Token = "0x400444B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private readonly int tweenCount;

	[Token(Token = "0x400444C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Action m_endTweenAction;

	[Token(Token = "0x400444D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public UIBasicSprite sprBlackOut;

	[Token(Token = "0x400444E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float m_showBlackOutTime;

	[Token(Token = "0x400444F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float m_showBlackOutDeltaTime;

	[Token(Token = "0x4004450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private XGameModeType m_gameModeType;

	[Token(Token = "0x6006183")]
	[Address(RVA = "0x13435D4", Offset = "0x13435D4", VA = "0x13435D4")]
	public XWidget_ResultExpression()
	{
	}

	[Token(Token = "0x6006184")]
	[Address(RVA = "0x13435F0", Offset = "0x13435F0", VA = "0x13435F0")]
	private void ResetTween()
	{
	}

	[Token(Token = "0x6006185")]
	[Address(RVA = "0x134365C", Offset = "0x134365C", VA = "0x134365C")]
	private void StartTween()
	{
	}

	[Token(Token = "0x6006186")]
	[Address(RVA = "0x13436D0", Offset = "0x13436D0", VA = "0x13436D0")]
	private void Reset()
	{
	}

	[Token(Token = "0x6006187")]
	[Address(RVA = "0x13436F8", Offset = "0x13436F8", VA = "0x13436F8")]
	public void EndExpresstionTweenEevnt()
	{
	}

	[Token(Token = "0x6006188")]
	[Address(RVA = "0x1343708", Offset = "0x1343708", VA = "0x1343708")]
	public void Init()
	{
	}

	[Token(Token = "0x6006189")]
	[Address(RVA = "0x13437D8", Offset = "0x13437D8", VA = "0x13437D8")]
	public void Show(XGameModeType gameModeType, CSWinlose gameResult, [Optional] Action endAction)
	{
	}

	[Token(Token = "0x600618A")]
	[Address(RVA = "0x1343CC8", Offset = "0x1343CC8", VA = "0x1343CC8")]
	public void Hide()
	{
	}

	[Token(Token = "0x600618B")]
	[Address(RVA = "0x1343768", Offset = "0x1343768", VA = "0x1343768")]
	private void ShowExpresion(bool isShow)
	{
	}

	[Token(Token = "0x600618C")]
	[Address(RVA = "0x1343D54", Offset = "0x1343D54", VA = "0x1343D54")]
	private void Update()
	{
	}
}
