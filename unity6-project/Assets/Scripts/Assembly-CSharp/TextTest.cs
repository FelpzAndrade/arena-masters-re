using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200009A")]
public class TextTest : MonoBehaviour
{
	[Token(Token = "0x4000288")]
	[FieldOffset(Offset = "0xC")]
	public GameObject TextObject;

	[Token(Token = "0x4000289")]
	[FieldOffset(Offset = "0x10")]
	private TextMesh _statusText;

	[Token(Token = "0x400028A")]
	[FieldOffset(Offset = "0x18")]
	private DateTime _refTime;

	[Token(Token = "0x400028B")]
	[FieldOffset(Offset = "0x28")]
	private int _testNum;

	[Token(Token = "0x400028C")]
	[FieldOffset(Offset = "0x2C")]
	private JsonTestScript _tester;

	[Token(Token = "0x400028D")]
	[FieldOffset(Offset = "0x30")]
	private bool _complete;

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x1D4D548", Offset = "0x1D4D548", VA = "0x1D4D548")]
	public TextTest()
	{
	}

	[Token(Token = "0x60004EF")]
	[Address(RVA = "0x1D4D558", Offset = "0x1D4D558", VA = "0x1D4D558")]
	private void Start()
	{
	}

	[Token(Token = "0x60004F0")]
	[Address(RVA = "0x1D4D6DC", Offset = "0x1D4D6DC", VA = "0x1D4D6DC")]
	private void Update()
	{
	}

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x1D4D878", Offset = "0x1D4D878", VA = "0x1D4D878")]
	private void RunNextTest()
	{
	}
}
