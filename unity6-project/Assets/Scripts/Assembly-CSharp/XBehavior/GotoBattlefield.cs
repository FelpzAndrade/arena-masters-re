using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace XBehavior
{
	[Token(Token = "0x200041A")]
	public class GotoBattlefield : XMovement
	{
		[Token(Token = "0x4001445")]
		[FieldOffset(Offset = "0x38")]
		private XRandomPosInCircle m_battlefield;

		[Token(Token = "0x4001446")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_start;

		[Token(Token = "0x4001447")]
		[FieldOffset(Offset = "0x3D")]
		private bool m_arrived;

		[Token(Token = "0x4001448")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 m_pos;

		[Token(Token = "0x6002160")]
		[Address(RVA = "0x1F0118C", Offset = "0x1F0118C", VA = "0x1F0118C")]
		public GotoBattlefield()
		{
		}

		[Token(Token = "0x6002161")]
		[Address(RVA = "0x1F01194", Offset = "0x1F01194", VA = "0x1F01194", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6002162")]
		[Address(RVA = "0x1F01368", Offset = "0x1F01368", VA = "0x1F01368", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6002163")]
		[Address(RVA = "0x1F01404", Offset = "0x1F01404", VA = "0x1F01404", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x6002164")]
		[Address(RVA = "0x1F01454", Offset = "0x1F01454", VA = "0x1F01454", Slot = "14")]
		public override void OnReset()
		{
		}
	}
}
