using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D44")]
public class XWidget_ResultCharLevel : MonoBehaviour
{
	[Token(Token = "0x400443D")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprChar;

	[Token(Token = "0x400443E")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblCharQuestName;

	[Token(Token = "0x400443F")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblCharQuestProgress;

	[Token(Token = "0x4004440")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_ProgressBarWithTable prbQuestPoint;

	[Token(Token = "0x4004441")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel lblQuestPoint;

	[Token(Token = "0x4004442")]
	[FieldOffset(Offset = "0x20")]
	private CSCharacterInfo m_charInfo;

	[Token(Token = "0x17000D27")]
	public CSCharacterInfo CharInfo
	{
		[Token(Token = "0x6006180")]
		[Address(RVA = "0x13430DC", Offset = "0x13430DC", VA = "0x13430DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600617F")]
	[Address(RVA = "0x13430D4", Offset = "0x13430D4", VA = "0x13430D4")]
	public XWidget_ResultCharLevel()
	{
	}

	[Token(Token = "0x6006181")]
	[Address(RVA = "0x13430E4", Offset = "0x13430E4", VA = "0x13430E4")]
	public void Build(XModuleActor character, QuestInfo questInfo)
	{
	}

	[Token(Token = "0x6006182")]
	[Address(RVA = "0x1343370", Offset = "0x1343370", VA = "0x1343370")]
	public void CharBuildQuestProgress(QuestInfo questInfo)
	{
	}
}
