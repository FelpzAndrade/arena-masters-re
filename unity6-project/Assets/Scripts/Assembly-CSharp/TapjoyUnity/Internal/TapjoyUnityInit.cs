using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace TapjoyUnity.Internal
{
	[Token(Token = "0x20010D4")]
	public sealed class TapjoyUnityInit : MonoBehaviour
	{
		[Token(Token = "0x4005CB3")]
		[FieldOffset(Offset = "0x0")]
		private static bool initialized;

		[Token(Token = "0x4005CB4")]
		[FieldOffset(Offset = "0x4")]
		private static UnityAction<Scene, LoadSceneMode> _003C_003Ef__am_0024cache1;

		[Token(Token = "0x4005CB5")]
		[FieldOffset(Offset = "0x8")]
		private static UnityAction<Scene> _003C_003Ef__am_0024cache2;

		[Token(Token = "0x4005CB6")]
		[FieldOffset(Offset = "0xC")]
		private static TapjoyFunc<int> _003C_003Ef__am_0024cache3;

		[Token(Token = "0x4005CB7")]
		[FieldOffset(Offset = "0x10")]
		private static TapjoyFunc<int, object> _003C_003Ef__am_0024cache4;

		[Token(Token = "0x6007F14")]
		[Address(RVA = "0x1D4AF74", Offset = "0x1D4AF74", VA = "0x1D4AF74")]
		public TapjoyUnityInit()
		{
		}

		[Token(Token = "0x6007F16")]
		[Address(RVA = "0x1D4AF80", Offset = "0x1D4AF80", VA = "0x1D4AF80")]
		private void Awake()
		{
		}

		[Token(Token = "0x6007F17")]
		[Address(RVA = "0x1D4B530", Offset = "0x1D4B530", VA = "0x1D4B530")]
		private static void _003CAwake_003Em__540(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6007F18")]
		[Address(RVA = "0x1D4B618", Offset = "0x1D4B618", VA = "0x1D4B618")]
		private static void _003CAwake_003Em__541(Scene scene)
		{
		}

		[Token(Token = "0x6007F19")]
		[Address(RVA = "0x1D4B6FC", Offset = "0x1D4B6FC", VA = "0x1D4B6FC")]
		private static int _003CAwake_003Em__542()
		{
			return default(int);
		}

		[Token(Token = "0x6007F1A")]
		[Address(RVA = "0x1D4B708", Offset = "0x1D4B708", VA = "0x1D4B708")]
		private static object _003CAwake_003Em__543(int index)
		{
			return null;
		}
	}
}
