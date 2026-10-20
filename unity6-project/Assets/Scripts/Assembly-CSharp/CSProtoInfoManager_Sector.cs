using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000B44")]
public class CSProtoInfoManager_Sector : Dictionary<int, CSSectorInfo>, CSProtoInfoManagerBase
{
	[Token(Token = "0x2000B45")]
	private sealed class _003CRemoveNotTagedContents_003Ec__AnonStorey159
	{
		[Token(Token = "0x400380D")]
		[FieldOffset(Offset = "0x8")]
		internal CSProtoInfoManagers protos;

		[Token(Token = "0x600525C")]
		[Address(RVA = "0x21F599C", Offset = "0x21F599C", VA = "0x21F599C")]
		public _003CRemoveNotTagedContents_003Ec__AnonStorey159()
		{
		}

		[Token(Token = "0x600525D")]
		[Address(RVA = "0x21F63F0", Offset = "0x21F63F0", VA = "0x21F63F0")]
		internal bool _003C_003Em__20D(KeyValuePair<int, CSSectorInfo> f)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6005252")]
	[Address(RVA = "0x21F5734", Offset = "0x21F5734", VA = "0x21F5734")]
	public CSProtoInfoManager_Sector()
	{
	}

	[Token(Token = "0x6005253")]
	[Address(RVA = "0x21F57B8", Offset = "0x21F57B8", VA = "0x21F57B8", Slot = "40")]
	public bool IsFrom(ProtoInfoFrom from)
	{
		return default(bool);
	}

	[Token(Token = "0x6005254")]
	[Address(RVA = "0x21F57C8", Offset = "0x21F57C8", VA = "0x21F57C8", Slot = "42")]
	public void RemoveNotTagedContents(CSProtoInfoManagers protos)
	{
	}

	[Token(Token = "0x6005255")]
	[Address(RVA = "0x21F59A4", Offset = "0x21F59A4", VA = "0x21F59A4", Slot = "41")]
	public bool Cooking(CSProtoInfoManagers protos)
	{
		return default(bool);
	}

	[Token(Token = "0x6005256")]
	[Address(RVA = "0x21F5C44", Offset = "0x21F5C44", VA = "0x21F5C44")]
	public void LoadFromServer(JToken source)
	{
	}

	[Token(Token = "0x6005257")]
	[Address(RVA = "0x21F5CD8", Offset = "0x21F5CD8", VA = "0x21F5CD8", Slot = "43")]
	public bool LoadFromLocalFile(CSFileLoaderBase loader)
	{
		return default(bool);
	}

	[Token(Token = "0x6005258")]
	[Address(RVA = "0x21F6044", Offset = "0x21F6044", VA = "0x21F6044")]
	public CSSectorInfo GetSectorInfo(int id)
	{
		return null;
	}

	[Token(Token = "0x6005259")]
	[Address(RVA = "0x21F61E8", Offset = "0x21F61E8", VA = "0x21F61E8")]
	public bool IsExist(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x600525A")]
	[Address(RVA = "0x21F6274", Offset = "0x21F6274", VA = "0x21F6274")]
	public bool IsEnterPossible(int id, int level)
	{
		return default(bool);
	}

	[Token(Token = "0x600525B")]
	[Address(RVA = "0x21F634C", Offset = "0x21F634C", VA = "0x21F634C")]
	private void _003CLoadFromLocalFile_003Em__20E(CSSectorInfo e)
	{
	}
}
