using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200015B")]
	internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory
	{
		[Token(Token = "0x200015C")]
		private sealed class _003CCreateMethodCall_003Ec__AnonStoreyD8<T>
		{
			[Token(Token = "0x4000570")]
			[FieldOffset(Offset = "0x0")]
			internal ConstructorInfo c;

			[Token(Token = "0x4000571")]
			[FieldOffset(Offset = "0x0")]
			internal MethodBase method;

			[Token(Token = "0x6000D05")]
			public _003CCreateMethodCall_003Ec__AnonStoreyD8()
			{
			}

			[Token(Token = "0x6000D06")]
			internal object _003C_003Em__63(T o, object[] a)
			{
				return null;
			}

			[Token(Token = "0x6000D07")]
			internal object _003C_003Em__64(T o, object[] a)
			{
				return null;
			}
		}

		[Token(Token = "0x200015D")]
		private sealed class _003CCreateDefaultConstructor_003Ec__AnonStoreyD9<T>
		{
			[Token(Token = "0x4000572")]
			[FieldOffset(Offset = "0x0")]
			internal Type type;

			[Token(Token = "0x4000573")]
			[FieldOffset(Offset = "0x0")]
			internal ConstructorInfo constructorInfo;

			[Token(Token = "0x6000D08")]
			public _003CCreateDefaultConstructor_003Ec__AnonStoreyD9()
			{
			}

			[Token(Token = "0x6000D09")]
			internal T _003C_003Em__65()
			{
				return (T)default;
			}

			[Token(Token = "0x6000D0A")]
			internal T _003C_003Em__66()
			{
				return (T)default;
			}
		}

		[Token(Token = "0x200015E")]
		private sealed class _003CCreateGet_003Ec__AnonStoreyDA<T>
		{
			[Token(Token = "0x4000574")]
			[FieldOffset(Offset = "0x0")]
			internal PropertyInfo propertyInfo;

			[Token(Token = "0x6000D0B")]
			public _003CCreateGet_003Ec__AnonStoreyDA()
			{
			}

			[Token(Token = "0x6000D0C")]
			internal object _003C_003Em__67(T o)
			{
				return null;
			}
		}

		[Token(Token = "0x200015F")]
		private sealed class _003CCreateGet_003Ec__AnonStoreyDB<T>
		{
			[Token(Token = "0x4000575")]
			[FieldOffset(Offset = "0x0")]
			internal FieldInfo fieldInfo;

			[Token(Token = "0x6000D0D")]
			public _003CCreateGet_003Ec__AnonStoreyDB()
			{
			}

			[Token(Token = "0x6000D0E")]
			internal object _003C_003Em__68(T o)
			{
				return null;
			}
		}

		[Token(Token = "0x2000160")]
		private sealed class _003CCreateSet_003Ec__AnonStoreyDC<T>
		{
			[Token(Token = "0x4000576")]
			[FieldOffset(Offset = "0x0")]
			internal FieldInfo fieldInfo;

			[Token(Token = "0x6000D0F")]
			public _003CCreateSet_003Ec__AnonStoreyDC()
			{
			}

			[Token(Token = "0x6000D10")]
			internal void _003C_003Em__69(T o, object v)
			{
			}
		}

		[Token(Token = "0x2000161")]
		private sealed class _003CCreateSet_003Ec__AnonStoreyDD<T>
		{
			[Token(Token = "0x4000577")]
			[FieldOffset(Offset = "0x0")]
			internal PropertyInfo propertyInfo;

			[Token(Token = "0x6000D11")]
			public _003CCreateSet_003Ec__AnonStoreyDD()
			{
			}

			[Token(Token = "0x6000D12")]
			internal void _003C_003Em__6A(T o, object v)
			{
			}
		}

		[Token(Token = "0x400056F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly LateBoundReflectionDelegateFactory _instance;

		[Token(Token = "0x17000233")]
		internal static ReflectionDelegateFactory Instance
		{
			[Token(Token = "0x6000CFE")]
			[Address(RVA = "0x11918B4", Offset = "0x11918B4", VA = "0x11918B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000CFC")]
		[Address(RVA = "0x119BB74", Offset = "0x119BB74", VA = "0x119BB74")]
		public LateBoundReflectionDelegateFactory()
		{
		}

		[Token(Token = "0x6000CFF")]
		public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method)
		{
			return null;
		}

		[Token(Token = "0x6000D00")]
		public override Func<T> CreateDefaultConstructor<T>(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000D01")]
		public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo)
		{
			return null;
		}

		[Token(Token = "0x6000D02")]
		public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo)
		{
			return null;
		}

		[Token(Token = "0x6000D03")]
		public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo)
		{
			return null;
		}

		[Token(Token = "0x6000D04")]
		public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo)
		{
			return null;
		}
	}
}
