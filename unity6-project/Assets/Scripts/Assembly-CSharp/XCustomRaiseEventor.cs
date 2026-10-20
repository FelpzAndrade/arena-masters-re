using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200083E")]
public class XCustomRaiseEventor
{
	[Token(Token = "0x60041FD")]
	[Address(RVA = "0x19A2954", Offset = "0x19A2954", VA = "0x19A2954")]
	public XCustomRaiseEventor()
	{
	}

	[Token(Token = "0x60041FE")]
	[Address(RVA = "0x19874A8", Offset = "0x19874A8", VA = "0x19874A8")]
	public static void InGameStart(List<string> liPlayersAID, NetData_PlayerTeamSetting teamInfo)
	{
	}

	[Token(Token = "0x60041FF")]
	[Address(RVA = "0x19A295C", Offset = "0x19A295C", VA = "0x19A295C")]
	public static void InGameHit(string attacker)
	{
	}

	[Token(Token = "0x6004200")]
	[Address(RVA = "0x19A2B58", Offset = "0x19A2B58", VA = "0x19A2B58")]
	public static void InGameGetBox(string actor)
	{
	}

	[Token(Token = "0x6004201")]
	[Address(RVA = "0x198904C", Offset = "0x198904C", VA = "0x198904C")]
	public static void InGameKillAndDie(string killer, string dead)
	{
	}

	[Token(Token = "0x6004202")]
	[Address(RVA = "0x19A2D54", Offset = "0x19A2D54", VA = "0x19A2D54")]
	public static void InGameAssist(string assister)
	{
	}

	[Token(Token = "0x6004203")]
	[Address(RVA = "0x19A2F50", Offset = "0x19A2F50", VA = "0x19A2F50")]
	public static void InGameKillZombie(string killer)
	{
	}

	[Token(Token = "0x6004204")]
	[Address(RVA = "0x19A314C", Offset = "0x19A314C", VA = "0x19A314C")]
	public static void InGameTagZombieToHuman(string playerName)
	{
	}

	[Token(Token = "0x6004205")]
	[Address(RVA = "0x19A3348", Offset = "0x19A3348", VA = "0x19A3348")]
	public static void InGameZombieInfect(string playerName)
	{
	}

	[Token(Token = "0x6004206")]
	[Address(RVA = "0x19A3544", Offset = "0x19A3544", VA = "0x19A3544")]
	public static void InGameStayAsHuman(List<string> playerNames)
	{
	}

	[Token(Token = "0x6004207")]
	[Address(RVA = "0x1989260", Offset = "0x1989260", VA = "0x1989260")]
	public static void InGameChangePlayerState(string playerName, CSPlayerState playerState)
	{
	}

	[Token(Token = "0x6004208")]
	[Address(RVA = "0x19A376C", Offset = "0x19A376C", VA = "0x19A376C")]
	internal static void GetAllPlayerRecord(int _targetPhotonID)
	{
	}

	[Token(Token = "0x6004209")]
	[Address(RVA = "0x19A398C", Offset = "0x19A398C", VA = "0x19A398C")]
	internal static void SetEscapeStatePlayer(string playerName, bool _escape)
	{
	}

	[Token(Token = "0x600420A")]
	[Address(RVA = "0x19A3BF4", Offset = "0x19A3BF4", VA = "0x19A3BF4")]
	internal static void InitSpeedHackCheck(string playerName)
	{
	}

	[Token(Token = "0x600420B")]
	[Address(RVA = "0x19A3EA8", Offset = "0x19A3EA8", VA = "0x19A3EA8")]
	internal static void SpeedHackCheck(string playerName, int actorNum, int timeStamp, int avgPing)
	{
	}

	[Token(Token = "0x600420C")]
	[Address(RVA = "0x19A4134", Offset = "0x19A4134", VA = "0x19A4134")]
	public static void InGameHpSync(string actor, short hpRatio)
	{
	}

	[Token(Token = "0x600420D")]
	[Address(RVA = "0x19A4364", Offset = "0x19A4364", VA = "0x19A4364")]
	public static void WebHttpInGameFinish(XGameMode gameMode, RoomType roomType)
	{
	}

	[Token(Token = "0x600420E")]
	[Address(RVA = "0x19A4B88", Offset = "0x19A4B88", VA = "0x19A4B88")]
	internal static void InGameKickPlayer(string kickPlayerName)
	{
	}

	[Token(Token = "0x600420F")]
	[Address(RVA = "0x19A4FD4", Offset = "0x19A4FD4", VA = "0x19A4FD4")]
	internal static void InGameBanPlayer(string kickPlayerName)
	{
	}

	[Token(Token = "0x6004210")]
	[Address(RVA = "0x19A5420", Offset = "0x19A5420", VA = "0x19A5420")]
	internal static void GamePlayRoundResult(int roundIndex, XTeamEnum winTeam)
	{
	}

	[Token(Token = "0x6004211")]
	[Address(RVA = "0x19A56A4", Offset = "0x19A56A4", VA = "0x19A56A4")]
	public static void FinishExitDuringTheGame(XGameMode gameMode, RoomType roomType, int Rank)
	{
	}
}
