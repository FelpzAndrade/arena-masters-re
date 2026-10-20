using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace XBehavior
{
	[Token(Token = "0x200042E")]
	public class IsResting : Conditional
	{
		[Token(Token = "0x400146F")]
		[FieldOffset(Offset = "0x2C")]
		public SharedFloat restTime;

		[Token(Token = "0x4001470")]
		[FieldOffset(Offset = "0x30")]
		private XModuleEntity m_me;

		[Token(Token = "0x4001471")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 m_start;

		[Token(Token = "0x60021B4")]
		[Address(RVA = "0x1F0279C", Offset = "0x1F0279C", VA = "0x1F0279C")]
		public IsResting()
		{
		}

		[Token(Token = "0x60021B5")]
		[Address(RVA = "0x1F027E0", Offset = "0x1F027E0", VA = "0x1F027E0", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60021B6")]
		[Address(RVA = "0x1F02874", Offset = "0x1F02874", VA = "0x1F02874", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
