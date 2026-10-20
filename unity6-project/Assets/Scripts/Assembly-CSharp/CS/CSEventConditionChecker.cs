using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008F5")]
	public class CSEventConditionChecker
	{
		[Token(Token = "0x4002B4E")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<int, CSEventInfo> m_ProtoInfoManager_Event;

		[Token(Token = "0x4002B4F")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, int> _003C_003Ef__switch_0024map12;

		[Token(Token = "0x60047BA")]
		[Address(RVA = "0x222C964", Offset = "0x222C964", VA = "0x222C964")]
		public CSEventConditionChecker()
		{
		}

		[Token(Token = "0x60047BB")]
		[Address(RVA = "0x222CA10", Offset = "0x222CA10", VA = "0x222CA10")]
		public bool IsCompletable(CSEventConditionCheck_UserDataParam userDataParam, int eventId, DateTime now)
		{
			return default(bool);
		}

		[Token(Token = "0x60047BC")]
		[Address(RVA = "0x222CBF0", Offset = "0x222CBF0", VA = "0x222CBF0")]
		public bool IsShowable(CSEventConditionCheck_UserDataParam userDataParam, int eventId, DateTime now)
		{
			return default(bool);
		}

		[Token(Token = "0x60047BD")]
		[Address(RVA = "0x222CE8C", Offset = "0x222CE8C", VA = "0x222CE8C")]
		public bool CheckCondition(CSEventConditionCheck_UserDataParam userDataParam, string condition, DateTime now)
		{
			return default(bool);
		}

		[Token(Token = "0x60047BE")]
		[Address(RVA = "0x222E1F4", Offset = "0x222E1F4", VA = "0x222E1F4")]
		public void GetProgressCount(UserDataBase data, int eventId, out int progressCount, out int totalCount)
		{
			progressCount = default;
			totalCount = default;
		}

		[Token(Token = "0x60047BF")]
		[Address(RVA = "0x222D928", Offset = "0x222D928", VA = "0x222D928")]
		public void GetProgressCount(UserDataBase data, string condition, out int progressCount, out int totalCount)
		{
			progressCount = default;
			totalCount = default;
		}

		[Token(Token = "0x60047C0")]
		[Address(RVA = "0x222E014", Offset = "0x222E014", VA = "0x222E014")]
		public void GetCharLevel(CSEventConditionCheck_UserDataParam userDataParam, string condition, out int nCharID, out int nCharLevel, out int nMyCharLevel)
		{
			nCharID = default;
			nCharLevel = default;
			nMyCharLevel = default;
		}
	}
}
