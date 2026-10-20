using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000AD")]
	public abstract class DateTimeConverterBase : JsonConverter
	{
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x13894B8", Offset = "0x13894B8", VA = "0x13894B8")]
		protected DateTimeConverterBase()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x13894C0", Offset = "0x13894C0", VA = "0x13894C0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}
	}
}
