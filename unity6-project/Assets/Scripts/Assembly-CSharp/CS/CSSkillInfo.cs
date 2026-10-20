using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B58")]
	public sealed class CSSkillInfo : CharStatus
	{
		[Token(Token = "0x40038BB")]
		[FieldOffset(Offset = "0xB0")]
		public int nID;

		[Token(Token = "0x40038BC")]
		[FieldOffset(Offset = "0xB4")]
		public string szName;

		[Token(Token = "0x40038BD")]
		[FieldOffset(Offset = "0xB8")]
		public string m_szDesc;

		[Token(Token = "0x40038BE")]
		[FieldOffset(Offset = "0xBC")]
		public string m_szSubDesc;

		[Token(Token = "0x40038BF")]
		[FieldOffset(Offset = "0xC0")]
		public string m_szSpecDesc;

		[Token(Token = "0x40038C0")]
		[FieldOffset(Offset = "0xC4")]
		public SkillTypes SkillType;

		[Token(Token = "0x40038C1")]
		[FieldOffset(Offset = "0xC8")]
		public SkillPassiveTiming PassiveTiming;

		[Token(Token = "0x40038C2")]
		[FieldOffset(Offset = "0xCC")]
		public float procRatio;

		[Token(Token = "0x40038C3")]
		[FieldOffset(Offset = "0xD0")]
		public SkillDamageTypes DamageType;

		[Token(Token = "0x40038C4")]
		[FieldOffset(Offset = "0xD4")]
		public float damageRatio;

		[Token(Token = "0x40038C5")]
		[FieldOffset(Offset = "0xD8")]
		public float healRatio;

		[Token(Token = "0x40038C6")]
		[FieldOffset(Offset = "0xDC")]
		public float healRatioPerMaxHp;

		[Token(Token = "0x40038C7")]
		[FieldOffset(Offset = "0xE0")]
		public float accFactor;

		[Token(Token = "0x40038C8")]
		[FieldOffset(Offset = "0xE4")]
		public string strIcon;

		[Token(Token = "0x40038C9")]
		[FieldOffset(Offset = "0xE8")]
		public string strHideCooltime;

		[Token(Token = "0x40038CA")]
		[FieldOffset(Offset = "0xEC")]
		public bool HideCooltime;

		[Token(Token = "0x40038CB")]
		[FieldOffset(Offset = "0xF0")]
		public float m_fAIRestTime;

		[Token(Token = "0x40038CC")]
		[FieldOffset(Offset = "0xF4")]
		public float ExpiredTime;

		[Token(Token = "0x40038CD")]
		[FieldOffset(Offset = "0xF8")]
		public float CastingTime;

		[Token(Token = "0x40038CE")]
		[FieldOffset(Offset = "0xFC")]
		public float m_hitFollowTime;

		[Token(Token = "0x40038CF")]
		[FieldOffset(Offset = "0x100")]
		public string m_strHitPrefab;

		[Token(Token = "0x40038D0")]
		[FieldOffset(Offset = "0x104")]
		public float m_fPreHitTime;

		[Token(Token = "0x40038D1")]
		[FieldOffset(Offset = "0x108")]
		[XmlIgnore]
		public List<string> hitPrefabs;

		[Token(Token = "0x40038D2")]
		[FieldOffset(Offset = "0x10C")]
		public string m_strHitTime;

		[Token(Token = "0x40038D3")]
		[FieldOffset(Offset = "0x110")]
		public HitTarget SkillHitTarget;

		[Token(Token = "0x40038D4")]
		[FieldOffset(Offset = "0x114")]
		[XmlIgnore]
		public List<XSkillHitTime> m_HitTimes;

		[Token(Token = "0x40038D5")]
		[FieldOffset(Offset = "0x118")]
		[XmlIgnore]
		public float FirstHitStartTime;

		[Token(Token = "0x40038D6")]
		[FieldOffset(Offset = "0x11C")]
		public float m_fAttackHitRadius;

		[Token(Token = "0x40038D7")]
		[FieldOffset(Offset = "0x120")]
		public float m_aiAttackRange;

		[Token(Token = "0x40038D8")]
		[FieldOffset(Offset = "0x124")]
		public float m_projectileShowTime;

		[Token(Token = "0x40038D9")]
		[FieldOffset(Offset = "0x128")]
		public float projectile_range;

		[Token(Token = "0x40038DA")]
		[FieldOffset(Offset = "0x12C")]
		public float m_fProjectileSpeed;

		[Token(Token = "0x40038DB")]
		[FieldOffset(Offset = "0x130")]
		public string m_strProjectilePenetratingWall;

		[Token(Token = "0x40038DC")]
		[FieldOffset(Offset = "0x134")]
		private bool m_ProjectilePenetratingWall;

		[Token(Token = "0x40038DD")]
		[FieldOffset(Offset = "0x138")]
		public string m_strProjectilePenetratingChar;

		[Token(Token = "0x40038DE")]
		[FieldOffset(Offset = "0x13C")]
		private bool m_ProjectilePenetratingChar;

		[Token(Token = "0x40038DF")]
		[FieldOffset(Offset = "0x140")]
		public string m_strMetaProperty;

		[Token(Token = "0x40038E0")]
		[FieldOffset(Offset = "0x144")]
		public string m_strhit_persistence;

		[Token(Token = "0x40038E1")]
		[FieldOffset(Offset = "0x148")]
		public bool hit_persistence;

		[Token(Token = "0x40038E2")]
		[FieldOffset(Offset = "0x14C")]
		public string m_strhit_clear_on_die;

		[Token(Token = "0x40038E3")]
		[FieldOffset(Offset = "0x150")]
		public bool hit_clear_on_die;

		[Token(Token = "0x40038E4")]
		[FieldOffset(Offset = "0x154")]
		public float aiMinAttackRange;

		[Token(Token = "0x40038E5")]
		[FieldOffset(Offset = "0x158")]
		public float aiMaxAttackRange;

		[Token(Token = "0x40038E6")]
		[FieldOffset(Offset = "0x15C")]
		public int aiDuration;

		[Token(Token = "0x40038E7")]
		[FieldOffset(Offset = "0x160")]
		public string m_struse_dummy_loc;

		[Token(Token = "0x40038E8")]
		[FieldOffset(Offset = "0x164")]
		public bool use_dummy_loc;

		[Token(Token = "0x40038E9")]
		[FieldOffset(Offset = "0x168")]
		public string m_strUseAni;

		[Token(Token = "0x40038EA")]
		[FieldOffset(Offset = "0x16C")]
		public float greetingStopTime;

		[Token(Token = "0x40038EB")]
		[FieldOffset(Offset = "0x170")]
		public string m_strCameraAni;

		[Token(Token = "0x40038EC")]
		[FieldOffset(Offset = "0x174")]
		public float m_fCameraAinStartTime;

		[Token(Token = "0x40038ED")]
		[FieldOffset(Offset = "0x178")]
		public EffectTarget CameraAniEffectTarget;

		[Token(Token = "0x40038EE")]
		[FieldOffset(Offset = "0x17C")]
		public float m_cameraAniScale;

		[Token(Token = "0x40038EF")]
		[FieldOffset(Offset = "0x180")]
		public string m_strCameraAni2;

		[Token(Token = "0x40038F0")]
		[FieldOffset(Offset = "0x184")]
		public float m_fCameraAinStartTime2;

		[Token(Token = "0x40038F1")]
		[FieldOffset(Offset = "0x188")]
		public EffectTarget CameraAniEffectTarget2;

		[Token(Token = "0x40038F2")]
		[FieldOffset(Offset = "0x18C")]
		public float m_cameraAniScale2;

		[Token(Token = "0x40038F3")]
		[FieldOffset(Offset = "0x190")]
		public string m_strHitCameraAni;

		[Token(Token = "0x40038F4")]
		[FieldOffset(Offset = "0x194")]
		public float m_hitCameraAniScale;

		[Token(Token = "0x40038F5")]
		[FieldOffset(Offset = "0x198")]
		public float m_fPhysicsPower;

		[Token(Token = "0x40038F6")]
		[FieldOffset(Offset = "0x19C")]
		public int m_nComboLine;

		[Token(Token = "0x40038F7")]
		[FieldOffset(Offset = "0x1A0")]
		public float m_fComboSkillStartTime;

		[Token(Token = "0x40038F8")]
		[FieldOffset(Offset = "0x1A4")]
		public int m_nComboSkillID;

		[Token(Token = "0x40038F9")]
		[FieldOffset(Offset = "0x1A8")]
		public float m_fComboLimitTime;

		[Token(Token = "0x40038FA")]
		[FieldOffset(Offset = "0x1AC")]
		public string m_strUseChainBreak;

		[Token(Token = "0x40038FB")]
		[FieldOffset(Offset = "0x1B0")]
		public bool m_isUseChainBreak;

		[Token(Token = "0x40038FC")]
		[FieldOffset(Offset = "0x1B4")]
		public int m_nBuffID1;

		[Token(Token = "0x40038FD")]
		[FieldOffset(Offset = "0x1B8")]
		public HitTarget m_nSkillBuffTarget1;

		[Token(Token = "0x40038FE")]
		[FieldOffset(Offset = "0x1BC")]
		public SkillBuffTiming m_nSkillBuffTiming1;

		[Token(Token = "0x40038FF")]
		[FieldOffset(Offset = "0x1C0")]
		public int m_nBuffID2;

		[Token(Token = "0x4003900")]
		[FieldOffset(Offset = "0x1C4")]
		public HitTarget m_nSkillBuffTarget2;

		[Token(Token = "0x4003901")]
		[FieldOffset(Offset = "0x1C8")]
		public SkillBuffTiming m_nSkillBuffTiming2;

		[Token(Token = "0x4003902")]
		[FieldOffset(Offset = "0x1CC")]
		public int m_nBuffID3;

		[Token(Token = "0x4003903")]
		[FieldOffset(Offset = "0x1D0")]
		public HitTarget m_nSkillBuffTarget3;

		[Token(Token = "0x4003904")]
		[FieldOffset(Offset = "0x1D4")]
		public SkillBuffTiming m_nSkillBuffTiming3;

		[Token(Token = "0x4003905")]
		[FieldOffset(Offset = "0x1D8")]
		public XSkillBuff[] m_BuffArray;

		[Token(Token = "0x4003906")]
		[FieldOffset(Offset = "0x1DC")]
		public string strUseMovingOnSkill;

		[Token(Token = "0x4003907")]
		[FieldOffset(Offset = "0x1E0")]
		public bool useMovingOnSkill;

		[Token(Token = "0x4003908")]
		[FieldOffset(Offset = "0x1E4")]
		public string strFixedDirectionOnMoving;

		[Token(Token = "0x4003909")]
		[FieldOffset(Offset = "0x1E8")]
		public bool fixedDirectionOnMoving;

		[Token(Token = "0x400390A")]
		[FieldOffset(Offset = "0x1EC")]
		public string useInstantString;

		[Token(Token = "0x400390B")]
		[FieldOffset(Offset = "0x1F0")]
		private bool m_UseInstant;

		[Token(Token = "0x400390C")]
		[FieldOffset(Offset = "0x1F4")]
		public int unlock_level;

		[Token(Token = "0x400390D")]
		[FieldOffset(Offset = "0x1F8")]
		public string useOverlappedString;

		[Token(Token = "0x400390E")]
		[FieldOffset(Offset = "0x1FC")]
		private bool m_UseOverlapped;

		[Token(Token = "0x400390F")]
		[FieldOffset(Offset = "0x200")]
		public string enable_targeting_setup;

		[Token(Token = "0x4003910")]
		[FieldOffset(Offset = "0x204")]
		private bool m_Enable_Targeting_Setup;

		[Token(Token = "0x4003911")]
		[FieldOffset(Offset = "0x208")]
		public string default_targeting;

		[Token(Token = "0x4003912")]
		[FieldOffset(Offset = "0x20C")]
		private bool m_DefaultTargeting;

		[Token(Token = "0x4003913")]
		[FieldOffset(Offset = "0x210")]
		public string autoTargeting;

		[Token(Token = "0x4003914")]
		[FieldOffset(Offset = "0x214")]
		private bool m_AutoTargeting;

		[Token(Token = "0x4003915")]
		[FieldOffset(Offset = "0x218")]
		public float m_fAutoTargetingRange;

		[Token(Token = "0x4003916")]
		[FieldOffset(Offset = "0x21C")]
		public string strChatBubbleMsg;

		[Token(Token = "0x4003917")]
		[FieldOffset(Offset = "0x220")]
		public int LevelupCostGrowth;

		[Token(Token = "0x4003918")]
		[FieldOffset(Offset = "0x224")]
		public float beatenDuration;

		[Token(Token = "0x4003919")]
		[FieldOffset(Offset = "0x228")]
		public float beatenDistance;

		[Token(Token = "0x400391A")]
		[FieldOffset(Offset = "0x22C")]
		public MotionControlSource beatenSource;

		[Token(Token = "0x400391B")]
		[FieldOffset(Offset = "0x230")]
		public MotionControlDirection beatenDirection;

		[Token(Token = "0x400391C")]
		[FieldOffset(Offset = "0x234")]
		public string strOnAutoTargetPosition;

		[Token(Token = "0x400391D")]
		[FieldOffset(Offset = "0x238")]
		public bool onAutoTargetPosition;

		[Token(Token = "0x400391E")]
		[FieldOffset(Offset = "0x23C")]
		public float defaultAutoTargetPosition;

		[Token(Token = "0x400391F")]
		[FieldOffset(Offset = "0x240")]
		public float ultimateCharge;

		[Token(Token = "0x4003920")]
		[FieldOffset(Offset = "0x244")]
		public float ignoreCollisionStartTime;

		[Token(Token = "0x4003921")]
		[FieldOffset(Offset = "0x248")]
		public float ignoreCollisionEndTime;

		[Token(Token = "0x4003922")]
		[FieldOffset(Offset = "0x24C")]
		public string strPushOtherOnCollision;

		[Token(Token = "0x4003923")]
		[FieldOffset(Offset = "0x250")]
		public bool pushOtherOnCollision;

		[Token(Token = "0x4003924")]
		[FieldOffset(Offset = "0x254")]
		public float AimTime;

		[Token(Token = "0x4003925")]
		[FieldOffset(Offset = "0x258")]
		public string strDispelInvisibleOnHit;

		[Token(Token = "0x4003926")]
		[FieldOffset(Offset = "0x25C")]
		public bool dispelInvisibleOnHit;

		[Token(Token = "0x4003927")]
		[FieldOffset(Offset = "0x260")]
		public float movementAdjustRatio;

		[Token(Token = "0x4003928")]
		[FieldOffset(Offset = "0x264")]
		public float aniSpeedScale;

		[Token(Token = "0x4003929")]
		[FieldOffset(Offset = "0x268")]
		public float aniPositionScale;

		[Token(Token = "0x400392A")]
		[FieldOffset(Offset = "0x26C")]
		public float AdditionalThreatRatio;

		[Token(Token = "0x400392B")]
		[FieldOffset(Offset = "0x270")]
		public float CancelableTimeByDefaultSkill;

		[Token(Token = "0x400392C")]
		[FieldOffset(Offset = "0x274")]
		public float SkillCancelableTimeBySkill;

		[Token(Token = "0x400392D")]
		[FieldOffset(Offset = "0x278")]
		public float CancelableTimeByDodge;

		[Token(Token = "0x400392E")]
		[FieldOffset(Offset = "0x27C")]
		public string BuffInclude;

		[Token(Token = "0x400392F")]
		[FieldOffset(Offset = "0x280")]
		[XmlIgnore]
		public List<int> BuffIncludeList;

		[Token(Token = "0x4003930")]
		[FieldOffset(Offset = "0x284")]
		public string BuffExclude;

		[Token(Token = "0x4003931")]
		[FieldOffset(Offset = "0x288")]
		[XmlIgnore]
		public List<int> BuffExcludeList;

		[Token(Token = "0x4003932")]
		[FieldOffset(Offset = "0x28C")]
		[XmlIgnore]
		public int referenceSkillID;

		[Token(Token = "0x4003933")]
		[FieldOffset(Offset = "0x290")]
		private bool m_hasProjectile;

		[Token(Token = "0x4003934")]
		[FieldOffset(Offset = "0x294")]
		public SkillEffectInfos EffectInfos;

		[Token(Token = "0x4003935")]
		[FieldOffset(Offset = "0x298")]
		public SkillSoundInfos SoundInfos;

		[Token(Token = "0x4003936")]
		[FieldOffset(Offset = "0x29C")]
		private KeyValuePair<MetaPropertyCondition, int> metaProperty__BackingField;

		[Token(Token = "0x17000C22")]
		[XmlIgnore]
		public KeyValuePair<MetaPropertyCondition, int> metaProperty
		{
			[Token(Token = "0x60052B6")]
			[Address(RVA = "0x1CC39D4", Offset = "0x1CC39D4", VA = "0x1CC39D4")]
			get
			{
				return default(KeyValuePair<MetaPropertyCondition, int>);
			}
			[Token(Token = "0x60052B7")]
			[Address(RVA = "0x1CD3020", Offset = "0x1CD3020", VA = "0x1CD3020")]
			private set
			{
			}
		}

		[Token(Token = "0x17000C23")]
		public bool HasProjectile
		{
			[Token(Token = "0x60052BF")]
			[Address(RVA = "0x1CD3084", Offset = "0x1CD3084", VA = "0x1CD3084")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60052B2")]
		[Address(RVA = "0x1CD2BE0", Offset = "0x1CD2BE0", VA = "0x1CD2BE0")]
		public CSSkillInfo()
		{
		}

		[Token(Token = "0x60052B3")]
		[Address(RVA = "0x1CD3008", Offset = "0x1CD3008", VA = "0x1CD3008", Slot = "6")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x60052B4")]
		[Address(RVA = "0x1CD3010", Offset = "0x1CD3010", VA = "0x1CD3010")]
		public bool ProjectilePenetratingWall()
		{
			return default(bool);
		}

		[Token(Token = "0x60052B5")]
		[Address(RVA = "0x1CD3018", Offset = "0x1CD3018", VA = "0x1CD3018")]
		public bool ProjectilePenetratingChar()
		{
			return default(bool);
		}

		[Token(Token = "0x60052B8")]
		[Address(RVA = "0x1CD302C", Offset = "0x1CD302C", VA = "0x1CD302C")]
		public bool IsUseInstant()
		{
			return default(bool);
		}

		[Token(Token = "0x60052B9")]
		[Address(RVA = "0x1CD3034", Offset = "0x1CD3034", VA = "0x1CD3034")]
		public bool IsUseOverlapped()
		{
			return default(bool);
		}

		[Token(Token = "0x60052BA")]
		[Address(RVA = "0x1CD303C", Offset = "0x1CD303C", VA = "0x1CD303C")]
		public bool EnableTargetingSetup()
		{
			return default(bool);
		}

		[Token(Token = "0x60052BB")]
		[Address(RVA = "0x1CD3044", Offset = "0x1CD3044", VA = "0x1CD3044")]
		public bool DefaultTargeting()
		{
			return default(bool);
		}

		[Token(Token = "0x60052BC")]
		[Address(RVA = "0x1CD304C", Offset = "0x1CD304C", VA = "0x1CD304C")]
		public bool AutoTargeting()
		{
			return default(bool);
		}

		[Token(Token = "0x60052BD")]
		[Address(RVA = "0x1CD3054", Offset = "0x1CD3054", VA = "0x1CD3054")]
		public bool IsTargetingSkill()
		{
			return default(bool);
		}

		[Token(Token = "0x60052BE")]
		[Address(RVA = "0x1CD305C", Offset = "0x1CD305C", VA = "0x1CD305C")]
		public bool HasOwnerAttribute()
		{
			return default(bool);
		}

		[Token(Token = "0x60052C0")]
		[Address(RVA = "0x1CD308C", Offset = "0x1CD308C", VA = "0x1CD308C")]
		public bool HasMetaPropertyCondition(MetaPropertyCondition condition)
		{
			return default(bool);
		}

		[Token(Token = "0x60052C1")]
		[Address(RVA = "0x1CC39E8", Offset = "0x1CC39E8", VA = "0x1CC39E8")]
		public int GetMetaPropertySkillID()
		{
			return default(int);
		}

		[Token(Token = "0x60052C2")]
		[Address(RVA = "0x1CD3138", Offset = "0x1CD3138", VA = "0x1CD3138")]
		public bool IsTrap()
		{
			return default(bool);
		}

		[Token(Token = "0x60052C3")]
		[Address(RVA = "0x1CC2B28", Offset = "0x1CC2B28", VA = "0x1CC2B28")]
		public bool Cooking()
		{
			return default(bool);
		}

		[Token(Token = "0x60052C4")]
		[Address(RVA = "0x1CD3A1C", Offset = "0x1CD3A1C", VA = "0x1CD3A1C")]
		private void CookingHasProjectile()
		{
		}

		[Token(Token = "0x60052C5")]
		[Address(RVA = "0x1CD3CDC", Offset = "0x1CD3CDC", VA = "0x1CD3CDC")]
		private void CookingBuffIncludeList()
		{
		}

		[Token(Token = "0x60052C6")]
		[Address(RVA = "0x1CD3EDC", Offset = "0x1CD3EDC", VA = "0x1CD3EDC")]
		private void CookingBuffExcludeList()
		{
		}

		[Token(Token = "0x60052C7")]
		[Address(RVA = "0x1CD37B8", Offset = "0x1CD37B8", VA = "0x1CD37B8")]
		private bool CookingHitPrefab()
		{
			return default(bool);
		}

		[Token(Token = "0x60052C8")]
		[Address(RVA = "0x1CD3168", Offset = "0x1CD3168", VA = "0x1CD3168")]
		private bool Cooking_MetaProperty()
		{
			return default(bool);
		}

		[Token(Token = "0x60052C9")]
		[Address(RVA = "0x1CD40DC", Offset = "0x1CD40DC", VA = "0x1CD40DC")]
		internal bool HasDamage()
		{
			return default(bool);
		}

		[Token(Token = "0x60052CA")]
		[Address(RVA = "0x1CD4130", Offset = "0x1CD4130", VA = "0x1CD4130")]
		public bool HasAnimation_Use()
		{
			return default(bool);
		}
	}
}
