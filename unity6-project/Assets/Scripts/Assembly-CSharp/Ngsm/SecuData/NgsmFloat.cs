using Il2CppDummyDll;

namespace Ngsm.SecuData
{
	[Token(Token = "0x20010BC")]
	public class NgsmFloat : NgsmSecuData<float>
	{
		[Token(Token = "0x6007E40")]
		[Address(RVA = "0x11A4728", Offset = "0x11A4728", VA = "0x11A4728")]
		public NgsmFloat()
		{
		}

		[Token(Token = "0x6007E41")]
		[Address(RVA = "0x11A47B0", Offset = "0x11A47B0", VA = "0x11A47B0", Slot = "4")]
		public override float GetData()
		{
			return default(float);
		}

		[Token(Token = "0x6007E42")]
		[Address(RVA = "0x11A487C", Offset = "0x11A487C", VA = "0x11A487C", Slot = "5")]
		public override bool SetData(float data)
		{
			return default(bool);
		}

		[Token(Token = "0x6007E43")]
		[Address(RVA = "0x11A4950", Offset = "0x11A4950", VA = "0x11A4950", Slot = "6")]
		public override bool AddData(float data)
		{
			return default(bool);
		}

		[Token(Token = "0x6007E44")]
		[Address(RVA = "0x11A4A24", Offset = "0x11A4A24", VA = "0x11A4A24", Slot = "7")]
		public override bool SubData(float data)
		{
			return default(bool);
		}
	}
}
