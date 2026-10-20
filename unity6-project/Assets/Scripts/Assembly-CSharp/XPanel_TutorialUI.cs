using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C04")]
public class XPanel_TutorialUI : MonoBehaviour
{
	[Token(Token = "0x2000C05")]
	private sealed class _003C_ShowUI_003Ec__Iterator93 : IDisposable
	{
		[Token(Token = "0x4003CDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal TutorialDataBase scriptData;

		[Token(Token = "0x4003CDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal TutorialDialogData _003Cdata_003E__0;

		[Token(Token = "0x4003CDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal TutorialDialogData _003Cdata_003E__1;

		[Token(Token = "0x4003CE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal bool _003CchangeSnapShot_003E__2;

		[Token(Token = "0x4003CE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal TutorialDialogAndHighlight _003Cdata_003E__3;

		[Token(Token = "0x4003CE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal TutorialHighlightData _003Cdata_003E__4;

		[Token(Token = "0x4003CE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal TutorialNotificationData _003Cdata_003E__5;

		[Token(Token = "0x4003CE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal TutorialPressNotificationData _003Cdata_003E__6;

		[Token(Token = "0x4003CE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal TutorialExplainData _003Cdata_003E__7;

		[Token(Token = "0x4003CE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal Action addedAction;

		[Token(Token = "0x4003CE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal TutorialHighlightData _003Cdata_003E__8;

		[Token(Token = "0x4003CE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal int _0024PC;

		[Token(Token = "0x4003CE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal object _0024current;

		[Token(Token = "0x4003CEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal TutorialDataBase _003C_0024_003EscriptData;

		[Token(Token = "0x4003CEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal Action _003C_0024_003EaddedAction;

		[Token(Token = "0x4003CEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		internal XPanel_TutorialUI _003C_003Ef__this;

		[Token(Token = "0x17000C9C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6005708")]
			[Address(RVA = "0xAD85CC", Offset = "0xAD85CC", VA = "0xAD85CC", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000C9D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005709")]
			[Address(RVA = "0xAD85D4", Offset = "0xAD85D4", VA = "0xAD85D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6005707")]
		[Address(RVA = "0xAD6D24", Offset = "0xAD6D24", VA = "0xAD6D24")]
		public _003C_ShowUI_003Ec__Iterator93()
		{
		}

		[Token(Token = "0x6005708")]
		[Address(RVA = "0xAD85CC", Offset = "0xAD85CC", VA = "0xAD85CC", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6005709")]
		[Address(RVA = "0xAD85D4", Offset = "0xAD85D4", VA = "0xAD85D4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600570A")]
		[Address(RVA = "0xAD85DC", Offset = "0xAD85DC", VA = "0xAD85DC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600570B")]
		[Address(RVA = "0xAD9058", Offset = "0xAD9058", VA = "0xAD9058", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600570C")]
		[Address(RVA = "0xAD9064", Offset = "0xAD9064", VA = "0xAD9064", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		[Token(Token = "0x600570D")]
		[Address(RVA = "0xAD90F8", Offset = "0xAD90F8", VA = "0xAD90F8")]
		internal void _003C_003Em__235()
		{
		}
	}

	[Token(Token = "0x2000C06")]
	private sealed class _003CStartFadeInOut_003Ec__AnonStorey168
	{
		[Token(Token = "0x4003CED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action fadeOutFinishAction;

		[Token(Token = "0x4003CEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XKeyEnum prevInput;

		[Token(Token = "0x600570E")]
		[Address(RVA = "0xAD78A0", Offset = "0xAD78A0", VA = "0xAD78A0")]
		public _003CStartFadeInOut_003Ec__AnonStorey168()
		{
		}

		[Token(Token = "0x600570F")]
		[Address(RVA = "0xAD9374", Offset = "0xAD9374", VA = "0xAD9374")]
		internal void _003C_003Em__231()
		{
		}
	}

	[Token(Token = "0x2000C07")]
	private sealed class _003CStartFadeIn_003Ec__AnonStorey169
	{
		[Token(Token = "0x4003CEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action fadeInFinishAction;

		[Token(Token = "0x4003CF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XKeyEnum prevInput;

		[Token(Token = "0x6005710")]
		[Address(RVA = "0xAD7A4C", Offset = "0xAD7A4C", VA = "0xAD7A4C")]
		public _003CStartFadeIn_003Ec__AnonStorey169()
		{
		}

		[Token(Token = "0x6005711")]
		[Address(RVA = "0xAD9284", Offset = "0xAD9284", VA = "0xAD9284")]
		internal void _003C_003Em__232()
		{
		}
	}

	[Token(Token = "0x2000C08")]
	private sealed class _003CStartFadeOut_003Ec__AnonStorey16A
	{
		[Token(Token = "0x4003CF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action fadeOutFinishAction;

		[Token(Token = "0x4003CF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XKeyEnum prevInput;

		[Token(Token = "0x6005712")]
		[Address(RVA = "0xAD7BFC", Offset = "0xAD7BFC", VA = "0xAD7BFC")]
		public _003CStartFadeOut_003Ec__AnonStorey16A()
		{
		}

		[Token(Token = "0x6005713")]
		[Address(RVA = "0xAD9464", Offset = "0xAD9464", VA = "0xAD9464")]
		internal void _003C_003Em__233()
		{
		}
	}

	[Token(Token = "0x2000C09")]
	private sealed class _003CShowRecruitPanel_003Ec__AnonStorey16B
	{
		[Token(Token = "0x4003CF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Action addedAction;

		[Token(Token = "0x4003CF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XPanel_TutorialUI _003C_003Ef__this;

		[Token(Token = "0x6005714")]
		[Address(RVA = "0xAD7E80", Offset = "0xAD7E80", VA = "0xAD7E80")]
		public _003CShowRecruitPanel_003Ec__AnonStorey16B()
		{
		}

		[Token(Token = "0x6005715")]
		[Address(RVA = "0xAD9234", Offset = "0xAD9234", VA = "0xAD9234")]
		internal void _003C_003Em__234()
		{
		}
	}

	[Token(Token = "0x4003CC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public GameObject goInputDisable;

	[Token(Token = "0x4003CC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public XUIMessageBox skipMessageBox;

	[Token(Token = "0x4003CC2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public XTutorialObjContainer tutoObjContainer;

	[Token(Token = "0x4003CC3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UIWidget widgetVirtualKey;

	[Token(Token = "0x4003CC4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public UIWidget widgetVirtualKeyRoot;

	[Token(Token = "0x4003CC5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UI2DSprite sprArenaBG1;

	[Token(Token = "0x4003CC6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UI2DSprite sprArenaBG2;

	[Token(Token = "0x4003CC7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public XWidget_Button btnSkip;

	[Token(Token = "0x4003CC8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public XWidget_TutorialDialog tutorialDialog;

	[Token(Token = "0x4003CC9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public XWidget_TutorialHighlight tutorialHighlight;

	[Token(Token = "0x4003CCA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public XWidget_TutorialNotification tutorialNoti;

	[Token(Token = "0x4003CCB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public XWidget_TutorialPressNotification tutorialPressNoti;

	[Token(Token = "0x4003CCC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public XWidget_TutorialExplain tutorialExplain;

	[Token(Token = "0x4003CCD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public XWidget_TutorialStart tutorialStart;

	[Token(Token = "0x4003CCE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public XWidget_TutorialRewardUp tutoRewardUp;

	[Token(Token = "0x4003CCF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public XWidget_AccumulateTutorialReward tutoReward;

	[Token(Token = "0x4003CD0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public GameObject goSkipBtns;

	[Token(Token = "0x4003CD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public XWidget_FadeInOut fadeInOut;

	[Token(Token = "0x4003CD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public XPanel_CharRecruit recruitPanel;

	[Token(Token = "0x4003CD3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject goMsgRoot;

	[Token(Token = "0x4003CD4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public UILabel lblMsg;

	[Token(Token = "0x4003CD5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float m_msgNotiTime;

	[Token(Token = "0x4003CD6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float m_elaspedTime;

	[Token(Token = "0x4003CD7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool m_reserveHideMsg;

	[Token(Token = "0x4003CD8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	private bool isPreviousPlayVoice;

	[Token(Token = "0x4003CD9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Action m_nextCallBack;

	[Token(Token = "0x4003CDA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Action m_tutoEndAction;

	[Token(Token = "0x4003CDB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private string m_playSoundName;

	[Token(Token = "0x4003CDC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string m_playSnapShotName;

	[Token(Token = "0x60056E8")]
	[Address(RVA = "0xAD6550", Offset = "0xAD6550", VA = "0xAD6550")]
	public XPanel_TutorialUI()
	{
	}

	[Token(Token = "0x60056E9")]
	[Address(RVA = "0xAD6640", Offset = "0xAD6640", VA = "0xAD6640")]
	public void DestroyDynamicLoadPrefab()
	{
	}

	[Token(Token = "0x60056EA")]
	[Address(RVA = "0xAD6890", Offset = "0xAD6890", VA = "0xAD6890")]
	public void Build(Action nextCallBack, Action skipCallBack, Action tutoEndAction, int startCrystal = 0)
	{
	}

	[Token(Token = "0x60056EB")]
	[Address(RVA = "0xAD6ACC", Offset = "0xAD6ACC", VA = "0xAD6ACC")]
	public void ReserveMsgHide()
	{
	}

	[Token(Token = "0x60056EC")]
	[Address(RVA = "0xAD6B1C", Offset = "0xAD6B1C", VA = "0xAD6B1C")]
	public void CallNextTuto()
	{
	}

	[Token(Token = "0x60056ED")]
	[Address(RVA = "0xAD6B68", Offset = "0xAD6B68", VA = "0xAD6B68")]
	private void Update()
	{
	}

	[Token(Token = "0x60056EE")]
	[Address(RVA = "0xAD6BD0", Offset = "0xAD6BD0", VA = "0xAD6BD0")]
	public void SetSkipable(bool skipable)
	{
	}

	[Token(Token = "0x60056EF")]
	[Address(RVA = "0xAD6BFC", Offset = "0xAD6BFC", VA = "0xAD6BFC")]
	public void ShowUI(TutorialDataBase scriptData, [Optional] Action addedAction)
	{
	}

	[Token(Token = "0x60056F0")]
	[Address(RVA = "0xAD6C68", Offset = "0xAD6C68", VA = "0xAD6C68")]
	[DebuggerHidden]
	public IEnumerator _ShowUI(TutorialDataBase scriptData, [Optional] Action addedAction)
	{
		return null;
	}

	[Token(Token = "0x60056F1")]
	[Address(RVA = "0xAD6D2C", Offset = "0xAD6D2C", VA = "0xAD6D2C")]
	public bool PlayVoiceAndCheckChangeSnapShot(TutorialDialogData data)
	{
		return default(bool);
	}

	[Token(Token = "0x60056F2")]
	[Address(RVA = "0xAD7064", Offset = "0xAD7064", VA = "0xAD7064")]
	private void TutorialDialogOn()
	{
	}

	[Token(Token = "0x60056F3")]
	[Address(RVA = "0xAD717C", Offset = "0xAD717C", VA = "0xAD717C")]
	private void PlaySound()
	{
	}

	[Token(Token = "0x60056F4")]
	[Address(RVA = "0xAD7250", Offset = "0xAD7250", VA = "0xAD7250")]
	public void SetPlaySnapShotName(string snapShotName)
	{
	}

	[Token(Token = "0x60056F5")]
	[Address(RVA = "0xAD7258", Offset = "0xAD7258", VA = "0xAD7258")]
	public void CheckAndChageSnapShotStart(TutorialDataBase data)
	{
	}

	[Token(Token = "0x60056F6")]
	[Address(RVA = "0xAD7364", Offset = "0xAD7364", VA = "0xAD7364")]
	public void Show()
	{
	}

	[Token(Token = "0x60056F7")]
	[Address(RVA = "0xAD6C3C", Offset = "0xAD6C3C", VA = "0xAD6C3C")]
	public void SetActiveInputDisable(bool isShow)
	{
	}

	[Token(Token = "0x60056F8")]
	[Address(RVA = "0xAD7398", Offset = "0xAD7398", VA = "0xAD7398")]
	private void ShowMsg(string text)
	{
	}

	[Token(Token = "0x60056F9")]
	[Address(RVA = "0xAD6AEC", Offset = "0xAD6AEC", VA = "0xAD6AEC")]
	public void HideMsg()
	{
	}

	[Token(Token = "0x60056FA")]
	[Address(RVA = "0xAD6A8C", Offset = "0xAD6A8C", VA = "0xAD6A8C")]
	public void SetActiveTutoReward(bool isActive)
	{
	}

	[Token(Token = "0x60056FB")]
	[Address(RVA = "0xAD7490", Offset = "0xAD7490", VA = "0xAD7490")]
	public void HideAll()
	{
	}

	[Token(Token = "0x60056FC")]
	[Address(RVA = "0xAD76D0", Offset = "0xAD76D0", VA = "0xAD76D0")]
	public void SetFadeInOutDuration(float fadeInDuration, float fadeOutDuration)
	{
	}

	[Token(Token = "0x60056FD")]
	[Address(RVA = "0xAD76FC", Offset = "0xAD76FC", VA = "0xAD76FC")]
	public void StartFadeInOut(Action fadeOutFinishAction)
	{
	}

	[Token(Token = "0x60056FE")]
	[Address(RVA = "0xAD78A8", Offset = "0xAD78A8", VA = "0xAD78A8")]
	public void StartFadeIn(Action fadeInFinishAction)
	{
	}

	[Token(Token = "0x60056FF")]
	[Address(RVA = "0xAD7A54", Offset = "0xAD7A54", VA = "0xAD7A54")]
	public void StartFadeOut(Action fadeOutFinishAction)
	{
	}

	[Token(Token = "0x6005700")]
	[Address(RVA = "0xAD7C04", Offset = "0xAD7C04", VA = "0xAD7C04")]
	public void ShowRecruitPanel([Optional][DefaultParameterValue(true)] bool isShow, [Optional] Action addedAction)
	{
	}

	[Token(Token = "0x6005701")]
	[Address(RVA = "0xAD7E88", Offset = "0xAD7E88", VA = "0xAD7E88")]
	public void CallNextTutorial()
	{
	}

	[Token(Token = "0x6005702")]
	[Address(RVA = "0xAD7E9C", Offset = "0xAD7E9C", VA = "0xAD7E9C")]
	public void ShowBG(string path)
	{
	}

	[Token(Token = "0x6005703")]
	[Address(RVA = "0xAD8080", Offset = "0xAD8080", VA = "0xAD8080")]
	public void HideBG()
	{
	}

	[Token(Token = "0x6005704")]
	[Address(RVA = "0xAD8424", Offset = "0xAD8424", VA = "0xAD8424")]
	public void SetVirtualStickAnchor()
	{
	}

	[Token(Token = "0x6005705")]
	[Address(RVA = "0xAD85A4", Offset = "0xAD85A4", VA = "0xAD85A4")]
	public void OnClick_ContinueTutorial()
	{
	}

	[Token(Token = "0x6005706")]
	[Address(RVA = "0xAD85B8", Offset = "0xAD85B8", VA = "0xAD85B8")]
	public void OnClick_EndTutorial()
	{
	}
}
