using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D8E")]
public class XUITargetIndicator : MonoBehaviour
{
	[Token(Token = "0x400465A")]
	[FieldOffset(Offset = "0xC")]
	public Transform target;

	[Token(Token = "0x400465B")]
	[FieldOffset(Offset = "0x10")]
	public Camera gameCamera;

	[Token(Token = "0x400465C")]
	[FieldOffset(Offset = "0x14")]
	public Camera uiCamera;

	[Token(Token = "0x400465D")]
	[FieldOffset(Offset = "0x18")]
	public bool disableIfInvisible;

	[Token(Token = "0x400465E")]
	[FieldOffset(Offset = "0x1C")]
	private Transform mTrans;

	[Token(Token = "0x400465F")]
	[FieldOffset(Offset = "0x20")]
	private bool mIsVisible;

	[Token(Token = "0x17000D3D")]
	public bool IsVisible
	{
		[Token(Token = "0x6006397")]
		[Address(RVA = "0x193454C", Offset = "0x193454C", VA = "0x193454C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6006393")]
	[Address(RVA = "0x193417C", Offset = "0x193417C", VA = "0x193417C")]
	public XUITargetIndicator()
	{
	}

	[Token(Token = "0x6006394")]
	[Address(RVA = "0x193418C", Offset = "0x193418C", VA = "0x193418C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006395")]
	[Address(RVA = "0x19341A8", Offset = "0x19341A8", VA = "0x19341A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6006396")]
	[Address(RVA = "0x1934420", Offset = "0x1934420", VA = "0x1934420")]
	private void SetVisible(bool val)
	{
	}

	[Token(Token = "0x6006398")]
	[Address(RVA = "0x1934554", Offset = "0x1934554", VA = "0x1934554")]
	private void Update()
	{
	}

	[Token(Token = "0x6006399")]
	[Address(RVA = "0x1934AFC", Offset = "0x1934AFC", VA = "0x1934AFC")]
	private void PositionArrow()
	{
	}

	[Token(Token = "0x600639A")]
	[Address(RVA = "0x1934E00", Offset = "0x1934E00", VA = "0x1934E00", Slot = "4")]
	protected virtual void OnUpdate(bool isVisible)
	{
	}
}
