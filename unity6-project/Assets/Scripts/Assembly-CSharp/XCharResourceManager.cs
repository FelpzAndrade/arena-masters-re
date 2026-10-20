using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000603")]
public class XCharResourceManager
{
	[Token(Token = "0x4001CD3")]
	[FieldOffset(Offset = "0x8")]
	private List<GameObject> m_coolDownEffectList;

	[Token(Token = "0x4001CD4")]
	[FieldOffset(Offset = "0xC")]
	private List<GameObject> m_removeEffectList;

	[Token(Token = "0x4001CD5")]
	[FieldOffset(Offset = "0x10")]
	private List<XCharacterLoadOperator> m_operatorList;

	[Token(Token = "0x4001CD6")]
	[FieldOffset(Offset = "0x14")]
	private bool IsEffectLoadStart__BackingField;

	[Token(Token = "0x170007A3")]
	public bool IsEffectLoadStart
	{
		[Token(Token = "0x600335F")]
		[Address(RVA = "0x1ABEF5C", Offset = "0x1ABEF5C", VA = "0x1ABEF5C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003360")]
		[Address(RVA = "0x1ABEF64", Offset = "0x1ABEF64", VA = "0x1ABEF64")]
		set
		{
		}
	}

	[Token(Token = "0x600335E")]
	[Address(RVA = "0x1ABEE64", Offset = "0x1ABEE64", VA = "0x1ABEE64")]
	public XCharResourceManager()
	{
	}

	[Token(Token = "0x6003361")]
	[Address(RVA = "0x1ABEF6C", Offset = "0x1ABEF6C", VA = "0x1ABEF6C")]
	public void PushCoolDownEffect(XPoolType type, GameObject obj)
	{
	}

	[Token(Token = "0x6003362")]
	[Address(RVA = "0x1ABF00C", Offset = "0x1ABF00C", VA = "0x1ABF00C")]
	public bool CheckEmptyOperatorList()
	{
		return default(bool);
	}

	[Token(Token = "0x6003363")]
	[Address(RVA = "0x1ABF0B4", Offset = "0x1ABF0B4", VA = "0x1ABF0B4")]
	public XAsyncLoadOperator AddCharAsyncOperator(List<XModuleActor.CreationDesc> descList, Action action, bool loadEffect = false, bool loadChangeChar = false)
	{
		return null;
	}

	[Token(Token = "0x6003364")]
	[Address(RVA = "0x1ABF1CC", Offset = "0x1ABF1CC", VA = "0x1ABF1CC")]
	public XAsyncLoadOperator AddCharAsyncOperator(Netdata_CreationDesc descList, Action action, bool loadEffect = false, bool loadChangeChar = false)
	{
		return null;
	}

	[Token(Token = "0x6003365")]
	[Address(RVA = "0x1ABF2E4", Offset = "0x1ABF2E4", VA = "0x1ABF2E4")]
	public XAsyncLoadOperator AddCharAsyncOperator(XModuleActor.CreationDesc desc, Action action, bool loadEffect = false, bool loadChangeChar = false)
	{
		return null;
	}

	[Token(Token = "0x6003366")]
	[Address(RVA = "0x1ABF3FC", Offset = "0x1ABF3FC", VA = "0x1ABF3FC")]
	public void MyLobbyCharPreload()
	{
	}

	[Token(Token = "0x6003367")]
	[Address(RVA = "0x1ABF620", Offset = "0x1ABF620", VA = "0x1ABF620")]
	public void AddCharOperator(XModuleActor.CreationDesc desc)
	{
	}

	[Token(Token = "0x6003368")]
	[Address(RVA = "0x1ABF6AC", Offset = "0x1ABF6AC", VA = "0x1ABF6AC")]
	public void Update()
	{
	}

	[Token(Token = "0x6003369")]
	[Address(RVA = "0x1ABF6D4", Offset = "0x1ABF6D4", VA = "0x1ABF6D4")]
	private void UpdateEffectLoad()
	{
	}

	[Token(Token = "0x600336A")]
	[Address(RVA = "0x1ABFB98", Offset = "0x1ABFB98", VA = "0x1ABFB98")]
	private void UpdateLoadOperator()
	{
	}

	[Token(Token = "0x600336B")]
	[Address(RVA = "0x1ABFD6C", Offset = "0x1ABFD6C", VA = "0x1ABFD6C")]
	public void Clear()
	{
	}

	[Token(Token = "0x600336C")]
	[Address(RVA = "0x1ABFE04", Offset = "0x1ABFE04", VA = "0x1ABFE04")]
	internal bool HasOperation()
	{
		return default(bool);
	}
}
