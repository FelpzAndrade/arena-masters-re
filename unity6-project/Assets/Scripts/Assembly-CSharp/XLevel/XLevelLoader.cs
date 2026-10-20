using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace XLevel
{
	[Token(Token = "0x2000746")]
	public class XLevelLoader
	{
		[Token(Token = "0x400227A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly JsonSerializerSettings jsonSettings;

		[Token(Token = "0x400227B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly string root;

		[Token(Token = "0x400227C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private LevelData m_levelData;

		[Token(Token = "0x400227D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private Func<LevelObjectData, XModuleLevelObject> m_objectLoader;

		[Token(Token = "0x400227E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Action<XLevelLoader> m_onFinish;

		[Token(Token = "0x400227F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Action m_onClear;

		[Token(Token = "0x4002280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Action m_onFailure;

		[Token(Token = "0x4002281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Action<XModuleLevelObject> m_onObjectDie;

		[Token(Token = "0x4002282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Queue<AreaData> m_areaData;

		[Token(Token = "0x4002283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private List<XAreaLoader> m_activeAreaLoader;

		[Token(Token = "0x4002284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Vector3> m_wayPoints;

		[Token(Token = "0x4002285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private ActionEntityTargetManager m_actionEntityTargetManager;

		[Token(Token = "0x4002286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_pause;

		[Token(Token = "0x4002287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private AreaData m_getReadyAreaData;

		[Token(Token = "0x4002288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<XAreaLoader> m_activeGetReadyAreaLoader;

		[Token(Token = "0x4002289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Action m_onGetReadyAreaLoadClear;

		[Token(Token = "0x17000837")]
		public LevelData LevelData
		{
			[Token(Token = "0x6003B85")]
			[Address(RVA = "0x202E024", Offset = "0x202E024", VA = "0x202E024")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000838")]
		public float? GroundPos
		{
			[Token(Token = "0x6003B86")]
			[Address(RVA = "0x202E02C", Offset = "0x202E02C", VA = "0x202E02C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003B81")]
		[Address(RVA = "0x202D6A8", Offset = "0x202D6A8", VA = "0x202D6A8")]
		public XLevelLoader(LevelData data, Func<LevelObjectData, XModuleLevelObject> resourceLoader, Action<XModuleLevelObject> onObjDie, Action<XLevelLoader> onFinish, [Optional] Action onClear, [Optional] Action onFailure)
		{
		}

		[Token(Token = "0x6003B83")]
		[Address(RVA = "0x202DAC0", Offset = "0x202DAC0", VA = "0x202DAC0")]
		public static LevelData LoadLevelData(string path)
		{
			return null;
		}

		[Token(Token = "0x6003B84")]
		[Address(RVA = "0x202DEB4", Offset = "0x202DEB4", VA = "0x202DEB4")]
		public static void ApplyFieldLevel(LevelData data, int fieldLevel)
		{
		}

		[Token(Token = "0x6003B87")]
		[Address(RVA = "0x202D814", Offset = "0x202D814", VA = "0x202D814")]
		public void Init(LevelData data, Func<LevelObjectData, XModuleLevelObject> objectLoader, Action<XModuleLevelObject> onObjDie, Action<XLevelLoader> onFinish, Action onClear, Action onFailure)
		{
		}

		[Token(Token = "0x6003B88")]
		[Address(RVA = "0x202E180", Offset = "0x202E180", VA = "0x202E180")]
		public List<Vector3> GetCurrentWayPoints()
		{
			return null;
		}

		[Token(Token = "0x6003B89")]
		[Address(RVA = "0x202E188", Offset = "0x202E188", VA = "0x202E188")]
		public void Start()
		{
		}

		[Token(Token = "0x6003B8A")]
		[Address(RVA = "0x202E1AC", Offset = "0x202E1AC", VA = "0x202E1AC")]
		private void LoadDeco()
		{
		}

		[Token(Token = "0x6003B8B")]
		[Address(RVA = "0x202E710", Offset = "0x202E710", VA = "0x202E710")]
		public void Pause(bool pause)
		{
		}

		[Token(Token = "0x6003B8C")]
		[Address(RVA = "0x202E904", Offset = "0x202E904", VA = "0x202E904")]
		public void Kill()
		{
		}

		[Token(Token = "0x6003B8D")]
		[Address(RVA = "0x202E2F8", Offset = "0x202E2F8", VA = "0x202E2F8")]
		private void InitNext()
		{
		}

		[Token(Token = "0x6003B8E")]
		[Address(RVA = "0x202E724", Offset = "0x202E724", VA = "0x202E724")]
		private void PauseAreas()
		{
		}

		[Token(Token = "0x6003B8F")]
		[Address(RVA = "0x202E814", Offset = "0x202E814", VA = "0x202E814")]
		private void ResumeAreas()
		{
		}

		[Token(Token = "0x6003B90")]
		[Address(RVA = "0x202EAF8", Offset = "0x202EAF8", VA = "0x202EAF8")]
		private void OnAreaFinish(XAreaLoader areaLoder)
		{
		}

		[Token(Token = "0x6003B91")]
		[Address(RVA = "0x202ECB0", Offset = "0x202ECB0", VA = "0x202ECB0")]
		private void OnClear()
		{
		}

		[Token(Token = "0x6003B92")]
		[Address(RVA = "0x202ECC4", Offset = "0x202ECC4", VA = "0x202ECC4")]
		private void OnFailure()
		{
		}

		[Token(Token = "0x6003B93")]
		[Address(RVA = "0x202EC14", Offset = "0x202EC14", VA = "0x202EC14")]
		private void Finish()
		{
		}

		[Token(Token = "0x6003B94")]
		[Address(RVA = "0x202E9C8", Offset = "0x202E9C8", VA = "0x202E9C8")]
		public void FixedUpdate(float delta)
		{
		}

		[Token(Token = "0x6003B95")]
		[Address(RVA = "0x202E570", Offset = "0x202E570", VA = "0x202E570")]
		private void InitGetReady()
		{
		}

		[Token(Token = "0x6003B96")]
		[Address(RVA = "0x202ECD8", Offset = "0x202ECD8", VA = "0x202ECD8")]
		private void OnGetReadyAreaLoadClear()
		{
		}

		[Token(Token = "0x6003B97")]
		[Address(RVA = "0x202ED84", Offset = "0x202ED84", VA = "0x202ED84")]
		public void FixedUpdateGetReady(float delta)
		{
		}

		[Token(Token = "0x6003B98")]
		[Address(RVA = "0x202EE7C", Offset = "0x202EE7C", VA = "0x202EE7C")]
		public void RegisterGetReadyAreaLoadClear(Action getReadyAreaLoadClear)
		{
		}
	}
}
