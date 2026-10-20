using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000FAA")]
public class XWidget_MissionBossElement : XWidget_MissionElement
{
	[Token(Token = "0x40052F2")]
	[FieldOffset(Offset = "0x40")]
	public UI2DSpriteAnimation bossAnim;

	[Token(Token = "0x40052F3")]
	[FieldOffset(Offset = "0x44")]
	private string spritePath;

	[Token(Token = "0x60074A1")]
	[Address(RVA = "0x146636C", Offset = "0x146636C", VA = "0x146636C")]
	public XWidget_MissionBossElement()
	{
	}

	[Token(Token = "0x60074A2")]
	[Address(RVA = "0x1466410", Offset = "0x1466410", VA = "0x1466410", Slot = "4")]
	public override void Show(CSStageInfo stageInfo, int bestScore, bool enterable, List<XWidget_MissionPathElement> pathList)
	{
	}
}
