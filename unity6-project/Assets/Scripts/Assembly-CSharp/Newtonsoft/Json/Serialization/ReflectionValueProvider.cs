using System.Reflection;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x200013D")]
	public class ReflectionValueProvider : IValueProvider
	{
		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0x8")]
		private readonly MemberInfo _memberInfo;

		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0x119202C", Offset = "0x119202C", VA = "0x119202C")]
		public ReflectionValueProvider(MemberInfo memberInfo)
		{
		}

		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x11920C4", Offset = "0x11920C4", VA = "0x11920C4", Slot = "4")]
		public void SetValue(object target, object value)
		{
		}

		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0x11926E4", Offset = "0x11926E4", VA = "0x11926E4", Slot = "5")]
		public object GetValue(object target)
		{
			return null;
		}
	}
}
