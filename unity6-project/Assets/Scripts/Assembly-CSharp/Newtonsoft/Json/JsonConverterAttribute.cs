using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x20000C7")]
	public sealed class JsonConverterAttribute : Attribute
	{
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x8")]
		private readonly Type _converterType;

		[Token(Token = "0x170000E2")]
		public Type ConverterType
		{
			[Token(Token = "0x600065B")]
			[Address(RVA = "0x139D854", Offset = "0x139D854", VA = "0x139D854")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x139D78C", Offset = "0x139D78C", VA = "0x139D78C")]
		public JsonConverterAttribute(Type converterType)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x139D85C", Offset = "0x139D85C", VA = "0x139D85C")]
		internal static JsonConverter CreateJsonConverterInstance(Type converterType)
		{
			return null;
		}
	}
}
