using Il2CppDummyDll;
using UnityEngine;

namespace XLevel
{
	[Token(Token = "0x200071E")]
	public struct XVector
	{
		[Token(Token = "0x40021A3")]
		[FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x40021A4")]
		[FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x40021A5")]
		[FieldOffset(Offset = "0x8")]
		public float z;

		[Token(Token = "0x40021A6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly XVector Zero;

		[Token(Token = "0x6003AC1")]
		[Address(RVA = "0x20334C0", Offset = "0x20334C0", VA = "0x20334C0")]
		public XVector(Vector3 v)
		{
			this = default;
		}

		[Token(Token = "0x6003AC2")]
		[Address(RVA = "0x20334CC", Offset = "0x20334CC", VA = "0x20334CC")]
		public XVector(float x, float y, float z)
		{
			this = default;
		}

		[Token(Token = "0x6003AC4")]
		[Address(RVA = "0x2033564", Offset = "0x2033564", VA = "0x2033564")]
		public Vector3 ToVector3()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6003AC5")]
		[Address(RVA = "0x20335A0", Offset = "0x20335A0", VA = "0x20335A0")]
		public void FromVector3(Vector3 v)
		{
		}

		[Token(Token = "0x6003AC6")]
		[Address(RVA = "0x20335AC", Offset = "0x20335AC", VA = "0x20335AC")]
		public static XVector operator -(XVector a, XVector b)
		{
			return default(XVector);
		}
	}
}
