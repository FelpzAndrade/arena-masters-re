using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x200071F")]
	public class XDecoration : XLevelDataEntity
	{
		[Token(Token = "0x6003AC7")]
		[Address(RVA = "0x202A3E0", Offset = "0x202A3E0", VA = "0x202A3E0")]
		public XDecoration()
		{
		}

		[Token(Token = "0x6003AC8")]
		[Address(RVA = "0x202A3E8", Offset = "0x202A3E8", VA = "0x202A3E8", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003AC9")]
		[Address(RVA = "0x202A474", Offset = "0x202A474", VA = "0x202A474", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}
	}
}
