using System;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace XLevel
{
	[Token(Token = "0x20006F9")]
	public class LevelActorData : LevelObjectData
	{
		[Token(Token = "0x400215F")]
		[FieldOffset(Offset = "0x40")]
		public float sightRange;

		[Token(Token = "0x4002160")]
		[FieldOffset(Offset = "0x44")]
		public ActorType actorType;

		[Token(Token = "0x4002161")]
		[FieldOffset(Offset = "0x48")]
		public XTeamEnum team;

		[Token(Token = "0x4002162")]
		[FieldOffset(Offset = "0x4C")]
		public string actionEntitiyTag;

		[Token(Token = "0x4002163")]
		[FieldOffset(Offset = "0x50")]
		public Tendency tendency;

		[Token(Token = "0x4002164")]
		[FieldOffset(Offset = "0x54")]
		[JsonIgnore]
		public int level;

		[Token(Token = "0x4002165")]
		[FieldOffset(Offset = "0x58")]
		[JsonIgnore]
		public ushort groupUID;

		[Token(Token = "0x6003A5F")]
		[Address(RVA = "0x201D7C8", Offset = "0x201D7C8", VA = "0x201D7C8")]
		public LevelActorData()
		{
		}

		[Token(Token = "0x6003A60")]
		[Address(RVA = "0x201D7E0", Offset = "0x201D7E0", VA = "0x201D7E0", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}

		[Token(Token = "0x6003A61")]
		[Address(RVA = "0x201D89C", Offset = "0x201D89C", VA = "0x201D89C", Slot = "5")]
		protected override void PushDataToComponent(XLevelDataEntity comp)
		{
		}
	}
}
