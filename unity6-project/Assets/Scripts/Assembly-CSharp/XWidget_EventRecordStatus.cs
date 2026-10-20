using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EB5")]
public class XWidget_EventRecordStatus : MonoBehaviour
{
	[Token(Token = "0x4004D4E")]
	[FieldOffset(Offset = "0xC")]
	public GameObject goWin;

	[Token(Token = "0x4004D4F")]
	[FieldOffset(Offset = "0x10")]
	public bool showRank;

	[Token(Token = "0x4004D50")]
	[FieldOffset(Offset = "0x14")]
	public GameObject goRank;

	[Token(Token = "0x4004D51")]
	[FieldOffset(Offset = "0x18")]
	public UILabel lblRankCondition;

	[Token(Token = "0x4004D52")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblRankCount;

	[Token(Token = "0x4004D53")]
	[FieldOffset(Offset = "0x20")]
	public GameObject goEnter;

	[Token(Token = "0x4004D54")]
	[FieldOffset(Offset = "0x24")]
	public GameObject goFail;

	[Token(Token = "0x4004D55")]
	[FieldOffset(Offset = "0x28")]
	public GameObject sprBar;

	[Token(Token = "0x4004D56")]
	[FieldOffset(Offset = "0x2C")]
	public bool showMaxWin;

	[Token(Token = "0x4004D57")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblWinCount;

	[Token(Token = "0x4004D58")]
	[FieldOffset(Offset = "0x34")]
	public bool useFailImage;

	[Token(Token = "0x4004D59")]
	[FieldOffset(Offset = "0x38")]
	public UILabel lblFailCount;

	[Token(Token = "0x4004D5A")]
	[FieldOffset(Offset = "0x3C")]
	public XWidget_Builder failIconBuilder;

	[Token(Token = "0x4004D5B")]
	[FieldOffset(Offset = "0x40")]
	public XWidget_Builder failbgBuilder;

	[Token(Token = "0x4004D5C")]
	[FieldOffset(Offset = "0x44")]
	public UILabel lblEnterCount;

	[Token(Token = "0x6006DA1")]
	[Address(RVA = "0x1429B5C", Offset = "0x1429B5C", VA = "0x1429B5C")]
	public XWidget_EventRecordStatus()
	{
	}

	[Token(Token = "0x6006DA2")]
	[Address(RVA = "0x1429B6C", Offset = "0x1429B6C", VA = "0x1429B6C")]
	public void Build(EventGameModeInfo eventModeInfo, EventGameModeClearRecord record)
	{
	}
}
