using Il2CppDummyDll;

[Token(Token = "0x200031A")]
public interface IPunTurnManagerCallbacks
{
	[Token(Token = "0x6001AA5")]
	void OnTurnBegins(int turn);

	[Token(Token = "0x6001AA6")]
	void OnTurnCompleted(int turn);

	[Token(Token = "0x6001AA7")]
	void OnPlayerMove(PhotonPlayer player, int turn, object move);

	[Token(Token = "0x6001AA8")]
	void OnPlayerFinished(PhotonPlayer player, int turn, object move);

	[Token(Token = "0x6001AA9")]
	void OnTurnTimeEnds(int turn);
}
