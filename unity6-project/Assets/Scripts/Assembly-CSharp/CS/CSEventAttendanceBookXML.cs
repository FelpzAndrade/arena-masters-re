using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AC8")]
	public sealed class CSEventAttendanceBookXML
	{
		[Token(Token = "0x4003295")]
		[FieldOffset(Offset = "0x8")]
		public List<CSEventAttendanceBookItem> dataList;

		[Token(Token = "0x6004F1A")]
		[Address(RVA = "0x222C4FC", Offset = "0x222C4FC", VA = "0x222C4FC")]
		public CSEventAttendanceBookXML()
		{
		}

		[Token(Token = "0x6004F1B")]
		[Address(RVA = "0x222C5A8", Offset = "0x222C5A8", VA = "0x222C5A8")]
		public void Add(CSEventAttendanceBookItem i)
		{
		}
	}
}
