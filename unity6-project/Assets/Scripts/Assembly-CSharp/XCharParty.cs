using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20003A7")]
public class XCharParty
{
	[Token(Token = "0x40012E7")]
	[FieldOffset(Offset = "0x8")]
	private UserDataBase m_UserDataBase;

	[Token(Token = "0x40012E8")]
	[FieldOffset(Offset = "0xC")]
	private XCharacterInventory m_CharacterInventory;

	[Token(Token = "0x40012E9")]
	[FieldOffset(Offset = "0x10")]
	private XCharacterInventory m_characterInventoryNotowned;

	[Token(Token = "0x40012EA")]
	[FieldOffset(Offset = "0x14")]
	private CharPartyId m_CurrentCharPartyId;

	[Token(Token = "0x40012EB")]
	[FieldOffset(Offset = "0x18")]
	private XServerPartySyncChecker m_ServerPartySyncChecker;

	[Token(Token = "0x17000505")]
	public CharPartyId CurrentCharPartyId
	{
		[Token(Token = "0x6001DFF")]
		[Address(RVA = "0x1ABDF80", Offset = "0x1ABDF80", VA = "0x1ABDF80")]
		get
		{
			return default(CharPartyId);
		}
	}

	[Token(Token = "0x17000506")]
	public int CurrentCharPartySelectRelicID
	{
		[Token(Token = "0x6001E00")]
		[Address(RVA = "0x1ABDF88", Offset = "0x1ABDF88", VA = "0x1ABDF88")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000507")]
	public int CurrentCharPartySelectRelicIndex
	{
		[Token(Token = "0x6001E01")]
		[Address(RVA = "0x1ABE0E0", Offset = "0x1ABE0E0", VA = "0x1ABE0E0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6001DFD")]
	[Address(RVA = "0x1ABDD80", Offset = "0x1ABDD80", VA = "0x1ABDD80")]
	public XCharParty(UserDataBase userDataBase, XCharacterInventory characterInventory, XCharacterInventory characterInventoryNotowned)
	{
	}

	[Token(Token = "0x6001DFE")]
	[Address(RVA = "0x1ABDE34", Offset = "0x1ABDE34", VA = "0x1ABDE34")]
	public void SelectParty(CharPartyId charPartyEnum)
	{
	}

	[Token(Token = "0x6001E02")]
	[Address(RVA = "0x1ABE238", Offset = "0x1ABE238", VA = "0x1ABE238")]
	public List<string> GetParty(CharPartyId charPartyId)
	{
		return null;
	}

	[Token(Token = "0x6001E03")]
	[Address(RVA = "0x1ABE27C", Offset = "0x1ABE27C", VA = "0x1ABE27C")]
	public List<string> GetCurrentParty()
	{
		return null;
	}

	[Token(Token = "0x6001E04")]
	[Address(RVA = "0x1ABE2C0", Offset = "0x1ABE2C0", VA = "0x1ABE2C0")]
	public int GetCurrentPartyMemberCount()
	{
		return default(int);
	}

	[Token(Token = "0x6001E05")]
	[Address(RVA = "0x1ABE35C", Offset = "0x1ABE35C", VA = "0x1ABE35C")]
	private XModuleActor GetActor(string id)
	{
		return null;
	}

	[Token(Token = "0x6001E06")]
	[Address(RVA = "0x1ABE3D8", Offset = "0x1ABE3D8", VA = "0x1ABE3D8")]
	public XModuleActor GetCharacter(int nMemberIndex = 0)
	{
		return null;
	}

	[Token(Token = "0x6001E07")]
	[Address(RVA = "0x1ABE4EC", Offset = "0x1ABE4EC", VA = "0x1ABE4EC")]
	public List<XModuleActor> GetPartyCharacters()
	{
		return null;
	}

	[Token(Token = "0x6001E08")]
	[Address(RVA = "0x1ABE7A4", Offset = "0x1ABE7A4", VA = "0x1ABE7A4")]
	public string GetCharCID(int nMemberIndex = 0)
	{
		return null;
	}

	[Token(Token = "0x6001E09")]
	[Address(RVA = "0x1ABE8FC", Offset = "0x1ABE8FC", VA = "0x1ABE8FC")]
	public string GetLeaderCID()
	{
		return null;
	}

	[Token(Token = "0x6001E0A")]
	[Address(RVA = "0x1ABE904", Offset = "0x1ABE904", VA = "0x1ABE904")]
	public XModuleActor GetLeaderCharacter()
	{
		return null;
	}

	[Token(Token = "0x6001E0B")]
	[Address(RVA = "0x1ABE90C", Offset = "0x1ABE90C", VA = "0x1ABE90C")]
	public int GetCharacterID(int nMemberIndex = 0)
	{
		return default(int);
	}

	[Token(Token = "0x6001E0C")]
	[Address(RVA = "0x1ABE96C", Offset = "0x1ABE96C", VA = "0x1ABE96C")]
	public CSCharacterInfo GetCharacterInfo(int nMemberIndex = 0)
	{
		return null;
	}

	[Token(Token = "0x6001E0D")]
	[Address(RVA = "0x1ABE990", Offset = "0x1ABE990", VA = "0x1ABE990")]
	public int GetHighLevel()
	{
		return default(int);
	}

	[Token(Token = "0x6001E0E")]
	[Address(RVA = "0x1ABEAE8", Offset = "0x1ABEAE8", VA = "0x1ABEAE8")]
	public void SetCurrentParty(List<string> cids)
	{
	}

	[Token(Token = "0x6001E0F")]
	[Address(RVA = "0x1ABEB34", Offset = "0x1ABEB34", VA = "0x1ABEB34")]
	public bool RemoveMember(string cid)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E10")]
	[Address(RVA = "0x1ABEBD8", Offset = "0x1ABEBD8", VA = "0x1ABEBD8")]
	public bool ContainsMember(string cid)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E11")]
	[Address(RVA = "0x1ABEC7C", Offset = "0x1ABEC7C", VA = "0x1ABEC7C")]
	public bool ContainsMember(int charID)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E12")]
	[Address(RVA = "0x1ABECD4", Offset = "0x1ABECD4", VA = "0x1ABECD4")]
	public bool IsLeaderMember(string cid)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E13")]
	[Address(RVA = "0x1ABEDCC", Offset = "0x1ABEDCC", VA = "0x1ABEDCC")]
	public bool IsChanged()
	{
		return default(bool);
	}

	[Token(Token = "0x6001E14")]
	[Address(RVA = "0x1ABEE18", Offset = "0x1ABEE18", VA = "0x1ABEE18")]
	public void Sync()
	{
	}
}
