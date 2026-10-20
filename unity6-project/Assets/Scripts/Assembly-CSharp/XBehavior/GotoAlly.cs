using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

namespace XBehavior
{
	[Token(Token = "0x2000419")]
	public class GotoAlly : XMovement
	{
		[Token(Token = "0x4001443")]
		[FieldOffset(Offset = "0x38")]
		private XModuleTeam m_team;

		[Token(Token = "0x4001444")]
		[FieldOffset(Offset = "0x3C")]
		private XModuleEntity m_followTarget;

		[Token(Token = "0x600215A")]
		[Address(RVA = "0x1F00C54", Offset = "0x1F00C54", VA = "0x1F00C54")]
		public GotoAlly()
		{
		}

		[Token(Token = "0x600215B")]
		[Address(RVA = "0x1F00C5C", Offset = "0x1F00C5C", VA = "0x1F00C5C", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x600215C")]
		[Address(RVA = "0x1F00C90", Offset = "0x1F00C90", VA = "0x1F00C90")]
		private void UpdateFollow()
		{
		}

		[Token(Token = "0x600215D")]
		[Address(RVA = "0x1F00DF8", Offset = "0x1F00DF8", VA = "0x1F00DF8", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x600215E")]
		[Address(RVA = "0x1F010A4", Offset = "0x1F010A4", VA = "0x1F010A4", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x600215F")]
		[Address(RVA = "0x1F01184", Offset = "0x1F01184", VA = "0x1F01184", Slot = "14")]
		public override void OnReset()
		{
		}
	}
}
