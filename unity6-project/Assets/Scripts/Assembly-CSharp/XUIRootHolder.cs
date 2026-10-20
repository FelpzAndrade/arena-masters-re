using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001069")]
public class XUIRootHolder : MonoSingleton<XUIRootHolder>
{
	[Token(Token = "0x40058A1")]
	[FieldOffset(Offset = "0xC")]
	public GameObject uiRoot;

	[Token(Token = "0x40058A2")]
	[FieldOffset(Offset = "0x10")]
	public Camera uiCamera;

	[Token(Token = "0x40058A3")]
	[FieldOffset(Offset = "0x14")]
	public UICamera uiCameraEx;

	[Token(Token = "0x40058A4")]
	[FieldOffset(Offset = "0x18")]
	public Transform uiCameraTransform;

	[Token(Token = "0x40058A5")]
	[FieldOffset(Offset = "0x1C")]
	public Object clickEffectPrefab;

	[Token(Token = "0x17000F52")]
	public override bool WillDestroyOnLoad
	{
		[Token(Token = "0x6007BFF")]
		[Address(RVA = "0x191E984", Offset = "0x191E984", VA = "0x191E984", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6007BFE")]
	[Address(RVA = "0x191E8C8", Offset = "0x191E8C8", VA = "0x191E8C8")]
	public XUIRootHolder()
	{
	}

	[Token(Token = "0x6007C00")]
	[Address(RVA = "0x191E98C", Offset = "0x191E98C", VA = "0x191E98C", Slot = "5")]
	public override void Init()
	{
	}

	[Token(Token = "0x6007C01")]
	[Address(RVA = "0x191EDA8", Offset = "0x191EDA8", VA = "0x191EDA8")]
	private void OnClick()
	{
	}
}
