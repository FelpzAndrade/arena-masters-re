using System.Collections.Generic;
using ExitGames.Client.Photon;
using Il2CppDummyDll;
using Photon;

[Token(Token = "0x2000319")]
public class PunTurnManager : PunBehaviour
{
	[Token(Token = "0x400103F")]
	public const byte TurnManagerEventOffset = 0;

	[Token(Token = "0x4001040")]
	public const byte EvMove = 1;

	[Token(Token = "0x4001041")]
	public const byte EvFinalMove = 2;

	[Token(Token = "0x4001042")]
	[FieldOffset(Offset = "0x10")]
	public float TurnDuration;

	[Token(Token = "0x4001043")]
	[FieldOffset(Offset = "0x14")]
	public IPunTurnManagerCallbacks TurnManagerListener;

	[Token(Token = "0x4001044")]
	[FieldOffset(Offset = "0x18")]
	private readonly HashSet<PhotonPlayer> finishedPlayers;

	[Token(Token = "0x4001045")]
	[FieldOffset(Offset = "0x1C")]
	private bool _isOverCallProcessed;

	[Token(Token = "0x1700048A")]
	public int Turn
	{
		[Token(Token = "0x6001A97")]
		[Address(RVA = "0x20E881C", Offset = "0x20E881C", VA = "0x20E881C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001A98")]
		[Address(RVA = "0x20E8908", Offset = "0x20E8908", VA = "0x20E8908")]
		private set
		{
		}
	}

	[Token(Token = "0x1700048B")]
	public float ElapsedTimeInTurn
	{
		[Token(Token = "0x6001A99")]
		[Address(RVA = "0x20E8A18", Offset = "0x20E8A18", VA = "0x20E8A18")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700048C")]
	public float RemainingSecondsInTurn
	{
		[Token(Token = "0x6001A9A")]
		[Address(RVA = "0x20E8B30", Offset = "0x20E8B30", VA = "0x20E8B30")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700048D")]
	public bool IsCompletedByAll
	{
		[Token(Token = "0x6001A9B")]
		[Address(RVA = "0x20E8BF8", Offset = "0x20E8BF8", VA = "0x20E8BF8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700048E")]
	public bool IsFinishedByMe
	{
		[Token(Token = "0x6001A9C")]
		[Address(RVA = "0x20E8E40", Offset = "0x20E8E40", VA = "0x20E8E40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700048F")]
	public bool IsOver
	{
		[Token(Token = "0x6001A9D")]
		[Address(RVA = "0x20E8F24", Offset = "0x20E8F24", VA = "0x20E8F24")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001A96")]
	[Address(RVA = "0x20E8764", Offset = "0x20E8764", VA = "0x20E8764")]
	public PunTurnManager()
	{
	}

	[Token(Token = "0x6001A9E")]
	[Address(RVA = "0x20E8F48", Offset = "0x20E8F48", VA = "0x20E8F48")]
	private void Start()
	{
	}

	[Token(Token = "0x6001A9F")]
	[Address(RVA = "0x20E9034", Offset = "0x20E9034", VA = "0x20E9034")]
	private void Update()
	{
	}

	[Token(Token = "0x6001AA0")]
	[Address(RVA = "0x20E9184", Offset = "0x20E9184", VA = "0x20E9184")]
	public void BeginTurn()
	{
	}

	[Token(Token = "0x6001AA1")]
	[Address(RVA = "0x20E91A4", Offset = "0x20E91A4", VA = "0x20E91A4")]
	public void SendMove(object move, bool finished)
	{
	}

	[Token(Token = "0x6001AA2")]
	[Address(RVA = "0x20E990C", Offset = "0x20E990C", VA = "0x20E990C")]
	public bool GetPlayerFinishedTurn(PhotonPlayer player)
	{
		return default(bool);
	}

	[Token(Token = "0x6001AA3")]
	[Address(RVA = "0x20E94E0", Offset = "0x20E94E0", VA = "0x20E94E0")]
	public void OnEvent(byte eventCode, object content, int senderId)
	{
	}

	[Token(Token = "0x6001AA4")]
	[Address(RVA = "0x20E99BC", Offset = "0x20E99BC", VA = "0x20E99BC", Slot = "52")]
	public override void OnPhotonCustomRoomPropertiesChanged(Hashtable propertiesThatChanged)
	{
	}
}
