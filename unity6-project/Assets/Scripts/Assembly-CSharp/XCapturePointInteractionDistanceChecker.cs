using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000507")]
public class XCapturePointInteractionDistanceChecker
{
	[Token(Token = "0x4001998")]
	private const float INTERACTION_CHECK_TICK = 0.5f;

	[Token(Token = "0x4001999")]
	private const float INTERACTION_DISTANCE_TOLER = 5f;

	[Token(Token = "0x400199A")]
	[FieldOffset(Offset = "0x8")]
	private float m_fInteractionCheckElapsedTime;

	[Token(Token = "0x6002B59")]
	[Address(RVA = "0x1AA49BC", Offset = "0x1AA49BC", VA = "0x1AA49BC")]
	public XCapturePointInteractionDistanceChecker()
	{
	}

	[Token(Token = "0x6002B5A")]
	[Address(RVA = "0x1AA59DC", Offset = "0x1AA59DC", VA = "0x1AA59DC")]
	public void UpdateCheck(float fDeltaTime, List<int> interactingPlayerList, int nSpawnID)
	{
	}
}
