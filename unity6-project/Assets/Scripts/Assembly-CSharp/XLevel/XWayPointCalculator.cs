using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace XLevel
{
	[Token(Token = "0x2000751")]
	public class XWayPointCalculator
	{
		[Token(Token = "0x400229E")]
		[FieldOffset(Offset = "0x8")]
		private List<Vector2> m_wayPoints;

		[Token(Token = "0x6003BC8")]
		[Address(RVA = "0x2033974", Offset = "0x2033974", VA = "0x2033974")]
		public XWayPointCalculator(List<Vector3> wayPoints)
		{
		}

		[Token(Token = "0x6003BC9")]
		[Address(RVA = "0x2033AFC", Offset = "0x2033AFC", VA = "0x2033AFC")]
		public XWayPointCalculator(XVector[] wayPoints)
		{
		}

		[Token(Token = "0x6003BCA")]
		[Address(RVA = "0x2033C48", Offset = "0x2033C48", VA = "0x2033C48")]
		public Vector3? GetPoint(int index, float yPos)
		{
			return null;
		}

		[Token(Token = "0x6003BCB")]
		[Address(RVA = "0x2033DF0", Offset = "0x2033DF0", VA = "0x2033DF0")]
		public int GetNextWayPointIndex(Vector3 point)
		{
			return default(int);
		}

		[Token(Token = "0x6003BCC")]
		[Address(RVA = "0x2034350", Offset = "0x2034350", VA = "0x2034350")]
		public Vector3 GetNextWayPoint(Vector3 point)
		{
			return default(Vector3);
		}
	}
}
