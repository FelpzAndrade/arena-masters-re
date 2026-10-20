using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace XBehavior
{
	[Token(Token = "0x2000439")]
	public class NPC_HasWayPoint : Conditional
	{
		[Token(Token = "0x4001498")]
		[FieldOffset(Offset = "0x2C")]
		private XModuleEntity m_me;

		[Token(Token = "0x4001499")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_start;

		[Token(Token = "0x60021CC")]
		[Address(RVA = "0x1A92738", Offset = "0x1A92738", VA = "0x1A92738")]
		public NPC_HasWayPoint()
		{
		}

		[Token(Token = "0x60021CD")]
		[Address(RVA = "0x1A9277C", Offset = "0x1A9277C", VA = "0x1A9277C", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60021CE")]
		[Address(RVA = "0x1A92810", Offset = "0x1A92810", VA = "0x1A92810", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
