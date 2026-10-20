using Il2CppDummyDll;
using PigeonCoopToolkit.Utillities;
using UnityEngine;

namespace PigeonCoopToolkit.Effects.Trails
{
	[Token(Token = "0x2000339")]
	public class SmoothTrail : TrailRenderer_Base
	{
		[Token(Token = "0x200033A")]
		private class ControlPoint
		{
			[Token(Token = "0x40010F9")]
			[FieldOffset(Offset = "0x8")]
			public Vector3 p;

			[Token(Token = "0x40010FA")]
			[FieldOffset(Offset = "0x14")]
			public Vector3 forward;

			[Token(Token = "0x6001B73")]
			[Address(RVA = "0x1BAE474", Offset = "0x1BAE474", VA = "0x1BAE474")]
			public ControlPoint()
			{
			}
		}

		[Token(Token = "0x40010F3")]
		[FieldOffset(Offset = "0x20")]
		public float MinControlPointDistance;

		[Token(Token = "0x40010F4")]
		[FieldOffset(Offset = "0x24")]
		public int MaxControlPoints;

		[Token(Token = "0x40010F5")]
		[FieldOffset(Offset = "0x28")]
		public int PointsBetweenControlPoints;

		[Token(Token = "0x40010F6")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 _lastPosition;

		[Token(Token = "0x40010F7")]
		[FieldOffset(Offset = "0x38")]
		private float _distanceMoved;

		[Token(Token = "0x40010F8")]
		[FieldOffset(Offset = "0x3C")]
		private CircularBuffer<ControlPoint> _controlPoints;

		[Token(Token = "0x6001B69")]
		[Address(RVA = "0x1BADC00", Offset = "0x1BADC00", VA = "0x1BADC00")]
		public SmoothTrail()
		{
		}

		[Token(Token = "0x6001B6A")]
		[Address(RVA = "0x1BADCBC", Offset = "0x1BADCBC", VA = "0x1BADCBC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6001B6B")]
		[Address(RVA = "0x1BADD08", Offset = "0x1BADD08", VA = "0x1BADD08", Slot = "7")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6001B6C")]
		[Address(RVA = "0x1BAE1F8", Offset = "0x1BAE1F8", VA = "0x1BAE1F8", Slot = "10")]
		protected override void OnStartEmit()
		{
		}

		[Token(Token = "0x6001B6D")]
		[Address(RVA = "0x1BAE47C", Offset = "0x1BAE47C", VA = "0x1BAE47C", Slot = "15")]
		protected override void UpdateTrail(PCTrail trail, float deltaTime)
		{
		}

		[Token(Token = "0x6001B6E")]
		[Address(RVA = "0x1BAF5A0", Offset = "0x1BAF5A0", VA = "0x1BAF5A0", Slot = "13")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6001B6F")]
		[Address(RVA = "0x1BAF5CC", Offset = "0x1BAF5CC", VA = "0x1BAF5CC", Slot = "11")]
		protected override void OnTranslate(Vector3 t)
		{
		}

		[Token(Token = "0x6001B70")]
		[Address(RVA = "0x1BAE00C", Offset = "0x1BAE00C", VA = "0x1BAE00C")]
		private void AddControlPoint(Vector3 position)
		{
		}

		[Token(Token = "0x6001B71")]
		[Address(RVA = "0x1BAF748", Offset = "0x1BAF748", VA = "0x1BAF748", Slot = "12")]
		protected override int GetMaxNumberOfPoints()
		{
			return default(int);
		}

		[Token(Token = "0x6001B72")]
		[Address(RVA = "0x1BAF28C", Offset = "0x1BAF28C", VA = "0x1BAF28C")]
		public Vector3 GetPointAlongCurve(Vector3 curveStart, Vector3 curveStartHandle, Vector3 curveEnd, Vector3 curveEndHandle, float t, float crease)
		{
			return default(Vector3);
		}
	}
}
