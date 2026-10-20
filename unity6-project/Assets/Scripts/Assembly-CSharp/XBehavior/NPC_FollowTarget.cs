using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace XBehavior
{
	[Token(Token = "0x200041F")]
	public class NPC_FollowTarget : XMovement
	{
		[Token(Token = "0x4001455")]
		[FieldOffset(Offset = "0x38")]
		private XModuleLevelObject m_mlo;

		[Token(Token = "0x600217B")]
		[Address(RVA = "0x1A922A8", Offset = "0x1A922A8", VA = "0x1A922A8")]
		public NPC_FollowTarget()
		{
		}

		[Token(Token = "0x600217C")]
		[Address(RVA = "0x1A922B0", Offset = "0x1A922B0", VA = "0x1A922B0", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x600217D")]
		[Address(RVA = "0x1A922E0", Offset = "0x1A922E0", VA = "0x1A922E0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600217E")]
		[Address(RVA = "0x1A9239C", Offset = "0x1A9239C", VA = "0x1A9239C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600217F")]
		[Address(RVA = "0x1A925C8", Offset = "0x1A925C8", VA = "0x1A925C8", Slot = "30")]
		protected override Vector3 Target()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6002180")]
		[Address(RVA = "0x1A92614", Offset = "0x1A92614", VA = "0x1A92614", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x6002181")]
		[Address(RVA = "0x1A92640", Offset = "0x1A92640", VA = "0x1A92640", Slot = "14")]
		public override void OnReset()
		{
		}
	}
}
