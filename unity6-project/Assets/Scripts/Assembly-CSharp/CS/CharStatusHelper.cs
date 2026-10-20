using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000922")]
	public static class CharStatusHelper
	{
		[Token(Token = "0x2000923")]
		private sealed class _003CParseFromXML_003Ec__AnonStorey14E<ITEM_TYPE, CHAR_STATUS> where ITEM_TYPE : new() where CHAR_STATUS : CharStatus
		{
			[Token(Token = "0x4002D4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal string index_tag;

			[Token(Token = "0x4002D4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal string index_tag2;

			[Token(Token = "0x4002D50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal IDictionary table;

			[Token(Token = "0x4002D51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal CSFileLoaderBase loader;

			[Token(Token = "0x4002D52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal List<string> varNames;

			[Token(Token = "0x60048FE")]
			public _003CParseFromXML_003Ec__AnonStorey14E()
			{
			}

			[Token(Token = "0x60048FF")]
			internal void _003C_003Em__1F1(int index, XElement element)
			{
			}
		}

		[Token(Token = "0x2000924")]
		private sealed class _003CParseFromXML_003Ec__AnonStorey14F<ITEM_TYPE, CHAR_STATUS> where ITEM_TYPE : new() where CHAR_STATUS : CharStatus
		{
			[Token(Token = "0x4002D53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal IDictionary table;

			[Token(Token = "0x4002D54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal CSFileLoaderBase loader;

			[Token(Token = "0x4002D55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal List<string> varNames;

			[Token(Token = "0x6004900")]
			public _003CParseFromXML_003Ec__AnonStorey14F()
			{
			}

			[Token(Token = "0x6004901")]
			internal void _003C_003Em__1F3(int index, XElement element)
			{
			}
		}

		[Token(Token = "0x60048F6")]
		[Address(RVA = "0x23EA718", Offset = "0x23EA718", VA = "0x23EA718")]
		public static string ReplaceAttrTextColor(CharStatusConvertParam arg)
		{
			return null;
		}

		[Token(Token = "0x60048F7")]
		[Address(RVA = "0x23EA8A0", Offset = "0x23EA8A0", VA = "0x23EA8A0")]
		public static string ReplaceAttrName(CharStatusConvertParam arg, [Optional] CultureInfo cultureInfo)
		{
			return null;
		}

		[Token(Token = "0x60048F8")]
		public static void ParseFromXMLImpl<ITEM_TYPE>(ITEM_TYPE item, XElement element, CSFileLoaderBase loader, List<string> varNames, [Optional] string parseFormat)
		{
		}

		[Token(Token = "0x60048F9")]
		public static void ParseFromXML<ITEM_TYPE, CHAR_STATUS>(CSFileLoaderBase loader, IDictionary table, string row_tag, string index_tag, string index_tag2) where ITEM_TYPE : new() where CHAR_STATUS : CharStatus
		{
		}

		[Token(Token = "0x60048FA")]
		public static void ParseFromXML<ITEM_TYPE, CHAR_STATUS>(CSFileLoaderBase loader, IDictionary table, string row_tag, string index_tag) where ITEM_TYPE : new() where CHAR_STATUS : CharStatus
		{
		}

		[Token(Token = "0x60048FB")]
		[Address(RVA = "0x23EB0B4", Offset = "0x23EB0B4", VA = "0x23EB0B4")]
		public static void ParseFromXML(CSFileLoaderBase loader, string row_tag, string index_tag, Action<int, XElement> action)
		{
		}

		[Token(Token = "0x60048FC")]
		private static string _003CParseFromXML_00602_003Em__1F0<ITEM_TYPE, CHAR_STATUS>(FieldInfo field) where ITEM_TYPE : new() where CHAR_STATUS : CharStatus
		{
			return null;
		}

		[Token(Token = "0x60048FD")]
		private static string _003CParseFromXML_00602_003Em__1F2<ITEM_TYPE, CHAR_STATUS>(FieldInfo field) where ITEM_TYPE : new() where CHAR_STATUS : CharStatus
		{
			return null;
		}
	}
}
