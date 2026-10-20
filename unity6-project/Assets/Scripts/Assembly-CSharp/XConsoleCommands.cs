using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000604")]
public class XConsoleCommands
{
	[Token(Token = "0x2000605")]
	private sealed class _003CCoroutineRoomClose_003Ec__Iterator71 : IDisposable
	{
		[Token(Token = "0x4001CD9")]
		[FieldOffset(Offset = "0x8")]
		internal float fDelayTime;

		[Token(Token = "0x4001CDA")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x4001CDB")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4001CDC")]
		[FieldOffset(Offset = "0x14")]
		internal float _003C_0024_003EfDelayTime;

		[Token(Token = "0x170007A5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60033E8")]
			[Address(RVA = "0x199EB30", Offset = "0x199EB30", VA = "0x199EB30", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170007A6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60033E9")]
			[Address(RVA = "0x199EB38", Offset = "0x199EB38", VA = "0x199EB38", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60033E7")]
		[Address(RVA = "0x19954F0", Offset = "0x19954F0", VA = "0x19954F0")]
		public _003CCoroutineRoomClose_003Ec__Iterator71()
		{
		}

		[Token(Token = "0x60033E8")]
		[Address(RVA = "0x199EB30", Offset = "0x199EB30", VA = "0x199EB30", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60033E9")]
		[Address(RVA = "0x199EB38", Offset = "0x199EB38", VA = "0x199EB38", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60033EA")]
		[Address(RVA = "0x199EB40", Offset = "0x199EB40", VA = "0x199EB40", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60033EB")]
		[Address(RVA = "0x199EDF8", Offset = "0x199EDF8", VA = "0x199EDF8", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60033EC")]
		[Address(RVA = "0x199EE04", Offset = "0x199EE04", VA = "0x199EE04", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000606")]
	private sealed class _003COnDumpActors_003Ec__AnonStorey126
	{
		[Token(Token = "0x4001CDD")]
		[FieldOffset(Offset = "0x8")]
		internal StringBuilder sb;

		[Token(Token = "0x60033ED")]
		[Address(RVA = "0x1994198", Offset = "0x1994198", VA = "0x1994198")]
		public _003COnDumpActors_003Ec__AnonStorey126()
		{
		}

		[Token(Token = "0x60033EE")]
		[Address(RVA = "0x199EE98", Offset = "0x199EE98", VA = "0x199EE98")]
		internal void _003C_003Em__162(XModuleEntity e)
		{
		}

		[Token(Token = "0x60033EF")]
		[Address(RVA = "0x199EEA0", Offset = "0x199EEA0", VA = "0x199EEA0")]
		internal void _003C_003Em__163(XModuleEntity e)
		{
		}
	}

	[Token(Token = "0x4001CD7")]
	[FieldOffset(Offset = "0x0")]
	private static string LastErrorMessage__BackingField;

	[Token(Token = "0x4001CD8")]
	[FieldOffset(Offset = "0x4")]
	private static NetCallback _003C_003Ef__am_0024cache1;

	[Token(Token = "0x170007A4")]
	public static string LastErrorMessage
	{
		[Token(Token = "0x60033AF")]
		[Address(RVA = "0x199446C", Offset = "0x199446C", VA = "0x199446C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60033B0")]
		[Address(RVA = "0x19944EC", Offset = "0x19944EC", VA = "0x19944EC")]
		set
		{
		}
	}

	[Token(Token = "0x600336D")]
	[Address(RVA = "0x198A630", Offset = "0x198A630", VA = "0x198A630")]
	public XConsoleCommands()
	{
	}

	[Token(Token = "0x600336E")]
	[Address(RVA = "0x198A638", Offset = "0x198A638", VA = "0x198A638")]
	public static string OnDebugResisterLocalPush(string param)
	{
		return null;
	}

	[Token(Token = "0x600336F")]
	[Address(RVA = "0x198A7F8", Offset = "0x198A7F8", VA = "0x198A7F8")]
	public static string OnDebugCancelLocalPush(string param)
	{
		return null;
	}

	[Token(Token = "0x6003370")]
	[Address(RVA = "0x198A964", Offset = "0x198A964", VA = "0x198A964")]
	public static string OnDebug(string param)
	{
		return null;
	}

	[Token(Token = "0x6003371")]
	[Address(RVA = "0x198AC48", Offset = "0x198AC48", VA = "0x198AC48")]
	private static void LogToGConsole(string condition, string stackTrace, LogType type)
	{
	}

	[Token(Token = "0x6003372")]
	[Address(RVA = "0x198ACF0", Offset = "0x198ACF0", VA = "0x198ACF0")]
	public static void AddGConsoleLog(bool val)
	{
	}

	[Token(Token = "0x6003373")]
	[Address(RVA = "0x198ADF0", Offset = "0x198ADF0", VA = "0x198ADF0")]
	public static string OnDebugGConsole(string param)
	{
		return null;
	}

	[Token(Token = "0x6003374")]
	[Address(RVA = "0x198AFF8", Offset = "0x198AFF8", VA = "0x198AFF8")]
	public static string OnGCCollect(string param)
	{
		return null;
	}

	[Token(Token = "0x6003375")]
	[Address(RVA = "0x198B188", Offset = "0x198B188", VA = "0x198B188")]
	public static string OnUnload(string param)
	{
		return null;
	}

	[Token(Token = "0x6003376")]
	[Address(RVA = "0x198B354", Offset = "0x198B354", VA = "0x198B354")]
	public static string OnSpawnAIChar(string param)
	{
		return null;
	}

	[Token(Token = "0x6003377")]
	[Address(RVA = "0x198B588", Offset = "0x198B588", VA = "0x198B588")]
	public static string OnShowFPS(string param)
	{
		return null;
	}

	[Token(Token = "0x6003378")]
	[Address(RVA = "0x198B7E4", Offset = "0x198B7E4", VA = "0x198B7E4")]
	public static string OnHideMessage(string param)
	{
		return null;
	}

	[Token(Token = "0x6003379")]
	[Address(RVA = "0x198B9A4", Offset = "0x198B9A4", VA = "0x198B9A4")]
	public static string OnPollingProcess(string param)
	{
		return null;
	}

	[Token(Token = "0x600337A")]
	[Address(RVA = "0x198BB40", Offset = "0x198BB40", VA = "0x198BB40")]
	public static string OnLogFPS(string param)
	{
		return null;
	}

	[Token(Token = "0x600337B")]
	[Address(RVA = "0x198BD00", Offset = "0x198BD00", VA = "0x198BD00")]
	public static string OnShowName(string param)
	{
		return null;
	}

	[Token(Token = "0x600337C")]
	[Address(RVA = "0x198BEC0", Offset = "0x198BEC0", VA = "0x198BEC0")]
	public static string OnShowPhotonInfo(string param)
	{
		return null;
	}

	[Token(Token = "0x600337D")]
	[Address(RVA = "0x198C3D0", Offset = "0x198C3D0", VA = "0x198C3D0")]
	public static string OnShowGameProcessingFlag(string param)
	{
		return null;
	}

	[Token(Token = "0x600337E")]
	[Address(RVA = "0x198C5D0", Offset = "0x198C5D0", VA = "0x198C5D0")]
	public static string OnShowDummyLoc(string param)
	{
		return null;
	}

	[Token(Token = "0x600337F")]
	[Address(RVA = "0x198C790", Offset = "0x198C790", VA = "0x198C790")]
	public static string OnShowCharInterface(string param)
	{
		return null;
	}

	[Token(Token = "0x6003380")]
	[Address(RVA = "0x198CA30", Offset = "0x198CA30", VA = "0x198CA30")]
	public static string OnShowCharacterId(string param)
	{
		return null;
	}

	[Token(Token = "0x6003381")]
	[Address(RVA = "0x198CBF0", Offset = "0x198CBF0", VA = "0x198CBF0")]
	public static string OnLoadLocalXML(string param)
	{
		return null;
	}

	[Token(Token = "0x6003382")]
	[Address(RVA = "0x198D508", Offset = "0x198D508", VA = "0x198D508")]
	public static string OnSetMovie(string param)
	{
		return null;
	}

	[Token(Token = "0x6003383")]
	[Address(RVA = "0x198D6C8", Offset = "0x198D6C8", VA = "0x198D6C8")]
	public static string OnSetLocalData(string param)
	{
		return null;
	}

	[Token(Token = "0x6003384")]
	[Address(RVA = "0x198D888", Offset = "0x198D888", VA = "0x198D888")]
	public static string OnGod(string param)
	{
		return null;
	}

	[Token(Token = "0x6003385")]
	[Address(RVA = "0x198DB88", Offset = "0x198DB88", VA = "0x198DB88")]
	public static string OnChangeToDeveloperMode(string param)
	{
		return null;
	}

	[Token(Token = "0x6003386")]
	[Address(RVA = "0x198DD58", Offset = "0x198DD58", VA = "0x198DD58")]
	public static string OnChangeToDevLoginMode(string param)
	{
		return null;
	}

	[Token(Token = "0x6003387")]
	[Address(RVA = "0x198DF18", Offset = "0x198DF18", VA = "0x198DF18")]
	public static string OnDie(string param)
	{
		return null;
	}

	[Token(Token = "0x6003388")]
	[Address(RVA = "0x198E0AC", Offset = "0x198E0AC", VA = "0x198E0AC")]
	public static string OnSetHP(string param)
	{
		return null;
	}

	[Token(Token = "0x6003389")]
	[Address(RVA = "0x198E3C0", Offset = "0x198E3C0", VA = "0x198E3C0")]
	public static string CreateParty(string param)
	{
		return null;
	}

	[Token(Token = "0x600338A")]
	[Address(RVA = "0x198E70C", Offset = "0x198E70C", VA = "0x198E70C")]
	public static string InviteFriendToGame(string param)
	{
		return null;
	}

	[Token(Token = "0x600338B")]
	[Address(RVA = "0x198EB60", Offset = "0x198EB60", VA = "0x198EB60")]
	public static string StartPartyGame(string param)
	{
		return null;
	}

	[Token(Token = "0x600338C")]
	[Address(RVA = "0x198EF74", Offset = "0x198EF74", VA = "0x198EF74")]
	public static string SetRegionServerKey(string param)
	{
		return null;
	}

	[Token(Token = "0x600338D")]
	[Address(RVA = "0x198F1EC", Offset = "0x198F1EC", VA = "0x198F1EC")]
	public static string ResetRegionServerKey(string param)
	{
		return null;
	}

	[Token(Token = "0x600338E")]
	[Address(RVA = "0x198F314", Offset = "0x198F314", VA = "0x198F314")]
	public static string TapjoySendPing(string param)
	{
		return null;
	}

	[Token(Token = "0x600338F")]
	[Address(RVA = "0x198F40C", Offset = "0x198F40C", VA = "0x198F40C")]
	internal static string SetMoveMotionSync(string param)
	{
		return null;
	}

	[Token(Token = "0x6003390")]
	[Address(RVA = "0x198F794", Offset = "0x198F794", VA = "0x198F794")]
	internal static string SetNexonAccount(string arg1)
	{
		return null;
	}

	[Token(Token = "0x6003391")]
	[Address(RVA = "0x198F954", Offset = "0x198F954", VA = "0x198F954")]
	internal static string SetSendRateOnSerialize(string param)
	{
		return null;
	}

	[Token(Token = "0x6003392")]
	[Address(RVA = "0x198FBF0", Offset = "0x198FBF0", VA = "0x198FBF0")]
	internal static string SetMoveSyncOption(string param)
	{
		return null;
	}

	[Token(Token = "0x6003393")]
	[Address(RVA = "0x1990220", Offset = "0x1990220", VA = "0x1990220")]
	internal static string SetSyncStart(string param)
	{
		return null;
	}

	[Token(Token = "0x6003394")]
	[Address(RVA = "0x1990558", Offset = "0x1990558", VA = "0x1990558")]
	internal static string SetSyncTurn(string param)
	{
		return null;
	}

	[Token(Token = "0x6003395")]
	[Address(RVA = "0x199080C", Offset = "0x199080C", VA = "0x199080C")]
	public static string GetClanWarPartyList(string param)
	{
		return null;
	}

	[Token(Token = "0x6003396")]
	[Address(RVA = "0x19909E0", Offset = "0x19909E0", VA = "0x19909E0")]
	public static string LoadChattingMessageFromServer(string param)
	{
		return null;
	}

	[Token(Token = "0x6003397")]
	[Address(RVA = "0x1990A58", Offset = "0x1990A58", VA = "0x1990A58")]
	public static string OnAddBuff(string param)
	{
		return null;
	}

	[Token(Token = "0x6003398")]
	[Address(RVA = "0x1990D9C", Offset = "0x1990D9C", VA = "0x1990D9C")]
	public static string OnDeleteBuff(string param)
	{
		return null;
	}

	[Token(Token = "0x6003399")]
	[Address(RVA = "0x19910A8", Offset = "0x19910A8", VA = "0x19910A8")]
	public static string OnGameSpawn(string param)
	{
		return null;
	}

	[Token(Token = "0x600339A")]
	[Address(RVA = "0x1991674", Offset = "0x1991674", VA = "0x1991674")]
	private static void SetTeam(XTeamEnum nTeam)
	{
	}

	[Token(Token = "0x600339B")]
	[Address(RVA = "0x19918C4", Offset = "0x19918C4", VA = "0x19918C4")]
	public static string OnSetATeam(string param)
	{
		return null;
	}

	[Token(Token = "0x600339C")]
	[Address(RVA = "0x19919A0", Offset = "0x19919A0", VA = "0x19919A0")]
	public static string OnSetBTeam(string param)
	{
		return null;
	}

	[Token(Token = "0x600339D")]
	[Address(RVA = "0x1991A7C", Offset = "0x1991A7C", VA = "0x1991A7C")]
	public static string OnShowUI(string param)
	{
		return null;
	}

	[Token(Token = "0x600339E")]
	[Address(RVA = "0x1991C88", Offset = "0x1991C88", VA = "0x1991C88")]
	public static string OnHideUI(string param)
	{
		return null;
	}

	[Token(Token = "0x600339F")]
	[Address(RVA = "0x1991E94", Offset = "0x1991E94", VA = "0x1991E94")]
	public static string OnDisableUltDirection(string param)
	{
		return null;
	}

	[Token(Token = "0x60033A0")]
	[Address(RVA = "0x19920B8", Offset = "0x19920B8", VA = "0x19920B8")]
	public static string Reconnect(string param)
	{
		return null;
	}

	[Token(Token = "0x60033A1")]
	[Address(RVA = "0x19921E4", Offset = "0x19921E4", VA = "0x19921E4")]
	public static string OnInputIDMode(string param)
	{
		return null;
	}

	[Token(Token = "0x60033A2")]
	[Address(RVA = "0x19924C4", Offset = "0x19924C4", VA = "0x19924C4")]
	public static string TouchEffect(string param)
	{
		return null;
	}

	[Token(Token = "0x60033A3")]
	[Address(RVA = "0x19926A0", Offset = "0x19926A0", VA = "0x19926A0")]
	public static string OnSetFPS(string param)
	{
		return null;
	}

	[Token(Token = "0x60033A4")]
	[Address(RVA = "0x1992A8C", Offset = "0x1992A8C", VA = "0x1992A8C")]
	public static string OnSetLocale(string param)
	{
		return null;
	}

	[Token(Token = "0x60033A5")]
	[Address(RVA = "0x1992E68", Offset = "0x1992E68", VA = "0x1992E68")]
	public static string OnSetCountry(string param)
	{
		return null;
	}

	[Token(Token = "0x60033A6")]
	[Address(RVA = "0x19931B4", Offset = "0x19931B4", VA = "0x19931B4")]
	public static string OnAIPlayer(string param)
	{
		return null;
	}

	[Token(Token = "0x60033A7")]
	[Address(RVA = "0x19934E8", Offset = "0x19934E8", VA = "0x19934E8")]
	public static string OnCheatClear(string param)
	{
		return null;
	}

	[Token(Token = "0x60033A8")]
	[Address(RVA = "0x1993914", Offset = "0x1993914", VA = "0x1993914")]
	public static string OnCheatKillAll(string param)
	{
		return null;
	}

	[Token(Token = "0x60033A9")]
	[Address(RVA = "0x1993A48", Offset = "0x1993A48", VA = "0x1993A48")]
	public static string OnCheatUlt(string param)
	{
		return null;
	}

	[Token(Token = "0x60033AA")]
	[Address(RVA = "0x1993CC0", Offset = "0x1993CC0", VA = "0x1993CC0")]
	public static string OnPauseForTest(string param)
	{
		return null;
	}

	[Token(Token = "0x60033AB")]
	[Address(RVA = "0x1993D68", Offset = "0x1993D68", VA = "0x1993D68")]
	public static string OnBirdTest(string param)
	{
		return null;
	}

	[Token(Token = "0x60033AC")]
	[Address(RVA = "0x1993D70", Offset = "0x1993D70", VA = "0x1993D70")]
	public static string OnDumpActors(string param)
	{
		return null;
	}

	[Token(Token = "0x60033AD")]
	[Address(RVA = "0x19941A0", Offset = "0x19941A0", VA = "0x19941A0")]
	public static string ShowMessageBox(string param)
	{
		return null;
	}

	[Token(Token = "0x60033AE")]
	[Address(RVA = "0x1994358", Offset = "0x1994358", VA = "0x1994358")]
	public static string UITouchDebug(string param)
	{
		return null;
	}

	[Token(Token = "0x60033B1")]
	[Address(RVA = "0x1994570", Offset = "0x1994570", VA = "0x1994570")]
	public static string ShowLastErrorCode(string param)
	{
		return null;
	}

	[Token(Token = "0x60033B2")]
	[Address(RVA = "0x1994790", Offset = "0x1994790", VA = "0x1994790")]
	public static string SetMinorVersion(string param)
	{
		return null;
	}

	[Token(Token = "0x60033B3")]
	[Address(RVA = "0x19949A4", Offset = "0x19949A4", VA = "0x19949A4")]
	public static string InitLocalData(string param)
	{
		return null;
	}

	[Token(Token = "0x60033B4")]
	[Address(RVA = "0x1994BCC", Offset = "0x1994BCC", VA = "0x1994BCC")]
	public static string InitGameEvalutate(string param)
	{
		return null;
	}

	[Token(Token = "0x60033B5")]
	[Address(RVA = "0x1994D20", Offset = "0x1994D20", VA = "0x1994D20")]
	private static void DumpActorInfo(XModuleEntity actors, StringBuilder sb)
	{
	}

	[Token(Token = "0x60033B6")]
	[Address(RVA = "0x19953DC", Offset = "0x19953DC", VA = "0x19953DC")]
	public static string ChannelJoin(string param)
	{
		return null;
	}

	[Token(Token = "0x60033B7")]
	[Address(RVA = "0x19953E4", Offset = "0x19953E4", VA = "0x19953E4")]
	public static string ChannelSend(string param)
	{
		return null;
	}

	[Token(Token = "0x60033B8")]
	[Address(RVA = "0x19953EC", Offset = "0x19953EC", VA = "0x19953EC")]
	public static string ChannelOutput(string param)
	{
		return null;
	}

	[Token(Token = "0x60033B9")]
	[Address(RVA = "0x19953F4", Offset = "0x19953F4", VA = "0x19953F4")]
	public static string RoomClose(string param)
	{
		return null;
	}

	[Token(Token = "0x60033BA")]
	[Address(RVA = "0x1995444", Offset = "0x1995444", VA = "0x1995444")]
	[DebuggerHidden]
	private static IEnumerator CoroutineRoomClose(float fDelayTime)
	{
		return null;
	}

	[Token(Token = "0x60033BB")]
	[Address(RVA = "0x19954F8", Offset = "0x19954F8", VA = "0x19954F8")]
	public static string OnShowELO(string param)
	{
		return null;
	}

	[Token(Token = "0x60033BC")]
	[Address(RVA = "0x1995754", Offset = "0x1995754", VA = "0x1995754")]
	public static string OnShowPing(string param)
	{
		return null;
	}

	[Token(Token = "0x60033BD")]
	[Address(RVA = "0x19959B0", Offset = "0x19959B0", VA = "0x19959B0")]
	public static string OnShowStat(string param)
	{
		return null;
	}

	[Token(Token = "0x60033BE")]
	[Address(RVA = "0x1995C0C", Offset = "0x1995C0C", VA = "0x1995C0C")]
	public static string MoveTutorial(string param)
	{
		return null;
	}

	[Token(Token = "0x60033BF")]
	[Address(RVA = "0x1995EC4", Offset = "0x1995EC4", VA = "0x1995EC4")]
	public static string TestRecordAssist(string param)
	{
		return null;
	}

	[Token(Token = "0x60033C0")]
	[Address(RVA = "0x19962A0", Offset = "0x19962A0", VA = "0x19962A0")]
	public static string FakeStorageFull(string param)
	{
		return null;
	}

	[Token(Token = "0x60033C1")]
	[Address(RVA = "0x19964B8", Offset = "0x19964B8", VA = "0x19964B8")]
	public static string GetCrystalParameter(string param)
	{
		return null;
	}

	[Token(Token = "0x60033C2")]
	[Address(RVA = "0x19966CC", Offset = "0x19966CC", VA = "0x19966CC")]
	public static string GetComplexCurrencyParameter(string param)
	{
		return null;
	}

	[Token(Token = "0x60033C3")]
	[Address(RVA = "0x1996A48", Offset = "0x1996A48", VA = "0x1996A48")]
	public static string QACheckParameter(string param)
	{
		return null;
	}

	[Token(Token = "0x60033C4")]
	[Address(RVA = "0x199726C", Offset = "0x199726C", VA = "0x199726C")]
	public static string PlayerTeamQAParam(string param)
	{
		return null;
	}

	[Token(Token = "0x60033C5")]
	[Address(RVA = "0x19973A0", Offset = "0x19973A0", VA = "0x19973A0")]
	public static string PhotonTeamQAParam(string param)
	{
		return null;
	}

	[Token(Token = "0x60033C6")]
	[Address(RVA = "0x19976EC", Offset = "0x19976EC", VA = "0x19976EC")]
	public static string ShowSocial(string param)
	{
		return null;
	}

	[Token(Token = "0x60033C7")]
	[Address(RVA = "0x19977D0", Offset = "0x19977D0", VA = "0x19977D0")]
	public static string GotoTitle(string param)
	{
		return null;
	}

	[Token(Token = "0x60033C8")]
	[Address(RVA = "0x19978A0", Offset = "0x19978A0", VA = "0x19978A0")]
	public static string RoomState(string param)
	{
		return null;
	}

	[Token(Token = "0x60033C9")]
	[Address(RVA = "0x1998344", Offset = "0x1998344", VA = "0x1998344")]
	public static string NetState(string param)
	{
		return null;
	}

	[Token(Token = "0x60033CA")]
	[Address(RVA = "0x1998BC8", Offset = "0x1998BC8", VA = "0x1998BC8")]
	public static string ChatState(string param)
	{
		return null;
	}

	[Token(Token = "0x60033CB")]
	[Address(RVA = "0x1998F9C", Offset = "0x1998F9C", VA = "0x1998F9C")]
	internal static string GameModeState(string arg1)
	{
		return null;
	}

	[Token(Token = "0x60033CC")]
	[Address(RVA = "0x1999354", Offset = "0x1999354", VA = "0x1999354")]
	internal static string XCValidation(string arg1)
	{
		return null;
	}

	[Token(Token = "0x60033CD")]
	[Address(RVA = "0x199935C", Offset = "0x199935C", VA = "0x199935C")]
	internal static string SetXC(string arg1)
	{
		return null;
	}

	[Token(Token = "0x60033CE")]
	[Address(RVA = "0x19994D8", Offset = "0x19994D8", VA = "0x19994D8")]
	public static string OnShowSystemInfo(string param)
	{
		return null;
	}

	[Token(Token = "0x60033CF")]
	[Address(RVA = "0x19998C4", Offset = "0x19998C4", VA = "0x19998C4")]
	internal static string OnLagSimulationGui(string arg1)
	{
		return null;
	}

	[Token(Token = "0x60033D0")]
	[Address(RVA = "0x1999B20", Offset = "0x1999B20", VA = "0x1999B20")]
	internal static string OnPhotonStatsGui(string arg1)
	{
		return null;
	}

	[Token(Token = "0x60033D1")]
	[Address(RVA = "0x1999D7C", Offset = "0x1999D7C", VA = "0x1999D7C")]
	internal static string KickPlayer(string param)
	{
		return null;
	}

	[Token(Token = "0x60033D2")]
	[Address(RVA = "0x1999F90", Offset = "0x1999F90", VA = "0x1999F90")]
	internal static string BanPlayer(string param)
	{
		return null;
	}

	[Token(Token = "0x60033D3")]
	[Address(RVA = "0x199A1A4", Offset = "0x199A1A4", VA = "0x199A1A4")]
	internal static string SetPing(string param)
	{
		return null;
	}

	[Token(Token = "0x60033D4")]
	[Address(RVA = "0x199A3B0", Offset = "0x199A3B0", VA = "0x199A3B0")]
	internal static string SetMatchingSupplement(string param)
	{
		return null;
	}

	[Token(Token = "0x60033D5")]
	[Address(RVA = "0x199A64C", Offset = "0x199A64C", VA = "0x199A64C")]
	internal static string SetRankMatchingSupplement(string param)
	{
		return null;
	}

	[Token(Token = "0x60033D6")]
	[Address(RVA = "0x199A81C", Offset = "0x199A81C", VA = "0x199A81C")]
	internal static string UseCoupon(string couponNum)
	{
		return null;
	}

	[Token(Token = "0x60033D7")]
	[Address(RVA = "0x199AC20", Offset = "0x199AC20", VA = "0x199AC20")]
	public static string OnHoldCamera(string param)
	{
		return null;
	}

	[Token(Token = "0x60033D8")]
	[Address(RVA = "0x199AEAC", Offset = "0x199AEAC", VA = "0x199AEAC")]
	public static string OnFocusCamera(string param)
	{
		return null;
	}

	[Token(Token = "0x60033D9")]
	[Address(RVA = "0x199B138", Offset = "0x199B138", VA = "0x199B138")]
	public static string PostPing(string param)
	{
		return null;
	}

	[Token(Token = "0x60033DA")]
	[Address(RVA = "0x199B30C", Offset = "0x199B30C", VA = "0x199B30C")]
	public static string PostPollingPing(string param)
	{
		return null;
	}

	[Token(Token = "0x60033DB")]
	[Address(RVA = "0x199B4E0", Offset = "0x199B4E0", VA = "0x199B4E0")]
	public static string Spectator(string param)
	{
		return null;
	}

	[Token(Token = "0x60033DC")]
	[Address(RVA = "0x199B8F0", Offset = "0x199B8F0", VA = "0x199B8F0")]
	private static void SetShowLocalizeKey(bool show)
	{
	}

	[Token(Token = "0x60033DD")]
	[Address(RVA = "0x199BA14", Offset = "0x199BA14", VA = "0x199BA14")]
	public static string OnShowLocalizeKey(string param)
	{
		return null;
	}

	[Token(Token = "0x60033DE")]
	[Address(RVA = "0x199BA2C", Offset = "0x199BA2C", VA = "0x199BA2C")]
	public static string OnHideLocalizeKey(string param)
	{
		return null;
	}

	[Token(Token = "0x60033DF")]
	[Address(RVA = "0x199BA44", Offset = "0x199BA44", VA = "0x199BA44")]
	public static string OnShowSpec(string param)
	{
		return null;
	}

	[Token(Token = "0x60033E0")]
	[Address(RVA = "0x199BE0C", Offset = "0x199BE0C", VA = "0x199BE0C")]
	public static string OnAddChar(string param)
	{
		return null;
	}

	[Token(Token = "0x60033E1")]
	[Address(RVA = "0x199C31C", Offset = "0x199C31C", VA = "0x199C31C")]
	public static string OnRoomInfo(string param)
	{
		return null;
	}

	[Token(Token = "0x60033E2")]
	[Address(RVA = "0x199D698", Offset = "0x199D698", VA = "0x199D698")]
	public static string OnShowNGUIAtlas(string param)
	{
		return null;
	}

	[Token(Token = "0x60033E3")]
	[Address(RVA = "0x199E250", Offset = "0x199E250", VA = "0x199E250")]
	public static string OnShowRuntimeMemoryLog(string param)
	{
		return null;
	}

	[Token(Token = "0x60033E4")]
	[Address(RVA = "0x199E4B0", Offset = "0x199E4B0", VA = "0x199E4B0")]
	internal static string AddSecond(string param)
	{
		return null;
	}

	[Token(Token = "0x60033E5")]
	[Address(RVA = "0x199E858", Offset = "0x199E858", VA = "0x199E858")]
	internal static string USDPriceChange(string param)
	{
		return null;
	}

	[Token(Token = "0x60033E6")]
	[Address(RVA = "0x199EA18", Offset = "0x199EA18", VA = "0x199EA18")]
	private static void _003COnAddChar_003Em__164(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
