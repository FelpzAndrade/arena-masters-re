using Il2CppDummyDll;

namespace XAssetBundle
{
	[Token(Token = "0x200038C")]
	public class DownloadInfo
	{
		[Token(Token = "0x40012A0")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x40012A1")]
		[FieldOffset(Offset = "0xC")]
		public int write;

		[Token(Token = "0x40012A2")]
		[FieldOffset(Offset = "0x10")]
		public int total;

		[Token(Token = "0x40012A3")]
		[FieldOffset(Offset = "0x14")]
		public DownloadState state;

		[Token(Token = "0x6001D2F")]
		[Address(RVA = "0x1EF4148", Offset = "0x1EF4148", VA = "0x1EF4148")]
		public DownloadInfo(string name, int write, int total, DownloadState state)
		{
		}

		[Token(Token = "0x6001D30")]
		[Address(RVA = "0x1EF3D40", Offset = "0x1EF3D40", VA = "0x1EF3D40")]
		public bool IsFinish()
		{
			return default(bool);
		}
	}
}
