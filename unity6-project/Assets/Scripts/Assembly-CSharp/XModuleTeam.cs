using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000494")]
public class XModuleTeam : XModuleBase
{
	[Token(Token = "0x4001704")]
	[FieldOffset(Offset = "0x10")]
	public XTeamEnum m_Team;

	[Token(Token = "0x4001705")]
	[FieldOffset(Offset = "0x14")]
	private HashSet<XModuleEntity> m_teamMembersExcludeMe;

	[Token(Token = "0x17000639")]
	public HashSet<XModuleEntity> TeamList
	{
		[Token(Token = "0x6002766")]
		[Address(RVA = "0xB72324", Offset = "0xB72324", VA = "0xB72324")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002763")]
	[Address(RVA = "0xB99B68", Offset = "0xB99B68", VA = "0xB99B68")]
	public XModuleTeam()
	{
	}

	[Token(Token = "0x6002764")]
	[Address(RVA = "0xB99C20", Offset = "0xB99C20", VA = "0xB99C20")]
	public void UpdateTeamMember()
	{
	}

	[Token(Token = "0x6002765")]
	[Address(RVA = "0xB99CD0", Offset = "0xB99CD0", VA = "0xB99CD0")]
	private void UpdateTeamMember(XInstanceType type)
	{
	}

	[Token(Token = "0x6002767")]
	[Address(RVA = "0xB99EF8", Offset = "0xB99EF8", VA = "0xB99EF8")]
	public void RemoveFromTeam(XModuleEntity me)
	{
	}

	[Token(Token = "0x6002768")]
	[Address(RVA = "0xB71AB4", Offset = "0xB71AB4", VA = "0xB71AB4")]
	public void SOSToTeam(XModuleEntity enemy, float time)
	{
	}

	[Token(Token = "0x6002769")]
	[Address(RVA = "0xB99F98", Offset = "0xB99F98", VA = "0xB99F98", Slot = "16")]
	public override void OnActorRevive()
	{
	}

	[Token(Token = "0x600276A")]
	[Address(RVA = "0xB9A21C", Offset = "0xB9A21C", VA = "0xB9A21C")]
	public void AddTeamMember(XModuleEntity teamMember)
	{
	}

	[Token(Token = "0x600276B")]
	[Address(RVA = "0xB9A314", Offset = "0xB9A314", VA = "0xB9A314")]
	public bool HasTeamMember()
	{
		return default(bool);
	}

	[Token(Token = "0x600276C")]
	[Address(RVA = "0xB9A3BC", Offset = "0xB9A3BC", VA = "0xB9A3BC")]
	public bool HasAliveTeamMember()
	{
		return default(bool);
	}

	[Token(Token = "0x600276D")]
	[Address(RVA = "0xB9A474", Offset = "0xB9A474", VA = "0xB9A474")]
	public XModuleEntity GetAliveTeamMember()
	{
		return null;
	}

	[Token(Token = "0x600276E")]
	[Address(RVA = "0xB9A608", Offset = "0xB9A608", VA = "0xB9A608", Slot = "40")]
	public override void OnGameObjectDestroy()
	{
	}
}
