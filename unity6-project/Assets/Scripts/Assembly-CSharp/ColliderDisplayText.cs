using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000059")]
public class ColliderDisplayText : MonoBehaviour
{
	[Token(Token = "0x4000182")]
	[FieldOffset(Offset = "0xC")]
	public GameObject prefab;

	[Token(Token = "0x4000183")]
	[FieldOffset(Offset = "0x10")]
	public Transform target;

	[Token(Token = "0x4000184")]
	[FieldOffset(Offset = "0x14")]
	private HUDText mText;

	[Token(Token = "0x4000185")]
	[FieldOffset(Offset = "0x18")]
	private bool mHover;

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x20C7760", Offset = "0x20C7760", VA = "0x20C7760")]
	public ColliderDisplayText()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x20C7768", Offset = "0x20C7768", VA = "0x20C7768")]
	private void Start()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x20C793C", Offset = "0x20C793C", VA = "0x20C793C")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x20C7A98", Offset = "0x20C7A98", VA = "0x20C7A98")]
	private void OnClick()
	{
	}
}
