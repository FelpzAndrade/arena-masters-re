using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000159")]
	internal class EnumValues<T> : KeyedCollection<string, EnumValue<T>> where T : struct
	{
		[Token(Token = "0x6000CF7")]
		public EnumValues()
		{
		}

		[Token(Token = "0x6000CF8")]
		protected override string GetKeyForItem(EnumValue<T> item)
		{
			return null;
		}
	}
}
