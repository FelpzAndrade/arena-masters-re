using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using SharpRaven.Data;
using SharpRaven.Logging;
using UnityEngine;

namespace SharpRaven
{
	[Token(Token = "0x2000361")]
	public class RavenClient
	{
		[Token(Token = "0x2000362")]
		public class HttpRequestCreator : IWebRequestCreate
		{
			[Token(Token = "0x6001C4A")]
			[Address(RVA = "0x20F31E8", Offset = "0x20F31E8", VA = "0x20F31E8")]
			public HttpRequestCreator()
			{
			}

			[Token(Token = "0x6001C4B")]
			[Address(RVA = "0x20F4850", Offset = "0x20F4850", VA = "0x20F4850", Slot = "4")]
			public WebRequest Create(Uri uri)
			{
				return null;
			}
		}

		[Token(Token = "0x40011A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private DSN CurrentDSN__BackingField;

		[Token(Token = "0x40011A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private IScrubber LogScrubber__BackingField;

		[Token(Token = "0x40011A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool Compression__BackingField;

		[Token(Token = "0x40011A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private string Logger__BackingField;

		[Token(Token = "0x170004C7")]
		public DSN CurrentDSN
		{
			[Token(Token = "0x6001C39")]
			[Address(RVA = "0x20F331C", Offset = "0x20F331C", VA = "0x20F331C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C3A")]
			[Address(RVA = "0x20F31F0", Offset = "0x20F31F0", VA = "0x20F31F0")]
			set
			{
			}
		}

		[Token(Token = "0x170004C8")]
		public IScrubber LogScrubber
		{
			[Token(Token = "0x6001C3B")]
			[Address(RVA = "0x20F3324", Offset = "0x20F3324", VA = "0x20F3324")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C3C")]
			[Address(RVA = "0x20F332C", Offset = "0x20F332C", VA = "0x20F332C")]
			set
			{
			}
		}

		[Token(Token = "0x170004C9")]
		public bool Compression
		{
			[Token(Token = "0x6001C3D")]
			[Address(RVA = "0x20F3334", Offset = "0x20F3334", VA = "0x20F3334")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C3E")]
			[Address(RVA = "0x20F31F8", Offset = "0x20F31F8", VA = "0x20F31F8")]
			set
			{
			}
		}

		[Token(Token = "0x170004CA")]
		public string Logger
		{
			[Token(Token = "0x6001C3F")]
			[Address(RVA = "0x20F333C", Offset = "0x20F333C", VA = "0x20F333C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C40")]
			[Address(RVA = "0x20F3200", Offset = "0x20F3200", VA = "0x20F3200")]
			set
			{
			}
		}

		[Token(Token = "0x6001C37")]
		[Address(RVA = "0x20F30B4", Offset = "0x20F30B4", VA = "0x20F30B4")]
		public RavenClient(string dsn)
		{
		}

		[Token(Token = "0x6001C38")]
		[Address(RVA = "0x20F3208", Offset = "0x20F3208", VA = "0x20F3208")]
		public RavenClient(DSN dsn)
		{
		}

		[Token(Token = "0x6001C41")]
		[Address(RVA = "0x20F3344", Offset = "0x20F3344", VA = "0x20F3344")]
		public int CaptureException(Exception e)
		{
			return default(int);
		}

		[Token(Token = "0x6001C42")]
		[Address(RVA = "0x20F344C", Offset = "0x20F344C", VA = "0x20F344C")]
		public int CaptureException(Exception e, Dictionary<string, string> tags)
		{
			return default(int);
		}

		[Token(Token = "0x6001C43")]
		[Address(RVA = "0x20F3368", Offset = "0x20F3368", VA = "0x20F3368")]
		public int CaptureException(Exception e, Dictionary<string, string> tags, [Optional] object extra)
		{
			return default(int);
		}

		[Token(Token = "0x6001C44")]
		[Address(RVA = "0x20F435C", Offset = "0x20F435C", VA = "0x20F435C")]
		public int CaptureUntiyLog(string log, string stack, LogType logType, [Optional] Dictionary<string, string> tags, [Optional] object extra)
		{
			return default(int);
		}

		[Token(Token = "0x6001C45")]
		[Address(RVA = "0x20F4458", Offset = "0x20F4458", VA = "0x20F4458")]
		public int CaptureMessage(string message)
		{
			return default(int);
		}

		[Token(Token = "0x6001C46")]
		[Address(RVA = "0x20F4574", Offset = "0x20F4574", VA = "0x20F4574")]
		public int CaptureMessage(string message, ErrorLevel level)
		{
			return default(int);
		}

		[Token(Token = "0x6001C47")]
		[Address(RVA = "0x20F459C", Offset = "0x20F459C", VA = "0x20F459C")]
		public int CaptureMessage(string message, ErrorLevel level, Dictionary<string, string> tags)
		{
			return default(int);
		}

		[Token(Token = "0x6001C48")]
		[Address(RVA = "0x20F4484", Offset = "0x20F4484", VA = "0x20F4484")]
		public int CaptureMessage(string message, ErrorLevel level, Dictionary<string, string> tags, object extra)
		{
			return default(int);
		}

		[Token(Token = "0x6001C49")]
		[Address(RVA = "0x20F346C", Offset = "0x20F346C", VA = "0x20F346C")]
		public bool Send(JsonPacket packet, DSN dsn)
		{
			return default(bool);
		}
	}
}
