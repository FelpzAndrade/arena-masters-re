using Il2CppDummyDll;
using UnityEngine;

namespace XLevel
{
	[Token(Token = "0x20006F4")]
	public class XCameraDirectionTargetSpawn : XCameraDirection
	{
		[Token(Token = "0x400214E")]
		[FieldOffset(Offset = "0xC")]
		public string targetEntity;

		[Token(Token = "0x400214F")]
		[FieldOffset(Offset = "0x10")]
		public float linearDuration;

		[Token(Token = "0x4002150")]
		[FieldOffset(Offset = "0x14")]
		public float orbitaryDuration;

		[Token(Token = "0x4002151")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 orbitaryEndRotation;

		[Token(Token = "0x4002152")]
		[FieldOffset(Offset = "0x24")]
		public float orbitaryEndRadius;

		[Token(Token = "0x6003A57")]
		[Address(RVA = "0x202967C", Offset = "0x202967C", VA = "0x202967C")]
		public XCameraDirectionTargetSpawn()
		{
		}

		[Token(Token = "0x6003A58")]
		[Address(RVA = "0x2029684", Offset = "0x2029684", VA = "0x2029684", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003A59")]
		[Address(RVA = "0x2029710", Offset = "0x2029710", VA = "0x2029710", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}
	}
}
