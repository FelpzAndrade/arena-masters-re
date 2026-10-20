using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F75")]
public class XWidget_CombatDifficultyViewer : MonoBehaviour
{
	[Token(Token = "0x40051A0")]
	[FieldOffset(Offset = "0xC")]
	public XWiget_GridBuilder gridCombatDifficultyViewer;

	[Token(Token = "0x40051A1")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblCombatDifficulty;

	[Token(Token = "0x40051A2")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblStageCombatPower;

	[Token(Token = "0x40051A3")]
	[FieldOffset(Offset = "0x18")]
	private int GRID_VIEW_COLOR_NUMBER;

	[Token(Token = "0x6007318")]
	[Address(RVA = "0x15E87F4", Offset = "0x15E87F4", VA = "0x15E87F4")]
	public XWidget_CombatDifficultyViewer()
	{
	}

	[Token(Token = "0x6007319")]
	[Address(RVA = "0x15E8804", Offset = "0x15E8804", VA = "0x15E8804")]
	public void Build(CSStageInfo stageInfo, List<XModuleActor> partyActors)
	{
	}
}
