using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Schema
{
	[Token(Token = "0x200010F")]
	internal class JsonSchemaNodeCollection : KeyedCollection<string, JsonSchemaNode>
	{
		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0xFB26D0", Offset = "0xFB26D0", VA = "0xFB26D0")]
		public JsonSchemaNodeCollection()
		{
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0xFB4550", Offset = "0xFB4550", VA = "0xFB4550", Slot = "37")]
		protected override string GetKeyForItem(JsonSchemaNode item)
		{
			return null;
		}
	}
}
