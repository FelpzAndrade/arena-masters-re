using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000900")]
	public static class EmoticonLogic
	{
		[Token(Token = "0x6004811")]
		[Address(RVA = "0x1CDBF38", Offset = "0x1CDBF38", VA = "0x1CDBF38")]
		public static void ResetDefault(UserDataBase user)
		{
		}

		[Token(Token = "0x6004812")]
		[Address(RVA = "0x1CDC038", Offset = "0x1CDC038", VA = "0x1CDC038")]
		public static bool HasEmoticonSet(UserDataBase userData, int emoticon_set_id)
		{
			return default(bool);
		}

		[Token(Token = "0x6004813")]
		[Address(RVA = "0x1CDC0E8", Offset = "0x1CDC0E8", VA = "0x1CDC0E8")]
		public static int OwnedEmoticonSetCount(UserDataBase userData)
		{
			return default(int);
		}

		[Token(Token = "0x6004814")]
		[Address(RVA = "0x1CDC190", Offset = "0x1CDC190", VA = "0x1CDC190")]
		public static bool Select(UserDataBase userData, int emoticonId)
		{
			return default(bool);
		}

		[Token(Token = "0x6004815")]
		[Address(RVA = "0x1CDC1E0", Offset = "0x1CDC1E0", VA = "0x1CDC1E0")]
		public static bool CanPurchase(UserDataBase userData, CSEmoticonSetInfo info, DateTime serverLocalTime)
		{
			return default(bool);
		}

		[Token(Token = "0x6004816")]
		[Address(RVA = "0x1CDC248", Offset = "0x1CDC248", VA = "0x1CDC248")]
		public static bool Showable(CSEmoticonSetInfo info, DateTime serverLocalTime)
		{
			return default(bool);
		}

		[Token(Token = "0x6004817")]
		[Address(RVA = "0x1CDC4E0", Offset = "0x1CDC4E0", VA = "0x1CDC4E0")]
		public static TimeSpan GetRemainTime(CSEmoticonSetInfo info, DateTime serverLocalTime)
		{
			return default(TimeSpan);
		}
	}
}
