using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C23")]
public class XWidget_TutorialExplain : XWidget_TutorialBase
{
	[Token(Token = "0x4003D58")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblMsg;

	[Token(Token = "0x4003D59")]
	[FieldOffset(Offset = "0x18")]
	public UIBasicSprite sprExplainBox;

	[Token(Token = "0x4003D5A")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject goExpain;

	[Token(Token = "0x4003D5B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject explainRoot;

	[Token(Token = "0x4003D5C")]
	[FieldOffset(Offset = "0x24")]
	public GameObject widgetRoot;

	[Token(Token = "0x4003D5D")]
	[FieldOffset(Offset = "0x28")]
	public GameObject goBackColider;

	[Token(Token = "0x4003D5E")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject goBackBG;

	[Token(Token = "0x4003D5F")]
	[FieldOffset(Offset = "0x30")]
	public XWidget_NGUITween tweens;

	[Token(Token = "0x4003D60")]
	[FieldOffset(Offset = "0x34")]
	private Action m_nextCallBack;

	[Token(Token = "0x4003D61")]
	[FieldOffset(Offset = "0x38")]
	public XWidget_Builder boxBuilder;

	[Token(Token = "0x4003D62")]
	[FieldOffset(Offset = "0x3C")]
	private TutorialExplainData m_explainData;

	[Token(Token = "0x4003D63")]
	[FieldOffset(Offset = "0x40")]
	private readonly int RETRY_COUNT;

	[Token(Token = "0x4003D64")]
	[FieldOffset(Offset = "0x44")]
	private int retryCnt;

	[Token(Token = "0x4003D65")]
	[FieldOffset(Offset = "0x48")]
	private float m_retryTime;

	[Token(Token = "0x4003D66")]
	[FieldOffset(Offset = "0x4C")]
	public float skipableLimitTime;

	[Token(Token = "0x4003D67")]
	[FieldOffset(Offset = "0x50")]
	private float m_elaspedTime;

	[Token(Token = "0x4003D68")]
	[FieldOffset(Offset = "0x54")]
	private int tutorialPanelDepth;

	[Token(Token = "0x60057D7")]
	[Address(RVA = "0x1B2F4D8", Offset = "0x1B2F4D8", VA = "0x1B2F4D8")]
	public XWidget_TutorialExplain()
	{
	}

	[Token(Token = "0x60057D8")]
	[Address(RVA = "0x1B2F4F4", Offset = "0x1B2F4F4", VA = "0x1B2F4F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60057D9")]
	[Address(RVA = "0x1B2F5E8", Offset = "0x1B2F5E8", VA = "0x1B2F5E8")]
	private void Update()
	{
	}

	[Token(Token = "0x60057DA")]
	[Address(RVA = "0x1B2FA58", Offset = "0x1B2FA58", VA = "0x1B2FA58")]
	public void Show(TutorialExplainData data, Action nextCallBack)
	{
	}

	[Token(Token = "0x60057DB")]
	[Address(RVA = "0x1B2F66C", Offset = "0x1B2F66C", VA = "0x1B2F66C")]
	private void Build(TutorialExplainData data)
	{
	}

	[Token(Token = "0x60057DC")]
	[Address(RVA = "0x1B2FADC", Offset = "0x1B2FADC", VA = "0x1B2FADC")]
	private void SetActiveRoot(bool isActive)
	{
	}

	[Token(Token = "0x60057DD")]
	[Address(RVA = "0x1B2FD38", Offset = "0x1B2FD38", VA = "0x1B2FD38")]
	private void BuildExplainBox(TutorialExplainData data, Transform targetTransform)
	{
	}

	[Token(Token = "0x60057DE")]
	[Address(RVA = "0x1B2FF18", Offset = "0x1B2FF18", VA = "0x1B2FF18")]
	private Vector3 GetExplainBoxRelativePos(UIWidget targetWidget, TutoImgLocation msgLocType)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60057DF")]
	[Address(RVA = "0x1B30168", Offset = "0x1B30168", VA = "0x1B30168")]
	private void SetExplainFlipAndPos(TutoImgLocation msgLocType, bool hasLeft, bool hasRight, bool hasBottom, bool hasTop)
	{
	}

	[Token(Token = "0x60057E0")]
	[Address(RVA = "0x1B2FF04", Offset = "0x1B2FF04", VA = "0x1B2FF04")]
	private bool HasEnum(TutoImgLocation target, TutoImgLocation check)
	{
		return default(bool);
	}

	[Token(Token = "0x60057E1")]
	[Address(RVA = "0x1B2FB20", Offset = "0x1B2FB20", VA = "0x1B2FB20")]
	private void BuildBox(UIWidget boxWodget, Transform posTargetTransform)
	{
	}

	[Token(Token = "0x60057E2")]
	[Address(RVA = "0x1B2FA98", Offset = "0x1B2FA98", VA = "0x1B2FA98")]
	public void Show()
	{
	}

	[Token(Token = "0x60057E3")]
	[Address(RVA = "0x1B30348", Offset = "0x1B30348", VA = "0x1B30348")]
	private void ShowColider(bool show)
	{
	}

	[Token(Token = "0x60057E4")]
	[Address(RVA = "0x1B30398", Offset = "0x1B30398", VA = "0x1B30398")]
	public void Hide()
	{
	}

	[Token(Token = "0x60057E5")]
	[Address(RVA = "0x1B30550", Offset = "0x1B30550", VA = "0x1B30550")]
	public void HideBackColider()
	{
	}

	[Token(Token = "0x60057E6")]
	[Address(RVA = "0x1B30558", Offset = "0x1B30558", VA = "0x1B30558")]
	public void OnTouch()
	{
	}
}
