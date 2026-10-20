using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x200011F")]
	internal class DefaultReferenceResolver : IReferenceResolver
	{
		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0x8")]
		private int _referenceCount;

		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0xF6DD78", Offset = "0xF6DD78", VA = "0xF6DD78")]
		public DefaultReferenceResolver()
		{
		}

		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0xFBDE8C", Offset = "0xFBDE8C", VA = "0xFBDE8C")]
		private BidirectionalDictionary<string, object> GetMappings(object context)
		{
			return null;
		}

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0xFBE148", Offset = "0xFBE148", VA = "0xFBE148", Slot = "4")]
		public object ResolveReference(object context, string reference)
		{
			return null;
		}

		[Token(Token = "0x6000B00")]
		[Address(RVA = "0xFBE204", Offset = "0xFBE204", VA = "0xFBE204", Slot = "5")]
		public string GetReference(object context, object value)
		{
			return null;
		}

		[Token(Token = "0x6000B01")]
		[Address(RVA = "0xFBE364", Offset = "0xFBE364", VA = "0xFBE364", Slot = "7")]
		public void AddReference(object context, string reference, object value)
		{
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0xFBE410", Offset = "0xFBE410", VA = "0xFBE410", Slot = "6")]
		public bool IsReferenced(object context, object value)
		{
			return default(bool);
		}
	}
}
