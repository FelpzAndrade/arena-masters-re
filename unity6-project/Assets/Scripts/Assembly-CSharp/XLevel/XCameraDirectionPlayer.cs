using Il2CppDummyDll;
using UnityEngine;

namespace XLevel
{
	[Token(Token = "0x20006F0")]
	public class XCameraDirectionPlayer : XCameraDirection
	{
		[Token(Token = "0x400213D")]
		[FieldOffset(Offset = "0xC")]
		public float orbitaryDuration;

		[Token(Token = "0x400213E")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 orbitaryStartRotation;

		[Token(Token = "0x400213F")]
		[FieldOffset(Offset = "0x1C")]
		public float orbitaryStartRadius;

		[Token(Token = "0x4002140")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 orbitaryEndRotation;

		[Token(Token = "0x4002141")]
		[FieldOffset(Offset = "0x2C")]
		public float orbitaryEndRadius;

		[Token(Token = "0x4002142")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x6003A4C")]
		[Address(RVA = "0x2029360", Offset = "0x2029360", VA = "0x2029360")]
		public XCameraDirectionPlayer()
		{
		}

		[Token(Token = "0x6003A4D")]
		[Address(RVA = "0x202943C", Offset = "0x202943C", VA = "0x202943C", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003A4E")]
		[Address(RVA = "0x20294C8", Offset = "0x20294C8", VA = "0x20294C8", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}
	}
}
