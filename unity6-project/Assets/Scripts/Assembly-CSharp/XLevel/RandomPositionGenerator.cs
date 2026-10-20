using System.Collections.Generic;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x2000747")]
	public class RandomPositionGenerator
	{
		[Token(Token = "0x400228A")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<string, XRandomPosInCircle> m_ranomPosInCircles;

		[Token(Token = "0x6003B99")]
		[Address(RVA = "0x201EF8C", Offset = "0x201EF8C", VA = "0x201EF8C")]
		public RandomPositionGenerator(List<RandomPositionData> data)
		{
		}

		[Token(Token = "0x6003B9A")]
		[Address(RVA = "0x201F048", Offset = "0x201F048", VA = "0x201F048")]
		private void LoadRandomPositions(List<RandomPositionData> randomPositions)
		{
		}

		[Token(Token = "0x6003B9B")]
		[Address(RVA = "0x201F478", Offset = "0x201F478", VA = "0x201F478")]
		public XVector GetPosition(string group)
		{
			return default(XVector);
		}
	}
}
