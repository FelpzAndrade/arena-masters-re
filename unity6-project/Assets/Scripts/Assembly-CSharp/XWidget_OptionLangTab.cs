using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000FB8")]
public class XWidget_OptionLangTab : XUIBaseWidget
{
	[Token(Token = "0x2000FB9")]
	private sealed class _003COnSelect_003Ec__AnonStorey245
	{
		[Token(Token = "0x400536E")]
		[FieldOffset(Offset = "0x8")]
		internal XWidget_LanguageItem waitSelectItem;

		[Token(Token = "0x400536F")]
		[FieldOffset(Offset = "0xC")]
		internal XWidget_OptionLangTab _003C_003Ef__this;

		[Token(Token = "0x6007510")]
		[Address(RVA = "0x130EA08", Offset = "0x130EA08", VA = "0x130EA08")]
		public _003COnSelect_003Ec__AnonStorey245()
		{
		}

		[Token(Token = "0x6007511")]
		[Address(RVA = "0x130EB24", Offset = "0x130EB24", VA = "0x130EB24")]
		internal void _003C_003Em__4CE()
		{
		}

		[Token(Token = "0x6007512")]
		[Address(RVA = "0x130ED74", Offset = "0x130ED74", VA = "0x130ED74")]
		internal void _003C_003Em__4CF()
		{
		}
	}

	[Token(Token = "0x400536C")]
	[FieldOffset(Offset = "0x1C")]
	public XWiget_GridBuilder languageBuilder;

	[Token(Token = "0x400536D")]
	[FieldOffset(Offset = "0x20")]
	private XWidget_LanguageItem currentSelectItem;

	[Token(Token = "0x600750A")]
	[Address(RVA = "0x130E1D0", Offset = "0x130E1D0", VA = "0x130E1D0")]
	public XWidget_OptionLangTab()
	{
	}

	[Token(Token = "0x600750B")]
	[Address(RVA = "0x130E1D8", Offset = "0x130E1D8", VA = "0x130E1D8")]
	public void BuildTab()
	{
	}

	[Token(Token = "0x600750C")]
	[Address(RVA = "0x130E5AC", Offset = "0x130E5AC", VA = "0x130E5AC")]
	public void Show()
	{
	}

	[Token(Token = "0x600750D")]
	[Address(RVA = "0x130E350", Offset = "0x130E350", VA = "0x130E350")]
	public void Build(List<XLanguageInfo> infos, string selectLanguage)
	{
	}

	[Token(Token = "0x600750E")]
	[Address(RVA = "0x130E6DC", Offset = "0x130E6DC", VA = "0x130E6DC")]
	public void OnSelect(XWidget_LanguageItem waitSelectItem)
	{
	}

	[Token(Token = "0x600750F")]
	[Address(RVA = "0x130EA10", Offset = "0x130EA10", VA = "0x130EA10")]
	private void SaveLangOption()
	{
	}
}
