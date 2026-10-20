using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace XAssetBundle
{
	[Token(Token = "0x2000392")]
	public class ResourceLoader : MonoSingleton<ResourceLoader>
	{
		[Token(Token = "0x2000393")]
		public class Cache<T> where T : UnityEngine.Object
		{
			[Token(Token = "0x40012BE")]
			[FieldOffset(Offset = "0x0")]
			private Dictionary<string, T> cache;

			[Token(Token = "0x6001D72")]
			public Cache()
			{
			}

			[Token(Token = "0x6001D73")]
			public void Add(string path, T obj)
			{
			}

			[Token(Token = "0x6001D74")]
			public T Get(string path)
			{
				return null;
			}

			[Token(Token = "0x6001D75")]
			public void Remove(string path)
			{
			}

			[Token(Token = "0x6001D76")]
			public void Clear()
			{
			}

			[Token(Token = "0x6001D77")]
			public Dictionary<string, T>.Enumerator GetEnumerator()
			{
				return default(Dictionary<string, T>.Enumerator);
			}

			[Token(Token = "0x6001D78")]
			public bool TryGetValue(string path, out T obj)
			{
				obj = default;
				return default(bool);
			}

			[Token(Token = "0x6001D79")]
			public bool Peek(string path)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000394")]
		public delegate void ProgressCallBack(string group, int cur, int total, float downloadedBytes);

		[Token(Token = "0x2000395")]
		public delegate void OnCompleteUnityObject(UnityEngine.Object uO);

		[Token(Token = "0x2000396")]
		public delegate void OnCompleteAssetBundle(AssetBundle ab);

		[Token(Token = "0x2000397")]
		public delegate void OnCompletesString(string str);

		[Token(Token = "0x2000398")]
		public delegate void OnCompleteVoid();

		[Token(Token = "0x2000399")]
		private sealed class _003CUnloadAllAssetBundleAllLoadedObjects_003Ec__Iterator32 : IDisposable
		{
			[Token(Token = "0x40012BF")]
			[FieldOffset(Offset = "0x8")]
			internal int _0024PC;

			[Token(Token = "0x40012C0")]
			[FieldOffset(Offset = "0xC")]
			internal object _0024current;

			[Token(Token = "0x40012C1")]
			[FieldOffset(Offset = "0x10")]
			internal ResourceLoader _003C_003Ef__this;

			[Token(Token = "0x170004F6")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x6001D8F")]
				[Address(RVA = "0x1EF5FA8", Offset = "0x1EF5FA8", VA = "0x1EF5FA8", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170004F7")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6001D90")]
				[Address(RVA = "0x1EF5FB0", Offset = "0x1EF5FB0", VA = "0x1EF5FB0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001D8E")]
			[Address(RVA = "0x1EF5FA0", Offset = "0x1EF5FA0", VA = "0x1EF5FA0")]
			public _003CUnloadAllAssetBundleAllLoadedObjects_003Ec__Iterator32()
			{
			}

			[Token(Token = "0x6001D8F")]
			[Address(RVA = "0x1EF5FA8", Offset = "0x1EF5FA8", VA = "0x1EF5FA8", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001D90")]
			[Address(RVA = "0x1EF5FB0", Offset = "0x1EF5FB0", VA = "0x1EF5FB0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001D91")]
			[Address(RVA = "0x1EF5FB8", Offset = "0x1EF5FB8", VA = "0x1EF5FB8", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6001D92")]
			[Address(RVA = "0x1EF6678", Offset = "0x1EF6678", VA = "0x1EF6678", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6001D93")]
			[Address(RVA = "0x1EF6684", Offset = "0x1EF6684", VA = "0x1EF6684", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40012BA")]
		[FieldOffset(Offset = "0xC")]
		private AssetbundlePatcher m_assetBundlePatcher;

		[Token(Token = "0x40012BB")]
		[FieldOffset(Offset = "0x10")]
		private bool m_usingAssetBundle;

		[Token(Token = "0x40012BC")]
		[FieldOffset(Offset = "0x14")]
		private List<XAssetBundleLoadAssetOperation> operationList;

		[Token(Token = "0x40012BD")]
		[FieldOffset(Offset = "0x18")]
		public Cache<UnityEngine.Object> ResourceCache;

		[Token(Token = "0x170004F5")]
		public bool usingAssetBundle
		{
			[Token(Token = "0x6001D64")]
			[Address(RVA = "0x1EF5720", Offset = "0x1EF5720", VA = "0x1EF5720")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6001D63")]
		[Address(RVA = "0x1EF55FC", Offset = "0x1EF55FC", VA = "0x1EF55FC")]
		public ResourceLoader()
		{
		}

		[Token(Token = "0x6001D65")]
		[Address(RVA = "0x1EF57E0", Offset = "0x1EF57E0", VA = "0x1EF57E0")]
		public UnityEngine.Object InstantiateObject(UnityEngine.Object prefab)
		{
			return null;
		}

		[Token(Token = "0x6001D66")]
		[Address(RVA = "0x1EF5888", Offset = "0x1EF5888", VA = "0x1EF5888", Slot = "5")]
		public override void Init()
		{
		}

		[Token(Token = "0x6001D67")]
		private void GetAndAddComponent<T>(ref T obj) where T : Component
		{
		}

		[Token(Token = "0x6001D68")]
		[Address(RVA = "0x1EF59B0", Offset = "0x1EF59B0", VA = "0x1EF59B0")]
		public void CheckUpdateAssetBundle(Action<AssetbundlePatcher.Flow> onProgress, Action<AssetbundlePatcher.Result, int, float> onComplete)
		{
		}

		[Token(Token = "0x6001D69")]
		[Address(RVA = "0x1EF5A98", Offset = "0x1EF5A98", VA = "0x1EF5A98")]
		public void DoUpdateAssetbundle(ProgressCallBack pgCallBack, Action<AssetbundlePatcher.Result> onComplete)
		{
		}

		[Token(Token = "0x6001D6A")]
		[Address(RVA = "0x1EE8B78", Offset = "0x1EE8B78", VA = "0x1EE8B78")]
		public UnityEngine.Object Load(string relativePath, bool unloadAssetbundleRightAway = false)
		{
			return null;
		}

		[Token(Token = "0x6001D6B")]
		public T Load<T>(string relativePath, bool unloadAssetbundleRightAway = false) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6001D6C")]
		public T[] LoadAll<T>(string relativePath, bool unloadAssetbundleRightAway = false) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6001D6D")]
		[Address(RVA = "0x1EF5B6C", Offset = "0x1EF5B6C", VA = "0x1EF5B6C")]
		public XAssetBundleLoadAssetOperation LoadAsync(string relativePath)
		{
			return null;
		}

		[Token(Token = "0x6001D6E")]
		public XAssetBundleLoadAssetOperation LoadAsync<T>(string relativePath) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6001D6F")]
		[Address(RVA = "0x1EF5BF8", Offset = "0x1EF5BF8", VA = "0x1EF5BF8")]
		public bool HasAsyncOperation()
		{
			return default(bool);
		}

		[Token(Token = "0x6001D70")]
		[Address(RVA = "0x1EF5CA0", Offset = "0x1EF5CA0", VA = "0x1EF5CA0")]
		private void Update()
		{
		}

		[Token(Token = "0x6001D71")]
		[Address(RVA = "0x1EF5EFC", Offset = "0x1EF5EFC", VA = "0x1EF5EFC")]
		[DebuggerHidden]
		public IEnumerator UnloadAllAssetBundleAllLoadedObjects()
		{
			return null;
		}
	}
}
