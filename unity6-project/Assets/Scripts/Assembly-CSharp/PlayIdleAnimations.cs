using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001B3")]
public class PlayIdleAnimations : MonoBehaviour
{
	[Token(Token = "0x400064F")]
	[FieldOffset(Offset = "0xC")]
	private Animation mAnim;

	[Token(Token = "0x4000650")]
	[FieldOffset(Offset = "0x10")]
	private AnimationClip mIdle;

	[Token(Token = "0x4000651")]
	[FieldOffset(Offset = "0x14")]
	private List<AnimationClip> mBreaks;

	[Token(Token = "0x4000652")]
	[FieldOffset(Offset = "0x18")]
	private float mNextBreak;

	[Token(Token = "0x4000653")]
	[FieldOffset(Offset = "0x1C")]
	private int mLastIndex;

	[Token(Token = "0x6000ECD")]
	[Address(RVA = "0x20E36F8", Offset = "0x20E36F8", VA = "0x20E36F8")]
	public PlayIdleAnimations()
	{
	}

	[Token(Token = "0x6000ECE")]
	[Address(RVA = "0x20E379C", Offset = "0x20E379C", VA = "0x20E379C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000ECF")]
	[Address(RVA = "0x20E3F74", Offset = "0x20E3F74", VA = "0x20E3F74")]
	private void Update()
	{
	}
}
