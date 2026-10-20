using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x20006FE")]
	public class XLevelTransform : XLevelSpawnable
	{
		[Token(Token = "0x6003A6E")]
		[Address(RVA = "0x2031674", Offset = "0x2031674", VA = "0x2031674")]
		public XLevelTransform()
		{
		}

		[Token(Token = "0x6003A6F")]
		[Address(RVA = "0x20318D4", Offset = "0x20318D4", VA = "0x20318D4", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003A70")]
		[Address(RVA = "0x2031704", Offset = "0x2031704", VA = "0x2031704", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}
	}
}
