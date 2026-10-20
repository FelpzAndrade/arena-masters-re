using System;
using Il2CppDummyDll;
using UnityEngine;

namespace XLevel
{
	[Token(Token = "0x2000706")]
	public sealed class ColliderTriggerData : TimeTriggerData
	{
		[Token(Token = "0x2000707")]
		private sealed class _003CPushDataToComponent_003Ec__AnonStorey135
		{
			[Token(Token = "0x400217B")]
			[FieldOffset(Offset = "0x8")]
			internal GameObject go;

			[Token(Token = "0x6003A8A")]
			[Address(RVA = "0x20199A8", Offset = "0x20199A8", VA = "0x20199A8")]
			public _003CPushDataToComponent_003Ec__AnonStorey135()
			{
			}

			[Token(Token = "0x6003A8B")]
			[Address(RVA = "0x2019AB8", Offset = "0x2019AB8", VA = "0x2019AB8")]
			internal void _003C_003Em__19A(ColliderData data)
			{
			}
		}

		[Token(Token = "0x4002178")]
		[FieldOffset(Offset = "0x20")]
		public XVector position;

		[Token(Token = "0x4002179")]
		[FieldOffset(Offset = "0x2C")]
		public XVector rotation;

		[Token(Token = "0x400217A")]
		[FieldOffset(Offset = "0x38")]
		public ColliderData[] colliders;

		[Token(Token = "0x6003A86")]
		[Address(RVA = "0x2019570", Offset = "0x2019570", VA = "0x2019570")]
		public ColliderTriggerData()
		{
		}

		[Token(Token = "0x6003A87")]
		[Address(RVA = "0x2019580", Offset = "0x2019580", VA = "0x2019580")]
		public XColliderTrigger ToComponent(Transform parent, ITriggerReciever reciever)
		{
			return null;
		}

		[Token(Token = "0x6003A88")]
		[Address(RVA = "0x20198EC", Offset = "0x20198EC", VA = "0x20198EC", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}

		[Token(Token = "0x6003A89")]
		[Address(RVA = "0x20196B8", Offset = "0x20196B8", VA = "0x20196B8", Slot = "5")]
		protected override void PushDataToComponent(XLevelDataEntity comp)
		{
		}
	}
}
