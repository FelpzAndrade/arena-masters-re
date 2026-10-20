using CS;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x20006F8")]
	public class XLevelActor : XLevelObject
	{
		[Token(Token = "0x400215A")]
		[FieldOffset(Offset = "0x18")]
		public float sightRange;

		[Token(Token = "0x400215B")]
		[FieldOffset(Offset = "0x1C")]
		public ActorType actorType;

		[Token(Token = "0x400215C")]
		[FieldOffset(Offset = "0x20")]
		public XTeamEnum team;

		[Token(Token = "0x400215D")]
		[FieldOffset(Offset = "0x24")]
		public string actionEntitiyTag;

		[Token(Token = "0x400215E")]
		[FieldOffset(Offset = "0x28")]
		public Tendency tendency;

		[Token(Token = "0x6003A5C")]
		[Address(RVA = "0x202AF50", Offset = "0x202AF50", VA = "0x202AF50")]
		public XLevelActor()
		{
		}

		[Token(Token = "0x6003A5D")]
		[Address(RVA = "0x202AF68", Offset = "0x202AF68", VA = "0x202AF68", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003A5E")]
		[Address(RVA = "0x202B004", Offset = "0x202B004", VA = "0x202B004", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}
	}
}
