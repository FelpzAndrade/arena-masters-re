using CS;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace XLevel
{
	[Token(Token = "0x20004F5")]
	public class XMissionTester : MonoBehaviour
	{
		[Token(Token = "0x4001904")]
		[FieldOffset(Offset = "0xC")]
		private JsonSerializerSettings m_settings;

		[Token(Token = "0x4001905")]
		[FieldOffset(Offset = "0x10")]
		public int sectorId;

		[Token(Token = "0x4001906")]
		[FieldOffset(Offset = "0x14")]
		public string path;

		[Token(Token = "0x4001907")]
		[FieldOffset(Offset = "0x18")]
		public int playerCharID;

		[Token(Token = "0x4001908")]
		[FieldOffset(Offset = "0x1C")]
		public int playerCharID2;

		[Token(Token = "0x4001909")]
		[FieldOffset(Offset = "0x20")]
		public int relicSkillId;

		[Token(Token = "0x400190A")]
		[FieldOffset(Offset = "0x24")]
		public int playerLev;

		[Token(Token = "0x400190B")]
		[FieldOffset(Offset = "0x28")]
		public int skillLev;

		[Token(Token = "0x400190C")]
		[FieldOffset(Offset = "0x2C")]
		public Netdata_EquipedItem[] equipItems;

		[Token(Token = "0x400190D")]
		[FieldOffset(Offset = "0x30")]
		public int fieldLevel;

		[Token(Token = "0x400190E")]
		[FieldOffset(Offset = "0x34")]
		public CSStageGameModeType gameModeType;

		[Token(Token = "0x400190F")]
		[FieldOffset(Offset = "0x38")]
		public CSStageType gameType;

		[Token(Token = "0x4001910")]
		[FieldOffset(Offset = "0x3C")]
		public int timeLimit;

		[Token(Token = "0x6002AC7")]
		[Address(RVA = "0x203195C", Offset = "0x203195C", VA = "0x203195C")]
		public XMissionTester()
		{
		}

		[Token(Token = "0x6002AC8")]
		[Address(RVA = "0x2031AA4", Offset = "0x2031AA4", VA = "0x2031AA4")]
		private void Start()
		{
		}
	}
}
