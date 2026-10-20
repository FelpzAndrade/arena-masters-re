using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000662")]
public class ProtoInfoManager_GameModeSort : Dictionary<XGameModeMainCatecory, List<XGameModeSortInfo>>, CSProtoInfoManagerBase
{
	[Token(Token = "0x2000663")]
	private sealed class _003CGetItem_003Ec__AnonStorey129
	{
		[Token(Token = "0x4001E9C")]
		[FieldOffset(Offset = "0x8")]
		internal XGameModeSubCatecory subcategory;

		[Token(Token = "0x600364E")]
		[Address(RVA = "0x20E7C50", Offset = "0x20E7C50", VA = "0x20E7C50")]
		public _003CGetItem_003Ec__AnonStorey129()
		{
		}

		[Token(Token = "0x600364F")]
		[Address(RVA = "0x20E7C8C", Offset = "0x20E7C8C", VA = "0x20E7C8C")]
		internal bool _003C_003Em__180(XGameModeSortInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4001E9B")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<XGameModeSortInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6003646")]
	[Address(RVA = "0x20E6DBC", Offset = "0x20E6DBC", VA = "0x20E6DBC")]
	public ProtoInfoManager_GameModeSort()
	{
	}

	[Token(Token = "0x6003647")]
	[Address(RVA = "0x20E6E40", Offset = "0x20E6E40", VA = "0x20E6E40", Slot = "40")]
	public bool IsFrom(ProtoInfoFrom from)
	{
		return default(bool);
	}

	[Token(Token = "0x6003648")]
	[Address(RVA = "0x20E6E50", Offset = "0x20E6E50", VA = "0x20E6E50", Slot = "42")]
	public void RemoveNotTagedContents(CSProtoInfoManagers protos)
	{
	}

	[Token(Token = "0x6003649")]
	[Address(RVA = "0x20E6E54", Offset = "0x20E6E54", VA = "0x20E6E54", Slot = "41")]
	public bool Cooking(CSProtoInfoManagers protos)
	{
		return default(bool);
	}

	[Token(Token = "0x600364A")]
	[Address(RVA = "0x20E732C", Offset = "0x20E732C", VA = "0x20E732C", Slot = "43")]
	public bool LoadFromLocalFile(CSFileLoaderBase loader)
	{
		return default(bool);
	}

	[Token(Token = "0x600364B")]
	[Address(RVA = "0x20E7910", Offset = "0x20E7910", VA = "0x20E7910")]
	public List<XGameModeSortInfo> GetItemList(XGameModeMainCatecory mainCategory)
	{
		return null;
	}

	[Token(Token = "0x600364C")]
	[Address(RVA = "0x20E7AC4", Offset = "0x20E7AC4", VA = "0x20E7AC4")]
	public XGameModeSortInfo GetItem(XGameModeMainCatecory mainCategory, XGameModeSubCatecory subcategory)
	{
		return null;
	}

	[Token(Token = "0x600364D")]
	[Address(RVA = "0x20E7C58", Offset = "0x20E7C58", VA = "0x20E7C58")]
	private static int _003CGetItemList_003Em__17F(XGameModeSortInfo x, XGameModeSortInfo y)
	{
		return default(int);
	}
}
