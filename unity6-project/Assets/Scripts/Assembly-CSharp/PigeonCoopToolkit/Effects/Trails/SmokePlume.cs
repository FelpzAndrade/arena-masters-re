using Il2CppDummyDll;
using UnityEngine;

namespace PigeonCoopToolkit.Effects.Trails
{
	[Token(Token = "0x2000336")]
	public class SmokePlume : TrailRenderer_Base
	{
		[Token(Token = "0x40010E8")]
		[FieldOffset(Offset = "0x20")]
		public float TimeBetweenPoints;

		[Token(Token = "0x40010E9")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 ConstantForce;

		[Token(Token = "0x40010EA")]
		[FieldOffset(Offset = "0x30")]
		public float RandomForceScale;

		[Token(Token = "0x40010EB")]
		[FieldOffset(Offset = "0x34")]
		public int MaxNumberOfPoints;

		[Token(Token = "0x40010EC")]
		[FieldOffset(Offset = "0x38")]
		private float _timeSincePoint;

		[Token(Token = "0x6001B57")]
		[Address(RVA = "0x1BABCFC", Offset = "0x1BABCFC", VA = "0x1BABCFC")]
		public SmokePlume()
		{
		}

		[Token(Token = "0x6001B58")]
		[Address(RVA = "0x1BABE14", Offset = "0x1BABE14", VA = "0x1BABE14", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6001B59")]
		[Address(RVA = "0x1BABE24", Offset = "0x1BABE24", VA = "0x1BABE24", Slot = "10")]
		protected override void OnStartEmit()
		{
		}

		[Token(Token = "0x6001B5A")]
		[Address(RVA = "0x1BABE30", Offset = "0x1BABE30", VA = "0x1BABE30", Slot = "13")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6001B5B")]
		[Address(RVA = "0x1BAC310", Offset = "0x1BAC310", VA = "0x1BAC310", Slot = "7")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6001B5C")]
		[Address(RVA = "0x1BAD294", Offset = "0x1BAD294", VA = "0x1BAD294", Slot = "14")]
		protected override void InitialiseNewPoint(PCTrailPoint newPoint)
		{
		}

		[Token(Token = "0x6001B5D")]
		[Address(RVA = "0x1BAD3A0", Offset = "0x1BAD3A0", VA = "0x1BAD3A0", Slot = "15")]
		protected override void UpdateTrail(PCTrail trail, float deltaTime)
		{
		}

		[Token(Token = "0x6001B5E")]
		[Address(RVA = "0x1BAD700", Offset = "0x1BAD700", VA = "0x1BAD700", Slot = "12")]
		protected override int GetMaxNumberOfPoints()
		{
			return default(int);
		}
	}
}
