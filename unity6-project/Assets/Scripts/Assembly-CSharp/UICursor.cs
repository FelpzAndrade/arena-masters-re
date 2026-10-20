using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000198")]
public class UICursor : MonoBehaviour
{
	[Token(Token = "0x40005CA")]
	[FieldOffset(Offset = "0x0")]
	public static UICursor instance;

	[Token(Token = "0x40005CB")]
	[FieldOffset(Offset = "0xC")]
	public Camera uiCamera;

	[Token(Token = "0x40005CC")]
	[FieldOffset(Offset = "0x10")]
	private Transform mTrans;

	[Token(Token = "0x40005CD")]
	[FieldOffset(Offset = "0x14")]
	private UISprite mSprite;

	[Token(Token = "0x40005CE")]
	[FieldOffset(Offset = "0x18")]
	private UIAtlas mAtlas;

	[Token(Token = "0x40005CF")]
	[FieldOffset(Offset = "0x1C")]
	private string mSpriteName;

	[Token(Token = "0x6000E65")]
	[Address(RVA = "0x16DC4E8", Offset = "0x16DC4E8", VA = "0x16DC4E8")]
	public UICursor()
	{
	}

	[Token(Token = "0x6000E66")]
	[Address(RVA = "0x16DC4F0", Offset = "0x16DC4F0", VA = "0x16DC4F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000E67")]
	[Address(RVA = "0x16DC574", Offset = "0x16DC574", VA = "0x16DC574")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000E68")]
	[Address(RVA = "0x16DC5F8", Offset = "0x16DC5F8", VA = "0x16DC5F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000E69")]
	[Address(RVA = "0x16DC80C", Offset = "0x16DC80C", VA = "0x16DC80C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000E6A")]
	[Address(RVA = "0x16DCDD8", Offset = "0x16DCDD8", VA = "0x16DCDD8")]
	public static void Clear()
	{
	}

	[Token(Token = "0x6000E6B")]
	[Address(RVA = "0x16DCF54", Offset = "0x16DCF54", VA = "0x16DCF54")]
	public static void Set(UIAtlas atlas, string sprite)
	{
	}
}
