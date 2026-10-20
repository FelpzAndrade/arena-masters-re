using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000493")]
public class XModuleTargetIndicator : XModuleBase
{
	[Token(Token = "0x4001702")]
	[FieldOffset(Offset = "0x10")]
	private GameObject m_goMyTeamIndicator;

	[Token(Token = "0x4001703")]
	[FieldOffset(Offset = "0x14")]
	private XModuleEntity m_goLeader;

	[Token(Token = "0x600275C")]
	[Address(RVA = "0xB99548", Offset = "0xB99548", VA = "0xB99548")]
	public XModuleTargetIndicator()
	{
	}

	[Token(Token = "0x600275D")]
	[Address(RVA = "0xB99558", Offset = "0xB99558", VA = "0xB99558")]
	private void Start()
	{
	}

	[Token(Token = "0x600275E")]
	[Address(RVA = "0xB9955C", Offset = "0xB9955C", VA = "0xB9955C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600275F")]
	[Address(RVA = "0xB99698", Offset = "0xB99698", VA = "0xB99698")]
	private void Update()
	{
	}

	[Token(Token = "0x6002760")]
	[Address(RVA = "0xB9969C", Offset = "0xB9969C", VA = "0xB9969C")]
	private void UpdateEnemyIndicator()
	{
	}

	[Token(Token = "0x6002761")]
	[Address(RVA = "0xB99968", Offset = "0xB99968", VA = "0xB99968")]
	private bool CheckMyTeam()
	{
		return default(bool);
	}

	[Token(Token = "0x6002762")]
	[Address(RVA = "0xB99560", Offset = "0xB99560", VA = "0xB99560")]
	public void Final()
	{
	}
}
