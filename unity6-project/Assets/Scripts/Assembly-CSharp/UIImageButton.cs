using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001DC")]
public class UIImageButton : MonoBehaviour
{
	[Token(Token = "0x4000749")]
	[FieldOffset(Offset = "0xC")]
	public UISprite target;

	[Token(Token = "0x400074A")]
	[FieldOffset(Offset = "0x10")]
	public string normalSprite;

	[Token(Token = "0x400074B")]
	[FieldOffset(Offset = "0x14")]
	public string hoverSprite;

	[Token(Token = "0x400074C")]
	[FieldOffset(Offset = "0x18")]
	public string pressedSprite;

	[Token(Token = "0x400074D")]
	[FieldOffset(Offset = "0x1C")]
	public string disabledSprite;

	[Token(Token = "0x400074E")]
	[FieldOffset(Offset = "0x20")]
	public bool pixelSnap;

	[Token(Token = "0x17000255")]
	public bool isEnabled
	{
		[Token(Token = "0x6000FBB")]
		[Address(RVA = "0x16F44EC", Offset = "0x16F44EC", VA = "0x16F44EC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000FBC")]
		[Address(RVA = "0x16F45F4", Offset = "0x16F45F4", VA = "0x16F45F4")]
		set
		{
		}
	}

	[Token(Token = "0x6000FBA")]
	[Address(RVA = "0x16F44DC", Offset = "0x16F44DC", VA = "0x16F44DC")]
	public UIImageButton()
	{
	}

	[Token(Token = "0x6000FBD")]
	[Address(RVA = "0x16F4868", Offset = "0x16F4868", VA = "0x16F4868")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000FBE")]
	[Address(RVA = "0x16F4950", Offset = "0x16F4950", VA = "0x16F4950")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000FBF")]
	[Address(RVA = "0x16F471C", Offset = "0x16F471C", VA = "0x16F471C")]
	private void UpdateImage()
	{
	}

	[Token(Token = "0x6000FC0")]
	[Address(RVA = "0x16F4D20", Offset = "0x16F4D20", VA = "0x16F4D20")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6000FC1")]
	[Address(RVA = "0x16F4E1C", Offset = "0x16F4E1C", VA = "0x16F4E1C")]
	private void OnPress(bool pressed)
	{
	}

	[Token(Token = "0x6000FC2")]
	[Address(RVA = "0x16F4BAC", Offset = "0x16F4BAC", VA = "0x16F4BAC")]
	private void SetSprite(string sprite)
	{
	}
}
