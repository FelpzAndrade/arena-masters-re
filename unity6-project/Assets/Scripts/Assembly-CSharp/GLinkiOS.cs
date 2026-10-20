using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000194")]
public class GLinkiOS : MonoBehaviour, IGLink
{
	[Token(Token = "0x6000E36")]
	[Address(RVA = "0x1F36D58", Offset = "0x1F36D58", VA = "0x1F36D58")]
	public GLinkiOS()
	{
	}

	[Token(Token = "0x6000E37")]
	[Address(RVA = "0x1F36D60", Offset = "0x1F36D60", VA = "0x1F36D60", Slot = "4")]
	public void executeHome()
	{
	}

	[Token(Token = "0x6000E38")]
	[Address(RVA = "0x1F36D64", Offset = "0x1F36D64", VA = "0x1F36D64", Slot = "5")]
	public void executeNotice()
	{
	}

	[Token(Token = "0x6000E39")]
	[Address(RVA = "0x1F36D68", Offset = "0x1F36D68", VA = "0x1F36D68", Slot = "6")]
	public void executeEvent()
	{
	}

	[Token(Token = "0x6000E3A")]
	[Address(RVA = "0x1F36D6C", Offset = "0x1F36D6C", VA = "0x1F36D6C", Slot = "7")]
	public void executeMenu()
	{
	}

	[Token(Token = "0x6000E3B")]
	[Address(RVA = "0x1F36D70", Offset = "0x1F36D70", VA = "0x1F36D70", Slot = "8")]
	public void executeProfile()
	{
	}

	[Token(Token = "0x6000E3C")]
	[Address(RVA = "0x1F36D74", Offset = "0x1F36D74", VA = "0x1F36D74", Slot = "9")]
	public void executeArticle(int articleId)
	{
	}

	[Token(Token = "0x6000E3D")]
	[Address(RVA = "0x1F36D78", Offset = "0x1F36D78", VA = "0x1F36D78", Slot = "10")]
	public void executeArticlePost()
	{
	}

	[Token(Token = "0x6000E3E")]
	[Address(RVA = "0x1F36D7C", Offset = "0x1F36D7C", VA = "0x1F36D7C", Slot = "11")]
	public void executeArticlePostWithImage(string filePath)
	{
	}

	[Token(Token = "0x6000E3F")]
	[Address(RVA = "0x1F36D80", Offset = "0x1F36D80", VA = "0x1F36D80", Slot = "12")]
	public void executeArticlePostWithVideo(string filePath)
	{
	}

	[Token(Token = "0x6000E40")]
	[Address(RVA = "0x1F36D84", Offset = "0x1F36D84", VA = "0x1F36D84", Slot = "13")]
	public void syncGameUserId(string gameUserId)
	{
	}

	[Token(Token = "0x6000E41")]
	[Address(RVA = "0x1F36D88", Offset = "0x1F36D88", VA = "0x1F36D88", Slot = "19")]
	public void executeMore()
	{
	}

	[Token(Token = "0x6000E42")]
	[Address(RVA = "0x1F36D8C", Offset = "0x1F36D8C", VA = "0x1F36D8C", Slot = "14")]
	public void startWidget()
	{
	}

	[Token(Token = "0x6000E43")]
	[Address(RVA = "0x1F36D90", Offset = "0x1F36D90", VA = "0x1F36D90", Slot = "15")]
	public void stopWidget()
	{
	}

	[Token(Token = "0x6000E44")]
	[Address(RVA = "0x1F36D94", Offset = "0x1F36D94", VA = "0x1F36D94", Slot = "16")]
	public void setUseWidgetVideoRecord(bool useVideoRecord)
	{
	}

	[Token(Token = "0x6000E45")]
	[Address(RVA = "0x1F36D98", Offset = "0x1F36D98", VA = "0x1F36D98", Slot = "18")]
	public void setShowWidgetWhenUnloadSDK(bool useWidget)
	{
	}

	[Token(Token = "0x6000E46")]
	[Address(RVA = "0x1F36D9C", Offset = "0x1F36D9C", VA = "0x1F36D9C", Slot = "20")]
	public string getCurrentChannelCode()
	{
		return null;
	}

	[Token(Token = "0x6000E47")]
	[Address(RVA = "0x1F36DA4", Offset = "0x1F36DA4", VA = "0x1F36DA4", Slot = "21")]
	public void setChannelCode(string channelCode)
	{
	}

	[Token(Token = "0x6000E48")]
	[Address(RVA = "0x1F36DA8", Offset = "0x1F36DA8", VA = "0x1F36DA8", Slot = "22")]
	public void setThemeColor(string themeColorCSSString)
	{
	}

	[Token(Token = "0x6000E49")]
	[Address(RVA = "0x1F36DAC", Offset = "0x1F36DAC", VA = "0x1F36DAC", Slot = "23")]
	public void setThemeColor(string themeColorCSSString, string backgroundCSSString)
	{
	}

	[Token(Token = "0x6000E4A")]
	[Address(RVA = "0x1F36DB0", Offset = "0x1F36DB0", VA = "0x1F36DB0", Slot = "24")]
	public void setWidgetStartPosition(bool isLeft, int heightPercentage)
	{
	}

	[Token(Token = "0x6000E4B")]
	[Address(RVA = "0x1F36DB4", Offset = "0x1F36DB4", VA = "0x1F36DB4", Slot = "17")]
	public void setUseWidgetScreenShot(bool useScreenShot)
	{
	}
}
