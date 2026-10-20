using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

namespace XLevel
{
	[Token(Token = "0x2000724")]
	public class XLevelDataEntity : MonoBehaviour
	{
		[Token(Token = "0x2000725")]
		public class GenerationReport
		{
			[Token(Token = "0x40021D9")]
			[FieldOffset(Offset = "0x8")]
			public HashSet<TriggerType> triggersOnBranch;

			[Token(Token = "0x40021DA")]
			[FieldOffset(Offset = "0xC")]
			public XTeamEnum spawnTriggerTeam;

			[Token(Token = "0x40021DB")]
			[FieldOffset(Offset = "0x10")]
			public bool errorOccured;

			[Token(Token = "0x40021DC")]
			[FieldOffset(Offset = "0x14")]
			public List<Object> causedObjects;

			[Token(Token = "0x40021DD")]
			[FieldOffset(Offset = "0x18")]
			public string errorMessage;

			[Token(Token = "0x40021DE")]
			[FieldOffset(Offset = "0x1C")]
			public Dictionary<string, GameObject> nameList;

			[Token(Token = "0x40021DF")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, GameObject> targetEntityList;

			[Token(Token = "0x40021E0")]
			[FieldOffset(Offset = "0x24")]
			public Dictionary<string, GameObject> actionTagList;

			[Token(Token = "0x40021E1")]
			[FieldOffset(Offset = "0x28")]
			public List<XLevelActionEntity> actionEntityList;

			[Token(Token = "0x40021E2")]
			[FieldOffset(Offset = "0x2C")]
			public Dictionary<string, GameObject> actionTriggerTargetList;

			[Token(Token = "0x6003AD8")]
			[Address(RVA = "0x202B6F0", Offset = "0x202B6F0", VA = "0x202B6F0")]
			public GenerationReport()
			{
			}
		}

		[Token(Token = "0x1700082C")]
		public virtual bool IsLeaf
		{
			[Token(Token = "0x6003AD4")]
			[Address(RVA = "0x202B5B0", Offset = "0x202B5B0", VA = "0x202B5B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6003AD2")]
		[Address(RVA = "0x20203E4", Offset = "0x20203E4", VA = "0x20203E4")]
		public XLevelDataEntity()
		{
		}

		[Token(Token = "0x6003AD3")]
		[Address(RVA = "0x202B534", Offset = "0x202B534", VA = "0x202B534")]
		public LevelDataEntity GenerateData(GenerationReport meta)
		{
			return null;
		}

		[Token(Token = "0x6003AD5")]
		[Address(RVA = "0x20206D0", Offset = "0x20206D0", VA = "0x20206D0", Slot = "5")]
		protected virtual void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}

		[Token(Token = "0x6003AD6")]
		[Address(RVA = "0x202B5B8", Offset = "0x202B5B8", VA = "0x202B5B8")]
		private bool HasChildren(XLevelDataEntity childData)
		{
			return default(bool);
		}

		[Token(Token = "0x6003AD7")]
		[Address(RVA = "0x202B664", Offset = "0x202B664", VA = "0x202B664", Slot = "6")]
		protected virtual LevelDataEntity GetDataInstance()
		{
			return null;
		}
	}
}
