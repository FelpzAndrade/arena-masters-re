using Il2CppDummyDll;

[Token(Token = "0x20008E3")]
public interface IRegulator
{
	[Token(Token = "0x6004751")]
	void Start();

	[Token(Token = "0x6004752")]
	void Stop();

	[Token(Token = "0x6004753")]
	void Reset();

	[Token(Token = "0x6004754")]
	void Restart();

	[Token(Token = "0x6004755")]
	bool IsUpdate();

	[Token(Token = "0x6004756")]
	bool IsRunning();
}
