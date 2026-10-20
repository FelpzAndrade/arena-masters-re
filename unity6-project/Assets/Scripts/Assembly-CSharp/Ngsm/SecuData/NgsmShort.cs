using Il2CppDummyDll;

namespace Ngsm.SecuData
{
	[Token(Token = "0x20010C1")]
	public class NgsmShort : NgsmSecuData<short>
	{
		[Token(Token = "0x6007E58")]
		[Address(RVA = "0x11A52B4", Offset = "0x11A52B4", VA = "0x11A52B4")]
		public NgsmShort()
		{
		}

		[Token(Token = "0x6007E59")]
		[Address(RVA = "0x11A533C", Offset = "0x11A533C", VA = "0x11A533C", Slot = "4")]
		public override short GetData()
		{
			return default(short);
		}

		[Token(Token = "0x6007E5A")]
		[Address(RVA = "0x11A5404", Offset = "0x11A5404", VA = "0x11A5404", Slot = "5")]
		public override bool SetData(short data)
		{
			return default(bool);
		}

		[Token(Token = "0x6007E5B")]
		[Address(RVA = "0x11A54DC", Offset = "0x11A54DC", VA = "0x11A54DC", Slot = "6")]
		public override bool AddData(short data)
		{
			return default(bool);
		}

		[Token(Token = "0x6007E5C")]
		[Address(RVA = "0x11A55B4", Offset = "0x11A55B4", VA = "0x11A55B4", Slot = "7")]
		public override bool SubData(short data)
		{
			return default(bool);
		}
	}
}
