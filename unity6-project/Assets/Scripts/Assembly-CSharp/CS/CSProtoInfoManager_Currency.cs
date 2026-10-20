using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000ABC")]
	public class CSProtoInfoManager_Currency : List<int>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x400324C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly List<Currency> ComplexCurrencyType;

		[Token(Token = "0x400324D")]
		[FieldOffset(Offset = "0x14")]
		private Dictionary<Currency, CurrencyInfo> _list;

		[Token(Token = "0x400324E")]
		[FieldOffset(Offset = "0x18")]
		public List<CSContentType> _contentTypeList;

		[Token(Token = "0x6004EE9")]
		[Address(RVA = "0x1FC1E54", Offset = "0x1FC1E54", VA = "0x1FC1E54")]
		public CSProtoInfoManager_Currency()
		{
		}

		[Token(Token = "0x6004EEB")]
		[Address(RVA = "0x1FCC664", Offset = "0x1FCC664", VA = "0x1FCC664")]
		public bool IsComplexCurrency(CSContentType Type)
		{
			return default(bool);
		}

		[Token(Token = "0x6004EEC")]
		[Address(RVA = "0x1FCC704", Offset = "0x1FCC704", VA = "0x1FCC704")]
		public Stat.Type GetStat(bool IsIncrease, Currency currency)
		{
			return default(Stat.Type);
		}

		[Token(Token = "0x6004EED")]
		[Address(RVA = "0x1FCC7F0", Offset = "0x1FCC7F0", VA = "0x1FCC7F0", Slot = "33")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6004EEE")]
		[Address(RVA = "0x1FCC800", Offset = "0x1FCC800", VA = "0x1FCC800", Slot = "37")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6004EEF")]
		[Address(RVA = "0x1FCCD4C", Offset = "0x1FCCD4C", VA = "0x1FCCD4C", Slot = "38")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6004EF0")]
		[Address(RVA = "0x1FCCD54", Offset = "0x1FCCD54", VA = "0x1FCCD54", Slot = "35")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}
	}
}
