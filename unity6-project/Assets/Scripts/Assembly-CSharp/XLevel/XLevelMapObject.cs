using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x20006FA")]
	public class XLevelMapObject : XLevelObject
	{
		[Token(Token = "0x6003A62")]
		[Address(RVA = "0x2031560", Offset = "0x2031560", VA = "0x2031560")]
		public XLevelMapObject()
		{
		}

		[Token(Token = "0x6003A63")]
		[Address(RVA = "0x2031568", Offset = "0x2031568", VA = "0x2031568", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003A64")]
		[Address(RVA = "0x20315FC", Offset = "0x20315FC", VA = "0x20315FC", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}
	}
}
