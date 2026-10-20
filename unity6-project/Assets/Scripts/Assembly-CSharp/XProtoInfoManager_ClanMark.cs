using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000652")]
public class XProtoInfoManager_ClanMark : Dictionary<int, XClanMarkProtoInfo>, CSProtoInfoManagerBase
{
	[Token(Token = "0x2000653")]
	private sealed class _003CGeTypeList_003Ec__AnonStorey127
	{
		[Token(Token = "0x4001E4E")]
		[FieldOffset(Offset = "0x8")]
		internal ClanMarkInfoType type;

		[Token(Token = "0x4001E4F")]
		[FieldOffset(Offset = "0xC")]
		internal List<XClanMarkProtoInfo> markList;

		[Token(Token = "0x6003610")]
		[Address(RVA = "0x1C896C0", Offset = "0x1C896C0", VA = "0x1C896C0")]
		public _003CGeTypeList_003Ec__AnonStorey127()
		{
		}

		[Token(Token = "0x6003611")]
		[Address(RVA = "0x1C8976C", Offset = "0x1C8976C", VA = "0x1C8976C")]
		internal void _003C_003Em__17D(KeyValuePair<int, XClanMarkProtoInfo> e)
		{
		}
	}

	[Token(Token = "0x6003608")]
	[Address(RVA = "0x1C8693C", Offset = "0x1C8693C", VA = "0x1C8693C")]
	public XProtoInfoManager_ClanMark()
	{
	}

	[Token(Token = "0x6003609")]
	[Address(RVA = "0x1C89070", Offset = "0x1C89070", VA = "0x1C89070", Slot = "42")]
	public void RemoveNotTagedContents(CSProtoInfoManagers protos)
	{
	}

	[Token(Token = "0x600360A")]
	[Address(RVA = "0x1C89074", Offset = "0x1C89074", VA = "0x1C89074", Slot = "41")]
	public bool Cooking(CSProtoInfoManagers protos)
	{
		return default(bool);
	}

	[Token(Token = "0x600360B")]
	[Address(RVA = "0x1C8907C", Offset = "0x1C8907C", VA = "0x1C8907C", Slot = "40")]
	public bool IsFrom(ProtoInfoFrom from)
	{
		return default(bool);
	}

	[Token(Token = "0x600360C")]
	[Address(RVA = "0x1C8908C", Offset = "0x1C8908C", VA = "0x1C8908C", Slot = "43")]
	public bool LoadFromLocalFile(CSFileLoaderBase loader)
	{
		return default(bool);
	}

	[Token(Token = "0x600360D")]
	[Address(RVA = "0x1C893FC", Offset = "0x1C893FC", VA = "0x1C893FC")]
	public XClanMarkProtoInfo GetInfo(int id)
	{
		return null;
	}

	[Token(Token = "0x600360E")]
	[Address(RVA = "0x1C8956C", Offset = "0x1C8956C", VA = "0x1C8956C")]
	public List<XClanMarkProtoInfo> GeTypeList(ClanMarkInfoType type)
	{
		return null;
	}

	[Token(Token = "0x600360F")]
	[Address(RVA = "0x1C896C8", Offset = "0x1C896C8", VA = "0x1C896C8")]
	private void _003CLoadFromLocalFile_003Em__17C(XClanMarkProtoInfo e)
	{
	}
}
