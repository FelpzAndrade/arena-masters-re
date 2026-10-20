using Il2CppDummyDll;
using UnityEngine;

namespace Assets.DustinHorne.JsonDotNetUnity.TestCases.TestModels
{
	[Token(Token = "0x2000095")]
	public class SampleBase
	{
		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x8")]
		private string TextValue__BackingField;

		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0xC")]
		private int NumberValue__BackingField;

		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x10")]
		private Vector3 VectorValue__BackingField;

		[Token(Token = "0x17000094")]
		public string TextValue
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x20BD5E4", Offset = "0x20BD5E4", VA = "0x20BD5E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x20BCE54", Offset = "0x20BCE54", VA = "0x20BCE54")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public int NumberValue
		{
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x20BD5EC", Offset = "0x20BD5EC", VA = "0x20BD5EC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x20BCE5C", Offset = "0x20BCE5C", VA = "0x20BCE5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public Vector3 VectorValue
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x20BD5F4", Offset = "0x20BD5F4", VA = "0x20BD5F4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x20BCE64", Offset = "0x20BCE64", VA = "0x20BCE64")]
			set
			{
			}
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x20BCE4C", Offset = "0x20BCE4C", VA = "0x20BCE4C")]
		public SampleBase()
		{
		}
	}
}
