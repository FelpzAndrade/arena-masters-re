using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B26")]
	public class CSProtoInfoManager_PremiumTicket : Dictionary<int, PremiumTicketInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x60051F1")]
		[Address(RVA = "0x1CBA0D4", Offset = "0x1CBA0D4", VA = "0x1CBA0D4")]
		public CSProtoInfoManager_PremiumTicket()
		{
		}

		[Token(Token = "0x60051F2")]
		[Address(RVA = "0x1CBA158", Offset = "0x1CBA158", VA = "0x1CBA158", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x60051F3")]
		[Address(RVA = "0x1CBA168", Offset = "0x1CBA168", VA = "0x1CBA168", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x60051F4")]
		[Address(RVA = "0x1CBA16C", Offset = "0x1CBA16C", VA = "0x1CBA16C", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x60051F5")]
		[Address(RVA = "0x1CBA3F4", Offset = "0x1CBA3F4", VA = "0x1CBA3F4", Slot = "43")]
		public bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x60051F6")]
		[Address(RVA = "0x1CBA760", Offset = "0x1CBA760", VA = "0x1CBA760")]
		public PremiumTicketInfo GetEffectivePremiumTicket(int id, DateTime premiumTicketStartTime, DateTime nowTime)
		{
			return null;
		}

		[Token(Token = "0x60051F7")]
		[Address(RVA = "0x1CBA998", Offset = "0x1CBA998", VA = "0x1CBA998")]
		private void _003CLoadFromLocalFile_003Em__20B(PremiumTicketInfo e)
		{
		}
	}
}
