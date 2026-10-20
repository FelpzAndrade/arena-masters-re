using System;
using System.IO;
using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x20000C5")]
	public static class JsonConvert
	{
		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string True;

		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x4")]
		public static readonly string False;

		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string Null;

		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0xC")]
		public static readonly string Undefined;

		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string PositiveInfinity;

		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x14")]
		public static readonly string NegativeInfinity;

		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string NaN;

		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly long InitialJavaScriptDateTicks;

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x1398678", Offset = "0x1398678", VA = "0x1398678")]
		public static string ToString(DateTime value)
		{
			return null;
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x1398D10", Offset = "0x1398D10", VA = "0x1398D10")]
		public static string ToString(DateTimeOffset value)
		{
			return null;
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x13988BC", Offset = "0x13988BC", VA = "0x13988BC")]
		private static TimeSpan GetUtcOffset(DateTime dateTime)
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x1398F54", Offset = "0x1398F54", VA = "0x1398F54")]
		internal static void WriteDateTimeString(TextWriter writer, DateTime value)
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x13989CC", Offset = "0x13989CC", VA = "0x13989CC")]
		internal static void WriteDateTimeString(TextWriter writer, DateTime value, TimeSpan offset, DateTimeKind kind)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x1399064", Offset = "0x1399064", VA = "0x1399064")]
		private static long ToUniversalTicks(DateTime dateTime)
		{
			return default(long);
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x1399184", Offset = "0x1399184", VA = "0x1399184")]
		private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset)
		{
			return default(long);
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x1383574", Offset = "0x1383574", VA = "0x1383574")]
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset)
		{
			return default(long);
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x138A6B4", Offset = "0x138A6B4", VA = "0x138A6B4")]
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime)
		{
			return default(long);
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x1383448", Offset = "0x1383448", VA = "0x1383448")]
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc)
		{
			return default(long);
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x1399248", Offset = "0x1399248", VA = "0x1399248")]
		private static long UniversialTicksToJavaScriptTicks(long universialTicks)
		{
			return default(long);
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x13866B0", Offset = "0x13866B0", VA = "0x13866B0")]
		internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x1399314", Offset = "0x1399314", VA = "0x1399314")]
		public static string ToString(bool value)
		{
			return null;
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x1399410", Offset = "0x1399410", VA = "0x1399410")]
		public static string ToString(char value)
		{
			return null;
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x13995B8", Offset = "0x13995B8", VA = "0x13995B8")]
		public static string ToString(Enum value)
		{
			return null;
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x1399654", Offset = "0x1399654", VA = "0x1399654")]
		public static string ToString(int value)
		{
			return null;
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x1399714", Offset = "0x1399714", VA = "0x1399714")]
		public static string ToString(short value)
		{
			return null;
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x13997D4", Offset = "0x13997D4", VA = "0x13997D4")]
		public static string ToString(ushort value)
		{
			return null;
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x1399894", Offset = "0x1399894", VA = "0x1399894")]
		public static string ToString(uint value)
		{
			return null;
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x1399954", Offset = "0x1399954", VA = "0x1399954")]
		public static string ToString(long value)
		{
			return null;
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x1399A14", Offset = "0x1399A14", VA = "0x1399A14")]
		public static string ToString(ulong value)
		{
			return null;
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x1399AD4", Offset = "0x1399AD4", VA = "0x1399AD4")]
		public static string ToString(float value)
		{
			return null;
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x1399D5C", Offset = "0x1399D5C", VA = "0x1399D5C")]
		public static string ToString(double value)
		{
			return null;
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x1399BFC", Offset = "0x1399BFC", VA = "0x1399BFC")]
		private static string EnsureDecimalPlace(double value, string text)
		{
			return null;
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x1399E80", Offset = "0x1399E80", VA = "0x1399E80")]
		private static string EnsureDecimalPlace(string text)
		{
			return null;
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x1399F74", Offset = "0x1399F74", VA = "0x1399F74")]
		public static string ToString(byte value)
		{
			return null;
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x139A034", Offset = "0x139A034", VA = "0x139A034")]
		public static string ToString(sbyte value)
		{
			return null;
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x139A0F4", Offset = "0x139A0F4", VA = "0x139A0F4")]
		public static string ToString(decimal value)
		{
			return null;
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x139A200", Offset = "0x139A200", VA = "0x139A200")]
		public static string ToString(Guid value)
		{
			return null;
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x139A36C", Offset = "0x139A36C", VA = "0x139A36C")]
		public static string ToString(TimeSpan value)
		{
			return null;
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x139A474", Offset = "0x139A474", VA = "0x139A474")]
		public static string ToString(Uri value)
		{
			return null;
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x13994FC", Offset = "0x13994FC", VA = "0x13994FC")]
		public static string ToString(string value)
		{
			return null;
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x139A5C0", Offset = "0x139A5C0", VA = "0x139A5C0")]
		public static string ToString(string value, char delimter)
		{
			return null;
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x139A5E8", Offset = "0x139A5E8", VA = "0x139A5E8")]
		public static string ToString(object value)
		{
			return null;
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x139BBBC", Offset = "0x139BBBC", VA = "0x139BBBC")]
		private static bool IsJsonPrimitiveTypeCode(TypeCode typeCode)
		{
			return default(bool);
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x139BBE4", Offset = "0x139BBE4", VA = "0x139BBE4")]
		internal static bool IsJsonPrimitiveType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x139BF00", Offset = "0x139BF00", VA = "0x139BF00")]
		internal static bool IsJsonPrimitive(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x139C178", Offset = "0x139C178", VA = "0x139C178")]
		public static string SerializeObject(object value)
		{
			return null;
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x139C4D4", Offset = "0x139C4D4", VA = "0x139C4D4")]
		public static string SerializeObject(object value, Formatting formatting)
		{
			return null;
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x139C588", Offset = "0x139C588", VA = "0x139C588")]
		public static string SerializeObject(object value, params JsonConverter[] converters)
		{
			return null;
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x139C63C", Offset = "0x139C63C", VA = "0x139C63C")]
		public static string SerializeObject(object value, Formatting formatting, params JsonConverter[] converters)
		{
			return null;
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x139C228", Offset = "0x139C228", VA = "0x139C228")]
		public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings)
		{
			return null;
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x139C75C", Offset = "0x139C75C", VA = "0x139C75C")]
		public static object DeserializeObject(string value)
		{
			return null;
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x139CAD8", Offset = "0x139CAD8", VA = "0x139CAD8")]
		public static object DeserializeObject(string value, JsonSerializerSettings settings)
		{
			return null;
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x139CB8C", Offset = "0x139CB8C", VA = "0x139CB8C")]
		public static object DeserializeObject(string value, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000645")]
		public static T DeserializeObject<T>(string value)
		{
			return (T)default;
		}

		[Token(Token = "0x6000646")]
		public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject)
		{
			return (T)default;
		}

		[Token(Token = "0x6000647")]
		public static T DeserializeObject<T>(string value, params JsonConverter[] converters)
		{
			return (T)default;
		}

		[Token(Token = "0x6000648")]
		public static T DeserializeObject<T>(string value, JsonSerializerSettings settings)
		{
			return (T)default;
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x139CC40", Offset = "0x139CC40", VA = "0x139CC40")]
		public static object DeserializeObject(string value, Type type, params JsonConverter[] converters)
		{
			return null;
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x139C80C", Offset = "0x139C80C", VA = "0x139C80C")]
		public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings)
		{
			return null;
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x139CD60", Offset = "0x139CD60", VA = "0x139CD60")]
		public static void PopulateObject(string value, object target)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x139CE14", Offset = "0x139CE14", VA = "0x139CE14")]
		public static void PopulateObject(string value, object target, JsonSerializerSettings settings)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x139D0C0", Offset = "0x139D0C0", VA = "0x139D0C0")]
		public static string SerializeXmlNode(XmlNode node)
		{
			return null;
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x139D164", Offset = "0x139D164", VA = "0x139D164")]
		public static string SerializeXmlNode(XmlNode node, Formatting formatting)
		{
			return null;
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x139D2C0", Offset = "0x139D2C0", VA = "0x139D2C0")]
		public static string SerializeXmlNode(XmlNode node, Formatting formatting, bool omitRootObject)
		{
			return null;
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x139D430", Offset = "0x139D430", VA = "0x139D430")]
		public static XmlDocument DeserializeXmlNode(string value)
		{
			return null;
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x139D4D4", Offset = "0x139D4D4", VA = "0x139D4D4")]
		public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName)
		{
			return null;
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x139D588", Offset = "0x139D588", VA = "0x139D588")]
		public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute)
		{
			return null;
		}
	}
}
