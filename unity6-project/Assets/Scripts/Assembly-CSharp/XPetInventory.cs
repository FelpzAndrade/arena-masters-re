using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x20003CF")]
public class XPetInventory
{
	[Token(Token = "0x400134E")]
	[FieldOffset(Offset = "0x8")]
	protected List<XModuleActor> m_PetList;

	[Token(Token = "0x400134F")]
	[FieldOffset(Offset = "0xC")]
	private List<XModuleActor> tapjoyPetBackup;

	[Token(Token = "0x17000549")]
	public int Count
	{
		[Token(Token = "0x6001F42")]
		[Address(RVA = "0xADDFEC", Offset = "0xADDFEC", VA = "0xADDFEC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700054A")]
	public int MaxCount
	{
		[Token(Token = "0x6001F43")]
		[Address(RVA = "0xADE084", Offset = "0xADE084", VA = "0xADE084")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6001F35")]
	[Address(RVA = "0xADD190", Offset = "0xADD190", VA = "0xADD190")]
	public XPetInventory()
	{
	}

	[Token(Token = "0x6001F36")]
	[Address(RVA = "0xADD254", Offset = "0xADD254", VA = "0xADD254")]
	public List<XModuleActor> GetList()
	{
		return null;
	}

	[Token(Token = "0x6001F37")]
	[Address(RVA = "0xADD25C", Offset = "0xADD25C", VA = "0xADD25C")]
	public List<int> GetIDList()
	{
		return null;
	}

	[Token(Token = "0x6001F38")]
	[Address(RVA = "0xADD414", Offset = "0xADD414", VA = "0xADD414")]
	public bool Add(XModuleActor newPet)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F39")]
	[Address(RVA = "0xADD4C4", Offset = "0xADD4C4", VA = "0xADD4C4")]
	public void Remove(string cid)
	{
	}

	[Token(Token = "0x6001F3A")]
	[Address(RVA = "0xADD738", Offset = "0xADD738", VA = "0xADD738")]
	public XModuleActor Slot(int nSlotID)
	{
		return null;
	}

	[Token(Token = "0x6001F3B")]
	[Address(RVA = "0xADD820", Offset = "0xADD820", VA = "0xADD820")]
	public void Clear()
	{
	}

	[Token(Token = "0x6001F3C")]
	[Address(RVA = "0xADD5D4", Offset = "0xADD5D4", VA = "0xADD5D4")]
	public XModuleActor Find(string cid)
	{
		return null;
	}

	[Token(Token = "0x6001F3D")]
	[Address(RVA = "0xADD984", Offset = "0xADD984", VA = "0xADD984")]
	public XModuleActor Find(int charId)
	{
		return null;
	}

	[Token(Token = "0x6001F3E")]
	[Address(RVA = "0xADDA94", Offset = "0xADDA94", VA = "0xADDA94")]
	public List<int> OwnCharIdList()
	{
		return null;
	}

	[Token(Token = "0x6001F3F")]
	[Address(RVA = "0xADDC4C", Offset = "0xADDC4C", VA = "0xADDC4C")]
	public int GetSlotID(string cid)
	{
		return default(int);
	}

	[Token(Token = "0x6001F40")]
	[Address(RVA = "0xADDDB0", Offset = "0xADDDB0", VA = "0xADDDB0")]
	public int GetMyPetMaxLevel()
	{
		return default(int);
	}

	[Token(Token = "0x6001F41")]
	[Address(RVA = "0xADDECC", Offset = "0xADDECC", VA = "0xADDECC")]
	public bool HasNew()
	{
		return default(bool);
	}

	[Token(Token = "0x6001F44")]
	[Address(RVA = "0xADE148", Offset = "0xADE148", VA = "0xADE148")]
	public bool IsExist(string cid)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F45")]
	[Address(RVA = "0xADE160", Offset = "0xADE160", VA = "0xADE160")]
	public bool Add(string uid, int charId, int skinId, int level, int xp, SkillSpecialized specialized_skill_list, Netdata_EquipedItem[] equipItems, bool isShowed, List<int> skinList)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F46")]
	[Address(RVA = "0xADE3A8", Offset = "0xADE3A8", VA = "0xADE3A8")]
	private void AddPetFromNetData(Netdata_Pet data)
	{
	}

	[Token(Token = "0x6001F47")]
	[Address(RVA = "0xADE7E4", Offset = "0xADE7E4", VA = "0xADE7E4")]
	public void UpdatePetListFromServer(JArray arr)
	{
	}

	[Token(Token = "0x6001F48")]
	[Address(RVA = "0xADEB3C", Offset = "0xADEB3C", VA = "0xADEB3C")]
	public void UpdatePetListFromServer(List<Netdata_Pet> list)
	{
	}

	[Token(Token = "0x6001F49")]
	[Address(RVA = "0xADE8D8", Offset = "0xADE8D8", VA = "0xADE8D8")]
	private void WillUpdatePetList()
	{
	}

	[Token(Token = "0x6001F4A")]
	[Address(RVA = "0xADE9A0", Offset = "0xADE9A0", VA = "0xADE9A0")]
	private void DidUpdatePetList()
	{
	}

	[Token(Token = "0x6001F4B")]
	[Address(RVA = "0xADEC38", Offset = "0xADEC38", VA = "0xADEC38")]
	internal void PatchPetByDiff(JObject diffJObj)
	{
	}

	[Token(Token = "0x6001F4C")]
	[Address(RVA = "0xADEC3C", Offset = "0xADEC3C", VA = "0xADEC3C")]
	internal void PatchPetListByDiff(JObject diffJObj)
	{
	}

	[Token(Token = "0x6001F4D")]
	[Address(RVA = "0xADECF4", Offset = "0xADECF4", VA = "0xADECF4")]
	private NetData_Pet_List MakeTDNetDataPet()
	{
		return null;
	}

	[Token(Token = "0x6001F4E")]
	[Address(RVA = "0xADEE58", Offset = "0xADEE58", VA = "0xADEE58")]
	public void UpdatePetFromServer(JToken source)
	{
	}

	[Token(Token = "0x6001F4F")]
	[Address(RVA = "0xADEF24", Offset = "0xADEF24", VA = "0xADEF24")]
	public bool HasPet(int charId)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F50")]
	[Address(RVA = "0xADF034", Offset = "0xADF034", VA = "0xADF034")]
	public void UpdateAllPetTalentStatus()
	{
	}

	[Token(Token = "0x6001F51")]
	[Address(RVA = "0xADF128", Offset = "0xADF128", VA = "0xADF128")]
	public List<int> OwnPetIdList()
	{
		return null;
	}

	[Token(Token = "0x6001F52")]
	[Address(RVA = "0xADF2E0", Offset = "0xADF2E0", VA = "0xADF2E0")]
	public void Sort(IComparer<XModuleActor> comparer)
	{
	}

	[Token(Token = "0x6001F53")]
	[Address(RVA = "0xADF380", Offset = "0xADF380", VA = "0xADF380")]
	public bool GetPetLevelUpState()
	{
		return default(bool);
	}
}
