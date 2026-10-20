using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200028C")]
[ExecuteInEditMode]
public class UISpriteAnimation : MonoBehaviour
{
	[Token(Token = "0x4000C10")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	[HideInInspector]
	protected int mFPS;

	[Token(Token = "0x4000C11")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[HideInInspector]
	protected string mPrefix;

	[Token(Token = "0x4000C12")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[HideInInspector]
	protected bool mLoop;

	[Token(Token = "0x4000C13")]
	[FieldOffset(Offset = "0x15")]
	[SerializeField]
	[HideInInspector]
	protected bool mSnap;

	[Token(Token = "0x4000C14")]
	[FieldOffset(Offset = "0x18")]
	protected UISprite mSprite;

	[Token(Token = "0x4000C15")]
	[FieldOffset(Offset = "0x1C")]
	protected float mDelta;

	[Token(Token = "0x4000C16")]
	[FieldOffset(Offset = "0x20")]
	protected int mIndex;

	[Token(Token = "0x4000C17")]
	[FieldOffset(Offset = "0x24")]
	protected bool mActive;

	[Token(Token = "0x4000C18")]
	[FieldOffset(Offset = "0x28")]
	protected List<string> mSpriteNames;

	[Token(Token = "0x170003BA")]
	public int frames
	{
		[Token(Token = "0x6001669")]
		[Address(RVA = "0x179F5F4", Offset = "0x179F5F4", VA = "0x179F5F4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003BB")]
	public int framesPerSecond
	{
		[Token(Token = "0x600166A")]
		[Address(RVA = "0x179F68C", Offset = "0x179F68C", VA = "0x179F68C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600166B")]
		[Address(RVA = "0x179F694", Offset = "0x179F694", VA = "0x179F694")]
		set
		{
		}
	}

	[Token(Token = "0x170003BC")]
	public string namePrefix
	{
		[Token(Token = "0x600166C")]
		[Address(RVA = "0x179F69C", Offset = "0x179F69C", VA = "0x179F69C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600166D")]
		[Address(RVA = "0x179F6A4", Offset = "0x179F6A4", VA = "0x179F6A4")]
		set
		{
		}
	}

	[Token(Token = "0x170003BD")]
	public bool loop
	{
		[Token(Token = "0x600166E")]
		[Address(RVA = "0x179FAAC", Offset = "0x179FAAC", VA = "0x179FAAC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600166F")]
		[Address(RVA = "0x179FAB4", Offset = "0x179FAB4", VA = "0x179FAB4")]
		set
		{
		}
	}

	[Token(Token = "0x170003BE")]
	public bool isPlaying
	{
		[Token(Token = "0x6001670")]
		[Address(RVA = "0x179FABC", Offset = "0x179FABC", VA = "0x179FABC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001668")]
	[Address(RVA = "0x179F4D8", Offset = "0x179F4D8", VA = "0x179F4D8")]
	public UISpriteAnimation()
	{
	}

	[Token(Token = "0x6001671")]
	[Address(RVA = "0x179FAC4", Offset = "0x179FAC4", VA = "0x179FAC4", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6001672")]
	[Address(RVA = "0x179FAC8", Offset = "0x179FAC8", VA = "0x179FAC8", Slot = "5")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6001673")]
	[Address(RVA = "0x179F76C", Offset = "0x179F76C", VA = "0x179F76C")]
	public void RebuildSpriteList()
	{
	}

	[Token(Token = "0x6001674")]
	[Address(RVA = "0x179FD3C", Offset = "0x179FD3C", VA = "0x179FD3C")]
	public void Play()
	{
	}

	[Token(Token = "0x6001675")]
	[Address(RVA = "0x179FD48", Offset = "0x179FD48", VA = "0x179FD48")]
	public void Pause()
	{
	}

	[Token(Token = "0x6001676")]
	[Address(RVA = "0x179FD54", Offset = "0x179FD54", VA = "0x179FD54")]
	public void ResetToBeginning()
	{
	}
}
