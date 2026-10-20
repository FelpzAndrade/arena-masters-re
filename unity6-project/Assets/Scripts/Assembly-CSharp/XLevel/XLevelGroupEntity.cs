using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x2000728")]
	public class XLevelGroupEntity : XLevelDataEntity
	{
		[Token(Token = "0x1700082D")]
		public override bool IsLeaf
		{
			[Token(Token = "0x6003AE4")]
			[Address(RVA = "0x202D628", Offset = "0x202D628", VA = "0x202D628", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6003AE2")]
		[Address(RVA = "0x202D594", Offset = "0x202D594", VA = "0x202D594")]
		public XLevelGroupEntity()
		{
		}

		[Token(Token = "0x6003AE3")]
		[Address(RVA = "0x202D59C", Offset = "0x202D59C", VA = "0x202D59C", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003AE5")]
		[Address(RVA = "0x202D630", Offset = "0x202D630", VA = "0x202D630", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}
	}
}
