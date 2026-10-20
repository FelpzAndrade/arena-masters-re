using Il2CppDummyDll;

namespace Ngsm.SecuData
{
	[Token(Token = "0x20010BE")]
	public class NgsmInt64 : NgsmSecuData<long>
	{
		[Token(Token = "0x6007E4A")]
		[Address(RVA = "0x11A4ECC", Offset = "0x11A4ECC", VA = "0x11A4ECC")]
		public NgsmInt64()
		{
		}

		[Token(Token = "0x6007E4B")]
		[Address(RVA = "0x11A4F54", Offset = "0x11A4F54", VA = "0x11A4F54", Slot = "4")]
		public override long GetData()
		{
			return default(long);
		}

		[Token(Token = "0x6007E4C")]
		[Address(RVA = "0x11A5020", Offset = "0x11A5020", VA = "0x11A5020", Slot = "5")]
		public override bool SetData(long data)
		{
			return default(bool);
		}

		[Token(Token = "0x6007E4D")]
		[Address(RVA = "0x11A50FC", Offset = "0x11A50FC", VA = "0x11A50FC", Slot = "6")]
		public override bool AddData(long data)
		{
			return default(bool);
		}

		[Token(Token = "0x6007E4E")]
		[Address(RVA = "0x11A51D8", Offset = "0x11A51D8", VA = "0x11A51D8", Slot = "7")]
		public override bool SubData(long data)
		{
			return default(bool);
		}
	}
}
