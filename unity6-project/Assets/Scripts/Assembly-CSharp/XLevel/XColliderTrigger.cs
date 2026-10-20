using Il2CppDummyDll;
using UnityEngine;

namespace XLevel
{
	[Token(Token = "0x2000705")]
	public class XColliderTrigger : XTimeTrigger
	{
		[Token(Token = "0x6003A80")]
		[Address(RVA = "0x20299BC", Offset = "0x20299BC", VA = "0x20299BC")]
		public XColliderTrigger()
		{
		}

		[Token(Token = "0x6003A81")]
		[Address(RVA = "0x20299C4", Offset = "0x20299C4", VA = "0x20299C4", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003A82")]
		[Address(RVA = "0x2029A50", Offset = "0x2029A50", VA = "0x2029A50", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}

		[Token(Token = "0x6003A83")]
		[Address(RVA = "0x2029D08", Offset = "0x2029D08", VA = "0x2029D08")]
		private ColliderData GetColliderData(BoxCollider boxCollider)
		{
			return null;
		}

		[Token(Token = "0x6003A84")]
		[Address(RVA = "0x2029DF8", Offset = "0x2029DF8", VA = "0x2029DF8")]
		private ColliderData GetColliderData(SphereCollider sphereCollider)
		{
			return null;
		}

		[Token(Token = "0x6003A85")]
		[Address(RVA = "0x2029ED4", Offset = "0x2029ED4", VA = "0x2029ED4")]
		private void OnTriggerEnter(Collider col)
		{
		}
	}
}
