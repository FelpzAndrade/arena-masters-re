using System;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x20006F1")]
	public class CameraDirectionPlayerData : CameraDirectionData
	{
		[Token(Token = "0x4002143")]
		[FieldOffset(Offset = "0x14")]
		public float orbitaryDuration;

		[Token(Token = "0x4002144")]
		[FieldOffset(Offset = "0x18")]
		public XVector orbitaryStartRotation;

		[Token(Token = "0x4002145")]
		[FieldOffset(Offset = "0x24")]
		public float orbitaryStartRadius;

		[Token(Token = "0x4002146")]
		[FieldOffset(Offset = "0x28")]
		public XVector orbitaryEndRotation;

		[Token(Token = "0x4002147")]
		[FieldOffset(Offset = "0x34")]
		public float orbitaryEndRadius;

		[Token(Token = "0x4002148")]
		[FieldOffset(Offset = "0x38")]
		public XVector offset;

		[Token(Token = "0x6003A4F")]
		[Address(RVA = "0x1D402CC", Offset = "0x1D402CC", VA = "0x1D402CC")]
		public CameraDirectionPlayerData()
		{
		}

		[Token(Token = "0x6003A50")]
		[Address(RVA = "0x1D402D4", Offset = "0x1D402D4", VA = "0x1D402D4", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}

		[Token(Token = "0x6003A51")]
		[Address(RVA = "0x1D40390", Offset = "0x1D40390", VA = "0x1D40390", Slot = "5")]
		protected override void PushDataToComponent(XLevelDataEntity comp)
		{
		}
	}
}
