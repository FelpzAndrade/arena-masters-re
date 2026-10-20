using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x20006ED")]
public class XItemInventory
{
	[Token(Token = "0x4002139")]
	[FieldOffset(Offset = "0x8")]
	public List<XItem> m_ItemList;

	[Token(Token = "0x400213A")]
	[FieldOffset(Offset = "0x0")]
	public static bool defaultStatIsPVP;

	[Token(Token = "0x400213B")]
	[FieldOffset(Offset = "0x4")]
	private static Func<XItem, bool> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x400213C")]
	[FieldOffset(Offset = "0x8")]
	private static Func<XItem, bool> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x1700082B")]
	public int Count
	{
		[Token(Token = "0x6003A2D")]
		[Address(RVA = "0x1D34018", Offset = "0x1D34018", VA = "0x1D34018")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6003A25")]
	[Address(RVA = "0x1D341E8", Offset = "0x1D341E8", VA = "0x1D341E8")]
	public XItemInventory()
	{
	}

	[Token(Token = "0x6003A27")]
	[Address(RVA = "0x1D34298", Offset = "0x1D34298", VA = "0x1D34298")]
	public List<int> GetIDList()
	{
		return null;
	}

	[Token(Token = "0x6003A28")]
	[Address(RVA = "0x1D34400", Offset = "0x1D34400", VA = "0x1D34400")]
	public bool Add(XItem newItem)
	{
		return default(bool);
	}

	[Token(Token = "0x6003A29")]
	[Address(RVA = "0x1D3457C", Offset = "0x1D3457C", VA = "0x1D3457C")]
	public void Remove(string iid)
	{
	}

	[Token(Token = "0x6003A2A")]
	[Address(RVA = "0x1D3470C", Offset = "0x1D3470C", VA = "0x1D3470C")]
	public XItem Slot(int nSlotID)
	{
		return null;
	}

	[Token(Token = "0x6003A2B")]
	[Address(RVA = "0x1D347F4", Offset = "0x1D347F4", VA = "0x1D347F4")]
	public bool IsEmptySlot(int nSlotID)
	{
		return default(bool);
	}

	[Token(Token = "0x6003A2C")]
	[Address(RVA = "0x1D34814", Offset = "0x1D34814", VA = "0x1D34814")]
	public void Clear()
	{
	}

	[Token(Token = "0x6003A2E")]
	[Address(RVA = "0x1D30220", Offset = "0x1D30220", VA = "0x1D30220")]
	public XItem Find(string iid)
	{
		return null;
	}

	[Token(Token = "0x6003A2F")]
	[Address(RVA = "0x1D3363C", Offset = "0x1D3363C", VA = "0x1D3363C")]
	public XItem Find(int nId)
	{
		return null;
	}

	[Token(Token = "0x6003A30")]
	[Address(RVA = "0x1D348AC", Offset = "0x1D348AC", VA = "0x1D348AC")]
	public int GetSlotID(string iid)
	{
		return default(int);
	}

	[Token(Token = "0x6003A31")]
	[Address(RVA = "0x1D34A0C", Offset = "0x1D34A0C", VA = "0x1D34A0C")]
	public bool IsExist(string iid)
	{
		return default(bool);
	}

	[Token(Token = "0x6003A32")]
	[Address(RVA = "0x1D34A24", Offset = "0x1D34A24", VA = "0x1D34A24")]
	private bool NewItemFromNetDataItem(Netdata_Item data, out XItem item)
	{
		item = default;
		return default(bool);
	}

	[Token(Token = "0x6003A33")]
	[Address(RVA = "0x1D34BE4", Offset = "0x1D34BE4", VA = "0x1D34BE4")]
	public void UpdateFromServer(JArray arr)
	{
	}

	[Token(Token = "0x6003A34")]
	[Address(RVA = "0x1D34D40", Offset = "0x1D34D40", VA = "0x1D34D40")]
	public void PatchByDiff(JObject diffJObj)
	{
	}

	[Token(Token = "0x6003A35")]
	[Address(RVA = "0x1D34D3C", Offset = "0x1D34D3C", VA = "0x1D34D3C")]
	private void ItemListSort()
	{
	}

	[Token(Token = "0x6003A36")]
	[Address(RVA = "0x1D34EE8", Offset = "0x1D34EE8", VA = "0x1D34EE8")]
	private Netdata_Item_List MakeTDNetDataItem()
	{
		return null;
	}

	[Token(Token = "0x6003A37")]
	[Address(RVA = "0x1D35048", Offset = "0x1D35048", VA = "0x1D35048")]
	public int GetDimensionSoulStoneCount()
	{
		return default(int);
	}

	[Token(Token = "0x6003A38")]
	[Address(RVA = "0x1D3522C", Offset = "0x1D3522C", VA = "0x1D3522C")]
	public int GetSoulStoneCount(int charId)
	{
		return default(int);
	}

	[Token(Token = "0x6003A39")]
	[Address(RVA = "0x1D35388", Offset = "0x1D35388", VA = "0x1D35388")]
	public int GetDimensionSoulDustCount()
	{
		return default(int);
	}

	[Token(Token = "0x6003A3A")]
	[Address(RVA = "0x1D3556C", Offset = "0x1D3556C", VA = "0x1D3556C")]
	public int GetSoulDustCount(int charId)
	{
		return default(int);
	}

	[Token(Token = "0x6003A3B")]
	[Address(RVA = "0x1D356C8", Offset = "0x1D356C8", VA = "0x1D356C8")]
	public int GetRelicPieceCount(int relicPieceId)
	{
		return default(int);
	}

	[Token(Token = "0x6003A3C")]
	[Address(RVA = "0x1D35800", Offset = "0x1D35800", VA = "0x1D35800")]
	public string GetRelicPieceIID(int relicPieceId)
	{
		return null;
	}

	[Token(Token = "0x6003A3D")]
	[Address(RVA = "0x1D35980", Offset = "0x1D35980", VA = "0x1D35980")]
	public int GetCount(int itemID)
	{
		return default(int);
	}

	[Token(Token = "0x6003A3E")]
	[Address(RVA = "0x1D35A94", Offset = "0x1D35A94", VA = "0x1D35A94")]
	public int GetNewItemCount()
	{
		return default(int);
	}

	[Token(Token = "0x6003A3F")]
	[Address(RVA = "0x1D35B90", Offset = "0x1D35B90", VA = "0x1D35B90")]
	public void ClearNew()
	{
	}

	[Token(Token = "0x6003A40")]
	[Address(RVA = "0x1D35C80", Offset = "0x1D35C80", VA = "0x1D35C80")]
	public bool HasNew()
	{
		return default(bool);
	}

	[Token(Token = "0x6003A41")]
	[Address(RVA = "0x1D35D84", Offset = "0x1D35D84", VA = "0x1D35D84")]
	public bool HasNew(out bool weapon, out bool armor, out bool accessory, out bool etc)
	{
		accessory = default;
		armor = default;
		etc = default;
		weapon = default;
		return default(bool);
	}

	[Token(Token = "0x6003A42")]
	[Address(RVA = "0x1D35FC0", Offset = "0x1D35FC0", VA = "0x1D35FC0")]
	public bool NeedMoreSlot(int productId, int addCount)
	{
		return default(bool);
	}

	[Token(Token = "0x6003A43")]
	[Address(RVA = "0x1D36168", Offset = "0x1D36168", VA = "0x1D36168")]
	public int GetMaxItemStackCount()
	{
		return default(int);
	}

	[Token(Token = "0x6003A44")]
	[Address(RVA = "0x1D362A8", Offset = "0x1D362A8", VA = "0x1D362A8")]
	public int GetResurrectionItemStackCount()
	{
		return default(int);
	}

	[Token(Token = "0x6003A45")]
	[Address(RVA = "0x1D363BC", Offset = "0x1D363BC", VA = "0x1D363BC")]
	private static bool _003CGetDimensionSoulStoneCount_003Em__197(XItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x6003A46")]
	[Address(RVA = "0x1D363EC", Offset = "0x1D363EC", VA = "0x1D363EC")]
	private static bool _003CGetDimensionSoulDustCount_003Em__198(XItem item)
	{
		return default(bool);
	}
}
