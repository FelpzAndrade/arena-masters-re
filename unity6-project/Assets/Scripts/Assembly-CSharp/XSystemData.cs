using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200067F")]
public class XSystemData : MonoBehaviour
{
	[Token(Token = "0x2000680")]
	public enum EffectOffsetDirection
	{
		[Token(Token = "0x4001F95")]
		None = 0,
		[Token(Token = "0x4001F96")]
		ToCamera = 1,
		[Token(Token = "0x4001F97")]
		ToAttacker = 2
	}

	[Token(Token = "0x4001F3F")]
	[FieldOffset(Offset = "0xC")]
	public Ease throwupEase;

	[Token(Token = "0x4001F40")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_CameraDirection;

	[Token(Token = "0x4001F41")]
	[FieldOffset(Offset = "0x1C")]
	public float m_CameraDistance;

	[Token(Token = "0x4001F42")]
	[FieldOffset(Offset = "0x20")]
	public float m_CameraTargetHeight;

	[Token(Token = "0x4001F43")]
	[FieldOffset(Offset = "0x24")]
	public float m_HeroRotationSpeed;

	[Token(Token = "0x4001F44")]
	[FieldOffset(Offset = "0x28")]
	public int m_DefaultHeroCharID;

	[Token(Token = "0x4001F45")]
	[FieldOffset(Offset = "0x2C")]
	public string m_FixedMonster;

	[Token(Token = "0x4001F46")]
	[FieldOffset(Offset = "0x30")]
	public int m_FixedMonsterCount;

	[Token(Token = "0x4001F47")]
	[FieldOffset(Offset = "0x34")]
	public AnimationCurve weightedRandomPositionCurve;

	[Token(Token = "0x4001F48")]
	[FieldOffset(Offset = "0x38")]
	public float focusingDistanceOffset;

	[Token(Token = "0x4001F49")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 focusingPositionOffset;

	[Token(Token = "0x4001F4A")]
	[FieldOffset(Offset = "0x48")]
	public float focusingMoveSpeed_Boss;

	[Token(Token = "0x4001F4B")]
	[FieldOffset(Offset = "0x4C")]
	public iTween.EaseType focusingMoveEaseType_Boss;

	[Token(Token = "0x4001F4C")]
	[FieldOffset(Offset = "0x50")]
	public float focusingRotateSpeed_Boss;

	[Token(Token = "0x4001F4D")]
	[FieldOffset(Offset = "0x54")]
	public iTween.EaseType focusingRotateEaseType_Boss;

	[Token(Token = "0x4001F4E")]
	[FieldOffset(Offset = "0x58")]
	public float focusingMoveSpeed_Player;

	[Token(Token = "0x4001F4F")]
	[FieldOffset(Offset = "0x5C")]
	public iTween.EaseType focusingMoveEaseType_Player;

	[Token(Token = "0x4001F50")]
	[FieldOffset(Offset = "0x60")]
	public float focusingRotateSpeed_Player;

	[Token(Token = "0x4001F51")]
	[FieldOffset(Offset = "0x64")]
	public iTween.EaseType focusingRotateEaseType_Player;

	[Token(Token = "0x4001F52")]
	[FieldOffset(Offset = "0x68")]
	public float claerEffectDistanceOffset;

	[Token(Token = "0x4001F53")]
	[FieldOffset(Offset = "0x6C")]
	public Vector3 clearEffectPositionOffset;

	[Token(Token = "0x4001F54")]
	[FieldOffset(Offset = "0x78")]
	public float claerEffectMoveSpeed_Boss;

	[Token(Token = "0x4001F55")]
	[FieldOffset(Offset = "0x7C")]
	public iTween.EaseType claerMoveEaseType;

	[Token(Token = "0x4001F56")]
	[FieldOffset(Offset = "0x80")]
	public float claerEffectRotateSpeed_Boss;

	[Token(Token = "0x4001F57")]
	[FieldOffset(Offset = "0x84")]
	public iTween.EaseType claerRotateEaseType;

	[Token(Token = "0x4001F58")]
	[FieldOffset(Offset = "0x88")]
	public float clearEffectDurationTime;

	[Token(Token = "0x4001F59")]
	[FieldOffset(Offset = "0x8C")]
	public float claerEffectShakingSpeed;

	[Token(Token = "0x4001F5A")]
	[FieldOffset(Offset = "0x90")]
	public float claerEffectShakingAmount;

	[Token(Token = "0x4001F5B")]
	[FieldOffset(Offset = "0x94")]
	public iTween.EaseType claerShakeEaseType;

	[Token(Token = "0x4001F5C")]
	[FieldOffset(Offset = "0x98")]
	public float showResultRightDistance;

	[Token(Token = "0x4001F5D")]
	[FieldOffset(Offset = "0x9C")]
	public float showResultUpDistance;

	[Token(Token = "0x4001F5E")]
	[FieldOffset(Offset = "0xA0")]
	public float showResultForwardDistance;

	[Token(Token = "0x4001F5F")]
	[FieldOffset(Offset = "0xA4")]
	public float lookatHeightOffset;

	[Token(Token = "0x4001F60")]
	[FieldOffset(Offset = "0xA8")]
	public iTween.EaseType showResultMoveEaseType;

	[Token(Token = "0x4001F61")]
	[FieldOffset(Offset = "0xAC")]
	public float showResultRotateSpeed;

	[Token(Token = "0x4001F62")]
	[FieldOffset(Offset = "0xB0")]
	public iTween.EaseType showResultRotateEaseType;

	[Token(Token = "0x4001F63")]
	[FieldOffset(Offset = "0xB4")]
	public iTween.EaseType cameraExpressionMoveEaseType;

	[Token(Token = "0x4001F64")]
	[FieldOffset(Offset = "0xB8")]
	public float cameraExpressionMoveSpeed;

	[Token(Token = "0x4001F65")]
	[FieldOffset(Offset = "0xBC")]
	public float cameraExpressionMoveDistance;

	[Token(Token = "0x4001F66")]
	[FieldOffset(Offset = "0xC0")]
	public AnimationCurve beatenKnockbackCurve;

	[Token(Token = "0x4001F67")]
	[FieldOffset(Offset = "0xC4")]
	public float beatenAniStartFadeTime;

	[Token(Token = "0x4001F68")]
	[FieldOffset(Offset = "0xC8")]
	public float beatenAniEndFadeTime;

	[Token(Token = "0x4001F69")]
	[FieldOffset(Offset = "0xCC")]
	public float fakeBeatenAniWeight;

	[Token(Token = "0x4001F6A")]
	[FieldOffset(Offset = "0xD0")]
	public float fakeBeatenAniFadeTime;

	[Token(Token = "0x4001F6B")]
	[FieldOffset(Offset = "0xD4")]
	public float fakeBeatenAniDuration;

	[Token(Token = "0x4001F6C")]
	[FieldOffset(Offset = "0xD8")]
	public EffectOffsetDirection effectOffsetDirection;

	[Token(Token = "0x4001F6D")]
	[FieldOffset(Offset = "0xDC")]
	public float WayPointCameraBoundOffset;

	[Token(Token = "0x4001F6E")]
	[FieldOffset(Offset = "0xE0")]
	public float NavigationArrowMoveSpeed;

	[Token(Token = "0x4001F6F")]
	[FieldOffset(Offset = "0xE4")]
	public float NavigationAppearDelay;

	[Token(Token = "0x4001F70")]
	[FieldOffset(Offset = "0xE8")]
	public float SkillReserveDuration;

	[Token(Token = "0x4001F71")]
	[FieldOffset(Offset = "0xEC")]
	public float SkillReserveDurationWhileAuto;

	[Token(Token = "0x4001F72")]
	[FieldOffset(Offset = "0xF0")]
	public float CameraAniFadeLenth;

	[Token(Token = "0x4001F73")]
	[FieldOffset(Offset = "0xF4")]
	public float SkillCameraAniFadeLenth;

	[Token(Token = "0x4001F74")]
	[FieldOffset(Offset = "0xF8")]
	public float HealthBarOffset;

	[Token(Token = "0x4001F75")]
	[FieldOffset(Offset = "0xFC")]
	public float MFPullBounceDistance;

	[Token(Token = "0x4001F76")]
	[FieldOffset(Offset = "0x100")]
	public float MFPullSpeed;

	[Token(Token = "0x4001F77")]
	[FieldOffset(Offset = "0x104")]
	public AnimationCurve MFPullCurve;

	[Token(Token = "0x4001F78")]
	[FieldOffset(Offset = "0x108")]
	public AnimationCurve MFPullBounceCurve;

	[Token(Token = "0x4001F79")]
	[FieldOffset(Offset = "0x10C")]
	public float MFPullTotalDuration;

	[Token(Token = "0x4001F7A")]
	[FieldOffset(Offset = "0x110")]
	public float MFPullBounceHeight;

	[Token(Token = "0x4001F7B")]
	[FieldOffset(Offset = "0x114")]
	public string MFPullCameraAni;

	[Token(Token = "0x4001F7C")]
	[FieldOffset(Offset = "0x118")]
	public float MFPullCameraAniScale;

	[Token(Token = "0x4001F7D")]
	[FieldOffset(Offset = "0x11C")]
	public float ComboSkillFadeLength;

	[Token(Token = "0x4001F7E")]
	[FieldOffset(Offset = "0x120")]
	public float BlackOutDuration;

	[Token(Token = "0x4001F7F")]
	[FieldOffset(Offset = "0x124")]
	public float HitRimLightRetainingTime;

	[Token(Token = "0x4001F80")]
	[FieldOffset(Offset = "0x128")]
	public float HitRimLightDecrementTime;

	[Token(Token = "0x4001F81")]
	[FieldOffset(Offset = "0x12C")]
	public float SkillCameraAniAffectableRadius;

	[Token(Token = "0x4001F82")]
	[FieldOffset(Offset = "0x130")]
	public float SpectatorCameraSpeed;

	[Token(Token = "0x4001F83")]
	[FieldOffset(Offset = "0x134")]
	public float SpectatorCameraZoom;

	[Token(Token = "0x4001F84")]
	[FieldOffset(Offset = "0x138")]
	public float SpectatorCameraSwipeSpeed;

	[Token(Token = "0x4001F85")]
	[FieldOffset(Offset = "0x13C")]
	public float SpectatorBoundaryScale;

	[Token(Token = "0x4001F86")]
	[FieldOffset(Offset = "0x140")]
	public float EmoticonUIOffset_X;

	[Token(Token = "0x4001F87")]
	[FieldOffset(Offset = "0x144")]
	public float EmoticonUIOffset_Y;

	[Token(Token = "0x4001F88")]
	[FieldOffset(Offset = "0x148")]
	public float EmoticonScale;

	[Token(Token = "0x4001F89")]
	[FieldOffset(Offset = "0x14C")]
	public float EmoticonMenuDuration;

	[Token(Token = "0x4001F8A")]
	[FieldOffset(Offset = "0x150")]
	public float ThiefSight;

	[Token(Token = "0x4001F8B")]
	[FieldOffset(Offset = "0x154")]
	public float PoliceSight;

	[Token(Token = "0x4001F8C")]
	[FieldOffset(Offset = "0x158")]
	public float BoxOccupyTime;

	[Token(Token = "0x4001F8D")]
	[FieldOffset(Offset = "0x15C")]
	public float PoliceRespawnTime;

	[Token(Token = "0x4001F8E")]
	[FieldOffset(Offset = "0x160")]
	public float defaultCameraDistance;

	[Token(Token = "0x4001F8F")]
	[FieldOffset(Offset = "0x164")]
	public float policeVsThiefCameraDistance;

	[Token(Token = "0x4001F90")]
	[FieldOffset(Offset = "0x168")]
	public float HideAndSeekCameraDistance;

	[Token(Token = "0x4001F91")]
	[FieldOffset(Offset = "0x16C")]
	public float CinemaCameraOffsetY;

	[Token(Token = "0x4001F92")]
	[FieldOffset(Offset = "0x170")]
	public Vector3 CinemaCameraOffset;

	[Token(Token = "0x4001F93")]
	[FieldOffset(Offset = "0x0")]
	private static XSystemData m_instance;

	[Token(Token = "0x170007F7")]
	public static XSystemData instance
	{
		[Token(Token = "0x60036EB")]
		[Address(RVA = "0x182E39C", Offset = "0x182E39C", VA = "0x182E39C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007F8")]
	public static Vector3 CameraOffset
	{
		[Token(Token = "0x60036ED")]
		[Address(RVA = "0x1834BD4", Offset = "0x1834BD4", VA = "0x1834BD4")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170007F9")]
	public static Vector3 CameraDirection
	{
		[Token(Token = "0x60036EE")]
		[Address(RVA = "0x1834C40", Offset = "0x1834C40", VA = "0x1834C40")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60036EF")]
		[Address(RVA = "0x1834C74", Offset = "0x1834C74", VA = "0x1834C74")]
		set
		{
		}
	}

	[Token(Token = "0x170007FA")]
	public static float CameraDistance
	{
		[Token(Token = "0x60036F0")]
		[Address(RVA = "0x1834CAC", Offset = "0x1834CAC", VA = "0x1834CAC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60036F1")]
		[Address(RVA = "0x1834CD0", Offset = "0x1834CD0", VA = "0x1834CD0")]
		set
		{
		}
	}

	[Token(Token = "0x170007FB")]
	public static float CameraTargetHeight
	{
		[Token(Token = "0x60036F2")]
		[Address(RVA = "0x1834CFC", Offset = "0x1834CFC", VA = "0x1834CFC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60036F3")]
		[Address(RVA = "0x1834D20", Offset = "0x1834D20", VA = "0x1834D20")]
		set
		{
		}
	}

	[Token(Token = "0x170007FC")]
	public static float HeroRotationSpeed
	{
		[Token(Token = "0x60036F4")]
		[Address(RVA = "0x1834D4C", Offset = "0x1834D4C", VA = "0x1834D4C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170007FD")]
	public static int DefaultHeroCharID
	{
		[Token(Token = "0x60036F5")]
		[Address(RVA = "0x1834D70", Offset = "0x1834D70", VA = "0x1834D70")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170007FE")]
	public static string FixedMonster
	{
		[Token(Token = "0x60036F6")]
		[Address(RVA = "0x1834D94", Offset = "0x1834D94", VA = "0x1834D94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007FF")]
	public static int FixedMonsterCount
	{
		[Token(Token = "0x60036F7")]
		[Address(RVA = "0x1834DB8", Offset = "0x1834DB8", VA = "0x1834DB8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000800")]
	public static AnimationCurve WeightedRandomCurve
	{
		[Token(Token = "0x60036F8")]
		[Address(RVA = "0x1834DDC", Offset = "0x1834DDC", VA = "0x1834DDC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000801")]
	public static float GetSpectatorCameraSpeed
	{
		[Token(Token = "0x60036F9")]
		[Address(RVA = "0x182EEB4", Offset = "0x182EEB4", VA = "0x182EEB4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60036EA")]
	[Address(RVA = "0x1834730", Offset = "0x1834730", VA = "0x1834730")]
	public XSystemData()
	{
	}

	[Token(Token = "0x60036EC")]
	[Address(RVA = "0x1834B10", Offset = "0x1834B10", VA = "0x1834B10")]
	private void Awake()
	{
	}
}
