using Il2CppDummyDll;
using UnityEngine;

namespace PigeonCoopToolkit.Effects.Trails
{
	[Token(Token = "0x200033E")]
	public class PCTrailPoint
	{
		[Token(Token = "0x4001113")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 Forward;

		[Token(Token = "0x4001114")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 Position;

		[Token(Token = "0x4001115")]
		[FieldOffset(Offset = "0x20")]
		public int PointNumber;

		[Token(Token = "0x4001116")]
		[FieldOffset(Offset = "0x24")]
		private float _timeActive;

		[Token(Token = "0x4001117")]
		[FieldOffset(Offset = "0x28")]
		private float _distance;

		[Token(Token = "0x6001B9A")]
		[Address(RVA = "0x1BABC1C", Offset = "0x1BABC1C", VA = "0x1BABC1C")]
		public PCTrailPoint()
		{
		}

		[Token(Token = "0x6001B9B")]
		[Address(RVA = "0x1BABC24", Offset = "0x1BABC24", VA = "0x1BABC24", Slot = "4")]
		public virtual void Update(float deltaTime)
		{
		}

		[Token(Token = "0x6001B9C")]
		[Address(RVA = "0x1BABC38", Offset = "0x1BABC38", VA = "0x1BABC38")]
		public float TimeActive()
		{
			return default(float);
		}

		[Token(Token = "0x6001B9D")]
		[Address(RVA = "0x1BABC40", Offset = "0x1BABC40", VA = "0x1BABC40")]
		public void SetTimeActive(float time)
		{
		}

		[Token(Token = "0x6001B9E")]
		[Address(RVA = "0x1BABC48", Offset = "0x1BABC48", VA = "0x1BABC48")]
		public void SetDistanceFromStart(float distance)
		{
		}

		[Token(Token = "0x6001B9F")]
		[Address(RVA = "0x1BABC50", Offset = "0x1BABC50", VA = "0x1BABC50")]
		public float GetDistanceFromStart()
		{
			return default(float);
		}
	}
}
