using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000A7E")]
	public class CSProtoInfoManager_ArenaShop : Dictionary<int, CSArenaShopItem>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x40030B3")]
		[FieldOffset(Offset = "0x34")]
		private Dictionary<CSArenaShopItem.Category, List<string>> countryDic;

		[Token(Token = "0x6004DF2")]
		[Address(RVA = "0x1FC1314", Offset = "0x1FC1314", VA = "0x1FC1314")]
		public CSProtoInfoManager_ArenaShop()
		{
		}

		[Token(Token = "0x6004DF3")]
		[Address(RVA = "0x1FC24C0", Offset = "0x1FC24C0", VA = "0x1FC24C0", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6004DF4")]
		[Address(RVA = "0x1FC24D0", Offset = "0x1FC24D0", VA = "0x1FC24D0", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6004DF5")]
		[Address(RVA = "0x1FC24D4", Offset = "0x1FC24D4", VA = "0x1FC24D4", Slot = "41")]
		public bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6004DF6")]
		[Address(RVA = "0x1FC2904", Offset = "0x1FC2904", VA = "0x1FC2904", Slot = "43")]
		public bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6004DF7")]
		[Address(RVA = "0x1FC2BDC", Offset = "0x1FC2BDC", VA = "0x1FC2BDC")]
		public void RefreshList(List<CSArenaShopItem> list)
		{
		}

		[Token(Token = "0x6004DF8")]
		[Address(RVA = "0x1FC2D4C", Offset = "0x1FC2D4C", VA = "0x1FC2D4C")]
		public List<CSArenaShopItem> GetDisplayShopSaleList(string strCountry, string strRegion)
		{
			return null;
		}

		[Token(Token = "0x6004DF9")]
		[Address(RVA = "0x1FC2F48", Offset = "0x1FC2F48", VA = "0x1FC2F48")]
		public bool IsShowItem(CSArenaShopItem item, string strCountry, string strRegion)
		{
			return default(bool);
		}

		[Token(Token = "0x6004DFA")]
		[Address(RVA = "0x1FC2FC4", Offset = "0x1FC2FC4", VA = "0x1FC2FC4")]
		private bool IsAllowCountry(CSArenaShopItem info, string strCountry)
		{
			return default(bool);
		}
	}
}
