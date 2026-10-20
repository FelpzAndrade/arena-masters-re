using Il2CppDummyDll;

[Token(Token = "0x2000694")]
public class TutorialDialogData : TutorialDataBase
{
		protected TutorialDialogData()
		{
		}

	[Token(Token = "0x400201E")]
	[FieldOffset(Offset = "0x14")]
	public string strLeftIllust;

	[Token(Token = "0x400201F")]
	[FieldOffset(Offset = "0x18")]
	public string strRightIllust;

	[Token(Token = "0x4002020")]
	[FieldOffset(Offset = "0x1C")]
	public bool isLeftActive;

	[Token(Token = "0x4002021")]
	[FieldOffset(Offset = "0x1D")]
	public bool isRightActive;

	[Token(Token = "0x4002022")]
	[FieldOffset(Offset = "0x20")]
	public string Name;

	[Token(Token = "0x4002023")]
	[FieldOffset(Offset = "0x24")]
	public string DescA;

	[Token(Token = "0x4002024")]
	[FieldOffset(Offset = "0x28")]
	public string DescB;

	[Token(Token = "0x4002025")]
	[FieldOffset(Offset = "0x2C")]
	public string message;

	[Token(Token = "0x4002026")]
	[FieldOffset(Offset = "0x30")]
	public string soundName;

	[Token(Token = "0x4002027")]
	[FieldOffset(Offset = "0x34")]
	public TutoImgLocation imgLocationType;

	[Token(Token = "0x600373D")]
	[Address(RVA = "0x1D59000", Offset = "0x1D59000", VA = "0x1D59000")]
	public TutorialDialogData(TutorialScriptType scriptType, int order, string strLeftIllust, string strRightIllust, string strLeftIllustActive, string strRightIllustActive, string strName, string strDescA, string strDescB, string msg, TutoImgLocation imgLoc, string soundName)
	{
	}

	[Token(Token = "0x600373E")]
	[Address(RVA = "0x1D5930C", Offset = "0x1D5930C", VA = "0x1D5930C")]
	public TutorialDialogData(int order, string strLeftIllust, string strRightIllust, string strLeftIllustActive, string strRightIllustActive, string strName, string strDescA, string strDescB, string msg, TutoImgLocation imgLoc, string soundName)
	{
	}
}
