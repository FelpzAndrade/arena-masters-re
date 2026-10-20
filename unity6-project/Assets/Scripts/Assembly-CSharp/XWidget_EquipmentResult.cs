using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EC9")]
public class XWidget_EquipmentResult : XWidget_ItemDetail
{
	[Token(Token = "0x2000ECA")]
	public enum ResultType
	{
		[Token(Token = "0x4004DC3")]
		None = 0,
		[Token(Token = "0x4004DC4")]
		Refine = 1,
		[Token(Token = "0x4004DC5")]
		Promotion = 2,
		[Token(Token = "0x4004DC6")]
		Fusion = 3,
		[Token(Token = "0x4004DC7")]
		Transcend = 4
	}

	[Token(Token = "0x4004DB5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public UITable tableStatRoot;

	[Token(Token = "0x4004DB6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public UILabel lblTitle;

	[Token(Token = "0x4004DB7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public TweenAlpha m_tweenEquipmentResultOpenAlpha;

	[Token(Token = "0x4004DB8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public TweenAlpha m_tweenEquipmentResultCloseAlpha;

	[Token(Token = "0x4004DB9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public TweenScale m_tweenEquipmentResultOpenScale;

	[Token(Token = "0x4004DBA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public TweenScale m_tweenEquipmentResultCloseScale;

	[Token(Token = "0x4004DBB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public XWidget_Button btnConfirm;

	[Token(Token = "0x4004DBC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Action m_onConfirm;

	[Token(Token = "0x4004DBD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private ResultType m_resultType;

	[Token(Token = "0x4004DBE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public GameObject tweenPaenl;

	[Token(Token = "0x4004DBF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public XWidget_Builder builderMajorStat;

	[Token(Token = "0x4004DC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public UIBasicSprite sprBG;

	[Token(Token = "0x4004DC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private int m_beforeItemRandomOptionCount;

	[Token(Token = "0x6006E2B")]
	[Address(RVA = "0x15F69F0", Offset = "0x15F69F0", VA = "0x15F69F0")]
	public XWidget_EquipmentResult()
	{
	}

	[Token(Token = "0x6006E2C")]
	[Address(RVA = "0x15F69F8", Offset = "0x15F69F8", VA = "0x15F69F8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006E2D")]
	[Address(RVA = "0x15F6B4C", Offset = "0x15F6B4C", VA = "0x15F6B4C")]
	private void TweenReset()
	{
	}

	[Token(Token = "0x6006E2E")]
	[Address(RVA = "0x15F6C3C", Offset = "0x15F6C3C", VA = "0x15F6C3C")]
	public void Build(XItem item, InventoryModeType invenMode, [Optional][DefaultParameterValue(0)] int beforeItemRandomOptionCount, [Optional] Action onConfirm)
	{
	}

	[Token(Token = "0x6006E2F")]
	[Address(RVA = "0x15F6DC8", Offset = "0x15F6DC8", VA = "0x15F6DC8")]
	private void BuildTitle()
	{
	}

	[Token(Token = "0x6006E30")]
	[Address(RVA = "0x15F6FC0", Offset = "0x15F6FC0", VA = "0x15F6FC0", Slot = "21")]
	protected override void BuildStat(XItem item)
	{
	}

	[Token(Token = "0x6006E31")]
	[Address(RVA = "0x15F746C", Offset = "0x15F746C", VA = "0x15F746C")]
	private void BuildStatLabel(XCharStatusDisplay.StatInfo statInfo, XWidget_LabelTriple statLabel)
	{
	}

	[Token(Token = "0x6006E32")]
	[Address(RVA = "0x15F6F6C", Offset = "0x15F6F6C", VA = "0x15F6F6C")]
	private void BuildPosAndActive()
	{
	}

	[Token(Token = "0x6006E33")]
	[Address(RVA = "0x15F74E8", Offset = "0x15F74E8", VA = "0x15F74E8", Slot = "22")]
	protected override void BuildRandomOptionStat(XItem item, XWiget_GridBuilder randoptionBuilder)
	{
	}

	[Token(Token = "0x6006E34")]
	[Address(RVA = "0x15F793C", Offset = "0x15F793C", VA = "0x15F793C")]
	private void PlayTweenAlpha(GameObject go, bool isPlay)
	{
	}

	[Token(Token = "0x6006E35")]
	[Address(RVA = "0x15F6D98", Offset = "0x15F6D98", VA = "0x15F6D98")]
	private ResultType GetResultType(InventoryModeType invenMode)
	{
		return default(ResultType);
	}

	[Token(Token = "0x6006E36")]
	[Address(RVA = "0x15F7B14", Offset = "0x15F7B14", VA = "0x15F7B14")]
	public void EndCloseTween()
	{
	}

	[Token(Token = "0x6006E37")]
	[Address(RVA = "0x15F7B44", Offset = "0x15F7B44", VA = "0x15F7B44")]
	public void OnClick_Confirm()
	{
	}
}
