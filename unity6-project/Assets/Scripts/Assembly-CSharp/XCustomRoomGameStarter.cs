using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x20004CF")]
public class XCustomRoomGameStarter : XPVPGameStarter
{
	[Token(Token = "0x4001839")]
	[FieldOffset(Offset = "0x18")]
	private CustomRoomInfo RoomInfo__BackingField;

	[Token(Token = "0x400183A")]
	[FieldOffset(Offset = "0x1C")]
	private Action<Action> ActionMissionReward__BackingField;

	[Token(Token = "0x1700067A")]
	public CustomRoomInfo RoomInfo
	{
		[Token(Token = "0x6002936")]
		[Address(RVA = "0x19A5DC0", Offset = "0x19A5DC0", VA = "0x19A5DC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002937")]
		[Address(RVA = "0x19A5DB0", Offset = "0x19A5DB0", VA = "0x19A5DB0")]
		private set
		{
		}
	}

	[Token(Token = "0x1700067B")]
	public Action<Action> ActionMissionReward
	{
		[Token(Token = "0x6002938")]
		[Address(RVA = "0x19A5DC8", Offset = "0x19A5DC8", VA = "0x19A5DC8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002939")]
		[Address(RVA = "0x19A5DB8", Offset = "0x19A5DB8", VA = "0x19A5DB8")]
		private set
		{
		}
	}

	[Token(Token = "0x6002935")]
	[Address(RVA = "0x19A5D70", Offset = "0x19A5D70", VA = "0x19A5D70")]
	public XCustomRoomGameStarter(CustomRoomInfo roomInfo, bool preGameContinue = false)
	{
	}

	[Token(Token = "0x600293A")]
	[Address(RVA = "0x19A5DD0", Offset = "0x19A5DD0", VA = "0x19A5DD0")]
	public bool BuildGameData()
	{
		return default(bool);
	}

	[Token(Token = "0x600293B")]
	[Address(RVA = "0x19A5F28", Offset = "0x19A5F28", VA = "0x19A5F28", Slot = "5")]
	public override bool Start()
	{
		return default(bool);
	}

	[Token(Token = "0x600293C")]
	[Address(RVA = "0x19A68E4", Offset = "0x19A68E4", VA = "0x19A68E4")]
	public void GetMissionRewardAfterStartGame()
	{
	}

	[Token(Token = "0x600293D")]
	[Address(RVA = "0x19A6064", Offset = "0x19A6064", VA = "0x19A6064")]
	private bool CheckStartGame()
	{
		return default(bool);
	}

	[Token(Token = "0x600293E")]
	[Address(RVA = "0x19A69F4", Offset = "0x19A69F4", VA = "0x19A69F4")]
	public GameModeInstanceInfo GetGameModeInstanceInfo()
	{
		return null;
	}

	[Token(Token = "0x600293F")]
	[Address(RVA = "0x19A66BC", Offset = "0x19A66BC", VA = "0x19A66BC")]
	private bool StartGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6002940")]
	[Address(RVA = "0x19A6A04", Offset = "0x19A6A04", VA = "0x19A6A04", Slot = "7")]
	protected override void DoEnterDungeon(JObject jsonData, int eloPt, GameModeInstanceInfo currentGameModeInstanceInfo, bool _preGameContinue, Action onStartFail)
	{
	}

	[Token(Token = "0x6002941")]
	[Address(RVA = "0x19A6F6C", Offset = "0x19A6F6C", VA = "0x19A6F6C")]
	private bool InGameRoomEnter(int eloPt, GameModeInstanceInfo gameModeInstanceInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6002942")]
	[Address(RVA = "0x19A7328", Offset = "0x19A7328", VA = "0x19A7328")]
	private bool CreateCustomGameRoom()
	{
		return default(bool);
	}

	[Token(Token = "0x6002943")]
	[Address(RVA = "0x19A74F4", Offset = "0x19A74F4", VA = "0x19A74F4")]
	private bool JoinCustomGameRoom()
	{
		return default(bool);
	}

	[Token(Token = "0x6002944")]
	[Address(RVA = "0x19A71B8", Offset = "0x19A71B8", VA = "0x19A71B8")]
	private bool PreGameContinue(string gameId)
	{
		return default(bool);
	}

	[Token(Token = "0x6002945")]
	[Address(RVA = "0x19A708C", Offset = "0x19A708C", VA = "0x19A708C")]
	public void OnGameStartFail()
	{
	}

	[Token(Token = "0x6002946")]
	[Address(RVA = "0x19A7670", Offset = "0x19A7670", VA = "0x19A7670")]
	internal void SetMissionRewsrdCallback(Action<Action> acMissionReward)
	{
	}

	[Token(Token = "0x6002947")]
	[Address(RVA = "0x19A7678", Offset = "0x19A7678", VA = "0x19A7678")]
	private void _003CCheckStartGame_003Em__F5()
	{
	}
}
