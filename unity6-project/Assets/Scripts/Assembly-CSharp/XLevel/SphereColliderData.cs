using System;
using Il2CppDummyDll;

namespace XLevel
{
	[Serializable]
	[Token(Token = "0x200070A")]
	public class SphereColliderData : ColliderData
	{
		[Token(Token = "0x400217E")]
		[FieldOffset(Offset = "0x14")]
		public float radius;

		[Token(Token = "0x6003A8E")]
		[Address(RVA = "0x201F84C", Offset = "0x201F84C", VA = "0x201F84C")]
		public SphereColliderData()
		{
		}
	}
}
