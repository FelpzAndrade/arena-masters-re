using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x20003AB")]
internal abstract class CharacterComparer : IComparer<XModuleActor>
{
		protected CharacterComparer()
		{
		}

	[Token(Token = "0x40012F0")]
	[FieldOffset(Offset = "0x8")]
	private bool m_isAscending;

	[Token(Token = "0x6001E37")]
	[Address(RVA = "0x20C4398", Offset = "0x20C4398", VA = "0x20C4398")]
	public CharacterComparer(bool isAscending)
	{
	}

	[Token(Token = "0x6001E38")]
	[Address(RVA = "0x20C43C4", Offset = "0x20C43C4", VA = "0x20C43C4", Slot = "4")]
	public int Compare(XModuleActor c1, XModuleActor c2)
	{
		return default(int);
	}

	[Token(Token = "0x6001E39")]
	protected abstract int CompareMethod(XModuleActor c1, XModuleActor c2);
}
