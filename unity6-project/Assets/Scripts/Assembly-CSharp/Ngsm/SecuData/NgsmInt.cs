using Il2CppDummyDll;

namespace Ngsm.SecuData
{
	[Token(Token = "0x20010BD")]
	public class NgsmInt : NgsmSecuData<int>
	{
		[Token(Token = "0x6007E45")]
		[Address(RVA = "0x11A4AF8", Offset = "0x11A4AF8", VA = "0x11A4AF8")]
		public NgsmInt()
		{
		}

		[Token(Token = "0x6007E46")]
		[Address(RVA = "0x11A4B80", Offset = "0x11A4B80", VA = "0x11A4B80", Slot = "4")]
		public override int GetData()
		{
			return default(int);
		}

		[Token(Token = "0x6007E47")]
		[Address(RVA = "0x11A4C44", Offset = "0x11A4C44", VA = "0x11A4C44", Slot = "5")]
		public override bool SetData(int data)
		{
			return default(bool);
		}

		[Token(Token = "0x6007E48")]
		[Address(RVA = "0x11A4D1C", Offset = "0x11A4D1C", VA = "0x11A4D1C", Slot = "6")]
		public override bool AddData(int data)
		{
			return default(bool);
		}

		[Token(Token = "0x6007E49")]
		[Address(RVA = "0x11A4DF4", Offset = "0x11A4DF4", VA = "0x11A4DF4", Slot = "7")]
		public override bool SubData(int data)
		{
			return default(bool);
		}
	}
}
