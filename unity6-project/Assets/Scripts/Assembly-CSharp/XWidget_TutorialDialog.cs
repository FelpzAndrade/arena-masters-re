using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C22")]
public class XWidget_TutorialDialog : MonoBehaviour
{
	[Token(Token = "0x4003D4C")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprLeftIllust;

	[Token(Token = "0x4003D4D")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprRightIllust;

	[Token(Token = "0x4003D4E")]
	[FieldOffset(Offset = "0x14")]
	public TypewriterEffect typewrite;

	[Token(Token = "0x4003D4F")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblMessage;

	[Token(Token = "0x4003D50")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject goNext;

	[Token(Token = "0x4003D51")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblName;

	[Token(Token = "0x4003D52")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblDesc;

	[Token(Token = "0x4003D53")]
	[FieldOffset(Offset = "0x28")]
	public float OneLetterOutTime;

	[Token(Token = "0x4003D54")]
	[FieldOffset(Offset = "0x2C")]
	public float skipableLimitTime;

	[Token(Token = "0x4003D55")]
	[FieldOffset(Offset = "0x30")]
	private float m_elaspedTime;

	[Token(Token = "0x4003D56")]
	[FieldOffset(Offset = "0x34")]
	private Action m_nextCallBack;

	[Token(Token = "0x4003D57")]
	[FieldOffset(Offset = "0x38")]
	private bool isEnd;

	[Token(Token = "0x60057CE")]
	[Address(RVA = "0x1B2EBE8", Offset = "0x1B2EBE8", VA = "0x1B2EBE8")]
	public XWidget_TutorialDialog()
	{
	}

	[Token(Token = "0x60057CF")]
	[Address(RVA = "0x1B2EC08", Offset = "0x1B2EC08", VA = "0x1B2EC08")]
	private void SetIllust(UI2DSprite spr, string illustName, bool isActive)
	{
	}

	[Token(Token = "0x60057D0")]
	[Address(RVA = "0x1B2EE54", Offset = "0x1B2EE54", VA = "0x1B2EE54")]
	public void Build(TutorialDialogData script, Action nextCallBack)
	{
	}

	[Token(Token = "0x60057D1")]
	[Address(RVA = "0x1B2F19C", Offset = "0x1B2F19C", VA = "0x1B2F19C")]
	public void Show(TutorialDialogData script, Action nextCallBack)
	{
	}

	[Token(Token = "0x60057D2")]
	[Address(RVA = "0x1B2F224", Offset = "0x1B2F224", VA = "0x1B2F224")]
	public void ResetTextWirte()
	{
	}

	[Token(Token = "0x60057D3")]
	[Address(RVA = "0x1B2F278", Offset = "0x1B2F278", VA = "0x1B2F278")]
	private void Update()
	{
	}

	[Token(Token = "0x60057D4")]
	[Address(RVA = "0x1B2F2DC", Offset = "0x1B2F2DC", VA = "0x1B2F2DC")]
	public void OnTouch_FlowMsg()
	{
	}

	[Token(Token = "0x60057D5")]
	[Address(RVA = "0x1B2F1F0", Offset = "0x1B2F1F0", VA = "0x1B2F1F0")]
	public void Show()
	{
	}

	[Token(Token = "0x60057D6")]
	[Address(RVA = "0x1B2F47C", Offset = "0x1B2F47C", VA = "0x1B2F47C")]
	public void Hide()
	{
	}
}
