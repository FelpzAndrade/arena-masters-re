using System;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B12")]
	public sealed class CSNewUserBenefitInfo
	{
		[Token(Token = "0x4003673")]
		[FieldOffset(Offset = "0x8")]
		public string Key;

		[Token(Token = "0x4003674")]
		[FieldOffset(Offset = "0xC")]
		public string MailName;

		[Token(Token = "0x4003675")]
		[FieldOffset(Offset = "0x10")]
		public string MailDesc;

		[Token(Token = "0x4003676")]
		[FieldOffset(Offset = "0x14")]
		public CSContentType ContentType;

		[Token(Token = "0x4003677")]
		[FieldOffset(Offset = "0x18")]
		public int ContentID;

		[Token(Token = "0x4003678")]
		[FieldOffset(Offset = "0x1C")]
		public int ContentCount;

		[Token(Token = "0x4003679")]
		[FieldOffset(Offset = "0x20")]
		public int Period;

		[Token(Token = "0x400367A")]
		[FieldOffset(Offset = "0x24")]
		private CSContent Content__BackingField;

		[Token(Token = "0x17000BD3")]
		[XmlIgnore]
		public CSContent Content
		{
			[Token(Token = "0x6005154")]
			[Address(RVA = "0x1FBF8B4", Offset = "0x1FBF8B4", VA = "0x1FBF8B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005155")]
			[Address(RVA = "0x1FBF8BC", Offset = "0x1FBF8BC", VA = "0x1FBF8BC")]
			private set
			{
			}
		}

		[Token(Token = "0x6005153")]
		[Address(RVA = "0x1FBF7B4", Offset = "0x1FBF7B4", VA = "0x1FBF7B4")]
		public CSNewUserBenefitInfo()
		{
		}

		[Token(Token = "0x6005156")]
		[Address(RVA = "0x1FBF8C4", Offset = "0x1FBF8C4", VA = "0x1FBF8C4")]
		public void Cooking()
		{
		}
	}
}
