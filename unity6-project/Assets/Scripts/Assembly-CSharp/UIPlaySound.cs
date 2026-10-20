using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001E3")]
public class UIPlaySound : MonoBehaviour
{
	[Token(Token = "0x20001E4")]
	public enum Trigger
	{
		[Token(Token = "0x4000786")]
		OnClick = 0,
		[Token(Token = "0x4000787")]
		OnMouseOver = 1,
		[Token(Token = "0x4000788")]
		OnMouseOut = 2,
		[Token(Token = "0x4000789")]
		OnPress = 3,
		[Token(Token = "0x400078A")]
		OnRelease = 4,
		[Token(Token = "0x400078B")]
		Custom = 5,
		[Token(Token = "0x400078C")]
		OnEnable = 6,
		[Token(Token = "0x400078D")]
		OnDisable = 7
	}

	[Token(Token = "0x4000780")]
	[FieldOffset(Offset = "0xC")]
	public AudioClip audioClip;

	[Token(Token = "0x4000781")]
	[FieldOffset(Offset = "0x10")]
	public Trigger trigger;

	[Token(Token = "0x4000782")]
	[FieldOffset(Offset = "0x14")]
	public float volume;

	[Token(Token = "0x4000783")]
	[FieldOffset(Offset = "0x18")]
	public float pitch;

	[Token(Token = "0x4000784")]
	[FieldOffset(Offset = "0x1C")]
	private bool mIsOver;

	[Token(Token = "0x1700025A")]
	private bool canPlay
	{
		[Token(Token = "0x6000FF8")]
		[Address(RVA = "0x1784BD8", Offset = "0x1784BD8", VA = "0x1784BD8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000FF7")]
	[Address(RVA = "0x1784BC4", Offset = "0x1784BC4", VA = "0x1784BC4")]
	public UIPlaySound()
	{
	}

	[Token(Token = "0x6000FF9")]
	[Address(RVA = "0x1784D0C", Offset = "0x1784D0C", VA = "0x1784D0C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000FFA")]
	[Address(RVA = "0x1784DE8", Offset = "0x1784DE8", VA = "0x1784DE8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000FFB")]
	[Address(RVA = "0x1784EC4", Offset = "0x1784EC4", VA = "0x1784EC4")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6000FFC")]
	[Address(RVA = "0x1784FEC", Offset = "0x1784FEC", VA = "0x1784FEC")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x6000FFD")]
	[Address(RVA = "0x1785114", Offset = "0x1785114", VA = "0x1785114")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000FFE")]
	[Address(RVA = "0x17851FC", Offset = "0x17851FC", VA = "0x17851FC")]
	private void OnSelect(bool isSelected)
	{
	}

	[Token(Token = "0x6000FFF")]
	[Address(RVA = "0x17852D4", Offset = "0x17852D4", VA = "0x17852D4")]
	public void Play()
	{
	}
}
