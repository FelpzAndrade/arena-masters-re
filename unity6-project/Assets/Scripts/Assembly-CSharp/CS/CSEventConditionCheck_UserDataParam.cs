using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008F4")]
	public class CSEventConditionCheck_UserDataParam
	{
		[Token(Token = "0x4002B4C")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<int, int> m_CharLevels;

		[Token(Token = "0x4002B4D")]
		[FieldOffset(Offset = "0xC")]
		private UserDataBase m_UserData;

		[Token(Token = "0x17000998")]
		public UserDataBase UserData
		{
			[Token(Token = "0x60047B7")]
			[Address(RVA = "0x222C7DC", Offset = "0x222C7DC", VA = "0x222C7DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60047B5")]
		[Address(RVA = "0x222C648", Offset = "0x222C648", VA = "0x222C648")]
		public CSEventConditionCheck_UserDataParam(UserDataBase userData)
		{
		}

		[Token(Token = "0x60047B6")]
		[Address(RVA = "0x222C6FC", Offset = "0x222C6FC", VA = "0x222C6FC")]
		public void AddCharLevel(int nCharId, int nCharLevel)
		{
		}

		[Token(Token = "0x60047B8")]
		[Address(RVA = "0x222C7E4", Offset = "0x222C7E4", VA = "0x222C7E4")]
		public bool IsExistChar(int nCharId)
		{
			return default(bool);
		}

		[Token(Token = "0x60047B9")]
		[Address(RVA = "0x222C884", Offset = "0x222C884", VA = "0x222C884")]
		public int GetCharLevel(int nCharId)
		{
			return default(int);
		}
	}
}
