using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20003A3")]
public class XMapBuffManager
{
	[Token(Token = "0x40012E1")]
	[FieldOffset(Offset = "0x8")]
	private List<XMapBuff> m_listBuff;

	[Token(Token = "0x40012E2")]
	[FieldOffset(Offset = "0xC")]
	private XMapBuffModifier m_Mod;

	[Token(Token = "0x17000504")]
	public XMapBuffModifier Mod
	{
		[Token(Token = "0x6001DF6")]
		[Address(RVA = "0x1E2CA94", Offset = "0x1E2CA94", VA = "0x1E2CA94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001DEE")]
	[Address(RVA = "0x1E2C2A4", Offset = "0x1E2C2A4", VA = "0x1E2C2A4")]
	public XMapBuffManager()
	{
	}

	[Token(Token = "0x6001DEF")]
	[Address(RVA = "0x1E2C39C", Offset = "0x1E2C39C", VA = "0x1E2C39C")]
	public void Clear()
	{
	}

	[Token(Token = "0x6001DF0")]
	[Address(RVA = "0x1E2C3D0", Offset = "0x1E2C3D0", VA = "0x1E2C3D0")]
	public void AddBuff(int nID)
	{
	}

	[Token(Token = "0x6001DF1")]
	[Address(RVA = "0x1E2C6DC", Offset = "0x1E2C6DC", VA = "0x1E2C6DC")]
	public void DeleteBuff(int nID)
	{
	}

	[Token(Token = "0x6001DF2")]
	[Address(RVA = "0x1E2C678", Offset = "0x1E2C678", VA = "0x1E2C678")]
	private void GainBuff(XMapBuff buff)
	{
	}

	[Token(Token = "0x6001DF3")]
	[Address(RVA = "0x1E2C82C", Offset = "0x1E2C82C", VA = "0x1E2C82C")]
	private void LostBuff(XMapBuff buff)
	{
	}

	[Token(Token = "0x6001DF4")]
	[Address(RVA = "0x1E2C850", Offset = "0x1E2C850", VA = "0x1E2C850")]
	private void ApplyModifier(XMapBuff buff, bool bGain)
	{
	}

	[Token(Token = "0x6001DF5")]
	[Address(RVA = "0x1E2C92C", Offset = "0x1E2C92C", VA = "0x1E2C92C")]
	private void ApplyModifierFlags(XMapBuff buff, bool bGain)
	{
	}
}
