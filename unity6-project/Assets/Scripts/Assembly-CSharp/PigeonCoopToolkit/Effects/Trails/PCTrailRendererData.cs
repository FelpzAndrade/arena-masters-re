using System;
using Il2CppDummyDll;
using UnityEngine;

namespace PigeonCoopToolkit.Effects.Trails
{
	[Serializable]
	[Token(Token = "0x200033F")]
	public class PCTrailRendererData
	{
		[Token(Token = "0x4001118")]
		[FieldOffset(Offset = "0x8")]
		public Material TrailMaterial;

		[Token(Token = "0x4001119")]
		[FieldOffset(Offset = "0xC")]
		public float Lifetime;

		[Token(Token = "0x400111A")]
		[FieldOffset(Offset = "0x10")]
		public bool UsingSimpleSize;

		[Token(Token = "0x400111B")]
		[FieldOffset(Offset = "0x14")]
		public float SimpleSizeOverLifeStart;

		[Token(Token = "0x400111C")]
		[FieldOffset(Offset = "0x18")]
		public float SimpleSizeOverLifeEnd;

		[Token(Token = "0x400111D")]
		[FieldOffset(Offset = "0x1C")]
		public AnimationCurve SizeOverLife;

		[Token(Token = "0x400111E")]
		[FieldOffset(Offset = "0x20")]
		public bool UsingSimpleColor;

		[Token(Token = "0x400111F")]
		[FieldOffset(Offset = "0x24")]
		public Color SimpleColorOverLifeStart;

		[Token(Token = "0x4001120")]
		[FieldOffset(Offset = "0x34")]
		public Color SimpleColorOverLifeEnd;

		[Token(Token = "0x4001121")]
		[FieldOffset(Offset = "0x44")]
		public Gradient ColorOverLife;

		[Token(Token = "0x4001122")]
		[FieldOffset(Offset = "0x48")]
		public bool StretchSizeToFit;

		[Token(Token = "0x4001123")]
		[FieldOffset(Offset = "0x49")]
		public bool StretchColorToFit;

		[Token(Token = "0x4001124")]
		[FieldOffset(Offset = "0x4C")]
		public float MaterialTileLength;

		[Token(Token = "0x4001125")]
		[FieldOffset(Offset = "0x50")]
		public bool UseForwardOverride;

		[Token(Token = "0x4001126")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 ForwardOverride;

		[Token(Token = "0x4001127")]
		[FieldOffset(Offset = "0x60")]
		public bool ForwardOverrideRelative;

		[Token(Token = "0x6001BA0")]
		[Address(RVA = "0x1BABC58", Offset = "0x1BABC58", VA = "0x1BABC58")]
		public PCTrailRendererData()
		{
		}
	}
}
