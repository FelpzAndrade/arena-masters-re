using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000FCB")]
public class XWidget_PetStatDetail : XUIBaseWidget
{
	[Token(Token = "0x2000FCC")]
	private sealed class _003CSetTweenScaleFinishLink_003Ec__AnonStorey248
	{
		[Token(Token = "0x400540C")]
		[FieldOffset(Offset = "0x8")]
		internal Action action;

		[Token(Token = "0x60075B8")]
		[Address(RVA = "0x13188E0", Offset = "0x13188E0", VA = "0x13188E0")]
		public _003CSetTweenScaleFinishLink_003Ec__AnonStorey248()
		{
		}

		[Token(Token = "0x60075B9")]
		[Address(RVA = "0x13199B4", Offset = "0x13199B4", VA = "0x13199B4")]
		internal void _003C_003Em__4D9()
		{
		}
	}

	[Token(Token = "0x40053FE")]
	[FieldOffset(Offset = "0x1C")]
	public UIPlayTween playTween;

	[Token(Token = "0x40053FF")]
	[FieldOffset(Offset = "0x20")]
	public TweenScale tweenScale;

	[Token(Token = "0x4005400")]
	[FieldOffset(Offset = "0x24")]
	public XWiget_GridBuilder gridAttackStat;

	[Token(Token = "0x4005401")]
	[FieldOffset(Offset = "0x28")]
	public XWiget_GridBuilder gridDefenseStat;

	[Token(Token = "0x4005402")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblSpecial_exp;

	[Token(Token = "0x4005403")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblSpecial_totalExp;

	[Token(Token = "0x4005404")]
	[FieldOffset(Offset = "0x34")]
	public UILabel lblSpecial_medal;

	[Token(Token = "0x4005405")]
	[FieldOffset(Offset = "0x38")]
	public UILabel lblSpecial_totalMedal;

	[Token(Token = "0x4005406")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel lblSpecial_gold;

	[Token(Token = "0x4005407")]
	[FieldOffset(Offset = "0x40")]
	public UILabel lblSpecial_totalGold;

	[Token(Token = "0x4005408")]
	[FieldOffset(Offset = "0x44")]
	public List<string> attackStatNames;

	[Token(Token = "0x4005409")]
	[FieldOffset(Offset = "0x48")]
	public List<string> defenseStatNames;

	[Token(Token = "0x400540A")]
	[FieldOffset(Offset = "0x4C")]
	private XModuleActor m_buildChar;

	[Token(Token = "0x400540B")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map18;

	[Token(Token = "0x60075B1")]
	[Address(RVA = "0x13184F0", Offset = "0x13184F0", VA = "0x13184F0")]
	public XWidget_PetStatDetail()
	{
	}

	[Token(Token = "0x60075B2")]
	[Address(RVA = "0x13187B0", Offset = "0x13187B0", VA = "0x13187B0")]
	public void SetTweenScaleFinishLink(Action action)
	{
	}

	[Token(Token = "0x60075B3")]
	[Address(RVA = "0x13188E8", Offset = "0x13188E8", VA = "0x13188E8")]
	public void BuildStat(XModuleActor character, List<XModuleActor> petActorList)
	{
	}

	[Token(Token = "0x60075B4")]
	[Address(RVA = "0x13191E0", Offset = "0x13191E0", VA = "0x13191E0")]
	private bool GetExceptionValue(XModuleActor character, XCharStatusDisplay statData, string statName, XCharStatusDisplay.StatInfo statInfo, ref string valueStr, ref string statText)
	{
		return default(bool);
	}

	[Token(Token = "0x60075B5")]
	[Address(RVA = "0x1318F28", Offset = "0x1318F28", VA = "0x1318F28")]
	private void BuildStat(XModuleActor character, XCharStatusDisplay statData, XWiget_GridBuilder builder, List<string> buildStatNames)
	{
	}

	[Token(Token = "0x60075B6")]
	[Address(RVA = "0x1319914", Offset = "0x1319914", VA = "0x1319914")]
	public void Build(XModuleActor character, List<XModuleActor> petActorList)
	{
	}

	[Token(Token = "0x60075B7")]
	[Address(RVA = "0x1319950", Offset = "0x1319950", VA = "0x1319950")]
	public void Show()
	{
	}
}
