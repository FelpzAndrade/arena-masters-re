using System;
using System.Reflection;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x200013B")]
	internal class LateBoundMetadataTypeAttribute : IMetadataTypeAttribute
	{
		[Token(Token = "0x4000534")]
		[FieldOffset(Offset = "0x0")]
		private static PropertyInfo _metadataClassTypeProperty;

		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x8")]
		private readonly object _attribute;

		[Token(Token = "0x1700020D")]
		public Type MetadataClassType
		{
			[Token(Token = "0x6000C2A")]
			[Address(RVA = "0x1191964", Offset = "0x1191964", VA = "0x1191964", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x119162C", Offset = "0x119162C", VA = "0x119162C")]
		public LateBoundMetadataTypeAttribute(object attribute)
		{
		}
	}
}
