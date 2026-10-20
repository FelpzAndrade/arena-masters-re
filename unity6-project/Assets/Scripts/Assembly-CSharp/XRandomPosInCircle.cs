using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004F6")]
public class XRandomPosInCircle
{
	[Token(Token = "0x4001911")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private Vector3 m_pos;

	[Token(Token = "0x4001912")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private float m_radius;

	[Token(Token = "0x4001913")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float m_innerRadius;

	[Token(Token = "0x4001914")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private System.Random m_random;

	[Token(Token = "0x4001915")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<float> m_weight;

	[Token(Token = "0x4001916")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float m_magnitude;

	[Token(Token = "0x4001917")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float m_step;

	[Token(Token = "0x4001918")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float m_weightSum;

	[Token(Token = "0x4001919")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Func<float> m_getRadius;

	[Token(Token = "0x170006AD")]
	public Vector3 Position
	{
		[Token(Token = "0x6002ACA")]
		[Address(RVA = "0x1C9F2B0", Offset = "0x1C9F2B0", VA = "0x1C9F2B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170006AE")]
	public float Radius
	{
		[Token(Token = "0x6002ACB")]
		[Address(RVA = "0x1C9F2C4", Offset = "0x1C9F2C4", VA = "0x1C9F2C4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6002AC9")]
	[Address(RVA = "0x1C9F040", Offset = "0x1C9F040", VA = "0x1C9F040")]
	public XRandomPosInCircle(Vector3 pos, float radius, float innerRadius, int seed, [Optional] AnimationCurve curve)
	{
	}

	[Token(Token = "0x6002ACC")]
	[Address(RVA = "0x1C9F2D0", Offset = "0x1C9F2D0", VA = "0x1C9F2D0")]
	public Vector3 GetNextPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6002ACD")]
	[Address(RVA = "0x1C9F4A0", Offset = "0x1C9F4A0", VA = "0x1C9F4A0")]
	public bool IsInCircle(Vector3 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6002ACE")]
	[Address(RVA = "0x1C9F528", Offset = "0x1C9F528", VA = "0x1C9F528")]
	public bool IsInWeightedCircle(Vector3 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6002ACF")]
	[Address(RVA = "0x1C9F5BC", Offset = "0x1C9F5BC", VA = "0x1C9F5BC")]
	private float GetRadius()
	{
		return default(float);
	}

	[Token(Token = "0x6002AD0")]
	[Address(RVA = "0x1C9F640", Offset = "0x1C9F640", VA = "0x1C9F640")]
	private float GetWeightedRadius()
	{
		return default(float);
	}
}
