using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008D1")]
	public abstract class CSFileLoaderBase
	{
		protected CSFileLoaderBase()
		{
		}

		[Token(Token = "0x4002AED")]
		[FieldOffset(Offset = "0x8")]
		private string Filename__BackingField;

		[Token(Token = "0x17000992")]
		public string Filename
		{
			[Token(Token = "0x600471F")]
			[Address(RVA = "0x222EB98", Offset = "0x222EB98", VA = "0x222EB98")]
			get
			{
				return Filename__BackingField;
			}
			[Token(Token = "0x6004720")]
			[Address(RVA = "0x222EF48", Offset = "0x222EF48", VA = "0x222EF48")]
			private set
			{
				Filename__BackingField = value;
			}
		}

		[Token(Token = "0x600471E")]
		[Address(RVA = "0x222E9C0", Offset = "0x222E9C0", VA = "0x222E9C0")]
		public CSFileLoaderBase(string filename)
		{
			Filename = filename;
		}

		[Token(Token = "0x6004721")]
		public abstract string Load();
	}
}
