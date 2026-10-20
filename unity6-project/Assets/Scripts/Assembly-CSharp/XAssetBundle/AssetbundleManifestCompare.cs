using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace XAssetBundle
{
	[Token(Token = "0x200037F")]
	public class AssetbundleManifestCompare
	{
		[Token(Token = "0x40011F9")]
		[FieldOffset(Offset = "0x8")]
		private AssetBundleManifest m_patchedManifest;

		[Token(Token = "0x40011FA")]
		[FieldOffset(Offset = "0xC")]
		private AssetBundleManifest m_newManifest;

		[Token(Token = "0x40011FB")]
		[FieldOffset(Offset = "0x10")]
		private List<string> m_patchedAssetNameList;

		[Token(Token = "0x40011FC")]
		[FieldOffset(Offset = "0x14")]
		private List<string> m_newAssetNameList;

		[Token(Token = "0x40011FD")]
		[FieldOffset(Offset = "0x18")]
		private List<string> m_removeList;

		[Token(Token = "0x40011FE")]
		[FieldOffset(Offset = "0x1C")]
		private List<string> m_updateList;

		[Token(Token = "0x6001CDE")]
		[Address(RVA = "0x1EE9F5C", Offset = "0x1EE9F5C", VA = "0x1EE9F5C")]
		public AssetbundleManifestCompare(AssetBundleManifest patchedList, AssetBundleManifest newList)
		{
		}

		[Token(Token = "0x6001CDF")]
		[Address(RVA = "0x1EEA08C", Offset = "0x1EEA08C", VA = "0x1EEA08C")]
		private void InitManifestAssetNameList(AssetBundleManifest manifest, out List<string> assetNameList)
		{
			assetNameList = default;
		}

		[Token(Token = "0x6001CE0")]
		[Address(RVA = "0x1EEA1FC", Offset = "0x1EEA1FC", VA = "0x1EEA1FC")]
		private void CompareListsToCheckUpdate()
		{
		}

		[Token(Token = "0x6001CE1")]
		[Address(RVA = "0x1EEA7BC", Offset = "0x1EEA7BC", VA = "0x1EEA7BC")]
		public List<string> GetRemovedList()
		{
			return null;
		}

		[Token(Token = "0x6001CE2")]
		[Address(RVA = "0x1EEA868", Offset = "0x1EEA868", VA = "0x1EEA868")]
		public List<string> GetUpdatedList()
		{
			return null;
		}

		[Token(Token = "0x6001CE3")]
		[Address(RVA = "0x1EEA61C", Offset = "0x1EEA61C", VA = "0x1EEA61C")]
		private void GetRemovedLocalAssetList(out List<string> removeList)
		{
			removeList = default;
		}

		[Token(Token = "0x6001CE4")]
		[Address(RVA = "0x1EEA32C", Offset = "0x1EEA32C", VA = "0x1EEA32C")]
		private void GetUpdateAndModifyAssetList(out List<string> updateList, out List<string> modifyList)
		{
			modifyList = default;
			updateList = default;
		}
	}
}
