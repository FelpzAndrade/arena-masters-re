using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CA5")]
public class XWidget_TextScrolling : MonoBehaviour
{
	[Token(Token = "0x2000CA6")]
	public enum RollingState
	{
		[Token(Token = "0x4004075")]
		None = 0,
		[Token(Token = "0x4004076")]
		Start = 1,
		[Token(Token = "0x4004077")]
		Sliding = 2,
		[Token(Token = "0x4004078")]
		End = 3
	}

	[Token(Token = "0x4004066")]
	[FieldOffset(Offset = "0xC")]
	private float toX;

	[Token(Token = "0x4004067")]
	[FieldOffset(Offset = "0x10")]
	private float elaspedX;

	[Token(Token = "0x4004068")]
	[FieldOffset(Offset = "0x14")]
	private float elaspedTime;

	[Token(Token = "0x4004069")]
	[FieldOffset(Offset = "0x18")]
	private float nextStateTime;

	[Token(Token = "0x400406A")]
	[FieldOffset(Offset = "0x1C")]
	private float slidingInterval;

	[Token(Token = "0x400406B")]
	[FieldOffset(Offset = "0x20")]
	public float rolingStartTime;

	[Token(Token = "0x400406C")]
	[FieldOffset(Offset = "0x24")]
	public float rolingSlidingTime;

	[Token(Token = "0x400406D")]
	[FieldOffset(Offset = "0x28")]
	public float rolingEndTime;

	[Token(Token = "0x400406E")]
	[FieldOffset(Offset = "0x2C")]
	public float speed;

	[Token(Token = "0x400406F")]
	[FieldOffset(Offset = "0x30")]
	public Transform transformMessage;

	[Token(Token = "0x4004070")]
	[FieldOffset(Offset = "0x34")]
	public UILabel lblMessage;

	[Token(Token = "0x4004071")]
	[FieldOffset(Offset = "0x38")]
	public UIPanel clipPanel;

	[Token(Token = "0x4004072")]
	[FieldOffset(Offset = "0x3C")]
	private Action changedNoneCallback;

	[Token(Token = "0x4004073")]
	[FieldOffset(Offset = "0x40")]
	private RollingState rollingState__BackingField;

	[Token(Token = "0x17000CC9")]
	public RollingState rollingState
	{
		[Token(Token = "0x6005B58")]
		[Address(RVA = "0x1B22988", Offset = "0x1B22988", VA = "0x1B22988")]
		get
		{
			return default(RollingState);
		}
		[Token(Token = "0x6005B59")]
		[Address(RVA = "0x1B22990", Offset = "0x1B22990", VA = "0x1B22990")]
		private set
		{
		}
	}

	[Token(Token = "0x6005B57")]
	[Address(RVA = "0x1B2296C", Offset = "0x1B2296C", VA = "0x1B2296C")]
	public XWidget_TextScrolling()
	{
	}

	[Token(Token = "0x6005B5A")]
	[Address(RVA = "0x1B22998", Offset = "0x1B22998", VA = "0x1B22998")]
	private void Update()
	{
	}

	[Token(Token = "0x6005B5B")]
	[Address(RVA = "0x1B22B58", Offset = "0x1B22B58", VA = "0x1B22B58")]
	public void Init(Action changedNoneCallback)
	{
	}

	[Token(Token = "0x6005B5C")]
	[Address(RVA = "0x1B22B60", Offset = "0x1B22B60", VA = "0x1B22B60")]
	public bool IsNeedRoling()
	{
		return default(bool);
	}

	[Token(Token = "0x6005B5D")]
	[Address(RVA = "0x1B22BD4", Offset = "0x1B22BD4", VA = "0x1B22BD4")]
	public float GetClipWidth()
	{
		return default(float);
	}

	[Token(Token = "0x6005B5E")]
	[Address(RVA = "0x1B22B9C", Offset = "0x1B22B9C", VA = "0x1B22B9C")]
	public float GetMessageWidth()
	{
		return default(float);
	}

	[Token(Token = "0x6005B5F")]
	[Address(RVA = "0x1B22C00", Offset = "0x1B22C00", VA = "0x1B22C00")]
	public void StartRolling(RollingState startState)
	{
	}

	[Token(Token = "0x6005B60")]
	[Address(RVA = "0x1B22AFC", Offset = "0x1B22AFC", VA = "0x1B22AFC")]
	private void SetNextState(RollingState curState)
	{
	}

	[Token(Token = "0x6005B61")]
	[Address(RVA = "0x1B22B20", Offset = "0x1B22B20", VA = "0x1B22B20")]
	private float GetNextStateTime(RollingState curState)
	{
		return default(float);
	}
}
