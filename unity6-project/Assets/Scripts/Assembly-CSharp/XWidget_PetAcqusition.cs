using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2000FC9")]
internal class XWidget_PetAcqusition : XWidget_CharacterAcqusition
{
	[Token(Token = "0x40053F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public UILabel lblDustQuantity;

	[Token(Token = "0x60075A1")]
	[Address(RVA = "0x1316E60", Offset = "0x1316E60", VA = "0x1316E60")]
	public XWidget_PetAcqusition()
	{
	}

	[Token(Token = "0x60075A2")]
	[Address(RVA = "0x1316E68", Offset = "0x1316E68", VA = "0x1316E68", Slot = "18")]
	public override void Show(XModuleActor character, bool isEvolution, [Optional] Action onClickOk)
	{
	}

	[Token(Token = "0x60075A3")]
	[Address(RVA = "0x1317040", Offset = "0x1317040", VA = "0x1317040", Slot = "19")]
	protected override void BuildUI(bool isEvolution, XModuleActor character)
	{
	}

	[Token(Token = "0x60075A4")]
	[Address(RVA = "0x13177F0", Offset = "0x13177F0", VA = "0x13177F0")]
	private bool IsOwnedPet(string charUID)
	{
		return default(bool);
	}

	[Token(Token = "0x60075A5")]
	[Address(RVA = "0x13178B4", Offset = "0x13178B4", VA = "0x13178B4", Slot = "20")]
	protected override bool CheckCost()
	{
		return default(bool);
	}

	[Token(Token = "0x60075A6")]
	[Address(RVA = "0x1317C6C", Offset = "0x1317C6C", VA = "0x1317C6C")]
	private void _003CShow_003Em__4D8()
	{
	}
}
