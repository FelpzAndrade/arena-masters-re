using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace XAssetBundle
{
	[Token(Token = "0x2000374")]
	public class XAssetBundleManager : MonoBehaviour
	{
		[Token(Token = "0x2000375")]
		public enum LogMode
		{
			[Token(Token = "0x40011E2")]
			All = 0,
			[Token(Token = "0x40011E3")]
			JustErrors = 1
		}

		[Token(Token = "0x2000376")]
		public enum LogType
		{
			[Token(Token = "0x40011E5")]
			Info = 0,
			[Token(Token = "0x40011E6")]
			Warning = 1,
			[Token(Token = "0x40011E7")]
			Error = 2
		}

		[Token(Token = "0x2000377")]
		public class AsyncStreamManager
		{
			[Token(Token = "0x40011E8")]
			private const int constMaxStream = 3;

			[Token(Token = "0x40011E9")]
			[FieldOffset(Offset = "0x8")]
			private int maxStream;

			[Token(Token = "0x40011EA")]
			[FieldOffset(Offset = "0xC")]
			private List<AsyncOperation> operatingList;

			[Token(Token = "0x40011EB")]
			[FieldOffset(Offset = "0x10")]
			private Queue<AsyncRequestReserve> queue;

			[Token(Token = "0x6001CB7")]
			[Address(RVA = "0x1EF8458", Offset = "0x1EF8458", VA = "0x1EF8458")]
			public AsyncStreamManager()
			{
			}

			[Token(Token = "0x6001CB8")]
			[Address(RVA = "0x1EFB698", Offset = "0x1EFB698", VA = "0x1EFB698")]
			public void SetMaxStream(int stream)
			{
			}

			[Token(Token = "0x6001CB9")]
			[Address(RVA = "0x1EFB6A0", Offset = "0x1EFB6A0", VA = "0x1EFB6A0")]
			public void ResetMaxStream()
			{
			}

			[Token(Token = "0x6001CBA")]
			[Address(RVA = "0x1EFB6AC", Offset = "0x1EFB6AC", VA = "0x1EFB6AC")]
			private bool IsMaxStream()
			{
				return default(bool);
			}

			[Token(Token = "0x6001CBB")]
			[Address(RVA = "0x1EFAA40", Offset = "0x1EFAA40", VA = "0x1EFAA40")]
			public void Update()
			{
			}

			[Token(Token = "0x6001CBC")]
			[Address(RVA = "0x1EFB758", Offset = "0x1EFB758", VA = "0x1EFB758")]
			private void AddOperation(AsyncOperation op)
			{
			}

			[Token(Token = "0x6001CBD")]
			[Address(RVA = "0x1EF7624", Offset = "0x1EF7624", VA = "0x1EF7624")]
			public void Enqueue(AsyncRequestReserve reqReserve)
			{
			}
		}

		[Token(Token = "0x2000378")]
		public abstract class AsyncRequestReserve
		{
			[Token(Token = "0x170004D0")]
			public abstract bool isDone
			{
				[Token(Token = "0x6001CC0")]
				get;
			}

			[Token(Token = "0x6001CBE")]
			[Address(RVA = "0x1EFB524", Offset = "0x1EFB524", VA = "0x1EFB524")]
			protected AsyncRequestReserve()
			{
			}

			[Token(Token = "0x6001CBF")]
			public abstract AsyncOperation Request();
		}

		[Token(Token = "0x2000379")]
		public abstract class AssetBundleCreateRequestReserve : AsyncRequestReserve
		{
			[Token(Token = "0x40011EC")]
			[FieldOffset(Offset = "0x8")]
			protected AssetBundleCreateRequest req;

			[Token(Token = "0x170004D1")]
			public AssetBundle AssetBundle
			{
				[Token(Token = "0x6001CC2")]
				[Address(RVA = "0x1EFAC44", Offset = "0x1EFAC44", VA = "0x1EFAC44")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004D2")]
			public override bool isDone
			{
				[Token(Token = "0x6001CC3")]
				[Address(RVA = "0x1EFB52C", Offset = "0x1EFB52C", VA = "0x1EFB52C", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6001CC1")]
			[Address(RVA = "0x1EFB4D4", Offset = "0x1EFB4D4", VA = "0x1EFB4D4")]
			protected AssetBundleCreateRequestReserve()
			{
			}
		}

		[Token(Token = "0x200037A")]
		public class AssetBundleCreateRequestFromMemoryReserve : AssetBundleCreateRequestReserve
		{
			[Token(Token = "0x40011ED")]
			[FieldOffset(Offset = "0xC")]
			private byte[] data;

			[Token(Token = "0x6001CC4")]
			[Address(RVA = "0x1EF9A94", Offset = "0x1EF9A94", VA = "0x1EF9A94")]
			public AssetBundleCreateRequestFromMemoryReserve(byte[] data)
			{
			}

			[Token(Token = "0x6001CC5")]
			[Address(RVA = "0x1EFB4DC", Offset = "0x1EFB4DC", VA = "0x1EFB4DC", Slot = "4")]
			public override AsyncOperation Request()
			{
				return null;
			}
		}

		[Token(Token = "0x200037B")]
		public class AssetBundleCreateRequestFromPathReserve : AssetBundleCreateRequestReserve
		{
			[Token(Token = "0x40011EE")]
			[FieldOffset(Offset = "0xC")]
			private string path;

			[Token(Token = "0x6001CC6")]
			[Address(RVA = "0x1EF9AB4", Offset = "0x1EF9AB4", VA = "0x1EF9AB4")]
			public AssetBundleCreateRequestFromPathReserve(string path)
			{
			}

			[Token(Token = "0x6001CC7")]
			[Address(RVA = "0x1EFB500", Offset = "0x1EFB500", VA = "0x1EFB500", Slot = "4")]
			public override AsyncOperation Request()
			{
				return null;
			}
		}

		[Token(Token = "0x200037C")]
		public class AssetBundleRequestReserve : AsyncRequestReserve
		{
			[Token(Token = "0x40011EF")]
			[FieldOffset(Offset = "0x8")]
			private AssetBundle assetbundle;

			[Token(Token = "0x40011F0")]
			[FieldOffset(Offset = "0xC")]
			private string assetName;

			[Token(Token = "0x40011F1")]
			[FieldOffset(Offset = "0x10")]
			private Type type;

			[Token(Token = "0x40011F2")]
			[FieldOffset(Offset = "0x14")]
			private AssetBundleRequest req;

			[Token(Token = "0x170004D3")]
			public override bool isDone
			{
				[Token(Token = "0x6001CCA")]
				[Address(RVA = "0x1EFB644", Offset = "0x1EFB644", VA = "0x1EFB644", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170004D4")]
			public UnityEngine.Object asset
			{
				[Token(Token = "0x6001CCB")]
				[Address(RVA = "0x1EFB66C", Offset = "0x1EFB66C", VA = "0x1EFB66C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6001CC8")]
			[Address(RVA = "0x1EF75F4", Offset = "0x1EF75F4", VA = "0x1EF75F4")]
			public AssetBundleRequestReserve(AssetBundle assetbundle, string assetName, Type type)
			{
			}

			[Token(Token = "0x6001CC9")]
			[Address(RVA = "0x1EFB554", Offset = "0x1EFB554", VA = "0x1EFB554", Slot = "4")]
			public override AsyncOperation Request()
			{
				return null;
			}
		}

		[Token(Token = "0x40011D2")]
		[FieldOffset(Offset = "0x0")]
		private static LogMode m_LogMode;

		[Token(Token = "0x40011D3")]
		[FieldOffset(Offset = "0x4")]
		private static string m_BaseFilePath;

		[Token(Token = "0x40011D4")]
		[FieldOffset(Offset = "0x8")]
		private static string[] m_ActiveVariants;

		[Token(Token = "0x40011D5")]
		[FieldOffset(Offset = "0xC")]
		private static AssetBundleManifest m_AssetBundleManifest;

		[Token(Token = "0x40011D6")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<string, XLoadedAssetBundle> m_LoadedAssetBundles;

		[Token(Token = "0x40011D7")]
		[FieldOffset(Offset = "0x14")]
		private static Dictionary<string, AssetBundleCreateRequestReserve> m_CreateRequestings;

		[Token(Token = "0x40011D8")]
		[FieldOffset(Offset = "0x18")]
		private static Dictionary<string, string> m_DownloadingErrors;

		[Token(Token = "0x40011D9")]
		[FieldOffset(Offset = "0x1C")]
		private static List<XAssetBundleLoadOperation> m_InProgressOperations;

		[Token(Token = "0x40011DA")]
		[FieldOffset(Offset = "0x20")]
		private static Dictionary<string, string[]> m_Dependencies;

		[Token(Token = "0x40011DB")]
		[FieldOffset(Offset = "0x24")]
		private static HashSet<string> occupy;

		[Token(Token = "0x40011DC")]
		[FieldOffset(Offset = "0x28")]
		private static bool isIgnoreOccupy;

		[Token(Token = "0x40011DD")]
		[FieldOffset(Offset = "0x2C")]
		private static GameObject m_go;

		[Token(Token = "0x40011DE")]
		[FieldOffset(Offset = "0x30")]
		private static StringBuilder m_builder;

		[Token(Token = "0x40011DF")]
		[FieldOffset(Offset = "0xC")]
		private List<string> keysToRemove;

		[Token(Token = "0x40011E0")]
		[FieldOffset(Offset = "0x34")]
		public static AsyncStreamManager asyncStreamManager;

		[Token(Token = "0x170004CC")]
		public static LogMode logMode
		{
			[Token(Token = "0x6001C99")]
			[Address(RVA = "0x1EF8540", Offset = "0x1EF8540", VA = "0x1EF8540")]
			get
			{
				return default(LogMode);
			}
			[Token(Token = "0x6001C9A")]
			[Address(RVA = "0x1EF85F0", Offset = "0x1EF85F0", VA = "0x1EF85F0")]
			set
			{
			}
		}

		[Token(Token = "0x170004CD")]
		public static string BaseFilePath
		{
			[Token(Token = "0x6001C9B")]
			[Address(RVA = "0x1EF86A4", Offset = "0x1EF86A4", VA = "0x1EF86A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C9C")]
			[Address(RVA = "0x1EF8754", Offset = "0x1EF8754", VA = "0x1EF8754")]
			set
			{
			}
		}

		[Token(Token = "0x170004CE")]
		public static string[] ActiveVariants
		{
			[Token(Token = "0x6001C9D")]
			[Address(RVA = "0x1EF8808", Offset = "0x1EF8808", VA = "0x1EF8808")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C9E")]
			[Address(RVA = "0x1EF88B8", Offset = "0x1EF88B8", VA = "0x1EF88B8")]
			set
			{
			}
		}

		[Token(Token = "0x170004CF")]
		public static AssetBundleManifest AssetBundleManifestObject
		{
			[Token(Token = "0x6001C9F")]
			[Address(RVA = "0x1EF7F0C", Offset = "0x1EF7F0C", VA = "0x1EF7F0C")]
			set
			{
			}
		}

		[Token(Token = "0x6001C97")]
		[Address(RVA = "0x1EF80BC", Offset = "0x1EF80BC", VA = "0x1EF80BC")]
		public XAssetBundleManager()
		{
		}

		[Token(Token = "0x6001CA0")]
		[Address(RVA = "0x1EF793C", Offset = "0x1EF793C", VA = "0x1EF793C")]
		public static void Log(LogType logType, string text)
		{
		}

		[Token(Token = "0x6001CA1")]
		[Address(RVA = "0x1EF896C", Offset = "0x1EF896C", VA = "0x1EF896C")]
		public static void SetSourceAssetBundlePath(string absolutePath)
		{
		}

		[Token(Token = "0x6001CA2")]
		[Address(RVA = "0x1EF8A0C", Offset = "0x1EF8A0C", VA = "0x1EF8A0C")]
		public static void IgnoreOccupy(bool enable)
		{
		}

		[Token(Token = "0x6001CA3")]
		[Address(RVA = "0x1EF74BC", Offset = "0x1EF74BC", VA = "0x1EF74BC")]
		public static bool IsOccupied(string res)
		{
			return default(bool);
		}

		[Token(Token = "0x6001CA4")]
		[Address(RVA = "0x1EF7720", Offset = "0x1EF7720", VA = "0x1EF7720")]
		public static void Occupy(string res)
		{
		}

		[Token(Token = "0x6001CA5")]
		[Address(RVA = "0x1EF703C", Offset = "0x1EF703C", VA = "0x1EF703C")]
		public static void Unoccupy(string res)
		{
		}

		[Token(Token = "0x6001CA6")]
		[Address(RVA = "0x1EF7128", Offset = "0x1EF7128", VA = "0x1EF7128")]
		public static XLoadedAssetBundle GetLoadedAssetBundle(string assetBundleName, out string error)
		{
			error = default;
			return null;
		}

		[Token(Token = "0x6001CA7")]
		[Address(RVA = "0x1EED7C4", Offset = "0x1EED7C4", VA = "0x1EED7C4")]
		public static void Initialize(AssetBundleManifest manifest, string basePath)
		{
		}

		[Token(Token = "0x6001CA8")]
		[Address(RVA = "0x1EF8AC0", Offset = "0x1EF8AC0", VA = "0x1EF8AC0")]
		protected static void LoadAssetBundleAsync(string assetBundleName)
		{
		}

		[Token(Token = "0x6001CA9")]
		[Address(RVA = "0x1EF91A4", Offset = "0x1EF91A4", VA = "0x1EF91A4")]
		protected static AssetBundle LoadAssetBundle(string assetBundleName)
		{
			return null;
		}

		[Token(Token = "0x6001CAA")]
		[Address(RVA = "0x1EF8BA0", Offset = "0x1EF8BA0", VA = "0x1EF8BA0")]
		protected static bool LoadAssetBundleAsyncInternal(string assetBundleName)
		{
			return default(bool);
		}

		[Token(Token = "0x6001CAB")]
		[Address(RVA = "0x1EF9880", Offset = "0x1EF9880", VA = "0x1EF9880")]
		private static string GetassetBundlePath(string assetBundleName)
		{
			return null;
		}

		[Token(Token = "0x6001CAC")]
		[Address(RVA = "0x1EF92A4", Offset = "0x1EF92A4", VA = "0x1EF92A4")]
		protected static AssetBundle LoadAssetBundleInternal(string assetBundleName, out bool isAlreadyProcessed)
		{
			isAlreadyProcessed = default;
			return null;
		}

		[Token(Token = "0x6001CAD")]
		[Address(RVA = "0x1EF8ED0", Offset = "0x1EF8ED0", VA = "0x1EF8ED0")]
		protected static void LoadDependenciesAsync(string assetBundleName)
		{
		}

		[Token(Token = "0x6001CAE")]
		[Address(RVA = "0x1EF9590", Offset = "0x1EF9590", VA = "0x1EF9590")]
		protected static void LoadDependencies(string assetBundleName)
		{
		}

		[Token(Token = "0x6001CAF")]
		[Address(RVA = "0x1EF60AC", Offset = "0x1EF60AC", VA = "0x1EF60AC")]
		public static void UnloadAllAssetBundleAllLoadedObjects()
		{
		}

		[Token(Token = "0x6001CB0")]
		[Address(RVA = "0x1EF9AFC", Offset = "0x1EF9AFC", VA = "0x1EF9AFC")]
		public static void UnloadAssetBundle(string assetBundleName, bool unloadAllLoadedObjects)
		{
		}

		[Token(Token = "0x6001CB1")]
		[Address(RVA = "0x1EF9D94", Offset = "0x1EF9D94", VA = "0x1EF9D94")]
		protected static void UnloadDependencies(string assetBundleName, bool unloadAllLoadedObjects)
		{
		}

		[Token(Token = "0x6001CB2")]
		[Address(RVA = "0x1EF9BD4", Offset = "0x1EF9BD4", VA = "0x1EF9BD4")]
		protected static void UnloadAssetBundleInternal(string assetBundleName, bool unloadAllLoadedObjects)
		{
		}

		[Token(Token = "0x6001CB3")]
		[Address(RVA = "0x1EF9F98", Offset = "0x1EF9F98", VA = "0x1EF9F98")]
		private void Update()
		{
		}

		[Token(Token = "0x6001CB4")]
		[Address(RVA = "0x1EFAC98", Offset = "0x1EFAC98", VA = "0x1EFAC98")]
		public static XAssetBundleLoadAssetOperation LoadAssetAsync(string relativePath, string assetBundleName, string assetName, Type type)
		{
			return null;
		}

		[Token(Token = "0x6001CB5")]
		[Address(RVA = "0x1EFB02C", Offset = "0x1EFB02C", VA = "0x1EFB02C")]
		public static AssetBundle LoadAsset(string assetBundleName)
		{
			return null;
		}

		[Token(Token = "0x6001CB6")]
		[Address(RVA = "0x1EFB150", Offset = "0x1EFB150", VA = "0x1EFB150")]
		public static XAssetBundleLoadOperation LoadLevelAsync(string assetBundleName, string levelName, bool isAdditive)
		{
			return null;
		}
	}
}
