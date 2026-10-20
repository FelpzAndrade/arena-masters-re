using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x200072A")]
	public class XLevelSpawnable : XLevelDataEntity
	{
		[Token(Token = "0x40021E8")]
		[FieldOffset(Offset = "0xC")]
		public float delay;

		[Token(Token = "0x1700082E")]
		public override bool IsLeaf
		{
			[Token(Token = "0x6003AEC")]
			[Address(RVA = "0x20318CC", Offset = "0x20318CC", VA = "0x20318CC", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6003AEA")]
		[Address(RVA = "0x202AC9C", Offset = "0x202AC9C", VA = "0x202AC9C")]
		public XLevelSpawnable()
		{
		}

		[Token(Token = "0x6003AEB")]
		[Address(RVA = "0x2031844", Offset = "0x2031844", VA = "0x2031844", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003AED")]
		[Address(RVA = "0x202AE7C", Offset = "0x202AE7C", VA = "0x202AE7C", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}
	}
}
