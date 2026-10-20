using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20003D0")]
internal abstract class PetComparer : IComparer<XModuleActor>
{
		protected PetComparer()
		{
		}

	[Token(Token = "0x4001350")]
	[FieldOffset(Offset = "0x8")]
	private bool m_isAscending;

	[Token(Token = "0x6001F54")]
	[Address(RVA = "0x1B7FFF8", Offset = "0x1B7FFF8", VA = "0x1B7FFF8")]
	public PetComparer(bool isAscending)
	{
	}

	[Token(Token = "0x6001F55")]
	[Address(RVA = "0x1B80024", Offset = "0x1B80024", VA = "0x1B80024", Slot = "4")]
	public int Compare(XModuleActor c1, XModuleActor c2)
	{
		return default(int);
	}

	[Token(Token = "0x6001F56")]
	protected abstract int CompareMethod(XModuleActor c1, XModuleActor c2);
}
