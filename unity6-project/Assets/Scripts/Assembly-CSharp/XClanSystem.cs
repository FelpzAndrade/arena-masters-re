using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x20003F2")]
public class XClanSystem
{
	[Token(Token = "0x20003F3")]
	private sealed class _003COnRefreshClanMemberStatus_003Ec__AnonStoreyF2
	{
		[Token(Token = "0x40013BF")]
		[FieldOffset(Offset = "0x8")]
		internal string findAID;

		[Token(Token = "0x6002052")]
		[Address(RVA = "0x1AC6EAC", Offset = "0x1AC6EAC", VA = "0x1AC6EAC")]
		public _003COnRefreshClanMemberStatus_003Ec__AnonStoreyF2()
		{
		}

		[Token(Token = "0x6002053")]
		[Address(RVA = "0x1AC7520", Offset = "0x1AC7520", VA = "0x1AC7520")]
		internal bool _003C_003Em__AE(FriendInfo item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40013BB")]
	[FieldOffset(Offset = "0x8")]
	private Netdata_Clan m_clanData;

	[Token(Token = "0x40013BC")]
	[FieldOffset(Offset = "0xC")]
	private IClanListener m_listener;

	[Token(Token = "0x40013BD")]
	[FieldOffset(Offset = "0x10")]
	private XClanWar ClanWar__BackingField;

	[Token(Token = "0x40013BE")]
	[FieldOffset(Offset = "0x0")]
	private static Func<ClanMemberMetaData, string> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x17000573")]
	public XClanWar ClanWar
	{
		[Token(Token = "0x6002044")]
		[Address(RVA = "0x1AC5944", Offset = "0x1AC5944", VA = "0x1AC5944")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002045")]
		[Address(RVA = "0x1AC65F4", Offset = "0x1AC65F4", VA = "0x1AC65F4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000574")]
	public Netdata_Clan ClanData
	{
		[Token(Token = "0x6002046")]
		[Address(RVA = "0x1AC65FC", Offset = "0x1AC65FC", VA = "0x1AC65FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002043")]
	[Address(RVA = "0x1AC637C", Offset = "0x1AC637C", VA = "0x1AC637C")]
	public XClanSystem()
	{
	}

	[Token(Token = "0x6002047")]
	[Address(RVA = "0x1AC6604", Offset = "0x1AC6604", VA = "0x1AC6604")]
	internal void Clear()
	{
	}

	[Token(Token = "0x6002048")]
	[Address(RVA = "0x1AC666C", Offset = "0x1AC666C", VA = "0x1AC666C")]
	public void SetListener(IClanListener listener)
	{
	}

	[Token(Token = "0x6002049")]
	[Address(RVA = "0x1AC6674", Offset = "0x1AC6674", VA = "0x1AC6674")]
	public void RemoveListener(IClanListener listener)
	{
	}

	[Token(Token = "0x600204A")]
	[Address(RVA = "0x1AC673C", Offset = "0x1AC673C", VA = "0x1AC673C")]
	public bool BuildClan(Netdata_Clan clanData, bool getMemberStatus = true)
	{
		return default(bool);
	}

	[Token(Token = "0x600204B")]
	[Address(RVA = "0x1AC6878", Offset = "0x1AC6878", VA = "0x1AC6878")]
	public bool RefreshClanMemberStatus()
	{
		return default(bool);
	}

	[Token(Token = "0x600204C")]
	[Address(RVA = "0x1AC6B40", Offset = "0x1AC6B40", VA = "0x1AC6B40")]
	public void OnRefreshClanMemberStatus(List<FriendInfo> clanMemberInfo)
	{
	}

	[Token(Token = "0x600204D")]
	[Address(RVA = "0x1AC6EB4", Offset = "0x1AC6EB4", VA = "0x1AC6EB4")]
	public int GetClanMemberCount()
	{
		return default(int);
	}

	[Token(Token = "0x600204E")]
	[Address(RVA = "0x1AC6ECC", Offset = "0x1AC6ECC", VA = "0x1AC6ECC")]
	public int GetClanMemberLoginCount()
	{
		return default(int);
	}

	[Token(Token = "0x600204F")]
	[Address(RVA = "0x1AC6EE4", Offset = "0x1AC6EE4", VA = "0x1AC6EE4")]
	public void GetMyClanDataForChat()
	{
	}

	[Token(Token = "0x6002050")]
	[Address(RVA = "0x1AC706C", Offset = "0x1AC706C", VA = "0x1AC706C")]
	private static string _003CRefreshClanMemberStatus_003Em__AD(ClanMemberMetaData item)
	{
		return null;
	}

	[Token(Token = "0x6002051")]
	[Address(RVA = "0x1AC7098", Offset = "0x1AC7098", VA = "0x1AC7098")]
	private void _003CGetMyClanDataForChat_003Em__AF(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
