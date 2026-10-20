using Il2CppDummyDll;
using UnityEngine;

namespace XLevel
{
	[Token(Token = "0x20006FC")]
	public class XLevelObject : XLevelTransform
	{
		[Token(Token = "0x4002167")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4002168")]
		[FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public string positionGenerator;

		[Token(Token = "0x6003A68")]
		[Address(RVA = "0x202AF60", Offset = "0x202AF60", VA = "0x202AF60")]
		public XLevelObject()
		{
		}

		[Token(Token = "0x6003A69")]
		[Address(RVA = "0x203167C", Offset = "0x203167C", VA = "0x203167C", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003A6A")]
		[Address(RVA = "0x202B314", Offset = "0x202B314", VA = "0x202B314", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}
	}
}
