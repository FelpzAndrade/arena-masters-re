using Il2CppDummyDll;
using UnityEngine;
using XLevel;

[Token(Token = "0x20010D8")]
[IntegrationTest.SucceedWithAssertions]
public class TestWayPoints : MonoBehaviour
{
	[Token(Token = "0x4005CC3")]
	[FieldOffset(Offset = "0xC")]
	public Transform position1;

	[Token(Token = "0x4005CC4")]
	[FieldOffset(Offset = "0x10")]
	public XWayPoints wayPoints;

	[Token(Token = "0x4005CC5")]
	[FieldOffset(Offset = "0x14")]
	public Vector3? result;

	[Token(Token = "0x4005CC6")]
	[FieldOffset(Offset = "0x24")]
	private XWayPointCalculator calculator;

	[Token(Token = "0x6007F25")]
	[Address(RVA = "0x1D4D050", Offset = "0x1D4D050", VA = "0x1D4D050")]
	public TestWayPoints()
	{
	}

	[Token(Token = "0x6007F26")]
	[Address(RVA = "0x1D4D058", Offset = "0x1D4D058", VA = "0x1D4D058")]
	public void Awake()
	{
	}

	[Token(Token = "0x6007F27")]
	[Address(RVA = "0x1D4D05C", Offset = "0x1D4D05C", VA = "0x1D4D05C")]
	public void Start()
	{
	}

	[Token(Token = "0x6007F28")]
	[Address(RVA = "0x1D4D138", Offset = "0x1D4D138", VA = "0x1D4D138")]
	private void Update()
	{
	}

	[Token(Token = "0x6007F29")]
	[Address(RVA = "0x1D4D36C", Offset = "0x1D4D36C", VA = "0x1D4D36C")]
	private void OnDrawGizmos()
	{
	}
}
