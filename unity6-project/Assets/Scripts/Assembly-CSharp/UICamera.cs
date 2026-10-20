using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200025C")]
[ExecuteInEditMode]
public class UICamera : MonoBehaviour
{
	[Token(Token = "0x200025D")]
	public enum ControlScheme
	{
		[Token(Token = "0x4000AFD")]
		Mouse = 0,
		[Token(Token = "0x4000AFE")]
		Touch = 1,
		[Token(Token = "0x4000AFF")]
		Controller = 2
	}

	[Token(Token = "0x200025E")]
	public enum ClickNotification
	{
		[Token(Token = "0x4000B01")]
		None = 0,
		[Token(Token = "0x4000B02")]
		Always = 1,
		[Token(Token = "0x4000B03")]
		BasedOnDelta = 2
	}

	[Token(Token = "0x200025F")]
	public class MouseOrTouch
	{
		[Token(Token = "0x4000B04")]
		[FieldOffset(Offset = "0x8")]
		public KeyCode key;

		[Token(Token = "0x4000B05")]
		[FieldOffset(Offset = "0xC")]
		public Vector2 pos;

		[Token(Token = "0x4000B06")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 lastPos;

		[Token(Token = "0x4000B07")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 delta;

		[Token(Token = "0x4000B08")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 totalDelta;

		[Token(Token = "0x4000B09")]
		[FieldOffset(Offset = "0x2C")]
		public Camera pressedCam;

		[Token(Token = "0x4000B0A")]
		[FieldOffset(Offset = "0x30")]
		public GameObject last;

		[Token(Token = "0x4000B0B")]
		[FieldOffset(Offset = "0x34")]
		public GameObject current;

		[Token(Token = "0x4000B0C")]
		[FieldOffset(Offset = "0x38")]
		public GameObject pressed;

		[Token(Token = "0x4000B0D")]
		[FieldOffset(Offset = "0x3C")]
		public GameObject dragged;

		[Token(Token = "0x4000B0E")]
		[FieldOffset(Offset = "0x40")]
		public float pressTime;

		[Token(Token = "0x4000B0F")]
		[FieldOffset(Offset = "0x44")]
		public float clickTime;

		[Token(Token = "0x4000B10")]
		[FieldOffset(Offset = "0x48")]
		public ClickNotification clickNotification;

		[Token(Token = "0x4000B11")]
		[FieldOffset(Offset = "0x4C")]
		public bool touchBegan;

		[Token(Token = "0x4000B12")]
		[FieldOffset(Offset = "0x4D")]
		public bool pressStarted;

		[Token(Token = "0x4000B13")]
		[FieldOffset(Offset = "0x4E")]
		public bool dragStarted;

		[Token(Token = "0x4000B14")]
		[FieldOffset(Offset = "0x50")]
		public int ignoreDelta;

		[Token(Token = "0x1700033C")]
		public float deltaTime
		{
			[Token(Token = "0x60014B6")]
			[Address(RVA = "0x16D70E8", Offset = "0x16D70E8", VA = "0x16D70E8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700033D")]
		public bool isOverUI
		{
			[Token(Token = "0x60014B7")]
			[Address(RVA = "0x16C6294", Offset = "0x16C6294", VA = "0x16C6294")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60014B5")]
		[Address(RVA = "0x16C3FA0", Offset = "0x16C3FA0", VA = "0x16C3FA0")]
		public MouseOrTouch()
		{
		}
	}

	[Token(Token = "0x2000260")]
	public enum EventType
	{
		[Token(Token = "0x4000B16")]
		World_3D = 0,
		[Token(Token = "0x4000B17")]
		UI_3D = 1,
		[Token(Token = "0x4000B18")]
		World_2D = 2,
		[Token(Token = "0x4000B19")]
		UI_2D = 3
	}

	[Token(Token = "0x2000261")]
	public enum ProcessEventsIn
	{
		[Token(Token = "0x4000B1B")]
		Update = 0,
		[Token(Token = "0x4000B1C")]
		LateUpdate = 1
	}

	[Token(Token = "0x2000262")]
	private struct DepthEntry
	{
		[Token(Token = "0x4000B1D")]
		[FieldOffset(Offset = "0x0")]
		public int depth;

		[Token(Token = "0x4000B1E")]
		[FieldOffset(Offset = "0x4")]
		public RaycastHit hit;

		[Token(Token = "0x4000B1F")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 point;

		[Token(Token = "0x4000B20")]
		[FieldOffset(Offset = "0x3C")]
		public GameObject go;
	}

	[Token(Token = "0x2000263")]
	public class Touch
	{
		[Token(Token = "0x4000B21")]
		[FieldOffset(Offset = "0x8")]
		public int fingerId;

		[Token(Token = "0x4000B22")]
		[FieldOffset(Offset = "0xC")]
		public TouchPhase phase;

		[Token(Token = "0x4000B23")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 position;

		[Token(Token = "0x4000B24")]
		[FieldOffset(Offset = "0x18")]
		public int tapCount;

		[Token(Token = "0x60014B8")]
		[Address(RVA = "0x16D8050", Offset = "0x16D8050", VA = "0x16D8050")]
		public Touch()
		{
		}
	}

	[Token(Token = "0x2000264")]
	public delegate bool GetKeyStateFunc(KeyCode key);

	[Token(Token = "0x2000265")]
	public delegate float GetAxisFunc(string name);

	[Token(Token = "0x2000266")]
	public delegate bool GetAnyKeyFunc();

	[Token(Token = "0x2000267")]
	public delegate void OnScreenResize();

	[Token(Token = "0x2000268")]
	public delegate void OnCustomInput();

	[Token(Token = "0x2000269")]
	public delegate void OnSchemeChange();

	[Token(Token = "0x200026A")]
	public delegate void MoveDelegate(Vector2 delta);

	[Token(Token = "0x200026B")]
	public delegate void VoidDelegate(GameObject go);

	[Token(Token = "0x200026C")]
	public delegate void BoolDelegate(GameObject go, bool state);

	[Token(Token = "0x200026D")]
	public delegate void FloatDelegate(GameObject go, float delta);

	[Token(Token = "0x200026E")]
	public delegate void VectorDelegate(GameObject go, Vector2 delta);

	[Token(Token = "0x200026F")]
	public delegate void ObjectDelegate(GameObject go, GameObject obj);

	[Token(Token = "0x2000270")]
	public delegate void KeyCodeDelegate(GameObject go, KeyCode key);

	[Token(Token = "0x2000271")]
	public delegate int GetTouchCountCallback();

	[Token(Token = "0x2000272")]
	public delegate Touch GetTouchCallback(int index);

	[Token(Token = "0x4000A99")]
	[FieldOffset(Offset = "0xC")]
	[HideInInspector]
	public Action m_onClickExcutor;

	[Token(Token = "0x4000A9A")]
	[FieldOffset(Offset = "0x0")]
	public static BetterList<UICamera> list;

	[Token(Token = "0x4000A9B")]
	[FieldOffset(Offset = "0x4")]
	public static GetKeyStateFunc GetKeyDown;

	[Token(Token = "0x4000A9C")]
	[FieldOffset(Offset = "0x8")]
	public static GetKeyStateFunc GetKeyUp;

	[Token(Token = "0x4000A9D")]
	[FieldOffset(Offset = "0xC")]
	public static GetKeyStateFunc GetKey;

	[Token(Token = "0x4000A9E")]
	[FieldOffset(Offset = "0x10")]
	public static GetAxisFunc GetAxis;

	[Token(Token = "0x4000A9F")]
	[FieldOffset(Offset = "0x14")]
	public static GetAnyKeyFunc GetAnyKeyDown;

	[Token(Token = "0x4000AA0")]
	[FieldOffset(Offset = "0x18")]
	public static OnScreenResize onScreenResize;

	[Token(Token = "0x4000AA1")]
	[FieldOffset(Offset = "0x10")]
	public EventType eventType;

	[Token(Token = "0x4000AA2")]
	[FieldOffset(Offset = "0x14")]
	public bool eventsGoToColliders;

	[Token(Token = "0x4000AA3")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask eventReceiverMask;

	[Token(Token = "0x4000AA4")]
	[FieldOffset(Offset = "0x1C")]
	public ProcessEventsIn processEventsIn;

	[Token(Token = "0x4000AA5")]
	[FieldOffset(Offset = "0x20")]
	public bool debug;

	[Token(Token = "0x4000AA6")]
	[FieldOffset(Offset = "0x21")]
	public bool useMouse;

	[Token(Token = "0x4000AA7")]
	[FieldOffset(Offset = "0x22")]
	public bool useTouch;

	[Token(Token = "0x4000AA8")]
	[FieldOffset(Offset = "0x23")]
	public bool allowMultiTouch;

	[Token(Token = "0x4000AA9")]
	[FieldOffset(Offset = "0x24")]
	public bool useKeyboard;

	[Token(Token = "0x4000AAA")]
	[FieldOffset(Offset = "0x25")]
	public bool useController;

	[Token(Token = "0x4000AAB")]
	[FieldOffset(Offset = "0x26")]
	public bool stickyTooltip;

	[Token(Token = "0x4000AAC")]
	[FieldOffset(Offset = "0x28")]
	public float tooltipDelay;

	[Token(Token = "0x4000AAD")]
	[FieldOffset(Offset = "0x2C")]
	public bool longPressTooltip;

	[Token(Token = "0x4000AAE")]
	[FieldOffset(Offset = "0x30")]
	public float mouseDragThreshold;

	[Token(Token = "0x4000AAF")]
	[FieldOffset(Offset = "0x34")]
	public float mouseClickThreshold;

	[Token(Token = "0x4000AB0")]
	[FieldOffset(Offset = "0x38")]
	public float touchDragThreshold;

	[Token(Token = "0x4000AB1")]
	[FieldOffset(Offset = "0x3C")]
	public float touchClickThreshold;

	[Token(Token = "0x4000AB2")]
	[FieldOffset(Offset = "0x40")]
	public float rangeDistance;

	[Token(Token = "0x4000AB3")]
	[FieldOffset(Offset = "0x44")]
	public string horizontalAxisName;

	[Token(Token = "0x4000AB4")]
	[FieldOffset(Offset = "0x48")]
	public string verticalAxisName;

	[Token(Token = "0x4000AB5")]
	[FieldOffset(Offset = "0x4C")]
	public string horizontalPanAxisName;

	[Token(Token = "0x4000AB6")]
	[FieldOffset(Offset = "0x50")]
	public string verticalPanAxisName;

	[Token(Token = "0x4000AB7")]
	[FieldOffset(Offset = "0x54")]
	public string scrollAxisName;

	[Token(Token = "0x4000AB8")]
	[FieldOffset(Offset = "0x58")]
	public bool commandClick;

	[Token(Token = "0x4000AB9")]
	[FieldOffset(Offset = "0x5C")]
	public KeyCode submitKey0;

	[Token(Token = "0x4000ABA")]
	[FieldOffset(Offset = "0x60")]
	public KeyCode submitKey1;

	[Token(Token = "0x4000ABB")]
	[FieldOffset(Offset = "0x64")]
	public KeyCode cancelKey0;

	[Token(Token = "0x4000ABC")]
	[FieldOffset(Offset = "0x68")]
	public KeyCode cancelKey1;

	[Token(Token = "0x4000ABD")]
	[FieldOffset(Offset = "0x6C")]
	public bool autoHideCursor;

	[Token(Token = "0x4000ABE")]
	[FieldOffset(Offset = "0x1C")]
	public static OnCustomInput onCustomInput;

	[Token(Token = "0x4000ABF")]
	[FieldOffset(Offset = "0x20")]
	public static bool showTooltips;

	[Token(Token = "0x4000AC0")]
	[FieldOffset(Offset = "0x21")]
	public static bool ignoreControllerInput;

	[Token(Token = "0x4000AC1")]
	[FieldOffset(Offset = "0x22")]
	private static bool mDisableController;

	[Token(Token = "0x4000AC2")]
	[FieldOffset(Offset = "0x24")]
	private static Vector2 mLastPos;

	[Token(Token = "0x4000AC3")]
	[FieldOffset(Offset = "0x2C")]
	public static Vector3 lastWorldPosition;

	[Token(Token = "0x4000AC4")]
	[FieldOffset(Offset = "0x38")]
	public static RaycastHit lastHit;

	[Token(Token = "0x4000AC5")]
	[FieldOffset(Offset = "0x64")]
	public static UICamera current;

	[Token(Token = "0x4000AC6")]
	[FieldOffset(Offset = "0x68")]
	public static Camera currentCamera;

	[Token(Token = "0x4000AC7")]
	[FieldOffset(Offset = "0x6C")]
	public static OnSchemeChange onSchemeChange;

	[Token(Token = "0x4000AC8")]
	[FieldOffset(Offset = "0x70")]
	private static ControlScheme mLastScheme;

	[Token(Token = "0x4000AC9")]
	[FieldOffset(Offset = "0x74")]
	public static int currentTouchID;

	[Token(Token = "0x4000ACA")]
	[FieldOffset(Offset = "0x78")]
	private static KeyCode mCurrentKey;

	[Token(Token = "0x4000ACB")]
	[FieldOffset(Offset = "0x7C")]
	public static MouseOrTouch currentTouch;

	[Token(Token = "0x4000ACC")]
	[FieldOffset(Offset = "0x80")]
	private static bool mInputFocus;

	[Token(Token = "0x4000ACD")]
	[FieldOffset(Offset = "0x84")]
	private static GameObject mGenericHandler;

	[Token(Token = "0x4000ACE")]
	[FieldOffset(Offset = "0x88")]
	public static GameObject fallThrough;

	[Token(Token = "0x4000ACF")]
	[FieldOffset(Offset = "0x8C")]
	public static VoidDelegate onClick;

	[Token(Token = "0x4000AD0")]
	[FieldOffset(Offset = "0x90")]
	public static VoidDelegate onDoubleClick;

	[Token(Token = "0x4000AD1")]
	[FieldOffset(Offset = "0x94")]
	public static BoolDelegate onHover;

	[Token(Token = "0x4000AD2")]
	[FieldOffset(Offset = "0x98")]
	public static BoolDelegate onPress;

	[Token(Token = "0x4000AD3")]
	[FieldOffset(Offset = "0x9C")]
	public static BoolDelegate onSelect;

	[Token(Token = "0x4000AD4")]
	[FieldOffset(Offset = "0xA0")]
	public static FloatDelegate onScroll;

	[Token(Token = "0x4000AD5")]
	[FieldOffset(Offset = "0xA4")]
	public static VectorDelegate onDrag;

	[Token(Token = "0x4000AD6")]
	[FieldOffset(Offset = "0xA8")]
	public static VoidDelegate onDragStart;

	[Token(Token = "0x4000AD7")]
	[FieldOffset(Offset = "0xAC")]
	public static ObjectDelegate onDragOver;

	[Token(Token = "0x4000AD8")]
	[FieldOffset(Offset = "0xB0")]
	public static ObjectDelegate onDragOut;

	[Token(Token = "0x4000AD9")]
	[FieldOffset(Offset = "0xB4")]
	public static VoidDelegate onDragEnd;

	[Token(Token = "0x4000ADA")]
	[FieldOffset(Offset = "0xB8")]
	public static ObjectDelegate onDrop;

	[Token(Token = "0x4000ADB")]
	[FieldOffset(Offset = "0xBC")]
	public static KeyCodeDelegate onKey;

	[Token(Token = "0x4000ADC")]
	[FieldOffset(Offset = "0xC0")]
	public static KeyCodeDelegate onNavigate;

	[Token(Token = "0x4000ADD")]
	[FieldOffset(Offset = "0xC4")]
	public static VectorDelegate onPan;

	[Token(Token = "0x4000ADE")]
	[FieldOffset(Offset = "0xC8")]
	public static BoolDelegate onTooltip;

	[Token(Token = "0x4000ADF")]
	[FieldOffset(Offset = "0xCC")]
	public static MoveDelegate onMouseMove;

	[Token(Token = "0x4000AE0")]
	[FieldOffset(Offset = "0xD0")]
	private static MouseOrTouch[] mMouse;

	[Token(Token = "0x4000AE1")]
	[FieldOffset(Offset = "0xD4")]
	public static MouseOrTouch controller;

	[Token(Token = "0x4000AE2")]
	[FieldOffset(Offset = "0xD8")]
	public static List<MouseOrTouch> activeTouches;

	[Token(Token = "0x4000AE3")]
	[FieldOffset(Offset = "0xDC")]
	private static List<int> mTouchIDs;

	[Token(Token = "0x4000AE4")]
	[FieldOffset(Offset = "0xE0")]
	private static int mWidth;

	[Token(Token = "0x4000AE5")]
	[FieldOffset(Offset = "0xE4")]
	private static int mHeight;

	[Token(Token = "0x4000AE6")]
	[FieldOffset(Offset = "0xE8")]
	private static GameObject mTooltip;

	[Token(Token = "0x4000AE7")]
	[FieldOffset(Offset = "0x70")]
	private Camera mCam;

	[Token(Token = "0x4000AE8")]
	[FieldOffset(Offset = "0xEC")]
	private static float mTooltipTime;

	[Token(Token = "0x4000AE9")]
	[FieldOffset(Offset = "0x74")]
	private float mNextRaycast;

	[Token(Token = "0x4000AEA")]
	[FieldOffset(Offset = "0xF0")]
	public static bool isDragging;

	[Token(Token = "0x4000AEB")]
	[FieldOffset(Offset = "0xF4")]
	private static GameObject mRayHitObject;

	[Token(Token = "0x4000AEC")]
	[FieldOffset(Offset = "0xF8")]
	private static GameObject mHover;

	[Token(Token = "0x4000AED")]
	[FieldOffset(Offset = "0xFC")]
	private static GameObject mSelected;

	[Token(Token = "0x4000AEE")]
	[FieldOffset(Offset = "0x100")]
	private static DepthEntry mHit;

	[Token(Token = "0x4000AEF")]
	[FieldOffset(Offset = "0x140")]
	private static BetterList<DepthEntry> mHits;

	[Token(Token = "0x4000AF0")]
	[FieldOffset(Offset = "0x144")]
	private static Plane m2DPlane;

	[Token(Token = "0x4000AF1")]
	[FieldOffset(Offset = "0x154")]
	private static float mNextEvent;

	[Token(Token = "0x4000AF2")]
	[FieldOffset(Offset = "0x158")]
	private static int mNotifying;

	[Token(Token = "0x4000AF3")]
	[FieldOffset(Offset = "0x15C")]
	private static bool mUsingTouchEvents;

	[Token(Token = "0x4000AF4")]
	[FieldOffset(Offset = "0x160")]
	public static GetTouchCountCallback GetInputTouchCount;

	[Token(Token = "0x4000AF5")]
	[FieldOffset(Offset = "0x164")]
	public static GetTouchCallback GetInputTouch;

	[Token(Token = "0x4000AF6")]
	[FieldOffset(Offset = "0x168")]
	private static GetKeyStateFunc _003C_003Ef__am_0024cache5D;

	[Token(Token = "0x4000AF7")]
	[FieldOffset(Offset = "0x16C")]
	private static GetKeyStateFunc _003C_003Ef__am_0024cache5E;

	[Token(Token = "0x4000AF8")]
	[FieldOffset(Offset = "0x170")]
	private static GetKeyStateFunc _003C_003Ef__am_0024cache5F;

	[Token(Token = "0x4000AF9")]
	[FieldOffset(Offset = "0x174")]
	private static GetAxisFunc _003C_003Ef__am_0024cache60;

	[Token(Token = "0x4000AFA")]
	[FieldOffset(Offset = "0x178")]
	private static BetterList<DepthEntry>.CompareFunc _003C_003Ef__am_0024cache61;

	[Token(Token = "0x4000AFB")]
	[FieldOffset(Offset = "0x17C")]
	private static BetterList<DepthEntry>.CompareFunc _003C_003Ef__am_0024cache62;

	[Token(Token = "0x17000327")]
	public bool stickyPress
	{
		[Token(Token = "0x600146D")]
		[Address(RVA = "0x16C3FB4", Offset = "0x16C3FB4", VA = "0x16C3FB4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000328")]
	public static bool disableController
	{
		[Token(Token = "0x600146E")]
		[Address(RVA = "0x16C3FBC", Offset = "0x16C3FBC", VA = "0x16C3FBC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600146F")]
		[Address(RVA = "0x16C40C0", Offset = "0x16C40C0", VA = "0x16C40C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000329")]
	public static Vector2 lastTouchPosition
	{
		[Token(Token = "0x6001470")]
		[Address(RVA = "0x16C4174", Offset = "0x16C4174", VA = "0x16C4174")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6001471")]
		[Address(RVA = "0x16C4234", Offset = "0x16C4234", VA = "0x16C4234")]
		set
		{
		}
	}

	[Token(Token = "0x1700032A")]
	public static Vector2 lastEventPosition
	{
		[Token(Token = "0x6001472")]
		[Address(RVA = "0x16C42F0", Offset = "0x16C42F0", VA = "0x16C42F0")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6001473")]
		[Address(RVA = "0x16C4594", Offset = "0x16C4594", VA = "0x16C4594")]
		set
		{
		}
	}

	[Token(Token = "0x1700032B")]
	public static UICamera first
	{
		[Token(Token = "0x6001474")]
		[Address(RVA = "0x16C4650", Offset = "0x16C4650", VA = "0x16C4650")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700032C")]
	public static ControlScheme currentScheme
	{
		[Token(Token = "0x6001475")]
		[Address(RVA = "0x16C0CEC", Offset = "0x16C0CEC", VA = "0x16C0CEC")]
		get
		{
			return default(ControlScheme);
		}
		[Token(Token = "0x6001476")]
		[Address(RVA = "0x16C47D4", Offset = "0x16C47D4", VA = "0x16C47D4")]
		set
		{
		}
	}

	[Token(Token = "0x1700032D")]
	public static KeyCode currentKey
	{
		[Token(Token = "0x6001477")]
		[Address(RVA = "0x16C4D48", Offset = "0x16C4D48", VA = "0x16C4D48")]
		get
		{
			return default(KeyCode);
		}
		[Token(Token = "0x6001478")]
		[Address(RVA = "0x16C497C", Offset = "0x16C497C", VA = "0x16C497C")]
		set
		{
		}
	}

	[Token(Token = "0x1700032E")]
	public static Ray currentRay
	{
		[Token(Token = "0x6001479")]
		[Address(RVA = "0x16C4F24", Offset = "0x16C4F24", VA = "0x16C4F24")]
		get
		{
			return default(Ray);
		}
	}

	[Token(Token = "0x1700032F")]
	public static bool inputHasFocus
	{
		[Token(Token = "0x600147A")]
		[Address(RVA = "0x16C51AC", Offset = "0x16C51AC", VA = "0x16C51AC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000330")]
	public static GameObject genericEventHandler
	{
		[Token(Token = "0x600147B")]
		[Address(RVA = "0x16C536C", Offset = "0x16C536C", VA = "0x16C536C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600147C")]
		[Address(RVA = "0x16C541C", Offset = "0x16C541C", VA = "0x16C541C")]
		set
		{
		}
	}

	[Token(Token = "0x17000331")]
	private bool handlesEvents
	{
		[Token(Token = "0x600147D")]
		[Address(RVA = "0x16C54D0", Offset = "0x16C54D0", VA = "0x16C54D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000332")]
	public Camera cachedCamera
	{
		[Token(Token = "0x600147E")]
		[Address(RVA = "0x16C57D8", Offset = "0x16C57D8", VA = "0x16C57D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000333")]
	public static GameObject tooltipObject
	{
		[Token(Token = "0x600147F")]
		[Address(RVA = "0x16C58C0", Offset = "0x16C58C0", VA = "0x16C58C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000334")]
	public static bool isOverUI
	{
		[Token(Token = "0x6001480")]
		[Address(RVA = "0x16C5970", Offset = "0x16C5970", VA = "0x16C5970")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000335")]
	public static GameObject hoveredObject
	{
		[Token(Token = "0x6001481")]
		[Address(RVA = "0x16BF060", Offset = "0x16BF060", VA = "0x16BF060")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001482")]
		[Address(RVA = "0x16C64A0", Offset = "0x16C64A0", VA = "0x16C64A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000336")]
	public static GameObject controllerNavigationObject
	{
		[Token(Token = "0x6001483")]
		[Address(RVA = "0x16C7E0C", Offset = "0x16C7E0C", VA = "0x16C7E0C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001484")]
		[Address(RVA = "0x16C8650", Offset = "0x16C8650", VA = "0x16C8650")]
		set
		{
		}
	}

	[Token(Token = "0x17000337")]
	public static GameObject selectedObject
	{
		[Token(Token = "0x6001485")]
		[Address(RVA = "0x16C89C0", Offset = "0x16C89C0", VA = "0x16C89C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001486")]
		[Address(RVA = "0x16C8BD0", Offset = "0x16C8BD0", VA = "0x16C8BD0")]
		set
		{
		}
	}

	[Token(Token = "0x17000338")]
	public static int touchCount
	{
		[Token(Token = "0x6001488")]
		[Address(RVA = "0x16C9BDC", Offset = "0x16C9BDC", VA = "0x16C9BDC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000339")]
	public static int dragCount
	{
		[Token(Token = "0x600148A")]
		[Address(RVA = "0x16CA040", Offset = "0x16CA040", VA = "0x16CA040")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700033A")]
	public static Camera mainCamera
	{
		[Token(Token = "0x600148B")]
		[Address(RVA = "0x16CA40C", Offset = "0x16CA40C", VA = "0x16CA40C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700033B")]
	public static UICamera eventHandler
	{
		[Token(Token = "0x600148C")]
		[Address(RVA = "0x16C55BC", Offset = "0x16C55BC", VA = "0x16C55BC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600146B")]
	[Address(RVA = "0x16C3688", Offset = "0x16C3688", VA = "0x16C3688")]
	public UICamera()
	{
	}

	[Token(Token = "0x6001487")]
	[Address(RVA = "0x16C9834", Offset = "0x16C9834", VA = "0x16C9834")]
	public static bool IsPressed(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6001489")]
	[Address(RVA = "0x16C9C74", Offset = "0x16C9C74", VA = "0x16C9C74")]
	public static int CountInputSources()
	{
		return default(int);
	}

	[Token(Token = "0x600148D")]
	[Address(RVA = "0x16CA51C", Offset = "0x16CA51C", VA = "0x16CA51C")]
	private static int CompareFunc(UICamera a, UICamera b)
	{
		return default(int);
	}

	[Token(Token = "0x600148E")]
	[Address(RVA = "0x16CA5F0", Offset = "0x16CA5F0", VA = "0x16CA5F0")]
	private static Rigidbody FindRootRigidbody(Transform trans)
	{
		return null;
	}

	[Token(Token = "0x600148F")]
	[Address(RVA = "0x16CA7A8", Offset = "0x16CA7A8", VA = "0x16CA7A8")]
	private static Rigidbody2D FindRootRigidbody2D(Transform trans)
	{
		return null;
	}

	[Token(Token = "0x6001490")]
	[Address(RVA = "0x16CA960", Offset = "0x16CA960", VA = "0x16CA960")]
	public static void Raycast(MouseOrTouch touch)
	{
	}

	[Token(Token = "0x6001491")]
	[Address(RVA = "0x16CAC00", Offset = "0x16CAC00", VA = "0x16CAC00")]
	public static bool Raycast(Vector3 inPos)
	{
		return default(bool);
	}

	[Token(Token = "0x6001492")]
	[Address(RVA = "0x16CD2F8", Offset = "0x16CD2F8", VA = "0x16CD2F8")]
	private static bool IsVisible(Vector3 worldPoint, GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6001493")]
	[Address(RVA = "0x16CD184", Offset = "0x16CD184", VA = "0x16CD184")]
	private static bool IsVisible(ref DepthEntry de)
	{
		return default(bool);
	}

	[Token(Token = "0x6001494")]
	[Address(RVA = "0x16C04C4", Offset = "0x16C04C4", VA = "0x16C04C4")]
	public static bool IsHighlighted(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x6001495")]
	[Address(RVA = "0x16C7C1C", Offset = "0x16C7C1C", VA = "0x16C7C1C")]
	public static UICamera FindCameraForLayer(int layer)
	{
		return null;
	}

	[Token(Token = "0x6001496")]
	[Address(RVA = "0x16CD478", Offset = "0x16CD478", VA = "0x16CD478")]
	private static int GetDirection(KeyCode up, KeyCode down)
	{
		return default(int);
	}

	[Token(Token = "0x6001497")]
	[Address(RVA = "0x16CD6AC", Offset = "0x16CD6AC", VA = "0x16CD6AC")]
	private static int GetDirection(KeyCode up0, KeyCode up1, KeyCode down0, KeyCode down1)
	{
		return default(int);
	}

	[Token(Token = "0x6001498")]
	[Address(RVA = "0x16CD9A8", Offset = "0x16CD9A8", VA = "0x16CD9A8")]
	private static int GetDirection(string axis)
	{
		return default(int);
	}

	[Token(Token = "0x6001499")]
	[Address(RVA = "0x16C7630", Offset = "0x16C7630", VA = "0x16C7630")]
	public static void Notify(GameObject go, string funcName, object obj)
	{
	}

	[Token(Token = "0x600149A")]
	[Address(RVA = "0x16CDCD0", Offset = "0x16CDCD0", VA = "0x16CDCD0")]
	public static MouseOrTouch GetMouse(int button)
	{
		return null;
	}

	[Token(Token = "0x600149B")]
	[Address(RVA = "0x16CDDB4", Offset = "0x16CDDB4", VA = "0x16CDDB4")]
	public static MouseOrTouch GetTouch(int id, bool createIfMissing = false)
	{
		return null;
	}

	[Token(Token = "0x600149C")]
	[Address(RVA = "0x16CE128", Offset = "0x16CE128", VA = "0x16CE128")]
	public static void RemoveTouch(int id)
	{
	}

	[Token(Token = "0x600149D")]
	[Address(RVA = "0x16CE370", Offset = "0x16CE370", VA = "0x16CE370")]
	private void Awake()
	{
	}

	[Token(Token = "0x600149E")]
	[Address(RVA = "0x16CE768", Offset = "0x16CE768", VA = "0x16CE768")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600149F")]
	[Address(RVA = "0x16CE8DC", Offset = "0x16CE8DC", VA = "0x16CE8DC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60014A0")]
	[Address(RVA = "0x16CE9C8", Offset = "0x16CE9C8", VA = "0x16CE9C8")]
	private void Start()
	{
	}

	[Token(Token = "0x60014A1")]
	[Address(RVA = "0x16CEC74", Offset = "0x16CEC74", VA = "0x16CEC74")]
	private void Update()
	{
	}

	[Token(Token = "0x60014A2")]
	[Address(RVA = "0x16CF7A0", Offset = "0x16CF7A0", VA = "0x16CF7A0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60014A3")]
	[Address(RVA = "0x16CECA4", Offset = "0x16CECA4", VA = "0x16CECA4")]
	private void ProcessEvents()
	{
	}

	[Token(Token = "0x60014A4")]
	[Address(RVA = "0x16D0400", Offset = "0x16D0400", VA = "0x16D0400")]
	public void ProcessMouse()
	{
	}

	[Token(Token = "0x60014A5")]
	[Address(RVA = "0x16CFA88", Offset = "0x16CFA88", VA = "0x16CFA88")]
	public void ProcessTouches()
	{
	}

	[Token(Token = "0x60014A6")]
	[Address(RVA = "0x16D36A0", Offset = "0x16D36A0", VA = "0x16D36A0")]
	private void ProcessFakeTouches()
	{
	}

	[Token(Token = "0x60014A7")]
	[Address(RVA = "0x16D1774", Offset = "0x16D1774", VA = "0x16D1774")]
	public void ProcessOthers()
	{
	}

	[Token(Token = "0x60014A8")]
	[Address(RVA = "0x16D3F18", Offset = "0x16D3F18", VA = "0x16D3F18")]
	private void ProcessPress(bool pressed, float click, float drag)
	{
	}

	[Token(Token = "0x60014A9")]
	[Address(RVA = "0x16D5F04", Offset = "0x16D5F04", VA = "0x16D5F04")]
	private void ProcessRelease(bool isMouse, float drag)
	{
	}

	[Token(Token = "0x60014AA")]
	[Address(RVA = "0x16D6F14", Offset = "0x16D6F14", VA = "0x16D6F14")]
	private bool HasCollider(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x60014AB")]
	[Address(RVA = "0x16D2FF8", Offset = "0x16D2FF8", VA = "0x16D2FF8")]
	public void ProcessTouch(bool pressed, bool released)
	{
	}

	[Token(Token = "0x60014AC")]
	[Address(RVA = "0x16D7114", Offset = "0x16D7114", VA = "0x16D7114")]
	public static void CancelNextTooltip()
	{
	}

	[Token(Token = "0x60014AD")]
	[Address(RVA = "0x16C7148", Offset = "0x16C7148", VA = "0x16C7148")]
	public static bool ShowTooltip(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x60014AE")]
	[Address(RVA = "0x16C4DF8", Offset = "0x16C4DF8", VA = "0x16C4DF8")]
	public static bool HideTooltip()
	{
		return default(bool);
	}

	[Token(Token = "0x60014AF")]
	[Address(RVA = "0x16D71C8", Offset = "0x16D71C8", VA = "0x16D71C8")]
	private static bool _003CGetKeyDown_003Em__78(KeyCode key)
	{
		return default(bool);
	}

	[Token(Token = "0x60014B0")]
	[Address(RVA = "0x16D72DC", Offset = "0x16D72DC", VA = "0x16D72DC")]
	private static bool _003CGetKeyUp_003Em__79(KeyCode key)
	{
		return default(bool);
	}

	[Token(Token = "0x60014B1")]
	[Address(RVA = "0x16D73F0", Offset = "0x16D73F0", VA = "0x16D73F0")]
	private static bool _003CGetKey_003Em__7A(KeyCode key)
	{
		return default(bool);
	}

	[Token(Token = "0x60014B2")]
	[Address(RVA = "0x16D7504", Offset = "0x16D7504", VA = "0x16D7504")]
	private static float _003CGetAxis_003Em__7B(string axis)
	{
		return default(float);
	}

	[Token(Token = "0x60014B3")]
	[Address(RVA = "0x16D760C", Offset = "0x16D760C", VA = "0x16D760C")]
	private static int _003CRaycast_003Em__7C(DepthEntry r1, DepthEntry r2)
	{
		return default(int);
	}

	[Token(Token = "0x60014B4")]
	[Address(RVA = "0x16D768C", Offset = "0x16D768C", VA = "0x16D768C")]
	private static int _003CRaycast_003Em__7D(DepthEntry r1, DepthEntry r2)
	{
		return default(int);
	}
}
