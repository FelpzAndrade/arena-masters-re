using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20002F7")]
public class PhotonTransformViewScaleModel
{
	[Token(Token = "0x20002F8")]
	public enum InterpolateOptions
	{
		[Token(Token = "0x4000FC9")]
		Disabled = 0,
		[Token(Token = "0x4000FCA")]
		MoveTowards = 1,
		[Token(Token = "0x4000FCB")]
		Lerp = 2
	}

	[Token(Token = "0x4000FC4")]
	[FieldOffset(Offset = "0x8")]
	public bool SynchronizeEnabled;

	[Token(Token = "0x4000FC5")]
	[FieldOffset(Offset = "0xC")]
	public InterpolateOptions InterpolateOption;

	[Token(Token = "0x4000FC6")]
	[FieldOffset(Offset = "0x10")]
	public float InterpolateMoveTowardsSpeed;

	[Token(Token = "0x4000FC7")]
	[FieldOffset(Offset = "0x14")]
	public float InterpolateLerpSpeed;

	[Token(Token = "0x60019EE")]
	[Address(RVA = "0x1BA00B0", Offset = "0x1BA00B0", VA = "0x1BA00B0")]
	public PhotonTransformViewScaleModel()
	{
	}
}
