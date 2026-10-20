using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000ACC")]
	public sealed class EventGameModeXML
	{
		[Token(Token = "0x40032A8")]
		[FieldOffset(Offset = "0x8")]
		public List<EventGameModeInfo> dataList;

		[Token(Token = "0x6004F31")]
		[Address(RVA = "0x1CDF410", Offset = "0x1CDF410", VA = "0x1CDF410")]
		public EventGameModeXML()
		{
		}

		[Token(Token = "0x6004F32")]
		[Address(RVA = "0x1CDF4BC", Offset = "0x1CDF4BC", VA = "0x1CDF4BC")]
		public void Add(EventGameModeInfo i)
		{
		}
	}
}
