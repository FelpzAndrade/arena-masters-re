using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B5D")]
	public sealed class CSSkillEffectInfo
	{
		[Token(Token = "0x400393C")]
		[FieldOffset(Offset = "0x8")]
		public int nID;

		[Token(Token = "0x400393D")]
		[FieldOffset(Offset = "0xC")]
		public int nSkinID;

		[Token(Token = "0x400393E")]
		[FieldOffset(Offset = "0x10")]
		public string szEffectName;

		[Token(Token = "0x400393F")]
		[FieldOffset(Offset = "0x14")]
		public float m_fEffectTime;

		[Token(Token = "0x4003940")]
		[FieldOffset(Offset = "0x18")]
		public string m_strEffectStartNode;

		[Token(Token = "0x4003941")]
		[FieldOffset(Offset = "0x1C")]
		public string effectFollowString;

		[Token(Token = "0x4003942")]
		[FieldOffset(Offset = "0x20")]
		private bool m_EffectFollow;

		[Token(Token = "0x4003943")]
		[FieldOffset(Offset = "0x24")]
		public float effectScale;

		[Token(Token = "0x4003944")]
		[FieldOffset(Offset = "0x28")]
		public string effectPersistanceString;

		[Token(Token = "0x4003945")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_effectPersistance;

		[Token(Token = "0x4003946")]
		[FieldOffset(Offset = "0x30")]
		public string szHitEffectName;

		[Token(Token = "0x4003947")]
		[FieldOffset(Offset = "0x34")]
		public string useHitBlinkString;

		[Token(Token = "0x4003948")]
		[FieldOffset(Offset = "0x38")]
		private bool m_useHitBlink;

		[Token(Token = "0x4003949")]
		[FieldOffset(Offset = "0x3C")]
		public string szHitMashColor;

		[Token(Token = "0x400394A")]
		[FieldOffset(Offset = "0x40")]
		public string szMashRimColor;

		[Token(Token = "0x400394B")]
		[FieldOffset(Offset = "0x44")]
		public string szMashColor;

		[Token(Token = "0x400394C")]
		[FieldOffset(Offset = "0x48")]
		public float nMashColorDuration;

		[Token(Token = "0x400394D")]
		[FieldOffset(Offset = "0x4C")]
		public string szProjectileName;

		[Token(Token = "0x400394E")]
		[FieldOffset(Offset = "0x50")]
		public string m_strProjectileStartNode;

		[Token(Token = "0x400394F")]
		[FieldOffset(Offset = "0x54")]
		public float projectileInitRotation;

		[Token(Token = "0x4003950")]
		[FieldOffset(Offset = "0x58")]
		public string szProjectileHitWallEffect;

		[Token(Token = "0x4003951")]
		[FieldOffset(Offset = "0x5C")]
		public string szProjectileHitActorEffect;

		[Token(Token = "0x4003952")]
		[FieldOffset(Offset = "0x60")]
		public string szProjectileTimeoutEffect;

		[Token(Token = "0x4003953")]
		[FieldOffset(Offset = "0x64")]
		public string szProjectileRangeoutEffect;

		[Token(Token = "0x17000C24")]
		public bool EffectFollow
		{
			[Token(Token = "0x60052E2")]
			[Address(RVA = "0x1CD2A7C", Offset = "0x1CD2A7C", VA = "0x1CD2A7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000C25")]
		public bool EffectPersistance
		{
			[Token(Token = "0x60052E3")]
			[Address(RVA = "0x1CD2A84", Offset = "0x1CD2A84", VA = "0x1CD2A84")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000C26")]
		public bool UseHitBlink
		{
			[Token(Token = "0x60052E4")]
			[Address(RVA = "0x1CD2A8C", Offset = "0x1CD2A8C", VA = "0x1CD2A8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60052E1")]
		[Address(RVA = "0x1CD28BC", Offset = "0x1CD28BC", VA = "0x1CD28BC")]
		public CSSkillEffectInfo()
		{
		}

		[Token(Token = "0x60052E5")]
		[Address(RVA = "0x1CC4360", Offset = "0x1CC4360", VA = "0x1CC4360")]
		public bool Cooking()
		{
			return default(bool);
		}
	}
}
