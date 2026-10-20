using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004C3")]
public class XCamera
{
	[Token(Token = "0x20004C4")]
	private enum EFFECT_STATE
	{
		[Token(Token = "0x4001807")]
		None = 0,
		[Token(Token = "0x4001808")]
		Normal = 1,
		[Token(Token = "0x4001809")]
		FocusingBoss = 2,
		[Token(Token = "0x400180A")]
		FocusingPlayer = 3,
		[Token(Token = "0x400180B")]
		ClearShaking = 4,
		[Token(Token = "0x400180C")]
		Hold = 5,
		[Token(Token = "0x400180D")]
		ClearStage = 6,
		[Token(Token = "0x400180E")]
		GameResultExprssion = 7,
		[Token(Token = "0x400180F")]
		TutorialCinemaComeEnemy = 8,
		[Token(Token = "0x4001810")]
		UltimateSkillStart = 9
	}

	[Token(Token = "0x40017E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private EFFECT_STATE m_effectState;

	[Token(Token = "0x40017E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Camera m_mainCam;

	[Token(Token = "0x40017E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private GameObject m_objCameraAni;

	[Token(Token = "0x40017E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private GameObject m_objSkillCameraAni;

	[Token(Token = "0x40017E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject m_objSkillCameraAni2;

	[Token(Token = "0x40017EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private GameObject m_objTutorialCinemaCamera;

	[Token(Token = "0x40017EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject m_objUltimateCinemaCamera;

	[Token(Token = "0x40017EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float m_fPreZoomDist;

	[Token(Token = "0x40017ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float m_fCurZoomDist;

	[Token(Token = "0x40017EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float m_fCameraMinY;

	[Token(Token = "0x40017EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float m_rangeOffset;

	[Token(Token = "0x40017F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private string m_LastSkillCameraAniName;

	[Token(Token = "0x40017F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string m_LastSkillCameraAniName2;

	[Token(Token = "0x40017F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float m_aniScale;

	[Token(Token = "0x40017F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float m_SkillAniScale;

	[Token(Token = "0x40017F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float m_SkillAniScale2;

	[Token(Token = "0x40017F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject m_targetObj;

	[Token(Token = "0x40017F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Transform m_enemyTransform;

	[Token(Token = "0x40017F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform m_myCharacterTransform;

	[Token(Token = "0x40017F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private bool m_isStartTracing_Move;

	[Token(Token = "0x40017F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	private bool m_isStartTracing_Rotate;

	[Token(Token = "0x40017FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Quaternion m_tracingBossQuaternion;

	[Token(Token = "0x40017FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3 m_tracingBossPos;

	[Token(Token = "0x40017FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private Quaternion m_tracingResultQuaternion;

	[Token(Token = "0x40017FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Vector3 m_tracingResultPos;

	[Token(Token = "0x40017FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 m_targetCameraPos;

	[Token(Token = "0x40017FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private Quaternion m_originalCameraQuaternion;

	[Token(Token = "0x4001800")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private Vector3 m_originalCameraPosition;

	[Token(Token = "0x4001801")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Action action;

	[Token(Token = "0x4001802")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private float m_shakingDuration;

	[Token(Token = "0x4001803")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float m_deltaDuration;

	[Token(Token = "0x4001804")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private Quaternion m_qRot;

	[Token(Token = "0x4001805")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private int m_cullingMask;

	[Token(Token = "0x60028DD")]
	[Address(RVA = "0x1A9CF40", Offset = "0x1A9CF40", VA = "0x1A9CF40")]
	public XCamera()
	{
	}

	[Token(Token = "0x60028DE")]
	[Address(RVA = "0x1A9D08C", Offset = "0x1A9D08C", VA = "0x1A9D08C")]
	public void SetTargetObj(GameObject target)
	{
	}

	[Token(Token = "0x60028DF")]
	[Address(RVA = "0x1A9D094", Offset = "0x1A9D094", VA = "0x1A9D094")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x60028E0")]
	[Address(RVA = "0x1A9D640", Offset = "0x1A9D640", VA = "0x1A9D640")]
	public void Init(float fCameraMinY)
	{
	}

	[Token(Token = "0x60028E1")]
	[Address(RVA = "0x1A9D984", Offset = "0x1A9D984", VA = "0x1A9D984")]
	private void PreLoadCameraAni()
	{
	}

	[Token(Token = "0x60028E2")]
	[Address(RVA = "0x1A9E76C", Offset = "0x1A9E76C", VA = "0x1A9E76C")]
	public void UpdateCamera()
	{
	}

	[Token(Token = "0x60028E3")]
	[Address(RVA = "0x1A9E884", Offset = "0x1A9E884", VA = "0x1A9E884")]
	private GameObject GetSeletedCharater()
	{
		return null;
	}

	[Token(Token = "0x60028E4")]
	[Address(RVA = "0x1A9E88C", Offset = "0x1A9E88C", VA = "0x1A9E88C")]
	private void UpdateCameraPlayer(GameObject objLeader)
	{
	}

	[Token(Token = "0x60028E5")]
	[Address(RVA = "0x1A9E8F4", Offset = "0x1A9E8F4", VA = "0x1A9E8F4")]
	private void ChacingPlayer(GameObject objLeader)
	{
	}

	[Token(Token = "0x60028E6")]
	[Address(RVA = "0x1A9E9D0", Offset = "0x1A9E9D0", VA = "0x1A9E9D0")]
	private void FocusingBoss()
	{
	}

	[Token(Token = "0x60028E7")]
	[Address(RVA = "0x1A9EB2C", Offset = "0x1A9EB2C", VA = "0x1A9EB2C")]
	private void FocusingPlayer()
	{
	}

	[Token(Token = "0x60028E8")]
	[Address(RVA = "0x1A9EC88", Offset = "0x1A9EC88", VA = "0x1A9EC88")]
	private void ClearShaking()
	{
	}

	[Token(Token = "0x60028E9")]
	[Address(RVA = "0x1A9EE50", Offset = "0x1A9EE50", VA = "0x1A9EE50")]
	private void ResultExpression()
	{
	}

	[Token(Token = "0x60028EA")]
	[Address(RVA = "0x1A9EEF0", Offset = "0x1A9EEF0", VA = "0x1A9EEF0")]
	private void CharacterTutorialCinemaEnemyCome()
	{
	}

	[Token(Token = "0x60028EB")]
	[Address(RVA = "0x1A9F444", Offset = "0x1A9F444", VA = "0x1A9F444")]
	private void UltimateSkillStart()
	{
	}

	[Token(Token = "0x60028EC")]
	[Address(RVA = "0x1A9ECF4", Offset = "0x1A9ECF4", VA = "0x1A9ECF4")]
	private void ClearStage()
	{
	}

	[Token(Token = "0x60028ED")]
	[Address(RVA = "0x1A9F980", Offset = "0x1A9F980", VA = "0x1A9F980")]
	public void PlayCameraFocusBoss(string moveEaseType, string rotateEaseType, Transform focusingTarget, Vector3 transformOffset, float focusingOffset, float focucingMoveSpeed, float focucingRotateSpeed, [Optional] Action action)
	{
	}

	[Token(Token = "0x60028EE")]
	[Address(RVA = "0x1AA0484", Offset = "0x1AA0484", VA = "0x1AA0484")]
	public void PlayCameraFocusPlayer(string moveEaseType, string rotateEaseType, float focucingMoveSpeed, float focucingRotateSpeed, [Optional] Action action)
	{
	}

	[Token(Token = "0x60028EF")]
	[Address(RVA = "0x1AA0524", Offset = "0x1AA0524", VA = "0x1AA0524")]
	public void PlayCameraResultDirection(string moveEaseType, string rotateEaseType, Transform focusingTarget, float lookatHeightOffset, float moveRightDistance, float moveUpDistance, float moveforwarDistance, float focucingRotateSpeed, [Optional] Action action)
	{
	}

	[Token(Token = "0x60028F0")]
	[Address(RVA = "0x1AA1164", Offset = "0x1AA1164", VA = "0x1AA1164")]
	public void PlayCameraClearShaking(string shakeEaseType, float shakingDuration, float shakingAngle, float shakingSpeed, [Optional] Action action)
	{
	}

	[Token(Token = "0x60028F1")]
	[Address(RVA = "0x1AA1724", Offset = "0x1AA1724", VA = "0x1AA1724")]
	public void PlayGameResultExpression(string moveEaseType, float moveSpeed, float moveDistance, [Optional] Action action)
	{
	}

	[Token(Token = "0x60028F2")]
	[Address(RVA = "0x1AA1CD0", Offset = "0x1AA1CD0", VA = "0x1AA1CD0")]
	public void ResetCamera()
	{
	}

	[Token(Token = "0x60028F3")]
	[Address(RVA = "0x1AA1E14", Offset = "0x1AA1E14", VA = "0x1AA1E14")]
	public void DisableCamera()
	{
	}

	[Token(Token = "0x60028F4")]
	[Address(RVA = "0x1AA1E60", Offset = "0x1AA1E60", VA = "0x1AA1E60")]
	public void EnableCamera()
	{
	}

	[Token(Token = "0x60028F5")]
	[Address(RVA = "0x1AA1E98", Offset = "0x1AA1E98", VA = "0x1AA1E98")]
	public void PlayCameraAni(string str, float aniScale = 1f)
	{
	}

	[Token(Token = "0x60028F6")]
	[Address(RVA = "0x1AA1F84", Offset = "0x1AA1F84", VA = "0x1AA1F84")]
	public void PlaySkillCameraAni(string str, float aniScale = 1f)
	{
	}

	[Token(Token = "0x60028F7")]
	[Address(RVA = "0x1AA2074", Offset = "0x1AA2074", VA = "0x1AA2074")]
	public void StopSkillCameraAni(string str)
	{
	}

	[Token(Token = "0x60028F8")]
	[Address(RVA = "0x1AA21C0", Offset = "0x1AA21C0", VA = "0x1AA21C0")]
	public void PlaySkillCameraAni2(string str, float aniScale = 1f)
	{
	}

	[Token(Token = "0x60028F9")]
	[Address(RVA = "0x1AA22B0", Offset = "0x1AA22B0", VA = "0x1AA22B0")]
	public void StopSkillCameraAni2(string str)
	{
	}

	[Token(Token = "0x60028FA")]
	[Address(RVA = "0x1AA23FC", Offset = "0x1AA23FC", VA = "0x1AA23FC")]
	public void PlayTutorialCineamEnemyComeAni(Transform enemyTransform, [Optional] Action action)
	{
	}

	[Token(Token = "0x60028FB")]
	[Address(RVA = "0x1AA2594", Offset = "0x1AA2594", VA = "0x1AA2594")]
	public void PlayUlitmateSkillStartAni(Transform myCharacterTransform, [Optional] Action action)
	{
	}

	[Token(Token = "0x60028FC")]
	[Address(RVA = "0x1AA272C", Offset = "0x1AA272C", VA = "0x1AA272C")]
	public void Hold(bool val, [Optional] Vector3? pos)
	{
	}

	[Token(Token = "0x60028FD")]
	[Address(RVA = "0x1A9F854", Offset = "0x1A9F854", VA = "0x1A9F854")]
	private void UpdatePosition(Vector3 vecPos)
	{
	}

	[Token(Token = "0x60028FE")]
	[Address(RVA = "0x1AA2828", Offset = "0x1AA2828", VA = "0x1AA2828")]
	private void CamaraZoomInOut()
	{
	}
}
