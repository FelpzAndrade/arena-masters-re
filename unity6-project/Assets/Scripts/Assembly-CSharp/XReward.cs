using CS;
using Il2CppDummyDll;

[Token(Token = "0x20004F8")]
public class XReward
{
	[Token(Token = "0x400191D")]
	[FieldOffset(Offset = "0x8")]
	private XRewardCategory m_nRewardCategory;

	[Token(Token = "0x400191E")]
	[FieldOffset(Offset = "0xC")]
	private CSContentType m_nRewardType;

	[Token(Token = "0x400191F")]
	[FieldOffset(Offset = "0x10")]
	private bool m_bReceived;

	[Token(Token = "0x4001920")]
	[FieldOffset(Offset = "0x14")]
	private string m_UID;

	[Token(Token = "0x4001921")]
	[FieldOffset(Offset = "0x18")]
	private int m_nGold;

	[Token(Token = "0x4001922")]
	[FieldOffset(Offset = "0x1C")]
	private int m_nItemID;

	[Token(Token = "0x4001923")]
	[FieldOffset(Offset = "0x20")]
	private int m_nItemLevel;

	[Token(Token = "0x4001924")]
	[FieldOffset(Offset = "0x24")]
	private int m_nCharID;

	[Token(Token = "0x4001925")]
	[FieldOffset(Offset = "0x28")]
	private int m_nCharLevel;

	[Token(Token = "0x170006AF")]
	public string UID
	{
		[Token(Token = "0x6002ADB")]
		[Address(RVA = "0x1CA4B54", Offset = "0x1CA4B54", VA = "0x1CA4B54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B0")]
	public XRewardCategory Category
	{
		[Token(Token = "0x6002ADC")]
		[Address(RVA = "0x1CA4B5C", Offset = "0x1CA4B5C", VA = "0x1CA4B5C")]
		get
		{
			return default(XRewardCategory);
		}
	}

	[Token(Token = "0x170006B1")]
	public CSContentType Type
	{
		[Token(Token = "0x6002ADD")]
		[Address(RVA = "0x1CA4B64", Offset = "0x1CA4B64", VA = "0x1CA4B64")]
		get
		{
			return default(CSContentType);
		}
	}

	[Token(Token = "0x170006B2")]
	public int Gold
	{
		[Token(Token = "0x6002ADE")]
		[Address(RVA = "0x1CA4B6C", Offset = "0x1CA4B6C", VA = "0x1CA4B6C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006B3")]
	public int ItemID
	{
		[Token(Token = "0x6002ADF")]
		[Address(RVA = "0x1CA4B74", Offset = "0x1CA4B74", VA = "0x1CA4B74")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006B4")]
	public int ItemLevel
	{
		[Token(Token = "0x6002AE0")]
		[Address(RVA = "0x1CA4B7C", Offset = "0x1CA4B7C", VA = "0x1CA4B7C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006B5")]
	public int CharID
	{
		[Token(Token = "0x6002AE1")]
		[Address(RVA = "0x1CA4B84", Offset = "0x1CA4B84", VA = "0x1CA4B84")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006B6")]
	public int CharLevel
	{
		[Token(Token = "0x6002AE2")]
		[Address(RVA = "0x1CA4B8C", Offset = "0x1CA4B8C", VA = "0x1CA4B8C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006B7")]
	public bool Received
	{
		[Token(Token = "0x6002AE3")]
		[Address(RVA = "0x1CA4B94", Offset = "0x1CA4B94", VA = "0x1CA4B94")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002AD2")]
	[Address(RVA = "0x1CA47B4", Offset = "0x1CA47B4", VA = "0x1CA47B4")]
	public XReward()
	{
	}

	[Token(Token = "0x6002AD3")]
	[Address(RVA = "0x1CA4884", Offset = "0x1CA4884", VA = "0x1CA4884")]
	public void Clear()
	{
	}

	[Token(Token = "0x6002AD4")]
	[Address(RVA = "0x1CA4960", Offset = "0x1CA4960", VA = "0x1CA4960")]
	public void SetType(CSContentType nType)
	{
	}

	[Token(Token = "0x6002AD5")]
	[Address(RVA = "0x1CA4968", Offset = "0x1CA4968", VA = "0x1CA4968")]
	public void SetCategory(XRewardCategory nCategory)
	{
	}

	[Token(Token = "0x6002AD6")]
	[Address(RVA = "0x1CA4970", Offset = "0x1CA4970", VA = "0x1CA4970")]
	public void SetUID(string uid)
	{
	}

	[Token(Token = "0x6002AD7")]
	[Address(RVA = "0x1CA4978", Offset = "0x1CA4978", VA = "0x1CA4978")]
	public void SetGold(int nGold)
	{
	}

	[Token(Token = "0x6002AD8")]
	[Address(RVA = "0x1CA4988", Offset = "0x1CA4988", VA = "0x1CA4988")]
	public void SetItem(int nItemID, int nItemLevel)
	{
	}

	[Token(Token = "0x6002AD9")]
	[Address(RVA = "0x1CA499C", Offset = "0x1CA499C", VA = "0x1CA499C")]
	public void SetChar(int nCharID, int nCharLevel)
	{
	}

	[Token(Token = "0x6002ADA")]
	[Address(RVA = "0x1CA49B0", Offset = "0x1CA49B0", VA = "0x1CA49B0")]
	public void SetReceived()
	{
	}
}
