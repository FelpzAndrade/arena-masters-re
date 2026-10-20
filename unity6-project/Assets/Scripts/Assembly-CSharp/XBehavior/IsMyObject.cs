using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

namespace XBehavior
{
	[Token(Token = "0x200042D")]
	public class IsMyObject : Conditional
	{
		[Token(Token = "0x400146E")]
		[FieldOffset(Offset = "0x2C")]
		private XModuleEntity m_me;

		[Token(Token = "0x60021B1")]
		[Address(RVA = "0x1F02604", Offset = "0x1F02604", VA = "0x1F02604")]
		public IsMyObject()
		{
		}

		[Token(Token = "0x60021B2")]
		[Address(RVA = "0x1F0260C", Offset = "0x1F0260C", VA = "0x1F0260C", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60021B3")]
		[Address(RVA = "0x1F026A0", Offset = "0x1F026A0", VA = "0x1F026A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
