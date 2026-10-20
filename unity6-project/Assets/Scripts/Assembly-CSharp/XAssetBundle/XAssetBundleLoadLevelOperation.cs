using Il2CppDummyDll;
using UnityEngine;

namespace XAssetBundle
{
	[Token(Token = "0x200036B")]
	public class XAssetBundleLoadLevelOperation : XAssetBundleLoadOperation
	{
		[Token(Token = "0x40011BF")]
		[FieldOffset(Offset = "0x8")]
		protected string m_AssetBundleName;

		[Token(Token = "0x40011C0")]
		[FieldOffset(Offset = "0xC")]
		protected string m_LevelName;

		[Token(Token = "0x40011C1")]
		[FieldOffset(Offset = "0x10")]
		protected bool m_IsAdditive;

		[Token(Token = "0x40011C2")]
		[FieldOffset(Offset = "0x14")]
		protected string m_DownloadingError;

		[Token(Token = "0x40011C3")]
		[FieldOffset(Offset = "0x18")]
		protected AsyncOperation m_Request;

		[Token(Token = "0x6001C79")]
		[Address(RVA = "0x1EF7BA4", Offset = "0x1EF7BA4", VA = "0x1EF7BA4")]
		public XAssetBundleLoadLevelOperation(string assetbundleName, string levelName, bool isAdditive)
		{
		}

		[Token(Token = "0x6001C7A")]
		[Address(RVA = "0x1EF7BD4", Offset = "0x1EF7BD4", VA = "0x1EF7BD4", Slot = "7")]
		public override bool Update()
		{
			return default(bool);
		}

		[Token(Token = "0x6001C7B")]
		[Address(RVA = "0x1EF7CD4", Offset = "0x1EF7CD4", VA = "0x1EF7CD4", Slot = "8")]
		public override bool IsDone()
		{
			return default(bool);
		}
	}
}
