using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000158")]
	internal class EnumValue<T> where T : struct
	{
		[Token(Token = "0x400056D")]
		[FieldOffset(Offset = "0x0")]
		private string _name;

		[Token(Token = "0x400056E")]
		[FieldOffset(Offset = "0x0")]
		private T _value;

		[Token(Token = "0x17000231")]
		public string Name
		{
			[Token(Token = "0x6000CF5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000232")]
		public T Value
		{
			[Token(Token = "0x6000CF6")]
			get
			{
				return (T)default;
			}
		}

		[Token(Token = "0x6000CF4")]
		public EnumValue(string name, T value)
		{
		}
	}
}
