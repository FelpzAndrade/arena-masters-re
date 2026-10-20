using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20010F6")]
public class iTween : MonoBehaviour
{
	[Token(Token = "0x20010F7")]
	public enum EaseType
	{
		[Token(Token = "0x4005D3B")]
		easeInQuad = 0,
		[Token(Token = "0x4005D3C")]
		easeOutQuad = 1,
		[Token(Token = "0x4005D3D")]
		easeInOutQuad = 2,
		[Token(Token = "0x4005D3E")]
		easeInCubic = 3,
		[Token(Token = "0x4005D3F")]
		easeOutCubic = 4,
		[Token(Token = "0x4005D40")]
		easeInOutCubic = 5,
		[Token(Token = "0x4005D41")]
		easeInQuart = 6,
		[Token(Token = "0x4005D42")]
		easeOutQuart = 7,
		[Token(Token = "0x4005D43")]
		easeInOutQuart = 8,
		[Token(Token = "0x4005D44")]
		easeInQuint = 9,
		[Token(Token = "0x4005D45")]
		easeOutQuint = 10,
		[Token(Token = "0x4005D46")]
		easeInOutQuint = 11,
		[Token(Token = "0x4005D47")]
		easeInSine = 12,
		[Token(Token = "0x4005D48")]
		easeOutSine = 13,
		[Token(Token = "0x4005D49")]
		easeInOutSine = 14,
		[Token(Token = "0x4005D4A")]
		easeInExpo = 15,
		[Token(Token = "0x4005D4B")]
		easeOutExpo = 16,
		[Token(Token = "0x4005D4C")]
		easeInOutExpo = 17,
		[Token(Token = "0x4005D4D")]
		easeInCirc = 18,
		[Token(Token = "0x4005D4E")]
		easeOutCirc = 19,
		[Token(Token = "0x4005D4F")]
		easeInOutCirc = 20,
		[Token(Token = "0x4005D50")]
		linear = 21,
		[Token(Token = "0x4005D51")]
		spring = 22,
		[Token(Token = "0x4005D52")]
		easeInBounce = 23,
		[Token(Token = "0x4005D53")]
		easeOutBounce = 24,
		[Token(Token = "0x4005D54")]
		easeInOutBounce = 25,
		[Token(Token = "0x4005D55")]
		easeInBack = 26,
		[Token(Token = "0x4005D56")]
		easeOutBack = 27,
		[Token(Token = "0x4005D57")]
		easeInOutBack = 28,
		[Token(Token = "0x4005D58")]
		easeInElastic = 29,
		[Token(Token = "0x4005D59")]
		easeOutElastic = 30,
		[Token(Token = "0x4005D5A")]
		easeInOutElastic = 31,
		[Token(Token = "0x4005D5B")]
		punch = 32
	}

	[Token(Token = "0x20010F8")]
	public enum LoopType
	{
		[Token(Token = "0x4005D5D")]
		none = 0,
		[Token(Token = "0x4005D5E")]
		loop = 1,
		[Token(Token = "0x4005D5F")]
		pingPong = 2
	}

	[Token(Token = "0x20010F9")]
	public enum NamedValueColor
	{
		[Token(Token = "0x4005D61")]
		_Color = 0,
		[Token(Token = "0x4005D62")]
		_SpecColor = 1,
		[Token(Token = "0x4005D63")]
		_Emission = 2,
		[Token(Token = "0x4005D64")]
		_ReflectColor = 3
	}

	[Token(Token = "0x20010FA")]
	public static class Defaults
	{
		[Token(Token = "0x4005D65")]
		[FieldOffset(Offset = "0x0")]
		public static float time;

		[Token(Token = "0x4005D66")]
		[FieldOffset(Offset = "0x4")]
		public static float delay;

		[Token(Token = "0x4005D67")]
		[FieldOffset(Offset = "0x8")]
		public static NamedValueColor namedColorValue;

		[Token(Token = "0x4005D68")]
		[FieldOffset(Offset = "0xC")]
		public static LoopType loopType;

		[Token(Token = "0x4005D69")]
		[FieldOffset(Offset = "0x10")]
		public static EaseType easeType;

		[Token(Token = "0x4005D6A")]
		[FieldOffset(Offset = "0x14")]
		public static float lookSpeed;

		[Token(Token = "0x4005D6B")]
		[FieldOffset(Offset = "0x18")]
		public static bool isLocal;

		[Token(Token = "0x4005D6C")]
		[FieldOffset(Offset = "0x1C")]
		public static Space space;

		[Token(Token = "0x4005D6D")]
		[FieldOffset(Offset = "0x20")]
		public static bool orientToPath;

		[Token(Token = "0x4005D6E")]
		[FieldOffset(Offset = "0x24")]
		public static Color color;

		[Token(Token = "0x4005D6F")]
		[FieldOffset(Offset = "0x34")]
		public static float updateTimePercentage;

		[Token(Token = "0x4005D70")]
		[FieldOffset(Offset = "0x38")]
		public static float updateTime;

		[Token(Token = "0x4005D71")]
		[FieldOffset(Offset = "0x3C")]
		public static int cameraFadeDepth;

		[Token(Token = "0x4005D72")]
		[FieldOffset(Offset = "0x40")]
		public static float lookAhead;

		[Token(Token = "0x4005D73")]
		[FieldOffset(Offset = "0x44")]
		public static bool useRealTime;

		[Token(Token = "0x4005D74")]
		[FieldOffset(Offset = "0x48")]
		public static Vector3 up;
	}

	[Token(Token = "0x20010FB")]
	private class CRSpline
	{
		[Token(Token = "0x4005D75")]
		[FieldOffset(Offset = "0x8")]
		public Vector3[] pts;

		[Token(Token = "0x60080A5")]
		[Address(RVA = "0xDAEDA4", Offset = "0xDAEDA4", VA = "0xDAEDA4")]
		public CRSpline(params Vector3[] pts)
		{
		}

		[Token(Token = "0x60080A6")]
		[Address(RVA = "0xDB143C", Offset = "0xDB143C", VA = "0xDB143C")]
		public Vector3 Interp(float t)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x20010FC")]
	private delegate float EasingFunction(float start, float end, float value);

	[Token(Token = "0x20010FD")]
	private delegate void ApplyTween();

	[Token(Token = "0x20010FE")]
	private sealed class _003CTweenDelay_003Ec__IteratorBE : IDisposable
	{
		[Token(Token = "0x4005D76")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4005D77")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4005D78")]
		[FieldOffset(Offset = "0x10")]
		internal iTween _003C_003Ef__this;

		[Token(Token = "0x17000FA4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60080B0")]
			[Address(RVA = "0xDCCBE8", Offset = "0xDCCBE8", VA = "0xDCCBE8", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000FA5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60080B1")]
			[Address(RVA = "0xDCCBF0", Offset = "0xDCCBF0", VA = "0xDCCBF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60080AF")]
		[Address(RVA = "0xDB550C", Offset = "0xDB550C", VA = "0xDB550C")]
		public _003CTweenDelay_003Ec__IteratorBE()
		{
		}

		[Token(Token = "0x60080B0")]
		[Address(RVA = "0xDCCBE8", Offset = "0xDCCBE8", VA = "0xDCCBE8", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60080B1")]
		[Address(RVA = "0xDCCBF0", Offset = "0xDCCBF0", VA = "0xDCCBF0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60080B2")]
		[Address(RVA = "0xDCCBF8", Offset = "0xDCCBF8", VA = "0xDCCBF8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60080B3")]
		[Address(RVA = "0xDCCD2C", Offset = "0xDCCD2C", VA = "0xDCCD2C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60080B4")]
		[Address(RVA = "0xDCCD38", Offset = "0xDCCD38", VA = "0xDCCD38", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20010FF")]
	private sealed class _003CTweenRestart_003Ec__IteratorBF : IDisposable
	{
		[Token(Token = "0x4005D79")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4005D7A")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4005D7B")]
		[FieldOffset(Offset = "0x10")]
		internal iTween _003C_003Ef__this;

		[Token(Token = "0x17000FA6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60080B6")]
			[Address(RVA = "0xDCCDCC", Offset = "0xDCCDCC", VA = "0xDCCDCC", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000FA7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60080B7")]
			[Address(RVA = "0xDCCDD4", Offset = "0xDCCDD4", VA = "0xDCCDD4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60080B5")]
		[Address(RVA = "0xDB6A54", Offset = "0xDB6A54", VA = "0xDB6A54")]
		public _003CTweenRestart_003Ec__IteratorBF()
		{
		}

		[Token(Token = "0x60080B6")]
		[Address(RVA = "0xDCCDCC", Offset = "0xDCCDCC", VA = "0xDCCDCC", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60080B7")]
		[Address(RVA = "0xDCCDD4", Offset = "0xDCCDD4", VA = "0xDCCDD4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60080B8")]
		[Address(RVA = "0xDCCDDC", Offset = "0xDCCDDC", VA = "0xDCCDDC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60080B9")]
		[Address(RVA = "0xDCCF18", Offset = "0xDCCF18", VA = "0xDCCF18", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60080BA")]
		[Address(RVA = "0xDCCF24", Offset = "0xDCCF24", VA = "0xDCCF24", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001100")]
	private sealed class _003CStart_003Ec__IteratorC0 : IDisposable
	{
		[Token(Token = "0x4005D7C")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4005D7D")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4005D7E")]
		[FieldOffset(Offset = "0x10")]
		internal iTween _003C_003Ef__this;

		[Token(Token = "0x17000FA8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60080BC")]
			[Address(RVA = "0xDCCA3C", Offset = "0xDCCA3C", VA = "0xDCCA3C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000FA9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60080BD")]
			[Address(RVA = "0xDCCA44", Offset = "0xDCCA44", VA = "0xDCCA44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60080BB")]
		[Address(RVA = "0xDCAA0C", Offset = "0xDCAA0C", VA = "0xDCAA0C")]
		public _003CStart_003Ec__IteratorC0()
		{
		}

		[Token(Token = "0x60080BC")]
		[Address(RVA = "0xDCCA3C", Offset = "0xDCCA3C", VA = "0xDCCA3C", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60080BD")]
		[Address(RVA = "0xDCCA44", Offset = "0xDCCA44", VA = "0xDCCA44", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60080BE")]
		[Address(RVA = "0xDCCA4C", Offset = "0xDCCA4C", VA = "0xDCCA4C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60080BF")]
		[Address(RVA = "0xDCCB48", Offset = "0xDCCB48", VA = "0xDCCB48", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60080C0")]
		[Address(RVA = "0xDCCB54", Offset = "0xDCCB54", VA = "0xDCCB54", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4005D08")]
	[FieldOffset(Offset = "0x0")]
	public static ArrayList tweens;

	[Token(Token = "0x4005D09")]
	[FieldOffset(Offset = "0x4")]
	private static GameObject cameraFade;

	[Token(Token = "0x4005D0A")]
	[FieldOffset(Offset = "0xC")]
	public string id;

	[Token(Token = "0x4005D0B")]
	[FieldOffset(Offset = "0x10")]
	public string type;

	[Token(Token = "0x4005D0C")]
	[FieldOffset(Offset = "0x14")]
	public string method;

	[Token(Token = "0x4005D0D")]
	[FieldOffset(Offset = "0x18")]
	public EaseType easeType;

	[Token(Token = "0x4005D0E")]
	[FieldOffset(Offset = "0x1C")]
	public float time;

	[Token(Token = "0x4005D0F")]
	[FieldOffset(Offset = "0x20")]
	public float delay;

	[Token(Token = "0x4005D10")]
	[FieldOffset(Offset = "0x24")]
	public LoopType loopType;

	[Token(Token = "0x4005D11")]
	[FieldOffset(Offset = "0x28")]
	public bool isRunning;

	[Token(Token = "0x4005D12")]
	[FieldOffset(Offset = "0x29")]
	public bool isPaused;

	[Token(Token = "0x4005D13")]
	[FieldOffset(Offset = "0x2C")]
	public string _name;

	[Token(Token = "0x4005D14")]
	[FieldOffset(Offset = "0x30")]
	private float runningTime;

	[Token(Token = "0x4005D15")]
	[FieldOffset(Offset = "0x34")]
	private float percentage;

	[Token(Token = "0x4005D16")]
	[FieldOffset(Offset = "0x38")]
	private float delayStarted;

	[Token(Token = "0x4005D17")]
	[FieldOffset(Offset = "0x3C")]
	private bool kinematic;

	[Token(Token = "0x4005D18")]
	[FieldOffset(Offset = "0x3D")]
	private bool isLocal;

	[Token(Token = "0x4005D19")]
	[FieldOffset(Offset = "0x3E")]
	private bool loop;

	[Token(Token = "0x4005D1A")]
	[FieldOffset(Offset = "0x3F")]
	private bool reverse;

	[Token(Token = "0x4005D1B")]
	[FieldOffset(Offset = "0x40")]
	private bool wasPaused;

	[Token(Token = "0x4005D1C")]
	[FieldOffset(Offset = "0x41")]
	private bool physics;

	[Token(Token = "0x4005D1D")]
	[FieldOffset(Offset = "0x44")]
	private Hashtable tweenArguments;

	[Token(Token = "0x4005D1E")]
	[FieldOffset(Offset = "0x48")]
	private Space space;

	[Token(Token = "0x4005D1F")]
	[FieldOffset(Offset = "0x4C")]
	private EasingFunction ease;

	[Token(Token = "0x4005D20")]
	[FieldOffset(Offset = "0x50")]
	private ApplyTween apply;

	[Token(Token = "0x4005D21")]
	[FieldOffset(Offset = "0x54")]
	private AudioSource audioSource;

	[Token(Token = "0x4005D22")]
	[FieldOffset(Offset = "0x58")]
	private Vector3[] vector3s;

	[Token(Token = "0x4005D23")]
	[FieldOffset(Offset = "0x5C")]
	private Vector2[] vector2s;

	[Token(Token = "0x4005D24")]
	[FieldOffset(Offset = "0x60")]
	private Color[,] colors;

	[Token(Token = "0x4005D25")]
	[FieldOffset(Offset = "0x64")]
	private float[] floats;

	[Token(Token = "0x4005D26")]
	[FieldOffset(Offset = "0x68")]
	private Rect[] rects;

	[Token(Token = "0x4005D27")]
	[FieldOffset(Offset = "0x6C")]
	private CRSpline path;

	[Token(Token = "0x4005D28")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 preUpdate;

	[Token(Token = "0x4005D29")]
	[FieldOffset(Offset = "0x7C")]
	private Vector3 postUpdate;

	[Token(Token = "0x4005D2A")]
	[FieldOffset(Offset = "0x88")]
	private NamedValueColor namedcolorvalue;

	[Token(Token = "0x4005D2B")]
	[FieldOffset(Offset = "0x8C")]
	private float lastRealTime;

	[Token(Token = "0x4005D2C")]
	[FieldOffset(Offset = "0x90")]
	private bool useRealTime;

	[Token(Token = "0x4005D2D")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map20;

	[Token(Token = "0x4005D2E")]
	[FieldOffset(Offset = "0xC")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map21;

	[Token(Token = "0x4005D2F")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map22;

	[Token(Token = "0x4005D30")]
	[FieldOffset(Offset = "0x14")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map23;

	[Token(Token = "0x4005D31")]
	[FieldOffset(Offset = "0x18")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map24;

	[Token(Token = "0x4005D32")]
	[FieldOffset(Offset = "0x1C")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map25;

	[Token(Token = "0x4005D33")]
	[FieldOffset(Offset = "0x20")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map26;

	[Token(Token = "0x4005D34")]
	[FieldOffset(Offset = "0x24")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map27;

	[Token(Token = "0x4005D35")]
	[FieldOffset(Offset = "0x28")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map28;

	[Token(Token = "0x4005D36")]
	[FieldOffset(Offset = "0x2C")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map29;

	[Token(Token = "0x4005D37")]
	[FieldOffset(Offset = "0x30")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map2A;

	[Token(Token = "0x4005D38")]
	[FieldOffset(Offset = "0x34")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map2B;

	[Token(Token = "0x4005D39")]
	[FieldOffset(Offset = "0x38")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map2C;

	[Token(Token = "0x6007FA6")]
	[Address(RVA = "0xD93204", Offset = "0xD93204", VA = "0xD93204")]
	public iTween()
	{
	}

	[Token(Token = "0x6007FA8")]
	[Address(RVA = "0xD932AC", Offset = "0xD932AC", VA = "0xD932AC")]
	public static void Init(GameObject target)
	{
	}

	[Token(Token = "0x6007FA9")]
	[Address(RVA = "0xD93634", Offset = "0xD93634", VA = "0xD93634")]
	public static void CameraFadeFrom(float amount, float time)
	{
	}

	[Token(Token = "0x6007FAA")]
	[Address(RVA = "0xD93B9C", Offset = "0xD93B9C", VA = "0xD93B9C")]
	public static void CameraFadeFrom(Hashtable args)
	{
	}

	[Token(Token = "0x6007FAB")]
	[Address(RVA = "0xD951C0", Offset = "0xD951C0", VA = "0xD951C0")]
	public static void CameraFadeTo(float amount, float time)
	{
	}

	[Token(Token = "0x6007FAC")]
	[Address(RVA = "0xD9556C", Offset = "0xD9556C", VA = "0xD9556C")]
	public static void CameraFadeTo(Hashtable args)
	{
	}

	[Token(Token = "0x6007FAD")]
	[Address(RVA = "0xD95E60", Offset = "0xD95E60", VA = "0xD95E60")]
	public static void ValueTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FAE")]
	[Address(RVA = "0xD976B8", Offset = "0xD976B8", VA = "0xD976B8")]
	public static void FadeFrom(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6007FAF")]
	[Address(RVA = "0xD97964", Offset = "0xD97964", VA = "0xD97964")]
	public static void FadeFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FB0")]
	[Address(RVA = "0xD97A0C", Offset = "0xD97A0C", VA = "0xD97A0C")]
	public static void FadeTo(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6007FB1")]
	[Address(RVA = "0xD97CB8", Offset = "0xD97CB8", VA = "0xD97CB8")]
	public static void FadeTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FB2")]
	[Address(RVA = "0xD97D60", Offset = "0xD97D60", VA = "0xD97D60")]
	public static void ColorFrom(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x6007FB3")]
	[Address(RVA = "0xD93D58", Offset = "0xD93D58", VA = "0xD93D58")]
	public static void ColorFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FB4")]
	[Address(RVA = "0xD9802C", Offset = "0xD9802C", VA = "0xD9802C")]
	public static void ColorTo(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x6007FB5")]
	[Address(RVA = "0xD95728", Offset = "0xD95728", VA = "0xD95728")]
	public static void ColorTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FB6")]
	[Address(RVA = "0xD982F8", Offset = "0xD982F8", VA = "0xD982F8")]
	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6007FB7")]
	[Address(RVA = "0xD98670", Offset = "0xD98670", VA = "0xD98670")]
	public static void AudioFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FB8")]
	[Address(RVA = "0xD98EB8", Offset = "0xD98EB8", VA = "0xD98EB8")]
	public static void AudioTo(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6007FB9")]
	[Address(RVA = "0xD99230", Offset = "0xD99230", VA = "0xD99230")]
	public static void AudioTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FBA")]
	[Address(RVA = "0xD994B8", Offset = "0xD994B8", VA = "0xD994B8")]
	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
	}

	[Token(Token = "0x6007FBB")]
	[Address(RVA = "0xD99748", Offset = "0xD99748", VA = "0xD99748")]
	public static void Stab(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FBC")]
	[Address(RVA = "0xD99870", Offset = "0xD99870", VA = "0xD99870")]
	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6007FBD")]
	[Address(RVA = "0xD99B2C", Offset = "0xD99B2C", VA = "0xD99B2C")]
	public static void LookFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FBE")]
	[Address(RVA = "0xD9A76C", Offset = "0xD9A76C", VA = "0xD9A76C")]
	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6007FBF")]
	[Address(RVA = "0xD9AA28", Offset = "0xD9AA28", VA = "0xD9AA28")]
	public static void LookTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FC0")]
	[Address(RVA = "0xD9AF28", Offset = "0xD9AF28", VA = "0xD9AF28")]
	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6007FC1")]
	[Address(RVA = "0xD9B1E4", Offset = "0xD9B1E4", VA = "0xD9B1E4")]
	public static void MoveTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FC2")]
	[Address(RVA = "0xD9B7B4", Offset = "0xD9B7B4", VA = "0xD9B7B4")]
	public static void MoveFrom(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6007FC3")]
	[Address(RVA = "0xD9BA70", Offset = "0xD9BA70", VA = "0xD9BA70")]
	public static void MoveFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FC4")]
	[Address(RVA = "0xD9C97C", Offset = "0xD9C97C", VA = "0xD9C97C")]
	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6007FC5")]
	[Address(RVA = "0xD9CC38", Offset = "0xD9CC38", VA = "0xD9CC38")]
	public static void MoveAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FC6")]
	[Address(RVA = "0xD93378", Offset = "0xD93378", VA = "0xD93378")]
	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6007FC7")]
	[Address(RVA = "0xD9CDC0", Offset = "0xD9CDC0", VA = "0xD9CDC0")]
	public static void MoveBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FC8")]
	[Address(RVA = "0xD9CF48", Offset = "0xD9CF48", VA = "0xD9CF48")]
	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6007FC9")]
	[Address(RVA = "0xD9D204", Offset = "0xD9D204", VA = "0xD9D204")]
	public static void ScaleTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FCA")]
	[Address(RVA = "0xD9D7D4", Offset = "0xD9D7D4", VA = "0xD9D7D4")]
	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6007FCB")]
	[Address(RVA = "0xD9DA90", Offset = "0xD9DA90", VA = "0xD9DA90")]
	public static void ScaleFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FCC")]
	[Address(RVA = "0xD9E230", Offset = "0xD9E230", VA = "0xD9E230")]
	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6007FCD")]
	[Address(RVA = "0xD9E4EC", Offset = "0xD9E4EC", VA = "0xD9E4EC")]
	public static void ScaleAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FCE")]
	[Address(RVA = "0xD9E674", Offset = "0xD9E674", VA = "0xD9E674")]
	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6007FCF")]
	[Address(RVA = "0xD9E930", Offset = "0xD9E930", VA = "0xD9E930")]
	public static void ScaleBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FD0")]
	[Address(RVA = "0xD9EAB8", Offset = "0xD9EAB8", VA = "0xD9EAB8")]
	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6007FD1")]
	[Address(RVA = "0xD9ED74", Offset = "0xD9ED74", VA = "0xD9ED74")]
	public static void RotateTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FD2")]
	[Address(RVA = "0xD9F348", Offset = "0xD9F348", VA = "0xD9F348")]
	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6007FD3")]
	[Address(RVA = "0xD9F604", Offset = "0xD9F604", VA = "0xD9F604")]
	public static void RotateFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FD4")]
	[Address(RVA = "0xD9FF1C", Offset = "0xD9FF1C", VA = "0xD9FF1C")]
	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6007FD5")]
	[Address(RVA = "0xDA01D8", Offset = "0xDA01D8", VA = "0xDA01D8")]
	public static void RotateAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FD6")]
	[Address(RVA = "0xDA0360", Offset = "0xDA0360", VA = "0xDA0360")]
	public static void RotateBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6007FD7")]
	[Address(RVA = "0xDA061C", Offset = "0xDA061C", VA = "0xDA061C")]
	public static void RotateBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FD8")]
	[Address(RVA = "0xDA07A4", Offset = "0xDA07A4", VA = "0xDA07A4")]
	public static void ShakePosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6007FD9")]
	[Address(RVA = "0xDA0A60", Offset = "0xDA0A60", VA = "0xDA0A60")]
	public static void ShakePosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FDA")]
	[Address(RVA = "0xDA0BE8", Offset = "0xDA0BE8", VA = "0xDA0BE8")]
	public static void ShakeScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6007FDB")]
	[Address(RVA = "0xDA0EA4", Offset = "0xDA0EA4", VA = "0xDA0EA4")]
	public static void ShakeScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FDC")]
	[Address(RVA = "0xDA102C", Offset = "0xDA102C", VA = "0xDA102C")]
	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6007FDD")]
	[Address(RVA = "0xDA12E8", Offset = "0xDA12E8", VA = "0xDA12E8")]
	public static void ShakeRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FDE")]
	[Address(RVA = "0xDA1470", Offset = "0xDA1470", VA = "0xDA1470")]
	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6007FDF")]
	[Address(RVA = "0xDA172C", Offset = "0xDA172C", VA = "0xDA172C")]
	public static void PunchPosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FE0")]
	[Address(RVA = "0xDA1930", Offset = "0xDA1930", VA = "0xDA1930")]
	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6007FE1")]
	[Address(RVA = "0xDA1BEC", Offset = "0xDA1BEC", VA = "0xDA1BEC")]
	public static void PunchRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FE2")]
	[Address(RVA = "0xDA1DF0", Offset = "0xDA1DF0", VA = "0xDA1DF0")]
	public static void PunchScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6007FE3")]
	[Address(RVA = "0xDA20AC", Offset = "0xDA20AC", VA = "0xDA20AC")]
	public static void PunchScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6007FE4")]
	[Address(RVA = "0xDA22B0", Offset = "0xDA22B0", VA = "0xDA22B0")]
	private void GenerateTargets()
	{
	}

	[Token(Token = "0x6007FE5")]
	[Address(RVA = "0xDA46D8", Offset = "0xDA46D8", VA = "0xDA46D8")]
	private void GenerateRectTargets()
	{
	}

	[Token(Token = "0x6007FE6")]
	[Address(RVA = "0xDA4510", Offset = "0xDA4510", VA = "0xDA4510")]
	private void GenerateColorTargets()
	{
	}

	[Token(Token = "0x6007FE7")]
	[Address(RVA = "0xDA41BC", Offset = "0xDA41BC", VA = "0xDA41BC")]
	private void GenerateVector3Targets()
	{
	}

	[Token(Token = "0x6007FE8")]
	[Address(RVA = "0xDA3DCC", Offset = "0xDA3DCC", VA = "0xDA3DCC")]
	private void GenerateVector2Targets()
	{
	}

	[Token(Token = "0x6007FE9")]
	[Address(RVA = "0xDA3A98", Offset = "0xDA3A98", VA = "0xDA3A98")]
	private void GenerateFloatTargets()
	{
	}

	[Token(Token = "0x6007FEA")]
	[Address(RVA = "0xDA48C0", Offset = "0xDA48C0", VA = "0xDA48C0")]
	private void GenerateColorToTargets()
	{
	}

	[Token(Token = "0x6007FEB")]
	[Address(RVA = "0xDA58F4", Offset = "0xDA58F4", VA = "0xDA58F4")]
	private void GenerateAudioToTargets()
	{
	}

	[Token(Token = "0x6007FEC")]
	[Address(RVA = "0xDAE0A4", Offset = "0xDAE0A4", VA = "0xDAE0A4")]
	private void GenerateStabTargets()
	{
	}

	[Token(Token = "0x6007FED")]
	[Address(RVA = "0xDAD028", Offset = "0xDAD028", VA = "0xDAD028")]
	private void GenerateLookToTargets()
	{
	}

	[Token(Token = "0x6007FEE")]
	[Address(RVA = "0xDA5F34", Offset = "0xDA5F34", VA = "0xDA5F34")]
	private void GenerateMoveToPathTargets()
	{
	}

	[Token(Token = "0x6007FEF")]
	[Address(RVA = "0xDA6B08", Offset = "0xDA6B08", VA = "0xDA6B08")]
	private void GenerateMoveToTargets()
	{
	}

	[Token(Token = "0x6007FF0")]
	[Address(RVA = "0xDA75C8", Offset = "0xDA75C8", VA = "0xDA75C8")]
	private void GenerateMoveByTargets()
	{
	}

	[Token(Token = "0x6007FF1")]
	[Address(RVA = "0xDA806C", Offset = "0xDA806C", VA = "0xDA806C")]
	private void GenerateScaleToTargets()
	{
	}

	[Token(Token = "0x6007FF2")]
	[Address(RVA = "0xDA8910", Offset = "0xDA8910", VA = "0xDA8910")]
	private void GenerateScaleByTargets()
	{
	}

	[Token(Token = "0x6007FF3")]
	[Address(RVA = "0xDA902C", Offset = "0xDA902C", VA = "0xDA902C")]
	private void GenerateScaleAddTargets()
	{
	}

	[Token(Token = "0x6007FF4")]
	[Address(RVA = "0xDA9728", Offset = "0xDA9728", VA = "0xDA9728")]
	private void GenerateRotateToTargets()
	{
	}

	[Token(Token = "0x6007FF5")]
	[Address(RVA = "0xDAA1C8", Offset = "0xDAA1C8", VA = "0xDAA1C8")]
	private void GenerateRotateAddTargets()
	{
	}

	[Token(Token = "0x6007FF6")]
	[Address(RVA = "0xDAA908", Offset = "0xDAA908", VA = "0xDAA908")]
	private void GenerateRotateByTargets()
	{
	}

	[Token(Token = "0x6007FF7")]
	[Address(RVA = "0xDAB0B8", Offset = "0xDAB0B8", VA = "0xDAB0B8")]
	private void GenerateShakePositionTargets()
	{
	}

	[Token(Token = "0x6007FF8")]
	[Address(RVA = "0xDAB5EC", Offset = "0xDAB5EC", VA = "0xDAB5EC")]
	private void GenerateShakeScaleTargets()
	{
	}

	[Token(Token = "0x6007FF9")]
	[Address(RVA = "0xDABACC", Offset = "0xDABACC", VA = "0xDABACC")]
	private void GenerateShakeRotationTargets()
	{
	}

	[Token(Token = "0x6007FFA")]
	[Address(RVA = "0xDABFAC", Offset = "0xDABFAC", VA = "0xDABFAC")]
	private void GeneratePunchPositionTargets()
	{
	}

	[Token(Token = "0x6007FFB")]
	[Address(RVA = "0xDAC584", Offset = "0xDAC584", VA = "0xDAC584")]
	private void GeneratePunchRotationTargets()
	{
	}

	[Token(Token = "0x6007FFC")]
	[Address(RVA = "0xDACB08", Offset = "0xDACB08", VA = "0xDACB08")]
	private void GeneratePunchScaleTargets()
	{
	}

	[Token(Token = "0x6007FFD")]
	[Address(RVA = "0xDAF054", Offset = "0xDAF054", VA = "0xDAF054")]
	private void ApplyRectTargets()
	{
	}

	[Token(Token = "0x6007FFE")]
	[Address(RVA = "0xDAF5C4", Offset = "0xDAF5C4", VA = "0xDAF5C4")]
	private void ApplyColorTargets()
	{
	}

	[Token(Token = "0x6007FFF")]
	[Address(RVA = "0xDAF838", Offset = "0xDAF838", VA = "0xDAF838")]
	private void ApplyVector3Targets()
	{
	}

	[Token(Token = "0x6008000")]
	[Address(RVA = "0xDAFBF4", Offset = "0xDAFBF4", VA = "0xDAFBF4")]
	private void ApplyVector2Targets()
	{
	}

	[Token(Token = "0x6008001")]
	[Address(RVA = "0xDAFF18", Offset = "0xDAFF18", VA = "0xDAFF18")]
	private void ApplyFloatTargets()
	{
	}

	[Token(Token = "0x6008002")]
	[Address(RVA = "0xDB0188", Offset = "0xDB0188", VA = "0xDB0188")]
	private void ApplyColorToTargets()
	{
	}

	[Token(Token = "0x6008003")]
	[Address(RVA = "0xDB0BD8", Offset = "0xDB0BD8", VA = "0xDB0BD8")]
	private void ApplyAudioToTargets()
	{
	}

	[Token(Token = "0x6008004")]
	[Address(RVA = "0xDB0E44", Offset = "0xDB0E44", VA = "0xDB0E44")]
	private void ApplyStabTargets()
	{
	}

	[Token(Token = "0x6008005")]
	[Address(RVA = "0xDB0E48", Offset = "0xDB0E48", VA = "0xDB0E48")]
	private void ApplyMoveToPathTargets()
	{
	}

	[Token(Token = "0x6008006")]
	[Address(RVA = "0xDB19F4", Offset = "0xDB19F4", VA = "0xDB19F4")]
	private void ApplyMoveToTargets()
	{
	}

	[Token(Token = "0x6008007")]
	[Address(RVA = "0xDB1E48", Offset = "0xDB1E48", VA = "0xDB1E48")]
	private void ApplyMoveByTargets()
	{
	}

	[Token(Token = "0x6008008")]
	[Address(RVA = "0xDB2438", Offset = "0xDB2438", VA = "0xDB2438")]
	private void ApplyScaleToTargets()
	{
	}

	[Token(Token = "0x6008009")]
	[Address(RVA = "0xDB26E0", Offset = "0xDB26E0", VA = "0xDB26E0")]
	private void ApplyLookToTargets()
	{
	}

	[Token(Token = "0x600800A")]
	[Address(RVA = "0xDB29A4", Offset = "0xDB29A4", VA = "0xDB29A4")]
	private void ApplyRotateToTargets()
	{
	}

	[Token(Token = "0x600800B")]
	[Address(RVA = "0xDB2EA0", Offset = "0xDB2EA0", VA = "0xDB2EA0")]
	private void ApplyRotateAddTargets()
	{
	}

	[Token(Token = "0x600800C")]
	[Address(RVA = "0xDB32D8", Offset = "0xDB32D8", VA = "0xDB32D8")]
	private void ApplyShakePositionTargets()
	{
	}

	[Token(Token = "0x600800D")]
	[Address(RVA = "0xDB38D0", Offset = "0xDB38D0", VA = "0xDB38D0")]
	private void ApplyShakeScaleTargets()
	{
	}

	[Token(Token = "0x600800E")]
	[Address(RVA = "0xDB3C10", Offset = "0xDB3C10", VA = "0xDB3C10")]
	private void ApplyShakeRotationTargets()
	{
	}

	[Token(Token = "0x600800F")]
	[Address(RVA = "0xDB406C", Offset = "0xDB406C", VA = "0xDB406C")]
	private void ApplyPunchPositionTargets()
	{
	}

	[Token(Token = "0x6008010")]
	[Address(RVA = "0xDB4970", Offset = "0xDB4970", VA = "0xDB4970")]
	private void ApplyPunchRotationTargets()
	{
	}

	[Token(Token = "0x6008011")]
	[Address(RVA = "0xDB4F98", Offset = "0xDB4F98", VA = "0xDB4F98")]
	private void ApplyPunchScaleTargets()
	{
	}

	[Token(Token = "0x6008012")]
	[Address(RVA = "0xDB5468", Offset = "0xDB5468", VA = "0xDB5468")]
	[DebuggerHidden]
	private IEnumerator TweenDelay()
	{
		return null;
	}

	[Token(Token = "0x6008013")]
	[Address(RVA = "0xDB5514", Offset = "0xDB5514", VA = "0xDB5514")]
	private void TweenStart()
	{
	}

	[Token(Token = "0x6008014")]
	[Address(RVA = "0xDB69B0", Offset = "0xDB69B0", VA = "0xDB69B0")]
	[DebuggerHidden]
	private IEnumerator TweenRestart()
	{
		return null;
	}

	[Token(Token = "0x6008015")]
	[Address(RVA = "0xDB6A5C", Offset = "0xDB6A5C", VA = "0xDB6A5C")]
	private void TweenUpdate()
	{
	}

	[Token(Token = "0x6008016")]
	[Address(RVA = "0xDB6C20", Offset = "0xDB6C20", VA = "0xDB6C20")]
	private void TweenComplete()
	{
	}

	[Token(Token = "0x6008017")]
	[Address(RVA = "0xDB6DA4", Offset = "0xDB6DA4", VA = "0xDB6DA4")]
	private void TweenLoop()
	{
	}

	[Token(Token = "0x6008018")]
	[Address(RVA = "0xDB6E98", Offset = "0xDB6E98", VA = "0xDB6E98")]
	public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
	{
		return default(Rect);
	}

	[Token(Token = "0x6008019")]
	[Address(RVA = "0xDB7118", Offset = "0xDB7118", VA = "0xDB7118")]
	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600801A")]
	[Address(RVA = "0xDB71F0", Offset = "0xDB71F0", VA = "0xDB71F0")]
	public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600801B")]
	[Address(RVA = "0xDB70D4", Offset = "0xDB70D4", VA = "0xDB70D4")]
	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		return default(float);
	}

	[Token(Token = "0x600801C")]
	[Address(RVA = "0xDB729C", Offset = "0xDB729C", VA = "0xDB729C")]
	public static void FadeUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600801D")]
	[Address(RVA = "0xDB8898", Offset = "0xDB8898", VA = "0xDB8898")]
	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x600801E")]
	[Address(RVA = "0xDB73F8", Offset = "0xDB73F8", VA = "0xDB73F8")]
	public static void ColorUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600801F")]
	[Address(RVA = "0xDB8B44", Offset = "0xDB8B44", VA = "0xDB8B44")]
	public static void ColorUpdate(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x6008020")]
	[Address(RVA = "0xDB8E10", Offset = "0xDB8E10", VA = "0xDB8E10")]
	public static void AudioUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6008021")]
	[Address(RVA = "0xDB9740", Offset = "0xDB9740", VA = "0xDB9740")]
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6008022")]
	[Address(RVA = "0xDB9AB8", Offset = "0xDB9AB8", VA = "0xDB9AB8")]
	public static void RotateUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6008023")]
	[Address(RVA = "0xDBA550", Offset = "0xDBA550", VA = "0xDBA550")]
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6008024")]
	[Address(RVA = "0xDBA80C", Offset = "0xDBA80C", VA = "0xDBA80C")]
	public static void ScaleUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6008025")]
	[Address(RVA = "0xDBB29C", Offset = "0xDBB29C", VA = "0xDBB29C")]
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6008026")]
	[Address(RVA = "0xDBB558", Offset = "0xDBB558", VA = "0xDBB558")]
	public static void MoveUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6008027")]
	[Address(RVA = "0xDBD728", Offset = "0xDBD728", VA = "0xDBD728")]
	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6008028")]
	[Address(RVA = "0xDBC4C4", Offset = "0xDBC4C4", VA = "0xDBC4C4")]
	public static void LookUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6008029")]
	[Address(RVA = "0xDBD9E4", Offset = "0xDBD9E4", VA = "0xDBD9E4")]
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x600802A")]
	[Address(RVA = "0xDBDCA0", Offset = "0xDBDCA0", VA = "0xDBDCA0")]
	public static float PathLength(Transform[] path)
	{
		return default(float);
	}

	[Token(Token = "0x600802B")]
	[Address(RVA = "0xDAEE84", Offset = "0xDAEE84", VA = "0xDAEE84")]
	public static float PathLength(Vector3[] path)
	{
		return default(float);
	}

	[Token(Token = "0x600802C")]
	[Address(RVA = "0xDBE8DC", Offset = "0xDBE8DC", VA = "0xDBE8DC")]
	public static Texture2D CameraTexture(Color color)
	{
		return null;
	}

	[Token(Token = "0x600802D")]
	[Address(RVA = "0xDBEA70", Offset = "0xDBEA70", VA = "0xDBEA70")]
	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x600802E")]
	[Address(RVA = "0xDBEB74", Offset = "0xDBEB74", VA = "0xDBEB74")]
	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x600802F")]
	[Address(RVA = "0xDBEC60", Offset = "0xDBEC60", VA = "0xDBEC60")]
	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x6008030")]
	[Address(RVA = "0xDBEE30", Offset = "0xDBEE30", VA = "0xDBEE30")]
	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x6008031")]
	[Address(RVA = "0xDBEFE8", Offset = "0xDBEFE8", VA = "0xDBEFE8")]
	public static Vector3 PointOnPath(Transform[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6008032")]
	[Address(RVA = "0xDBF180", Offset = "0xDBF180", VA = "0xDBF180")]
	public static void DrawLine(Vector3[] line)
	{
	}

	[Token(Token = "0x6008033")]
	[Address(RVA = "0xDBF568", Offset = "0xDBF568", VA = "0xDBF568")]
	public static void DrawLine(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6008034")]
	[Address(RVA = "0xDBF66C", Offset = "0xDBF66C", VA = "0xDBF66C")]
	public static void DrawLine(Transform[] line)
	{
	}

	[Token(Token = "0x6008035")]
	[Address(RVA = "0xDBF87C", Offset = "0xDBF87C", VA = "0xDBF87C")]
	public static void DrawLine(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6008036")]
	[Address(RVA = "0xDBFA44", Offset = "0xDBFA44", VA = "0xDBFA44")]
	public static void DrawLineGizmos(Vector3[] line)
	{
	}

	[Token(Token = "0x6008037")]
	[Address(RVA = "0xDBFB9C", Offset = "0xDBFB9C", VA = "0xDBFB9C")]
	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6008038")]
	[Address(RVA = "0xDBFCA0", Offset = "0xDBFCA0", VA = "0xDBFCA0")]
	public static void DrawLineGizmos(Transform[] line)
	{
	}

	[Token(Token = "0x6008039")]
	[Address(RVA = "0xDBFEB0", Offset = "0xDBFEB0", VA = "0xDBFEB0")]
	public static void DrawLineGizmos(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x600803A")]
	[Address(RVA = "0xDC0078", Offset = "0xDC0078", VA = "0xDC0078")]
	public static void DrawLineHandles(Vector3[] line)
	{
	}

	[Token(Token = "0x600803B")]
	[Address(RVA = "0xDC01D0", Offset = "0xDC01D0", VA = "0xDC01D0")]
	public static void DrawLineHandles(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x600803C")]
	[Address(RVA = "0xDC02D4", Offset = "0xDC02D4", VA = "0xDC02D4")]
	public static void DrawLineHandles(Transform[] line)
	{
	}

	[Token(Token = "0x600803D")]
	[Address(RVA = "0xDC04E4", Offset = "0xDC04E4", VA = "0xDC04E4")]
	public static void DrawLineHandles(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x600803E")]
	[Address(RVA = "0xDC06AC", Offset = "0xDC06AC", VA = "0xDC06AC")]
	public static Vector3 PointOnPath(Vector3[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600803F")]
	[Address(RVA = "0xDC0770", Offset = "0xDC0770", VA = "0xDC0770")]
	public static void DrawPath(Vector3[] path)
	{
	}

	[Token(Token = "0x6008040")]
	[Address(RVA = "0xDC0C0C", Offset = "0xDC0C0C", VA = "0xDC0C0C")]
	public static void DrawPath(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x6008041")]
	[Address(RVA = "0xDC0D10", Offset = "0xDC0D10", VA = "0xDC0D10")]
	public static void DrawPath(Transform[] path)
	{
	}

	[Token(Token = "0x6008042")]
	[Address(RVA = "0xDC0F20", Offset = "0xDC0F20", VA = "0xDC0F20")]
	public static void DrawPath(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x6008043")]
	[Address(RVA = "0xDC10E8", Offset = "0xDC10E8", VA = "0xDC10E8")]
	public static void DrawPathGizmos(Vector3[] path)
	{
	}

	[Token(Token = "0x6008044")]
	[Address(RVA = "0xDC1240", Offset = "0xDC1240", VA = "0xDC1240")]
	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x6008045")]
	[Address(RVA = "0xDC1344", Offset = "0xDC1344", VA = "0xDC1344")]
	public static void DrawPathGizmos(Transform[] path)
	{
	}

	[Token(Token = "0x6008046")]
	[Address(RVA = "0xDC1554", Offset = "0xDC1554", VA = "0xDC1554")]
	public static void DrawPathGizmos(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x6008047")]
	[Address(RVA = "0xDC171C", Offset = "0xDC171C", VA = "0xDC171C")]
	public static void DrawPathHandles(Vector3[] path)
	{
	}

	[Token(Token = "0x6008048")]
	[Address(RVA = "0xDC1874", Offset = "0xDC1874", VA = "0xDC1874")]
	public static void DrawPathHandles(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x6008049")]
	[Address(RVA = "0xDC1978", Offset = "0xDC1978", VA = "0xDC1978")]
	public static void DrawPathHandles(Transform[] path)
	{
	}

	[Token(Token = "0x600804A")]
	[Address(RVA = "0xDC1B88", Offset = "0xDC1B88", VA = "0xDC1B88")]
	public static void DrawPathHandles(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x600804B")]
	[Address(RVA = "0xDC1D50", Offset = "0xDC1D50", VA = "0xDC1D50")]
	public static void CameraFadeDepth(int depth)
	{
	}

	[Token(Token = "0x600804C")]
	[Address(RVA = "0xDC1FAC", Offset = "0xDC1FAC", VA = "0xDC1FAC")]
	public static void CameraFadeDestroy()
	{
	}

	[Token(Token = "0x600804D")]
	[Address(RVA = "0xDC2138", Offset = "0xDC2138", VA = "0xDC2138")]
	public static void CameraFadeSwap(Texture2D texture)
	{
	}

	[Token(Token = "0x600804E")]
	[Address(RVA = "0xDC22D0", Offset = "0xDC22D0", VA = "0xDC22D0")]
	public static GameObject CameraFadeAdd(Texture2D texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x600804F")]
	[Address(RVA = "0xDC2628", Offset = "0xDC2628", VA = "0xDC2628")]
	public static GameObject CameraFadeAdd(Texture2D texture)
	{
		return null;
	}

	[Token(Token = "0x6008050")]
	[Address(RVA = "0xDC29D0", Offset = "0xDC29D0", VA = "0xDC29D0")]
	public static GameObject CameraFadeAdd()
	{
		return null;
	}

	[Token(Token = "0x6008051")]
	[Address(RVA = "0xDC2DA0", Offset = "0xDC2DA0", VA = "0xDC2DA0")]
	public static void Resume(GameObject target)
	{
	}

	[Token(Token = "0x6008052")]
	[Address(RVA = "0xDC2EF0", Offset = "0xDC2EF0", VA = "0xDC2EF0")]
	public static void Resume(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x6008053")]
	[Address(RVA = "0xDC3278", Offset = "0xDC3278", VA = "0xDC3278")]
	public static void Resume(GameObject target, string type)
	{
	}

	[Token(Token = "0x6008054")]
	[Address(RVA = "0xDC34B4", Offset = "0xDC34B4", VA = "0xDC34B4")]
	public static void Resume(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x6008055")]
	[Address(RVA = "0xDC39D8", Offset = "0xDC39D8", VA = "0xDC39D8")]
	public static void Resume()
	{
	}

	[Token(Token = "0x6008056")]
	[Address(RVA = "0xDC3D24", Offset = "0xDC3D24", VA = "0xDC3D24")]
	public static void Resume(string type)
	{
	}

	[Token(Token = "0x6008057")]
	[Address(RVA = "0xDC42D0", Offset = "0xDC42D0", VA = "0xDC42D0")]
	public static void Pause(GameObject target)
	{
	}

	[Token(Token = "0x6008058")]
	[Address(RVA = "0xDC449C", Offset = "0xDC449C", VA = "0xDC449C")]
	public static void Pause(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x6008059")]
	[Address(RVA = "0xDC4824", Offset = "0xDC4824", VA = "0xDC4824")]
	public static void Pause(GameObject target, string type)
	{
	}

	[Token(Token = "0x600805A")]
	[Address(RVA = "0xDC4AD8", Offset = "0xDC4AD8", VA = "0xDC4AD8")]
	public static void Pause(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x600805B")]
	[Address(RVA = "0xDC5088", Offset = "0xDC5088", VA = "0xDC5088")]
	public static void Pause()
	{
	}

	[Token(Token = "0x600805C")]
	[Address(RVA = "0xDC53D4", Offset = "0xDC53D4", VA = "0xDC53D4")]
	public static void Pause(string type)
	{
	}

	[Token(Token = "0x600805D")]
	[Address(RVA = "0xDC5980", Offset = "0xDC5980", VA = "0xDC5980")]
	public static int Count()
	{
		return default(int);
	}

	[Token(Token = "0x600805E")]
	[Address(RVA = "0xDC5A78", Offset = "0xDC5A78", VA = "0xDC5A78")]
	public static int Count(string type)
	{
		return default(int);
	}

	[Token(Token = "0x600805F")]
	[Address(RVA = "0xDC6004", Offset = "0xDC6004", VA = "0xDC6004")]
	public static int Count(GameObject target)
	{
		return default(int);
	}

	[Token(Token = "0x6008060")]
	[Address(RVA = "0xDC60F0", Offset = "0xDC60F0", VA = "0xDC60F0")]
	public static int Count(GameObject target, string type)
	{
		return default(int);
	}

	[Token(Token = "0x6008061")]
	[Address(RVA = "0xDC6320", Offset = "0xDC6320", VA = "0xDC6320")]
	public static void Stop()
	{
	}

	[Token(Token = "0x6008062")]
	[Address(RVA = "0xDC6830", Offset = "0xDC6830", VA = "0xDC6830")]
	public static void Stop(string type)
	{
	}

	[Token(Token = "0x6008063")]
	[Address(RVA = "0xDC7008", Offset = "0xDC7008", VA = "0xDC7008")]
	public static void StopByName(string name)
	{
	}

	[Token(Token = "0x6008064")]
	[Address(RVA = "0xDC66E8", Offset = "0xDC66E8", VA = "0xDC66E8")]
	public static void Stop(GameObject target)
	{
	}

	[Token(Token = "0x6008065")]
	[Address(RVA = "0xDC7764", Offset = "0xDC7764", VA = "0xDC7764")]
	public static void Stop(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x6008066")]
	[Address(RVA = "0xDC6DDC", Offset = "0xDC6DDC", VA = "0xDC6DDC")]
	public static void Stop(GameObject target, string type)
	{
	}

	[Token(Token = "0x6008067")]
	[Address(RVA = "0xDC75B4", Offset = "0xDC75B4", VA = "0xDC75B4")]
	public static void StopByName(GameObject target, string name)
	{
	}

	[Token(Token = "0x6008068")]
	[Address(RVA = "0xDC7AEC", Offset = "0xDC7AEC", VA = "0xDC7AEC")]
	public static void Stop(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x6008069")]
	[Address(RVA = "0xDC8010", Offset = "0xDC8010", VA = "0xDC8010")]
	public static void StopByName(GameObject target, string name, bool includechildren)
	{
	}

	[Token(Token = "0x600806A")]
	[Address(RVA = "0xD939E0", Offset = "0xD939E0", VA = "0xD939E0")]
	public static Hashtable Hash(params object[] args)
	{
		return null;
	}

	[Token(Token = "0x600806B")]
	[Address(RVA = "0xDC84A4", Offset = "0xDC84A4", VA = "0xDC84A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600806C")]
	[Address(RVA = "0xDCA968", Offset = "0xDCA968", VA = "0xDCA968")]
	[DebuggerHidden]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600806D")]
	[Address(RVA = "0xDCAA14", Offset = "0xDCAA14", VA = "0xDCAA14")]
	private void Update()
	{
	}

	[Token(Token = "0x600806E")]
	[Address(RVA = "0xDCAA68", Offset = "0xDCAA68", VA = "0xDCAA68")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600806F")]
	[Address(RVA = "0xDCAAB8", Offset = "0xDCAAB8", VA = "0xDCAAB8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6008070")]
	[Address(RVA = "0xDCAD2C", Offset = "0xDCAD2C", VA = "0xDCAD2C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6008071")]
	[Address(RVA = "0xDCADE8", Offset = "0xDCADE8", VA = "0xDCADE8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6008072")]
	[Address(RVA = "0xDBF2D8", Offset = "0xDBF2D8", VA = "0xDBF2D8")]
	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
	}

	[Token(Token = "0x6008073")]
	[Address(RVA = "0xDC08C8", Offset = "0xDC08C8", VA = "0xDC08C8")]
	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
	}

	[Token(Token = "0x6008074")]
	[Address(RVA = "0xDBDF30", Offset = "0xDBDF30", VA = "0xDBDF30")]
	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		return null;
	}

	[Token(Token = "0x6008075")]
	[Address(RVA = "0xDBE35C", Offset = "0xDBE35C", VA = "0xDBE35C")]
	private static Vector3 Interp(Vector3[] pts, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6008076")]
	[Address(RVA = "0xD97408", Offset = "0xD97408", VA = "0xD97408")]
	private static void Launch(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6008077")]
	[Address(RVA = "0xD966C4", Offset = "0xD966C4", VA = "0xD966C4")]
	private static Hashtable CleanArgs(Hashtable args)
	{
		return null;
	}

	[Token(Token = "0x6008078")]
	[Address(RVA = "0xDCADEC", Offset = "0xDCADEC", VA = "0xDCADEC")]
	private static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x6008079")]
	[Address(RVA = "0xDC84C8", Offset = "0xDC84C8", VA = "0xDC84C8")]
	private void RetrieveArgs()
	{
	}

	[Token(Token = "0x600807A")]
	[Address(RVA = "0xDCB01C", Offset = "0xDCB01C", VA = "0xDCB01C")]
	private void GetEasingFunction()
	{
	}

	[Token(Token = "0x600807B")]
	[Address(RVA = "0xDB6B98", Offset = "0xDB6B98", VA = "0xDB6B98")]
	private void UpdatePercentage()
	{
	}

	[Token(Token = "0x600807C")]
	[Address(RVA = "0xDB5930", Offset = "0xDB5930", VA = "0xDB5930")]
	private void CallBack(string callbackType)
	{
	}

	[Token(Token = "0x600807D")]
	[Address(RVA = "0xDAE810", Offset = "0xDAE810", VA = "0xDAE810")]
	private void Dispose()
	{
	}

	[Token(Token = "0x600807E")]
	[Address(RVA = "0xDB6014", Offset = "0xDB6014", VA = "0xDB6014")]
	private void ConflictCheck()
	{
	}

	[Token(Token = "0x600807F")]
	[Address(RVA = "0xDB69AC", Offset = "0xDB69AC", VA = "0xDB69AC")]
	private void EnableKinematic()
	{
	}

	[Token(Token = "0x6008080")]
	[Address(RVA = "0xDB6E94", Offset = "0xDB6E94", VA = "0xDB6E94")]
	private void DisableKinematic()
	{
	}

	[Token(Token = "0x6008081")]
	[Address(RVA = "0xDCAD60", Offset = "0xDCAD60", VA = "0xDCAD60")]
	private void ResumeDelay()
	{
	}

	[Token(Token = "0x6008082")]
	[Address(RVA = "0xDCB4D4", Offset = "0xDCB4D4", VA = "0xDCB4D4")]
	private float linear(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6008083")]
	[Address(RVA = "0xDAEC8C", Offset = "0xDAEC8C", VA = "0xDAEC8C")]
	private float clerp(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6008084")]
	[Address(RVA = "0xDCB598", Offset = "0xDCB598", VA = "0xDCB598")]
	private float spring(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6008085")]
	[Address(RVA = "0xDCB6E0", Offset = "0xDCB6E0", VA = "0xDCB6E0")]
	private float easeInQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6008086")]
	[Address(RVA = "0xDCB704", Offset = "0xDCB704", VA = "0xDCB704")]
	private float easeOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6008087")]
	[Address(RVA = "0xDCB730", Offset = "0xDCB730", VA = "0xDCB730")]
	private float easeInOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6008088")]
	[Address(RVA = "0xDCB798", Offset = "0xDCB798", VA = "0xDCB798")]
	private float easeInCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6008089")]
	[Address(RVA = "0xDCB7C0", Offset = "0xDCB7C0", VA = "0xDCB7C0")]
	private float easeOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600808A")]
	[Address(RVA = "0xDCB7F8", Offset = "0xDCB7F8", VA = "0xDCB7F8")]
	private float easeInOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600808B")]
	[Address(RVA = "0xDCB864", Offset = "0xDCB864", VA = "0xDCB864")]
	private float easeInQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600808C")]
	[Address(RVA = "0xDCB890", Offset = "0xDCB890", VA = "0xDCB890")]
	private float easeOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600808D")]
	[Address(RVA = "0xDCB8C8", Offset = "0xDCB8C8", VA = "0xDCB8C8")]
	private float easeInOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600808E")]
	[Address(RVA = "0xDCB938", Offset = "0xDCB938", VA = "0xDCB938")]
	private float easeInQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600808F")]
	[Address(RVA = "0xDCB968", Offset = "0xDCB968", VA = "0xDCB968")]
	private float easeOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6008090")]
	[Address(RVA = "0xDCB9A8", Offset = "0xDCB9A8", VA = "0xDCB9A8")]
	private float easeInOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6008091")]
	[Address(RVA = "0xDCBA24", Offset = "0xDCBA24", VA = "0xDCBA24")]
	private float easeInSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6008092")]
	[Address(RVA = "0xDCBAFC", Offset = "0xDCBAFC", VA = "0xDCBAFC")]
	private float easeOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6008093")]
	[Address(RVA = "0xDCBBD0", Offset = "0xDCBBD0", VA = "0xDCBBD0")]
	private float easeInOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6008094")]
	[Address(RVA = "0xDCBCB4", Offset = "0xDCBCB4", VA = "0xDCBCB4")]
	private float easeInExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6008095")]
	[Address(RVA = "0xDCBD8C", Offset = "0xDCBD8C", VA = "0xDCBD8C")]
	private float easeOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6008096")]
	[Address(RVA = "0xDCBE64", Offset = "0xDCBE64", VA = "0xDCBE64")]
	private float easeInOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6008097")]
	[Address(RVA = "0xDCBFB8", Offset = "0xDCBFB8", VA = "0xDCBFB8")]
	private float easeInCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6008098")]
	[Address(RVA = "0xDCC0AC", Offset = "0xDCC0AC", VA = "0xDCC0AC")]
	private float easeOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6008099")]
	[Address(RVA = "0xDCC19C", Offset = "0xDCC19C", VA = "0xDCC19C")]
	private float easeInOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600809A")]
	[Address(RVA = "0xDCC30C", Offset = "0xDCC30C", VA = "0xDCC30C")]
	private float easeInBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600809B")]
	[Address(RVA = "0xDCC360", Offset = "0xDCC360", VA = "0xDCC360")]
	private float easeOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600809C")]
	[Address(RVA = "0xDCC43C", Offset = "0xDCC43C", VA = "0xDCC43C")]
	private float easeInOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600809D")]
	[Address(RVA = "0xDCC4E0", Offset = "0xDCC4E0", VA = "0xDCC4E0")]
	private float easeInBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600809E")]
	[Address(RVA = "0xDCC520", Offset = "0xDCC520", VA = "0xDCC520")]
	private float easeOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600809F")]
	[Address(RVA = "0xDCC570", Offset = "0xDCC570", VA = "0xDCC570")]
	private float easeInOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60080A0")]
	[Address(RVA = "0xDB4840", Offset = "0xDB4840", VA = "0xDB4840")]
	private float punch(float amplitude, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60080A1")]
	[Address(RVA = "0xDCC604", Offset = "0xDCC604", VA = "0xDCC604")]
	private float easeInElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60080A2")]
	[Address(RVA = "0xDCC73C", Offset = "0xDCC73C", VA = "0xDCC73C")]
	private float easeOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60080A3")]
	[Address(RVA = "0xDCC870", Offset = "0xDCC870", VA = "0xDCC870")]
	private float easeInOutElastic(float start, float end, float value)
	{
		return default(float);
	}
}
