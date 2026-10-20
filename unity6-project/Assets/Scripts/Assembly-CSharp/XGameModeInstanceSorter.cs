using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000FB2")]
public class XGameModeInstanceSorter
{
	[Token(Token = "0x2000FB3")]
	private sealed class _003CGetSortGameModeInfos_003Ec__AnonStorey243
	{
		[Token(Token = "0x400533D")]
		[FieldOffset(Offset = "0x8")]
		internal XGameModeType firstShowType;

		[Token(Token = "0x60074D8")]
		[Address(RVA = "0x140ABE4", Offset = "0x140ABE4", VA = "0x140ABE4")]
		public _003CGetSortGameModeInfos_003Ec__AnonStorey243()
		{
		}

		[Token(Token = "0x60074D9")]
		[Address(RVA = "0x140AC5C", Offset = "0x140AC5C", VA = "0x140AC5C")]
		internal bool _003C_003Em__4C8(GameModeInstanceInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400533C")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<GameModeInstanceInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60074D5")]
	[Address(RVA = "0x140A908", Offset = "0x140A908", VA = "0x140A908")]
	public XGameModeInstanceSorter()
	{
	}

	[Token(Token = "0x60074D6")]
	[Address(RVA = "0x140A910", Offset = "0x140A910", VA = "0x140A910")]
	public List<GameModeInstanceInfo> GetSortGameModeInfos(List<GameModeInstanceInfo> originList, XGameModeType firstShowType = XGameModeType.NA)
	{
		return null;
	}

	[Token(Token = "0x60074D7")]
	[Address(RVA = "0x140ABEC", Offset = "0x140ABEC", VA = "0x140ABEC")]
	private static int _003CGetSortGameModeInfos_003Em__4C7(GameModeInstanceInfo x, GameModeInstanceInfo y)
	{
		return default(int);
	}
}
