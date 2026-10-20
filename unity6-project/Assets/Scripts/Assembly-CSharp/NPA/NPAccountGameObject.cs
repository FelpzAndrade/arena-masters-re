using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace NPA
{
	[Token(Token = "0x20010AD")]
	public class NPAccountGameObject : MonoBehaviour
	{
		[Token(Token = "0x4005ABC")]
		[FieldOffset(Offset = "0xC")]
		public Hashtable npaListenerTable;

		[Token(Token = "0x4005ABD")]
		[FieldOffset(Offset = "0x10")]
		public INPRecvNotificationListener pushListener;

		[Token(Token = "0x4005ABE")]
		[FieldOffset(Offset = "0x14")]
		public INPGCMListener gcmListener;

		[Token(Token = "0x6007DD2")]
		[Address(RVA = "0x11DA754", Offset = "0x11DA754", VA = "0x11DA754")]
		public NPAccountGameObject()
		{
		}

		[Token(Token = "0x6007DD3")]
		[Address(RVA = "0x11DA7F0", Offset = "0x11DA7F0", VA = "0x11DA7F0")]
		private void setListener(object[] paramsArray)
		{
		}

		[Token(Token = "0x6007DD4")]
		[Address(RVA = "0x11DAA28", Offset = "0x11DAA28", VA = "0x11DAA28")]
		private void setPushListener(INPRecvNotificationListener pushListener)
		{
		}

		[Token(Token = "0x6007DD5")]
		[Address(RVA = "0x11DAA30", Offset = "0x11DAA30", VA = "0x11DAA30")]
		private void setGCMListener(INPGCMListener gcmListener)
		{
		}

		[Token(Token = "0x6007DD6")]
		[Address(RVA = "0x11DAA38", Offset = "0x11DAA38", VA = "0x11DAA38")]
		public void OnReceiveNotification(string msg)
		{
		}

		[Token(Token = "0x6007DD7")]
		[Address(RVA = "0x11DABEC", Offset = "0x11DABEC", VA = "0x11DABEC")]
		public void OnEndingBannerClick(string msg)
		{
		}

		[Token(Token = "0x6007DD8")]
		[Address(RVA = "0x11DAE9C", Offset = "0x11DAE9C", VA = "0x11DAE9C")]
		public void OnEndingBannerDismiss(string msg)
		{
		}

		[Token(Token = "0x6007DD9")]
		[Address(RVA = "0x11DB124", Offset = "0x11DB124", VA = "0x11DB124")]
		public void OnEndingBannerFailed(string msg)
		{
		}

		[Token(Token = "0x6007DDA")]
		[Address(RVA = "0x11DB53C", Offset = "0x11DB53C", VA = "0x11DB53C")]
		public void OnEndingBannerExit(string msg)
		{
		}

		[Token(Token = "0x6007DDB")]
		[Address(RVA = "0x11DB7C4", Offset = "0x11DB7C4", VA = "0x11DB7C4")]
		public void OnBannerClick(string msg)
		{
		}

		[Token(Token = "0x6007DDC")]
		[Address(RVA = "0x11DBA74", Offset = "0x11DBA74", VA = "0x11DBA74")]
		public void OnBannerDismiss(string msg)
		{
		}

		[Token(Token = "0x6007DDD")]
		[Address(RVA = "0x11DBCFC", Offset = "0x11DBCFC", VA = "0x11DBCFC")]
		public void OnBannerFailed(string msg)
		{
		}

		[Token(Token = "0x6007DDE")]
		[Address(RVA = "0x11DC114", Offset = "0x11DC114", VA = "0x11DC114")]
		public void OnClose(string msg)
		{
		}

		[Token(Token = "0x6007DDF")]
		[Address(RVA = "0x11DC5E8", Offset = "0x11DC5E8", VA = "0x11DC5E8")]
		public void OnGameServiceClose(string msg)
		{
		}

		[Token(Token = "0x6007DE0")]
		[Address(RVA = "0x11DC9F8", Offset = "0x11DC9F8", VA = "0x11DC9F8")]
		public void OnResult(string msg)
		{
		}

		[Token(Token = "0x6007DE1")]
		[Address(RVA = "0x11DCE08", Offset = "0x11DCE08", VA = "0x11DCE08")]
		public void OnActionPerformedResult(string msg)
		{
		}

		[Token(Token = "0x6007DE2")]
		[Address(RVA = "0x11DD224", Offset = "0x11DD224", VA = "0x11DD224")]
		public void OnGCMResult(string msg)
		{
		}

		[Token(Token = "0x6007DE3")]
		[Address(RVA = "0x11DD3D8", Offset = "0x11DD3D8", VA = "0x11DD3D8")]
		public void OnRequestPermissionsResult(string msg)
		{
		}
	}
}
