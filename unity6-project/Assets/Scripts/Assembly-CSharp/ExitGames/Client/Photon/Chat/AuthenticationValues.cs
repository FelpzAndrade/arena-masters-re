using Il2CppDummyDll;

namespace ExitGames.Client.Photon.Chat
{
	[Token(Token = "0x200032F")]
	public class AuthenticationValues
	{
		[Token(Token = "0x40010B4")]
		[FieldOffset(Offset = "0x8")]
		private CustomAuthenticationType authType;

		[Token(Token = "0x40010B5")]
		[FieldOffset(Offset = "0xC")]
		private string AuthGetParameters__BackingField;

		[Token(Token = "0x40010B6")]
		[FieldOffset(Offset = "0x10")]
		private object AuthPostData__BackingField;

		[Token(Token = "0x40010B7")]
		[FieldOffset(Offset = "0x14")]
		private string Token__BackingField;

		[Token(Token = "0x40010B8")]
		[FieldOffset(Offset = "0x18")]
		private string UserId__BackingField;

		[Token(Token = "0x170004A6")]
		public CustomAuthenticationType AuthType
		{
			[Token(Token = "0x6001B3B")]
			[Address(RVA = "0x1E7662C", Offset = "0x1E7662C", VA = "0x1E7662C")]
			get
			{
				return default(CustomAuthenticationType);
			}
			[Token(Token = "0x6001B3C")]
			[Address(RVA = "0x1E76634", Offset = "0x1E76634", VA = "0x1E76634")]
			set
			{
			}
		}

		[Token(Token = "0x170004A7")]
		public string AuthGetParameters
		{
			[Token(Token = "0x6001B3D")]
			[Address(RVA = "0x1E7663C", Offset = "0x1E7663C", VA = "0x1E7663C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B3E")]
			[Address(RVA = "0x1E76644", Offset = "0x1E76644", VA = "0x1E76644")]
			set
			{
			}
		}

		[Token(Token = "0x170004A8")]
		public object AuthPostData
		{
			[Token(Token = "0x6001B3F")]
			[Address(RVA = "0x1E7664C", Offset = "0x1E7664C", VA = "0x1E7664C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B40")]
			[Address(RVA = "0x1E76654", Offset = "0x1E76654", VA = "0x1E76654")]
			private set
			{
			}
		}

		[Token(Token = "0x170004A9")]
		public string Token
		{
			[Token(Token = "0x6001B41")]
			[Address(RVA = "0x1E7665C", Offset = "0x1E7665C", VA = "0x1E7665C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B42")]
			[Address(RVA = "0x1E76664", Offset = "0x1E76664", VA = "0x1E76664")]
			set
			{
			}
		}

		[Token(Token = "0x170004AA")]
		public string UserId
		{
			[Token(Token = "0x6001B43")]
			[Address(RVA = "0x1E7666C", Offset = "0x1E7666C", VA = "0x1E7666C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B44")]
			[Address(RVA = "0x1E76624", Offset = "0x1E76624", VA = "0x1E76624")]
			set
			{
			}
		}

		[Token(Token = "0x6001B39")]
		[Address(RVA = "0x1E765E8", Offset = "0x1E765E8", VA = "0x1E765E8")]
		public AuthenticationValues()
		{
		}

		[Token(Token = "0x6001B3A")]
		[Address(RVA = "0x1E765F8", Offset = "0x1E765F8", VA = "0x1E765F8")]
		public AuthenticationValues(string userId)
		{
		}

		[Token(Token = "0x6001B45")]
		[Address(RVA = "0x1E76674", Offset = "0x1E76674", VA = "0x1E76674", Slot = "4")]
		public virtual void SetAuthPostData(string stringData)
		{
		}

		[Token(Token = "0x6001B46")]
		[Address(RVA = "0x1E76740", Offset = "0x1E76740", VA = "0x1E76740", Slot = "5")]
		public virtual void SetAuthPostData(byte[] byteData)
		{
		}

		[Token(Token = "0x6001B47")]
		[Address(RVA = "0x1E76748", Offset = "0x1E76748", VA = "0x1E76748", Slot = "6")]
		public virtual void AddAuthParameter(string key, string value)
		{
		}

		[Token(Token = "0x6001B48")]
		[Address(RVA = "0x1E76A80", Offset = "0x1E76A80", VA = "0x1E76A80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
