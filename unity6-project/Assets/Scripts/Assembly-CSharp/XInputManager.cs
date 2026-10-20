using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006C9")]
public class XInputManager : MonoSingleton<XInputManager>
{
	[Token(Token = "0x400205D")]
	[FieldOffset(Offset = "0xC")]
	private List<XModuleMyControl> m_actorRecievers;

	[Token(Token = "0x400205E")]
	[FieldOffset(Offset = "0x10")]
	private XGameManager m_gameManager;

	[Token(Token = "0x400205F")]
	[FieldOffset(Offset = "0x14")]
	private IVirtualStick m_virtualStick;

	[Token(Token = "0x4002060")]
	[FieldOffset(Offset = "0x18")]
	private bool m_enable;

	[Token(Token = "0x4002061")]
	[FieldOffset(Offset = "0x19")]
	private bool isInputGamepad;

	[Token(Token = "0x4002062")]
	[FieldOffset(Offset = "0x1C")]
	private XKeyEnum m_permitOnlyInput;

	[Token(Token = "0x4002063")]
	[FieldOffset(Offset = "0x20")]
	private Action<XKeyEnum> m_onInput;

	[Token(Token = "0x4002064")]
	[FieldOffset(Offset = "0x24")]
	private Action m_m_skillPressedDown;

	[Token(Token = "0x17000814")]
	public XKeyEnum PermitOnlyInput
	{
		[Token(Token = "0x60038F5")]
		[Address(RVA = "0x1D2AE2C", Offset = "0x1D2AE2C", VA = "0x1D2AE2C")]
		get
		{
			return default(XKeyEnum);
		}
		[Token(Token = "0x60038F6")]
		[Address(RVA = "0x1D2AE34", Offset = "0x1D2AE34", VA = "0x1D2AE34")]
		private set
		{
		}
	}

	[Token(Token = "0x1400005E")]
	private event Action m_skillPressedDown
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[Token(Token = "0x60038CC")]
		[Address(RVA = "0x1D28D18", Offset = "0x1D28D18", VA = "0x1D28D18")]
		add
		{
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[Token(Token = "0x60038CD")]
		[Address(RVA = "0x1D28EA4", Offset = "0x1D28EA4", VA = "0x1D28EA4")]
		remove
		{
		}
	}

	[Token(Token = "0x60038CB")]
	[Address(RVA = "0x1D28C18", Offset = "0x1D28C18", VA = "0x1D28C18")]
	public XInputManager()
	{
	}

	[Token(Token = "0x60038CE")]
	[Address(RVA = "0x1D29030", Offset = "0x1D29030", VA = "0x1D29030", Slot = "5")]
	public override void Init()
	{
	}

	[Token(Token = "0x60038CF")]
	[Address(RVA = "0x1D290B4", Offset = "0x1D290B4", VA = "0x1D290B4")]
	public void RegisterReciever(XModuleMyControl reciever)
	{
	}

	[Token(Token = "0x60038D0")]
	[Address(RVA = "0x1D2918C", Offset = "0x1D2918C", VA = "0x1D2918C")]
	public void DeregisterReciever(XModuleMyControl reciever)
	{
	}

	[Token(Token = "0x60038D1")]
	[Address(RVA = "0x1D29264", Offset = "0x1D29264", VA = "0x1D29264")]
	public void RegisterOnSkillPressed(Action onSkillPressed)
	{
	}

	[Token(Token = "0x60038D2")]
	[Address(RVA = "0x1D29500", Offset = "0x1D29500", VA = "0x1D29500")]
	public void RegisterGameManager(XGameManager gamemanager)
	{
	}

	[Token(Token = "0x60038D3")]
	[Address(RVA = "0x1D29508", Offset = "0x1D29508", VA = "0x1D29508")]
	public void RegisterVirtualStick(IVirtualStick virtualStick)
	{
	}

	[Token(Token = "0x60038D4")]
	[Address(RVA = "0x1D29510", Offset = "0x1D29510", VA = "0x1D29510")]
	public void DeregisterVirtualStick()
	{
	}

	[Token(Token = "0x60038D5")]
	[Address(RVA = "0x1D2951C", Offset = "0x1D2951C", VA = "0x1D2951C")]
	public void ClearRecievers()
	{
	}

	[Token(Token = "0x60038D6")]
	[Address(RVA = "0x1D295CC", Offset = "0x1D295CC", VA = "0x1D295CC")]
	private void ClearMove()
	{
	}

	[Token(Token = "0x60038D7")]
	[Address(RVA = "0x1D296CC", Offset = "0x1D296CC", VA = "0x1D296CC")]
	public void ClearGameManager()
	{
	}

	[Token(Token = "0x60038D8")]
	[Address(RVA = "0x1D296D8", Offset = "0x1D296D8", VA = "0x1D296D8")]
	public void Clear()
	{
	}

	[Token(Token = "0x60038D9")]
	[Address(RVA = "0x1D29700", Offset = "0x1D29700", VA = "0x1D29700")]
	public void Enable()
	{
	}

	[Token(Token = "0x60038DA")]
	[Address(RVA = "0x1D2970C", Offset = "0x1D2970C", VA = "0x1D2970C")]
	public void Disable()
	{
	}

	[Token(Token = "0x60038DB")]
	[Address(RVA = "0x1D29718", Offset = "0x1D29718", VA = "0x1D29718")]
	private void GamepadInputProcess()
	{
	}

	[Token(Token = "0x60038DC")]
	[Address(RVA = "0x1D298E0", Offset = "0x1D298E0", VA = "0x1D298E0")]
	private void KeyBoardInputProcess()
	{
	}

	[Token(Token = "0x60038DD")]
	[Address(RVA = "0x1D299D0", Offset = "0x1D299D0", VA = "0x1D299D0")]
	private void Update()
	{
	}

	[Token(Token = "0x60038DE")]
	[Address(RVA = "0x1D29A64", Offset = "0x1D29A64", VA = "0x1D29A64")]
	private bool HandleVirtualStick()
	{
		return default(bool);
	}

	[Token(Token = "0x60038DF")]
	[Address(RVA = "0x1D2A1F0", Offset = "0x1D2A1F0", VA = "0x1D2A1F0")]
	public void SendTagInput(XKeyEnum key)
	{
	}

	[Token(Token = "0x60038E0")]
	[Address(RVA = "0x1D2A2C4", Offset = "0x1D2A2C4", VA = "0x1D2A2C4")]
	public bool CheckGameModeKeyInput(XKeyEnum key)
	{
		return default(bool);
	}

	[Token(Token = "0x60038E1")]
	[Address(RVA = "0x1D2A38C", Offset = "0x1D2A38C", VA = "0x1D2A38C")]
	private bool CheckGameModeTag1KeyInput()
	{
		return default(bool);
	}

	[Token(Token = "0x60038E2")]
	[Address(RVA = "0x1D2A5A8", Offset = "0x1D2A5A8", VA = "0x1D2A5A8")]
	public void SendCharacterSkillInput(XKeyEnum key, bool byAuto)
	{
	}

	[Token(Token = "0x60038E3")]
	[Address(RVA = "0x1D2A6F4", Offset = "0x1D2A6F4", VA = "0x1D2A6F4")]
	public void SendRelicSkillInput(XKeyEnum key, bool byAuto)
	{
	}

	[Token(Token = "0x60038E4")]
	[Address(RVA = "0x1D2A058", Offset = "0x1D2A058", VA = "0x1D2A058")]
	private void SendTiltStick(Vector3 dir)
	{
	}

	[Token(Token = "0x60038E5")]
	[Address(RVA = "0x1D29908", Offset = "0x1D29908", VA = "0x1D29908")]
	private void HandleKeyboardSkillInput()
	{
	}

	[Token(Token = "0x60038E6")]
	[Address(RVA = "0x1D29994", Offset = "0x1D29994", VA = "0x1D29994")]
	private void HandleKeaboardTagInput()
	{
	}

	[Token(Token = "0x60038E7")]
	[Address(RVA = "0x1D2A8E8", Offset = "0x1D2A8E8", VA = "0x1D2A8E8")]
	private void HandleKeaboardTagInput(KeyCode code, XKeyEnum key)
	{
	}

	[Token(Token = "0x60038E8")]
	[Address(RVA = "0x1D2A840", Offset = "0x1D2A840", VA = "0x1D2A840")]
	private void HandleKeaboardSkillInputOnPressDown(KeyCode code, XKeyEnum key)
	{
	}

	[Token(Token = "0x60038E9")]
	[Address(RVA = "0x1D2A878", Offset = "0x1D2A878", VA = "0x1D2A878")]
	private void HandleKeaboardSkillInputOnPress(KeyCode code, XKeyEnum key)
	{
	}

	[Token(Token = "0x60038EA")]
	[Address(RVA = "0x1D2A8B0", Offset = "0x1D2A8B0", VA = "0x1D2A8B0")]
	private void HandleKeaboardRelicSkillInputOnPressDown(KeyCode code, XKeyEnum key)
	{
	}

	[Token(Token = "0x60038EB")]
	[Address(RVA = "0x1D29E34", Offset = "0x1D29E34", VA = "0x1D29E34")]
	private bool HandleKeyboardMoveInput()
	{
		return default(bool);
	}

	[Token(Token = "0x60038EC")]
	[Address(RVA = "0x1D2A9AC", Offset = "0x1D2A9AC", VA = "0x1D2A9AC")]
	private Vector3 HandleKeaboardMoveInput(KeyCode code, Vector3 dir)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60038ED")]
	[Address(RVA = "0x1D29740", Offset = "0x1D29740", VA = "0x1D29740")]
	private void HandleGamepadSkillInput()
	{
	}

	[Token(Token = "0x60038EE")]
	[Address(RVA = "0x1D29858", Offset = "0x1D29858", VA = "0x1D29858")]
	private void HandleGamepadTagInput()
	{
	}

	[Token(Token = "0x60038EF")]
	[Address(RVA = "0x1D29C94", Offset = "0x1D29C94", VA = "0x1D29C94")]
	private bool HandleGamepadMoveInput()
	{
		return default(bool);
	}

	[Token(Token = "0x60038F0")]
	[Address(RVA = "0x1D2AA00", Offset = "0x1D2AA00", VA = "0x1D2AA00")]
	private void HandleGamepadSkillInputOnPressDown(string buttonNum, XKeyEnum key)
	{
	}

	[Token(Token = "0x60038F1")]
	[Address(RVA = "0x1D2AAD0", Offset = "0x1D2AAD0", VA = "0x1D2AAD0")]
	private void HandleGamepadSkillInputOnPress(string buttonNum, XKeyEnum key)
	{
	}

	[Token(Token = "0x60038F2")]
	[Address(RVA = "0x1D2AD60", Offset = "0x1D2AD60", VA = "0x1D2AD60")]
	private void HandleGamepadTagInput(string buttonNum, XKeyEnum key)
	{
	}

	[Token(Token = "0x60038F3")]
	[Address(RVA = "0x1D2ABA0", Offset = "0x1D2ABA0", VA = "0x1D2ABA0")]
	private void HandleGamepadUltimateSkillInputOnPressDown()
	{
	}

	[Token(Token = "0x60038F4")]
	[Address(RVA = "0x1D2AC80", Offset = "0x1D2AC80", VA = "0x1D2AC80")]
	private void HandleGamepadRelicSkillInputOnPressDown()
	{
	}

	[Token(Token = "0x60038F7")]
	[Address(RVA = "0x1D2AE3C", Offset = "0x1D2AE3C", VA = "0x1D2AE3C")]
	public void SetUseOnlyOneInput(XKeyEnum useInput)
	{
	}

	[Token(Token = "0x60038F8")]
	[Address(RVA = "0x1D2A294", Offset = "0x1D2A294", VA = "0x1D2A294")]
	private bool IsAvailable(XKeyEnum checkInput)
	{
		return default(bool);
	}

	[Token(Token = "0x60038F9")]
	[Address(RVA = "0x1D2AE44", Offset = "0x1D2AE44", VA = "0x1D2AE44")]
	public void RegisterOnInput(Action<XKeyEnum> onInput)
	{
	}

	[Token(Token = "0x60038FA")]
	[Address(RVA = "0x1D296C0", Offset = "0x1D296C0", VA = "0x1D296C0")]
	public void ClearOnInput()
	{
	}

	[Token(Token = "0x60038FB")]
	[Address(RVA = "0x1D2A2DC", Offset = "0x1D2A2DC", VA = "0x1D2A2DC")]
	private void OnInput(XKeyEnum key)
	{
	}
}
