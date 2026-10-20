using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FEF")]
public class XWidget_StatDetail : XUIBaseWidget
{
	[Token(Token = "0x2000FF0")]
	private sealed class _003CSetTweenScaleFinishLink_003Ec__AnonStorey24C
	{
		[Token(Token = "0x400550C")]
		[FieldOffset(Offset = "0x8")]
		internal Action action;

		[Token(Token = "0x60076D8")]
		[Address(RVA = "0x1B0F92C", Offset = "0x1B0F92C", VA = "0x1B0F92C")]
		public _003CSetTweenScaleFinishLink_003Ec__AnonStorey24C()
		{
		}

		[Token(Token = "0x60076D9")]
		[Address(RVA = "0x1B11990", Offset = "0x1B11990", VA = "0x1B11990")]
		internal void _003C_003Em__4E6()
		{
		}
	}

	[Token(Token = "0x40054FC")]
	[FieldOffset(Offset = "0x1C")]
	public UIPlayTween playTween;

	[Token(Token = "0x40054FD")]
	[FieldOffset(Offset = "0x20")]
	public TweenScale tweenScale;

	[Token(Token = "0x40054FE")]
	[FieldOffset(Offset = "0x24")]
	public XWiget_GridBuilder gridTalentOption;

	[Token(Token = "0x40054FF")]
	[FieldOffset(Offset = "0x28")]
	private XWidget_Selectable_Label[] talentOptions;

	[Token(Token = "0x4005500")]
	[FieldOffset(Offset = "0x2C")]
	private int lastSelectTalentPage;

	[Token(Token = "0x4005501")]
	[FieldOffset(Offset = "0x30")]
	public XWiget_GridBuilder gridAttackStat;

	[Token(Token = "0x4005502")]
	[FieldOffset(Offset = "0x34")]
	public XWiget_GridBuilder gridDefenseStat;

	[Token(Token = "0x4005503")]
	[FieldOffset(Offset = "0x38")]
	public XWiget_GridBuilder gridAssistStat;

	[Token(Token = "0x4005504")]
	[FieldOffset(Offset = "0x3C")]
	public XWiget_GridBuilder gridResistanceStat;

	[Token(Token = "0x4005505")]
	[FieldOffset(Offset = "0x40")]
	public List<string> attackStatNames;

	[Token(Token = "0x4005506")]
	[FieldOffset(Offset = "0x44")]
	public List<string> defenseStatNames;

	[Token(Token = "0x4005507")]
	[FieldOffset(Offset = "0x48")]
	public List<string> assistStatNames;

	[Token(Token = "0x4005508")]
	[FieldOffset(Offset = "0x4C")]
	public List<string> resistanceStatNames;

	[Token(Token = "0x4005509")]
	[FieldOffset(Offset = "0x50")]
	private XModuleActor m_buildChar;

	[Token(Token = "0x400550A")]
	[FieldOffset(Offset = "0x54")]
	public XTutorialObjContainer tutoObjContainer;

	[Token(Token = "0x400550B")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map19;

	[Token(Token = "0x60076CA")]
	[Address(RVA = "0x1B0F414", Offset = "0x1B0F414", VA = "0x1B0F414")]
	public XWidget_StatDetail()
	{
	}

	[Token(Token = "0x60076CB")]
	[Address(RVA = "0x1B0F7FC", Offset = "0x1B0F7FC", VA = "0x1B0F7FC")]
	public void SetTweenScaleFinishLink(Action action)
	{
	}

	[Token(Token = "0x60076CC")]
	[Address(RVA = "0x1B0F934", Offset = "0x1B0F934", VA = "0x1B0F934")]
	public void BuildStat(XModuleActor character)
	{
	}

	[Token(Token = "0x60076CD")]
	[Address(RVA = "0x1B101EC", Offset = "0x1B101EC", VA = "0x1B101EC")]
	private bool GetExceptionValue(XModuleActor character, XCharStatusDisplay statData, string statName, XCharStatusDisplay.StatInfo statInfo, ref string valueStr, ref string statText)
	{
		return default(bool);
	}

	[Token(Token = "0x60076CE")]
	[Address(RVA = "0x1B0FF38", Offset = "0x1B0FF38", VA = "0x1B0FF38")]
	private void BuildStat(XModuleActor character, XCharStatusDisplay statData, XWiget_GridBuilder builder, List<string> buildStatNames)
	{
	}

	[Token(Token = "0x60076CF")]
	[Address(RVA = "0x1B10BB0", Offset = "0x1B10BB0", VA = "0x1B10BB0")]
	private void BuildTalentOption()
	{
	}

	[Token(Token = "0x60076D0")]
	[Address(RVA = "0x1B111E0", Offset = "0x1B111E0", VA = "0x1B111E0")]
	public void Build(XModuleActor character)
	{
	}

	[Token(Token = "0x60076D1")]
	[Address(RVA = "0x1B112B4", Offset = "0x1B112B4", VA = "0x1B112B4")]
	public void Show()
	{
	}

	[Token(Token = "0x60076D2")]
	[Address(RVA = "0x1B11318", Offset = "0x1B11318", VA = "0x1B11318")]
	private void ToggleTalentOption(bool toggle, int page)
	{
	}

	[Token(Token = "0x60076D3")]
	[Address(RVA = "0x1B10F88", Offset = "0x1B10F88", VA = "0x1B10F88")]
	private bool IsExitTalentPage(int pageNumber)
	{
		return default(bool);
	}

	[Token(Token = "0x60076D4")]
	[Address(RVA = "0x1B110A0", Offset = "0x1B110A0", VA = "0x1B110A0")]
	private bool IsLimitedTalentUnlockLv()
	{
		return default(bool);
	}

	[Token(Token = "0x60076D5")]
	[Address(RVA = "0x1B1170C", Offset = "0x1B1170C", VA = "0x1B1170C")]
	private GameObject GetTalentOptionObject(int idx)
	{
		return null;
	}

	[Token(Token = "0x60076D6")]
	[Address(RVA = "0x1B11768", Offset = "0x1B11768", VA = "0x1B11768")]
	private void SetStatDetailTutorialObject()
	{
	}

	[Token(Token = "0x60076D7")]
	[Address(RVA = "0x1B118A8", Offset = "0x1B118A8", VA = "0x1B118A8")]
	private void _003CSetStatDetailTutorialObject_003Em__4E7()
	{
	}
}
