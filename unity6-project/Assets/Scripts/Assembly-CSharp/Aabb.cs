using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CB4")]
public struct Aabb
{
	[Token(Token = "0x40040A9")]
	[FieldOffset(Offset = "0x0")]
	public Vector2 min;

	[Token(Token = "0x40040AA")]
	[FieldOffset(Offset = "0x8")]
	public Vector2 max;

	[Token(Token = "0x6005BA3")]
	[Address(RVA = "0x20B3EC4", Offset = "0x20B3EC4", VA = "0x20B3EC4")]
	public static bool AabbAabbIntersection(Aabb a, Aabb b)
	{
		return default(bool);
	}
}
