using Il2CppDummyDll;
using Photon;
using UnityEngine;

[Token(Token = "0x200031E")]
public class ShowInfoOfPlayer : Photon.MonoBehaviour
{
	[Token(Token = "0x4001049")]
	[FieldOffset(Offset = "0x10")]
	private GameObject textGo;

	[Token(Token = "0x400104A")]
	[FieldOffset(Offset = "0x14")]
	private TextMesh tm;

	[Token(Token = "0x400104B")]
	[FieldOffset(Offset = "0x18")]
	public float CharacterSize;

	[Token(Token = "0x400104C")]
	[FieldOffset(Offset = "0x1C")]
	public Font font;

	[Token(Token = "0x400104D")]
	[FieldOffset(Offset = "0x20")]
	public bool DisableOnOwnObjects;

	[Token(Token = "0x6001AB4")]
	[Address(RVA = "0x20F8EA4", Offset = "0x20F8EA4", VA = "0x20F8EA4")]
	public ShowInfoOfPlayer()
	{
	}

	[Token(Token = "0x6001AB5")]
	[Address(RVA = "0x20F8EAC", Offset = "0x20F8EAC", VA = "0x20F8EAC")]
	private void Start()
	{
	}

	[Token(Token = "0x6001AB6")]
	[Address(RVA = "0x20F93C0", Offset = "0x20F93C0", VA = "0x20F93C0")]
	private void Update()
	{
	}
}
