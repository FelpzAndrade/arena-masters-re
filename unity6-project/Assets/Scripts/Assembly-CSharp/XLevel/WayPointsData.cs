using Il2CppDummyDll;
using UnityEngine;

namespace XLevel
{
	[Token(Token = "0x2000753")]
	public class WayPointsData
	{
		[Token(Token = "0x400229F")]
		[FieldOffset(Offset = "0x8")]
		public XVector rootPosition;

		[Token(Token = "0x40022A0")]
		[FieldOffset(Offset = "0x14")]
		public XVector[] points;

		[Token(Token = "0x6003BD0")]
		[Address(RVA = "0x201FBD0", Offset = "0x201FBD0", VA = "0x201FBD0")]
		public WayPointsData()
		{
		}

		[Token(Token = "0x6003BD1")]
		[Address(RVA = "0x201FBD8", Offset = "0x201FBD8", VA = "0x201FBD8")]
		public void ToComponent(Transform parent)
		{
		}
	}
}
