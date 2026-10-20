using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B1C")]
	public class CSProtoInfoManager_PackageShop : Dictionary<int, PackageShopInfo>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x2000B1D")]
		private sealed class _003CLoadFromList_003Ec__AnonStorey156
		{
			[Token(Token = "0x40036C8")]
			[FieldOffset(Offset = "0x8")]
			internal Cash.Market market;

			[Token(Token = "0x60051D3")]
			[Address(RVA = "0x1CB84D0", Offset = "0x1CB84D0", VA = "0x1CB84D0")]
			public _003CLoadFromList_003Ec__AnonStorey156()
			{
			}

			[Token(Token = "0x60051D4")]
			[Address(RVA = "0x1CB8934", Offset = "0x1CB8934", VA = "0x1CB8934")]
			internal bool _003C_003Em__209(PackageShopInfo item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40036C4")]
		[FieldOffset(Offset = "0x34")]
		private Dictionary<DoubleKey, List<string>> countryDic;

		[Token(Token = "0x40036C5")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<PackageShopCategory, List<PackageShopInfo>> categoryDic;

		[Token(Token = "0x40036C6")]
		[FieldOffset(Offset = "0x3C")]
		public Dictionary<int, PackageShopInfo> NewShopItems;

		[Token(Token = "0x40036C7")]
		[FieldOffset(Offset = "0x40")]
		public List<PackageShopInfo> dataList;

		[Token(Token = "0x17000C05")]
		public Dictionary<PackageShopCategory, List<PackageShopInfo>> CategoryDic
		{
			[Token(Token = "0x60051C9")]
			[Address(RVA = "0x1CB74F4", Offset = "0x1CB74F4", VA = "0x1CB74F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60051C8")]
		[Address(RVA = "0x1CB73E0", Offset = "0x1CB73E0", VA = "0x1CB73E0")]
		public CSProtoInfoManager_PackageShop()
		{
		}

		[Token(Token = "0x60051CA")]
		[Address(RVA = "0x1CB74FC", Offset = "0x1CB74FC", VA = "0x1CB74FC", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x60051CB")]
		[Address(RVA = "0x1CB750C", Offset = "0x1CB750C", VA = "0x1CB750C", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x60051CC")]
		[Address(RVA = "0x1CB7510", Offset = "0x1CB7510", VA = "0x1CB7510", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x60051CD")]
		[Address(RVA = "0x1CB7B30", Offset = "0x1CB7B30", VA = "0x1CB7B30")]
		private void ClearData()
		{
		}

		[Token(Token = "0x60051CE")]
		[Address(RVA = "0x1CB7C3C", Offset = "0x1CB7C3C", VA = "0x1CB7C3C", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x60051CF")]
		[Address(RVA = "0x1CB7F18", Offset = "0x1CB7F18", VA = "0x1CB7F18")]
		public void LoadFromList(List<PackageShopInfo> list)
		{
		}

		[Token(Token = "0x60051D0")]
		[Address(RVA = "0x1CB84D8", Offset = "0x1CB84D8", VA = "0x1CB84D8")]
		public PackageShopInfo GetShopItem(int nProductID)
		{
			return null;
		}

		[Token(Token = "0x60051D1")]
		[Address(RVA = "0x1CB859C", Offset = "0x1CB859C", VA = "0x1CB859C")]
		public PackageShopInfo GetShopItemBy_StoreProductId(string store_product_id)
		{
			return null;
		}

		[Token(Token = "0x60051D2")]
		[Address(RVA = "0x1CB878C", Offset = "0x1CB878C", VA = "0x1CB878C")]
		public bool IsAllowCountry(PackageShopInfo info, string strCountry)
		{
			return default(bool);
		}
	}
}
