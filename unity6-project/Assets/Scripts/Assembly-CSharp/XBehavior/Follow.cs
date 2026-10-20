using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace XBehavior
{
	[Token(Token = "0x2000418")]
	public class Follow : XMovement
	{
		[Token(Token = "0x4001440")]
		[FieldOffset(Offset = "0x38")]
		public SharedFloat sharedDistance;

		[Token(Token = "0x4001441")]
		[FieldOffset(Offset = "0x3C")]
		public SharedFloat sharedDuration;

		[Token(Token = "0x4001442")]
		[FieldOffset(Offset = "0x40")]
		private float m_endTime;

		[Token(Token = "0x6002153")]
		[Address(RVA = "0x1F00550", Offset = "0x1F00550", VA = "0x1F00550")]
		public Follow()
		{
		}

		[Token(Token = "0x6002154")]
		[Address(RVA = "0x1F00558", Offset = "0x1F00558", VA = "0x1F00558", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x6002155")]
		[Address(RVA = "0x1F00604", Offset = "0x1F00604", VA = "0x1F00604", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6002156")]
		[Address(RVA = "0x1F00780", Offset = "0x1F00780", VA = "0x1F00780", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6002157")]
		[Address(RVA = "0x1F00A6C", Offset = "0x1F00A6C", VA = "0x1F00A6C", Slot = "30")]
		protected override Vector3 Target()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6002158")]
		[Address(RVA = "0x1F00B84", Offset = "0x1F00B84", VA = "0x1F00B84", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x6002159")]
		[Address(RVA = "0x1F00C4C", Offset = "0x1F00C4C", VA = "0x1F00C4C", Slot = "14")]
		public override void OnReset()
		{
		}
	}
}
