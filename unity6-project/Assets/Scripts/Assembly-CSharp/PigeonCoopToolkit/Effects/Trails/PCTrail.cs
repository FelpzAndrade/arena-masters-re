using System;
using Il2CppDummyDll;
using PigeonCoopToolkit.Utillities;
using UnityEngine;

namespace PigeonCoopToolkit.Effects.Trails
{
	[Token(Token = "0x200033D")]
	public class PCTrail : IDisposable
	{
		[Token(Token = "0x400110A")]
		[FieldOffset(Offset = "0x8")]
		public CircularBuffer<PCTrailPoint> Points;

		[Token(Token = "0x400110B")]
		[FieldOffset(Offset = "0xC")]
		public Mesh Mesh;

		[Token(Token = "0x400110C")]
		[FieldOffset(Offset = "0x10")]
		public Vector3[] verticies;

		[Token(Token = "0x400110D")]
		[FieldOffset(Offset = "0x14")]
		public Vector3[] normals;

		[Token(Token = "0x400110E")]
		[FieldOffset(Offset = "0x18")]
		public Vector2[] uvs;

		[Token(Token = "0x400110F")]
		[FieldOffset(Offset = "0x1C")]
		public Color[] colors;

		[Token(Token = "0x4001110")]
		[FieldOffset(Offset = "0x20")]
		public int[] indicies;

		[Token(Token = "0x4001111")]
		[FieldOffset(Offset = "0x24")]
		public int activePointCount;

		[Token(Token = "0x4001112")]
		[FieldOffset(Offset = "0x28")]
		public bool IsActiveTrail;

		[Token(Token = "0x6001B98")]
		[Address(RVA = "0x1BAB8C4", Offset = "0x1BAB8C4", VA = "0x1BAB8C4")]
		public PCTrail(int numPoints)
		{
		}

		[Token(Token = "0x6001B99")]
		[Address(RVA = "0x1BABA8C", Offset = "0x1BABA8C", VA = "0x1BABA8C", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
