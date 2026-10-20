using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004E1")]
public class XGamePlayController : MonoBehaviour
{
	[Token(Token = "0x20004E2")]
	private sealed class _003CCoroutineCameraAni_003Ec__Iterator42 : IDisposable
	{
		[Token(Token = "0x40018B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal float fTime;

		[Token(Token = "0x40018B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal string strAni;

		[Token(Token = "0x40018B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal float aniScale;

		[Token(Token = "0x40018B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x40018B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x40018B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal float _003C_0024_003EfTime;

		[Token(Token = "0x40018BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal string _003C_0024_003EstrAni;

		[Token(Token = "0x40018BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal float _003C_0024_003EaniScale;

		[Token(Token = "0x40018BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal XGamePlayController _003C_003Ef__this;

		[Token(Token = "0x170006A7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002A69")]
			[Address(RVA = "0x1D118F0", Offset = "0x1D118F0", VA = "0x1D118F0", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006A8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002A6A")]
			[Address(RVA = "0x1D118F8", Offset = "0x1D118F8", VA = "0x1D118F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002A68")]
		[Address(RVA = "0x1D118E8", Offset = "0x1D118E8", VA = "0x1D118E8")]
		public _003CCoroutineCameraAni_003Ec__Iterator42()
		{
		}

		[Token(Token = "0x6002A69")]
		[Address(RVA = "0x1D118F0", Offset = "0x1D118F0", VA = "0x1D118F0", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002A6A")]
		[Address(RVA = "0x1D118F8", Offset = "0x1D118F8", VA = "0x1D118F8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002A6B")]
		[Address(RVA = "0x1D11900", Offset = "0x1D11900", VA = "0x1D11900", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002A6C")]
		[Address(RVA = "0x1D119F4", Offset = "0x1D119F4", VA = "0x1D119F4", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002A6D")]
		[Address(RVA = "0x1D11A00", Offset = "0x1D11A00", VA = "0x1D11A00", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20004E3")]
	private sealed class _003CCoroutineSkillCameraAni_003Ec__Iterator43 : IDisposable
	{
		[Token(Token = "0x40018BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal float fTime;

		[Token(Token = "0x40018BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal string strAni;

		[Token(Token = "0x40018BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal float aniScale;

		[Token(Token = "0x40018C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x40018C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x40018C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal float _003C_0024_003EfTime;

		[Token(Token = "0x40018C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal string _003C_0024_003EstrAni;

		[Token(Token = "0x40018C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal float _003C_0024_003EaniScale;

		[Token(Token = "0x40018C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal XGamePlayController _003C_003Ef__this;

		[Token(Token = "0x170006A9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002A6F")]
			[Address(RVA = "0x1D11A9C", Offset = "0x1D11A9C", VA = "0x1D11A9C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006AA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002A70")]
			[Address(RVA = "0x1D11AA4", Offset = "0x1D11AA4", VA = "0x1D11AA4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002A6E")]
		[Address(RVA = "0x1D11A94", Offset = "0x1D11A94", VA = "0x1D11A94")]
		public _003CCoroutineSkillCameraAni_003Ec__Iterator43()
		{
		}

		[Token(Token = "0x6002A6F")]
		[Address(RVA = "0x1D11A9C", Offset = "0x1D11A9C", VA = "0x1D11A9C", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002A70")]
		[Address(RVA = "0x1D11AA4", Offset = "0x1D11AA4", VA = "0x1D11AA4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002A71")]
		[Address(RVA = "0x1D11AAC", Offset = "0x1D11AAC", VA = "0x1D11AAC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002A72")]
		[Address(RVA = "0x1D11BA8", Offset = "0x1D11BA8", VA = "0x1D11BA8", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002A73")]
		[Address(RVA = "0x1D11BB4", Offset = "0x1D11BB4", VA = "0x1D11BB4", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20004E4")]
	private sealed class _003CCoroutineSkillCameraAni2_003Ec__Iterator44 : IDisposable
	{
		[Token(Token = "0x40018C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal float fTime;

		[Token(Token = "0x40018C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal string strAni;

		[Token(Token = "0x40018C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal float aniScale;

		[Token(Token = "0x40018C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x40018CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x40018CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal float _003C_0024_003EfTime;

		[Token(Token = "0x40018CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal string _003C_0024_003EstrAni;

		[Token(Token = "0x40018CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal float _003C_0024_003EaniScale;

		[Token(Token = "0x40018CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal XGamePlayController _003C_003Ef__this;

		[Token(Token = "0x170006AB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002A75")]
			[Address(RVA = "0x1D11C50", Offset = "0x1D11C50", VA = "0x1D11C50", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006AC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002A76")]
			[Address(RVA = "0x1D11C58", Offset = "0x1D11C58", VA = "0x1D11C58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002A74")]
		[Address(RVA = "0x1D11C48", Offset = "0x1D11C48", VA = "0x1D11C48")]
		public _003CCoroutineSkillCameraAni2_003Ec__Iterator44()
		{
		}

		[Token(Token = "0x6002A75")]
		[Address(RVA = "0x1D11C50", Offset = "0x1D11C50", VA = "0x1D11C50", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002A76")]
		[Address(RVA = "0x1D11C58", Offset = "0x1D11C58", VA = "0x1D11C58", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002A77")]
		[Address(RVA = "0x1D11C60", Offset = "0x1D11C60", VA = "0x1D11C60", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002A78")]
		[Address(RVA = "0x1D11D5C", Offset = "0x1D11D5C", VA = "0x1D11D5C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002A79")]
		[Address(RVA = "0x1D11D68", Offset = "0x1D11D68", VA = "0x1D11D68", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40018B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private XCamera m_Camera;

	[Token(Token = "0x40018B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private XSpectatorController m_spectator;

	[Token(Token = "0x40018B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private IEnumerator m_coroutineSkillCameraAni;

	[Token(Token = "0x40018B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private IEnumerator m_coroutineSkillCameraAni2;

	[Token(Token = "0x6002A48")]
	[Address(RVA = "0x1425E60", Offset = "0x1425E60", VA = "0x1425E60")]
	public XGamePlayController()
	{
	}

	[Token(Token = "0x6002A49")]
	[Address(RVA = "0x13ED35C", Offset = "0x13ED35C", VA = "0x13ED35C")]
	public void EnableSpectatorMode(bool isEnable, BoxCollider collider)
	{
	}

	[Token(Token = "0x6002A4A")]
	[Address(RVA = "0x13F9000", Offset = "0x13F9000", VA = "0x13F9000")]
	public void Init(float fCameraMinY = -100000000f)
	{
	}

	[Token(Token = "0x6002A4B")]
	[Address(RVA = "0x1425EFC", Offset = "0x1425EFC", VA = "0x1425EFC")]
	private void Start()
	{
	}

	[Token(Token = "0x6002A4C")]
	[Address(RVA = "0x1425F00", Offset = "0x1425F00", VA = "0x1425F00")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6002A4D")]
	[Address(RVA = "0x1426080", Offset = "0x1426080", VA = "0x1426080")]
	private void UpdateCamera()
	{
	}

	[Token(Token = "0x6002A4E")]
	[Address(RVA = "0x1426478", Offset = "0x1426478", VA = "0x1426478")]
	[DebuggerHidden]
	private IEnumerator CoroutineCameraAni(float fTime, string strAni, float aniScale = 1f)
	{
		return null;
	}

	[Token(Token = "0x6002A4F")]
	[Address(RVA = "0x1426548", Offset = "0x1426548", VA = "0x1426548")]
	public void PlayCameraAniDelayed(string aniName, float waitTime, float aniScale = 1f)
	{
	}

	[Token(Token = "0x6002A50")]
	[Address(RVA = "0x14266B0", Offset = "0x14266B0", VA = "0x14266B0")]
	private void PlayCameraAni(string aniName, float aniScale = 1f)
	{
	}

	[Token(Token = "0x6002A51")]
	[Address(RVA = "0x14266DC", Offset = "0x14266DC", VA = "0x14266DC")]
	[DebuggerHidden]
	private IEnumerator CoroutineSkillCameraAni(float fTime, string strAni, float aniScale = 1f)
	{
		return null;
	}

	[Token(Token = "0x6002A52")]
	[Address(RVA = "0x14267AC", Offset = "0x14267AC", VA = "0x14267AC")]
	[DebuggerHidden]
	private IEnumerator CoroutineSkillCameraAni2(float fTime, string strAni, float aniScale = 1f)
	{
		return null;
	}

	[Token(Token = "0x6002A53")]
	[Address(RVA = "0x13ED43C", Offset = "0x13ED43C", VA = "0x13ED43C")]
	public void SetTargetInCamera(GameObject target)
	{
	}

	[Token(Token = "0x6002A54")]
	[Address(RVA = "0x142687C", Offset = "0x142687C", VA = "0x142687C")]
	public void PlaySkillCameraAniDelayed(string aniName, float waitTime, float aniScale = 1f)
	{
	}

	[Token(Token = "0x6002A55")]
	[Address(RVA = "0x1426AC8", Offset = "0x1426AC8", VA = "0x1426AC8")]
	public void PlaySkillCameraAniDelayed2(string aniName, float waitTime, float aniScale = 1f)
	{
	}

	[Token(Token = "0x6002A56")]
	[Address(RVA = "0x14269E8", Offset = "0x14269E8", VA = "0x14269E8")]
	public void PlaySkillCameraAni(string aniName, float aniScale = 1f)
	{
	}

	[Token(Token = "0x6002A57")]
	[Address(RVA = "0x1426D14", Offset = "0x1426D14", VA = "0x1426D14")]
	public void StopSkillCameraAni(string aniName)
	{
	}

	[Token(Token = "0x6002A58")]
	[Address(RVA = "0x1426C34", Offset = "0x1426C34", VA = "0x1426C34")]
	public void PlaySkillCameraAni2(string aniName, float aniScale = 1f)
	{
	}

	[Token(Token = "0x6002A59")]
	[Address(RVA = "0x1426E60", Offset = "0x1426E60", VA = "0x1426E60")]
	public void StopSkillCameraAni2(string aniName)
	{
	}

	[Token(Token = "0x6002A5A")]
	[Address(RVA = "0x1426FAC", Offset = "0x1426FAC", VA = "0x1426FAC")]
	public void HoldCamera(bool val, [Optional] Vector3? pos)
	{
	}

	[Token(Token = "0x6002A5B")]
	[Address(RVA = "0x13ED8A0", Offset = "0x13ED8A0", VA = "0x13ED8A0")]
	public void PlayCameraFocusBoss(string moveEaseType, string rotateEaseType, Transform focusingTarget, Vector3 transformOffset, float focusingOffset, float focucingMoveSpeed_Boss, float focucingRotateSpeed_Boss, [Optional] Action action)
	{
	}

	[Token(Token = "0x6002A5C")]
	[Address(RVA = "0x13FA71C", Offset = "0x13FA71C", VA = "0x13FA71C")]
	public void PlayCameraFocusPlayer(string moveEaseType, string rotateEaseType, float focucingMoveSpeed_Player, float focucingRotateSpeed_Player, [Optional] Action action)
	{
	}

	[Token(Token = "0x6002A5D")]
	[Address(RVA = "0x13FABDC", Offset = "0x13FABDC", VA = "0x13FABDC")]
	public void PlayCameraClearShaking(string shakeEaseType, float shakingDuration, float shakingAmount, float shakingSpeed, [Optional] Action action)
	{
	}

	[Token(Token = "0x6002A5E")]
	[Address(RVA = "0x13EEAD0", Offset = "0x13EEAD0", VA = "0x13EEAD0")]
	public void PlayCameraResultDirection(string moveEaseType, string rotateEaseType, Transform focusingTarget, float lookatHeightOffset, float moveRightDistance, float moveUpDistance, float moveforwarDistance, float focucingRotateSpeed, [Optional] Action action)
	{
	}

	[Token(Token = "0x6002A5F")]
	[Address(RVA = "0x13EF554", Offset = "0x13EF554", VA = "0x13EF554")]
	public void PlayGameResultExpression(string moveEaseType, float moveSpeed, float moveDistance, [Optional] Action action)
	{
	}

	[Token(Token = "0x6002A60")]
	[Address(RVA = "0x13EDEE8", Offset = "0x13EDEE8", VA = "0x13EDEE8")]
	public void PlayTutorialCineamEnemyComeAni(Transform enemyTransform, [Optional] Action action)
	{
	}

	[Token(Token = "0x6002A61")]
	[Address(RVA = "0x13EDF40", Offset = "0x13EDF40", VA = "0x13EDF40")]
	public void PlayUlitmateSkillStartAni(Transform myCharacterTransform, [Optional] Action action)
	{
	}

	[Token(Token = "0x6002A62")]
	[Address(RVA = "0x13EEB60", Offset = "0x13EEB60", VA = "0x13EEB60")]
	public void ResetCamera()
	{
	}

	[Token(Token = "0x6002A63")]
	[Address(RVA = "0x13EEBB4", Offset = "0x13EEBB4", VA = "0x13EEBB4")]
	public void DisableCamera()
	{
	}

	[Token(Token = "0x6002A64")]
	[Address(RVA = "0x1426FF4", Offset = "0x1426FF4", VA = "0x1426FF4")]
	public void EnableCamera()
	{
	}

	[Token(Token = "0x6002A65")]
	[Address(RVA = "0x13EF7D8", Offset = "0x13EF7D8", VA = "0x13EF7D8")]
	public Vector3 GetCameraPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6002A66")]
	[Address(RVA = "0x13EF9E4", Offset = "0x13EF9E4", VA = "0x13EF9E4")]
	public Vector3 GetCharacterAudioSourcePosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6002A67")]
	[Address(RVA = "0x14260C4", Offset = "0x14260C4", VA = "0x14260C4")]
	private void UpdateMouseCameraMove()
	{
	}
}
