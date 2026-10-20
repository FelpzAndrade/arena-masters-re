using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000120")]
	public class DefaultSerializationBinder : SerializationBinder
	{
		[Token(Token = "0x2000121")]
		internal struct TypeNameKey
		{
			[Token(Token = "0x40004D4")]
			[FieldOffset(Offset = "0x0")]
			internal readonly string AssemblyName;

			[Token(Token = "0x40004D5")]
			[FieldOffset(Offset = "0x4")]
			internal readonly string TypeName;

			[Token(Token = "0x6000B07")]
			[Address(RVA = "0xFBEAEC", Offset = "0xFBEAEC", VA = "0xFBEAEC")]
			public TypeNameKey(string assemblyName, string typeName)
			{
				this = default;
			}

			[Token(Token = "0x6000B08")]
			[Address(RVA = "0xFBEB44", Offset = "0xFBEB44", VA = "0xFBEB44", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000B09")]
			[Address(RVA = "0xFBED0C", Offset = "0xFBED0C", VA = "0xFBED0C", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0xFBED14", Offset = "0xFBED14", VA = "0xFBED14")]
			public bool Equals(TypeNameKey other)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40004D2")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly DefaultSerializationBinder Instance;

		[Token(Token = "0x40004D3")]
		[FieldOffset(Offset = "0x8")]
		private readonly ThreadSafeStore<TypeNameKey, Type> _typeCache;

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0xFBE4C8", Offset = "0xFBE4C8", VA = "0xFBE4C8")]
		public DefaultSerializationBinder()
		{
		}

		[Token(Token = "0x6000B05")]
		[Address(RVA = "0xFBE650", Offset = "0xFBE650", VA = "0xFBE650")]
		private static Type GetTypeFromTypeNameKey(TypeNameKey typeNameKey)
		{
			return null;
		}

		[Token(Token = "0x6000B06")]
		[Address(RVA = "0xFBEA44", Offset = "0xFBEA44", VA = "0xFBEA44", Slot = "4")]
		public override Type BindToType(string assemblyName, string typeName)
		{
			return null;
		}
	}
}
