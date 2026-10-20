using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace XBehavior
{
	[Token(Token = "0x200041B")]
	public class GotoPlayerBehind : XMovement
	{
		[Token(Token = "0x4001449")]
		[FieldOffset(Offset = "0x38")]
		private bool m_start;

		[Token(Token = "0x400144A")]
		[FieldOffset(Offset = "0x39")]
		private bool m_arrived;

		[Token(Token = "0x400144B")]
		[FieldOffset(Offset = "0x3C")]
		private GameObject m_player;

		[Token(Token = "0x400144C")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 m_pos;

		[Token(Token = "0x6002165")]
		[Address(RVA = "0x1F0145C", Offset = "0x1F0145C", VA = "0x1F0145C")]
		public GotoPlayerBehind()
		{
		}

		[Token(Token = "0x6002166")]
		[Address(RVA = "0x1F014A0", Offset = "0x1F014A0", VA = "0x1F014A0", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6002167")]
		[Address(RVA = "0x1F015EC", Offset = "0x1F015EC", VA = "0x1F015EC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6002168")]
		[Address(RVA = "0x1F01880", Offset = "0x1F01880", VA = "0x1F01880", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x6002169")]
		[Address(RVA = "0x1F018C8", Offset = "0x1F018C8", VA = "0x1F018C8", Slot = "14")]
		public override void OnReset()
		{
		}
	}
}
