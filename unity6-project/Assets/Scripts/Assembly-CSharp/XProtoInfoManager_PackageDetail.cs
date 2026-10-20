using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000674")]
public class XProtoInfoManager_PackageDetail : Dictionary<int, List<PackageDetailInfo>>, CSProtoInfoManagerBase
{
	[Token(Token = "0x4001EF1")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<PackageDetailInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6003680")]
	[Address(RVA = "0x1C864B0", Offset = "0x1C864B0", VA = "0x1C864B0")]
	public XProtoInfoManager_PackageDetail()
	{
	}

	[Token(Token = "0x6003681")]
	[Address(RVA = "0x1C8F840", Offset = "0x1C8F840", VA = "0x1C8F840", Slot = "40")]
	public bool IsFrom(ProtoInfoFrom from)
	{
		return default(bool);
	}

	[Token(Token = "0x6003682")]
	[Address(RVA = "0x1C8F850", Offset = "0x1C8F850", VA = "0x1C8F850", Slot = "42")]
	public void RemoveNotTagedContents(CSProtoInfoManagers protos)
	{
	}

	[Token(Token = "0x6003683")]
	[Address(RVA = "0x1C8F854", Offset = "0x1C8F854", VA = "0x1C8F854", Slot = "41")]
	public bool Cooking(CSProtoInfoManagers protos)
	{
		return default(bool);
	}

	[Token(Token = "0x6003684")]
	[Address(RVA = "0x1C8FAC4", Offset = "0x1C8FAC4", VA = "0x1C8FAC4", Slot = "44")]
	public virtual bool LoadFromLocalFile(CSFileLoaderBase loader)
	{
		return default(bool);
	}

	[Token(Token = "0x6003685")]
	[Address(RVA = "0x1C8FE7C", Offset = "0x1C8FE7C", VA = "0x1C8FE7C")]
	private static int _003CCooking_003Em__186(PackageDetailInfo x, PackageDetailInfo y)
	{
		return default(int);
	}
}
