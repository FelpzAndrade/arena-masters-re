using Il2CppDummyDll;
using UnityEngine;

namespace PigeonCoopToolkit.Effects.Trails
{
	[Token(Token = "0x2000338")]
	public class SmokeTrailPoint : PCTrailPoint
	{
		[Token(Token = "0x40010F2")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 RandomVec;

		[Token(Token = "0x6001B67")]
		[Address(RVA = "0x1BAC44C", Offset = "0x1BAC44C", VA = "0x1BAC44C")]
		public SmokeTrailPoint()
		{
		}

		[Token(Token = "0x6001B68")]
		[Address(RVA = "0x1BADB7C", Offset = "0x1BADB7C", VA = "0x1BADB7C", Slot = "4")]
		public override void Update(float deltaTime)
		{
		}
	}
}
