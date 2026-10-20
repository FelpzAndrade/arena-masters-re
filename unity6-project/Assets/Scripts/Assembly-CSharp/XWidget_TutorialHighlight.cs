using System;
using Il2CppDummyDll;

[Token(Token = "0x2000C24")]
public class XWidget_TutorialHighlight : XWidget_TutorialBase
{
	[Token(Token = "0x4003D69")]
	[FieldOffset(Offset = "0x14")]
	public XWidget_Builder arrowBuilder;

	[Token(Token = "0x4003D6A")]
	[FieldOffset(Offset = "0x18")]
	private UIBasicSprite[] arrows;

	[Token(Token = "0x4003D6B")]
	[FieldOffset(Offset = "0x1C")]
	private Action m_nextCallBack;

	[Token(Token = "0x4003D6C")]
	[FieldOffset(Offset = "0x20")]
	private int tutorialPanelDepth;

	[Token(Token = "0x4003D6D")]
	[FieldOffset(Offset = "0x24")]
	private TutorialHighlightData m_highlightData;

	[Token(Token = "0x4003D6E")]
	[FieldOffset(Offset = "0x28")]
	private readonly int RETRY_COUNT;

	[Token(Token = "0x4003D6F")]
	[FieldOffset(Offset = "0x2C")]
	private int retryCnt;

	[Token(Token = "0x4003D70")]
	[FieldOffset(Offset = "0x30")]
	private float elaspedTime;

	[Token(Token = "0x4003D71")]
	[FieldOffset(Offset = "0x34")]
	private bool isEnableClickComponent;

	[Token(Token = "0x60057E7")]
	[Address(RVA = "0x1B306F4", Offset = "0x1B306F4", VA = "0x1B306F4")]
	public XWidget_TutorialHighlight()
	{
	}

	[Token(Token = "0x60057E8")]
	[Address(RVA = "0x1B30710", Offset = "0x1B30710", VA = "0x1B30710")]
	private void Update()
	{
	}

	[Token(Token = "0x60057E9")]
	[Address(RVA = "0x1B30A60", Offset = "0x1B30A60", VA = "0x1B30A60")]
	public void Show(TutorialHighlightData data, Action nextCallBack, bool isEnableClickComp = true)
	{
	}

	[Token(Token = "0x60057EA")]
	[Address(RVA = "0x1B30798", Offset = "0x1B30798", VA = "0x1B30798")]
	private void Build(TutorialHighlightData data)
	{
	}

	[Token(Token = "0x60057EB")]
	[Address(RVA = "0x1B30AD8", Offset = "0x1B30AD8", VA = "0x1B30AD8")]
	private void UpdateArrow(TutorialHighlightData data)
	{
	}

	[Token(Token = "0x60057EC")]
	[Address(RVA = "0x1B30AA4", Offset = "0x1B30AA4", VA = "0x1B30AA4")]
	public void Show()
	{
	}

	[Token(Token = "0x60057ED")]
	[Address(RVA = "0x1B30C78", Offset = "0x1B30C78", VA = "0x1B30C78")]
	public void Hide()
	{
	}
}
