using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace XBehavior
{
	[Token(Token = "0x2000417")]
	public class Flee : XMovement
	{
		[Token(Token = "0x400143D")]
		[FieldOffset(Offset = "0x38")]
		private float m_startTime;

		[Token(Token = "0x400143E")]
		[FieldOffset(Offset = "0x3C")]
		private float m_endTime;

		[Token(Token = "0x400143F")]
		[FieldOffset(Offset = "0x40")]
		private new XModuleEntity m_me;

		[Token(Token = "0x600214D")]
		[Address(RVA = "0x1F00154", Offset = "0x1F00154", VA = "0x1F00154")]
		public Flee()
		{
		}

		[Token(Token = "0x600214E")]
		[Address(RVA = "0x1F0015C", Offset = "0x1F0015C", VA = "0x1F0015C", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x600214F")]
		[Address(RVA = "0x1F001F0", Offset = "0x1F001F0", VA = "0x1F001F0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6002150")]
		[Address(RVA = "0x1F002CC", Offset = "0x1F002CC", VA = "0x1F002CC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6002151")]
		[Address(RVA = "0x1F004D0", Offset = "0x1F004D0", VA = "0x1F004D0", Slot = "29")]
		protected override bool SetPathfindingDestination(Vector3 target)
		{
			return default(bool);
		}

		[Token(Token = "0x6002152")]
		[Address(RVA = "0x1F00514", Offset = "0x1F00514", VA = "0x1F00514", Slot = "9")]
		public override void OnEnd()
		{
		}
	}
}
