using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000256")]
public class UI2DSpriteAnimation : MonoBehaviour
{
	[Token(Token = "0x4000A67")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	protected int framerate;

	[Token(Token = "0x4000A68")]
	[FieldOffset(Offset = "0x10")]
	public bool ignoreTimeScale;

	[Token(Token = "0x4000A69")]
	[FieldOffset(Offset = "0x11")]
	public bool loop;

	[Token(Token = "0x4000A6A")]
	[FieldOffset(Offset = "0x14")]
	public Sprite[] frames;

	[Token(Token = "0x4000A6B")]
	[FieldOffset(Offset = "0x18")]
	private SpriteRenderer mUnitySprite;

	[Token(Token = "0x4000A6C")]
	[FieldOffset(Offset = "0x1C")]
	private UI2DSprite mNguiSprite;

	[Token(Token = "0x4000A6D")]
	[FieldOffset(Offset = "0x20")]
	private int mIndex;

	[Token(Token = "0x4000A6E")]
	[FieldOffset(Offset = "0x24")]
	private float mUpdate;

	[Token(Token = "0x1700031E")]
	public bool isPlaying
	{
		[Token(Token = "0x6001444")]
		[Address(RVA = "0x1D64344", Offset = "0x1D64344", VA = "0x1D64344")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700031F")]
	public int framesPerSecond
	{
		[Token(Token = "0x6001445")]
		[Address(RVA = "0x1D6434C", Offset = "0x1D6434C", VA = "0x1D6434C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001446")]
		[Address(RVA = "0x1D64354", Offset = "0x1D64354", VA = "0x1D64354")]
		set
		{
		}
	}

	[Token(Token = "0x6001443")]
	[Address(RVA = "0x1D6432C", Offset = "0x1D6432C", VA = "0x1D6432C")]
	public UI2DSpriteAnimation()
	{
	}

	[Token(Token = "0x6001447")]
	[Address(RVA = "0x1D6435C", Offset = "0x1D6435C", VA = "0x1D6435C")]
	public void Play()
	{
	}

	[Token(Token = "0x6001448")]
	[Address(RVA = "0x1D647E4", Offset = "0x1D647E4", VA = "0x1D647E4")]
	public void Pause()
	{
	}

	[Token(Token = "0x6001449")]
	[Address(RVA = "0x1D647F0", Offset = "0x1D647F0", VA = "0x1D647F0")]
	public void ResetToBeginning()
	{
	}

	[Token(Token = "0x600144A")]
	[Address(RVA = "0x1D64834", Offset = "0x1D64834", VA = "0x1D64834")]
	private void Start()
	{
	}

	[Token(Token = "0x600144B")]
	[Address(RVA = "0x1D64838", Offset = "0x1D64838", VA = "0x1D64838")]
	private void Update()
	{
	}

	[Token(Token = "0x600144C")]
	[Address(RVA = "0x1D64424", Offset = "0x1D64424", VA = "0x1D64424")]
	private void UpdateSprite()
	{
	}
}
