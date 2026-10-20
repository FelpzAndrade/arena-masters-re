using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000236")]
public class UIGeometry
{
	[Token(Token = "0x40009A0")]
	[FieldOffset(Offset = "0x8")]
	public BetterList<Vector3> verts;

	[Token(Token = "0x40009A1")]
	[FieldOffset(Offset = "0xC")]
	public BetterList<Vector2> uvs;

	[Token(Token = "0x40009A2")]
	[FieldOffset(Offset = "0x10")]
	public BetterList<Color> cols;

	[Token(Token = "0x40009A3")]
	[FieldOffset(Offset = "0x14")]
	private BetterList<Vector3> mRtpVerts;

	[Token(Token = "0x40009A4")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 mRtpNormal;

	[Token(Token = "0x40009A5")]
	[FieldOffset(Offset = "0x24")]
	private Vector4 mRtpTan;

	[Token(Token = "0x170002CB")]
	public bool hasVertices
	{
		[Token(Token = "0x60012F4")]
		[Address(RVA = "0x16F2758", Offset = "0x16F2758", VA = "0x16F2758")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002CC")]
	public bool hasTransformed
	{
		[Token(Token = "0x60012F5")]
		[Address(RVA = "0x16F278C", Offset = "0x16F278C", VA = "0x16F278C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60012F3")]
	[Address(RVA = "0x16F262C", Offset = "0x16F262C", VA = "0x16F262C")]
	public UIGeometry()
	{
	}

	[Token(Token = "0x60012F6")]
	[Address(RVA = "0x16F27E0", Offset = "0x16F27E0", VA = "0x16F27E0")]
	public void Clear()
	{
	}

	[Token(Token = "0x60012F7")]
	[Address(RVA = "0x16F28F4", Offset = "0x16F28F4", VA = "0x16F28F4")]
	public void ApplyTransform(Matrix4x4 widgetToPanel, bool generateNormals = true)
	{
	}

	[Token(Token = "0x60012F8")]
	[Address(RVA = "0x16F2BE0", Offset = "0x16F2BE0", VA = "0x16F2BE0")]
	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color> c, BetterList<Vector3> n, BetterList<Vector4> t)
	{
	}
}
