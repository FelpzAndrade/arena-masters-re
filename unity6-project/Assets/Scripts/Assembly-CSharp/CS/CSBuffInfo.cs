using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000A93")]
	public class CSBuffInfo : CharStatus
	{
		[Token(Token = "0x400310D")]
		[FieldOffset(Offset = "0xB0")]
		public int m_nID;

		[Token(Token = "0x400310E")]
		[FieldOffset(Offset = "0xB4")]
		public string m_szName;

		[Token(Token = "0x400310F")]
		[FieldOffset(Offset = "0xB8")]
		public BuffType nBuffType;

		[Token(Token = "0x4003110")]
		[FieldOffset(Offset = "0xBC")]
		public string m_szDesc;

		[Token(Token = "0x4003111")]
		[FieldOffset(Offset = "0xC0")]
		public string m_szIcon;

		[Token(Token = "0x4003112")]
		[FieldOffset(Offset = "0xC4")]
		public float m_fEffectRatio;

		[Token(Token = "0x4003113")]
		[FieldOffset(Offset = "0xC8")]
		public float m_fTriggingCooltime;

		[Token(Token = "0x4003114")]
		[FieldOffset(Offset = "0xCC")]
		public MotionControlType nMotionControlType;

		[Token(Token = "0x4003115")]
		[FieldOffset(Offset = "0xD0")]
		public MotionControlSource nMotionControlSource;

		[Token(Token = "0x4003116")]
		[FieldOffset(Offset = "0xD4")]
		public MotionControlDirection nMotionControlDirection;

		[Token(Token = "0x4003117")]
		[FieldOffset(Offset = "0xD8")]
		public float fMotionControlDistance;

		[Token(Token = "0x4003118")]
		[FieldOffset(Offset = "0xDC")]
		public float m_fModScaleX;

		[Token(Token = "0x4003119")]
		[FieldOffset(Offset = "0xE0")]
		public float m_fModScaleY;

		[Token(Token = "0x400311A")]
		[FieldOffset(Offset = "0xE4")]
		public float m_fModScaleZ;

		[Token(Token = "0x400311B")]
		[FieldOffset(Offset = "0xE8")]
		public string m_strBuffLine;

		[Token(Token = "0x400311C")]
		[FieldOffset(Offset = "0xEC")]
		[XmlIgnore]
		public List<int> buffLineList;

		[Token(Token = "0x400311D")]
		[FieldOffset(Offset = "0xF0")]
		public MotionControlSource m_uniformMotionSource;

		[Token(Token = "0x400311E")]
		[FieldOffset(Offset = "0xF4")]
		public MotionControlDirection m_uniformMotionDirection;

		[Token(Token = "0x400311F")]
		[FieldOffset(Offset = "0xF8")]
		public float m_uniformMotionSpeed;

		[Token(Token = "0x4003120")]
		[FieldOffset(Offset = "0xFC")]
		public string m_strDispellBuffLine;

		[Token(Token = "0x4003121")]
		[FieldOffset(Offset = "0x100")]
		[XmlIgnore]
		public List<int> dispellBuffLineList;

		[Token(Token = "0x4003122")]
		[FieldOffset(Offset = "0x104")]
		public int m_nBuffRank;

		[Token(Token = "0x4003123")]
		[FieldOffset(Offset = "0x108")]
		public float m_fPeriod;

		[Token(Token = "0x4003124")]
		[FieldOffset(Offset = "0x10C")]
		public float m_fDotDamagePerMaxHP;

		[Token(Token = "0x4003125")]
		[FieldOffset(Offset = "0x110")]
		public float m_fHotHealPerMaxHP;

		[Token(Token = "0x4003126")]
		[FieldOffset(Offset = "0x114")]
		public string strInvincible;

		[Token(Token = "0x4003127")]
		[FieldOffset(Offset = "0x118")]
		private bool m_Invincible;

		[Token(Token = "0x4003128")]
		[FieldOffset(Offset = "0x11C")]
		public CSBuffPlayerState m_nChangePlayerState;

		[Token(Token = "0x4003129")]
		[FieldOffset(Offset = "0x120")]
		public string strGhost;

		[Token(Token = "0x400312A")]
		[FieldOffset(Offset = "0x124")]
		public bool Ghost;

		[Token(Token = "0x400312B")]
		[FieldOffset(Offset = "0x128")]
		public string strInvisible;

		[Token(Token = "0x400312C")]
		[FieldOffset(Offset = "0x12C")]
		private bool m_invisible;

		[Token(Token = "0x400312D")]
		[FieldOffset(Offset = "0x130")]
		public float fInvisibleAlpha;

		[Token(Token = "0x400312E")]
		[FieldOffset(Offset = "0x134")]
		public string strImmuneMapItem;

		[Token(Token = "0x400312F")]
		[FieldOffset(Offset = "0x138")]
		private bool m_ImmuneMapItem;

		[Token(Token = "0x4003130")]
		[FieldOffset(Offset = "0x13C")]
		public float m_fMapModSightRange;

		[Token(Token = "0x4003131")]
		[FieldOffset(Offset = "0x140")]
		public string strImmunTrapPierce;

		[Token(Token = "0x4003132")]
		[FieldOffset(Offset = "0x144")]
		private bool m_ImmunTrapPierce;

		[Token(Token = "0x4003133")]
		[FieldOffset(Offset = "0x148")]
		public string strInstantDeath;

		[Token(Token = "0x4003134")]
		[FieldOffset(Offset = "0x14C")]
		private bool m_InstantDeath;

		[Token(Token = "0x4003135")]
		[FieldOffset(Offset = "0x150")]
		public string strShowDescInGame;

		[Token(Token = "0x4003136")]
		[FieldOffset(Offset = "0x154")]
		private bool m_ShowDescInGame;

		[Token(Token = "0x4003137")]
		[FieldOffset(Offset = "0x158")]
		public int m_nChangeCharID;

		[Token(Token = "0x4003138")]
		[FieldOffset(Offset = "0x15C")]
		public string strIdleRotation;

		[Token(Token = "0x4003139")]
		[FieldOffset(Offset = "0x160")]
		private bool m_IdleRotation;

		[Token(Token = "0x400313A")]
		[FieldOffset(Offset = "0x164")]
		public string strClearOnDie;

		[Token(Token = "0x400313B")]
		[FieldOffset(Offset = "0x168")]
		private bool m_ClearOnDie;

		[Token(Token = "0x400313C")]
		[FieldOffset(Offset = "0x16C")]
		public int nAdjustSkillID;

		[Token(Token = "0x400313D")]
		[FieldOffset(Offset = "0x170")]
		public float nAdjustSkillCooltime;

		[Token(Token = "0x400313E")]
		[FieldOffset(Offset = "0x174")]
		public string strMotionFactionAni;

		[Token(Token = "0x400313F")]
		[FieldOffset(Offset = "0x178")]
		public ProcTimingType m_nProcTimingType;

		[Token(Token = "0x4003140")]
		[FieldOffset(Offset = "0x17C")]
		public int m_nProcRate;

		[Token(Token = "0x4003141")]
		[FieldOffset(Offset = "0x180")]
		public int m_nProcSkillID;

		[Token(Token = "0x4003142")]
		[FieldOffset(Offset = "0x184")]
		public ProcSkillOwner m_ProcSkillOwner;

		[Token(Token = "0x4003143")]
		[FieldOffset(Offset = "0x188")]
		public float m_fProcDelayTime;

		[Token(Token = "0x4003144")]
		[FieldOffset(Offset = "0x18C")]
		public string strProcSkillLeader;

		[Token(Token = "0x4003145")]
		[FieldOffset(Offset = "0x190")]
		private bool m_ProcSkillLeader;

		[Token(Token = "0x4003146")]
		[FieldOffset(Offset = "0x194")]
		public string strChangeModelOnly;

		[Token(Token = "0x4003147")]
		[FieldOffset(Offset = "0x198")]
		public bool ChangeModelOnly;

		[Token(Token = "0x4003148")]
		[FieldOffset(Offset = "0x19C")]
		public string strChangeSkillPalette;

		[Token(Token = "0x4003149")]
		[FieldOffset(Offset = "0x1A0")]
		public bool ChangeSkillPalette;

		[Token(Token = "0x400314A")]
		[FieldOffset(Offset = "0x1A4")]
		public string strShowTagButton;

		[Token(Token = "0x400314B")]
		[FieldOffset(Offset = "0x1A8")]
		public bool ShowTagButton;

		[Token(Token = "0x400314C")]
		[FieldOffset(Offset = "0x1AC")]
		public string strExtraReleaseCondition;

		[Token(Token = "0x400314D")]
		[FieldOffset(Offset = "0x1B0")]
		public bool[] extraReleaseConditions;

		[Token(Token = "0x400314E")]
		[FieldOffset(Offset = "0x1B4")]
		public float m_chargeUltimate;

		[Token(Token = "0x400314F")]
		[FieldOffset(Offset = "0x1B8")]
		public TriggingBuffTiming triggingBuffTiming;

		[Token(Token = "0x4003150")]
		[FieldOffset(Offset = "0x1BC")]
		public int triggingBuffId;

		[Token(Token = "0x4003151")]
		[FieldOffset(Offset = "0x1C0")]
		public BuffMetaPropertyKey metaPropertyKey;

		[Token(Token = "0x4003152")]
		[FieldOffset(Offset = "0x1C4")]
		public string metaPropertyValue;

		[Token(Token = "0x4003153")]
		[FieldOffset(Offset = "0x1C8")]
		public int stackCount;

		[Token(Token = "0x4003154")]
		[FieldOffset(Offset = "0x1CC")]
		public string m_blindStr;

		[Token(Token = "0x4003155")]
		[FieldOffset(Offset = "0x1D0")]
		private bool m_blind;

		[Token(Token = "0x4003156")]
		[FieldOffset(Offset = "0x1D4")]
		[XmlIgnore]
		public BuffEffectInfos EffectInfos;

		[Token(Token = "0x4003157")]
		[FieldOffset(Offset = "0x1D8")]
		[XmlIgnore]
		public bool IsModeBuff;

		[Token(Token = "0x17000B05")]
		public bool Invincible
		{
			[Token(Token = "0x6004E21")]
			[Address(RVA = "0x22254A8", Offset = "0x22254A8", VA = "0x22254A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B06")]
		public bool Invisible
		{
			[Token(Token = "0x6004E22")]
			[Address(RVA = "0x22254B0", Offset = "0x22254B0", VA = "0x22254B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B07")]
		public bool ImmuneMapItem
		{
			[Token(Token = "0x6004E23")]
			[Address(RVA = "0x22254B8", Offset = "0x22254B8", VA = "0x22254B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B08")]
		public bool ImmunTrapPierce
		{
			[Token(Token = "0x6004E24")]
			[Address(RVA = "0x22254C0", Offset = "0x22254C0", VA = "0x22254C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B09")]
		public bool InstantDeath
		{
			[Token(Token = "0x6004E25")]
			[Address(RVA = "0x22254C8", Offset = "0x22254C8", VA = "0x22254C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B0A")]
		public bool IsShowDescInGame
		{
			[Token(Token = "0x6004E26")]
			[Address(RVA = "0x22254D0", Offset = "0x22254D0", VA = "0x22254D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B0B")]
		public bool HasChangeCharacter
		{
			[Token(Token = "0x6004E27")]
			[Address(RVA = "0x22254D8", Offset = "0x22254D8", VA = "0x22254D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B0C")]
		public bool IdleRotation
		{
			[Token(Token = "0x6004E28")]
			[Address(RVA = "0x22254E8", Offset = "0x22254E8", VA = "0x22254E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B0D")]
		public bool ClearOnDie
		{
			[Token(Token = "0x6004E29")]
			[Address(RVA = "0x22254F0", Offset = "0x22254F0", VA = "0x22254F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B0E")]
		public bool ProcSkillLeader
		{
			[Token(Token = "0x6004E2A")]
			[Address(RVA = "0x22254F8", Offset = "0x22254F8", VA = "0x22254F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B0F")]
		public bool IsBlind
		{
			[Token(Token = "0x6004E2C")]
			[Address(RVA = "0x2225544", Offset = "0x2225544", VA = "0x2225544")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6004E20")]
		[Address(RVA = "0x22251D8", Offset = "0x22251D8", VA = "0x22251D8")]
		public CSBuffInfo()
		{
		}

		[Token(Token = "0x6004E2B")]
		[Address(RVA = "0x2225500", Offset = "0x2225500", VA = "0x2225500")]
		public bool CheckExtraReleaseCondition(ExtraReleaseCondition condition)
		{
			return default(bool);
		}

		[Token(Token = "0x6004E2D")]
		[Address(RVA = "0x222554C", Offset = "0x222554C", VA = "0x222554C")]
		private void CookingExtraReleaseCondition()
		{
		}

		[Token(Token = "0x6004E2E")]
		[Address(RVA = "0x2225BD0", Offset = "0x2225BD0", VA = "0x2225BD0")]
		public bool Cooking()
		{
			return default(bool);
		}

		[Token(Token = "0x6004E2F")]
		[Address(RVA = "0x22262BC", Offset = "0x22262BC", VA = "0x22262BC")]
		private bool CookingBuffLine()
		{
			return default(bool);
		}

		[Token(Token = "0x6004E30")]
		[Address(RVA = "0x22264C0", Offset = "0x22264C0", VA = "0x22264C0")]
		private bool CookingDispellBuffLine()
		{
			return default(bool);
		}
	}
}
