using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace SharpRaven.Data
{
	[Token(Token = "0x2000357")]
	public class JsonPacket
	{
		[Token(Token = "0x400118D")]
		[FieldOffset(Offset = "0x8")]
		public Dictionary<string, string> Tags;

		[Token(Token = "0x400118E")]
		[FieldOffset(Offset = "0xC")]
		public object Extra;

		[Token(Token = "0x400118F")]
		[FieldOffset(Offset = "0x10")]
		private string EventID__BackingField;

		[Token(Token = "0x4001190")]
		[FieldOffset(Offset = "0x14")]
		private string Project__BackingField;

		[Token(Token = "0x4001191")]
		[FieldOffset(Offset = "0x18")]
		private string Culprit__BackingField;

		[Token(Token = "0x4001192")]
		[FieldOffset(Offset = "0x1C")]
		private ErrorLevel Level__BackingField;

		[Token(Token = "0x4001193")]
		[FieldOffset(Offset = "0x20")]
		private DateTime TimeStamp__BackingField;

		[Token(Token = "0x4001194")]
		[FieldOffset(Offset = "0x30")]
		private string Logger__BackingField;

		[Token(Token = "0x4001195")]
		[FieldOffset(Offset = "0x34")]
		private string Platform__BackingField;

		[Token(Token = "0x4001196")]
		[FieldOffset(Offset = "0x38")]
		private string Message__BackingField;

		[Token(Token = "0x4001197")]
		[FieldOffset(Offset = "0x3C")]
		private string ServerName__BackingField;

		[Token(Token = "0x4001198")]
		[FieldOffset(Offset = "0x40")]
		private List<Module> Modules__BackingField;

		[Token(Token = "0x4001199")]
		[FieldOffset(Offset = "0x44")]
		private SentryException Exception__BackingField;

		[Token(Token = "0x400119A")]
		[FieldOffset(Offset = "0x48")]
		private SentryStacktrace StackTrace__BackingField;

		[Token(Token = "0x170004BA")]
		public string EventID
		{
			[Token(Token = "0x6001C09")]
			[Address(RVA = "0x20F19DC", Offset = "0x20F19DC", VA = "0x20F19DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C0A")]
			[Address(RVA = "0x20F19E4", Offset = "0x20F19E4", VA = "0x20F19E4")]
			set
			{
			}
		}

		[Token(Token = "0x170004BB")]
		public string Project
		{
			[Token(Token = "0x6001C0B")]
			[Address(RVA = "0x20F19EC", Offset = "0x20F19EC", VA = "0x20F19EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C0C")]
			[Address(RVA = "0x20F1014", Offset = "0x20F1014", VA = "0x20F1014")]
			set
			{
			}
		}

		[Token(Token = "0x170004BC")]
		public string Culprit
		{
			[Token(Token = "0x6001C0D")]
			[Address(RVA = "0x20F19F4", Offset = "0x20F19F4", VA = "0x20F19F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C0E")]
			[Address(RVA = "0x20F1444", Offset = "0x20F1444", VA = "0x20F1444")]
			set
			{
			}
		}

		[Token(Token = "0x170004BD")]
		public ErrorLevel Level
		{
			[Token(Token = "0x6001C0F")]
			[Address(RVA = "0x20F19FC", Offset = "0x20F19FC", VA = "0x20F19FC")]
			get
			{
				return default(ErrorLevel);
			}
			[Token(Token = "0x6001C10")]
			[Address(RVA = "0x20F1454", Offset = "0x20F1454", VA = "0x20F1454")]
			set
			{
			}
		}

		[Token(Token = "0x170004BE")]
		public DateTime TimeStamp
		{
			[Token(Token = "0x6001C11")]
			[Address(RVA = "0x20F1A04", Offset = "0x20F1A04", VA = "0x20F1A04")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6001C12")]
			[Address(RVA = "0x20F1A14", Offset = "0x20F1A14", VA = "0x20F1A14")]
			set
			{
			}
		}

		[Token(Token = "0x170004BF")]
		public string Logger
		{
			[Token(Token = "0x6001C13")]
			[Address(RVA = "0x20F1A2C", Offset = "0x20F1A2C", VA = "0x20F1A2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C14")]
			[Address(RVA = "0x20F1A34", Offset = "0x20F1A34", VA = "0x20F1A34")]
			set
			{
			}
		}

		[Token(Token = "0x170004C0")]
		public string Platform
		{
			[Token(Token = "0x6001C15")]
			[Address(RVA = "0x20F1A3C", Offset = "0x20F1A3C", VA = "0x20F1A3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C16")]
			[Address(RVA = "0x20F1A44", Offset = "0x20F1A44", VA = "0x20F1A44")]
			set
			{
			}
		}

		[Token(Token = "0x170004C1")]
		public string Message
		{
			[Token(Token = "0x6001C17")]
			[Address(RVA = "0x20F1A4C", Offset = "0x20F1A4C", VA = "0x20F1A4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C18")]
			[Address(RVA = "0x20F143C", Offset = "0x20F143C", VA = "0x20F143C")]
			set
			{
			}
		}

		[Token(Token = "0x170004C2")]
		public string ServerName
		{
			[Token(Token = "0x6001C19")]
			[Address(RVA = "0x20F1A54", Offset = "0x20F1A54", VA = "0x20F1A54")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C1A")]
			[Address(RVA = "0x20F144C", Offset = "0x20F144C", VA = "0x20F144C")]
			set
			{
			}
		}

		[Token(Token = "0x170004C3")]
		public List<Module> Modules
		{
			[Token(Token = "0x6001C1B")]
			[Address(RVA = "0x20F1A5C", Offset = "0x20F1A5C", VA = "0x20F1A5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C1C")]
			[Address(RVA = "0x20F1A64", Offset = "0x20F1A64", VA = "0x20F1A64")]
			set
			{
			}
		}

		[Token(Token = "0x170004C4")]
		public SentryException Exception
		{
			[Token(Token = "0x6001C1D")]
			[Address(RVA = "0x20F1524", Offset = "0x20F1524", VA = "0x20F1524")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C1E")]
			[Address(RVA = "0x20F151C", Offset = "0x20F151C", VA = "0x20F151C")]
			set
			{
			}
		}

		[Token(Token = "0x170004C5")]
		public SentryStacktrace StackTrace
		{
			[Token(Token = "0x6001C1F")]
			[Address(RVA = "0x20F175C", Offset = "0x20F175C", VA = "0x20F175C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C20")]
			[Address(RVA = "0x20F1754", Offset = "0x20F1754", VA = "0x20F1754")]
			set
			{
			}
		}

		[Token(Token = "0x6001C06")]
		[Address(RVA = "0x20F0DE0", Offset = "0x20F0DE0", VA = "0x20F0DE0")]
		public JsonPacket(string project)
		{
		}

		[Token(Token = "0x6001C07")]
		[Address(RVA = "0x20F101C", Offset = "0x20F101C", VA = "0x20F101C")]
		public JsonPacket(string project, Exception e)
		{
		}

		[Token(Token = "0x6001C08")]
		[Address(RVA = "0x20F1764", Offset = "0x20F1764", VA = "0x20F1764")]
		public JsonPacket(string project, string log, string stack, LogType logType)
		{
		}

		[Token(Token = "0x6001C21")]
		[Address(RVA = "0x20F0E08", Offset = "0x20F0E08", VA = "0x20F0E08")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6001C22")]
		[Address(RVA = "0x20F1A6C", Offset = "0x20F1A6C", VA = "0x20F1A6C")]
		public string Serialize()
		{
			return null;
		}
	}
}
