using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000941")]
public class PVPTutorialLogic
{
	[Token(Token = "0x600496C")]
	[Address(RVA = "0x20E9B48", Offset = "0x20E9B48", VA = "0x20E9B48")]
	public PVPTutorialLogic()
	{
	}

	[Token(Token = "0x600496D")]
	[Address(RVA = "0x20E9B50", Offset = "0x20E9B50", VA = "0x20E9B50")]
	public static bool IsTutorialApplyPlayable(UserDataBase userData, CSProtoInfoManager_GameConst gameConst)
	{
		return default(bool);
	}

	[Token(Token = "0x600496E")]
	[Address(RVA = "0x20E9B98", Offset = "0x20E9B98", VA = "0x20E9B98")]
	public static int GetTutorialApplyPlayCnt(UserDataBase userData)
	{
		return default(int);
	}

	[Token(Token = "0x600496F")]
	[Address(RVA = "0x20E9CDC", Offset = "0x20E9CDC", VA = "0x20E9CDC")]
	public static void GetTutorialAIPVPData(ProtoInfoManager_GameModeInstance protoModeinstance, int currentTutorialPlayCount, out GameModeInstanceInfo modeInfo, out int sectorID)
	{
		modeInfo = default;
		sectorID = default;
	}

	[Token(Token = "0x6004970")]
	[Address(RVA = "0x20E9E38", Offset = "0x20E9E38", VA = "0x20E9E38")]
	public static string GetTutorialAILevelData(UserDataBase userData)
	{
		return null;
	}
}
