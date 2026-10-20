using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2001061")]
public class XCharStatusDisplay
{
	[Token(Token = "0x2001062")]
	public class StatInfo
	{
		[Token(Token = "0x400587A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string FieldName;

		[Token(Token = "0x400587B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public CharStatusAttr Stat;

		[Token(Token = "0x400587C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StatDesc StatDesc;

		[Token(Token = "0x400587D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public CharStatusAttr StatOther;

		[Token(Token = "0x400587E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CharStatusAttr StatDiff;

		[Token(Token = "0x400587F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool IsMajor;

		[Token(Token = "0x4005880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool IsItem;

		[Token(Token = "0x17000F47")]
		public bool IsRate
		{
			[Token(Token = "0x6007BC8")]
			[Address(RVA = "0x1AC0A04", Offset = "0x1AC0A04", VA = "0x1AC0A04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000F48")]
		public string ValueString
		{
			[Token(Token = "0x6007BC9")]
			[Address(RVA = "0x1AC0A28", Offset = "0x1AC0A28", VA = "0x1AC0A28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F49")]
		public string CharValueString
		{
			[Token(Token = "0x6007BCA")]
			[Address(RVA = "0x1AC0D3C", Offset = "0x1AC0D3C", VA = "0x1AC0D3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F4A")]
		public string ValueStringOther
		{
			[Token(Token = "0x6007BCB")]
			[Address(RVA = "0x1AC0FF4", Offset = "0x1AC0FF4", VA = "0x1AC0FF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F4B")]
		public bool? IsBetter
		{
			[Token(Token = "0x6007BCC")]
			[Address(RVA = "0x1AC104C", Offset = "0x1AC104C", VA = "0x1AC104C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F4C")]
		public string ValueStringDiff
		{
			[Token(Token = "0x6007BCD")]
			[Address(RVA = "0x1AC1188", Offset = "0x1AC1188", VA = "0x1AC1188")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F4D")]
		public string ValueStringDiffNoColor
		{
			[Token(Token = "0x6007BCE")]
			[Address(RVA = "0x1AC16CC", Offset = "0x1AC16CC", VA = "0x1AC16CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F4E")]
		public string ValueStringDiffPure
		{
			[Token(Token = "0x6007BCF")]
			[Address(RVA = "0x1AC18B0", Offset = "0x1AC18B0", VA = "0x1AC18B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007BC7")]
		[Address(RVA = "0x1AC0608", Offset = "0x1AC0608", VA = "0x1AC0608")]
		public StatInfo()
		{
		}

		[Token(Token = "0x6007BD0")]
		[Address(RVA = "0x1AC13D0", Offset = "0x1AC13D0", VA = "0x1AC13D0")]
		public string RGBToHexString(short r, short g, short b)
		{
			return null;
		}

		[Token(Token = "0x6007BD1")]
		[Address(RVA = "0x1AC19B4", Offset = "0x1AC19B4", VA = "0x1AC19B4")]
		public string GetFormat()
		{
			return null;
		}

		[Token(Token = "0x6007BD2")]
		[Address(RVA = "0x1AC1AD4", Offset = "0x1AC1AD4", VA = "0x1AC1AD4")]
		public float GetRoundValue(float value)
		{
			return default(float);
		}

		[Token(Token = "0x6007BD3")]
		[Address(RVA = "0x1AC1B48", Offset = "0x1AC1B48", VA = "0x1AC1B48")]
		public float GetDescRoundValue()
		{
			return default(float);
		}

		[Token(Token = "0x6007BD4")]
		[Address(RVA = "0x1AC0A80", Offset = "0x1AC0A80", VA = "0x1AC0A80")]
		private string GetValueString(float value)
		{
			return null;
		}

		[Token(Token = "0x6007BD5")]
		[Address(RVA = "0x1AC0D40", Offset = "0x1AC0D40", VA = "0x1AC0D40")]
		private string GetDescValueString()
		{
			return null;
		}
	}

	[Token(Token = "0x4005879")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private Dictionary<string, StatInfo> m_dic;

	[Token(Token = "0x6007BC0")]
	[Address(RVA = "0x1ABFEAC", Offset = "0x1ABFEAC", VA = "0x1ABFEAC")]
	public XCharStatusDisplay(bool isItem, CharStatus stat)
	{
	}

	[Token(Token = "0x6007BC1")]
	[Address(RVA = "0x1AC0428", Offset = "0x1AC0428", VA = "0x1AC0428")]
	public XCharStatusDisplay(bool isItem, CharStatus stat, CharStatus statOther)
	{
	}

	[Token(Token = "0x6007BC2")]
	[Address(RVA = "0x1AC0468", Offset = "0x1AC0468", VA = "0x1AC0468")]
	public Dictionary<string, StatInfo> GetDic()
	{
		return null;
	}

	[Token(Token = "0x6007BC3")]
	[Address(RVA = "0x1AC0470", Offset = "0x1AC0470", VA = "0x1AC0470")]
	public StatInfo GetStat(string key)
	{
		return null;
	}

	[Token(Token = "0x6007BC4")]
	[Address(RVA = "0x1ABFEE8", Offset = "0x1ABFEE8", VA = "0x1ABFEE8")]
	protected Dictionary<string, StatInfo> GetAttrDictionary(bool isItem, CharStatus info, [Optional] CharStatus other)
	{
		return null;
	}

	[Token(Token = "0x6007BC5")]
	[Address(RVA = "0x1AC0610", Offset = "0x1AC0610", VA = "0x1AC0610")]
	public List<StatInfo> GetStatInfos()
	{
		return null;
	}

	[Token(Token = "0x6007BC6")]
	[Address(RVA = "0x1AC0818", Offset = "0x1AC0818", VA = "0x1AC0818")]
	public List<StatInfo> GetStatDiffInfos()
	{
		return null;
	}
}
