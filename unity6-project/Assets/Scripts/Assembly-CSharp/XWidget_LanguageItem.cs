using System;
using Il2CppDummyDll;

[Token(Token = "0x2000F9B")]
public class XWidget_LanguageItem : XWidget_Select
{
	[Token(Token = "0x2000F9C")]
	private sealed class _003CBuild_003Ec__AnonStorey23F
	{
		[Token(Token = "0x40052A4")]
		[FieldOffset(Offset = "0x8")]
		internal Action<XWidget_LanguageItem> onSelect;

		[Token(Token = "0x40052A5")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_LanguageItem _003C_003Ef__this;

		[Token(Token = "0x6007462")]
		[Address(RVA = "0x145997C", Offset = "0x145997C", VA = "0x145997C")]
		public _003CBuild_003Ec__AnonStorey23F()
		{
		}

		[Token(Token = "0x6007463")]
		[Address(RVA = "0x1459984", Offset = "0x1459984", VA = "0x1459984")]
		internal void _003C_003Em__4BE()
		{
		}
	}

	[Token(Token = "0x40052A3")]
	[FieldOffset(Offset = "0x18")]
	private XLanguageInfo info;

	[Token(Token = "0x17000ECF")]
	public string LanguageString
	{
		[Token(Token = "0x600745E")]
		[Address(RVA = "0x1459578", Offset = "0x1459578", VA = "0x1459578")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ED0")]
	public string ChannelNameString
	{
		[Token(Token = "0x600745F")]
		[Address(RVA = "0x1459640", Offset = "0x1459640", VA = "0x1459640")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ED1")]
	public string LocaleKey
	{
		[Token(Token = "0x6007460")]
		[Address(RVA = "0x1459708", Offset = "0x1459708", VA = "0x1459708")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600745D")]
	[Address(RVA = "0x1459570", Offset = "0x1459570", VA = "0x1459570")]
	public XWidget_LanguageItem()
	{
	}

	[Token(Token = "0x6007461")]
	[Address(RVA = "0x14597D0", Offset = "0x14597D0", VA = "0x14597D0")]
	public void Build(XLanguageInfo info, bool selected, Action<XWidget_LanguageItem> onSelect)
	{
	}
}
