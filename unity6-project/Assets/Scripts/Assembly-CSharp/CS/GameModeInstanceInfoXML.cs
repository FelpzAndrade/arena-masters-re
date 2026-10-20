using System;
using System.Collections;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AED")]
	public sealed class GameModeInstanceInfoXML
	{
		[Token(Token = "0x400359A")]
		[FieldOffset(Offset = "0x8")]
		public ArrayList dataList;

		[Token(Token = "0x60050B1")]
		[Address(RVA = "0x23364F4", Offset = "0x23364F4", VA = "0x23364F4")]
		public GameModeInstanceInfoXML()
		{
		}

		[Token(Token = "0x60050B2")]
		[Address(RVA = "0x2336590", Offset = "0x2336590", VA = "0x2336590")]
		public void Add(GameModeInstanceInfo i)
		{
		}
	}
}
