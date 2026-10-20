using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace XBehavior
{
	[Token(Token = "0x200041D")]
	public class Look : XMovement
	{
		[Token(Token = "0x4001451")]
		[FieldOffset(Offset = "0x38")]
		private float m_elapsedTime;

		[Token(Token = "0x600216F")]
		[Address(RVA = "0x1A91D1C", Offset = "0x1A91D1C", VA = "0x1A91D1C")]
		public Look()
		{
		}

		[Token(Token = "0x6002170")]
		[Address(RVA = "0x1A91D2C", Offset = "0x1A91D2C", VA = "0x1A91D2C", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x6002171")]
		[Address(RVA = "0x1A91DF0", Offset = "0x1A91DF0", VA = "0x1A91DF0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6002172")]
		[Address(RVA = "0x1A91FD8", Offset = "0x1A91FD8", VA = "0x1A91FD8", Slot = "30")]
		protected override Vector3 Target()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6002173")]
		[Address(RVA = "0x1A920F0", Offset = "0x1A920F0", VA = "0x1A920F0", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x6002174")]
		[Address(RVA = "0x1A92128", Offset = "0x1A92128", VA = "0x1A92128", Slot = "14")]
		public override void OnReset()
		{
		}
	}
}
