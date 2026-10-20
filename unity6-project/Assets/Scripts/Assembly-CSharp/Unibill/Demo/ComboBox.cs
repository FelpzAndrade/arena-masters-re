using Il2CppDummyDll;
using UnityEngine;

namespace Unibill.Demo
{
	[Token(Token = "0x2001101")]
	public class ComboBox
	{
		[Token(Token = "0x4005D7F")]
		[FieldOffset(Offset = "0x0")]
		private static bool forceToUnShow;

		[Token(Token = "0x4005D80")]
		[FieldOffset(Offset = "0x4")]
		private static int useControlID;

		[Token(Token = "0x4005D81")]
		[FieldOffset(Offset = "0x8")]
		private bool isClickedComboButton;

		[Token(Token = "0x4005D82")]
		[FieldOffset(Offset = "0xC")]
		private int selectedItemIndex;

		[Token(Token = "0x60080C1")]
		[Address(RVA = "0x17B1220", Offset = "0x17B1220", VA = "0x17B1220")]
		public ComboBox()
		{
		}

		[Token(Token = "0x60080C3")]
		[Address(RVA = "0x17B12AC", Offset = "0x17B12AC", VA = "0x17B12AC")]
		public int List(Rect rect, string buttonText, GUIContent[] listContent, GUIStyle listStyle)
		{
			return default(int);
		}

		[Token(Token = "0x60080C4")]
		[Address(RVA = "0x17B19B0", Offset = "0x17B19B0", VA = "0x17B19B0")]
		public int List(Rect rect, GUIContent buttonContent, GUIContent[] listContent, GUIStyle listStyle)
		{
			return default(int);
		}

		[Token(Token = "0x60080C5")]
		[Address(RVA = "0x17B1ADC", Offset = "0x17B1ADC", VA = "0x17B1ADC")]
		public int List(Rect rect, string buttonText, GUIContent[] listContent, GUIStyle buttonStyle, GUIStyle boxStyle, GUIStyle listStyle)
		{
			return default(int);
		}

		[Token(Token = "0x60080C6")]
		[Address(RVA = "0x17B13FC", Offset = "0x17B13FC", VA = "0x17B13FC")]
		public int List(Rect rect, GUIContent buttonContent, GUIContent[] listContent, GUIStyle buttonStyle, GUIStyle boxStyle, GUIStyle listStyle)
		{
			return default(int);
		}

		[Token(Token = "0x60080C7")]
		[Address(RVA = "0x17B1BD8", Offset = "0x17B1BD8", VA = "0x17B1BD8")]
		public int GetSelectedItemIndex()
		{
			return default(int);
		}
	}
}
