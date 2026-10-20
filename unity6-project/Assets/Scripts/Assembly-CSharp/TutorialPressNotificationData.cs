using Il2CppDummyDll;

[Token(Token = "0x2000691")]
public class TutorialPressNotificationData : TutorialDataBase
{
	[Token(Token = "0x400201A")]
	[FieldOffset(Offset = "0x14")]
	public string gameObjectName;

	[Token(Token = "0x400201B")]
	[FieldOffset(Offset = "0x18")]
	public string strMsg;

	[Token(Token = "0x400201C")]
	[FieldOffset(Offset = "0x1C")]
	public TutoImgLocation imgLocationType;

	[Token(Token = "0x600373A")]
	[Address(RVA = "0x1D5AAF0", Offset = "0x1D5AAF0", VA = "0x1D5AAF0")]
	public TutorialPressNotificationData(int order, string gameObjectName, string strMsg, TutoImgLocation imgLoc)
	{
	}
}
