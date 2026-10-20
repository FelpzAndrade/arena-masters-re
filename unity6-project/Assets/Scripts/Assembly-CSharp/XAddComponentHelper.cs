using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200069A")]
public class XAddComponentHelper
{
	[Token(Token = "0x600374C")]
	[Address(RVA = "0x17B6658", Offset = "0x17B6658", VA = "0x17B6658")]
	public XAddComponentHelper()
	{
	}

	[Token(Token = "0x600374D")]
	[Address(RVA = "0x17B6660", Offset = "0x17B6660", VA = "0x17B6660")]
	public static XModuleEntity AddComponentActor(GameObject obj)
	{
		return null;
	}

	[Token(Token = "0x600374E")]
	[Address(RVA = "0x17B68B8", Offset = "0x17B68B8", VA = "0x17B68B8")]
	public static XModuleEntity AddComponentMonster(GameObject obj)
	{
		return null;
	}

	[Token(Token = "0x600374F")]
	[Address(RVA = "0x17B6B44", Offset = "0x17B6B44", VA = "0x17B6B44")]
	public static void AddComponentLevelActor(GameObject obj)
	{
	}

	[Token(Token = "0x6003750")]
	[Address(RVA = "0x17B6CC4", Offset = "0x17B6CC4", VA = "0x17B6CC4")]
	public static void AddComponentLevelMapObject(GameObject obj)
	{
	}

	[Token(Token = "0x6003751")]
	[Address(RVA = "0x17B6F2C", Offset = "0x17B6F2C", VA = "0x17B6F2C")]
	public static void AddComponentWall(GameObject obj)
	{
	}

	[Token(Token = "0x6003752")]
	[Address(RVA = "0x17B70EC", Offset = "0x17B70EC", VA = "0x17B70EC")]
	public static void AddComponentDropObject(GameObject obj)
	{
	}

	[Token(Token = "0x6003753")]
	[Address(RVA = "0x17B73A8", Offset = "0x17B73A8", VA = "0x17B73A8")]
	public static void AddComponentPointObject(GameObject obj)
	{
	}

	[Token(Token = "0x6003754")]
	[Address(RVA = "0x17B7668", Offset = "0x17B7668", VA = "0x17B7668")]
	public static void AddComponentCommonPlayer(GameObject obj)
	{
	}

	[Token(Token = "0x6003755")]
	[Address(RVA = "0x17B78B0", Offset = "0x17B78B0", VA = "0x17B78B0")]
	public static void AddComponentMyPlayer(GameObject obj)
	{
	}

	[Token(Token = "0x6003756")]
	[Address(RVA = "0x17B7A0C", Offset = "0x17B7A0C", VA = "0x17B7A0C")]
	public static void AddComponentMyPet(GameObject obj, XModuleEntity myPlayerMe)
	{
	}

	[Token(Token = "0x6003757")]
	[Address(RVA = "0x17B7C94", Offset = "0x17B7C94", VA = "0x17B7C94")]
	public static void AddComponentAIPlayer(GameObject obj)
	{
	}

	[Token(Token = "0x6003758")]
	[Address(RVA = "0x17B7D48", Offset = "0x17B7D48", VA = "0x17B7D48")]
	public static void AddComponentNetAIPlayer(GameObject obj)
	{
	}

	[Token(Token = "0x6003759")]
	[Address(RVA = "0x17B6A3C", Offset = "0x17B6A3C", VA = "0x17B6A3C")]
	public static void AddAIComponents(GameObject obj)
	{
	}

	[Token(Token = "0x600375A")]
	[Address(RVA = "0x17B7E18", Offset = "0x17B7E18", VA = "0x17B7E18")]
	public static void AddComponentNetPlayer(GameObject obj)
	{
	}

	[Token(Token = "0x600375B")]
	[Address(RVA = "0x17B7EC4", Offset = "0x17B7EC4", VA = "0x17B7EC4")]
	public static void AddComponentLobbyPlayer(GameObject obj)
	{
	}

	[Token(Token = "0x600375C")]
	[Address(RVA = "0x17B7F68", Offset = "0x17B7F68", VA = "0x17B7F68")]
	public static void AddComponentModelPreview(GameObject obj)
	{
	}

	[Token(Token = "0x600375D")]
	[Address(RVA = "0x17B8084", Offset = "0x17B8084", VA = "0x17B8084")]
	public static XModuleAttackInfo AddComponentProjectile(XModuleEntity owner, GameObject goAttack, CSSkillInfo skillInfo, [Optional] CSSkillEffectInfo effectInfo)
	{
		return null;
	}

	[Token(Token = "0x600375E")]
	[Address(RVA = "0x17B82F4", Offset = "0x17B82F4", VA = "0x17B82F4")]
	public static GameObject AttachModel(XModuleEntity me, CSCharacterInfo characterInfo, SkinInfo skinInfo)
	{
		return null;
	}

	[Token(Token = "0x600375F")]
	[Address(RVA = "0x17B84C4", Offset = "0x17B84C4", VA = "0x17B84C4")]
	public static GameObject AttachModelWithoutPool(GameObject me, CSCharacterInfo characterInfo, SkinInfo skinInfo)
	{
		return null;
	}

	[Token(Token = "0x6003760")]
	[Address(RVA = "0x17B832C", Offset = "0x17B832C", VA = "0x17B832C")]
	public static GameObject AttachModel(XModuleEntity me, string strResourceName, [Optional] CSCharacterInfo characterInfo)
	{
		return null;
	}

	[Token(Token = "0x6003761")]
	[Address(RVA = "0x17B84FC", Offset = "0x17B84FC", VA = "0x17B84FC")]
	public static GameObject AttachModelWithoutPool(GameObject me, string strResourceName, [Optional] CSCharacterInfo characterInfo)
	{
		return null;
	}

	[Token(Token = "0x6003762")]
	[Address(RVA = "0x17B882C", Offset = "0x17B882C", VA = "0x17B882C")]
	private static void SetTransform(XModuleEntity parent, GameObject goModel)
	{
	}

	[Token(Token = "0x6003763")]
	[Address(RVA = "0x17B8BCC", Offset = "0x17B8BCC", VA = "0x17B8BCC")]
	private static void SetTransform(GameObject parent, GameObject goModel)
	{
	}

	[Token(Token = "0x6003764")]
	[Address(RVA = "0x17B8EB0", Offset = "0x17B8EB0", VA = "0x17B8EB0")]
	public static void RemoveModel(XModuleEntity me)
	{
	}
}
