using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20002F4")]
public class PhotonTransformViewRotationModel
{
	[Token(Token = "0x20002F5")]
	public enum InterpolateOptions
	{
		[Token(Token = "0x4000FBF")]
		Disabled = 0,
		[Token(Token = "0x4000FC0")]
		RotateTowards = 1,
		[Token(Token = "0x4000FC1")]
		Lerp = 2
	}

	[Token(Token = "0x4000FBA")]
	[FieldOffset(Offset = "0x8")]
	public bool SynchronizeEnabled;

	[Token(Token = "0x4000FBB")]
	[FieldOffset(Offset = "0xC")]
	public InterpolateOptions InterpolateOption;

	[Token(Token = "0x4000FBC")]
	[FieldOffset(Offset = "0x10")]
	public float InterpolateRotateTowardsSpeed;

	[Token(Token = "0x4000FBD")]
	[FieldOffset(Offset = "0x14")]
	public float InterpolateLerpSpeed;

	[Token(Token = "0x60019E9")]
	[Address(RVA = "0x1BA008C", Offset = "0x1BA008C", VA = "0x1BA008C")]
	public PhotonTransformViewRotationModel()
	{
	}
}
