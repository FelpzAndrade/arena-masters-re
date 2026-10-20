using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace XAssetBundle
{
	[Token(Token = "0x2000380")]
	public class AssetbundlePatcher : MonoBehaviour, IPatchListener
	{
		[Token(Token = "0x2000381")]
		public enum Flow
		{
			[Token(Token = "0x400120B")]
			CheckAPKUpdate = 0,
			[Token(Token = "0x400120C")]
			CheckLocalManifest = 1,
			[Token(Token = "0x400120D")]
			CheckServerManifest = 2,
			[Token(Token = "0x400120E")]
			CheckAssetUpdate = 3,
			[Token(Token = "0x400120F")]
			RemoveAsset = 4,
			[Token(Token = "0x4001210")]
			CheckContinueDownload = 5,
			[Token(Token = "0x4001211")]
			CheckDownloadSize = 6,
			[Token(Token = "0x4001212")]
			DownloadingFile = 7,
			[Token(Token = "0x4001213")]
			SaveServerManifestToLocal = 8
		}

		[Token(Token = "0x2000382")]
		public enum Result
		{
			[Token(Token = "0x4001215")]
			DownloadFailServerManifest = 0,
			[Token(Token = "0x4001216")]
			NotExistServerManifest = 1,
			[Token(Token = "0x4001217")]
			DownloadFailAssetbundle = 2,
			[Token(Token = "0x4001218")]
			DownloadFailDownSize = 3,
			[Token(Token = "0x4001219")]
			DownloadFailHashList = 4,
			[Token(Token = "0x400121A")]
			FileSaveFail = 5,
			[Token(Token = "0x400121B")]
			FileValidationCheckFail = 6,
			[Token(Token = "0x400121C")]
			NotCalledCheckPath = 7,
			[Token(Token = "0x400121D")]
			APKUpdate = 8,
			[Token(Token = "0x400121E")]
			Success = 9
		}

		[Token(Token = "0x2000383")]
		private sealed class _003C_CheckPatch_003Ec__Iterator2C : IDisposable
		{
			[Token(Token = "0x400121F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Result _003CpatchResult_003E__0;

			[Token(Token = "0x4001220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Action<Flow> onProgress;

			[Token(Token = "0x4001221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal AssetBundle _003CassetBundle_003E__1;

			[Token(Token = "0x4001222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal Action<Result, int, float> onComplete;

			[Token(Token = "0x4001223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal AssetbundleManifestCompare _003Ccompare_003E__2;

			[Token(Token = "0x4001224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal string _003CsaveBasePath_003E__3;

			[Token(Token = "0x4001225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal List<string> _003CdownCompleteList_003E__4;

			[Token(Token = "0x4001226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal List<string> _003CremovedList_003E__5;

			[Token(Token = "0x4001227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal int _003Ci_003E__6;

			[Token(Token = "0x4001228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal string _003CremovedItem_003E__7;

			[Token(Token = "0x4001229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal string _003CremovePath_003E__8;

			[Token(Token = "0x400122A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal List<string> _003CupdateList_003E__9;

			[Token(Token = "0x400122B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal int _003CdownloadNeedFIleNum_003E__10;

			[Token(Token = "0x400122C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal float _003CdownloadSizeBytes_003E__11;

			[Token(Token = "0x400122D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal int _0024PC;

			[Token(Token = "0x400122E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal object _0024current;

			[Token(Token = "0x400122F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal Action<Flow> _003C_0024_003EonProgress;

			[Token(Token = "0x4001230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			internal Action<Result, int, float> _003C_0024_003EonComplete;

			[Token(Token = "0x4001231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal AssetbundlePatcher _003C_003Ef__this;

			[Token(Token = "0x170004E5")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x6001D01")]
				[Address(RVA = "0x1EEE400", Offset = "0x1EEE400", VA = "0x1EEE400", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170004E6")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6001D02")]
				[Address(RVA = "0x1EEE408", Offset = "0x1EEE408", VA = "0x1EEE408", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001D00")]
			[Address(RVA = "0x1EEBDBC", Offset = "0x1EEBDBC", VA = "0x1EEBDBC")]
			public _003C_CheckPatch_003Ec__Iterator2C()
			{
			}

			[Token(Token = "0x6001D01")]
			[Address(RVA = "0x1EEE400", Offset = "0x1EEE400", VA = "0x1EEE400", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001D02")]
			[Address(RVA = "0x1EEE408", Offset = "0x1EEE408", VA = "0x1EEE408", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001D03")]
			[Address(RVA = "0x1EEE410", Offset = "0x1EEE410", VA = "0x1EEE410", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6001D04")]
			[Address(RVA = "0x1EEF080", Offset = "0x1EEF080", VA = "0x1EEF080", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6001D05")]
			[Address(RVA = "0x1EEF08C", Offset = "0x1EEF08C", VA = "0x1EEF08C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			[Token(Token = "0x6001D06")]
			[Address(RVA = "0x1EEF120", Offset = "0x1EEF120", VA = "0x1EEF120")]
			internal void _003C_003Em__8F(Result result, AssetBundleManifest manifest, byte[] bytes)
			{
			}

			[Token(Token = "0x6001D07")]
			[Address(RVA = "0x1EEF158", Offset = "0x1EEF158", VA = "0x1EEF158")]
			internal void _003C_003Em__90(Result result)
			{
			}

			[Token(Token = "0x6001D08")]
			[Address(RVA = "0x1EEF160", Offset = "0x1EEF160", VA = "0x1EEF160")]
			internal void _003C_003Em__91(Result result, float totalBytes)
			{
			}
		}

		[Token(Token = "0x2000384")]
		private sealed class _003C_StartPatch_003Ec__Iterator2D : IDisposable
		{
			[Token(Token = "0x4001232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Result _003CpatchResult_003E__0;

			[Token(Token = "0x4001233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal ResourceLoader.ProgressCallBack pgCallBack;

			[Token(Token = "0x4001234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal List<string> downNeedList;

			[Token(Token = "0x4001235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal string saveBasePath;

			[Token(Token = "0x4001236")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal byte[] serverManifestBytes;

			[Token(Token = "0x4001237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal Action<Result> onComplete;

			[Token(Token = "0x4001238")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int _0024PC;

			[Token(Token = "0x4001239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal object _0024current;

			[Token(Token = "0x400123A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ResourceLoader.ProgressCallBack _003C_0024_003EpgCallBack;

			[Token(Token = "0x400123B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal List<string> _003C_0024_003EdownNeedList;

			[Token(Token = "0x400123C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal string _003C_0024_003EsaveBasePath;

			[Token(Token = "0x400123D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal byte[] _003C_0024_003EserverManifestBytes;

			[Token(Token = "0x400123E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Action<Result> _003C_0024_003EonComplete;

			[Token(Token = "0x400123F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal AssetbundlePatcher _003C_003Ef__this;

			[Token(Token = "0x170004E7")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x6001D0A")]
				[Address(RVA = "0x1EEF16C", Offset = "0x1EEF16C", VA = "0x1EEF16C", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170004E8")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6001D0B")]
				[Address(RVA = "0x1EEF174", Offset = "0x1EEF174", VA = "0x1EEF174", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001D09")]
			[Address(RVA = "0x1EEBDC4", Offset = "0x1EEBDC4", VA = "0x1EEBDC4")]
			public _003C_StartPatch_003Ec__Iterator2D()
			{
			}

			[Token(Token = "0x6001D0A")]
			[Address(RVA = "0x1EEF16C", Offset = "0x1EEF16C", VA = "0x1EEF16C", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001D0B")]
			[Address(RVA = "0x1EEF174", Offset = "0x1EEF174", VA = "0x1EEF174", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001D0C")]
			[Address(RVA = "0x1EEF17C", Offset = "0x1EEF17C", VA = "0x1EEF17C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6001D0D")]
			[Address(RVA = "0x1EEF32C", Offset = "0x1EEF32C", VA = "0x1EEF32C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6001D0E")]
			[Address(RVA = "0x1EEF338", Offset = "0x1EEF338", VA = "0x1EEF338", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			[Token(Token = "0x6001D0F")]
			[Address(RVA = "0x1EEF3CC", Offset = "0x1EEF3CC", VA = "0x1EEF3CC")]
			internal void _003C_003Em__92(Result result)
			{
			}
		}

		[Token(Token = "0x2000385")]
		private sealed class _003CDownloadFilesAndSave_003Ec__Iterator2E : IDisposable
		{
			[Token(Token = "0x4001240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal int _003CprogressCount_003E__0;

			[Token(Token = "0x4001241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal List<string> updatedList;

			[Token(Token = "0x4001242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int _003CtotalCnt_003E__1;

			[Token(Token = "0x4001243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal float _003CdownloadedCompleteBytes_003E__2;

			[Token(Token = "0x4001244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal ResourceLoader.ProgressCallBack pgCallBack;

			[Token(Token = "0x4001245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal Dictionary<string, float> _003CdownloadingBytesDic_003E__3;

			[Token(Token = "0x4001246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal bool _003CisComplete_003E__4;

			[Token(Token = "0x4001247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal int _003CfailCount_003E__5;

			[Token(Token = "0x4001248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal int _003CfailThresHold_003E__6;

			[Token(Token = "0x4001249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal List<string> _003CdownCompleteList_003E__7;

			[Token(Token = "0x400124A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Dictionary<string, WWW> _003CdownloadingList_003E__8;

			[Token(Token = "0x400124B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal List<string> _003CredownloadList_003E__9;

			[Token(Token = "0x400124C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Queue<string> _003Cqueue_003E__10;

			[Token(Token = "0x400124D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal int _003CthreadMax_003E__11;

			[Token(Token = "0x400124E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal int _003Ci_003E__12;

			[Token(Token = "0x400124F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal string _003CgroupName_003E__13;

			[Token(Token = "0x4001250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal List<string> _003Ccomplete_003E__14;

			[Token(Token = "0x4001251")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			internal string _003Cg_003E__15;

			[Token(Token = "0x4001252")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal string _003Curl_003E__16;

			[Token(Token = "0x4001253")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			internal bool _003CstopDownLoading_003E__17;

			[Token(Token = "0x4001254")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal Dictionary<string, WWW>.Enumerator _003Cenumerator_003E__18;

			[Token(Token = "0x4001255")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			internal KeyValuePair<string, WWW> _003CdownloadingItem_003E__19;

			[Token(Token = "0x4001256")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			internal WWW _003Cw_003E__20;

			[Token(Token = "0x4001257")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			internal int _003Ci_003E__21;

			[Token(Token = "0x4001258")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			internal string _003CredownloadItem_003E__22;

			[Token(Token = "0x4001259")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			internal Action<Result> callback;

			[Token(Token = "0x400125A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			internal int _003Ci_003E__23;

			[Token(Token = "0x400125B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			internal string _003CcompleteStr_003E__24;

			[Token(Token = "0x400125C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			internal WWW _003Cw_003E__25;

			[Token(Token = "0x400125D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			internal string saveBasePath;

			[Token(Token = "0x400125E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			internal string _003CsavePath_003E__26;

			[Token(Token = "0x400125F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			internal Result _003Cresult_003E__27;

			[Token(Token = "0x4001260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			internal Result _003Cresult_003E__28;

			[Token(Token = "0x4001261")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			internal float _003CdownloadingBytes_003E__29;

			[Token(Token = "0x4001262")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			internal Dictionary<string, float>.Enumerator _003CdownloadingBytesEnumerator_003E__30;

			[Token(Token = "0x4001263")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			internal int _0024PC;

			[Token(Token = "0x4001264")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			internal object _0024current;

			[Token(Token = "0x4001265")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			internal List<string> _003C_0024_003EupdatedList;

			[Token(Token = "0x4001266")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			internal ResourceLoader.ProgressCallBack _003C_0024_003EpgCallBack;

			[Token(Token = "0x4001267")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			internal Action<Result> _003C_0024_003Ecallback;

			[Token(Token = "0x4001268")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			internal string _003C_0024_003EsaveBasePath;

			[Token(Token = "0x4001269")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			internal AssetbundlePatcher _003C_003Ef__this;

			[Token(Token = "0x170004E9")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x6001D11")]
				[Address(RVA = "0x1EEF3D4", Offset = "0x1EEF3D4", VA = "0x1EEF3D4", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170004EA")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6001D12")]
				[Address(RVA = "0x1EEF3DC", Offset = "0x1EEF3DC", VA = "0x1EEF3DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001D10")]
			[Address(RVA = "0x1EEC730", Offset = "0x1EEC730", VA = "0x1EEC730")]
			public _003CDownloadFilesAndSave_003Ec__Iterator2E()
			{
			}

			[Token(Token = "0x6001D11")]
			[Address(RVA = "0x1EEF3D4", Offset = "0x1EEF3D4", VA = "0x1EEF3D4", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001D12")]
			[Address(RVA = "0x1EEF3DC", Offset = "0x1EEF3DC", VA = "0x1EEF3DC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001D13")]
			[Address(RVA = "0x1EEF3E4", Offset = "0x1EEF3E4", VA = "0x1EEF3E4", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6001D14")]
			[Address(RVA = "0x1EF0734", Offset = "0x1EF0734", VA = "0x1EF0734", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6001D15")]
			[Address(RVA = "0x1EF0740", Offset = "0x1EF0740", VA = "0x1EF0740", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000386")]
		private sealed class _003CManifestSetup_003Ec__Iterator2F : IDisposable
		{
			[Token(Token = "0x400126A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal AssetBundleManifest _003Cmanifest_003E__0;

			[Token(Token = "0x400126B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Result _003Cresult_003E__1;

			[Token(Token = "0x400126C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string url;

			[Token(Token = "0x400126D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal string manifestName;

			[Token(Token = "0x400126E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal WWW _003CwwwManifest_003E__2;

			[Token(Token = "0x400126F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal Action<float> progress;

			[Token(Token = "0x4001270")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal AssetBundle _003CmanifestBundle_003E__3;

			[Token(Token = "0x4001271")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal Action<Result, AssetBundleManifest, byte[]> callBack;

			[Token(Token = "0x4001272")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal int _0024PC;

			[Token(Token = "0x4001273")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal object _0024current;

			[Token(Token = "0x4001274")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal string _003C_0024_003Eurl;

			[Token(Token = "0x4001275")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal string _003C_0024_003EmanifestName;

			[Token(Token = "0x4001276")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Action<float> _003C_0024_003Eprogress;

			[Token(Token = "0x4001277")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal Action<Result, AssetBundleManifest, byte[]> _003C_0024_003EcallBack;

			[Token(Token = "0x4001278")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal AssetbundlePatcher _003C_003Ef__this;

			[Token(Token = "0x170004EB")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x6001D17")]
				[Address(RVA = "0x1EF1D70", Offset = "0x1EF1D70", VA = "0x1EF1D70", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170004EC")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6001D18")]
				[Address(RVA = "0x1EF1D78", Offset = "0x1EF1D78", VA = "0x1EF1D78", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001D16")]
			[Address(RVA = "0x1EED5E4", Offset = "0x1EED5E4", VA = "0x1EED5E4")]
			public _003CManifestSetup_003Ec__Iterator2F()
			{
			}

			[Token(Token = "0x6001D17")]
			[Address(RVA = "0x1EF1D70", Offset = "0x1EF1D70", VA = "0x1EF1D70", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001D18")]
			[Address(RVA = "0x1EF1D78", Offset = "0x1EF1D78", VA = "0x1EF1D78", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001D19")]
			[Address(RVA = "0x1EF1D80", Offset = "0x1EF1D80", VA = "0x1EF1D80", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6001D1A")]
			[Address(RVA = "0x1EF22D0", Offset = "0x1EF22D0", VA = "0x1EF22D0", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6001D1B")]
			[Address(RVA = "0x1EF23E0", Offset = "0x1EF23E0", VA = "0x1EF23E0", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000387")]
		private sealed class _003CGetCalcDownloadFileSize_003Ec__Iterator30 : IDisposable
		{
			[Token(Token = "0x4001279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal long _003CbyteSize_003E__0;

			[Token(Token = "0x400127A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string _003Curl_003E__1;

			[Token(Token = "0x400127B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal WWW _003Cwww_003E__2;

			[Token(Token = "0x400127C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Action<Result, float> onComplete;

			[Token(Token = "0x400127D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal string _003Ctext_003E__3;

			[Token(Token = "0x400127E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal string[] _003Clines_003E__4;

			[Token(Token = "0x400127F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal int _003Ci_003E__5;

			[Token(Token = "0x4001280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal string _003Cline_003E__6;

			[Token(Token = "0x4001281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal string[] _003Cpair_003E__7;

			[Token(Token = "0x4001282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal string _003Ckey_003E__8;

			[Token(Token = "0x4001283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal long _003Cvalue_003E__9;

			[Token(Token = "0x4001284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal int _003Ci_003E__10;

			[Token(Token = "0x4001285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal List<string> updateList;

			[Token(Token = "0x4001286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal string _003CupdateItem_003E__11;

			[Token(Token = "0x4001287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			internal string _003Cname_003E__12;

			[Token(Token = "0x4001288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal int _0024PC;

			[Token(Token = "0x4001289")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			internal object _0024current;

			[Token(Token = "0x400128A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal Action<Result, float> _003C_0024_003EonComplete;

			[Token(Token = "0x400128B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			internal List<string> _003C_0024_003EupdateList;

			[Token(Token = "0x400128C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal AssetbundlePatcher _003C_003Ef__this;

			[Token(Token = "0x170004ED")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x6001D1D")]
				[Address(RVA = "0x1EF07D4", Offset = "0x1EF07D4", VA = "0x1EF07D4", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170004EE")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6001D1E")]
				[Address(RVA = "0x1EF07DC", Offset = "0x1EF07DC", VA = "0x1EF07DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001D1C")]
			[Address(RVA = "0x1EEDB5C", Offset = "0x1EEDB5C", VA = "0x1EEDB5C")]
			public _003CGetCalcDownloadFileSize_003Ec__Iterator30()
			{
			}

			[Token(Token = "0x6001D1D")]
			[Address(RVA = "0x1EF07D4", Offset = "0x1EF07D4", VA = "0x1EF07D4", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001D1E")]
			[Address(RVA = "0x1EF07DC", Offset = "0x1EF07DC", VA = "0x1EF07DC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001D1F")]
			[Address(RVA = "0x1EF07E4", Offset = "0x1EF07E4", VA = "0x1EF07E4", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6001D20")]
			[Address(RVA = "0x1EF11E4", Offset = "0x1EF11E4", VA = "0x1EF11E4", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6001D21")]
			[Address(RVA = "0x1EF12F4", Offset = "0x1EF12F4", VA = "0x1EF12F4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000388")]
		private sealed class _003CGetHashList_003Ec__Iterator31 : IDisposable
		{
			[Token(Token = "0x400128D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal string _003Curl_003E__0;

			[Token(Token = "0x400128E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal WWW _003Cwww_003E__1;

			[Token(Token = "0x400128F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Action<Result> onComplete;

			[Token(Token = "0x4001290")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal string _003Ctext_003E__2;

			[Token(Token = "0x4001291")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal string[] _003Clines_003E__3;

			[Token(Token = "0x4001292")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal int _003Ci_003E__4;

			[Token(Token = "0x4001293")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal string _003Cline_003E__5;

			[Token(Token = "0x4001294")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal string[] _003Cpair_003E__6;

			[Token(Token = "0x4001295")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal string _003Ckey_003E__7;

			[Token(Token = "0x4001296")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal string _003Cvalue_003E__8;

			[Token(Token = "0x4001297")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal int _0024PC;

			[Token(Token = "0x4001298")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal object _0024current;

			[Token(Token = "0x4001299")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Action<Result> _003C_0024_003EonComplete;

			[Token(Token = "0x400129A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal AssetbundlePatcher _003C_003Ef__this;

			[Token(Token = "0x170004EF")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x6001D23")]
				[Address(RVA = "0x1EF1388", Offset = "0x1EF1388", VA = "0x1EF1388", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170004F0")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6001D24")]
				[Address(RVA = "0x1EF1390", Offset = "0x1EF1390", VA = "0x1EF1390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001D22")]
			[Address(RVA = "0x1EEDC14", Offset = "0x1EEDC14", VA = "0x1EEDC14")]
			public _003CGetHashList_003Ec__Iterator31()
			{
			}

			[Token(Token = "0x6001D23")]
			[Address(RVA = "0x1EF1388", Offset = "0x1EF1388", VA = "0x1EF1388", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001D24")]
			[Address(RVA = "0x1EF1390", Offset = "0x1EF1390", VA = "0x1EF1390", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001D25")]
			[Address(RVA = "0x1EF1398", Offset = "0x1EF1398", VA = "0x1EF1398", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6001D26")]
			[Address(RVA = "0x1EF1BCC", Offset = "0x1EF1BCC", VA = "0x1EF1BCC", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6001D27")]
			[Address(RVA = "0x1EF1CDC", Offset = "0x1EF1CDC", VA = "0x1EF1CDC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40011FF")]
		public const string HashFileName = "hashlist.txt";

		[Token(Token = "0x4001200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private bool IsChecked;

		[Token(Token = "0x4001201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<string> downNeedList;

		[Token(Token = "0x4001202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Dictionary<string, long> downfileSize;

		[Token(Token = "0x4001203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<string, string> hashList;

		[Token(Token = "0x4001204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private ResourceLoader.ProgressCallBack ProgressCallBack;

		[Token(Token = "0x4001205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Action<Result> CompleteCallBack;

		[Token(Token = "0x4001206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool IsFirstDownload;

		[Token(Token = "0x4001207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AssetBundleManifest localManifest;

		[Token(Token = "0x4001208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private AssetBundleManifest serverManifest;

		[Token(Token = "0x4001209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private byte[] serverManifestBytes;

		[Token(Token = "0x170004E3")]
		public string DownCompelteFilePath
		{
			[Token(Token = "0x6001CE6")]
			[Address(RVA = "0x1EEAA28", Offset = "0x1EEAA28", VA = "0x1EEAA28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E4")]
		public string LocalAssetbundleManifestPath
		{
			[Token(Token = "0x6001CE7")]
			[Address(RVA = "0x1EEABF8", Offset = "0x1EEABF8", VA = "0x1EEABF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001CE5")]
		[Address(RVA = "0x1EEA914", Offset = "0x1EEA914", VA = "0x1EEA914")]
		public AssetbundlePatcher()
		{
		}

		[Token(Token = "0x6001CE8")]
		[Address(RVA = "0x1EEADB0", Offset = "0x1EEADB0", VA = "0x1EEADB0")]
		public string GetPatchAssetUrl(string relativePath = "")
		{
			return null;
		}

		[Token(Token = "0x6001CE9")]
		[Address(RVA = "0x1EEB68C", Offset = "0x1EEB68C", VA = "0x1EEB68C")]
		public string GetConvertUrl(string path, bool isLocal = false)
		{
			return null;
		}

		[Token(Token = "0x6001CEA")]
		[Address(RVA = "0x1EEB750", Offset = "0x1EEB750", VA = "0x1EEB750")]
		public void CheckPatch(Action<Flow> onProgress, Action<Result, int, float> onComplete)
		{
		}

		[Token(Token = "0x6001CEB")]
		[Address(RVA = "0x1EEB84C", Offset = "0x1EEB84C", VA = "0x1EEB84C")]
		public void StartPatch(ResourceLoader.ProgressCallBack pgCallBack, Action<Result> onComplete)
		{
		}

		[Token(Token = "0x6001CEC")]
		[Address(RVA = "0x1EEBD00", Offset = "0x1EEBD00", VA = "0x1EEBD00")]
		private bool IsSuccess(Result result)
		{
			return default(bool);
		}

		[Token(Token = "0x6001CED")]
		[Address(RVA = "0x1EEBD10", Offset = "0x1EEBD10", VA = "0x1EEBD10")]
		private void ClearData()
		{
		}

		[Token(Token = "0x6001CEE")]
		[Address(RVA = "0x1EEB790", Offset = "0x1EEB790", VA = "0x1EEB790")]
		[DebuggerHidden]
		private IEnumerator _CheckPatch(Action<Flow> onProgress, Action<Result, int, float> onComplete)
		{
			return null;
		}

		[Token(Token = "0x6001CEF")]
		[Address(RVA = "0x1EEBC20", Offset = "0x1EEBC20", VA = "0x1EEBC20")]
		[DebuggerHidden]
		private IEnumerator _StartPatch(ResourceLoader.ProgressCallBack pgCallBack, byte[] serverManifestBytes, List<string> downNeedList, string saveBasePath, Action<Result> onComplete)
		{
			return null;
		}

		[Token(Token = "0x6001CF0")]
		[Address(RVA = "0x1EEBDCC", Offset = "0x1EEBDCC", VA = "0x1EEBDCC")]
		private List<string> GetDownCompleteList(List<string> serverList, Dictionary<string, string> hashList)
		{
			return null;
		}

		[Token(Token = "0x6001CF1")]
		[Address(RVA = "0x1EEC660", Offset = "0x1EEC660", VA = "0x1EEC660")]
		[DebuggerHidden]
		private IEnumerator DownloadFilesAndSave(ResourceLoader.ProgressCallBack pgCallBack, List<string> updatedList, string saveBasePath, [Optional] Action<Result> callback)
		{
			return null;
		}

		[Token(Token = "0x6001CF2")]
		[Address(RVA = "0x1EEC738", Offset = "0x1EEC738", VA = "0x1EEC738")]
		private WWW GetWWW(string url, long byteSize)
		{
			return null;
		}

		[Token(Token = "0x6001CF3")]
		[Address(RVA = "0x1EEC818", Offset = "0x1EEC818", VA = "0x1EEC818")]
		private void DisposeWWW(WWW www, long byteSize)
		{
		}

		[Token(Token = "0x6001CF4")]
		[Address(RVA = "0x1EEC890", Offset = "0x1EEC890", VA = "0x1EEC890")]
		private bool CheckHash(string itemKey, byte[] bytes)
		{
			return default(bool);
		}

		[Token(Token = "0x6001CF5")]
		[Address(RVA = "0x1EECC38", Offset = "0x1EECC38", VA = "0x1EECC38")]
		private void Dispose(Dictionary<string, WWW> wwws, Dictionary<string, long> fileSizeDic)
		{
		}

		[Token(Token = "0x6001CF6")]
		[Address(RVA = "0x1EECE2C", Offset = "0x1EECE2C", VA = "0x1EECE2C")]
		public Result FileSave(string path, byte[] bytes)
		{
			return default(Result);
		}

		[Token(Token = "0x6001CF7")]
		[Address(RVA = "0x1EED0CC", Offset = "0x1EED0CC", VA = "0x1EED0CC")]
		private Result SaveDownLoadList(string path, List<string> lines)
		{
			return default(Result);
		}

		[Token(Token = "0x6001CF8")]
		[Address(RVA = "0x1EED514", Offset = "0x1EED514", VA = "0x1EED514")]
		[DebuggerHidden]
		private IEnumerator ManifestSetup(string url, string manifestName, Action<Result, AssetBundleManifest, byte[]> callBack, [Optional] Action<float> progress)
		{
			return null;
		}

		[Token(Token = "0x6001CF9")]
		[Address(RVA = "0x1EED5EC", Offset = "0x1EED5EC", VA = "0x1EED5EC")]
		private AssetBundleManifest LoadAsset_Manifest(AssetBundle bundle)
		{
			return null;
		}

		[Token(Token = "0x6001CFA")]
		[Address(RVA = "0x1EEDAA0", Offset = "0x1EEDAA0", VA = "0x1EEDAA0")]
		[DebuggerHidden]
		private IEnumerator GetCalcDownloadFileSize(List<string> updateList, Action<Result, float> onComplete)
		{
			return null;
		}

		[Token(Token = "0x6001CFB")]
		[Address(RVA = "0x1EEDB64", Offset = "0x1EEDB64", VA = "0x1EEDB64")]
		[DebuggerHidden]
		private IEnumerator GetHashList(Action<Result> onComplete)
		{
			return null;
		}

		[Token(Token = "0x6001CFC")]
		[Address(RVA = "0x1EEDC1C", Offset = "0x1EEDC1C", VA = "0x1EEDC1C", Slot = "4")]
		public void OnProgress(int write, int total, int totalWrite)
		{
		}

		[Token(Token = "0x6001CFD")]
		[Address(RVA = "0x1EEDE0C", Offset = "0x1EEDE0C", VA = "0x1EEDE0C", Slot = "5")]
		public void OnFinish()
		{
		}

		[Token(Token = "0x6001CFE")]
		[Address(RVA = "0x1EEE0F4", Offset = "0x1EEE0F4", VA = "0x1EEE0F4", Slot = "6")]
		public void OnError()
		{
		}

		[Token(Token = "0x6001CFF")]
		[Address(RVA = "0x1EEC090", Offset = "0x1EEC090", VA = "0x1EEC090")]
		private List<string> GetValidFilesInPatchStorageByHash(List<string> checkList, Dictionary<string, string> hashList)
		{
			return null;
		}
	}
}
