using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace XBehavior
{
	[Token(Token = "0x200041C")]
	public class GotoRandomWayPoint : XMovement
	{
		[Token(Token = "0x400144D")]
		[FieldOffset(Offset = "0x38")]
		private XRandomPosInCircle m_TargetWayPoint;

		[Token(Token = "0x400144E")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_start;

		[Token(Token = "0x400144F")]
		[FieldOffset(Offset = "0x3D")]
		private bool m_arrived;

		[Token(Token = "0x4001450")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 m_pos;

		[Token(Token = "0x600216A")]
		[Address(RVA = "0x1F018D0", Offset = "0x1F018D0", VA = "0x1F018D0")]
		public GotoRandomWayPoint()
		{
		}

		[Token(Token = "0x600216B")]
		[Address(RVA = "0x1F018D8", Offset = "0x1F018D8", VA = "0x1F018D8", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600216C")]
		[Address(RVA = "0x1F01AAC", Offset = "0x1F01AAC", VA = "0x1F01AAC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600216D")]
		[Address(RVA = "0x1F01B4C", Offset = "0x1F01B4C", VA = "0x1F01B4C", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x600216E")]
		[Address(RVA = "0x1F01B9C", Offset = "0x1F01B9C", VA = "0x1F01B9C", Slot = "14")]
		public override void OnReset()
		{
		}
	}
}
