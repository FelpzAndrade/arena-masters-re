using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20006AC")]
public static class XExtraCharHelper
{
	[Token(Token = "0x4002040")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024mapC;

	[Token(Token = "0x6003800")]
	[Address(RVA = "0x19AF388", Offset = "0x19AF388", VA = "0x19AF388")]
	public static void AddExtraChar(GameModeInstanceInfo info, ref XModuleActor.CreationDesc desc)
	{
	}

	[Token(Token = "0x6003801")]
	[Address(RVA = "0x19AF540", Offset = "0x19AF540", VA = "0x19AF540")]
	private static Netdata_EquipedItem[] MakeEmptyItem()
	{
		return null;
	}

	[Token(Token = "0x6003802")]
	[Address(RVA = "0x19AF684", Offset = "0x19AF684", VA = "0x19AF684")]
	public static XModuleActor GetActor(List<XPlayer> players)
	{
		return null;
	}

	[Token(Token = "0x6003803")]
	[Address(RVA = "0x19AF808", Offset = "0x19AF808", VA = "0x19AF808")]
	public static XTeamEnum GetTeam(List<XPlayer> players)
	{
		return default(XTeamEnum);
	}

	[Token(Token = "0x6003804")]
	[Address(RVA = "0x19AF8CC", Offset = "0x19AF8CC", VA = "0x19AF8CC")]
	public static int WinDrawCount(List<XPlayer> players)
	{
		return default(int);
	}

	[Token(Token = "0x6003805")]
	[Address(RVA = "0x19AF9C0", Offset = "0x19AF9C0", VA = "0x19AF9C0")]
	public static int LoseDrawCount(List<XPlayer> players)
	{
		return default(int);
	}

	[Token(Token = "0x6003806")]
	public static T GameModeParamIntUsingGameMode<T>(GameModeInstanceInfo info)
	{
		return (T)default;
	}

	[Token(Token = "0x6003807")]
	[Address(RVA = "0x19AFAB4", Offset = "0x19AFAB4", VA = "0x19AFAB4")]
	public static bool TryGetTaggerBuffID_UsingGameModeParam(GameModeInstanceInfo info, int sectorID, out int buffID)
	{
		buffID = default;
		return default(bool);
	}

	[Token(Token = "0x6003808")]
	[Address(RVA = "0x19AFFC4", Offset = "0x19AFFC4", VA = "0x19AFFC4")]
	public static bool TryGetLevelData_UsingGameModeParam(GameModeInstanceInfo info, int sectorID, out int fieldLevel, out string levelData)
	{
		fieldLevel = default;
		levelData = default;
		return default(bool);
	}

	[Token(Token = "0x6003809")]
	[Address(RVA = "0x19B05F8", Offset = "0x19B05F8", VA = "0x19B05F8")]
	public static void AddRoundStartImmuneBuff(XModuleBuff buff)
	{
	}
}
