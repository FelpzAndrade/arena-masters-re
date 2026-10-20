using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001AD")]
public class LagPosition : MonoBehaviour
{
	[Token(Token = "0x400063A")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 speed;

	[Token(Token = "0x400063B")]
	[FieldOffset(Offset = "0x18")]
	public bool ignoreTimeScale;

	[Token(Token = "0x400063C")]
	[FieldOffset(Offset = "0x1C")]
	private Transform mTrans;

	[Token(Token = "0x400063D")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 mRelative;

	[Token(Token = "0x400063E")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 mAbsolute;

	[Token(Token = "0x400063F")]
	[FieldOffset(Offset = "0x38")]
	private bool mStarted;

	[Token(Token = "0x6000EB6")]
	[Address(RVA = "0xDD4854", Offset = "0xDD4854", VA = "0xDD4854")]
	public LagPosition()
	{
	}

	[Token(Token = "0x6000EB7")]
	[Address(RVA = "0xDD48B4", Offset = "0xDD48B4", VA = "0xDD48B4")]
	public void OnRepositionEnd()
	{
	}

	[Token(Token = "0x6000EB8")]
	[Address(RVA = "0xDD48C0", Offset = "0xDD48C0", VA = "0xDD48C0")]
	private void Interpolate(float delta)
	{
	}

	[Token(Token = "0x6000EB9")]
	[Address(RVA = "0xDD4B50", Offset = "0xDD4B50", VA = "0xDD4B50")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000EBA")]
	[Address(RVA = "0xDD4B6C", Offset = "0xDD4B6C", VA = "0xDD4B6C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000EBB")]
	[Address(RVA = "0xDD4BF0", Offset = "0xDD4BF0", VA = "0xDD4BF0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000EBC")]
	[Address(RVA = "0xDD4B7C", Offset = "0xDD4B7C", VA = "0xDD4B7C")]
	public void ResetPosition()
	{
	}

	[Token(Token = "0x6000EBD")]
	[Address(RVA = "0xDD4BFC", Offset = "0xDD4BFC", VA = "0xDD4BFC")]
	private void Update()
	{
	}
}
