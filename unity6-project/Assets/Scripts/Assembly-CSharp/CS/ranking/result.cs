using Il2CppDummyDll;

namespace CS.ranking
{
	[Token(Token = "0x2000A1B")]
	public struct result
	{
		[Token(Token = "0x2000A1C")]
		public enum code
		{
			[Token(Token = "0x4002FE0")]
			failed_to_paid_reward = 0,
			[Token(Token = "0x4002FE1")]
			reward_not_exist = 1,
			[Token(Token = "0x4002FE2")]
			already_paid_reward = 2
		}
	}
}
