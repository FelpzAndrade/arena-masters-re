using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000994")]
	public class NetData_Record
	{
		[Token(Token = "0x4002F46")]
		[FieldOffset(Offset = "0x8")]
		public string aid;

		[Token(Token = "0x4002F47")]
		[FieldOffset(Offset = "0xC")]
		public string nickname;

		[Token(Token = "0x4002F48")]
		[FieldOffset(Offset = "0x10")]
		public string countryCode;

		[Token(Token = "0x4002F49")]
		[FieldOffset(Offset = "0x14")]
		public CSPlayerState lastState;

		[Token(Token = "0x4002F4A")]
		[FieldOffset(Offset = "0x18")]
		public bool escaped;

		[Token(Token = "0x4002F4B")]
		[FieldOffset(Offset = "0x1A")]
		public short level;

		[Token(Token = "0x4002F4C")]
		[FieldOffset(Offset = "0x1C")]
		public bool mine;

		[Token(Token = "0x4002F4D")]
		[FieldOffset(Offset = "0x1D")]
		public bool host;

		[Token(Token = "0x4002F4E")]
		[FieldOffset(Offset = "0x1E")]
		public short hitCount;

		[Token(Token = "0x4002F4F")]
		[FieldOffset(Offset = "0x20")]
		public short killCount;

		[Token(Token = "0x4002F50")]
		[FieldOffset(Offset = "0x22")]
		public short deathCount;

		[Token(Token = "0x4002F51")]
		[FieldOffset(Offset = "0x24")]
		public short assistCount;

		[Token(Token = "0x4002F52")]
		[FieldOffset(Offset = "0x26")]
		public short killZombieCount;

		[Token(Token = "0x4002F53")]
		[FieldOffset(Offset = "0x28")]
		public short tagZombieToHumanCount;

		[Token(Token = "0x4002F54")]
		[FieldOffset(Offset = "0x2A")]
		public short zombieInfectCnt;

		[Token(Token = "0x4002F55")]
		[FieldOffset(Offset = "0x2C")]
		public short param1;

		[Token(Token = "0x4002F56")]
		[FieldOffset(Offset = "0x2E")]
		public short param2;

		[Token(Token = "0x4002F57")]
		[FieldOffset(Offset = "0x30")]
		public short boxCount;

		[Token(Token = "0x4002F58")]
		[FieldOffset(Offset = "0x32")]
		public short getItem;

		[Token(Token = "0x4002F59")]
		[FieldOffset(Offset = "0x34")]
		public short hpRatio;

		[Token(Token = "0x4002F5A")]
		[FieldOffset(Offset = "0x38")]
		public int earnGold;

		[Token(Token = "0x4002F5B")]
		[FieldOffset(Offset = "0x3C")]
		public short team;

		[Token(Token = "0x4002F5C")]
		[FieldOffset(Offset = "0x3E")]
		public short stayAsHuman;

		[Token(Token = "0x4002F5D")]
		[FieldOffset(Offset = "0x40")]
		public short elo;

		[Token(Token = "0x4002F5E")]
		[FieldOffset(Offset = "0x42")]
		public short gameState;

		[Token(Token = "0x4002F5F")]
		[FieldOffset(Offset = "0x44")]
		public short roundResult_0;

		[Token(Token = "0x4002F60")]
		[FieldOffset(Offset = "0x46")]
		public short roundResult_1;

		[Token(Token = "0x4002F61")]
		[FieldOffset(Offset = "0x48")]
		public short roundResult_2;

		[Token(Token = "0x4002F62")]
		[FieldOffset(Offset = "0x4A")]
		public short roundResult_3;

		[Token(Token = "0x4002F63")]
		[FieldOffset(Offset = "0x4C")]
		public short roundResult_4;

		[Token(Token = "0x4002F64")]
		[FieldOffset(Offset = "0x50")]
		public float hp;

		[Token(Token = "0x4002F65")]
		[FieldOffset(Offset = "0x54")]
		public float ultCharge;

		[Token(Token = "0x6004CD1")]
		[Address(RVA = "0x2340498", Offset = "0x2340498", VA = "0x2340498")]
		public NetData_Record()
		{
		}

		[Token(Token = "0x6004CD2")]
		[Address(RVA = "0x23404A0", Offset = "0x23404A0", VA = "0x23404A0")]
		public void ReserveFullHP()
		{
		}
	}
}
