using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20002F0")]
public class PhotonTransformViewPositionModel
{
	[Token(Token = "0x20002F1")]
	public enum InterpolateOptions
	{
		[Token(Token = "0x4000FAE")]
		Disabled = 0,
		[Token(Token = "0x4000FAF")]
		FixedSpeed = 1,
		[Token(Token = "0x4000FB0")]
		EstimatedSpeed = 2,
		[Token(Token = "0x4000FB1")]
		SynchronizeValues = 3,
		[Token(Token = "0x4000FB2")]
		Lerp = 4
	}

	[Token(Token = "0x20002F2")]
	public enum ExtrapolateOptions
	{
		[Token(Token = "0x4000FB4")]
		Disabled = 0,
		[Token(Token = "0x4000FB5")]
		SynchronizeValues = 1,
		[Token(Token = "0x4000FB6")]
		EstimateSpeedAndTurn = 2,
		[Token(Token = "0x4000FB7")]
		FixedSpeed = 3
	}

	[Token(Token = "0x4000F9F")]
	[FieldOffset(Offset = "0x8")]
	public bool SynchronizeEnabled;

	[Token(Token = "0x4000FA0")]
	[FieldOffset(Offset = "0x9")]
	public bool TeleportEnabled;

	[Token(Token = "0x4000FA1")]
	[FieldOffset(Offset = "0xC")]
	public float TeleportIfDistanceGreaterThan;

	[Token(Token = "0x4000FA2")]
	[FieldOffset(Offset = "0x10")]
	public InterpolateOptions InterpolateOption;

	[Token(Token = "0x4000FA3")]
	[FieldOffset(Offset = "0x14")]
	public float InterpolateMoveTowardsSpeed;

	[Token(Token = "0x4000FA4")]
	[FieldOffset(Offset = "0x18")]
	public float InterpolateLerpSpeed;

	[Token(Token = "0x4000FA5")]
	[FieldOffset(Offset = "0x1C")]
	public float InterpolateMoveTowardsAcceleration;

	[Token(Token = "0x4000FA6")]
	[FieldOffset(Offset = "0x20")]
	public float InterpolateMoveTowardsDeceleration;

	[Token(Token = "0x4000FA7")]
	[FieldOffset(Offset = "0x24")]
	public AnimationCurve InterpolateSpeedCurve;

	[Token(Token = "0x4000FA8")]
	[FieldOffset(Offset = "0x28")]
	public ExtrapolateOptions ExtrapolateOption;

	[Token(Token = "0x4000FA9")]
	[FieldOffset(Offset = "0x2C")]
	public float ExtrapolateSpeed;

	[Token(Token = "0x4000FAA")]
	[FieldOffset(Offset = "0x30")]
	public bool ExtrapolateIncludingRoundTripTime;

	[Token(Token = "0x4000FAB")]
	[FieldOffset(Offset = "0x34")]
	public int ExtrapolateNumberOfStoredPositions;

	[Token(Token = "0x4000FAC")]
	[FieldOffset(Offset = "0x38")]
	public bool DrawErrorGizmo;

	[Token(Token = "0x60019E3")]
	[Address(RVA = "0x1B9FE1C", Offset = "0x1B9FE1C", VA = "0x1B9FE1C")]
	public PhotonTransformViewPositionModel()
	{
	}
}
