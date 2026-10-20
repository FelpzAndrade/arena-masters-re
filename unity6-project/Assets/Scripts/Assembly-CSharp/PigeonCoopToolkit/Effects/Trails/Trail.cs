using Il2CppDummyDll;
using UnityEngine;

namespace PigeonCoopToolkit.Effects.Trails
{
	[Token(Token = "0x200033B")]
	public class Trail : TrailRenderer_Base
	{
		[Token(Token = "0x40010FB")]
		[FieldOffset(Offset = "0x20")]
		public float MinVertexDistance;

		[Token(Token = "0x40010FC")]
		[FieldOffset(Offset = "0x24")]
		public int MaxNumberOfPoints;

		[Token(Token = "0x40010FD")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 _lastPosition;

		[Token(Token = "0x40010FE")]
		[FieldOffset(Offset = "0x34")]
		private float _distanceMoved;

		[Token(Token = "0x6001B74")]
		[Address(RVA = "0x1BAF758", Offset = "0x1BAF758", VA = "0x1BAF758")]
		public Trail()
		{
		}

		[Token(Token = "0x6001B75")]
		[Address(RVA = "0x1BAF810", Offset = "0x1BAF810", VA = "0x1BAF810", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6001B76")]
		[Address(RVA = "0x1BAF85C", Offset = "0x1BAF85C", VA = "0x1BAF85C", Slot = "7")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6001B77")]
		[Address(RVA = "0x1BAF9EC", Offset = "0x1BAF9EC", VA = "0x1BAF9EC", Slot = "10")]
		protected override void OnStartEmit()
		{
		}

		[Token(Token = "0x6001B78")]
		[Address(RVA = "0x1BAFA38", Offset = "0x1BAFA38", VA = "0x1BAFA38", Slot = "13")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6001B79")]
		[Address(RVA = "0x1BAFA58", Offset = "0x1BAFA58", VA = "0x1BAFA58", Slot = "11")]
		protected override void OnTranslate(Vector3 t)
		{
		}

		[Token(Token = "0x6001B7A")]
		[Address(RVA = "0x1BAFAA8", Offset = "0x1BAFAA8", VA = "0x1BAFAA8", Slot = "12")]
		protected override int GetMaxNumberOfPoints()
		{
			return default(int);
		}
	}
}
