using System.Collections.Generic;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using XLevel;

namespace XBehavior
{
	[Token(Token = "0x2000416")]
	public class AlongWayPoints : XMovement
	{
		[Token(Token = "0x4001439")]
		[FieldOffset(Offset = "0x38")]
		private List<Vector3> m_wayPoints;

		[Token(Token = "0x400143A")]
		[FieldOffset(Offset = "0x3C")]
		private XWayPointCalculator m_wpCalc;

		[Token(Token = "0x400143B")]
		[FieldOffset(Offset = "0x40")]
		private int m_index;

		[Token(Token = "0x400143C")]
		[FieldOffset(Offset = "0x44")]
		private int m_startIndex;

		[Token(Token = "0x6002146")]
		[Address(RVA = "0x1EFF948", Offset = "0x1EFF948", VA = "0x1EFF948")]
		public AlongWayPoints()
		{
		}

		[Token(Token = "0x6002147")]
		[Address(RVA = "0x1EFF950", Offset = "0x1EFF950", VA = "0x1EFF950", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6002148")]
		[Address(RVA = "0x1EFFBC4", Offset = "0x1EFFBC4", VA = "0x1EFFBC4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}

		[Token(Token = "0x6002149")]
		[Address(RVA = "0x1EFFDD0", Offset = "0x1EFFDD0", VA = "0x1EFFDD0")]
		public void SetDirectDestination(Vector3 target)
		{
		}

		[Token(Token = "0x600214A")]
		[Address(RVA = "0x1EFFE10", Offset = "0x1EFFE10", VA = "0x1EFFE10", Slot = "30")]
		protected override Vector3 Target()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600214B")]
		[Address(RVA = "0x1EFFF18", Offset = "0x1EFFF18", VA = "0x1EFFF18", Slot = "9")]
		public override void OnEnd()
		{
		}

		[Token(Token = "0x600214C")]
		[Address(RVA = "0x1EFFF60", Offset = "0x1EFFF60", VA = "0x1EFFF60", Slot = "14")]
		public override void OnReset()
		{
		}
	}
}
