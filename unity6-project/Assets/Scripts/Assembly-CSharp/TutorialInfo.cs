using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000688")]
public class TutorialInfo
{
	[Token(Token = "0x4001FE8")]
	[FieldOffset(Offset = "0x8")]
	public int groupID;

	[Token(Token = "0x4001FE9")]
	[FieldOffset(Offset = "0xC")]
	public int tutorialID;

	[Token(Token = "0x4001FEA")]
	[FieldOffset(Offset = "0x10")]
	public int order;

	[Token(Token = "0x4001FEB")]
	[FieldOffset(Offset = "0x14")]
	public TutorialScriptType scriptType;

	[Token(Token = "0x4001FEC")]
	[FieldOffset(Offset = "0x18")]
	public string strMsg;

	[Token(Token = "0x4001FED")]
	[FieldOffset(Offset = "0x1C")]
	public string strLeftIllust;

	[Token(Token = "0x4001FEE")]
	[FieldOffset(Offset = "0x20")]
	public string strLeftIllustActive;

	[Token(Token = "0x4001FEF")]
	[FieldOffset(Offset = "0x24")]
	public string strRightIllust;

	[Token(Token = "0x4001FF0")]
	[FieldOffset(Offset = "0x28")]
	public string strRightIllustActive;

	[Token(Token = "0x4001FF1")]
	[FieldOffset(Offset = "0x2C")]
	public string strName;

	[Token(Token = "0x4001FF2")]
	[FieldOffset(Offset = "0x30")]
	public string strDescA;

	[Token(Token = "0x4001FF3")]
	[FieldOffset(Offset = "0x34")]
	public string strDescB;

	[Token(Token = "0x4001FF4")]
	[FieldOffset(Offset = "0x38")]
	public TutoImgLocation imgLocationType;

	[Token(Token = "0x4001FF5")]
	[FieldOffset(Offset = "0x3C")]
	public string gameObjectName;

	[Token(Token = "0x4001FF6")]
	[FieldOffset(Offset = "0x40")]
	public string startScene;

	[Token(Token = "0x4001FF7")]
	[FieldOffset(Offset = "0x44")]
	public string strFinishGroup;

	[Token(Token = "0x4001FF8")]
	[FieldOffset(Offset = "0x48")]
	public string strExplainLocation;

	[Token(Token = "0x4001FF9")]
	[FieldOffset(Offset = "0x4C")]
	public string strVoice;

	[Token(Token = "0x4001FFA")]
	[FieldOffset(Offset = "0x50")]
	public int arrowLimitCount;

	[Token(Token = "0x4001FFB")]
	[FieldOffset(Offset = "0x54")]
	public string strBgPath;

	[Token(Token = "0x4001FFC")]
	[FieldOffset(Offset = "0x58")]
	public string strLevelDataName;

	[Token(Token = "0x4001FFD")]
	[FieldOffset(Offset = "0x5C")]
	public int rewardCount;

	[Token(Token = "0x4001FFE")]
	[FieldOffset(Offset = "0x60")]
	public string targetIDs;

	[Token(Token = "0x4001FFF")]
	[FieldOffset(Offset = "0x64")]
	public TutoImgLocation explainLocType;

	[Token(Token = "0x6003717")]
	[Address(RVA = "0x1D5BDC8", Offset = "0x1D5BDC8", VA = "0x1D5BDC8")]
	public TutorialInfo()
	{
	}
}
