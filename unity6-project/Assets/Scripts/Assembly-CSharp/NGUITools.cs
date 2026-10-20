using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200021E")]
public static class NGUITools
{
	[Token(Token = "0x200021F")]
	public delegate void OnInitFunc<T>(T w) where T : UIWidget;

	[Token(Token = "0x400091B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AudioListener mListener;

	[Token(Token = "0x400091C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static bool mLoaded;

	[Token(Token = "0x400091D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static float mGlobalVolume;

	[Token(Token = "0x400091E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static float mLastTimestamp;

	[Token(Token = "0x400091F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static AudioClip mLastClip;

	[Token(Token = "0x4000920")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static Dictionary<Type, string> mTypeNames;

	[Token(Token = "0x4000921")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Vector3[] mSides;

	[Token(Token = "0x4000922")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public static KeyCode[] keys;

	[Token(Token = "0x4000923")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Dictionary<string, UIWidget> mWidgets;

	[Token(Token = "0x4000924")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static UIPanel mRoot;

	[Token(Token = "0x4000925")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static GameObject mGo;

	[Token(Token = "0x4000926")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private static ColorSpace mColorSpace;

	[Token(Token = "0x170002A6")]
	public static float soundVolume
	{
		[Token(Token = "0x60011F2")]
		[Address(RVA = "0x11BD448", Offset = "0x11BD448", VA = "0x11BD448")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60011F3")]
		[Address(RVA = "0x11BD5B4", Offset = "0x11BD5B4", VA = "0x11BD5B4")]
		set
		{
		}
	}

	[Token(Token = "0x170002A7")]
	public static bool fileAccess
	{
		[Token(Token = "0x60011F4")]
		[Address(RVA = "0x11BD6FC", Offset = "0x11BD6FC", VA = "0x11BD6FC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002A8")]
	public static string clipboard
	{
		[Token(Token = "0x600123A")]
		[Address(RVA = "0x11C4BB8", Offset = "0x11C4BB8", VA = "0x11C4BB8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600123B")]
		[Address(RVA = "0x11C4C6C", Offset = "0x11C4C6C", VA = "0x11C4C6C")]
		set
		{
		}
	}

	[Token(Token = "0x170002A9")]
	public static Vector2 screenSize
	{
		[Token(Token = "0x600124C")]
		[Address(RVA = "0x11C5C80", Offset = "0x11C5C80", VA = "0x11C5C80")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x60011F5")]
	[Address(RVA = "0x11BD73C", Offset = "0x11BD73C", VA = "0x11BD73C")]
	public static AudioSource PlaySound(AudioClip clip)
	{
		return null;
	}

	[Token(Token = "0x60011F6")]
	[Address(RVA = "0x11BE284", Offset = "0x11BE284", VA = "0x11BE284")]
	public static AudioSource PlaySound(AudioClip clip, float volume)
	{
		return null;
	}

	[Token(Token = "0x60011F7")]
	[Address(RVA = "0x11BD7EC", Offset = "0x11BD7EC", VA = "0x11BD7EC")]
	public static AudioSource PlaySound(AudioClip clip, float volume, float pitch)
	{
		return null;
	}

	[Token(Token = "0x60011F8")]
	[Address(RVA = "0x11BE43C", Offset = "0x11BE43C", VA = "0x11BE43C")]
	public static int RandomRange(int min, int max)
	{
		return default(int);
	}

	[Token(Token = "0x60011F9")]
	[Address(RVA = "0x11A74D8", Offset = "0x11A74D8", VA = "0x11A74D8")]
	public static string GetHierarchy(GameObject obj)
	{
		return null;
	}

	[Token(Token = "0x60011FA")]
	public static T[] FindActive<T>() where T : Component
	{
		return null;
	}

	[Token(Token = "0x60011FB")]
	[Address(RVA = "0x11ABE00", Offset = "0x11ABE00", VA = "0x11ABE00")]
	public static Camera FindCameraForLayer(int layer)
	{
		return null;
	}

	[Token(Token = "0x60011FC")]
	[Address(RVA = "0x11BE458", Offset = "0x11BE458", VA = "0x11BE458")]
	public static void AddWidgetCollider(GameObject go)
	{
	}

	[Token(Token = "0x60011FD")]
	[Address(RVA = "0x11BE4FC", Offset = "0x11BE4FC", VA = "0x11BE4FC")]
	public static void AddWidgetCollider(GameObject go, bool considerInactive)
	{
	}

	[Token(Token = "0x60011FE")]
	[Address(RVA = "0x11BF220", Offset = "0x11BF220", VA = "0x11BF220")]
	public static void UpdateWidgetCollider(GameObject go)
	{
	}

	[Token(Token = "0x60011FF")]
	[Address(RVA = "0x11BF2C4", Offset = "0x11BF2C4", VA = "0x11BF2C4")]
	public static void UpdateWidgetCollider(GameObject go, bool considerInactive)
	{
	}

	[Token(Token = "0x6001200")]
	[Address(RVA = "0x11BEA30", Offset = "0x11BEA30", VA = "0x11BEA30")]
	public static void UpdateWidgetCollider(BoxCollider box, bool considerInactive)
	{
	}

	[Token(Token = "0x6001201")]
	[Address(RVA = "0x11BEE90", Offset = "0x11BEE90", VA = "0x11BEE90")]
	public static void UpdateWidgetCollider(BoxCollider2D box, bool considerInactive)
	{
	}

	[Token(Token = "0x6001202")]
	public static string GetTypeName<T>()
	{
		return null;
	}

	[Token(Token = "0x6001203")]
	[Address(RVA = "0x11BF4EC", Offset = "0x11BF4EC", VA = "0x11BF4EC")]
	public static string GetTypeName(UnityEngine.Object obj)
	{
		return null;
	}

	[Token(Token = "0x6001204")]
	[Address(RVA = "0x11BF6A8", Offset = "0x11BF6A8", VA = "0x11BF6A8")]
	public static void RegisterUndo(UnityEngine.Object obj, string name)
	{
	}

	[Token(Token = "0x6001205")]
	[Address(RVA = "0x11BF6AC", Offset = "0x11BF6AC", VA = "0x11BF6AC")]
	public static void SetDirty(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6001206")]
	[Address(RVA = "0x11BF6B0", Offset = "0x11BF6B0", VA = "0x11BF6B0")]
	public static GameObject AddChild(this GameObject parent)
	{
		return null;
	}

	[Token(Token = "0x6001207")]
	[Address(RVA = "0x11BF754", Offset = "0x11BF754", VA = "0x11BF754")]
	public static GameObject AddChild(this GameObject parent, bool undo)
	{
		return null;
	}

	[Token(Token = "0x6001208")]
	[Address(RVA = "0x11BF914", Offset = "0x11BF914", VA = "0x11BF914")]
	public static GameObject AddChild(this GameObject parent, GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x6001209")]
	[Address(RVA = "0x11BFB30", Offset = "0x11BFB30", VA = "0x11BFB30")]
	public static int CalculateRaycastDepth(GameObject go)
	{
		return default(int);
	}

	[Token(Token = "0x600120A")]
	[Address(RVA = "0x11BFD4C", Offset = "0x11BFD4C", VA = "0x11BFD4C")]
	public static int CalculateNextDepth(GameObject go)
	{
		return default(int);
	}

	[Token(Token = "0x600120B")]
	[Address(RVA = "0x11BFEF4", Offset = "0x11BFEF4", VA = "0x11BFEF4")]
	public static int CalculateNextDepth(GameObject go, bool ignoreChildrenWithColliders)
	{
		return default(int);
	}

	[Token(Token = "0x600120C")]
	[Address(RVA = "0x11C0258", Offset = "0x11C0258", VA = "0x11C0258")]
	public static int AdjustDepth(GameObject go, int adjustment)
	{
		return default(int);
	}

	[Token(Token = "0x600120D")]
	[Address(RVA = "0x11C05C4", Offset = "0x11C05C4", VA = "0x11C05C4")]
	public static void BringForward(GameObject go)
	{
	}

	[Token(Token = "0x600120E")]
	[Address(RVA = "0x11C09A0", Offset = "0x11C09A0", VA = "0x11C09A0")]
	public static void PushBack(GameObject go)
	{
	}

	[Token(Token = "0x600120F")]
	[Address(RVA = "0x11C0AC4", Offset = "0x11C0AC4", VA = "0x11C0AC4")]
	public static void NormalizeDepths()
	{
	}

	[Token(Token = "0x6001210")]
	[Address(RVA = "0x11C08E0", Offset = "0x11C08E0", VA = "0x11C08E0")]
	public static void NormalizeWidgetDepths()
	{
	}

	[Token(Token = "0x6001211")]
	[Address(RVA = "0x11C0D00", Offset = "0x11C0D00", VA = "0x11C0D00")]
	public static void NormalizeWidgetDepths(GameObject go)
	{
	}

	[Token(Token = "0x6001212")]
	[Address(RVA = "0x11C0B60", Offset = "0x11C0B60", VA = "0x11C0B60")]
	public static void NormalizeWidgetDepths(UIWidget[] list)
	{
	}

	[Token(Token = "0x6001213")]
	[Address(RVA = "0x11C06E4", Offset = "0x11C06E4", VA = "0x11C06E4")]
	public static void NormalizePanelDepths()
	{
	}

	[Token(Token = "0x6001214")]
	[Address(RVA = "0x11C0DD0", Offset = "0x11C0DD0", VA = "0x11C0DD0")]
	public static UIPanel CreateUI(bool advanced3D)
	{
		return null;
	}

	[Token(Token = "0x6001215")]
	[Address(RVA = "0x11C1EE4", Offset = "0x11C1EE4", VA = "0x11C1EE4")]
	public static UIPanel CreateUI(bool advanced3D, int layer)
	{
		return null;
	}

	[Token(Token = "0x6001216")]
	[Address(RVA = "0x11C0E80", Offset = "0x11C0E80", VA = "0x11C0E80")]
	public static UIPanel CreateUI(Transform trans, bool advanced3D, int layer)
	{
		return null;
	}

	[Token(Token = "0x6001217")]
	[Address(RVA = "0x11C2170", Offset = "0x11C2170", VA = "0x11C2170")]
	public static void SetChildLayer(this Transform t, int layer)
	{
	}

	[Token(Token = "0x6001218")]
	public static T AddChild<T>(this GameObject parent) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6001219")]
	public static T AddChild<T>(this GameObject parent, bool undo) where T : Component
	{
		return null;
	}

	[Token(Token = "0x600121A")]
	public static T AddWidget<T>(this GameObject go, int depth = int.MaxValue) where T : UIWidget
	{
		return null;
	}

	[Token(Token = "0x600121B")]
	[Address(RVA = "0x11C228C", Offset = "0x11C228C", VA = "0x11C228C")]
	public static UISprite AddSprite(this GameObject go, UIAtlas atlas, string spriteName, int depth = int.MaxValue)
	{
		return null;
	}

	[Token(Token = "0x600121C")]
	[Address(RVA = "0x11C2464", Offset = "0x11C2464", VA = "0x11C2464")]
	public static GameObject GetRoot(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x600121D")]
	public static T FindInParents<T>(GameObject go) where T : Component
	{
		return null;
	}

	[Token(Token = "0x600121E")]
	public static T FindInParents<T>(Transform trans) where T : Component
	{
		return null;
	}

	[Token(Token = "0x600121F")]
	[Address(RVA = "0x11C2564", Offset = "0x11C2564", VA = "0x11C2564")]
	public static void Destroy(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6001220")]
	[Address(RVA = "0x11C2850", Offset = "0x11C2850", VA = "0x11C2850")]
	public static void DestroyChildren(this Transform t)
	{
	}

	[Token(Token = "0x6001221")]
	[Address(RVA = "0x11C29D0", Offset = "0x11C29D0", VA = "0x11C29D0")]
	public static void DestroyImmediate(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6001222")]
	[Address(RVA = "0x11C2B14", Offset = "0x11C2B14", VA = "0x11C2B14")]
	public static void Broadcast(string funcName)
	{
	}

	[Token(Token = "0x6001223")]
	[Address(RVA = "0x11C2CA4", Offset = "0x11C2CA4", VA = "0x11C2CA4")]
	public static void Broadcast(string funcName, object param)
	{
	}

	[Token(Token = "0x6001224")]
	[Address(RVA = "0x11C1F98", Offset = "0x11C1F98", VA = "0x11C1F98")]
	public static bool IsChild(Transform parent, Transform child)
	{
		return default(bool);
	}

	[Token(Token = "0x6001225")]
	[Address(RVA = "0x11C2E48", Offset = "0x11C2E48", VA = "0x11C2E48")]
	private static void Activate(Transform t)
	{
	}

	[Token(Token = "0x6001226")]
	[Address(RVA = "0x11C2EEC", Offset = "0x11C2EEC", VA = "0x11C2EEC")]
	private static void Activate(Transform t, bool compatibilityMode)
	{
	}

	[Token(Token = "0x6001227")]
	[Address(RVA = "0x11C30C8", Offset = "0x11C30C8", VA = "0x11C30C8")]
	private static void Deactivate(Transform t)
	{
	}

	[Token(Token = "0x6001228")]
	[Address(RVA = "0x11C3190", Offset = "0x11C3190", VA = "0x11C3190")]
	public static void SetActive(GameObject go, bool state)
	{
	}

	[Token(Token = "0x6001229")]
	[Address(RVA = "0x11C3244", Offset = "0x11C3244", VA = "0x11C3244")]
	public static void SetActive(GameObject go, bool state, bool compatibilityMode)
	{
	}

	[Token(Token = "0x600122A")]
	[Address(RVA = "0x11C33AC", Offset = "0x11C33AC", VA = "0x11C33AC")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	private static void CallCreatePanel(Transform t)
	{
	}

	[Token(Token = "0x600122B")]
	[Address(RVA = "0x11C3520", Offset = "0x11C3520", VA = "0x11C3520")]
	public static void SetActiveChildren(GameObject go, bool state)
	{
	}

	[Token(Token = "0x600122C")]
	[Address(RVA = "0x11C36A0", Offset = "0x11C36A0", VA = "0x11C36A0")]
	public static bool IsActive(Behaviour mb)
	{
		return default(bool);
	}

	[Token(Token = "0x600122D")]
	[Address(RVA = "0x11BE338", Offset = "0x11BE338", VA = "0x11BE338")]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public static bool GetActive(Behaviour mb)
	{
		return default(bool);
	}

	[Token(Token = "0x600122E")]
	[Address(RVA = "0x11A9430", Offset = "0x11A9430", VA = "0x11A9430")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static bool GetActive(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x600122F")]
	[Address(RVA = "0x11C3098", Offset = "0x11C3098", VA = "0x11C3098")]
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static void SetActiveSelf(GameObject go, bool state)
	{
	}

	[Token(Token = "0x6001230")]
	[Address(RVA = "0x11C37A8", Offset = "0x11C37A8", VA = "0x11C37A8")]
	public static void SetLayer(GameObject go, int layer)
	{
	}

	[Token(Token = "0x6001231")]
	[Address(RVA = "0x11C38D8", Offset = "0x11C38D8", VA = "0x11C38D8")]
	public static Vector3 Round(Vector3 v)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001232")]
	[Address(RVA = "0x11C3B9C", Offset = "0x11C3B9C", VA = "0x11C3B9C")]
	public static void MakePixelPerfect(Transform t)
	{
	}

	[Token(Token = "0x6001233")]
	[Address(RVA = "0x11C3EB8", Offset = "0x11C3EB8", VA = "0x11C3EB8")]
	public static void FitOnScreen(this Camera cam, Transform transform, Vector3 pos)
	{
	}

	[Token(Token = "0x6001234")]
	[Address(RVA = "0x11C3F7C", Offset = "0x11C3F7C", VA = "0x11C3F7C")]
	public static void FitOnScreen(this Camera cam, Transform transform, Transform content, Vector3 pos)
	{
	}

	[Token(Token = "0x6001235")]
	[Address(RVA = "0x11C4068", Offset = "0x11C4068", VA = "0x11C4068")]
	public static void FitOnScreen(this Camera cam, Transform transform, Transform content, Vector3 pos, out Bounds bounds)
	{
		bounds = default;
	}

	[Token(Token = "0x6001236")]
	[Address(RVA = "0x11C45D0", Offset = "0x11C45D0", VA = "0x11C45D0")]
	public static bool Save(string fileName, byte[] bytes)
	{
		return default(bool);
	}

	[Token(Token = "0x6001237")]
	[Address(RVA = "0x11C48F4", Offset = "0x11C48F4", VA = "0x11C48F4")]
	public static byte[] Load(string fileName)
	{
		return null;
	}

	[Token(Token = "0x6001238")]
	[Address(RVA = "0x11C4A54", Offset = "0x11C4A54", VA = "0x11C4A54")]
	public static Color ApplyPMA(Color c)
	{
		return default(Color);
	}

	[Token(Token = "0x6001239")]
	[Address(RVA = "0x11C4AA0", Offset = "0x11C4AA0", VA = "0x11C4AA0")]
	public static void MarkParentAsChanged(GameObject go)
	{
	}

	[Token(Token = "0x600123C")]
	[Address(RVA = "0x11C4D34", Offset = "0x11C4D34", VA = "0x11C4D34")]
	public static string EncodeColor(Color c)
	{
		return null;
	}

	[Token(Token = "0x600123D")]
	[Address(RVA = "0x11C4DFC", Offset = "0x11C4DFC", VA = "0x11C4DFC")]
	public static Color ParseColor(string text, int offset)
	{
		return default(Color);
	}

	[Token(Token = "0x600123E")]
	[Address(RVA = "0x11C4EB4", Offset = "0x11C4EB4", VA = "0x11C4EB4")]
	public static string StripSymbols(string text)
	{
		return null;
	}

	[Token(Token = "0x600123F")]
	public static T AddMissingComponent<T>(this GameObject go) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6001240")]
	[Address(RVA = "0x11C4F54", Offset = "0x11C4F54", VA = "0x11C4F54")]
	public static Vector3[] GetSides(this Camera cam)
	{
		return null;
	}

	[Token(Token = "0x6001241")]
	[Address(RVA = "0x11C5A8C", Offset = "0x11C5A8C", VA = "0x11C5A8C")]
	public static Vector3[] GetSides(this Camera cam, float depth)
	{
		return null;
	}

	[Token(Token = "0x6001242")]
	[Address(RVA = "0x11C5B40", Offset = "0x11C5B40", VA = "0x11C5B40")]
	public static Vector3[] GetSides(this Camera cam, Transform relativeTo)
	{
		return null;
	}

	[Token(Token = "0x6001243")]
	[Address(RVA = "0x11C5090", Offset = "0x11C5090", VA = "0x11C5090")]
	public static Vector3[] GetSides(this Camera cam, float depth, Transform relativeTo)
	{
		return null;
	}

	[Token(Token = "0x6001244")]
	[Address(RVA = "0x11C5CDC", Offset = "0x11C5CDC", VA = "0x11C5CDC")]
	public static Vector3[] GetWorldCorners(this Camera cam)
	{
		return null;
	}

	[Token(Token = "0x6001245")]
	[Address(RVA = "0x11C6788", Offset = "0x11C6788", VA = "0x11C6788")]
	public static Vector3[] GetWorldCorners(this Camera cam, float depth)
	{
		return null;
	}

	[Token(Token = "0x6001246")]
	[Address(RVA = "0x11C683C", Offset = "0x11C683C", VA = "0x11C683C")]
	public static Vector3[] GetWorldCorners(this Camera cam, Transform relativeTo)
	{
		return null;
	}

	[Token(Token = "0x6001247")]
	[Address(RVA = "0x11C5E18", Offset = "0x11C5E18", VA = "0x11C5E18")]
	public static Vector3[] GetWorldCorners(this Camera cam, float depth, Transform relativeTo)
	{
		return null;
	}

	[Token(Token = "0x6001248")]
	[Address(RVA = "0x11C697C", Offset = "0x11C697C", VA = "0x11C697C")]
	public static string GetFuncName(object obj, string method)
	{
		return null;
	}

	[Token(Token = "0x6001249")]
	public static void Execute<T>(GameObject go, string funcName) where T : Component
	{
	}

	[Token(Token = "0x600124A")]
	public static void ExecuteAll<T>(GameObject root, string funcName) where T : Component
	{
	}

	[Token(Token = "0x600124B")]
	[Address(RVA = "0x11C6B54", Offset = "0x11C6B54", VA = "0x11C6B54")]
	public static void ImmediatelyCreateDrawCalls(GameObject root)
	{
	}

	[Token(Token = "0x600124D")]
	[Address(RVA = "0x11C6C98", Offset = "0x11C6C98", VA = "0x11C6C98")]
	public static string KeyToCaption(KeyCode key)
	{
		return null;
	}

	[Token(Token = "0x600124E")]
	public static T Draw<T>(string id, [Optional] OnInitFunc<T> onInit) where T : UIWidget
	{
		return null;
	}

	[Token(Token = "0x600124F")]
	[Address(RVA = "0x11B8950", Offset = "0x11B8950", VA = "0x11B8950")]
	public static Color GammaToLinearSpace(this Color c)
	{
		return default(Color);
	}
}
