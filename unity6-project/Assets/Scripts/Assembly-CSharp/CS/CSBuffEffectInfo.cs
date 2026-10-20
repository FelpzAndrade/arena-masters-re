using System;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000A97")]
	public sealed class CSBuffEffectInfo
	{
		[Token(Token = "0x2000A98")]
		public enum BaseLocation
		{
			[Token(Token = "0x400316A")]
			Bottom = 0,
			[Token(Token = "0x400316B")]
			Center = 1,
			[Token(Token = "0x400316C")]
			Top = 2,
			[Token(Token = "0x400316D")]
			Ground = 3
		}

		[Token(Token = "0x2000A99")]
		public enum EffectTiming
		{
			[Token(Token = "0x400316F")]
			Gain = 0,
			[Token(Token = "0x4003170")]
			Lost = 1
		}

		[Token(Token = "0x400315B")]
		[FieldOffset(Offset = "0x8")]
		public int nID;

		[Token(Token = "0x400315C")]
		[FieldOffset(Offset = "0xC")]
		public int nSkinID;

		[Token(Token = "0x400315D")]
		[FieldOffset(Offset = "0x10")]
		public string m_refreshOnUpdateStr;

		[Token(Token = "0x400315E")]
		[FieldOffset(Offset = "0x14")]
		private bool m_refreshOnUpdate;

		[Token(Token = "0x400315F")]
		[FieldOffset(Offset = "0x18")]
		public EffectTiming effectDisplayTiming;

		[Token(Token = "0x4003160")]
		[FieldOffset(Offset = "0x1C")]
		public string m_eraseOnReleaseStr;

		[Token(Token = "0x4003161")]
		[FieldOffset(Offset = "0x20")]
		private bool m_eraseOnRelease;

		[Token(Token = "0x4003162")]
		[FieldOffset(Offset = "0x24")]
		public string m_szResourceName;

		[Token(Token = "0x4003163")]
		[FieldOffset(Offset = "0x28")]
		public BaseLocation baseLocation;

		[Token(Token = "0x4003164")]
		[FieldOffset(Offset = "0x2C")]
		public string m_applyBuffEffectScaleStr;

		[Token(Token = "0x4003165")]
		[FieldOffset(Offset = "0x30")]
		private bool m_applyBuffEffectScale;

		[Token(Token = "0x4003166")]
		[FieldOffset(Offset = "0x34")]
		public string m_effectScreenPath;

		[Token(Token = "0x4003167")]
		[FieldOffset(Offset = "0x38")]
		[XmlIgnore]
		public string m_blindStr;

		[Token(Token = "0x4003168")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_blind;

		[Token(Token = "0x17000B10")]
		public bool RefreshOnUpdate
		{
			[Token(Token = "0x6004E3F")]
			[Address(RVA = "0x2224E1C", Offset = "0x2224E1C", VA = "0x2224E1C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004E40")]
			[Address(RVA = "0x2224E24", Offset = "0x2224E24", VA = "0x2224E24")]
			set
			{
			}
		}

		[Token(Token = "0x17000B11")]
		public bool EraseOnRelease
		{
			[Token(Token = "0x6004E41")]
			[Address(RVA = "0x2224E2C", Offset = "0x2224E2C", VA = "0x2224E2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B12")]
		public bool ApplyBuffEffectScale
		{
			[Token(Token = "0x6004E42")]
			[Address(RVA = "0x2224E34", Offset = "0x2224E34", VA = "0x2224E34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6004E3E")]
		[Address(RVA = "0x2224CE4", Offset = "0x2224CE4", VA = "0x2224CE4")]
		public CSBuffEffectInfo()
		{
		}

		[Token(Token = "0x6004E43")]
		[Address(RVA = "0x2224E3C", Offset = "0x2224E3C", VA = "0x2224E3C")]
		public bool Cooking()
		{
			return default(bool);
		}
	}
}
