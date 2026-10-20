using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004FC")]
public class GameDataPatcher
{
	[Token(Token = "0x20004FD")]
	public enum PatchResult
	{
		[Token(Token = "0x4001942")]
		ServerManifestDownloadFail = 0,
		[Token(Token = "0x4001943")]
		ServerGameDataDownloadFail = 1,
		[Token(Token = "0x4001944")]
		ServerGameDataZipDownloadFail = 2,
		[Token(Token = "0x4001945")]
		FailGetDataInZip = 3,
		[Token(Token = "0x4001946")]
		NotFoundFileInZip = 4,
		[Token(Token = "0x4001947")]
		GameDataLocalLoadFail = 5,
		[Token(Token = "0x4001948")]
		GameDataLocalLoadFail_NotExist = 6,
		[Token(Token = "0x4001949")]
		NotFoundDownloadProtoFile = 7,
		[Token(Token = "0x400194A")]
		InvalidProtoFile = 8,
		[Token(Token = "0x400194B")]
		ErrorFileSave = 9,
		[Token(Token = "0x400194C")]
		Success = 10
	}

	[Token(Token = "0x20004FE")]
	public struct LocalFileInfo
	{
		[Token(Token = "0x400194D")]
		[FieldOffset(Offset = "0x0")]
		private byte[] Bytes__BackingField;

		[Token(Token = "0x400194E")]
		[FieldOffset(Offset = "0x4")]
		private string FileName__BackingField;

		[Token(Token = "0x400194F")]
		[FieldOffset(Offset = "0x8")]
		private string MD5__BackingField;

		[Token(Token = "0x170006C4")]
		public byte[] Bytes
		{
			[Token(Token = "0x6002B26")]
			[Address(RVA = "0x1F2DA5C", Offset = "0x1F2DA5C", VA = "0x1F2DA5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B27")]
			[Address(RVA = "0x1F2DA64", Offset = "0x1F2DA64", VA = "0x1F2DA64")]
			private set
			{
			}
		}

		[Token(Token = "0x170006C5")]
		public string FileName
		{
			[Token(Token = "0x6002B28")]
			[Address(RVA = "0x1F2DA6C", Offset = "0x1F2DA6C", VA = "0x1F2DA6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B29")]
			[Address(RVA = "0x1F2DA74", Offset = "0x1F2DA74", VA = "0x1F2DA74")]
			private set
			{
			}
		}

		[Token(Token = "0x170006C6")]
		public string MD5
		{
			[Token(Token = "0x6002B2A")]
			[Address(RVA = "0x1F2DA7C", Offset = "0x1F2DA7C", VA = "0x1F2DA7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B2B")]
			[Address(RVA = "0x1F2DA84", Offset = "0x1F2DA84", VA = "0x1F2DA84")]
			private set
			{
			}
		}

		[Token(Token = "0x6002B25")]
		[Address(RVA = "0x1F2DA54", Offset = "0x1F2DA54", VA = "0x1F2DA54")]
		public LocalFileInfo(string name, byte[] bytes)
		{
			this = default;
		}

		[Token(Token = "0x6002B2C")]
		[Address(RVA = "0x1F2DA8C", Offset = "0x1F2DA8C", VA = "0x1F2DA8C")]
		private string ToMd5(byte[] input)
		{
			return null;
		}
	}

	[Token(Token = "0x20004FF")]
	public delegate void OnProgress();

	[Token(Token = "0x2000500")]
	private sealed class _003C_StartDataPatch_003Ec__Iterator45 : IDisposable
	{
		[Token(Token = "0x4001950")]
		[FieldOffset(Offset = "0x8")]
		internal DateTime _003Cnow_003E__0;

		[Token(Token = "0x4001951")]
		[FieldOffset(Offset = "0x18")]
		internal XProtoInfoManagers proto;

		[Token(Token = "0x4001952")]
		[FieldOffset(Offset = "0x1C")]
		internal List<string> _003CprotoList_003E__1;

		[Token(Token = "0x4001953")]
		[FieldOffset(Offset = "0x20")]
		internal List<string> _003CdownNeedFileNameList_003E__2;

		[Token(Token = "0x4001954")]
		[FieldOffset(Offset = "0x24")]
		internal bool _003Cencryption_003E__3;

		[Token(Token = "0x4001955")]
		[FieldOffset(Offset = "0x28")]
		internal Dictionary<string, string> _003CserverHashDic_003E__4;

		[Token(Token = "0x4001956")]
		[FieldOffset(Offset = "0x2C")]
		internal OnProgress onProgress;

		[Token(Token = "0x4001957")]
		[FieldOffset(Offset = "0x30")]
		internal Action<PatchResult, string> onFail;

		[Token(Token = "0x4001958")]
		[FieldOffset(Offset = "0x34")]
		internal Dictionary<string, byte[]> _003CdownloadFiles_003E__5;

		[Token(Token = "0x4001959")]
		[FieldOffset(Offset = "0x38")]
		internal DateTime _003CdownEnd_003E__6;

		[Token(Token = "0x400195A")]
		[FieldOffset(Offset = "0x48")]
		internal Action onComplete;

		[Token(Token = "0x400195B")]
		[FieldOffset(Offset = "0x4C")]
		internal int _0024PC;

		[Token(Token = "0x400195C")]
		[FieldOffset(Offset = "0x50")]
		internal object _0024current;

		[Token(Token = "0x400195D")]
		[FieldOffset(Offset = "0x54")]
		internal XProtoInfoManagers _003C_0024_003Eproto;

		[Token(Token = "0x400195E")]
		[FieldOffset(Offset = "0x58")]
		internal OnProgress _003C_0024_003EonProgress;

		[Token(Token = "0x400195F")]
		[FieldOffset(Offset = "0x5C")]
		internal Action<PatchResult, string> _003C_0024_003EonFail;

		[Token(Token = "0x4001960")]
		[FieldOffset(Offset = "0x60")]
		internal Action _003C_0024_003EonComplete;

		[Token(Token = "0x4001961")]
		[FieldOffset(Offset = "0x64")]
		internal GameDataPatcher _003C_003Ef__this;

		[Token(Token = "0x170006C7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002B32")]
			[Address(RVA = "0x1F2B45C", Offset = "0x1F2B45C", VA = "0x1F2B45C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006C8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B33")]
			[Address(RVA = "0x1F2B464", Offset = "0x1F2B464", VA = "0x1F2B464", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002B31")]
		[Address(RVA = "0x1F29234", Offset = "0x1F29234", VA = "0x1F29234")]
		public _003C_StartDataPatch_003Ec__Iterator45()
		{
		}

		[Token(Token = "0x6002B32")]
		[Address(RVA = "0x1F2B45C", Offset = "0x1F2B45C", VA = "0x1F2B45C", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002B33")]
		[Address(RVA = "0x1F2B464", Offset = "0x1F2B464", VA = "0x1F2B464", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002B34")]
		[Address(RVA = "0x1F2B46C", Offset = "0x1F2B46C", VA = "0x1F2B46C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B35")]
		[Address(RVA = "0x1F2BA80", Offset = "0x1F2BA80", VA = "0x1F2BA80", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002B36")]
		[Address(RVA = "0x1F2BA8C", Offset = "0x1F2BA8C", VA = "0x1F2BA8C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		[Token(Token = "0x6002B37")]
		[Address(RVA = "0x1F2BB20", Offset = "0x1F2BB20", VA = "0x1F2BB20")]
		internal void _003C_003Em__10C(List<string> upList, Dictionary<string, string> _serverHashDic, bool _encryption)
		{
		}

		[Token(Token = "0x6002B38")]
		[Address(RVA = "0x1F2BC88", Offset = "0x1F2BC88", VA = "0x1F2BC88")]
		internal void _003C_003Em__10D(Dictionary<string, byte[]> files)
		{
		}
	}

	[Token(Token = "0x2000501")]
	private sealed class _003CDownloadAndSetUpGameDataManifest_003Ec__Iterator46 : IDisposable
	{
		[Token(Token = "0x4001962")]
		[FieldOffset(Offset = "0x8")]
		internal string _003CserverManifest_003E__0;

		[Token(Token = "0x4001963")]
		[FieldOffset(Offset = "0xC")]
		internal string manifestUrl;

		[Token(Token = "0x4001964")]
		[FieldOffset(Offset = "0x10")]
		internal WWW _003CserverManifestWWW_003E__1;

		[Token(Token = "0x4001965")]
		[FieldOffset(Offset = "0x14")]
		internal OnProgress onProgress;

		[Token(Token = "0x4001966")]
		[FieldOffset(Offset = "0x18")]
		internal bool _003Cencryption_003E__2;

		[Token(Token = "0x4001967")]
		[FieldOffset(Offset = "0x1C")]
		internal Dictionary<string, string> _003CserverVerHashDic_003E__3;

		[Token(Token = "0x4001968")]
		[FieldOffset(Offset = "0x20")]
		internal List<string> _003CfileNameList_003E__4;

		[Token(Token = "0x4001969")]
		[FieldOffset(Offset = "0x24")]
		internal Action<List<string>, Dictionary<string, string>, bool> onComplete;

		[Token(Token = "0x400196A")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x400196B")]
		[FieldOffset(Offset = "0x2C")]
		internal object _0024current;

		[Token(Token = "0x400196C")]
		[FieldOffset(Offset = "0x30")]
		internal string _003C_0024_003EmanifestUrl;

		[Token(Token = "0x400196D")]
		[FieldOffset(Offset = "0x34")]
		internal OnProgress _003C_0024_003EonProgress;

		[Token(Token = "0x400196E")]
		[FieldOffset(Offset = "0x38")]
		internal Action<List<string>, Dictionary<string, string>, bool> _003C_0024_003EonComplete;

		[Token(Token = "0x400196F")]
		[FieldOffset(Offset = "0x3C")]
		internal GameDataPatcher _003C_003Ef__this;

		[Token(Token = "0x170006C9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002B3A")]
			[Address(RVA = "0x1F2BD3C", Offset = "0x1F2BD3C", VA = "0x1F2BD3C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006CA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B3B")]
			[Address(RVA = "0x1F2BD44", Offset = "0x1F2BD44", VA = "0x1F2BD44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002B39")]
		[Address(RVA = "0x1F29304", Offset = "0x1F29304", VA = "0x1F29304")]
		public _003CDownloadAndSetUpGameDataManifest_003Ec__Iterator46()
		{
		}

		[Token(Token = "0x6002B3A")]
		[Address(RVA = "0x1F2BD3C", Offset = "0x1F2BD3C", VA = "0x1F2BD3C", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002B3B")]
		[Address(RVA = "0x1F2BD44", Offset = "0x1F2BD44", VA = "0x1F2BD44", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002B3C")]
		[Address(RVA = "0x1F2BD4C", Offset = "0x1F2BD4C", VA = "0x1F2BD4C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B3D")]
		[Address(RVA = "0x1F2C1E4", Offset = "0x1F2C1E4", VA = "0x1F2C1E4", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002B3E")]
		[Address(RVA = "0x1F2C2F4", Offset = "0x1F2C2F4", VA = "0x1F2C2F4", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000502")]
	private sealed class _003CDownloadUpdateGameData_003Ec__Iterator47 : IDisposable
	{
		[Token(Token = "0x4001970")]
		[FieldOffset(Offset = "0x8")]
		internal Dictionary<string, byte[]> _003Cfiles_003E__0;

		[Token(Token = "0x4001971")]
		[FieldOffset(Offset = "0xC")]
		internal int _003CretryCount_003E__1;

		[Token(Token = "0x4001972")]
		[FieldOffset(Offset = "0x10")]
		internal byte[] _003ClocalData_003E__2;

		[Token(Token = "0x4001973")]
		[FieldOffset(Offset = "0x14")]
		internal Dictionary<string, string> serverHashDic;

		[Token(Token = "0x4001974")]
		[FieldOffset(Offset = "0x18")]
		internal string _003Cerror_003E__3;

		[Token(Token = "0x4001975")]
		[FieldOffset(Offset = "0x1C")]
		internal bool encryption;

		[Token(Token = "0x4001976")]
		[FieldOffset(Offset = "0x20")]
		internal byte[] _003CfileBytes_003E__4;

		[Token(Token = "0x4001977")]
		[FieldOffset(Offset = "0x24")]
		internal List<string> updateFileNameList;

		[Token(Token = "0x4001978")]
		[FieldOffset(Offset = "0x28")]
		internal string zipName;

		[Token(Token = "0x4001979")]
		[FieldOffset(Offset = "0x2C")]
		internal string _003Curl_003E__5;

		[Token(Token = "0x400197A")]
		[FieldOffset(Offset = "0x30")]
		internal WWW _003CzipWWW_003E__6;

		[Token(Token = "0x400197B")]
		[FieldOffset(Offset = "0x34")]
		internal OnProgress onProgress;

		[Token(Token = "0x400197C")]
		[FieldOffset(Offset = "0x38")]
		internal byte[] _003CfileBytes_003E__7;

		[Token(Token = "0x400197D")]
		[FieldOffset(Offset = "0x3C")]
		internal Action<Dictionary<string, byte[]>> onComplete;

		[Token(Token = "0x400197E")]
		[FieldOffset(Offset = "0x40")]
		internal int _0024PC;

		[Token(Token = "0x400197F")]
		[FieldOffset(Offset = "0x44")]
		internal object _0024current;

		[Token(Token = "0x4001980")]
		[FieldOffset(Offset = "0x48")]
		internal Dictionary<string, string> _003C_0024_003EserverHashDic;

		[Token(Token = "0x4001981")]
		[FieldOffset(Offset = "0x4C")]
		internal bool _003C_0024_003Eencryption;

		[Token(Token = "0x4001982")]
		[FieldOffset(Offset = "0x50")]
		internal List<string> _003C_0024_003EupdateFileNameList;

		[Token(Token = "0x4001983")]
		[FieldOffset(Offset = "0x54")]
		internal string _003C_0024_003EzipName;

		[Token(Token = "0x4001984")]
		[FieldOffset(Offset = "0x58")]
		internal OnProgress _003C_0024_003EonProgress;

		[Token(Token = "0x4001985")]
		[FieldOffset(Offset = "0x5C")]
		internal Action<Dictionary<string, byte[]>> _003C_0024_003EonComplete;

		[Token(Token = "0x4001986")]
		[FieldOffset(Offset = "0x60")]
		internal GameDataPatcher _003C_003Ef__this;

		[Token(Token = "0x170006CB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002B40")]
			[Address(RVA = "0x1F2C388", Offset = "0x1F2C388", VA = "0x1F2C388", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006CC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B41")]
			[Address(RVA = "0x1F2C390", Offset = "0x1F2C390", VA = "0x1F2C390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002B3F")]
		[Address(RVA = "0x1F293F8", Offset = "0x1F293F8", VA = "0x1F293F8")]
		public _003CDownloadUpdateGameData_003Ec__Iterator47()
		{
		}

		[Token(Token = "0x6002B40")]
		[Address(RVA = "0x1F2C388", Offset = "0x1F2C388", VA = "0x1F2C388", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002B41")]
		[Address(RVA = "0x1F2C390", Offset = "0x1F2C390", VA = "0x1F2C390", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002B42")]
		[Address(RVA = "0x1F2C398", Offset = "0x1F2C398", VA = "0x1F2C398", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B43")]
		[Address(RVA = "0x1F2CD78", Offset = "0x1F2CD78", VA = "0x1F2CD78", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002B44")]
		[Address(RVA = "0x1F2CE8C", Offset = "0x1F2CE8C", VA = "0x1F2CE8C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		[Token(Token = "0x6002B45")]
		[Address(RVA = "0x1F2CF20", Offset = "0x1F2CF20", VA = "0x1F2CF20")]
		internal void _003C_003Em__10E(Dictionary<string, byte[]> loadFIles)
		{
		}

		[Token(Token = "0x6002B46")]
		[Address(RVA = "0x1F2CF28", Offset = "0x1F2CF28", VA = "0x1F2CF28")]
		internal void _003C_003Em__10F(Dictionary<string, byte[]> loadFIles)
		{
		}
	}

	[Token(Token = "0x2000503")]
	private sealed class _003CUpdateProtoManger_003Ec__Iterator48 : IDisposable
	{
		[Token(Token = "0x4001987")]
		[FieldOffset(Offset = "0x8")]
		internal Array _003Ctypes_003E__0;

		[Token(Token = "0x4001988")]
		[FieldOffset(Offset = "0xC")]
		internal IEnumerator _003C_0024s_253_003E__1;

		[Token(Token = "0x4001989")]
		[FieldOffset(Offset = "0x10")]
		internal object _003Ceach_003E__2;

		[Token(Token = "0x400198A")]
		[FieldOffset(Offset = "0x14")]
		internal ProtoInfoTypes _003Ct_003E__3;

		[Token(Token = "0x400198B")]
		[FieldOffset(Offset = "0x18")]
		internal XProtoInfoManagers protoMgr;

		[Token(Token = "0x400198C")]
		[FieldOffset(Offset = "0x1C")]
		internal CSProtoInfoManagerBase _003Cmgr_003E__4;

		[Token(Token = "0x400198D")]
		[FieldOffset(Offset = "0x20")]
		internal string _003Cfilename_003E__5;

		[Token(Token = "0x400198E")]
		[FieldOffset(Offset = "0x24")]
		internal Dictionary<string, byte[]> files;

		[Token(Token = "0x400198F")]
		[FieldOffset(Offset = "0x28")]
		internal byte[] _003CfileByte_003E__6;

		[Token(Token = "0x4001990")]
		[FieldOffset(Offset = "0x2C")]
		internal int _0024PC;

		[Token(Token = "0x4001991")]
		[FieldOffset(Offset = "0x30")]
		internal object _0024current;

		[Token(Token = "0x4001992")]
		[FieldOffset(Offset = "0x34")]
		internal XProtoInfoManagers _003C_0024_003EprotoMgr;

		[Token(Token = "0x4001993")]
		[FieldOffset(Offset = "0x38")]
		internal Dictionary<string, byte[]> _003C_0024_003Efiles;

		[Token(Token = "0x4001994")]
		[FieldOffset(Offset = "0x3C")]
		internal GameDataPatcher _003C_003Ef__this;

		[Token(Token = "0x170006CD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002B48")]
			[Address(RVA = "0x1F2CF30", Offset = "0x1F2CF30", VA = "0x1F2CF30", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006CE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B49")]
			[Address(RVA = "0x1F2CF38", Offset = "0x1F2CF38", VA = "0x1F2CF38", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002B47")]
		[Address(RVA = "0x1F2ABA8", Offset = "0x1F2ABA8", VA = "0x1F2ABA8")]
		public _003CUpdateProtoManger_003Ec__Iterator48()
		{
		}

		[Token(Token = "0x6002B48")]
		[Address(RVA = "0x1F2CF30", Offset = "0x1F2CF30", VA = "0x1F2CF30", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002B49")]
		[Address(RVA = "0x1F2CF38", Offset = "0x1F2CF38", VA = "0x1F2CF38", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002B4A")]
		[Address(RVA = "0x1F2CF40", Offset = "0x1F2CF40", VA = "0x1F2CF40", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B4B")]
		[Address(RVA = "0x1F2D658", Offset = "0x1F2D658", VA = "0x1F2D658", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002B4C")]
		[Address(RVA = "0x1F2D784", Offset = "0x1F2D784", VA = "0x1F2D784", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001939")]
	private const string m_encryptionKey = "encrypt:";

	[Token(Token = "0x400193A")]
	[FieldOffset(Offset = "0x8")]
	private string m_downBaseUrl;

	[Token(Token = "0x400193B")]
	[FieldOffset(Offset = "0xC")]
	private int m_localGameDataVer;

	[Token(Token = "0x400193C")]
	[FieldOffset(Offset = "0x10")]
	private int m_serverGameDataVer;

	[Token(Token = "0x400193D")]
	[FieldOffset(Offset = "0x14")]
	private ConnectEnum.ServerType m_serverType;

	[Token(Token = "0x400193E")]
	[FieldOffset(Offset = "0x18")]
	private string LOCAL_GAMEDATA_BASE_PATH;

	[Token(Token = "0x400193F")]
	[FieldOffset(Offset = "0x1C")]
	private PatchResult Result__BackingField;

	[Token(Token = "0x4001940")]
	[FieldOffset(Offset = "0x20")]
	private string ErrorMsg__BackingField;

	[Token(Token = "0x170006C2")]
	private PatchResult Result
	{
		[Token(Token = "0x6002B11")]
		[Address(RVA = "0x1F28990", Offset = "0x1F28990", VA = "0x1F28990")]
		get
		{
			return default(PatchResult);
		}
		[Token(Token = "0x6002B12")]
		[Address(RVA = "0x1F28998", Offset = "0x1F28998", VA = "0x1F28998")]
		set
		{
		}
	}

	[Token(Token = "0x170006C3")]
	private string ErrorMsg
	{
		[Token(Token = "0x6002B13")]
		[Address(RVA = "0x1F289A0", Offset = "0x1F289A0", VA = "0x1F289A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002B14")]
		[Address(RVA = "0x1F289A8", Offset = "0x1F289A8", VA = "0x1F289A8")]
		set
		{
		}
	}

	[Token(Token = "0x6002B10")]
	[Address(RVA = "0x1F28890", Offset = "0x1F28890", VA = "0x1F28890")]
	public GameDataPatcher()
	{
	}

	[Token(Token = "0x6002B15")]
	[Address(RVA = "0x1F289B0", Offset = "0x1F289B0", VA = "0x1F289B0")]
	private string GetLocalGameDataSavePath(string fileName)
	{
		return null;
	}

	[Token(Token = "0x6002B16")]
	[Address(RVA = "0x1F28A64", Offset = "0x1F28A64", VA = "0x1F28A64")]
	private string GetLocalGameDataURL(string fileName)
	{
		return null;
	}

	[Token(Token = "0x6002B17")]
	[Address(RVA = "0x1F28AA4", Offset = "0x1F28AA4", VA = "0x1F28AA4")]
	private string GetServerGameDataURL(int ver, string relativePath)
	{
		return null;
	}

	[Token(Token = "0x6002B18")]
	[Address(RVA = "0x1F28E74", Offset = "0x1F28E74", VA = "0x1F28E74")]
	public void StartDataPatch(ConnectEnum.ServerType serverType, int localGameDataVer, int serverGameDataVer, string downBaseUrl, XProtoInfoManagers proto, OnProgress onProgress, Action onComplete, Action<PatchResult, string> onFail)
	{
	}

	[Token(Token = "0x6002B19")]
	[Address(RVA = "0x1F29164", Offset = "0x1F29164", VA = "0x1F29164")]
	[DebuggerHidden]
	private IEnumerator _StartDataPatch(XProtoInfoManagers proto, OnProgress onProgress, Action onComplete, Action<PatchResult, string> onFail)
	{
		return null;
	}

	[Token(Token = "0x6002B1A")]
	[Address(RVA = "0x1F2923C", Offset = "0x1F2923C", VA = "0x1F2923C")]
	[DebuggerHidden]
	private IEnumerator DownloadAndSetUpGameDataManifest(string manifestUrl, OnProgress onProgress, Action<List<string>, Dictionary<string, string>, bool> onComplete)
	{
		return null;
	}

	[Token(Token = "0x6002B1B")]
	[Address(RVA = "0x1F2930C", Offset = "0x1F2930C", VA = "0x1F2930C")]
	[DebuggerHidden]
	private IEnumerator DownloadUpdateGameData(bool encryption, Dictionary<string, string> serverHashDic, List<string> updateFileNameList, string zipName, OnProgress onProgress, Action<Dictionary<string, byte[]>> onComplete)
	{
		return null;
	}

	[Token(Token = "0x6002B1C")]
	[Address(RVA = "0x1F29400", Offset = "0x1F29400", VA = "0x1F29400")]
	private bool CheckHash(Dictionary<string, string> hashDic, string fileName, byte[] fileBytes, out string error)
	{
		error = default;
		return default(bool);
	}

	[Token(Token = "0x6002B1D")]
	[Address(RVA = "0x1F2964C", Offset = "0x1F2964C", VA = "0x1F2964C")]
	private List<string> GetListForKey(IDictionary dic)
	{
		return null;
	}

	[Token(Token = "0x6002B1E")]
	[Address(RVA = "0x1F29BE4", Offset = "0x1F29BE4", VA = "0x1F29BE4")]
	private Dictionary<string, string> MakeServerHashDic(string text, out bool encryption)
	{
		encryption = default;
		return null;
	}

	[Token(Token = "0x6002B1F")]
	[Address(RVA = "0x1F2A11C", Offset = "0x1F2A11C", VA = "0x1F2A11C")]
	private byte[] LoadLocalFile(string path)
	{
		return null;
	}

	[Token(Token = "0x6002B20")]
	[Address(RVA = "0x1F2A410", Offset = "0x1F2A410", VA = "0x1F2A410")]
	private string to_md5(byte[] input)
	{
		return null;
	}

	[Token(Token = "0x6002B21")]
	[Address(RVA = "0x1F2A578", Offset = "0x1F2A578", VA = "0x1F2A578")]
	private void UnzipFromWeb(byte[] gameData, List<string> saveFileNameList, Action<Dictionary<string, byte[]>> onComplete)
	{
	}

	[Token(Token = "0x6002B22")]
	[Address(RVA = "0x1F2AAEC", Offset = "0x1F2AAEC", VA = "0x1F2AAEC")]
	[DebuggerHidden]
	private IEnumerator UpdateProtoManger(XProtoInfoManagers protoMgr, Dictionary<string, byte[]> files, bool encrypt)
	{
		return null;
	}

	[Token(Token = "0x6002B23")]
	[Address(RVA = "0x1F2ABB0", Offset = "0x1F2ABB0", VA = "0x1F2ABB0")]
	private bool LoadProtoManager(CSProtoInfoManagerBase mgr, string fileName, byte[] fileBytes)
	{
		return default(bool);
	}

	[Token(Token = "0x6002B24")]
	[Address(RVA = "0x1F2AF78", Offset = "0x1F2AF78", VA = "0x1F2AF78")]
	private List<string> GetFileList_NotProtoInfoFromClient(XProtoInfoManagers protoMgr)
	{
		return null;
	}
}
