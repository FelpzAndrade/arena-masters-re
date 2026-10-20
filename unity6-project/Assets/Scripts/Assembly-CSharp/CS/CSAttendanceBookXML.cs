using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000A80")]
	public sealed class CSAttendanceBookXML
	{
		[Token(Token = "0x40030B9")]
		[FieldOffset(Offset = "0x8")]
		public List<CSAttendanceBookItem> dataList;

		[Token(Token = "0x6004DFC")]
		[Address(RVA = "0x23EEFA0", Offset = "0x23EEFA0", VA = "0x23EEFA0")]
		public CSAttendanceBookXML()
		{
		}

		[Token(Token = "0x6004DFD")]
		[Address(RVA = "0x23EF04C", Offset = "0x23EF04C", VA = "0x23EF04C")]
		public void Add(CSAttendanceBookItem i)
		{
		}
	}
}
