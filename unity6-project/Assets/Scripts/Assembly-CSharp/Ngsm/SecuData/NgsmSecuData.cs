using Il2CppDummyDll;
using Ngsm.SecuData.Internal;

namespace Ngsm.SecuData
{
	[Token(Token = "0x20010C0")]
	public abstract class NgsmSecuData<T>
	{
		[Token(Token = "0x4005C79")]
		protected const int INVALID_SECU_KEY = 0;

		[Token(Token = "0x4005C7A")]
		[FieldOffset(Offset = "0x0")]
		protected int m_shandle;

		[Token(Token = "0x4005C7B")]
		[FieldOffset(Offset = "0x0")]
		private static ISecuData secudata;

		[Token(Token = "0x17000F72")]
		protected static ISecuData SecuDataImpl
		{
			[Token(Token = "0x6007E57")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007E4F")]
		protected NgsmSecuData()
		{
		}

		[Token(Token = "0x6007E50")]
		protected NgsmSecuData(EUnityDataType eUnityDataType)
		{
		}

		[Token(Token = "0x6007E51")]
		public abstract T GetData();

		[Token(Token = "0x6007E52")]
		public abstract bool SetData(T data);

		[Token(Token = "0x6007E53")]
		public abstract bool AddData(T data);

		[Token(Token = "0x6007E54")]
		public abstract bool SubData(T data);

		[Token(Token = "0x6007E55")]
		public void ReleaseData()
		{
		}

		[Token(Token = "0x6007E56")]
		protected void Dispose()
		{
		}
	}
}
