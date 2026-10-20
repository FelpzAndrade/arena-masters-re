using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AA3")]
	public sealed class CSCharacterInfo : CharStatus
	{
		[Token(Token = "0x4003191")]
		[FieldOffset(Offset = "0xB0")]
		public int nID;

		[Token(Token = "0x4003192")]
		[FieldOffset(Offset = "0xB4")]
		public CharType nCharType;

		[Token(Token = "0x4003193")]
		[FieldOffset(Offset = "0xB8")]
		public string strName;

		[Token(Token = "0x4003194")]
		[FieldOffset(Offset = "0xBC")]
		public string strFightingMsg;

		[Token(Token = "0x4003195")]
		[FieldOffset(Offset = "0xC0")]
		public string strIntro;

		[Token(Token = "0x4003196")]
		[FieldOffset(Offset = "0xC4")]
		public string strTitle;

		[Token(Token = "0x4003197")]
		[FieldOffset(Offset = "0xC8")]
		public int m_nGrade;

		[Token(Token = "0x4003198")]
		[FieldOffset(Offset = "0xCC")]
		public int m_nSpecialGrade;

		[Token(Token = "0x4003199")]
		[FieldOffset(Offset = "0xD0")]
		public string strUseCharacterShader;

		[Token(Token = "0x400319A")]
		[FieldOffset(Offset = "0xD4")]
		private bool m_UseCharacterShader;

		[Token(Token = "0x400319B")]
		[FieldOffset(Offset = "0xD8")]
		public string strMapObjectReCreated;

		[Token(Token = "0x400319C")]
		[FieldOffset(Offset = "0xDC")]
		private bool m_MapObjectReCreated;

		[Token(Token = "0x400319D")]
		[FieldOffset(Offset = "0xE0")]
		public string strModel;

		[Token(Token = "0x400319E")]
		[FieldOffset(Offset = "0xE4")]
		public string strResourcePath;

		[Token(Token = "0x400319F")]
		[FieldOffset(Offset = "0xE8")]
		public string strResourceName;

		[Token(Token = "0x40031A0")]
		[FieldOffset(Offset = "0xEC")]
		public string strAniKey;

		[Token(Token = "0x40031A1")]
		[FieldOffset(Offset = "0xF0")]
		public int nDefaultSkinId;

		[Token(Token = "0x40031A2")]
		[FieldOffset(Offset = "0xF4")]
		public string strTag;

		[Token(Token = "0x40031A3")]
		[FieldOffset(Offset = "0xF8")]
		public string strTagParam;

		[Token(Token = "0x40031A4")]
		[FieldOffset(Offset = "0xFC")]
		public float m_fRotationX;

		[Token(Token = "0x40031A5")]
		[FieldOffset(Offset = "0x100")]
		public float m_fRotationY;

		[Token(Token = "0x40031A6")]
		[FieldOffset(Offset = "0x104")]
		public float m_fRotationZ;

		[Token(Token = "0x40031A7")]
		[FieldOffset(Offset = "0x108")]
		public string strMinimapItemColor;

		[Token(Token = "0x40031A8")]
		[FieldOffset(Offset = "0x10C")]
		public string strIcon;

		[Token(Token = "0x40031A9")]
		[FieldOffset(Offset = "0x110")]
		public string strUltIcon;

		[Token(Token = "0x40031AA")]
		[FieldOffset(Offset = "0x114")]
		public int m_nGetSoulStoneCost;

		[Token(Token = "0x40031AB")]
		[FieldOffset(Offset = "0x118")]
		public int m_nGetCrystalCost;

		[Token(Token = "0x40031AC")]
		[FieldOffset(Offset = "0x11C")]
		public int m_nGetGoldCost;

		[Token(Token = "0x40031AD")]
		[FieldOffset(Offset = "0x120")]
		public float fToughness;

		[Token(Token = "0x40031AE")]
		[FieldOffset(Offset = "0x124")]
		public float fWeight;

		[Token(Token = "0x40031AF")]
		[FieldOffset(Offset = "0x128")]
		public int nDefaultSkillID;

		[Token(Token = "0x40031B0")]
		[FieldOffset(Offset = "0x12C")]
		public CSSkillInfo m_DefaultSkillInfo;

		[Token(Token = "0x40031B1")]
		[FieldOffset(Offset = "0x130")]
		public int nSkill_1;

		[Token(Token = "0x40031B2")]
		[FieldOffset(Offset = "0x134")]
		public int nSkill_2;

		[Token(Token = "0x40031B3")]
		[FieldOffset(Offset = "0x138")]
		public int nSkill_3;

		[Token(Token = "0x40031B4")]
		[FieldOffset(Offset = "0x13C")]
		public int nDodgeSkill;

		[Token(Token = "0x40031B5")]
		[FieldOffset(Offset = "0x140")]
		public int nUltimateSkill;

		[Token(Token = "0x40031B6")]
		[FieldOffset(Offset = "0x144")]
		public int nPassiveSkill_1;

		[Token(Token = "0x40031B7")]
		[FieldOffset(Offset = "0x148")]
		public int nPassiveSkill_2;

		[Token(Token = "0x40031B8")]
		[FieldOffset(Offset = "0x14C")]
		public string strPushing;

		[Token(Token = "0x40031B9")]
		[FieldOffset(Offset = "0x150")]
		private bool m_pushing;

		[Token(Token = "0x40031BA")]
		[FieldOffset(Offset = "0x154")]
		public int nBuffPvpTexp;

		[Token(Token = "0x40031BB")]
		[FieldOffset(Offset = "0x158")]
		public float fBuffPvpGold;

		[Token(Token = "0x40031BC")]
		[FieldOffset(Offset = "0x15C")]
		public float fBuffPvpMedalWoh;

		[Token(Token = "0x40031BD")]
		[FieldOffset(Offset = "0x160")]
		public CSSkillInfo[] m_SkillInfo;

		[Token(Token = "0x40031BE")]
		[FieldOffset(Offset = "0x164")]
		public CSSkillInfo m_UltimateSkillInfo;

		[Token(Token = "0x40031BF")]
		[FieldOffset(Offset = "0x168")]
		public CSSkillInfo m_TagSkillInfo;

		[Token(Token = "0x40031C0")]
		[FieldOffset(Offset = "0x16C")]
		public CSSkillInfo[] m_PassiveSkillInfo;

		[Token(Token = "0x40031C1")]
		[FieldOffset(Offset = "0x170")]
		[XmlIgnore]
		public List<CSCharacterSkillInfo> UsableSkillInfos;

		[Token(Token = "0x40031C2")]
		[FieldOffset(Offset = "0x174")]
		[XmlIgnore]
		public List<CSCharacterSkillInfo> CombatSkillInfos;

		[Token(Token = "0x40031C3")]
		[FieldOffset(Offset = "0x178")]
		[XmlIgnore]
		public List<CSCharacterSkillInfo> PassiveSkillInfos;

		[Token(Token = "0x40031C4")]
		[FieldOffset(Offset = "0x17C")]
		[XmlIgnore]
		public List<CSCharacterSkillInfo> UpgradableSkillInfos;

		[Token(Token = "0x40031C5")]
		[FieldOffset(Offset = "0x180")]
		[XmlIgnore]
		public HashSet<int> ComboSkill;

		[Token(Token = "0x40031C6")]
		[FieldOffset(Offset = "0x184")]
		public int bossGreetingSkill;

		[Token(Token = "0x40031C7")]
		[FieldOffset(Offset = "0x188")]
		public string bossGreetingIdle;

		[Token(Token = "0x40031C8")]
		[FieldOffset(Offset = "0x18C")]
		public int nPassiveBuffID;

		[Token(Token = "0x40031C9")]
		[FieldOffset(Offset = "0x190")]
		public CSBuffInfo m_PassiveBuffInfo;

		[Token(Token = "0x40031CA")]
		[FieldOffset(Offset = "0x194")]
		public float minAttackRange;

		[Token(Token = "0x40031CB")]
		[FieldOffset(Offset = "0x198")]
		public float maxAttackRange;

		[Token(Token = "0x40031CC")]
		[FieldOffset(Offset = "0x19C")]
		public string strIdleAni;

		[Token(Token = "0x40031CD")]
		[FieldOffset(Offset = "0x1A0")]
		public string strRunAni;

		[Token(Token = "0x40031CE")]
		[FieldOffset(Offset = "0x1A4")]
		public string strDieAni;

		[Token(Token = "0x40031CF")]
		[FieldOffset(Offset = "0x1A8")]
		public string strDieCameraAni;

		[Token(Token = "0x40031D0")]
		[FieldOffset(Offset = "0x1AC")]
		public string strDieEffect;

		[Token(Token = "0x40031D1")]
		[FieldOffset(Offset = "0x1B0")]
		public float fMoveSpeed;

		[Token(Token = "0x40031D2")]
		[FieldOffset(Offset = "0x1B4")]
		public float fRunSpeed;

		[Token(Token = "0x40031D3")]
		[FieldOffset(Offset = "0x1B8")]
		public string strMapObjAIFlag;

		[Token(Token = "0x40031D4")]
		[FieldOffset(Offset = "0x1BC")]
		public bool MapObjAIFlag;

		[Token(Token = "0x40031D5")]
		[FieldOffset(Offset = "0x1C0")]
		public string strAIMovingFlag;

		[Token(Token = "0x40031D6")]
		[FieldOffset(Offset = "0x1C4")]
		private bool m_AIMovingFlag;

		[Token(Token = "0x40031D7")]
		[FieldOffset(Offset = "0x1C8")]
		public string strAIMoveToEntity;

		[Token(Token = "0x40031D8")]
		[FieldOffset(Offset = "0x1CC")]
		public bool AIMoveToEntity;

		[Token(Token = "0x40031D9")]
		[FieldOffset(Offset = "0x1D0")]
		public string strAutoTarget;

		[Token(Token = "0x40031DA")]
		[FieldOffset(Offset = "0x1D4")]
		private bool m_AutoTarget;

		[Token(Token = "0x40031DB")]
		[FieldOffset(Offset = "0x1D8")]
		public float m_fDieKnockbackTime;

		[Token(Token = "0x40031DC")]
		[FieldOffset(Offset = "0x1DC")]
		public HitTriggerType nHitTriggerType;

		[Token(Token = "0x40031DD")]
		[FieldOffset(Offset = "0x1E0")]
		public string strHitFragmentEffect;

		[Token(Token = "0x40031DE")]
		[FieldOffset(Offset = "0x1E4")]
		[XmlIgnore]
		public List<string> HitFragmentEffects;

		[Token(Token = "0x40031DF")]
		[FieldOffset(Offset = "0x1E8")]
		public string m_strDropObjectPickSound;

		[Token(Token = "0x40031E0")]
		[FieldOffset(Offset = "0x1EC")]
		public string m_strDropObjectPickEffect;

		[Token(Token = "0x40031E1")]
		[FieldOffset(Offset = "0x1F0")]
		public int m_nDropObjectBuff;

		[Token(Token = "0x40031E2")]
		[FieldOffset(Offset = "0x1F4")]
		public BuffTargetType m_eDropObjectBuffTarget;

		[Token(Token = "0x40031E3")]
		[FieldOffset(Offset = "0x1F8")]
		public float fDropObjectLootingTime;

		[Token(Token = "0x40031E4")]
		[FieldOffset(Offset = "0x1FC")]
		public string strChangeTagger;

		[Token(Token = "0x40031E5")]
		[FieldOffset(Offset = "0x200")]
		private bool m_ChangeTagger;

		[Token(Token = "0x40031E6")]
		[FieldOffset(Offset = "0x204")]
		public int nFinishAttackBonusMin;

		[Token(Token = "0x40031E7")]
		[FieldOffset(Offset = "0x208")]
		public int nFinishAttackBonusMax;

		[Token(Token = "0x40031E8")]
		[FieldOffset(Offset = "0x20C")]
		public string strShopGachaFlag;

		[Token(Token = "0x40031E9")]
		[FieldOffset(Offset = "0x210")]
		private bool m_ShopGacha;

		[Token(Token = "0x40031EA")]
		[FieldOffset(Offset = "0x214")]
		public string m_strPlayableCharacter;

		[Token(Token = "0x40031EB")]
		[FieldOffset(Offset = "0x218")]
		private bool m_PlayableCharacter;

		[Token(Token = "0x40031EC")]
		[FieldOffset(Offset = "0x21C")]
		public string m_strCharacterOpenTime;

		[Token(Token = "0x40031ED")]
		[FieldOffset(Offset = "0x220")]
		public DateTime CharacterOpenTime;

		[Token(Token = "0x40031EE")]
		[FieldOffset(Offset = "0x230")]
		public string m_strCharacterCloseTime;

		[Token(Token = "0x40031EF")]
		[FieldOffset(Offset = "0x238")]
		public DateTime CharacterCloseTime;

		[Token(Token = "0x40031F0")]
		[FieldOffset(Offset = "0x248")]
		public float nPhysicalPowerApplyRate;

		[Token(Token = "0x40031F1")]
		[FieldOffset(Offset = "0x24C")]
		public float nMagicalPowerApplyRate;

		[Token(Token = "0x40031F2")]
		[FieldOffset(Offset = "0x250")]
		public string m_strMapObjectHit;

		[Token(Token = "0x40031F3")]
		[FieldOffset(Offset = "0x254")]
		public bool m_MapObjectHit;

		[Token(Token = "0x40031F4")]
		[FieldOffset(Offset = "0x258")]
		public string m_strMapObjectCollision;

		[Token(Token = "0x40031F5")]
		[FieldOffset(Offset = "0x25C")]
		public bool m_MapObjectCollision;

		[Token(Token = "0x40031F6")]
		[FieldOffset(Offset = "0x260")]
		public string m_strShowHP;

		[Token(Token = "0x40031F7")]
		[FieldOffset(Offset = "0x264")]
		public bool m_ShowHP;

		[Token(Token = "0x40031F8")]
		[FieldOffset(Offset = "0x268")]
		public int m_MapObjectHitCount;

		[Token(Token = "0x40031F9")]
		[FieldOffset(Offset = "0x26C")]
		public float modelScale;

		[Token(Token = "0x40031FA")]
		[FieldOffset(Offset = "0x270")]
		public float shadowScaleX;

		[Token(Token = "0x40031FB")]
		[FieldOffset(Offset = "0x274")]
		public float shadowScaleZ;

		[Token(Token = "0x40031FC")]
		[FieldOffset(Offset = "0x278")]
		public float lobbyScale;

		[Token(Token = "0x40031FD")]
		[FieldOffset(Offset = "0x27C")]
		public float buffEffectScale;

		[Token(Token = "0x40031FE")]
		[FieldOffset(Offset = "0x280")]
		public int m_nGetDustCost;

		[Token(Token = "0x17000B13")]
		public bool UseCharacterShader
		{
			[Token(Token = "0x6004E59")]
			[Address(RVA = "0x2226D7C", Offset = "0x2226D7C", VA = "0x2226D7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B14")]
		public bool MapObjectReCreated
		{
			[Token(Token = "0x6004E5A")]
			[Address(RVA = "0x2226D84", Offset = "0x2226D84", VA = "0x2226D84")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B15")]
		public CSSkillInfo DefaultSkillInfo
		{
			[Token(Token = "0x6004E5F")]
			[Address(RVA = "0x2226FA4", Offset = "0x2226FA4", VA = "0x2226FA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B16")]
		[XmlIgnore]
		public int DodgeSkillId
		{
			[Token(Token = "0x6004E60")]
			[Address(RVA = "0x2226FAC", Offset = "0x2226FAC", VA = "0x2226FAC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000B17")]
		public bool Pushing
		{
			[Token(Token = "0x6004E61")]
			[Address(RVA = "0x2226FB4", Offset = "0x2226FB4", VA = "0x2226FB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B18")]
		public bool AIMovingFlag
		{
			[Token(Token = "0x6004E66")]
			[Address(RVA = "0x22272E0", Offset = "0x22272E0", VA = "0x22272E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B19")]
		public bool AutoTarget
		{
			[Token(Token = "0x6004E67")]
			[Address(RVA = "0x22272E8", Offset = "0x22272E8", VA = "0x22272E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B1A")]
		public bool PlayableCharacter
		{
			[Token(Token = "0x6004E68")]
			[Address(RVA = "0x22272F0", Offset = "0x22272F0", VA = "0x22272F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B1B")]
		public bool ShopGacha
		{
			[Token(Token = "0x6004E69")]
			[Address(RVA = "0x22272F8", Offset = "0x22272F8", VA = "0x22272F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B1C")]
		public bool ChangeTagger
		{
			[Token(Token = "0x6004E6A")]
			[Address(RVA = "0x2227300", Offset = "0x2227300", VA = "0x2227300")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B1D")]
		public bool HasShadow
		{
			[Token(Token = "0x6004E6B")]
			[Address(RVA = "0x2227308", Offset = "0x2227308", VA = "0x2227308")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B1E")]
		public bool HasDieEffect
		{
			[Token(Token = "0x6004E6C")]
			[Address(RVA = "0x222733C", Offset = "0x222733C", VA = "0x222733C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B1F")]
		public int SkillCount
		{
			[Token(Token = "0x6004E70")]
			[Address(RVA = "0x2228130", Offset = "0x2228130", VA = "0x2228130")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6004E58")]
		[Address(RVA = "0x222688C", Offset = "0x222688C", VA = "0x222688C")]
		public CSCharacterInfo()
		{
		}

		[Token(Token = "0x6004E5B")]
		[Address(RVA = "0x2226D8C", Offset = "0x2226D8C", VA = "0x2226D8C")]
		public string GetAniKey()
		{
			return null;
		}

		[Token(Token = "0x6004E5C")]
		[Address(RVA = "0x2226DB8", Offset = "0x2226DB8", VA = "0x2226DB8")]
		public string GetResourceFullPathName()
		{
			return null;
		}

		[Token(Token = "0x6004E5D")]
		[Address(RVA = "0x2226E8C", Offset = "0x2226E8C", VA = "0x2226E8C")]
		public int GetTagParamInt()
		{
			return default(int);
		}

		[Token(Token = "0x6004E5E")]
		[Address(RVA = "0x2226F68", Offset = "0x2226F68", VA = "0x2226F68")]
		public bool IsRotation()
		{
			return default(bool);
		}

		[Token(Token = "0x6004E62")]
		[Address(RVA = "0x2226FBC", Offset = "0x2226FBC", VA = "0x2226FBC")]
		public CSCharacterSkillInfo.SkillType GetSkillType(int skillID)
		{
			return default(CSCharacterSkillInfo.SkillType);
		}

		[Token(Token = "0x6004E63")]
		[Address(RVA = "0x22270CC", Offset = "0x22270CC", VA = "0x22270CC")]
		public bool IsComboSkill(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E64")]
		[Address(RVA = "0x222716C", Offset = "0x222716C", VA = "0x222716C")]
		public int GetSkillID(int nSkillIndex)
		{
			return default(int);
		}

		[Token(Token = "0x6004E65")]
		[Address(RVA = "0x22271D4", Offset = "0x22271D4", VA = "0x22271D4")]
		public CSCharacterSkillInfo GetCharacterSkillInfo(int nSkillID)
		{
			return null;
		}

		[Token(Token = "0x6004E6D")]
		[Address(RVA = "0x2227358", Offset = "0x2227358", VA = "0x2227358")]
		public bool IsUsableSkill(int SkillId)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E6E")]
		[Address(RVA = "0x2227468", Offset = "0x2227468", VA = "0x2227468")]
		public bool IsUpgradableSkill(int SkillId)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E6F")]
		[Address(RVA = "0x2227578", Offset = "0x2227578", VA = "0x2227578")]
		public bool Cooking()
		{
			return default(bool);
		}

		[Token(Token = "0x6004E71")]
		[Address(RVA = "0x22281C8", Offset = "0x22281C8", VA = "0x22281C8")]
		public bool IsCharacterOpenTime(DateTime nowTime)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E72")]
		[Address(RVA = "0x2228448", Offset = "0x2228448", VA = "0x2228448")]
		public bool IsCharacterClosed(DateTime nowTime)
		{
			return default(bool);
		}
	}
}
