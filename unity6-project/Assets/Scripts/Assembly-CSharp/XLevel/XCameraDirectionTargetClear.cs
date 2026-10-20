using Il2CppDummyDll;
using UnityEngine;

namespace XLevel
{
	[Token(Token = "0x20006F2")]
	public class XCameraDirectionTargetClear : XCameraDirection
	{
		[Token(Token = "0x4002149")]
		[FieldOffset(Offset = "0xC")]
		public string targetEntity;

		[Token(Token = "0x400214A")]
		[FieldOffset(Offset = "0x10")]
		public float linearDuration;

		[Token(Token = "0x400214B")]
		[FieldOffset(Offset = "0x14")]
		public float orbitaryDuration;

		[Token(Token = "0x400214C")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 orbitaryEndRotation;

		[Token(Token = "0x400214D")]
		[FieldOffset(Offset = "0x24")]
		public float orbitaryEndRadius;

		[Token(Token = "0x6003A52")]
		[Address(RVA = "0x20295E4", Offset = "0x20295E4", VA = "0x20295E4")]
		public XCameraDirectionTargetClear()
		{
		}

		[Token(Token = "0x6003A53")]
		[Address(RVA = "0x20295EC", Offset = "0x20295EC", VA = "0x20295EC", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003A54")]
		[Address(RVA = "0x2029678", Offset = "0x2029678", VA = "0x2029678", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}
	}
}
