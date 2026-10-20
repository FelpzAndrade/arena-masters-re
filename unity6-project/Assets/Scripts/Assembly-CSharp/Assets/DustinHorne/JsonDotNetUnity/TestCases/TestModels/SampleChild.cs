using System.Collections.Generic;
using Il2CppDummyDll;

namespace Assets.DustinHorne.JsonDotNetUnity.TestCases.TestModels
{
	[Token(Token = "0x2000096")]
	public class SampleChild : SampleBase
	{
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x1C")]
		private List<SimpleClassObject> ObjectList__BackingField;

		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, SimpleClassObject> ObjectDictionary__BackingField;

		[Token(Token = "0x17000097")]
		public List<SimpleClassObject> ObjectList
		{
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x20BD5B8", Offset = "0x20BD5B8", VA = "0x20BD5B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x20BD5B0", Offset = "0x20BD5B0", VA = "0x20BD5B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public Dictionary<int, SimpleClassObject> ObjectDictionary
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x20BD5A8", Offset = "0x20BD5A8", VA = "0x20BD5A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x20BD2C0", Offset = "0x20BD2C0", VA = "0x20BD2C0")]
			set
			{
			}
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x20BD2B8", Offset = "0x20BD2B8", VA = "0x20BD2B8")]
		public SampleChild()
		{
		}
	}
}
