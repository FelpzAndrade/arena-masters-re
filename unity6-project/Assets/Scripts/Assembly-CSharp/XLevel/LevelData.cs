using CS;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace XLevel
{
	[Token(Token = "0x200073D")]
	public class LevelData
	{
		[Token(Token = "0x4002242")]
		[FieldOffset(Offset = "0x8")]
		[JsonIgnore]
		public string levelName;

		[Token(Token = "0x4002243")]
		[FieldOffset(Offset = "0xC")]
		public int sectorID;

		[Token(Token = "0x4002244")]
		[FieldOffset(Offset = "0x10")]
		public MissionPlayPattern playPattern;

		[Token(Token = "0x4002245")]
		[FieldOffset(Offset = "0x14")]
		public string escortTarget;

		[Token(Token = "0x4002246")]
		[FieldOffset(Offset = "0x18")]
		public int areaMaxMonsterCount;

		[Token(Token = "0x4002247")]
		[FieldOffset(Offset = "0x1C")]
		public DecorationData decoration;

		[Token(Token = "0x4002248")]
		[FieldOffset(Offset = "0x20")]
		public AreaData readyArea;

		[Token(Token = "0x4002249")]
		[FieldOffset(Offset = "0x24")]
		public AreaData[] areas;

		[Token(Token = "0x400224A")]
		[FieldOffset(Offset = "0x28")]
		public XVector playerStartPosition;

		[Token(Token = "0x400224B")]
		[FieldOffset(Offset = "0x34")]
		public XVector playerEnterFrom;

		[Token(Token = "0x400224C")]
		[FieldOffset(Offset = "0x40")]
		public XVector playerSpawnRotation;

		[Token(Token = "0x400224D")]
		[FieldOffset(Offset = "0x4C")]
		public WayPointsData wayPoints;

		[Token(Token = "0x400224E")]
		[FieldOffset(Offset = "0x50")]
		public RandomPositionData battleField;

		[Token(Token = "0x17000832")]
		[JsonIgnore]
		public static LevelData Empty
		{
			[Token(Token = "0x6003B49")]
			[Address(RVA = "0x201DA90", Offset = "0x201DA90", VA = "0x201DA90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003B48")]
		[Address(RVA = "0x201DA80", Offset = "0x201DA80", VA = "0x201DA80")]
		public LevelData()
		{
		}
	}
}
