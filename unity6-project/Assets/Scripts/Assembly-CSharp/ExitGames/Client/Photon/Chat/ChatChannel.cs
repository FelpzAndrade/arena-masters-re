using System.Collections.Generic;
using Il2CppDummyDll;

namespace ExitGames.Client.Photon.Chat
{
	[Token(Token = "0x2000327")]
	public class ChatChannel
	{
		[Token(Token = "0x4001063")]
		[FieldOffset(Offset = "0x8")]
		public readonly string Name;

		[Token(Token = "0x4001064")]
		[FieldOffset(Offset = "0xC")]
		public readonly List<string> Senders;

		[Token(Token = "0x4001065")]
		[FieldOffset(Offset = "0x10")]
		public readonly List<object> Messages;

		[Token(Token = "0x4001066")]
		[FieldOffset(Offset = "0x14")]
		public int MessageLimit;

		[Token(Token = "0x4001067")]
		[FieldOffset(Offset = "0x18")]
		private bool IsPrivate__BackingField;

		[Token(Token = "0x17000493")]
		public bool IsPrivate
		{
			[Token(Token = "0x6001AE4")]
			[Address(RVA = "0x1E76C74", Offset = "0x1E76C74", VA = "0x1E76C74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001AE5")]
			[Address(RVA = "0x1E76C7C", Offset = "0x1E76C7C", VA = "0x1E76C7C")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x17000494")]
		public int MessageCount
		{
			[Token(Token = "0x6001AE6")]
			[Address(RVA = "0x1E76C84", Offset = "0x1E76C84", VA = "0x1E76C84")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6001AE3")]
		[Address(RVA = "0x1E76B8C", Offset = "0x1E76B8C", VA = "0x1E76B8C")]
		public ChatChannel(string name)
		{
		}

		[Token(Token = "0x6001AE7")]
		[Address(RVA = "0x1E76D1C", Offset = "0x1E76D1C", VA = "0x1E76D1C")]
		public void Add(string sender, object message)
		{
		}

		[Token(Token = "0x6001AE8")]
		[Address(RVA = "0x1E76F44", Offset = "0x1E76F44", VA = "0x1E76F44")]
		public void Add(string[] senders, object[] messages)
		{
		}

		[Token(Token = "0x6001AE9")]
		[Address(RVA = "0x1E76DF8", Offset = "0x1E76DF8", VA = "0x1E76DF8")]
		public void TruncateMessages()
		{
		}

		[Token(Token = "0x6001AEA")]
		[Address(RVA = "0x1E77020", Offset = "0x1E77020", VA = "0x1E77020")]
		public void ClearMessages()
		{
		}

		[Token(Token = "0x6001AEB")]
		[Address(RVA = "0x1E770E4", Offset = "0x1E770E4", VA = "0x1E770E4")]
		public string ToStringMessages()
		{
			return null;
		}
	}
}
