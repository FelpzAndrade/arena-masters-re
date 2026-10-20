using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001A0")]
[ExecuteInEditMode]
public class InvDatabase : MonoBehaviour
{
	[Token(Token = "0x40005FD")]
	[FieldOffset(Offset = "0x0")]
	private static InvDatabase[] mList;

	[Token(Token = "0x40005FE")]
	[FieldOffset(Offset = "0x4")]
	private static bool mIsDirty;

	[Token(Token = "0x40005FF")]
	[FieldOffset(Offset = "0xC")]
	public int databaseID;

	[Token(Token = "0x4000600")]
	[FieldOffset(Offset = "0x10")]
	public List<InvBaseItem> items;

	[Token(Token = "0x4000601")]
	[FieldOffset(Offset = "0x14")]
	public UIAtlas iconAtlas;

	[Token(Token = "0x17000240")]
	public static InvDatabase[] list
	{
		[Token(Token = "0x6000E85")]
		[Address(RVA = "0xD8F894", Offset = "0xD8F894", VA = "0xD8F894")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000E83")]
	[Address(RVA = "0xD8F764", Offset = "0xD8F764", VA = "0xD8F764")]
	public InvDatabase()
	{
	}

	[Token(Token = "0x6000E86")]
	[Address(RVA = "0xD8FA30", Offset = "0xD8FA30", VA = "0xD8FA30")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000E87")]
	[Address(RVA = "0xD8FAE4", Offset = "0xD8FAE4", VA = "0xD8FAE4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000E88")]
	[Address(RVA = "0xD8FB98", Offset = "0xD8FB98", VA = "0xD8FB98")]
	private InvBaseItem GetItem(int id16)
	{
		return null;
	}

	[Token(Token = "0x6000E89")]
	[Address(RVA = "0xD8FC9C", Offset = "0xD8FC9C", VA = "0xD8FC9C")]
	private static InvDatabase GetDatabase(int dbID)
	{
		return null;
	}

	[Token(Token = "0x6000E8A")]
	[Address(RVA = "0xD8FDDC", Offset = "0xD8FDDC", VA = "0xD8FDDC")]
	public static InvBaseItem FindByID(int id32)
	{
		return null;
	}

	[Token(Token = "0x6000E8B")]
	[Address(RVA = "0xD8FEFC", Offset = "0xD8FEFC", VA = "0xD8FEFC")]
	public static InvBaseItem FindByName(string exact)
	{
		return null;
	}

	[Token(Token = "0x6000E8C")]
	[Address(RVA = "0xD9013C", Offset = "0xD9013C", VA = "0xD9013C")]
	public static int FindItemID(InvBaseItem item)
	{
		return default(int);
	}
}
