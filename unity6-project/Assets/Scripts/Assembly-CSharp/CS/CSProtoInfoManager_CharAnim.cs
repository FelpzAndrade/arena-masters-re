using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000A9F")]
	public class CSProtoInfoManager_CharAnim : Dictionary<string, Dictionary<AniCategoryType, Dictionary<string, Dictionary<int, CharAnimInfo>>>>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x4003180")]
		[FieldOffset(Offset = "0x34")]
		private Dictionary<KeyValuePair<string, KeyValuePair<int, string>>, string> resourcePathDic;

		[Token(Token = "0x4003181")]
		[FieldOffset(Offset = "0x38")]
		private List<string> m_exportGroupingFolderList;

		[Token(Token = "0x6004E4F")]
		[Address(RVA = "0x1FC78C0", Offset = "0x1FC78C0", VA = "0x1FC78C0")]
		public CSProtoInfoManager_CharAnim()
		{
		}

		[Token(Token = "0x6004E50")]
		[Address(RVA = "0x1FC79AC", Offset = "0x1FC79AC", VA = "0x1FC79AC")]
		public List<string> GetExportGroupingFolderList()
		{
			return null;
		}

		[Token(Token = "0x6004E51")]
		[Address(RVA = "0x1FC79B4", Offset = "0x1FC79B4", VA = "0x1FC79B4", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E52")]
		[Address(RVA = "0x1FC79C4", Offset = "0x1FC79C4", VA = "0x1FC79C4", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6004E53")]
		[Address(RVA = "0x1FC79C8", Offset = "0x1FC79C8", VA = "0x1FC79C8", Slot = "41")]
		public bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E54")]
		[Address(RVA = "0x1FC79D0", Offset = "0x1FC79D0", VA = "0x1FC79D0", Slot = "44")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E55")]
		[Address(RVA = "0x1FC8410", Offset = "0x1FC8410", VA = "0x1FC8410")]
		public bool HasAniPathList(string char_key, AniCategoryType type)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E56")]
		[Address(RVA = "0x1FC852C", Offset = "0x1FC852C", VA = "0x1FC852C")]
		public List<KeyValuePair<string, string>> GetAniClipPathList(string char_key, AniCategoryType type, int skin_id)
		{
			return null;
		}

		[Token(Token = "0x6004E57")]
		[Address(RVA = "0x1FC8918", Offset = "0x1FC8918", VA = "0x1FC8918")]
		public string GetAnimationPath(string setKey, int skinID, string clipName)
		{
			return null;
		}
	}
}
