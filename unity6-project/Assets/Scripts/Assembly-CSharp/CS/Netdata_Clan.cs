using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace CS
{
	[Token(Token = "0x200096A")]
	public class Netdata_Clan
	{
		[Token(Token = "0x4002E92")]
		[FieldOffset(Offset = "0x8")]
		public ClanMetaData Info;

		[Token(Token = "0x4002E93")]
		[FieldOffset(Offset = "0xC")]
		public ClanWar ClanWar;

		[Token(Token = "0x4002E94")]
		[FieldOffset(Offset = "0x10")]
		public List<ClanMember> MemberList1;

		[Token(Token = "0x4002E95")]
		[FieldOffset(Offset = "0x14")]
		public List<ClanMemberMetaData> MetaDataList;

		[Token(Token = "0x4002E96")]
		[FieldOffset(Offset = "0x18")]
		[JsonIgnore]
		private Dictionary<string, CompletedClanMember> _memDic;

		[Token(Token = "0x4002E97")]
		[FieldOffset(Offset = "0x1C")]
		[JsonIgnore]
		private List<CompletedClanMember> _memList;

		[Token(Token = "0x4002E98")]
		[FieldOffset(Offset = "0x20")]
		private string Notification__BackingField;

		[Token(Token = "0x4002E99")]
		[FieldOffset(Offset = "0x24")]
		private int Exp__BackingField;

		[Token(Token = "0x17000AB7")]
		public string ClanId
		{
			[Token(Token = "0x6004BCD")]
			[Address(RVA = "0x233EB70", Offset = "0x233EB70", VA = "0x233EB70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AB8")]
		public string Notification
		{
			[Token(Token = "0x6004BCE")]
			[Address(RVA = "0x233EB9C", Offset = "0x233EB9C", VA = "0x233EB9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004BCF")]
			[Address(RVA = "0x233EBA4", Offset = "0x233EBA4", VA = "0x233EBA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000AB9")]
		public int Exp
		{
			[Token(Token = "0x6004BD0")]
			[Address(RVA = "0x233EBAC", Offset = "0x233EBAC", VA = "0x233EBAC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004BD1")]
			[Address(RVA = "0x233EBB4", Offset = "0x233EBB4", VA = "0x233EBB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000ABA")]
		[JsonIgnore]
		public List<CompletedClanMember> MemberList
		{
			[Token(Token = "0x6004BD2")]
			[Address(RVA = "0x233EBBC", Offset = "0x233EBBC", VA = "0x233EBBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ABB")]
		[JsonIgnore]
		public int MemberCount
		{
			[Token(Token = "0x6004BD3")]
			[Address(RVA = "0x233F32C", Offset = "0x233F32C", VA = "0x233F32C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000ABC")]
		[JsonIgnore]
		public int MemberLoginCount
		{
			[Token(Token = "0x6004BD4")]
			[Address(RVA = "0x233F3C0", Offset = "0x233F3C0", VA = "0x233F3C0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000ABD")]
		[JsonIgnore]
		public Dictionary<string, CompletedClanMember> MemberDictionary
		{
			[Token(Token = "0x6004BD5")]
			[Address(RVA = "0x233EE98", Offset = "0x233EE98", VA = "0x233EE98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004BCC")]
		[Address(RVA = "0x233EA48", Offset = "0x233EA48", VA = "0x233EA48")]
		public Netdata_Clan()
		{
		}

		[Token(Token = "0x6004BD6")]
		[Address(RVA = "0x233F580", Offset = "0x233F580", VA = "0x233F580")]
		public bool IsMember(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6004BD7")]
		[Address(RVA = "0x233F624", Offset = "0x233F624", VA = "0x233F624")]
		public void ResetCompletedClanMember()
		{
		}

		[Token(Token = "0x6004BD8")]
		[Address(RVA = "0x233F6EC", Offset = "0x233F6EC", VA = "0x233F6EC")]
		public void RecombineCompletedClanMember()
		{
		}
	}
}
