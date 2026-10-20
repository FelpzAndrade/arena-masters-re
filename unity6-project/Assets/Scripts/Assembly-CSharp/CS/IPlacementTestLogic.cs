using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000908")]
	public interface IPlacementTestLogic
	{
		[Token(Token = "0x600485C")]
		bool IsPlacementTesting(PlacementTestInfo ptInfo, RankType rankType);

		[Token(Token = "0x600485D")]
		bool IsPtEnd(PlacementTestInfo ptInfo, RankType rankType);

		[Token(Token = "0x600485E")]
		bool TryGetPlayCount(PlacementTestInfo ptInfo, RankType rankType, out int count);
	}
}
