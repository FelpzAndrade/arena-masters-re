using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200017B")]
public class GLinkAndroid : IGLink
{
	[Token(Token = "0x200017C")]
	private class OnClickAppSchemeBannerListener : AndroidJavaProxy
	{
		[Token(Token = "0x6000DF4")]
		[Address(RVA = "0x1F36224", Offset = "0x1F36224", VA = "0x1F36224")]
		public OnClickAppSchemeBannerListener() : base((string)null)
		{
		}

		[Token(Token = "0x6000DF5")]
		[Address(RVA = "0x1F362AC", Offset = "0x1F362AC", VA = "0x1F362AC")]
		private void onClickAppSchemeBanner(string appScheme)
		{
		}
	}

	[Token(Token = "0x200017D")]
	private class OnSdkStartedListener : AndroidJavaProxy
	{
		[Token(Token = "0x6000DF6")]
		[Address(RVA = "0x1F368A0", Offset = "0x1F368A0", VA = "0x1F368A0")]
		public OnSdkStartedListener() : base((string)null)
		{
		}

		[Token(Token = "0x6000DF7")]
		[Address(RVA = "0x1F36928", Offset = "0x1F36928", VA = "0x1F36928")]
		private void onSdkStarted()
		{
		}
	}

	[Token(Token = "0x200017E")]
	private class OnSdkStoppedListener : AndroidJavaProxy
	{
		[Token(Token = "0x6000DF8")]
		[Address(RVA = "0x1F36984", Offset = "0x1F36984", VA = "0x1F36984")]
		public OnSdkStoppedListener() : base((string)null)
		{
		}

		[Token(Token = "0x6000DF9")]
		[Address(RVA = "0x1F36A0C", Offset = "0x1F36A0C", VA = "0x1F36A0C")]
		private void onSdkStopped()
		{
		}
	}

	[Token(Token = "0x200017F")]
	private class OnLoggedInListener : AndroidJavaProxy
	{
		[Token(Token = "0x6000DFA")]
		[Address(RVA = "0x1F36454", Offset = "0x1F36454", VA = "0x1F36454")]
		public OnLoggedInListener() : base((string)null)
		{
		}

		[Token(Token = "0x6000DFB")]
		[Address(RVA = "0x1F364DC", Offset = "0x1F364DC", VA = "0x1F364DC")]
		private void onLoggedIn(bool success)
		{
		}
	}

	[Token(Token = "0x2000180")]
	private class OnJoinedListener : AndroidJavaProxy
	{
		[Token(Token = "0x6000DFC")]
		[Address(RVA = "0x1F36370", Offset = "0x1F36370", VA = "0x1F36370")]
		public OnJoinedListener() : base((string)null)
		{
		}

		[Token(Token = "0x6000DFD")]
		[Address(RVA = "0x1F363F8", Offset = "0x1F363F8", VA = "0x1F363F8")]
		private void onJoined()
		{
		}
	}

	[Token(Token = "0x2000181")]
	private class OnPostedArticleListener : AndroidJavaProxy
	{
		[Token(Token = "0x6000DFE")]
		[Address(RVA = "0x1F364E0", Offset = "0x1F364E0", VA = "0x1F364E0")]
		public OnPostedArticleListener() : base((string)null)
		{
		}

		[Token(Token = "0x6000DFF")]
		[Address(RVA = "0x1F36568", Offset = "0x1F36568", VA = "0x1F36568")]
		private void onPostedArticle(int menuId, int imageCount, int videoCount)
		{
		}
	}

	[Token(Token = "0x2000182")]
	private class OnPostedCommentListener : AndroidJavaProxy
	{
		[Token(Token = "0x6000E00")]
		[Address(RVA = "0x1F36654", Offset = "0x1F36654", VA = "0x1F36654")]
		public OnPostedCommentListener() : base((string)null)
		{
		}

		[Token(Token = "0x6000E01")]
		[Address(RVA = "0x1F366DC", Offset = "0x1F366DC", VA = "0x1F366DC")]
		private void onPostedComment(int articleId)
		{
		}
	}

	[Token(Token = "0x2000183")]
	private class OnWidgetScreenshotClickListener : AndroidJavaProxy
	{
		[Token(Token = "0x6000E02")]
		[Address(RVA = "0x1F344C0", Offset = "0x1F344C0", VA = "0x1F344C0")]
		public OnWidgetScreenshotClickListener() : base((string)null)
		{
		}

		[Token(Token = "0x6000E03")]
		[Address(RVA = "0x1F36BDC", Offset = "0x1F36BDC", VA = "0x1F36BDC")]
		private void onScreenshotClick()
		{
		}
	}

	[Token(Token = "0x2000184")]
	private class OnRecordFinishListener : AndroidJavaProxy
	{
		[Token(Token = "0x6000E04")]
		[Address(RVA = "0x1F346E4", Offset = "0x1F346E4", VA = "0x1F346E4")]
		public OnRecordFinishListener() : base((string)null)
		{
		}

		[Token(Token = "0x6000E05")]
		[Address(RVA = "0x1F367C8", Offset = "0x1F367C8", VA = "0x1F367C8")]
		private void onRecordFinished(string uri)
		{
		}
	}

	[Token(Token = "0x2000185")]
	private class OnVotedListener : AndroidJavaProxy
	{
		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x1F36A68", Offset = "0x1F36A68", VA = "0x1F36A68")]
		public OnVotedListener() : base((string)null)
		{
		}

		[Token(Token = "0x6000E07")]
		[Address(RVA = "0x1F36AF0", Offset = "0x1F36AF0", VA = "0x1F36AF0")]
		private void onVoted(int articleId)
		{
		}
	}

	[Token(Token = "0x40005A6")]
	[FieldOffset(Offset = "0x8")]
	private AndroidJavaClass glinkClass;

	[Token(Token = "0x40005A7")]
	[FieldOffset(Offset = "0xC")]
	private AndroidJavaObject currentActivity;

	[Token(Token = "0x6000DDD")]
	[Address(RVA = "0x1F33EA8", Offset = "0x1F33EA8", VA = "0x1F33EA8")]
	public GLinkAndroid()
	{
	}

	[Token(Token = "0x6000DDE")]
	[Address(RVA = "0x1F3476C", Offset = "0x1F3476C", VA = "0x1F3476C")]
	private static void showToast(string message)
	{
	}

	[Token(Token = "0x6000DDF")]
	[Address(RVA = "0x1F34770", Offset = "0x1F34770", VA = "0x1F34770", Slot = "4")]
	public void executeHome()
	{
	}

	[Token(Token = "0x6000DE0")]
	[Address(RVA = "0x1F34894", Offset = "0x1F34894", VA = "0x1F34894", Slot = "5")]
	public void executeNotice()
	{
	}

	[Token(Token = "0x6000DE1")]
	[Address(RVA = "0x1F349B8", Offset = "0x1F349B8", VA = "0x1F349B8", Slot = "6")]
	public void executeEvent()
	{
	}

	[Token(Token = "0x6000DE2")]
	[Address(RVA = "0x1F34ADC", Offset = "0x1F34ADC", VA = "0x1F34ADC", Slot = "7")]
	public void executeMenu()
	{
	}

	[Token(Token = "0x6000DE3")]
	[Address(RVA = "0x1F34C00", Offset = "0x1F34C00", VA = "0x1F34C00", Slot = "8")]
	public void executeProfile()
	{
	}

	[Token(Token = "0x6000DE4")]
	[Address(RVA = "0x1F34D24", Offset = "0x1F34D24", VA = "0x1F34D24", Slot = "9")]
	public void executeArticle(int articleId)
	{
	}

	[Token(Token = "0x6000DE5")]
	[Address(RVA = "0x1F34EC0", Offset = "0x1F34EC0", VA = "0x1F34EC0", Slot = "10")]
	public void executeArticlePost()
	{
	}

	[Token(Token = "0x6000DE6")]
	[Address(RVA = "0x1F34FE4", Offset = "0x1F34FE4", VA = "0x1F34FE4", Slot = "11")]
	public void executeArticlePostWithImage(string filePath)
	{
	}

	[Token(Token = "0x6000DE7")]
	[Address(RVA = "0x1F351B4", Offset = "0x1F351B4", VA = "0x1F351B4", Slot = "12")]
	public void executeArticlePostWithVideo(string filePath)
	{
	}

	[Token(Token = "0x6000DE8")]
	[Address(RVA = "0x1F35384", Offset = "0x1F35384", VA = "0x1F35384", Slot = "19")]
	public void executeMore()
	{
	}

	[Token(Token = "0x6000DE9")]
	[Address(RVA = "0x1F354A8", Offset = "0x1F354A8", VA = "0x1F354A8", Slot = "13")]
	public void syncGameUserId(string gameUserId)
	{
	}

	[Token(Token = "0x6000DEA")]
	[Address(RVA = "0x1F35610", Offset = "0x1F35610", VA = "0x1F35610", Slot = "14")]
	public void startWidget()
	{
	}

	[Token(Token = "0x6000DEB")]
	[Address(RVA = "0x1F35734", Offset = "0x1F35734", VA = "0x1F35734", Slot = "15")]
	public void stopWidget()
	{
	}

	[Token(Token = "0x6000DEC")]
	[Address(RVA = "0x1F34548", Offset = "0x1F34548", VA = "0x1F34548", Slot = "16")]
	public void setUseWidgetVideoRecord(bool useVideoRecord)
	{
	}

	[Token(Token = "0x6000DED")]
	[Address(RVA = "0x1F35858", Offset = "0x1F35858", VA = "0x1F35858", Slot = "17")]
	public void setUseWidgetScreenShot(bool useScreenShot)
	{
	}

	[Token(Token = "0x6000DEE")]
	[Address(RVA = "0x1F359F4", Offset = "0x1F359F4", VA = "0x1F359F4", Slot = "18")]
	public void setShowWidgetWhenUnloadSDK(bool useWidget)
	{
	}

	[Token(Token = "0x6000DEF")]
	[Address(RVA = "0x1F35B90", Offset = "0x1F35B90", VA = "0x1F35B90", Slot = "20")]
	public string getCurrentChannelCode()
	{
		return null;
	}

	[Token(Token = "0x6000DF0")]
	[Address(RVA = "0x1F35C68", Offset = "0x1F35C68", VA = "0x1F35C68", Slot = "21")]
	public void setChannelCode(string channelCode)
	{
	}

	[Token(Token = "0x6000DF1")]
	[Address(RVA = "0x1F35D8C", Offset = "0x1F35D8C", VA = "0x1F35D8C", Slot = "22")]
	public void setThemeColor(string themeColorCSSString)
	{
	}

	[Token(Token = "0x6000DF2")]
	[Address(RVA = "0x1F35EB0", Offset = "0x1F35EB0", VA = "0x1F35EB0", Slot = "23")]
	public void setThemeColor(string themeColorCSSString, string backgroundCSSString)
	{
	}

	[Token(Token = "0x6000DF3")]
	[Address(RVA = "0x1F36018", Offset = "0x1F36018", VA = "0x1F36018", Slot = "24")]
	public void setWidgetStartPosition(bool isLeft, int heightPercentage)
	{
	}
}
