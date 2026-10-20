using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x2000700")]
	public class XActionEntityTrigger : XTimeTrigger
	{
		[Token(Token = "0x400216D")]
		[FieldOffset(Offset = "0x20")]
		public string targetActionEntity;

		[Token(Token = "0x6003A74")]
		[Address(RVA = "0x201FE64", Offset = "0x201FE64", VA = "0x201FE64")]
		public XActionEntityTrigger()
		{
		}

		[Token(Token = "0x6003A75")]
		[Address(RVA = "0x201FE74", Offset = "0x201FE74", VA = "0x201FE74", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003A76")]
		[Address(RVA = "0x201FF00", Offset = "0x201FF00", VA = "0x201FF00", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}
	}
}
