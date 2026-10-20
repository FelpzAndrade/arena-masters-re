using Il2CppDummyDll;

namespace ExitGames.Client.Photon.Chat
{
	[Token(Token = "0x200032E")]
	public enum CustomAuthenticationType : byte
	{
		[Token(Token = "0x40010AD")]
		Custom = 0,
		[Token(Token = "0x40010AE")]
		Steam = 1,
		[Token(Token = "0x40010AF")]
		Facebook = 2,
		[Token(Token = "0x40010B0")]
		Oculus = 3,
		[Token(Token = "0x40010B1")]
		PlayStation = 4,
		[Token(Token = "0x40010B2")]
		Xbox = 5,
		[Token(Token = "0x40010B3")]
		None = byte.MaxValue
	}
}
