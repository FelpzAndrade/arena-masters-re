using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000166")]
	internal abstract class ReflectionDelegateFactory
	{
		[Token(Token = "0x6000D39")]
		[Address(RVA = "0x119BB7C", Offset = "0x119BB7C", VA = "0x119BB7C")]
		protected ReflectionDelegateFactory()
		{
		}

		[Token(Token = "0x6000D3A")]
		public Func<T, object> CreateGet<T>(MemberInfo memberInfo)
		{
			return null;
		}

		[Token(Token = "0x6000D3B")]
		public Action<T, object> CreateSet<T>(MemberInfo memberInfo)
		{
			return null;
		}

		[Token(Token = "0x6000D3C")]
		public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method);

		[Token(Token = "0x6000D3D")]
		public abstract Func<T> CreateDefaultConstructor<T>(Type type);

		[Token(Token = "0x6000D3E")]
		public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);

		[Token(Token = "0x6000D3F")]
		public abstract Func<T, object> CreateGet<T>(FieldInfo fieldInfo);

		[Token(Token = "0x6000D40")]
		public abstract Action<T, object> CreateSet<T>(FieldInfo fieldInfo);

		[Token(Token = "0x6000D41")]
		public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);
	}
}
