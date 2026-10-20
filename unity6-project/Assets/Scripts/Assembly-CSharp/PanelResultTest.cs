using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20010F0")]
[IntegrationTest.SucceedWithAssertions]
public class PanelResultTest : MonoBehaviour
{
	[Token(Token = "0x4005CF4")]
	[FieldOffset(Offset = "0xC")]
	public XPanel_GameResult gameResult;

	[Token(Token = "0x4005CF5")]
	[FieldOffset(Offset = "0x10")]
	public XPlayerManager playerManager;

	[Token(Token = "0x6007F91")]
	[Address(RVA = "0x1B7A808", Offset = "0x1B7A808", VA = "0x1B7A808")]
	public PanelResultTest()
	{
	}

	[Token(Token = "0x6007F92")]
	[Address(RVA = "0x1B7A810", Offset = "0x1B7A810", VA = "0x1B7A810")]
	public void Start()
	{
	}

	[Token(Token = "0x6007F93")]
	[Address(RVA = "0x1B7B044", Offset = "0x1B7B044", VA = "0x1B7B044")]
	private CSContentReward GetReward(CSContentType type, int id, int beforeCount, int actualCount)
	{
		return null;
	}

	[Token(Token = "0x6007F94")]
	[Address(RVA = "0x1B7B15C", Offset = "0x1B7B15C", VA = "0x1B7B15C")]
	private void Update()
	{
	}

	[Token(Token = "0x6007F95")]
	[Address(RVA = "0x1B7AE20", Offset = "0x1B7AE20", VA = "0x1B7AE20")]
	public void ShowResult()
	{
	}
}
