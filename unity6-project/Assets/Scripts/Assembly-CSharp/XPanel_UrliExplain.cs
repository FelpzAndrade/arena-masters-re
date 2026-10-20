using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C55")]
public class XPanel_UrliExplain : MonoBehaviour
{
	[Token(Token = "0x4003E73")]
	[FieldOffset(Offset = "0xC")]
	public bool isOverlay;

	[Token(Token = "0x4003E74")]
	[FieldOffset(Offset = "0x10")]
	public GameObject buttonNext;

	[Token(Token = "0x4003E75")]
	[FieldOffset(Offset = "0x14")]
	public GameObject buttonPrevidous;

	[Token(Token = "0x4003E76")]
	[FieldOffset(Offset = "0x18")]
	public GameObject buttonDone;

	[Token(Token = "0x4003E77")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel label;

	[Token(Token = "0x4003E78")]
	[FieldOffset(Offset = "0x20")]
	private float printSpeed;

	[Token(Token = "0x4003E79")]
	[FieldOffset(Offset = "0x24")]
	private string printString;

	[Token(Token = "0x4003E7A")]
	[FieldOffset(Offset = "0x28")]
	private char[] prtinStringArray;

	[Token(Token = "0x4003E7B")]
	[FieldOffset(Offset = "0x2C")]
	private float deltaTime;

	[Token(Token = "0x4003E7C")]
	[FieldOffset(Offset = "0x30")]
	private float limitTime;

	[Token(Token = "0x4003E7D")]
	[FieldOffset(Offset = "0x34")]
	private int stringIndex;

	[Token(Token = "0x4003E7E")]
	[FieldOffset(Offset = "0x38")]
	private string tempString;

	[Token(Token = "0x4003E7F")]
	[FieldOffset(Offset = "0x3C")]
	private bool isStartPrint;

	[Token(Token = "0x4003E80")]
	[FieldOffset(Offset = "0x40")]
	private int urlypageCount;

	[Token(Token = "0x6005931")]
	[Address(RVA = "0xAD9554", Offset = "0xAD9554", VA = "0xAD9554")]
	public XPanel_UrliExplain()
	{
	}

	[Token(Token = "0x6005932")]
	[Address(RVA = "0xAD9630", Offset = "0xAD9630", VA = "0xAD9630")]
	public void Build(int pageCount)
	{
	}

	[Token(Token = "0x6005933")]
	[Address(RVA = "0xAD97F0", Offset = "0xAD97F0", VA = "0xAD97F0")]
	public void StartUrlyPage()
	{
	}

	[Token(Token = "0x6005934")]
	[Address(RVA = "0xAD99D8", Offset = "0xAD99D8", VA = "0xAD99D8")]
	public void Close()
	{
	}

	[Token(Token = "0x6005935")]
	[Address(RVA = "0xAD9ADC", Offset = "0xAD9ADC", VA = "0xAD9ADC")]
	private void Update()
	{
	}
}
