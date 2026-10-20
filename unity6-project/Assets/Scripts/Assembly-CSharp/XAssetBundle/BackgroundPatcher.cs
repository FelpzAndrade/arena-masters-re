using System.Collections.Generic;
using Il2CppDummyDll;

namespace XAssetBundle
{
	[Token(Token = "0x200038D")]
	public class BackgroundPatcher
	{
		[Token(Token = "0x200038E")]
		private sealed class _003CStartPatch_003Ec__AnonStoreyE9
		{
			[Token(Token = "0x40012AA")]
			[FieldOffset(Offset = "0x8")]
			internal string fileName;

			[Token(Token = "0x40012AB")]
			[FieldOffset(Offset = "0xC")]
			internal int taskId;

			[Token(Token = "0x40012AC")]
			[FieldOffset(Offset = "0x10")]
			internal BackgroundPatcher _003C_003Ef__this;

			[Token(Token = "0x6001D40")]
			[Address(RVA = "0x1EF38BC", Offset = "0x1EF38BC", VA = "0x1EF38BC")]
			public _003CStartPatch_003Ec__AnonStoreyE9()
			{
			}

			[Token(Token = "0x6001D41")]
			[Address(RVA = "0x1EF4050", Offset = "0x1EF4050", VA = "0x1EF4050")]
			internal void _003C_003Em__93()
			{
			}
		}

		[Token(Token = "0x200038F")]
		private sealed class _003CDownloadNotification_003Ec__AnonStoreyEA
		{
			[Token(Token = "0x40012AD")]
			[FieldOffset(Offset = "0x8")]
			internal int state;

			[Token(Token = "0x40012AE")]
			[FieldOffset(Offset = "0xC")]
			internal int taskId;

			[Token(Token = "0x40012AF")]
			[FieldOffset(Offset = "0x10")]
			internal int write;

			[Token(Token = "0x40012B0")]
			[FieldOffset(Offset = "0x14")]
			internal int total;

			[Token(Token = "0x40012B1")]
			[FieldOffset(Offset = "0x18")]
			internal BackgroundPatcher _003C_003Ef__this;

			[Token(Token = "0x6001D42")]
			[Address(RVA = "0x1EF3A3C", Offset = "0x1EF3A3C", VA = "0x1EF3A3C")]
			public _003CDownloadNotification_003Ec__AnonStoreyEA()
			{
			}

			[Token(Token = "0x6001D43")]
			[Address(RVA = "0x1EF3D64", Offset = "0x1EF3D64", VA = "0x1EF3D64")]
			internal void _003C_003Em__94()
			{
			}
		}

		[Token(Token = "0x40012A4")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly BackgroundPatcher Instance;

		[Token(Token = "0x40012A5")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<int, DownloadInfo> downloadInfos;

		[Token(Token = "0x40012A6")]
		[FieldOffset(Offset = "0xC")]
		private string UrlPrefix__BackingField;

		[Token(Token = "0x40012A7")]
		[FieldOffset(Offset = "0x10")]
		private string SaveDirectory__BackingField;

		[Token(Token = "0x40012A8")]
		[FieldOffset(Offset = "0x14")]
		private List<string> DownloadFiles__BackingField;

		[Token(Token = "0x40012A9")]
		[FieldOffset(Offset = "0x18")]
		private IPatchListener PatchListener__BackingField;

		[Token(Token = "0x170004F1")]
		public string UrlPrefix
		{
			[Token(Token = "0x6001D33")]
			[Address(RVA = "0x1EF34BC", Offset = "0x1EF34BC", VA = "0x1EF34BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D34")]
			[Address(RVA = "0x1EF3414", Offset = "0x1EF3414", VA = "0x1EF3414")]
			set
			{
			}
		}

		[Token(Token = "0x170004F2")]
		public string SaveDirectory
		{
			[Token(Token = "0x6001D35")]
			[Address(RVA = "0x1EF34C4", Offset = "0x1EF34C4", VA = "0x1EF34C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D36")]
			[Address(RVA = "0x1EF341C", Offset = "0x1EF341C", VA = "0x1EF341C")]
			set
			{
			}
		}

		[Token(Token = "0x170004F3")]
		public List<string> DownloadFiles
		{
			[Token(Token = "0x6001D37")]
			[Address(RVA = "0x1EF34CC", Offset = "0x1EF34CC", VA = "0x1EF34CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D38")]
			[Address(RVA = "0x1EEBA1C", Offset = "0x1EEBA1C", VA = "0x1EEBA1C")]
			set
			{
			}
		}

		[Token(Token = "0x170004F4")]
		public IPatchListener PatchListener
		{
			[Token(Token = "0x6001D39")]
			[Address(RVA = "0x1EF34D4", Offset = "0x1EF34D4", VA = "0x1EF34D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D3A")]
			[Address(RVA = "0x1EEBA24", Offset = "0x1EEBA24", VA = "0x1EEBA24")]
			set
			{
			}
		}

		[Token(Token = "0x6001D31")]
		[Address(RVA = "0x1EF3284", Offset = "0x1EF3284", VA = "0x1EF3284")]
		public BackgroundPatcher()
		{
		}

		[Token(Token = "0x6001D3B")]
		[Address(RVA = "0x1EEBA2C", Offset = "0x1EEBA2C", VA = "0x1EEBA2C")]
		public void Start()
		{
		}

		[Token(Token = "0x6001D3C")]
		[Address(RVA = "0x1EF34DC", Offset = "0x1EF34DC", VA = "0x1EF34DC")]
		private void StartPatch()
		{
		}

		[Token(Token = "0x6001D3D")]
		[Address(RVA = "0x1EF38C4", Offset = "0x1EF38C4", VA = "0x1EF38C4")]
		private void DownloadNotification(int taskId, int write, int total, int state)
		{
		}

		[Token(Token = "0x6001D3E")]
		[Address(RVA = "0x1EF3A44", Offset = "0x1EF3A44", VA = "0x1EF3A44")]
		private int GetTotalWriteByte()
		{
			return default(int);
		}

		[Token(Token = "0x6001D3F")]
		[Address(RVA = "0x1EF3BC0", Offset = "0x1EF3BC0", VA = "0x1EF3BC0")]
		private bool IsFinishDownload()
		{
			return default(bool);
		}
	}
}
