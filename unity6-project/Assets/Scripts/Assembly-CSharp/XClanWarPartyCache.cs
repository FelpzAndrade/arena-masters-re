using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000402")]
public class XClanWarPartyCache
{
	[Token(Token = "0x2000403")]
	private sealed class _003CUpdatePartyList_003Ec__AnonStoreyFD
	{
		[Token(Token = "0x40013EC")]
		[FieldOffset(Offset = "0x8")]
		internal List<DTPartyInfo> partyList;

		[Token(Token = "0x60020DB")]
		[Address(RVA = "0x19856F8", Offset = "0x19856F8", VA = "0x19856F8")]
		public _003CUpdatePartyList_003Ec__AnonStoreyFD()
		{
		}
	}

	[Token(Token = "0x2000404")]
	private sealed class _003CUpdatePartyList_003Ec__AnonStoreyFE
	{
		[Token(Token = "0x40013ED")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x40013EE")]
		[FieldOffset(Offset = "0xC")]
		internal _003CUpdatePartyList_003Ec__AnonStoreyFD _003C_003Ef__ref_0024253;

		[Token(Token = "0x60020DC")]
		[Address(RVA = "0x1985700", Offset = "0x1985700", VA = "0x1985700")]
		public _003CUpdatePartyList_003Ec__AnonStoreyFE()
		{
		}

		[Token(Token = "0x60020DD")]
		[Address(RVA = "0x1985AA4", Offset = "0x1985AA4", VA = "0x1985AA4")]
		internal bool _003C_003Em__CA(DTPartyInfo item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000405")]
	private sealed class _003CDeletePartyList_003Ec__AnonStoreyFF
	{
		[Token(Token = "0x40013EF")]
		[FieldOffset(Offset = "0x8")]
		internal List<long> deleteList;

		[Token(Token = "0x60020DE")]
		[Address(RVA = "0x1985838", Offset = "0x1985838", VA = "0x1985838")]
		public _003CDeletePartyList_003Ec__AnonStoreyFF()
		{
		}

		[Token(Token = "0x60020DF")]
		[Address(RVA = "0x19859DC", Offset = "0x19859DC", VA = "0x19859DC")]
		internal bool _003C_003Em__CB(DTPartyInfo item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40013EA")]
	[FieldOffset(Offset = "0x8")]
	private List<DTPartyInfo> m_liPartyInfo;

	[Token(Token = "0x40013EB")]
	[FieldOffset(Offset = "0x10")]
	private long GetLastTimeStamp__BackingField;

	[Token(Token = "0x17000579")]
	public List<DTPartyInfo> PartyList
	{
		[Token(Token = "0x60020D2")]
		[Address(RVA = "0x19852D0", Offset = "0x19852D0", VA = "0x19852D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700057A")]
	public long GetLastTimeStamp
	{
		[Token(Token = "0x60020D3")]
		[Address(RVA = "0x1985358", Offset = "0x1985358", VA = "0x1985358")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60020D4")]
		[Address(RVA = "0x19852C0", Offset = "0x19852C0", VA = "0x19852C0")]
		private set
		{
		}
	}

	[Token(Token = "0x60020D1")]
	[Address(RVA = "0x19851A4", Offset = "0x19851A4", VA = "0x19851A4")]
	public XClanWarPartyCache()
	{
	}

	[Token(Token = "0x60020D5")]
	[Address(RVA = "0x1985360", Offset = "0x1985360", VA = "0x1985360")]
	public void Clear()
	{
	}

	[Token(Token = "0x60020D6")]
	[Address(RVA = "0x1985468", Offset = "0x1985468", VA = "0x1985468")]
	public void UpdatePartyList(List<DTPartyInfo> partyList)
	{
	}

	[Token(Token = "0x60020D7")]
	[Address(RVA = "0x1985708", Offset = "0x1985708", VA = "0x1985708")]
	public void DeletePartyList(List<long> deleteList)
	{
	}

	[Token(Token = "0x60020D8")]
	[Address(RVA = "0x1985840", Offset = "0x1985840", VA = "0x1985840")]
	public void UpdateGetTimeStamp(long timeStamp)
	{
	}

	[Token(Token = "0x60020D9")]
	[Address(RVA = "0x1985850", Offset = "0x1985850", VA = "0x1985850")]
	internal void UpdateExpireCache()
	{
	}

	[Token(Token = "0x60020DA")]
	[Address(RVA = "0x19859D8", Offset = "0x19859D8", VA = "0x19859D8")]
	private void ExpireCache()
	{
	}
}
