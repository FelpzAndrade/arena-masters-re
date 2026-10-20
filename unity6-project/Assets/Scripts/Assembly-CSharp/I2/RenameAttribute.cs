using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace I2
{
	[Token(Token = "0x2000061")]
	public class RenameAttribute : PropertyAttribute
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly string Name;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public readonly string Tooltip;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly int HorizSpace;

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xD88838", Offset = "0xD88838", VA = "0xD88838")]
		public RenameAttribute(int hspace, string name, [Optional] string tooltip)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xD88868", Offset = "0xD88868", VA = "0xD88868")]
		public RenameAttribute(string name, [Optional] string tooltip)
		{
		}
	}
}
