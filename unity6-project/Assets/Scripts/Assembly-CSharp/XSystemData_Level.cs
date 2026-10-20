using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000681")]
public class XSystemData_Level : MonoBehaviour
{
	[Token(Token = "0x4001F98")]
	[FieldOffset(Offset = "0xC")]
	public float cognitionSight;

	[Token(Token = "0x4001F99")]
	[FieldOffset(Offset = "0x10")]
	public float defaultSightRange;

	[Token(Token = "0x4001F9A")]
	[FieldOffset(Offset = "0x14")]
	public float defaultNPCSightRange;

	[Token(Token = "0x4001F9B")]
	[FieldOffset(Offset = "0x18")]
	public float situationEstimateRange;

	[Token(Token = "0x4001F9C")]
	[FieldOffset(Offset = "0x1C")]
	public float joinTeamSightRange;

	[Token(Token = "0x4001F9D")]
	[FieldOffset(Offset = "0x20")]
	public float targetFollowDistance;

	[Token(Token = "0x4001F9E")]
	[FieldOffset(Offset = "0x24")]
	public float scenarioPanelFadeInDelay;

	[Token(Token = "0x4001F9F")]
	[FieldOffset(Offset = "0x28")]
	public float scenarioPanelFadeInDuration;

	[Token(Token = "0x4001FA0")]
	[FieldOffset(Offset = "0x2C")]
	public float dodgeDecideRange;

	[Token(Token = "0x4001FA1")]
	[FieldOffset(Offset = "0x30")]
	public int dodgeDice;

	[Token(Token = "0x4001FA2")]
	[FieldOffset(Offset = "0x34")]
	public float dodgeReactionEnd;

	[Token(Token = "0x4001FA3")]
	[FieldOffset(Offset = "0x38")]
	public float maximumAggroReduceRateByDistance;

	[Token(Token = "0x4001FA4")]
	[FieldOffset(Offset = "0x3C")]
	public float revengeCheckPeriod;

	[Token(Token = "0x4001FA5")]
	[FieldOffset(Offset = "0x40")]
	public float stuckAggroTime;

	[Token(Token = "0x4001FA6")]
	[FieldOffset(Offset = "0x44")]
	public float pushSpeed;

	[Token(Token = "0x4001FA7")]
	[FieldOffset(Offset = "0x0")]
	private static XSystemData_Level m_instance;

	[Token(Token = "0x17000802")]
	public static XSystemData_Level instance
	{
		[Token(Token = "0x60036FB")]
		[Address(RVA = "0x1834E90", Offset = "0x1834E90", VA = "0x1834E90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60036FA")]
	[Address(RVA = "0x1834E00", Offset = "0x1834E00", VA = "0x1834E00")]
	public XSystemData_Level()
	{
	}

	[Token(Token = "0x60036FC")]
	[Address(RVA = "0x18350AC", Offset = "0x18350AC", VA = "0x18350AC")]
	private void Awake()
	{
	}
}
