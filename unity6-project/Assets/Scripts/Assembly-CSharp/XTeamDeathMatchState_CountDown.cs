using System;
using System.Collections.Generic;
using System.Linq;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000585")]
public class XTeamDeathMatchState_CountDown : XPVPGameModeState_CountDown
{
	[Token(Token = "0x2000586")]
	private sealed class _003CDivideTeam_003Ec__AnonStorey11E
	{
		[Token(Token = "0x4001B38")]
		[FieldOffset(Offset = "0x8")]
		internal XTeamEnum t;

		[Token(Token = "0x6002F07")]
		[Address(RVA = "0x184283C", Offset = "0x184283C", VA = "0x184283C")]
		public _003CDivideTeam_003Ec__AnonStorey11E()
		{
		}

		[Token(Token = "0x6002F08")]
		[Address(RVA = "0x1843B74", Offset = "0x1843B74", VA = "0x1843B74")]
		internal void _003C_003Em__11F(KeyValuePair<string, XPlayer> e)
		{
		}

		[Token(Token = "0x6002F09")]
		[Address(RVA = "0x1843EB8", Offset = "0x1843EB8", VA = "0x1843EB8")]
		internal void _003C_003Em__120(KeyValuePair<string, XPlayer> e)
		{
		}

		[Token(Token = "0x6002F0A")]
		[Address(RVA = "0x18441FC", Offset = "0x18441FC", VA = "0x18441FC")]
		internal void _003C_003Em__129(KeyValuePair<string, XPlayer> e)
		{
		}
	}

	[Token(Token = "0x4001B2C")]
	[FieldOffset(Offset = "0x0")]
	private static Func<KeyValuePair<string, XPlayer>, short> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4001B2D")]
	[FieldOffset(Offset = "0x4")]
	private static Action<KeyValuePair<string, XPlayer>> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4001B2E")]
	[FieldOffset(Offset = "0x8")]
	private static Action<KeyValuePair<string, XPlayer>> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4001B2F")]
	[FieldOffset(Offset = "0xC")]
	private static Func<KeyValuePair<string, XPlayer>, XTeamEnum> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x4001B30")]
	[FieldOffset(Offset = "0x10")]
	private static Func<IGrouping<XTeamEnum, KeyValuePair<string, XPlayer>>, _003C_003E__AnonType1<XTeamEnum, double>> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x4001B31")]
	[FieldOffset(Offset = "0x14")]
	private static Func<_003C_003E__AnonType1<XTeamEnum, double>, bool> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x4001B32")]
	[FieldOffset(Offset = "0x18")]
	private static Func<_003C_003E__AnonType1<XTeamEnum, double>, double> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x4001B33")]
	[FieldOffset(Offset = "0x1C")]
	private static Func<KeyValuePair<string, XPlayer>, int> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x4001B34")]
	[FieldOffset(Offset = "0x20")]
	private static Func<KeyValuePair<string, XPlayer>, KeyValuePair<string, XPlayer>> _003C_003Ef__am_0024cache8;

	[Token(Token = "0x4001B35")]
	[FieldOffset(Offset = "0x24")]
	private static Func<KeyValuePair<string, XPlayer>, bool> _003C_003Ef__am_0024cache9;

	[Token(Token = "0x4001B36")]
	[FieldOffset(Offset = "0x28")]
	private static Func<KeyValuePair<string, XPlayer>, int> _003C_003Ef__am_0024cacheA;

	[Token(Token = "0x4001B37")]
	[FieldOffset(Offset = "0x2C")]
	private static Func<KeyValuePair<string, XPlayer>, int> _003C_003Ef__am_0024cacheB;

	[Token(Token = "0x6002EF6")]
	[Address(RVA = "0x1841810", Offset = "0x1841810", VA = "0x1841810")]
	public XTeamDeathMatchState_CountDown()
	{
	}

	[Token(Token = "0x6002EF7")]
	[Address(RVA = "0x1841818", Offset = "0x1841818", VA = "0x1841818", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6002EF8")]
	[Address(RVA = "0x184188C", Offset = "0x184188C", VA = "0x184188C", Slot = "20")]
	protected virtual void DevideIntoTeam()
	{
	}

	[Token(Token = "0x6002EF9")]
	[Address(RVA = "0x1841D70", Offset = "0x1841D70", VA = "0x1841D70")]
	private void DivideTeam(ref List<KeyValuePair<string, XPlayer>> list)
	{
	}

	[Token(Token = "0x6002EFA")]
	[Address(RVA = "0x1842844", Offset = "0x1842844", VA = "0x1842844")]
	private void SetTeam(int nPhotonID, XTeamEnum nTeam, bool onReconnect)
	{
	}

	[Token(Token = "0x6002EFB")]
	[Address(RVA = "0x1842B40", Offset = "0x1842B40", VA = "0x1842B40")]
	private static short _003CDevideIntoTeam_003Em__11C(KeyValuePair<string, XPlayer> e)
	{
		return default(short);
	}

	[Token(Token = "0x6002EFC")]
	[Address(RVA = "0x1842C48", Offset = "0x1842C48", VA = "0x1842C48")]
	private static void _003CDevideIntoTeam_003Em__11D(KeyValuePair<string, XPlayer> e)
	{
	}

	[Token(Token = "0x6002EFD")]
	[Address(RVA = "0x18431A8", Offset = "0x18431A8", VA = "0x18431A8")]
	private static void _003CDivideTeam_003Em__11E(KeyValuePair<string, XPlayer> e)
	{
	}

	[Token(Token = "0x6002EFE")]
	[Address(RVA = "0x18434CC", Offset = "0x18434CC", VA = "0x18434CC")]
	private static XTeamEnum _003CDivideTeam_003Em__121(KeyValuePair<string, XPlayer> e)
	{
		return default(XTeamEnum);
	}

	[Token(Token = "0x6002EFF")]
	[Address(RVA = "0x184357C", Offset = "0x184357C", VA = "0x184357C")]
	private static _003C_003E__AnonType1<XTeamEnum, double> _003CDivideTeam_003Em__122(IGrouping<XTeamEnum, KeyValuePair<string, XPlayer>> n)
	{
		return null;
	}

	[Token(Token = "0x6002F00")]
	[Address(RVA = "0x1843790", Offset = "0x1843790", VA = "0x1843790")]
	private static bool _003CDivideTeam_003Em__123(_003C_003E__AnonType1<XTeamEnum, double> e)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F01")]
	[Address(RVA = "0x1843830", Offset = "0x1843830", VA = "0x1843830")]
	private static double _003CDivideTeam_003Em__124(_003C_003E__AnonType1<XTeamEnum, double> n)
	{
		return default(double);
	}

	[Token(Token = "0x6002F02")]
	[Address(RVA = "0x18438C8", Offset = "0x18438C8", VA = "0x18438C8")]
	private static int _003CDivideTeam_003Em__125(KeyValuePair<string, XPlayer> e)
	{
		return default(int);
	}

	[Token(Token = "0x6002F03")]
	[Address(RVA = "0x1843968", Offset = "0x1843968", VA = "0x1843968")]
	private static KeyValuePair<string, XPlayer> _003CDivideTeam_003Em__126(KeyValuePair<string, XPlayer> e)
	{
		return default(KeyValuePair<string, XPlayer>);
	}

	[Token(Token = "0x6002F04")]
	[Address(RVA = "0x1843970", Offset = "0x1843970", VA = "0x1843970")]
	private static bool _003CDivideTeam_003Em__127(KeyValuePair<string, XPlayer> e)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F05")]
	[Address(RVA = "0x1843A34", Offset = "0x1843A34", VA = "0x1843A34")]
	private static int _003CDivideTeam_003Em__128(KeyValuePair<string, XPlayer> e)
	{
		return default(int);
	}

	[Token(Token = "0x6002F06")]
	[Address(RVA = "0x1843AD4", Offset = "0x1843AD4", VA = "0x1843AD4")]
	private static int _003CDivideTeam_003Em__12A(KeyValuePair<string, XPlayer> x)
	{
		return default(int);
	}
}
