using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FAE")]
public class XWidget_MissionStagePointContainer : MonoBehaviour
{
	[Token(Token = "0x4005322")]
	[FieldOffset(Offset = "0xC")]
	public GameObject[] normalStagePoint;

	[Token(Token = "0x4005323")]
	[FieldOffset(Offset = "0x10")]
	public GameObject bossStagePoint;

	[Token(Token = "0x4005324")]
	[FieldOffset(Offset = "0x14")]
	public GameObject bonusStagePoint;

	[Token(Token = "0x4005325")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] paths;

	[Token(Token = "0x60074BE")]
	[Address(RVA = "0x1469200", Offset = "0x1469200", VA = "0x1469200")]
	public XWidget_MissionStagePointContainer()
	{
	}

	[Token(Token = "0x60074BF")]
	[Address(RVA = "0x1469208", Offset = "0x1469208", VA = "0x1469208")]
	public XWidget_MissionElement[] BuildNormalStage(XWidget_Builder builder)
	{
		return null;
	}

	[Token(Token = "0x60074C0")]
	[Address(RVA = "0x14692A8", Offset = "0x14692A8", VA = "0x14692A8")]
	public XWidget_MissionBonusElement[] BuildBonusStage(XWidget_Builder builder)
	{
		return null;
	}

	[Token(Token = "0x60074C1")]
	[Address(RVA = "0x14693C8", Offset = "0x14693C8", VA = "0x14693C8")]
	public XWidget_MissionBossElement[] BuildBossStage(XWidget_Builder builder)
	{
		return null;
	}

	[Token(Token = "0x60074C2")]
	[Address(RVA = "0x14694E8", Offset = "0x14694E8", VA = "0x14694E8")]
	public Dictionary<int, List<XWidget_MissionPathElement>> BuildPath(XWidget_Builder builder)
	{
		return null;
	}
}
