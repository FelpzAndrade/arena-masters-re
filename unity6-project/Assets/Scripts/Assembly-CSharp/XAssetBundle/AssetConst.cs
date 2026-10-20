using CS;
using Il2CppDummyDll;

namespace XAssetBundle
{
	[Token(Token = "0x200037D")]
	public class AssetConst
	{
		[Token(Token = "0x200037E")]
		public enum WebStorageURL
		{
			[Token(Token = "0x40011F7")]
			LocalDummy = 0,
			[Token(Token = "0x40011F8")]
			S3 = 1
		}

		[Token(Token = "0x40011F3")]
		[FieldOffset(Offset = "0x0")]
		public static WebStorageURL webStorageURL;

		[Token(Token = "0x40011F4")]
		[FieldOffset(Offset = "0x4")]
		public static string AssetBundleKey_Android;

		[Token(Token = "0x40011F5")]
		[FieldOffset(Offset = "0x8")]
		public static string AssetBundleKey_IOS;

		[Token(Token = "0x170004D5")]
		public static string S3_DUMMY_URL
		{
			[Token(Token = "0x6001CCE")]
			[Address(RVA = "0x1EF2538", Offset = "0x1EF2538", VA = "0x1EF2538")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D6")]
		public static string WebStorageURLRoot
		{
			[Token(Token = "0x6001CCF")]
			[Address(RVA = "0x1EEAEE8", Offset = "0x1EEAEE8", VA = "0x1EEAEE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D7")]
		public static bool UsingDummyStorage
		{
			[Token(Token = "0x6001CD0")]
			[Address(RVA = "0x1EEB5D0", Offset = "0x1EEB5D0", VA = "0x1EEB5D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170004D8")]
		public static string PatchStorage
		{
			[Token(Token = "0x6001CD1")]
			[Address(RVA = "0x1EEAB28", Offset = "0x1EEAB28", VA = "0x1EEAB28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D9")]
		public static string RootFolderName
		{
			[Token(Token = "0x6001CD2")]
			[Address(RVA = "0x1EF26A8", Offset = "0x1EF26A8", VA = "0x1EF26A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DA")]
		public static string SourcePathRoot
		{
			[Token(Token = "0x6001CD3")]
			[Address(RVA = "0x1EF2720", Offset = "0x1EF2720", VA = "0x1EF2720")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DB")]
		public static string AssetMovePathRoot
		{
			[Token(Token = "0x6001CD4")]
			[Address(RVA = "0x1EF28E0", Offset = "0x1EF28E0", VA = "0x1EF28E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DC")]
		public static string SourceBundleRoot
		{
			[Token(Token = "0x6001CD5")]
			[Address(RVA = "0x1EF2868", Offset = "0x1EF2868", VA = "0x1EF2868")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DD")]
		public static string MoveBundleRoot
		{
			[Token(Token = "0x6001CD6")]
			[Address(RVA = "0x1EF2A28", Offset = "0x1EF2A28", VA = "0x1EF2A28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DE")]
		public static string SaveFormat
		{
			[Token(Token = "0x6001CD7")]
			[Address(RVA = "0x1EF2AA0", Offset = "0x1EF2AA0", VA = "0x1EF2AA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DF")]
		public static string AssetBundleExtension
		{
			[Token(Token = "0x6001CD8")]
			[Address(RVA = "0x1EF2B18", Offset = "0x1EF2B18", VA = "0x1EF2B18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E0")]
		public static string ManifestFormat
		{
			[Token(Token = "0x6001CD9")]
			[Address(RVA = "0x1EF2B90", Offset = "0x1EF2B90", VA = "0x1EF2B90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E1")]
		public static string LatestFileName
		{
			[Token(Token = "0x6001CDA")]
			[Address(RVA = "0x1EF2C08", Offset = "0x1EF2C08", VA = "0x1EF2C08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E2")]
		public static string AssetManifestName
		{
			[Token(Token = "0x6001CDB")]
			[Address(RVA = "0x1EEAD38", Offset = "0x1EEAD38", VA = "0x1EEAD38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001CCC")]
		[Address(RVA = "0x1EF2474", Offset = "0x1EF2474", VA = "0x1EF2474")]
		public AssetConst()
		{
		}

		[Token(Token = "0x6001CDC")]
		[Address(RVA = "0x1EF2C80", Offset = "0x1EF2C80", VA = "0x1EF2C80")]
		public static string GetAssetScriptVer_DownURL(ConnectEnum.ServerType serverType)
		{
			return null;
		}

		[Token(Token = "0x6001CDD")]
		[Address(RVA = "0x1EF3134", Offset = "0x1EF3134", VA = "0x1EF3134")]
		public static string GetAssetBundleKeyByPlatform(Platform platform)
		{
			return null;
		}
	}
}
