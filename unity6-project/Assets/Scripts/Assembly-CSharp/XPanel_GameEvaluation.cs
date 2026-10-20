using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DEB")]
public class XPanel_GameEvaluation : XUIButtons, IUIBackbutton, IBackbutton
{
	[Token(Token = "0x4004894")]
	[FieldOffset(Offset = "0x30")]
	public UI2DSprite sprNPCIllust;

	[Token(Token = "0x4004895")]
	[FieldOffset(Offset = "0x34")]
	public UILabel lblMsg;

	[Token(Token = "0x4004896")]
	[FieldOffset(Offset = "0x38")]
	private Action m_nextQueue;

	[Token(Token = "0x4004897")]
	[FieldOffset(Offset = "0x3C")]
	public string firstNPCPath;

	[Token(Token = "0x4004898")]
	[FieldOffset(Offset = "0x40")]
	public string firstMsgLocaleKey;

	[Token(Token = "0x4004899")]
	[FieldOffset(Offset = "0x44")]
	public GameObject goFirst;

	[Token(Token = "0x400489A")]
	[FieldOffset(Offset = "0x48")]
	public string endNPCPath;

	[Token(Token = "0x400489B")]
	[FieldOffset(Offset = "0x4C")]
	public string endMsgLocaleKey;

	[Token(Token = "0x400489C")]
	[FieldOffset(Offset = "0x50")]
	public GameObject goEnd;

	[Token(Token = "0x400489D")]
	[FieldOffset(Offset = "0x54")]
	public string EvaluateNPCPath;

	[Token(Token = "0x400489E")]
	[FieldOffset(Offset = "0x58")]
	public string EvaluateMsgLocaleKey;

	[Token(Token = "0x400489F")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject goEvaluate;

	[Token(Token = "0x60066B2")]
	[Address(RVA = "0xFD8848", Offset = "0xFD8848", VA = "0xFD8848")]
	public XPanel_GameEvaluation()
	{
	}

	[Token(Token = "0x60066B3")]
	[Address(RVA = "0xFD8850", Offset = "0xFD8850", VA = "0xFD8850")]
	public void Awake()
	{
	}

	[Token(Token = "0x60066B4")]
	[Address(RVA = "0xFD8884", Offset = "0xFD8884", VA = "0xFD8884")]
	private void SetEmphasis()
	{
	}

	[Token(Token = "0x60066B5")]
	[Address(RVA = "0xFD8898", Offset = "0xFD8898", VA = "0xFD8898")]
	private void ShowContent(bool first, bool servey, bool evauate)
	{
	}

	[Token(Token = "0x60066B6")]
	[Address(RVA = "0xFD8A50", Offset = "0xFD8A50", VA = "0xFD8A50")]
	public void Show(Action nextQueue)
	{
	}

	[Token(Token = "0x60066B7")]
	[Address(RVA = "0xFD8BCC", Offset = "0xFD8BCC", VA = "0xFD8BCC")]
	private void BuildFirst()
	{
	}

	[Token(Token = "0x60066B8")]
	[Address(RVA = "0xFD8FA4", Offset = "0xFD8FA4", VA = "0xFD8FA4")]
	private void BuildEnd()
	{
	}

	[Token(Token = "0x60066B9")]
	[Address(RVA = "0xFD90E8", Offset = "0xFD90E8", VA = "0xFD90E8")]
	private void BuildEvaluate()
	{
	}

	[Token(Token = "0x60066BA")]
	[Address(RVA = "0xFD8D28", Offset = "0xFD8D28", VA = "0xFD8D28")]
	private void ShowObject()
	{
	}

	[Token(Token = "0x60066BB")]
	[Address(RVA = "0xFD8D5C", Offset = "0xFD8D5C", VA = "0xFD8D5C")]
	private void BuildNPCIllust(string path)
	{
	}

	[Token(Token = "0x60066BC")]
	[Address(RVA = "0xFD8EA8", Offset = "0xFD8EA8", VA = "0xFD8EA8")]
	private void SetButtons(XMessageBoxButtons btn, Action OK, Action Cancel)
	{
	}

	[Token(Token = "0x60066BD")]
	[Address(RVA = "0xFD9244", Offset = "0xFD9244", VA = "0xFD9244")]
	public void OnClick_GoEnd()
	{
	}

	[Token(Token = "0x60066BE")]
	[Address(RVA = "0xFD9248", Offset = "0xFD9248", VA = "0xFD9248")]
	public void OnClick_GoEvalueate()
	{
	}

	[Token(Token = "0x60066BF")]
	[Address(RVA = "0xFD924C", Offset = "0xFD924C", VA = "0xFD924C")]
	public void OnClick_Evaluate()
	{
	}

	[Token(Token = "0x60066C0")]
	[Address(RVA = "0xFD9470", Offset = "0xFD9470", VA = "0xFD9470", Slot = "19")]
	public new bool IsActive()
	{
		return default(bool);
	}

	[Token(Token = "0x60066C1")]
	[Address(RVA = "0xFD9308", Offset = "0xFD9308", VA = "0xFD9308", Slot = "20")]
	public void OnHide()
	{
	}

	[Token(Token = "0x60066C2")]
	[Address(RVA = "0xFD94A0", Offset = "0xFD94A0", VA = "0xFD94A0")]
	private void CallNextQueue()
	{
	}
}
