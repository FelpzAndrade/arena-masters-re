using System.Collections.Generic;
using AnimationOrTween;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000206")]
public class ActiveAnimation : MonoBehaviour
{
	[Token(Token = "0x4000879")]
	[FieldOffset(Offset = "0x0")]
	public static ActiveAnimation current;

	[Token(Token = "0x400087A")]
	[FieldOffset(Offset = "0xC")]
	public List<EventDelegate> onFinished;

	[Token(Token = "0x400087B")]
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	public GameObject eventReceiver;

	[Token(Token = "0x400087C")]
	[FieldOffset(Offset = "0x14")]
	[HideInInspector]
	public string callWhenFinished;

	[Token(Token = "0x400087D")]
	[FieldOffset(Offset = "0x18")]
	private Animation mAnim;

	[Token(Token = "0x400087E")]
	[FieldOffset(Offset = "0x1C")]
	private Direction mLastDirection;

	[Token(Token = "0x400087F")]
	[FieldOffset(Offset = "0x20")]
	private Direction mDisableDirection;

	[Token(Token = "0x4000880")]
	[FieldOffset(Offset = "0x24")]
	private bool mNotify;

	[Token(Token = "0x4000881")]
	[FieldOffset(Offset = "0x28")]
	private Animator mAnimator;

	[Token(Token = "0x4000882")]
	[FieldOffset(Offset = "0x2C")]
	private string mClip;

	[Token(Token = "0x17000285")]
	private float playbackTime
	{
		[Token(Token = "0x60010EF")]
		[Address(RVA = "0x20B4410", Offset = "0x20B4410", VA = "0x20B4410")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000286")]
	public bool isPlaying
	{
		[Token(Token = "0x60010F0")]
		[Address(RVA = "0x20B4538", Offset = "0x20B4538", VA = "0x20B4538")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60010EE")]
	[Address(RVA = "0x20B4318", Offset = "0x20B4318", VA = "0x20B4318")]
	public ActiveAnimation()
	{
	}

	[Token(Token = "0x60010F1")]
	[Address(RVA = "0x20B4AC0", Offset = "0x20B4AC0", VA = "0x20B4AC0")]
	public void Finish()
	{
	}

	[Token(Token = "0x60010F2")]
	[Address(RVA = "0x20B4FFC", Offset = "0x20B4FFC", VA = "0x20B4FFC")]
	public void Reset()
	{
	}

	[Token(Token = "0x60010F3")]
	[Address(RVA = "0x20B5524", Offset = "0x20B5524", VA = "0x20B5524")]
	private void Start()
	{
	}

	[Token(Token = "0x60010F4")]
	[Address(RVA = "0x20B5638", Offset = "0x20B5638", VA = "0x20B5638")]
	private void Update()
	{
	}

	[Token(Token = "0x60010F5")]
	[Address(RVA = "0x20B5EC0", Offset = "0x20B5EC0", VA = "0x20B5EC0")]
	private void Play(string clipName, Direction playDirection)
	{
	}

	[Token(Token = "0x60010F6")]
	[Address(RVA = "0x20B6738", Offset = "0x20B6738", VA = "0x20B6738")]
	public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
	{
		return null;
	}

	[Token(Token = "0x60010F7")]
	[Address(RVA = "0x20B6ACC", Offset = "0x20B6ACC", VA = "0x20B6ACC")]
	public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection)
	{
		return null;
	}

	[Token(Token = "0x60010F8")]
	[Address(RVA = "0x20B6AF0", Offset = "0x20B6AF0", VA = "0x20B6AF0")]
	public static ActiveAnimation Play(Animation anim, Direction playDirection)
	{
		return null;
	}

	[Token(Token = "0x60010F9")]
	[Address(RVA = "0x20B6B20", Offset = "0x20B6B20", VA = "0x20B6B20")]
	public static ActiveAnimation Play(Animator anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
	{
		return null;
	}
}
