using Il2CppDummyDll;
using UnityEngine;

namespace Assets.DustinHorne.JsonDotNetUnity.TestCases.TestModels
{
	[Token(Token = "0x2000099")]
	public class SimpleClassObject
	{
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x8")]
		private string TextValue__BackingField;

		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0xC")]
		private int NumberValue__BackingField;

		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x10")]
		private Vector3 VectorValue__BackingField;

		[Token(Token = "0x170000A0")]
		public string TextValue
		{
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x20BD608", Offset = "0x20BD608", VA = "0x20BD608")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x20BD5C8", Offset = "0x20BD5C8", VA = "0x20BD5C8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public int NumberValue
		{
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x20BD610", Offset = "0x20BD610", VA = "0x20BD610")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x20BD5D0", Offset = "0x20BD5D0", VA = "0x20BD5D0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public Vector3 VectorValue
		{
			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x20BD618", Offset = "0x20BD618", VA = "0x20BD618")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x20BD5D8", Offset = "0x20BD5D8", VA = "0x20BD5D8")]
			set
			{
			}
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x20BD5C0", Offset = "0x20BD5C0", VA = "0x20BD5C0")]
		public SimpleClassObject()
		{
		}
	}
}
