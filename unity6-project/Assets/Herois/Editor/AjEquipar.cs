using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

// Encaixes do equipamento do Aj (valores acertados olhando a previa em Idle, Run, Ataque e Redemoinho).
// Menu: Arena Masters/Herois/Previa do equipamento do Aj (Captures/equip_depois.png).
public static class AjEquipar
{
	private const string Dir = "Assets/Herois/Aj/Equipamento";

	public static Equipamento.Encaixe[] Encaixes()
	{
		return new[]
		{
			new Equipamento.Encaixe
			{
				nome = "Espada", osso = HumanBodyBones.RightHand, peca = Peca("Espada"),
				posicao = new Vector3(0f, 0.075f, 0.02f), rotacao = new Vector3(0f, 0f, 90f), escala = 0.55f,   // lamina (+Y da peca) para o lado do polegar
				arma = true, ponta = new Vector3(0f, 1.42f, 0f),   // ponta da lamina no espaco da peca (malha vai ate y = 1,44)
			},
			new Equipamento.Encaixe
			{
				nome = "Escudo", osso = HumanBodyBones.LeftLowerArm, peca = Peca("Escudo"),
				posicao = new Vector3(0f, 0.13f, -0.07f), rotacao = new Vector3(0f, 180f, 0f), escala = 0.5f,
			},
			new Equipamento.Encaixe
			{
				nome = "Elmo", osso = HumanBodyBones.Head, peca = Peca("Elmo"),
				posicao = new Vector3(0f, 0.06f, -0.14f), rotacao = new Vector3(-8f, 0f, 0f), escala = 0.6f,   // cobre o bone
			},
		};
	}

	private static GameObject Peca(string nome) => AssetDatabase.LoadAssetAtPath<GameObject>($"{Dir}/{nome}.prefab");

	public static void Preparar(GameObject heroi)
	{
		Equipamento e = heroi.GetComponent<Equipamento>() ?? heroi.AddComponent<Equipamento>();
		e.encaixes = Encaixes();
		e.Equipar();
	}

	[MenuItem("Arena Masters/Herois/Previa do equipamento do Aj")]
	public static void Previa()
	{
		Previa("equip_depois");
	}

	public static string Previa(string nome)
	{
		var poses = new List<(string, string, float)>
		{
			("Assets/Herois/Aj/Aj_Idle.fbx", "Aj_Idle", 0.5f),
			("Assets/Herois/Aj/Aj_Run.fbx", "Aj_Run", 0.2f),
			("Assets/Herois/Aj/Aj_AtaqueBasico.fbx", "Aj_Ataque1", 0.7f),
			("Assets/Herois/Aj/Aj_Redemoinho.fbx", "Aj_Redemoinho", 0.6f),
		};
		return EquipamentoPrevia.Folha(AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Herois/Aj/Aj_Idle.fbx"), poses, nome, Preparar);
	}
}
