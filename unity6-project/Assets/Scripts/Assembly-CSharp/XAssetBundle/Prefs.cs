using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

namespace XAssetBundle
{
	[Serializable]
	[Token(Token = "0x2000391")]
	public class Prefs : ScriptableObject
	{
		[Token(Token = "0x40012B2")]
		public const string ASSETBUNDLE_PREFS_NAME = "AssetBundlePrefs";

		[Token(Token = "0x40012B3")]
		public const string ASSETBUNDLE_PREFS_PATH = "Assets/Resources/AssetBundlePrefs.asset";

		[Token(Token = "0x40012B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		public bool usingAssetBundle;

		[Token(Token = "0x40012B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		public ConnectEnum.ServerType serverType;

		[Token(Token = "0x40012B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public string version;

		[Token(Token = "0x40012B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<string> atlasFolderList;

		[Token(Token = "0x40012B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		public string toyServiceID;

		[Token(Token = "0x40012B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public string localAddress;

		[Token(Token = "0x6001D60")]
		[Address(RVA = "0x1EF5394", Offset = "0x1EF5394", VA = "0x1EF5394")]
		public Prefs()
		{
		}

		[Token(Token = "0x6001D61")]
		[Address(RVA = "0x1EDD018", Offset = "0x1EDD018", VA = "0x1EDD018")]
		public static Prefs Load()
		{
			return null;
		}

		[Token(Token = "0x6001D62")]
		[Address(RVA = "0x1EF553C", Offset = "0x1EF553C", VA = "0x1EF553C")]
		public static Prefs Create([Optional][DefaultParameterValue(false)] bool usingAssetBundle, [Optional] ConnectEnum.ServerType serverType, [Optional] string version, [Optional] List<string> atlasFolderList, string toyServiceID = "", string localAddr = "")
		{
			return null;
		}
	}
}
