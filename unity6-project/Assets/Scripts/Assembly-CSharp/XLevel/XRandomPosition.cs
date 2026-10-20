using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x200072C")]
	public class XRandomPosition : XLevelDataEntity
	{
		[Token(Token = "0x40021EC")]
		[FieldOffset(Offset = "0xC")]
		public float innerRadius;

		[Token(Token = "0x6003AF2")]
		[Address(RVA = "0x2032C04", Offset = "0x2032C04", VA = "0x2032C04")]
		public XRandomPosition()
		{
		}

		[Token(Token = "0x6003AF3")]
		[Address(RVA = "0x2032C0C", Offset = "0x2032C0C", VA = "0x2032C0C", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003AF4")]
		[Address(RVA = "0x2032C98", Offset = "0x2032C98", VA = "0x2032C98", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}

		[Token(Token = "0x6003AF5")]
		[Address(RVA = "0x2032E34", Offset = "0x2032E34", VA = "0x2032E34")]
		private void OnDrawGizmos()
		{
		}
	}
}
