using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000D20")]
public class XPanel_Zombie : XPanel_GameBase
{
	[Token(Token = "0x4004335")]
	[FieldOffset(Offset = "0x14")]
	public XWidget_RankedIcons rankedIcons;

	[Token(Token = "0x4004336")]
	[FieldOffset(Offset = "0x18")]
	private XUIHUDText m_hudPoint;

	[Token(Token = "0x17000D14")]
	private XUIHUDText hudPoint
	{
		[Token(Token = "0x600602F")]
		[Address(RVA = "0xADA8D8", Offset = "0xADA8D8", VA = "0xADA8D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600602E")]
	[Address(RVA = "0xADA8D0", Offset = "0xADA8D0", VA = "0xADA8D0")]
	public XPanel_Zombie()
	{
	}

	[Token(Token = "0x6006030")]
	[Address(RVA = "0xADAB50", Offset = "0xADAB50", VA = "0xADAB50")]
	private void Update()
	{
	}

	[Token(Token = "0x6006031")]
	[Address(RVA = "0xADAB94", Offset = "0xADAB94", VA = "0xADAB94")]
	public void BuildRank(List<XPlayer> players, IRecordUISetter setter)
	{
	}

	[Token(Token = "0x6006032")]
	[Address(RVA = "0xADABC0", Offset = "0xADABC0", VA = "0xADABC0")]
	public void ShowPoint(int point)
	{
	}
}
