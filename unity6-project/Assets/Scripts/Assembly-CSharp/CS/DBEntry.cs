using Il2CppDummyDll;
using Newtonsoft.Json;

namespace CS
{
	[Token(Token = "0x2000928")]
	public abstract class DBEntry
	{
		[Token(Token = "0x4002D5C")]
		[FieldOffset(Offset = "0x8")]
		private string InsertStack__BackingField;

		[Token(Token = "0x4002D5D")]
		[FieldOffset(Offset = "0x10")]
		private ulong Cas__BackingField;

		[Token(Token = "0x4002D5E")]
		[FieldOffset(Offset = "0x18")]
		private string padding__BackingField;

		[Token(Token = "0x4002D5F")]
		[FieldOffset(Offset = "0x1C")]
		private uint TTL__BackingField;

		[Token(Token = "0x4002D60")]
		[FieldOffset(Offset = "0x20")]
		private CommitType CommitType__BackingField;

		[Token(Token = "0x170009C7")]
		[JsonIgnore]
		public string InsertStack
		{
			[Token(Token = "0x6004909")]
			[Address(RVA = "0x1CDA918", Offset = "0x1CDA918", VA = "0x1CDA918")]
			get
			{
				return null;
			}
			[Token(Token = "0x600490A")]
			[Address(RVA = "0x1CDA920", Offset = "0x1CDA920", VA = "0x1CDA920")]
			set
			{
			}
		}

		[Token(Token = "0x170009C8")]
		[JsonIgnore]
		public ulong Cas
		{
			[Token(Token = "0x600490B")]
			[Address(RVA = "0x1CDA928", Offset = "0x1CDA928", VA = "0x1CDA928")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x600490C")]
			[Address(RVA = "0x1CDA930", Offset = "0x1CDA930", VA = "0x1CDA930")]
			set
			{
			}
		}

		[Token(Token = "0x170009C9")]
		public string padding
		{
			[Token(Token = "0x600490D")]
			[Address(RVA = "0x1CDA940", Offset = "0x1CDA940", VA = "0x1CDA940")]
			get
			{
				return null;
			}
			[Token(Token = "0x600490E")]
			[Address(RVA = "0x1CDA948", Offset = "0x1CDA948", VA = "0x1CDA948")]
			set
			{
			}
		}

		[Token(Token = "0x170009CA")]
		public uint TTL
		{
			[Token(Token = "0x600490F")]
			[Address(RVA = "0x1CDA950", Offset = "0x1CDA950", VA = "0x1CDA950")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6004910")]
			[Address(RVA = "0x1CDA958", Offset = "0x1CDA958", VA = "0x1CDA958")]
			set
			{
			}
		}

		[Token(Token = "0x170009CB")]
		[JsonIgnore]
		public CommitType CommitType
		{
			[Token(Token = "0x6004912")]
			[Address(RVA = "0x1CDAB84", Offset = "0x1CDAB84", VA = "0x1CDAB84")]
			get
			{
				return default(CommitType);
			}
			[Token(Token = "0x6004913")]
			[Address(RVA = "0x1CDAB8C", Offset = "0x1CDAB8C", VA = "0x1CDAB8C")]
			set
			{
			}
		}

		[Token(Token = "0x6004908")]
		[Address(RVA = "0x1CDA910", Offset = "0x1CDA910", VA = "0x1CDA910")]
		protected DBEntry()
		{
		}

		[Token(Token = "0x6004911")]
		[Address(RVA = "0x1CDA960", Offset = "0x1CDA960", VA = "0x1CDA960")]
		public bool Commit()
		{
			return default(bool);
		}

		[Token(Token = "0x6004914")]
		protected abstract bool Update();

		[Token(Token = "0x6004915")]
		protected abstract bool Remove();
	}
}
