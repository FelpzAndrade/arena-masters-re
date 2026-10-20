using GoogleMobileAds.Api;
using Il2CppDummyDll;
using UnityEngine;

namespace GoogleMobileAds.Android
{
	[Token(Token = "0x200004F")]
	internal class CustomInAppPurchase : ICustomInAppPurchase
	{
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x8")]
		private AndroidJavaObject purchase;

		[Token(Token = "0x17000050")]
		public string ProductId
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x1F3D710", Offset = "0x1F3D710", VA = "0x1F3D710", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1F3D6F0", Offset = "0x1F3D6F0", VA = "0x1F3D6F0")]
		public CustomInAppPurchase(AndroidJavaObject purchase)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1F3D7E8", Offset = "0x1F3D7E8", VA = "0x1F3D7E8", Slot = "5")]
		public void RecordResolution(PurchaseResolutionType resolution)
		{
		}
	}
}
