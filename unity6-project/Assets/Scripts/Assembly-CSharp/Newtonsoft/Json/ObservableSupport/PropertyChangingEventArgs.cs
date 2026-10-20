using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.ObservableSupport
{
	[Token(Token = "0x2000100")]
	public class PropertyChangingEventArgs : EventArgs
	{
		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0x8")]
		private string PropertyName__BackingField;

		[Token(Token = "0x1700017F")]
		public virtual string PropertyName
		{
			[Token(Token = "0x60009E2")]
			[Address(RVA = "0xFA6FB4", Offset = "0xFA6FB4", VA = "0xFA6FB4", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009E3")]
			[Address(RVA = "0xFA6FBC", Offset = "0xFA6FBC", VA = "0xFA6FBC", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0xFA6ED4", Offset = "0xFA6ED4", VA = "0xFA6ED4")]
		public PropertyChangingEventArgs(string propertyName)
		{
		}
	}
}
