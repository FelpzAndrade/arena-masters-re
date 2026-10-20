using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20010D5")]
[IntegrationTest.SucceedWithAssertions]
public class BehavierTreeTest : MonoBehaviour
{
	[Token(Token = "0x4005CB8")]
	[FieldOffset(Offset = "0xC")]
	public int playerId;

	[Token(Token = "0x4005CB9")]
	[FieldOffset(Offset = "0x10")]
	public int monsterId;

	[Token(Token = "0x4005CBA")]
	[FieldOffset(Offset = "0x14")]
	public XModuleActor monster;

	[Token(Token = "0x4005CBB")]
	[FieldOffset(Offset = "0x18")]
	public XModuleActor attacker;

	[Token(Token = "0x4005CBC")]
	[FieldOffset(Offset = "0x1C")]
	public XModuleAttackInfo attack;

	[Token(Token = "0x4005CBD")]
	[FieldOffset(Offset = "0x20")]
	public string clipQ;

	[Token(Token = "0x4005CBE")]
	[FieldOffset(Offset = "0x24")]
	public string clipW;

	[Token(Token = "0x4005CBF")]
	[FieldOffset(Offset = "0x28")]
	public string clipE;

	[Token(Token = "0x4005CC0")]
	[FieldOffset(Offset = "0x2C")]
	public float beatenDuration;

	[Token(Token = "0x4005CC1")]
	[FieldOffset(Offset = "0x30")]
	public float beatenDistance;

	[Token(Token = "0x4005CC2")]
	[FieldOffset(Offset = "0x34")]
	public float crossfadeLength;

	[Token(Token = "0x6007F1B")]
	[Address(RVA = "0x20BF3C4", Offset = "0x20BF3C4", VA = "0x20BF3C4")]
	public BehavierTreeTest()
	{
	}

	[Token(Token = "0x6007F1C")]
	[Address(RVA = "0x20BF4A8", Offset = "0x20BF4A8", VA = "0x20BF4A8")]
	public void Awake()
	{
	}

	[Token(Token = "0x6007F1D")]
	[Address(RVA = "0x20BF664", Offset = "0x20BF664", VA = "0x20BF664")]
	public void Start()
	{
	}

	[Token(Token = "0x6007F1E")]
	[Address(RVA = "0x20BFE24", Offset = "0x20BFE24", VA = "0x20BFE24")]
	private void Update()
	{
	}
}
