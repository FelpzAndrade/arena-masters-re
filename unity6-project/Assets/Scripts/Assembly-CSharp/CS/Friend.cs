using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008F8")]
	public class Friend : UserMetaData
	{
		[Token(Token = "0x4002B62")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string AddFriendKey;

		[Token(Token = "0x4002B63")]
		[FieldOffset(Offset = "0x48")]
		private int FriendPointCooltime__BackingField;

		[Token(Token = "0x170009AC")]
		public int FriendPointCooltime
		{
			[Token(Token = "0x60047EB")]
			[Address(RVA = "0x2333A98", Offset = "0x2333A98", VA = "0x2333A98")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60047EC")]
			[Address(RVA = "0x2333AA0", Offset = "0x2333AA0", VA = "0x2333AA0")]
			set
			{
			}
		}

		[Token(Token = "0x60047E9")]
		[Address(RVA = "0x2333A08", Offset = "0x2333A08", VA = "0x2333A08")]
		public Friend()
		{
		}
	}
}
