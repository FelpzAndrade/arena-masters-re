using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace XBehavior
{
	[Token(Token = "0x2000421")]
	public abstract class XMovement : Action
	{
		[Token(Token = "0x4001458")]
		[FieldOffset(Offset = "0x2C")]
		protected Seeker m_seeker;

		[Token(Token = "0x4001459")]
		[FieldOffset(Offset = "0x30")]
		protected XAIAgent m_agent;

		[Token(Token = "0x400145A")]
		[FieldOffset(Offset = "0x34")]
		protected XModuleEntity m_me;

		[Token(Token = "0x6002188")]
		[Address(RVA = "0x1A91D24", Offset = "0x1A91D24", VA = "0x1A91D24")]
		protected XMovement()
		{
		}

		[Token(Token = "0x6002189")]
		[Address(RVA = "0x1A91D30", Offset = "0x1A91D30", VA = "0x1A91D30", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x600218A")]
		[Address(RVA = "0x1A92188", Offset = "0x1A92188", VA = "0x1A92188", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x600218B")]
		[Address(RVA = "0x1A94130", Offset = "0x1A94130", VA = "0x1A94130", Slot = "29")]
		protected virtual bool SetPathfindingDestination(Vector3 target)
		{
			return default(bool);
		}

		[Token(Token = "0x600218C")]
		[Address(RVA = "0x1A94174", Offset = "0x1A94174", VA = "0x1A94174", Slot = "30")]
		protected virtual Vector3 Target()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600218D")]
		[Address(RVA = "0x1A941A0", Offset = "0x1A941A0", VA = "0x1A941A0", Slot = "31")]
		protected virtual bool HasArrived()
		{
			return default(bool);
		}

		[Token(Token = "0x600218E")]
		[Address(RVA = "0x1A92124", Offset = "0x1A92124", VA = "0x1A92124", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x600218F")]
		[Address(RVA = "0x1A9212C", Offset = "0x1A9212C", VA = "0x1A9212C", Slot = "14")]
		public override void OnReset()
		{
		}
	}
}
