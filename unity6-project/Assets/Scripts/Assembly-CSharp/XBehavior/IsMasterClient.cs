using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

namespace XBehavior
{
	[Token(Token = "0x2000415")]
	public class IsMasterClient : Conditional
	{
		[Token(Token = "0x6002144")]
		[Address(RVA = "0x1F0248C", Offset = "0x1F0248C", VA = "0x1F0248C")]
		public IsMasterClient()
		{
		}

		[Token(Token = "0x6002145")]
		[Address(RVA = "0x1F02494", Offset = "0x1F02494", VA = "0x1F02494", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
