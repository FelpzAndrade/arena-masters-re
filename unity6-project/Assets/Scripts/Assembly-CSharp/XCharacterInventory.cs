using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x20003A9")]
public class XCharacterInventory
{
	[Token(Token = "0x20003AA")]
	private sealed class _003CDidUpdateCharacterList_003Ec__AnonStoreyEC
	{
		[Token(Token = "0x40012EF")]
		[FieldOffset(Offset = "0x8")]
		internal int characterID;

		[Token(Token = "0x6001E35")]
		[Address(RVA = "0x1AB7D6C", Offset = "0x1AB7D6C", VA = "0x1AB7D6C")]
		public _003CDidUpdateCharacterList_003Ec__AnonStoreyEC()
		{
		}

		[Token(Token = "0x6001E36")]
		[Address(RVA = "0x1AB8304", Offset = "0x1AB8304", VA = "0x1AB8304")]
		internal bool _003C_003Em__A1(XModuleActor x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40012ED")]
	[FieldOffset(Offset = "0x8")]
	protected List<XModuleActor> m_CharacterList;

	[Token(Token = "0x40012EE")]
	[FieldOffset(Offset = "0xC")]
	private List<XModuleActor> tapjoyCharacterBackup;

	[Token(Token = "0x17000508")]
	public int Count
	{
		[Token(Token = "0x6001E25")]
		[Address(RVA = "0x1AB6FA0", Offset = "0x1AB6FA0", VA = "0x1AB6FA0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000509")]
	public int MaxCount
	{
		[Token(Token = "0x6001E26")]
		[Address(RVA = "0x1AB7038", Offset = "0x1AB7038", VA = "0x1AB7038")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6001E18")]
	[Address(RVA = "0x1AB6144", Offset = "0x1AB6144", VA = "0x1AB6144")]
	public XCharacterInventory()
	{
	}

	[Token(Token = "0x6001E19")]
	[Address(RVA = "0x1AB6208", Offset = "0x1AB6208", VA = "0x1AB6208")]
	public List<XModuleActor> GetList()
	{
		return null;
	}

	[Token(Token = "0x6001E1A")]
	[Address(RVA = "0x1AB6210", Offset = "0x1AB6210", VA = "0x1AB6210")]
	public List<int> GetIDList()
	{
		return null;
	}

	[Token(Token = "0x6001E1B")]
	[Address(RVA = "0x1AB63C8", Offset = "0x1AB63C8", VA = "0x1AB63C8")]
	public bool Add(XModuleActor newCharacter)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E1C")]
	[Address(RVA = "0x1AB6478", Offset = "0x1AB6478", VA = "0x1AB6478")]
	public void Remove(string cid)
	{
	}

	[Token(Token = "0x6001E1D")]
	[Address(RVA = "0x1AB66EC", Offset = "0x1AB66EC", VA = "0x1AB66EC")]
	public XModuleActor Slot(int nSlotID)
	{
		return null;
	}

	[Token(Token = "0x6001E1E")]
	[Address(RVA = "0x1AB67D4", Offset = "0x1AB67D4", VA = "0x1AB67D4")]
	public void Clear()
	{
	}

	[Token(Token = "0x6001E1F")]
	[Address(RVA = "0x1AB6588", Offset = "0x1AB6588", VA = "0x1AB6588")]
	public XModuleActor Find(string cid)
	{
		return null;
	}

	[Token(Token = "0x6001E20")]
	[Address(RVA = "0x1AB6938", Offset = "0x1AB6938", VA = "0x1AB6938")]
	public XModuleActor Find(int charId)
	{
		return null;
	}

	[Token(Token = "0x6001E21")]
	[Address(RVA = "0x1AB6A48", Offset = "0x1AB6A48", VA = "0x1AB6A48")]
	public List<int> OwnCharIdList()
	{
		return null;
	}

	[Token(Token = "0x6001E22")]
	[Address(RVA = "0x1AB6C00", Offset = "0x1AB6C00", VA = "0x1AB6C00")]
	public int GetSlotID(string cid)
	{
		return default(int);
	}

	[Token(Token = "0x6001E23")]
	[Address(RVA = "0x1AB6D64", Offset = "0x1AB6D64", VA = "0x1AB6D64")]
	public int GetMyCharacterMaxLevel()
	{
		return default(int);
	}

	[Token(Token = "0x6001E24")]
	[Address(RVA = "0x1AB6E80", Offset = "0x1AB6E80", VA = "0x1AB6E80")]
	public bool HasNew()
	{
		return default(bool);
	}

	[Token(Token = "0x6001E27")]
	[Address(RVA = "0x1AB70FC", Offset = "0x1AB70FC", VA = "0x1AB70FC")]
	public bool IsExist(string cid)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E28")]
	[Address(RVA = "0x1AB7114", Offset = "0x1AB7114", VA = "0x1AB7114")]
	public bool Add(string uid, int charId, int skinId, int level, int xp, SkillSpecialized specialized_skill_list, Netdata_EquipedItem[] equipItems, bool isShowed, List<int> skinList)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E29")]
	[Address(RVA = "0x1AB735C", Offset = "0x1AB735C", VA = "0x1AB735C")]
	private void AddCharacaterFromNetData(Netdata_Char data)
	{
	}

	[Token(Token = "0x6001E2A")]
	[Address(RVA = "0x1AB77BC", Offset = "0x1AB77BC", VA = "0x1AB77BC")]
	public void UpdateCharacterListFromServer(JArray arr)
	{
	}

	[Token(Token = "0x6001E2B")]
	[Address(RVA = "0x1AB7C70", Offset = "0x1AB7C70", VA = "0x1AB7C70")]
	public void UpdateCharacterListFromServer(List<Netdata_Char> list)
	{
	}

	[Token(Token = "0x6001E2C")]
	[Address(RVA = "0x1AB78B0", Offset = "0x1AB78B0", VA = "0x1AB78B0")]
	private void WillUpdateCharacterList()
	{
	}

	[Token(Token = "0x6001E2D")]
	[Address(RVA = "0x1AB7978", Offset = "0x1AB7978", VA = "0x1AB7978")]
	private void DidUpdateCharacterList()
	{
	}

	[Token(Token = "0x6001E2E")]
	[Address(RVA = "0x1AB7D74", Offset = "0x1AB7D74", VA = "0x1AB7D74")]
	internal void PatchCharacterByDiff(JObject diffJObj)
	{
	}

	[Token(Token = "0x6001E2F")]
	[Address(RVA = "0x1AB7D78", Offset = "0x1AB7D78", VA = "0x1AB7D78")]
	internal void PatchCharacterListByDiff(JObject diffJObj)
	{
	}

	[Token(Token = "0x6001E30")]
	[Address(RVA = "0x1AB7E30", Offset = "0x1AB7E30", VA = "0x1AB7E30")]
	private NetData_Char_List MakeTDNetDataChar()
	{
		return null;
	}

	[Token(Token = "0x6001E31")]
	[Address(RVA = "0x1AB7F94", Offset = "0x1AB7F94", VA = "0x1AB7F94")]
	public void UpdateCharacterFromServer(JToken source)
	{
	}

	[Token(Token = "0x6001E32")]
	[Address(RVA = "0x1AB8060", Offset = "0x1AB8060", VA = "0x1AB8060")]
	public bool HasCharacter(int charId)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E33")]
	[Address(RVA = "0x1AB8170", Offset = "0x1AB8170", VA = "0x1AB8170")]
	public void UpdateAllCharacterTalentStatus()
	{
	}

	[Token(Token = "0x6001E34")]
	[Address(RVA = "0x1AB8264", Offset = "0x1AB8264", VA = "0x1AB8264")]
	public void Sort(IComparer<XModuleActor> comparer)
	{
	}
}
