using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EE0")]
public class XWidget_OptionStatSwitch : MonoBehaviour
{
	[Token(Token = "0x4004EB1")]
	[FieldOffset(Offset = "0xC")]
	public UILabel lblBefore;

	[Token(Token = "0x4004EB2")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblAfter;

	[Token(Token = "0x4004EB3")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string PATH;

	[Token(Token = "0x4004EB4")]
	[FieldOffset(Offset = "0x14")]
	public XWiget_GridBuilder changeOptionBuilder;

	[Token(Token = "0x4004EB5")]
	[FieldOffset(Offset = "0x18")]
	public bool IsShowArrow;

	[Token(Token = "0x6006EFF")]
	[Address(RVA = "0x130F570", Offset = "0x130F570", VA = "0x130F570")]
	public XWidget_OptionStatSwitch()
	{
	}

	[Token(Token = "0x6006F01")]
	[Address(RVA = "0x1307DA0", Offset = "0x1307DA0", VA = "0x1307DA0")]
	public void BuildChangeCompleteStat(XItem item, int changeIndex, List<int> prevOptionIDs, List<int> changeOptionIDs)
	{
	}

	[Token(Token = "0x6006F02")]
	[Address(RVA = "0x130FD34", Offset = "0x130FD34", VA = "0x130FD34")]
	public void BuildExistBetterStat(XItem item, int current, Dictionary<int, bool> betterIDs)
	{
	}

	[Token(Token = "0x6006F03")]
	[Address(RVA = "0x130777C", Offset = "0x130777C", VA = "0x130777C")]
	public void BuildChangeSelectCheckStat(XItem item, int prevID, int changeID)
	{
	}

	[Token(Token = "0x6006F04")]
	[Address(RVA = "0x130F610", Offset = "0x130F610", VA = "0x130F610")]
	private void BuildChangeRandomOptionStat(XItem item, List<int> prevOptionIDs, List<int> changeOptionIDs, List<int> gradationIndexs, Dictionary<int, bool> betterIDs, bool isOnlyAfterGradation = true)
	{
	}

	[Token(Token = "0x6006F05")]
	[Address(RVA = "0x1310168", Offset = "0x1310168", VA = "0x1310168")]
	private string GetStateLocalizeName(XCharStatusDisplay.StatInfo stat)
	{
		return null;
	}
}
