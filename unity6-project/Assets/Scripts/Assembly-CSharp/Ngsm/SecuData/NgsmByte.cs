using Il2CppDummyDll;

namespace Ngsm.SecuData
{
	[Token(Token = "0x20010BA")]
	public class NgsmByte : NgsmSecuData<byte>
	{
		[Token(Token = "0x6007E36")]
		[Address(RVA = "0x11A3F68", Offset = "0x11A3F68", VA = "0x11A3F68")]
		public NgsmByte()
		{
		}

		[Token(Token = "0x6007E37")]
		[Address(RVA = "0x11A3FF0", Offset = "0x11A3FF0", VA = "0x11A3FF0", Slot = "4")]
		public override byte GetData()
		{
			return default(byte);
		}

		[Token(Token = "0x6007E38")]
		[Address(RVA = "0x11A40B8", Offset = "0x11A40B8", VA = "0x11A40B8", Slot = "5")]
		public override bool SetData(byte data)
		{
			return default(bool);
		}

		[Token(Token = "0x6007E39")]
		[Address(RVA = "0x11A4190", Offset = "0x11A4190", VA = "0x11A4190", Slot = "6")]
		public override bool AddData(byte data)
		{
			return default(bool);
		}

		[Token(Token = "0x6007E3A")]
		[Address(RVA = "0x11A4268", Offset = "0x11A4268", VA = "0x11A4268", Slot = "7")]
		public override bool SubData(byte data)
		{
			return default(bool);
		}
	}
}
