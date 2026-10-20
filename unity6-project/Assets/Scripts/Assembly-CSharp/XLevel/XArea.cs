using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x200071C")]
	public class XArea : XLevelDataEntity
	{
		[Token(Token = "0x6003ABC")]
		[Address(RVA = "0x20203DC", Offset = "0x20203DC", VA = "0x20203DC")]
		public XArea()
		{
		}

		[Token(Token = "0x6003ABD")]
		[Address(RVA = "0x20203EC", Offset = "0x20203EC", VA = "0x20203EC", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003ABE")]
		[Address(RVA = "0x2020478", Offset = "0x2020478", VA = "0x2020478", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}
	}
}
