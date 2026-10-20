using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2000695")]
public class TutorialDataBase
{
	[Token(Token = "0x4002028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	protected TutorialScriptType scriptType;

	[Token(Token = "0x4002029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public string arg1;

	[Token(Token = "0x400202A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private int order__BackingField;

	[Token(Token = "0x1700080A")]
	public TutorialScriptType TutorialScriptType
	{
		[Token(Token = "0x6003741")]
		[Address(RVA = "0x1D58F6C", Offset = "0x1D58F6C", VA = "0x1D58F6C")]
		get
		{
			return default(TutorialScriptType);
		}
	}

	[Token(Token = "0x1700080B")]
	public int order
	{
		[Token(Token = "0x6003742")]
		[Address(RVA = "0x1D58F74", Offset = "0x1D58F74", VA = "0x1D58F74")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003743")]
		[Address(RVA = "0x1D58F64", Offset = "0x1D58F64", VA = "0x1D58F64")]
		protected set
		{
		}
	}

	[Token(Token = "0x600373F")]
	[Address(RVA = "0x1D58F2C", Offset = "0x1D58F2C", VA = "0x1D58F2C")]
	public TutorialDataBase()
	{
	}

	[Token(Token = "0x6003740")]
	[Address(RVA = "0x1D58F34", Offset = "0x1D58F34", VA = "0x1D58F34")]
	public TutorialDataBase(int order, TutorialScriptType scriptType, [Optional] string arg1)
	{
	}
}
