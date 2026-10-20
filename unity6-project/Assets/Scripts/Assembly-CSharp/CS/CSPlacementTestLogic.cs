using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000909")]
	public class CSPlacementTestLogic : IPlacementTestLogic
	{
		[Token(Token = "0x600485F")]
		[Address(RVA = "0x1FC028C", Offset = "0x1FC028C", VA = "0x1FC028C")]
		public CSPlacementTestLogic()
		{
		}

		[Token(Token = "0x6004860")]
		[Address(RVA = "0x1FC0294", Offset = "0x1FC0294", VA = "0x1FC0294", Slot = "4")]
		public bool IsPlacementTesting(PlacementTestInfo ptInfo, RankType rankType)
		{
			return default(bool);
		}

		[Token(Token = "0x6004861")]
		[Address(RVA = "0x1FC02A8", Offset = "0x1FC02A8", VA = "0x1FC02A8", Slot = "5")]
		public bool IsPtEnd(PlacementTestInfo ptInfo, RankType rankType)
		{
			return default(bool);
		}

		[Token(Token = "0x6004862")]
		[Address(RVA = "0x1FC03B8", Offset = "0x1FC03B8", VA = "0x1FC03B8", Slot = "6")]
		public bool TryGetPlayCount(PlacementTestInfo ptInfo, RankType rankType, out int count)
		{
			count = default;
			return default(bool);
		}

		[Token(Token = "0x6004863")]
		[Address(RVA = "0x1FC03A4", Offset = "0x1FC03A4", VA = "0x1FC03A4")]
		protected bool IsPlacementTestGame(PlacementTestInfo ptInfo, RankType rankType)
		{
			return default(bool);
		}
	}
}
