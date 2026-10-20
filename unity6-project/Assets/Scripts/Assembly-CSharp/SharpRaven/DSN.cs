using System;
using Il2CppDummyDll;

namespace SharpRaven
{
	[Token(Token = "0x2000354")]
	public class DSN
	{
		[Token(Token = "0x4001175")]
		[FieldOffset(Offset = "0x8")]
		private Uri URI__BackingField;

		[Token(Token = "0x4001176")]
		[FieldOffset(Offset = "0xC")]
		private string SentryURI__BackingField;

		[Token(Token = "0x4001177")]
		[FieldOffset(Offset = "0x10")]
		private string PublicKey__BackingField;

		[Token(Token = "0x4001178")]
		[FieldOffset(Offset = "0x14")]
		private string PrivateKey__BackingField;

		[Token(Token = "0x4001179")]
		[FieldOffset(Offset = "0x18")]
		private string ProjectID__BackingField;

		[Token(Token = "0x400117A")]
		[FieldOffset(Offset = "0x1C")]
		private int Port__BackingField;

		[Token(Token = "0x400117B")]
		[FieldOffset(Offset = "0x20")]
		private string Path__BackingField;

		[Token(Token = "0x170004B3")]
		public Uri URI
		{
			[Token(Token = "0x6001BF2")]
			[Address(RVA = "0x20F2570", Offset = "0x20F2570", VA = "0x20F2570")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BF3")]
			[Address(RVA = "0x20F2578", Offset = "0x20F2578", VA = "0x20F2578")]
			set
			{
			}
		}

		[Token(Token = "0x170004B4")]
		public string SentryURI
		{
			[Token(Token = "0x6001BF4")]
			[Address(RVA = "0x20F2580", Offset = "0x20F2580", VA = "0x20F2580")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BF5")]
			[Address(RVA = "0x20F2568", Offset = "0x20F2568", VA = "0x20F2568")]
			set
			{
			}
		}

		[Token(Token = "0x170004B5")]
		public string PublicKey
		{
			[Token(Token = "0x6001BF6")]
			[Address(RVA = "0x20F2588", Offset = "0x20F2588", VA = "0x20F2588")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BF7")]
			[Address(RVA = "0x20F2360", Offset = "0x20F2360", VA = "0x20F2360")]
			set
			{
			}
		}

		[Token(Token = "0x170004B6")]
		public string PrivateKey
		{
			[Token(Token = "0x6001BF8")]
			[Address(RVA = "0x20F2590", Offset = "0x20F2590", VA = "0x20F2590")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BF9")]
			[Address(RVA = "0x20F2240", Offset = "0x20F2240", VA = "0x20F2240")]
			set
			{
			}
		}

		[Token(Token = "0x170004B7")]
		public string ProjectID
		{
			[Token(Token = "0x6001BFA")]
			[Address(RVA = "0x20F2560", Offset = "0x20F2560", VA = "0x20F2560")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BFB")]
			[Address(RVA = "0x20F246C", Offset = "0x20F246C", VA = "0x20F246C")]
			set
			{
			}
		}

		[Token(Token = "0x170004B8")]
		public int Port
		{
			[Token(Token = "0x6001BFC")]
			[Address(RVA = "0x20F2550", Offset = "0x20F2550", VA = "0x20F2550")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6001BFD")]
			[Address(RVA = "0x20F2394", Offset = "0x20F2394", VA = "0x20F2394")]
			set
			{
			}
		}

		[Token(Token = "0x170004B9")]
		public string Path
		{
			[Token(Token = "0x6001BFE")]
			[Address(RVA = "0x20F2558", Offset = "0x20F2558", VA = "0x20F2558")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BFF")]
			[Address(RVA = "0x20F2548", Offset = "0x20F2548", VA = "0x20F2548")]
			set
			{
			}
		}

		[Token(Token = "0x6001BF1")]
		[Address(RVA = "0x20F1DD4", Offset = "0x20F1DD4", VA = "0x20F1DD4")]
		public DSN(string dsn)
		{
		}

		[Token(Token = "0x6001C00")]
		[Address(RVA = "0x20F2368", Offset = "0x20F2368", VA = "0x20F2368")]
		public int GetPort(Uri uri)
		{
			return default(int);
		}

		[Token(Token = "0x6001C01")]
		[Address(RVA = "0x20F2474", Offset = "0x20F2474", VA = "0x20F2474")]
		public string GetPath(Uri uri)
		{
			return null;
		}

		[Token(Token = "0x6001C02")]
		[Address(RVA = "0x20F2248", Offset = "0x20F2248", VA = "0x20F2248")]
		public string GetPublicKey(Uri uri)
		{
			return null;
		}

		[Token(Token = "0x6001C03")]
		[Address(RVA = "0x20F2128", Offset = "0x20F2128", VA = "0x20F2128")]
		public string GetPrivateKey(Uri uri)
		{
			return null;
		}

		[Token(Token = "0x6001C04")]
		[Address(RVA = "0x20F239C", Offset = "0x20F239C", VA = "0x20F239C")]
		public string GetProjectID(Uri uri)
		{
			return null;
		}
	}
}
