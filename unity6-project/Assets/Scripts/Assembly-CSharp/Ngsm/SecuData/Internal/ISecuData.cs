using Il2CppDummyDll;

namespace Ngsm.SecuData.Internal
{
	[Token(Token = "0x20010B8")]
	public abstract class ISecuData
	{
		[Token(Token = "0x4005C73")]
		protected const long INVALID_SECU_KEY = 0L;

		[Token(Token = "0x4005C74")]
		[FieldOffset(Offset = "0x8")]
		protected long m_shandle;

		[Token(Token = "0x6007E09")]
		[Address(RVA = "0x11A2F24", Offset = "0x11A2F24", VA = "0x11A2F24")]
		protected ISecuData()
		{
		}

		[Token(Token = "0x6007E0A")]
		public abstract bool CreateSecuDataType(EUnityDataType eSecuDataType);

		[Token(Token = "0x6007E0B")]
		public abstract void ReleaseSecuDataType();

		[Token(Token = "0x6007E0C")]
		public abstract long GetSecuDataType();

		[Token(Token = "0x6007E0D")]
		public abstract bool SetSecuDataType(long data);

		[Token(Token = "0x6007E0E")]
		public abstract bool AddSecuDataType(long data);

		[Token(Token = "0x6007E0F")]
		public abstract bool SubSecuDataType(long data);

		[Token(Token = "0x6007E10")]
		public abstract float GetSecuDataTypeFloat();

		[Token(Token = "0x6007E11")]
		public abstract bool SetSecuDataTypeFloat(float data);

		[Token(Token = "0x6007E12")]
		public abstract bool AddSecuDataTypeFloat(float data);

		[Token(Token = "0x6007E13")]
		public abstract bool SubSecuDataTypeFloat(float data);

		[Token(Token = "0x6007E14")]
		public abstract double GetSecuDataTypeDouble();

		[Token(Token = "0x6007E15")]
		public abstract bool SetSecuDataTypeDouble(double data);

		[Token(Token = "0x6007E16")]
		public abstract bool AddSecuDataTypeDouble(double data);

		[Token(Token = "0x6007E17")]
		public abstract bool SubSecuDataTypeDouble(double data);
	}
}
