using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006CD")]
public class Joystick : MonoBehaviour
{
	[Token(Token = "0x4002073")]
	[FieldOffset(Offset = "0x0")]
	private static Joystick[] joysticks;

	[Token(Token = "0x4002074")]
	[FieldOffset(Offset = "0x4")]
	private static bool enumeratedJoysticks;

	[Token(Token = "0x4002075")]
	[FieldOffset(Offset = "0x8")]
	private static float tapTimeDelta;

	[Token(Token = "0x4002076")]
	[FieldOffset(Offset = "0xC")]
	public bool touchPad;

	[Token(Token = "0x4002077")]
	[FieldOffset(Offset = "0x10")]
	public Rect touchZone;

	[Token(Token = "0x4002078")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 deadZone;

	[Token(Token = "0x4002079")]
	[FieldOffset(Offset = "0x28")]
	public bool normalize;

	[Token(Token = "0x400207A")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2 position;

	[Token(Token = "0x400207B")]
	[FieldOffset(Offset = "0x34")]
	public int tapCount;

	[Token(Token = "0x400207C")]
	[FieldOffset(Offset = "0x38")]
	private int lastFingerId;

	[Token(Token = "0x400207D")]
	[FieldOffset(Offset = "0x3C")]
	private float tapTimeWindow;

	[Token(Token = "0x400207E")]
	[FieldOffset(Offset = "0x40")]
	private Vector2 fingerDownPos;

	[Token(Token = "0x400207F")]
	[FieldOffset(Offset = "0x48")]
	private float fingerDownTime;

	[Token(Token = "0x4002080")]
	[FieldOffset(Offset = "0x4C")]
	private float firstDeltaTime;

	[Token(Token = "0x4002081")]
	[FieldOffset(Offset = "0x50")]
	private UnityEngine.Component gui;

	[Token(Token = "0x4002082")]
	[FieldOffset(Offset = "0x54")]
	private Rect defaultRect;

	[Token(Token = "0x4002083")]
	[FieldOffset(Offset = "0x64")]
	private Boundary guiBoundary;

	[Token(Token = "0x4002084")]
	[FieldOffset(Offset = "0x68")]
	private Vector2 guiTouchOffset;

	[Token(Token = "0x4002085")]
	[FieldOffset(Offset = "0x70")]
	private Vector2 guiCenter;

	[Token(Token = "0x60038FF")]
	[Address(RVA = "0xDCF22C", Offset = "0xDCF22C", VA = "0xDCF22C")]
	public Joystick()
	{
	}

	[Token(Token = "0x6003901")]
	[Address(RVA = "0xDCF384", Offset = "0xDCF384", VA = "0xDCF384")]
	private void Start()
	{
	}

	[Token(Token = "0x6003902")]
	[Address(RVA = "0xDCF708", Offset = "0xDCF708", VA = "0xDCF708")]
	private void Disable()
	{
	}

	[Token(Token = "0x6003903")]
	[Address(RVA = "0xDCF7EC", Offset = "0xDCF7EC", VA = "0xDCF7EC")]
	private void ResetJoystick()
	{
	}

	[Token(Token = "0x6003904")]
	[Address(RVA = "0xDCF91C", Offset = "0xDCF91C", VA = "0xDCF91C")]
	private bool IsFingerDown()
	{
		return default(bool);
	}

	[Token(Token = "0x6003905")]
	[Address(RVA = "0xDCF930", Offset = "0xDCF930", VA = "0xDCF930")]
	private void LatchedFinger(int fingerId)
	{
	}

	[Token(Token = "0x6003906")]
	[Address(RVA = "0xDCF940", Offset = "0xDCF940", VA = "0xDCF940")]
	private void Update()
	{
	}
}
