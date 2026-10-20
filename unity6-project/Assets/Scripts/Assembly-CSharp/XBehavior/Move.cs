using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace XBehavior
{
	[Token(Token = "0x200041E")]
	public class Move : XMovement
	{
		[Token(Token = "0x4001452")]
		[FieldOffset(Offset = "0x38")]
		public float duration;

		[Token(Token = "0x4001453")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 direction;

		[Token(Token = "0x4001454")]
		[FieldOffset(Offset = "0x48")]
		private float m_endTime;

		[Token(Token = "0x6002175")]
		[Address(RVA = "0x1A92130", Offset = "0x1A92130", VA = "0x1A92130")]
		public Move()
		{
		}

		[Token(Token = "0x6002176")]
		[Address(RVA = "0x1A92138", Offset = "0x1A92138", VA = "0x1A92138", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x6002177")]
		[Address(RVA = "0x1A9213C", Offset = "0x1A9213C", VA = "0x1A9213C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6002178")]
		[Address(RVA = "0x1A9218C", Offset = "0x1A9218C", VA = "0x1A9218C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6002179")]
		[Address(RVA = "0x1A92270", Offset = "0x1A92270", VA = "0x1A92270", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x600217A")]
		[Address(RVA = "0x1A922A4", Offset = "0x1A922A4", VA = "0x1A922A4", Slot = "14")]
		public override void OnReset()
		{
		}
	}
}
