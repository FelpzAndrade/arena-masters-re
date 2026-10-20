using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x20000C2")]
	public sealed class JsonArrayAttribute : JsonContainerAttribute
	{
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x18")]
		private bool _allowNullItems;

		[Token(Token = "0x170000DB")]
		public bool AllowNullItems
		{
			[Token(Token = "0x600060A")]
			[Address(RVA = "0x139836C", Offset = "0x139836C", VA = "0x139836C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x1398374", Offset = "0x1398374", VA = "0x1398374")]
			set
			{
			}
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x13982FC", Offset = "0x13982FC", VA = "0x13982FC")]
		public JsonArrayAttribute()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x139830C", Offset = "0x139830C", VA = "0x139830C")]
		public JsonArrayAttribute(bool allowNullItems)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x139832C", Offset = "0x139832C", VA = "0x139832C")]
		public JsonArrayAttribute(string id)
		{
		}
	}
}
