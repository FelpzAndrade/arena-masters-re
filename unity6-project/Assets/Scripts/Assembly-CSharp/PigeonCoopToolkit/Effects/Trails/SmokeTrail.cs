using Il2CppDummyDll;
using UnityEngine;

namespace PigeonCoopToolkit.Effects.Trails
{
	[Token(Token = "0x2000337")]
	public class SmokeTrail : TrailRenderer_Base
	{
		[Token(Token = "0x40010ED")]
		[FieldOffset(Offset = "0x20")]
		public float MinVertexDistance;

		[Token(Token = "0x40010EE")]
		[FieldOffset(Offset = "0x24")]
		public int MaxNumberOfPoints;

		[Token(Token = "0x40010EF")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 _lastPosition;

		[Token(Token = "0x40010F0")]
		[FieldOffset(Offset = "0x34")]
		private float _distanceMoved;

		[Token(Token = "0x40010F1")]
		[FieldOffset(Offset = "0x38")]
		public float RandomForceScale;

		[Token(Token = "0x6001B5F")]
		[Address(RVA = "0x1BAD708", Offset = "0x1BAD708", VA = "0x1BAD708")]
		public SmokeTrail()
		{
		}

		[Token(Token = "0x6001B60")]
		[Address(RVA = "0x1BAD7C8", Offset = "0x1BAD7C8", VA = "0x1BAD7C8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6001B61")]
		[Address(RVA = "0x1BAD814", Offset = "0x1BAD814", VA = "0x1BAD814", Slot = "7")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6001B62")]
		[Address(RVA = "0x1BAD9A4", Offset = "0x1BAD9A4", VA = "0x1BAD9A4", Slot = "10")]
		protected override void OnStartEmit()
		{
		}

		[Token(Token = "0x6001B63")]
		[Address(RVA = "0x1BAD9F0", Offset = "0x1BAD9F0", VA = "0x1BAD9F0", Slot = "13")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6001B64")]
		[Address(RVA = "0x1BADA18", Offset = "0x1BADA18", VA = "0x1BADA18", Slot = "14")]
		protected override void InitialiseNewPoint(PCTrailPoint newPoint)
		{
		}

		[Token(Token = "0x6001B65")]
		[Address(RVA = "0x1BADB24", Offset = "0x1BADB24", VA = "0x1BADB24", Slot = "11")]
		protected override void OnTranslate(Vector3 t)
		{
		}

		[Token(Token = "0x6001B66")]
		[Address(RVA = "0x1BADB74", Offset = "0x1BADB74", VA = "0x1BADB74", Slot = "12")]
		protected override int GetMaxNumberOfPoints()
		{
			return default(int);
		}
	}
}
