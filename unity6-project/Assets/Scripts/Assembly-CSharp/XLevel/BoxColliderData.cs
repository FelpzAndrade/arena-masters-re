using System;
using Il2CppDummyDll;

namespace XLevel
{
	[Serializable]
	[Token(Token = "0x2000709")]
	public class BoxColliderData : ColliderData
	{
		[Token(Token = "0x400217D")]
		[FieldOffset(Offset = "0x14")]
		public XVector size;

		[Token(Token = "0x6003A8D")]
		[Address(RVA = "0x1D40200", Offset = "0x1D40200", VA = "0x1D40200")]
		public BoxColliderData()
		{
		}
	}
}
