using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001AA")]
public class EnvelopContent : MonoBehaviour
{
	[Token(Token = "0x4000632")]
	[FieldOffset(Offset = "0xC")]
	public Transform targetRoot;

	[Token(Token = "0x4000633")]
	[FieldOffset(Offset = "0x10")]
	public int padLeft;

	[Token(Token = "0x4000634")]
	[FieldOffset(Offset = "0x14")]
	public int padRight;

	[Token(Token = "0x4000635")]
	[FieldOffset(Offset = "0x18")]
	public int padBottom;

	[Token(Token = "0x4000636")]
	[FieldOffset(Offset = "0x1C")]
	public int padTop;

	[Token(Token = "0x4000637")]
	[FieldOffset(Offset = "0x20")]
	private bool mStarted;

	[Token(Token = "0x6000EAF")]
	[Address(RVA = "0x1E6A530", Offset = "0x1E6A530", VA = "0x1E6A530")]
	public EnvelopContent()
	{
	}

	[Token(Token = "0x6000EB0")]
	[Address(RVA = "0x1E6A538", Offset = "0x1E6A538", VA = "0x1E6A538")]
	private void Start()
	{
	}

	[Token(Token = "0x6000EB1")]
	[Address(RVA = "0x1E6A8E4", Offset = "0x1E6A8E4", VA = "0x1E6A8E4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000EB2")]
	[Address(RVA = "0x1E6A544", Offset = "0x1E6A544", VA = "0x1E6A544")]
	public void Execute()
	{
	}
}
