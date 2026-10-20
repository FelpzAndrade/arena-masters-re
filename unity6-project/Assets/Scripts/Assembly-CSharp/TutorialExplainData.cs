using Il2CppDummyDll;

[Token(Token = "0x200068D")]
public class TutorialExplainData : TutorialDataBase
{
	[Token(Token = "0x400200F")]
	[FieldOffset(Offset = "0x14")]
	public string gameObjectName;

	[Token(Token = "0x4002010")]
	[FieldOffset(Offset = "0x18")]
	public string strMsg;

	[Token(Token = "0x4002011")]
	[FieldOffset(Offset = "0x1C")]
	public TutoImgLocation msgLocationType;

	[Token(Token = "0x4002012")]
	[FieldOffset(Offset = "0x20")]
	public TutoImgLocation indicatorLocType;

	[Token(Token = "0x6003734")]
	[Address(RVA = "0x1D5960C", Offset = "0x1D5960C", VA = "0x1D5960C")]
	public TutorialExplainData()
	{
	}

	[Token(Token = "0x6003735")]
	[Address(RVA = "0x1D596D0", Offset = "0x1D596D0", VA = "0x1D596D0")]
	public TutorialExplainData(int order, string gameObjectName, string strMsg, TutoImgLocation arrowImgLoc, TutoImgLocation explainLoc)
	{
	}
}
