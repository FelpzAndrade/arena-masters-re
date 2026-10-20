using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AEA")]
	public sealed class GameModeInfoXML
	{
		[Token(Token = "0x4003535")]
		[FieldOffset(Offset = "0x8")]
		public List<GameModeInfo> dataList;

		[Token(Token = "0x600508C")]
		[Address(RVA = "0x23356A8", Offset = "0x23356A8", VA = "0x23356A8")]
		public GameModeInfoXML()
		{
		}

		[Token(Token = "0x600508D")]
		[Address(RVA = "0x2335754", Offset = "0x2335754", VA = "0x2335754")]
		public void Add(GameModeInfo i)
		{
		}
	}
}
