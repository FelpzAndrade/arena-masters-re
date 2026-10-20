using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

namespace XBehavior
{
	[Token(Token = "0x2000420")]
	public class Wander : XMovement
	{
		[Token(Token = "0x4001456")]
		[FieldOffset(Offset = "0x38")]
		private float m_duration;

		[Token(Token = "0x4001457")]
		[FieldOffset(Offset = "0x3C")]
		private float m_lastSetTime;

		[Token(Token = "0x6002182")]
		[Address(RVA = "0x1A9400C", Offset = "0x1A9400C", VA = "0x1A9400C")]
		public Wander()
		{
		}

		[Token(Token = "0x6002183")]
		[Address(RVA = "0x1A94014", Offset = "0x1A94014", VA = "0x1A94014", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6002184")]
		[Address(RVA = "0x1A94048", Offset = "0x1A94048", VA = "0x1A94048")]
		private void SetRandomPath()
		{
		}

		[Token(Token = "0x6002185")]
		[Address(RVA = "0x1A940E0", Offset = "0x1A940E0", VA = "0x1A940E0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6002186")]
		[Address(RVA = "0x1A94128", Offset = "0x1A94128", VA = "0x1A94128", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x6002187")]
		[Address(RVA = "0x1A9412C", Offset = "0x1A9412C", VA = "0x1A9412C", Slot = "14")]
		public override void OnReset()
		{
		}
	}
}
