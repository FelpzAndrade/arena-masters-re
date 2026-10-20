using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace PigeonCoopToolkit.Effects.Trails
{
	[Token(Token = "0x200033C")]
	public abstract class TrailRenderer_Base : MonoBehaviour
	{
		[Token(Token = "0x40010FF")]
		[FieldOffset(Offset = "0xC")]
		public PCTrailRendererData TrailData;

		[Token(Token = "0x4001100")]
		[FieldOffset(Offset = "0x10")]
		public bool Emit;

		[Token(Token = "0x4001101")]
		[FieldOffset(Offset = "0x11")]
		protected bool _emit;

		[Token(Token = "0x4001102")]
		[FieldOffset(Offset = "0x12")]
		protected bool _noDecay;

		[Token(Token = "0x4001103")]
		[FieldOffset(Offset = "0x14")]
		private PCTrail _activeTrail;

		[Token(Token = "0x4001104")]
		[FieldOffset(Offset = "0x18")]
		private List<PCTrail> _fadingTrails;

		[Token(Token = "0x4001105")]
		[FieldOffset(Offset = "0x1C")]
		protected Transform _t;

		[Token(Token = "0x4001106")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<Material, List<PCTrail>> _matToTrailList;

		[Token(Token = "0x4001107")]
		[FieldOffset(Offset = "0x4")]
		private static List<Mesh> _toClean;

		[Token(Token = "0x4001108")]
		[FieldOffset(Offset = "0x8")]
		private static bool _hasRenderer;

		[Token(Token = "0x4001109")]
		[FieldOffset(Offset = "0xC")]
		private static int GlobalTrailRendererCount;

		[Token(Token = "0x6001B7B")]
		[Address(RVA = "0x1BABE0C", Offset = "0x1BABE0C", VA = "0x1BABE0C")]
		protected TrailRenderer_Base()
		{
		}

		[Token(Token = "0x6001B7D")]
		[Address(RVA = "0x1BAFAB4", Offset = "0x1BAFAB4", VA = "0x1BAFAB4", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6001B7E")]
		[Address(RVA = "0x1BABE20", Offset = "0x1BABE20", VA = "0x1BABE20", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6001B7F")]
		[Address(RVA = "0x1BAFD6C", Offset = "0x1BAFD6C", VA = "0x1BAFD6C", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6001B80")]
		[Address(RVA = "0x1BAC7B8", Offset = "0x1BAC7B8", VA = "0x1BAC7B8", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6001B81")]
		[Address(RVA = "0x1BB18AC", Offset = "0x1BB18AC", VA = "0x1BB18AC", Slot = "8")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6001B82")]
		[Address(RVA = "0x1BB1F8C", Offset = "0x1BB1F8C", VA = "0x1BB1F8C", Slot = "9")]
		protected virtual void OnStopEmit()
		{
		}

		[Token(Token = "0x6001B83")]
		[Address(RVA = "0x1BB1F90", Offset = "0x1BB1F90", VA = "0x1BB1F90", Slot = "10")]
		protected virtual void OnStartEmit()
		{
		}

		[Token(Token = "0x6001B84")]
		[Address(RVA = "0x1BB1F94", Offset = "0x1BB1F94", VA = "0x1BB1F94", Slot = "11")]
		protected virtual void OnTranslate(Vector3 t)
		{
		}

		[Token(Token = "0x6001B85")]
		protected abstract int GetMaxNumberOfPoints();

		[Token(Token = "0x6001B86")]
		[Address(RVA = "0x1BAC064", Offset = "0x1BAC064", VA = "0x1BAC064", Slot = "13")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x6001B87")]
		[Address(RVA = "0x1BB1F98", Offset = "0x1BB1F98", VA = "0x1BB1F98", Slot = "14")]
		protected virtual void InitialiseNewPoint(PCTrailPoint newPoint)
		{
		}

		[Token(Token = "0x6001B88")]
		[Address(RVA = "0x1BB1F9C", Offset = "0x1BB1F9C", VA = "0x1BB1F9C", Slot = "15")]
		protected virtual void UpdateTrail(PCTrail trail, float deltaTime)
		{
		}

		[Token(Token = "0x6001B89")]
		[Address(RVA = "0x1BAC454", Offset = "0x1BAC454", VA = "0x1BAC454")]
		protected void AddPoint(PCTrailPoint newPoint, Vector3 pos)
		{
		}

		[Token(Token = "0x6001B8A")]
		[Address(RVA = "0x1BB07C4", Offset = "0x1BB07C4", VA = "0x1BB07C4")]
		private void GenerateMesh(PCTrail trail)
		{
		}

		[Token(Token = "0x6001B8B")]
		[Address(RVA = "0x1BB0568", Offset = "0x1BB0568", VA = "0x1BB0568")]
		private void DrawMesh(Mesh trailMesh, Material trailMaterial)
		{
		}

		[Token(Token = "0x6001B8C")]
		[Address(RVA = "0x1BB0660", Offset = "0x1BB0660", VA = "0x1BB0660")]
		private void UpdatePoints(PCTrail line, float deltaTime)
		{
		}

		[Token(Token = "0x6001B8D")]
		[Address(RVA = "0x1BB20B4", Offset = "0x1BB20B4", VA = "0x1BB20B4", Slot = "16")]
		protected virtual void UpdatePoint(PCTrailPoint pCTrailPoint, float deltaTime)
		{
		}

		[Token(Token = "0x6001B8E")]
		[Address(RVA = "0x1BB1700", Offset = "0x1BB1700", VA = "0x1BB1700")]
		private void CheckEmitChange()
		{
		}

		[Token(Token = "0x6001B8F")]
		[Address(RVA = "0x1BB1FA0", Offset = "0x1BB1FA0", VA = "0x1BB1FA0")]
		private int NumberOfActivePoints(PCTrail line)
		{
			return default(int);
		}

		[Token(Token = "0x6001B90")]
		[Address(RVA = "0x1BB20B8", Offset = "0x1BB20B8", VA = "0x1BB20B8")]
		protected void ToggleSizeInputStyle()
		{
		}

		[Token(Token = "0x6001B91")]
		[Address(RVA = "0x1BB20E4", Offset = "0x1BB20E4", VA = "0x1BB20E4")]
		protected void ToggleColorInputStyle()
		{
		}

		[Token(Token = "0x6001B92")]
		[Address(RVA = "0x1BB2110", Offset = "0x1BB2110", VA = "0x1BB2110")]
		public void LifeDecayEnabled(bool enabled)
		{
		}

		[Token(Token = "0x6001B93")]
		[Address(RVA = "0x1BB211C", Offset = "0x1BB211C", VA = "0x1BB211C")]
		public void Translate(Vector3 t)
		{
		}

		[Token(Token = "0x6001B94")]
		[Address(RVA = "0x1BB2570", Offset = "0x1BB2570", VA = "0x1BB2570")]
		public void CreateTrail(Vector3 from, Vector3 to, float distanceBetweenPoints)
		{
		}

		[Token(Token = "0x6001B95")]
		[Address(RVA = "0x1BB299C", Offset = "0x1BB299C", VA = "0x1BB299C")]
		public void ClearSystem(bool emitState)
		{
		}

		[Token(Token = "0x6001B96")]
		[Address(RVA = "0x1BB2C0C", Offset = "0x1BB2C0C", VA = "0x1BB2C0C")]
		public int NumSegments()
		{
			return default(int);
		}

		[Token(Token = "0x6001B97")]
		[Address(RVA = "0x1BB2CCC", Offset = "0x1BB2CCC", VA = "0x1BB2CCC")]
		private bool _003CUpdate_003Em__86(PCTrailPoint a)
		{
			return default(bool);
		}
	}
}
