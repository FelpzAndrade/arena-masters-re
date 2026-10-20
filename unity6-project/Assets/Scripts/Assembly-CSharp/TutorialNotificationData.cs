using Il2CppDummyDll;

[Token(Token = "0x2000690")]
public class TutorialNotificationData : TutorialDataBase
{
	[Token(Token = "0x4002017")]
	[FieldOffset(Offset = "0x14")]
	public string gameObjectName;

	[Token(Token = "0x4002018")]
	[FieldOffset(Offset = "0x18")]
	public string strMsg;

	[Token(Token = "0x4002019")]
	[FieldOffset(Offset = "0x1C")]
	public TutoImgLocation imgLocationType;

	[Token(Token = "0x6003739")]
	[Address(RVA = "0x1D5ABE4", Offset = "0x1D5ABE4", VA = "0x1D5ABE4")]
	public TutorialNotificationData(int order, string gameObjectName, string strMsg, TutoImgLocation imgLoc)
	{
	}
}
