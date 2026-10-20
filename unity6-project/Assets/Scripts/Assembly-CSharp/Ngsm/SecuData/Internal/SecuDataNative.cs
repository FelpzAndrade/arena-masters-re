using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Ngsm.SecuData.Internal
{
	[Token(Token = "0x20010B9")]
	public class SecuDataNative : ISecuData
	{
		[Token(Token = "0x6007E18")]
		[Address(RVA = "0x11A2F2C", Offset = "0x11A2F2C", VA = "0x11A2F2C")]
		public SecuDataNative()
		{
		}

		[PreserveSig]
		[Token(Token = "0x6007E19")]
		[Address(RVA = "0x11A2F34", Offset = "0x11A2F34", VA = "0x11A2F34")]
		public static extern long CreateSecuData(int cESecuDataTye);

		[PreserveSig]
		[Token(Token = "0x6007E1A")]
		[Address(RVA = "0x11A3010", Offset = "0x11A3010", VA = "0x11A3010")]
		public static extern void ReleaseSecuData(long sHandle);

		[PreserveSig]
		[Token(Token = "0x6007E1B")]
		[Address(RVA = "0x11A30F8", Offset = "0x11A30F8", VA = "0x11A30F8")]
		public static extern void ReleaseSecuDataAll();

		[PreserveSig]
		[Token(Token = "0x6007E1C")]
		[Address(RVA = "0x11A31C8", Offset = "0x11A31C8", VA = "0x11A31C8")]
		public static extern bool SetSecuData(long sHandle, long cSecuValue);

		[PreserveSig]
		[Token(Token = "0x6007E1D")]
		[Address(RVA = "0x11A32C0", Offset = "0x11A32C0", VA = "0x11A32C0")]
		public static extern long GetSecuData(long sHandle);

		[PreserveSig]
		[Token(Token = "0x6007E1E")]
		[Address(RVA = "0x11A33A8", Offset = "0x11A33A8", VA = "0x11A33A8")]
		public static extern bool AddSecuData(long sHandle, long cSecuValue);

		[PreserveSig]
		[Token(Token = "0x6007E1F")]
		[Address(RVA = "0x11A34A0", Offset = "0x11A34A0", VA = "0x11A34A0")]
		public static extern bool SubSecuData(long sHandle, long cSecuValue);

		[PreserveSig]
		[Token(Token = "0x6007E20")]
		[Address(RVA = "0x11A3598", Offset = "0x11A3598", VA = "0x11A3598")]
		public static extern bool SetSecuDataFloat(long sHandle, float cSecuValue);

		[PreserveSig]
		[Token(Token = "0x6007E21")]
		[Address(RVA = "0x11A3690", Offset = "0x11A3690", VA = "0x11A3690")]
		public static extern float GetSecuDataFloat(long sHandle);

		[PreserveSig]
		[Token(Token = "0x6007E22")]
		[Address(RVA = "0x11A3778", Offset = "0x11A3778", VA = "0x11A3778")]
		public static extern bool AddSecuDataFloat(long sHandle, float cSecuValue);

		[PreserveSig]
		[Token(Token = "0x6007E23")]
		[Address(RVA = "0x11A3870", Offset = "0x11A3870", VA = "0x11A3870")]
		public static extern bool SubSecuDataFloat(long sHandle, float cSecuValue);

		[PreserveSig]
		[Token(Token = "0x6007E24")]
		[Address(RVA = "0x11A3968", Offset = "0x11A3968", VA = "0x11A3968")]
		public static extern bool SetSecuDataDouble(long sHandle, double cSecuValue);

		[PreserveSig]
		[Token(Token = "0x6007E25")]
		[Address(RVA = "0x11A3A60", Offset = "0x11A3A60", VA = "0x11A3A60")]
		public static extern double GetSecuDataDouble(long sHandle);

		[PreserveSig]
		[Token(Token = "0x6007E26")]
		[Address(RVA = "0x11A3B48", Offset = "0x11A3B48", VA = "0x11A3B48")]
		public static extern bool AddSecuDataDouble(long sHandle, double cSecuValue);

		[PreserveSig]
		[Token(Token = "0x6007E27")]
		[Address(RVA = "0x11A3C40", Offset = "0x11A3C40", VA = "0x11A3C40")]
		public static extern bool SubSecuDataDouble(long sHandle, double cSecuValue);

		[Token(Token = "0x6007E28")]
		[Address(RVA = "0x11A3D38", Offset = "0x11A3D38", VA = "0x11A3D38", Slot = "4")]
		public override bool CreateSecuDataType(EUnityDataType eSecuDataType)
		{
			return default(bool);
		}

		[Token(Token = "0x6007E29")]
		[Address(RVA = "0x11A3D58", Offset = "0x11A3D58", VA = "0x11A3D58", Slot = "5")]
		public override void ReleaseSecuDataType()
		{
		}

		[Token(Token = "0x6007E2A")]
		[Address(RVA = "0x11A3D7C", Offset = "0x11A3D7C", VA = "0x11A3D7C", Slot = "6")]
		public override long GetSecuDataType()
		{
			return default(long);
		}

		[Token(Token = "0x6007E2B")]
		[Address(RVA = "0x11A3DA0", Offset = "0x11A3DA0", VA = "0x11A3DA0", Slot = "7")]
		public override bool SetSecuDataType(long data)
		{
			return default(bool);
		}

		[Token(Token = "0x6007E2C")]
		[Address(RVA = "0x11A3DC8", Offset = "0x11A3DC8", VA = "0x11A3DC8", Slot = "8")]
		public override bool AddSecuDataType(long data)
		{
			return default(bool);
		}

		[Token(Token = "0x6007E2D")]
		[Address(RVA = "0x11A3DF0", Offset = "0x11A3DF0", VA = "0x11A3DF0", Slot = "9")]
		public override bool SubSecuDataType(long data)
		{
			return default(bool);
		}

		[Token(Token = "0x6007E2E")]
		[Address(RVA = "0x11A3E18", Offset = "0x11A3E18", VA = "0x11A3E18", Slot = "10")]
		public override float GetSecuDataTypeFloat()
		{
			return default(float);
		}

		[Token(Token = "0x6007E2F")]
		[Address(RVA = "0x11A3E3C", Offset = "0x11A3E3C", VA = "0x11A3E3C", Slot = "11")]
		public override bool SetSecuDataTypeFloat(float data)
		{
			return default(bool);
		}

		[Token(Token = "0x6007E30")]
		[Address(RVA = "0x11A3E64", Offset = "0x11A3E64", VA = "0x11A3E64", Slot = "12")]
		public override bool AddSecuDataTypeFloat(float data)
		{
			return default(bool);
		}

		[Token(Token = "0x6007E31")]
		[Address(RVA = "0x11A3E8C", Offset = "0x11A3E8C", VA = "0x11A3E8C", Slot = "13")]
		public override bool SubSecuDataTypeFloat(float data)
		{
			return default(bool);
		}

		[Token(Token = "0x6007E32")]
		[Address(RVA = "0x11A3EB4", Offset = "0x11A3EB4", VA = "0x11A3EB4", Slot = "14")]
		public override double GetSecuDataTypeDouble()
		{
			return default(double);
		}

		[Token(Token = "0x6007E33")]
		[Address(RVA = "0x11A3ED8", Offset = "0x11A3ED8", VA = "0x11A3ED8", Slot = "15")]
		public override bool SetSecuDataTypeDouble(double data)
		{
			return default(bool);
		}

		[Token(Token = "0x6007E34")]
		[Address(RVA = "0x11A3F08", Offset = "0x11A3F08", VA = "0x11A3F08", Slot = "16")]
		public override bool AddSecuDataTypeDouble(double data)
		{
			return default(bool);
		}

		[Token(Token = "0x6007E35")]
		[Address(RVA = "0x11A3F38", Offset = "0x11A3F38", VA = "0x11A3F38", Slot = "17")]
		public override bool SubSecuDataTypeDouble(double data)
		{
			return default(bool);
		}
	}
}
