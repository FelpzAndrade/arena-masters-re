using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

namespace XBehavior
{
	[Token(Token = "0x2000426")]
	public class SetClosestMonsterAsTarget : Action
	{
		[Token(Token = "0x4001463")]
		[FieldOffset(Offset = "0x2C")]
		private XModuleEntity m_me;

		[Token(Token = "0x600219C")]
		[Address(RVA = "0x1A934F8", Offset = "0x1A934F8", VA = "0x1A934F8")]
		public SetClosestMonsterAsTarget()
		{
		}

		[Token(Token = "0x600219D")]
		[Address(RVA = "0x1A93500", Offset = "0x1A93500", VA = "0x1A93500", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x600219E")]
		[Address(RVA = "0x1A93594", Offset = "0x1A93594", VA = "0x1A93594", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
