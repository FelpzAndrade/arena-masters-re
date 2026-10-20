using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200090E")]
	public static class SkinLogic
	{
		[Token(Token = "0x200090F")]
		private sealed class _003CIsHaveSkin_003Ec__AnonStorey14D
		{
			[Token(Token = "0x4002B84")]
			[FieldOffset(Offset = "0x8")]
			internal int skin_id;

			[Token(Token = "0x6004885")]
			[Address(RVA = "0x21E2DB4", Offset = "0x21E2DB4", VA = "0x21E2DB4")]
			public _003CIsHaveSkin_003Ec__AnonStorey14D()
			{
			}

			[Token(Token = "0x6004886")]
			[Address(RVA = "0x21E3190", Offset = "0x21E3190", VA = "0x21E3190")]
			internal bool _003C_003Em__1EE(int e)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6004881")]
		[Address(RVA = "0x21E2C74", Offset = "0x21E2C74", VA = "0x21E2C74")]
		public static bool IsHaveSkin(List<int> SkinList, int skin_id)
		{
			return default(bool);
		}

		[Token(Token = "0x6004882")]
		[Address(RVA = "0x21E2DBC", Offset = "0x21E2DBC", VA = "0x21E2DBC")]
		public static bool IsHavePeriodSkin(UserDataBase user, DateTime UtcNow, int skin_id)
		{
			return default(bool);
		}

		[Token(Token = "0x6004883")]
		[Address(RVA = "0x21E2ED0", Offset = "0x21E2ED0", VA = "0x21E2ED0")]
		public static bool CheckUnlockable(UserDataBase userData, int id, Func<SkinInfo, bool> CheckHaveTicket, ProtoInfoManager_Skin protoSkin)
		{
			return default(bool);
		}

		[Token(Token = "0x6004884")]
		[Address(RVA = "0x21E3130", Offset = "0x21E3130", VA = "0x21E3130")]
		public static List<ExpireNode> GetPeriodSkinList(UserDataBase user, DateTime UtcNow)
		{
			return null;
		}
	}
}
