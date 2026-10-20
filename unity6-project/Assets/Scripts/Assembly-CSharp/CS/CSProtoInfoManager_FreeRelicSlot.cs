using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000ADC")]
	public class CSProtoInfoManager_FreeRelicSlot : Dictionary<int, List<CSFreeRelicSlotInfo>>, CSProtoInfoManagerBase
	{
		[Token(Token = "0x6004F78")]
		[Address(RVA = "0x1FC1D00", Offset = "0x1FC1D00", VA = "0x1FC1D00")]
		public CSProtoInfoManager_FreeRelicSlot()
		{
		}

		[Token(Token = "0x6004F79")]
		[Address(RVA = "0x1FD1C84", Offset = "0x1FD1C84", VA = "0x1FD1C84", Slot = "40")]
		public bool IsFrom(ProtoInfoFrom from)
		{
			return default(bool);
		}

		[Token(Token = "0x6004F7A")]
		[Address(RVA = "0x1FD1C94", Offset = "0x1FD1C94", VA = "0x1FD1C94", Slot = "42")]
		public void RemoveNotTagedContents(CSProtoInfoManagers protos)
		{
		}

		[Token(Token = "0x6004F7B")]
		[Address(RVA = "0x1FD1C98", Offset = "0x1FD1C98", VA = "0x1FD1C98", Slot = "44")]
		public virtual bool Cooking(CSProtoInfoManagers protos)
		{
			return default(bool);
		}

		[Token(Token = "0x6004F7C")]
		[Address(RVA = "0x1FD2170", Offset = "0x1FD2170", VA = "0x1FD2170", Slot = "45")]
		public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
		{
			return default(bool);
		}

		[Token(Token = "0x6004F7D")]
		[Address(RVA = "0x1FD27A4", Offset = "0x1FD27A4", VA = "0x1FD27A4")]
		private int GetRandomRelicGroup(int teamLevel)
		{
			return default(int);
		}

		[Token(Token = "0x6004F7E")]
		[Address(RVA = "0x1FD2C84", Offset = "0x1FD2C84", VA = "0x1FD2C84")]
		public CSFreeRelicSlotInfo GetRandomRelicInfo(int groupID, [Optional] Random random)
		{
			return null;
		}

		[Token(Token = "0x6004F7F")]
		[Address(RVA = "0x1FD2F48", Offset = "0x1FD2F48", VA = "0x1FD2F48", Slot = "46")]
		public virtual CSFreeRelicSlotInfo GetRandomFreeRelicInfo(int teamLevel, [Optional] Random random)
		{
			return null;
		}
	}
}
