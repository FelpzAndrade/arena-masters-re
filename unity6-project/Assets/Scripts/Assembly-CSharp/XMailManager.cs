using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000755")]
public class XMailManager
{
	[Token(Token = "0x40022A1")]
	[FieldOffset(Offset = "0x8")]
	public Dictionary<string, CSMailData> m_MailItemDictionary;

	[Token(Token = "0x40022A2")]
	[FieldOffset(Offset = "0xC")]
	public List<CSMailData> m_MailNormalItemList;

	[Token(Token = "0x40022A3")]
	[FieldOffset(Offset = "0x10")]
	public List<CSMailData> m_MailShopItemList;

	[Token(Token = "0x40022A4")]
	[FieldOffset(Offset = "0x14")]
	public List<CSMailData> m_MailCooperationItemList;

	[Token(Token = "0x40022A5")]
	[FieldOffset(Offset = "0x18")]
	public List<CSMailData> m_MailPresentItemList;

	[Token(Token = "0x40022A6")]
	[FieldOffset(Offset = "0x1C")]
	public List<CSMailData> m_MailCashItemList;

	[Token(Token = "0x40022A7")]
	[FieldOffset(Offset = "0x20")]
	private bool m_bLoaded;

	[Token(Token = "0x1700083D")]
	public bool Loaded
	{
		[Token(Token = "0x6003BDE")]
		[Address(RVA = "0x1E28954", Offset = "0x1E28954", VA = "0x1E28954")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003BD4")]
	[Address(RVA = "0x1E275FC", Offset = "0x1E275FC", VA = "0x1E275FC")]
	public XMailManager()
	{
	}

	[Token(Token = "0x6003BD5")]
	[Address(RVA = "0x1E27744", Offset = "0x1E27744", VA = "0x1E27744")]
	private void ClearMailList(List<CSMailData> list)
	{
	}

	[Token(Token = "0x6003BD6")]
	[Address(RVA = "0x1E27DC4", Offset = "0x1E27DC4", VA = "0x1E27DC4")]
	public List<CSMailData> GetMailList(MailType type)
	{
		return null;
	}

	[Token(Token = "0x6003BD7")]
	[Address(RVA = "0x1E27E28", Offset = "0x1E27E28", VA = "0x1E27E28")]
	public void ClearMails(MailType type)
	{
	}

	[Token(Token = "0x6003BD8")]
	[Address(RVA = "0x1E27E94", Offset = "0x1E27E94", VA = "0x1E27E94")]
	public void ClearAllMails()
	{
	}

	[Token(Token = "0x6003BD9")]
	[Address(RVA = "0x1E27FE8", Offset = "0x1E27FE8", VA = "0x1E27FE8")]
	public bool AddMail(CSMailData mailItem)
	{
		return default(bool);
	}

	[Token(Token = "0x6003BDA")]
	[Address(RVA = "0x1E283C8", Offset = "0x1E283C8", VA = "0x1E283C8")]
	public bool DelMail(string strUID)
	{
		return default(bool);
	}

	[Token(Token = "0x6003BDB")]
	[Address(RVA = "0x1E28590", Offset = "0x1E28590", VA = "0x1E28590")]
	public CSMailData FindMail(string strUID)
	{
		return null;
	}

	[Token(Token = "0x6003BDC")]
	[Address(RVA = "0x1E28648", Offset = "0x1E28648", VA = "0x1E28648")]
	public void LoadMails(JObject json)
	{
	}

	[Token(Token = "0x6003BDD")]
	[Address(RVA = "0x1E287AC", Offset = "0x1E287AC", VA = "0x1E287AC")]
	public List<CSMailData> RecievedFaildMailsData(JObject json)
	{
		return null;
	}

	[Token(Token = "0x6003BDF")]
	[Address(RVA = "0x1E2895C", Offset = "0x1E2895C", VA = "0x1E2895C")]
	private bool CheckCanObtain(List<CSMailData> list)
	{
		return default(bool);
	}

	[Token(Token = "0x6003BE0")]
	[Address(RVA = "0x1E28A60", Offset = "0x1E28A60", VA = "0x1E28A60")]
	public bool CanObtainAll(MailType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6003BE1")]
	[Address(RVA = "0x1E28AEC", Offset = "0x1E28AEC", VA = "0x1E28AEC")]
	private bool CheckIncludeGachaMail(List<CSMailData> list)
	{
		return default(bool);
	}

	[Token(Token = "0x6003BE2")]
	[Address(RVA = "0x1E28C4C", Offset = "0x1E28C4C", VA = "0x1E28C4C")]
	public bool IncludeGachaMail(MailType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6003BE3")]
	[Address(RVA = "0x1E28CD8", Offset = "0x1E28CD8", VA = "0x1E28CD8")]
	private bool CheckIncludePackageMail(List<CSMailData> list)
	{
		return default(bool);
	}

	[Token(Token = "0x6003BE4")]
	[Address(RVA = "0x1E28E38", Offset = "0x1E28E38", VA = "0x1E28E38")]
	public bool IncludePackageMail(MailType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6003BE5")]
	[Address(RVA = "0x1E28EB4", Offset = "0x1E28EB4", VA = "0x1E28EB4")]
	private bool CheckIncludePremiumTicketMail(List<CSMailData> list, int productID)
	{
		return default(bool);
	}

	[Token(Token = "0x6003BE6")]
	[Address(RVA = "0x1E2901C", Offset = "0x1E2901C", VA = "0x1E2901C")]
	public bool IncludePremiumTicketMail(int productID)
	{
		return default(bool);
	}

	[Token(Token = "0x6003BE7")]
	[Address(RVA = "0x1E29044", Offset = "0x1E29044", VA = "0x1E29044")]
	private bool AnalyzeContent(CSContent[] contents, ref int itemCount, ref List<CSContent> stackable)
	{
		return default(bool);
	}

	[Token(Token = "0x6003BE8")]
	[Address(RVA = "0x1E2789C", Offset = "0x1E2789C", VA = "0x1E2789C")]
	public bool CanObtain(string mailUID)
	{
		return default(bool);
	}

	[Token(Token = "0x6003BE9")]
	[Address(RVA = "0x1E2951C", Offset = "0x1E2951C", VA = "0x1E2951C")]
	private CSContent CharacterToSoulStone(CSContent content)
	{
		return null;
	}

	[Token(Token = "0x6003BEA")]
	[Address(RVA = "0x1E29688", Offset = "0x1E29688", VA = "0x1E29688")]
	public int OccupySlotCount(CSContent content)
	{
		return default(int);
	}

	[Token(Token = "0x6003BEB")]
	[Address(RVA = "0x1E281D8", Offset = "0x1E281D8", VA = "0x1E281D8")]
	private bool CheckExpireMail(CSMailData mail)
	{
		return default(bool);
	}
}
