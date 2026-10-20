using Il2CppDummyDll;

namespace Ngsm.SecuData
{
	[Token(Token = "0x20010BB")]
	public class NgsmDouble : NgsmSecuData<double>
	{
		[Token(Token = "0x6007E3B")]
		[Address(RVA = "0x11A4340", Offset = "0x11A4340", VA = "0x11A4340")]
		public NgsmDouble()
		{
		}

		[Token(Token = "0x6007E3C")]
		[Address(RVA = "0x11A43C8", Offset = "0x11A43C8", VA = "0x11A43C8", Slot = "4")]
		public override double GetData()
		{
			return default(double);
		}

		[Token(Token = "0x6007E3D")]
		[Address(RVA = "0x11A4494", Offset = "0x11A4494", VA = "0x11A4494", Slot = "5")]
		public override bool SetData(double data)
		{
			return default(bool);
		}

		[Token(Token = "0x6007E3E")]
		[Address(RVA = "0x11A4570", Offset = "0x11A4570", VA = "0x11A4570", Slot = "6")]
		public override bool AddData(double data)
		{
			return default(bool);
		}

		[Token(Token = "0x6007E3F")]
		[Address(RVA = "0x11A464C", Offset = "0x11A464C", VA = "0x11A464C", Slot = "7")]
		public override bool SubData(double data)
		{
			return default(bool);
		}
	}
}
