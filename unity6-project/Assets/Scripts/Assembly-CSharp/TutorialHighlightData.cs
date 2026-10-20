using Il2CppDummyDll;

[Token(Token = "0x200068F")]
public class TutorialHighlightData : TutorialDataBase
{
		protected TutorialHighlightData()
		{
		}

	[Token(Token = "0x4002013")]
	[FieldOffset(Offset = "0x14")]
	public string gameObjectName;

	[Token(Token = "0x4002014")]
	[FieldOffset(Offset = "0x18")]
	public string strMsg;

	[Token(Token = "0x4002015")]
	[FieldOffset(Offset = "0x1C")]
	public TutoImgLocation imgLocationType;

	[Token(Token = "0x4002016")]
	[FieldOffset(Offset = "0x20")]
	public int arrowLimitCount;

	[Token(Token = "0x6003737")]
	[Address(RVA = "0x1D5BCC4", Offset = "0x1D5BCC4", VA = "0x1D5BCC4")]
	public TutorialHighlightData(TutorialScriptType type, int order, string gameObjectName, string strMsg, TutoImgLocation imgLoc, int arrowLimitCount)
	{
	}

	[Token(Token = "0x6003738")]
	[Address(RVA = "0x1D5A938", Offset = "0x1D5A938", VA = "0x1D5A938")]
	public TutorialHighlightData(int order, string gameObjectName, string strMsg, TutoImgLocation imgLoc, int arrowLimitCount)
	{
	}
}
