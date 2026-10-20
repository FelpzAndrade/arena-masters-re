using Il2CppDummyDll;
using Newtonsoft.Json;

namespace CS
{
	[Token(Token = "0x20008F9")]
	public class ClanMemberMetaData : UserMetaData2
	{
		[Token(Token = "0x4002B64")]
		[FieldOffset(Offset = "0x48")]
		private bool IsOnline__BackingField;

		[Token(Token = "0x4002B65")]
		[FieldOffset(Offset = "0x4C")]
		private string Room__BackingField;

		[Token(Token = "0x4002B66")]
		[FieldOffset(Offset = "0x50")]
		private string AccountID__BackingField;

		[Token(Token = "0x170009AD")]
		[JsonIgnore]
		public bool IsOnline
		{
			[Token(Token = "0x60047EE")]
			[Address(RVA = "0x23EB900", Offset = "0x23EB900", VA = "0x23EB900")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60047EF")]
			[Address(RVA = "0x23EB8F0", Offset = "0x23EB8F0", VA = "0x23EB8F0")]
			set
			{
			}
		}

		[Token(Token = "0x170009AE")]
		[JsonIgnore]
		public string Room
		{
			[Token(Token = "0x60047F0")]
			[Address(RVA = "0x23EB908", Offset = "0x23EB908", VA = "0x23EB908")]
			get
			{
				return null;
			}
			[Token(Token = "0x60047F1")]
			[Address(RVA = "0x23EB8F8", Offset = "0x23EB8F8", VA = "0x23EB8F8")]
			set
			{
			}
		}

		[Token(Token = "0x170009AF")]
		[JsonIgnore]
		public bool IsInRoom
		{
			[Token(Token = "0x60047F2")]
			[Address(RVA = "0x23EB910", Offset = "0x23EB910", VA = "0x23EB910")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170009B0")]
		[JsonIgnore]
		public override bool IsLogin
		{
			[Token(Token = "0x60047F3")]
			[Address(RVA = "0x23EB9D0", Offset = "0x23EB9D0", VA = "0x23EB9D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170009B1")]
		public string AccountID
		{
			[Token(Token = "0x60047F4")]
			[Address(RVA = "0x23EB9D8", Offset = "0x23EB9D8", VA = "0x23EB9D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60047F5")]
			[Address(RVA = "0x23EB9E0", Offset = "0x23EB9E0", VA = "0x23EB9E0")]
			set
			{
			}
		}

		[Token(Token = "0x60047ED")]
		[Address(RVA = "0x23EB824", Offset = "0x23EB824", VA = "0x23EB824")]
		public ClanMemberMetaData()
		{
		}
	}
}
