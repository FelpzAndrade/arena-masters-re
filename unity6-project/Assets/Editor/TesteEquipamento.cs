using System.IO;
using System.Text;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

// Teste do equipamento no combate (rodar na copia de CI: tools/ci_run.sh TesteEquipamento.Rodar).
// A mesma luta bot x bot (Cavaleiro x Spark, mesmas sementes de sorteio, 60 s) duas vezes: o Cavaleiro sem nada e com
// o equipamento bom (Lamina do Relampago Errante +4, conjunto Vigilia Rubra completo, Anel da Rainha Escarlate,
// Colar da Esfera Runica). Mede o dano que o Cavaleiro causa e recebe. Resultado: captures/teste_equipamento.txt.
// (Os itens magicos so disparam no Play; aqui conta so o efeito dos atributos.)
public static class TesteEquipamento
{
	public static void Rodar()
	{
		StringBuilder log = new StringBuilder();
		(int causado, int recebido, float vida, float atk, float def, float crit) sem = Luta(false, log);
		(int causado, int recebido, float vida, float atk, float def, float crit) com = Luta(true, log);
		log.AppendLine();
		log.AppendLine($"SEM equipamento: vida {sem.vida:0}, ATK {sem.atk:0}, DEF {sem.def * 100:0.#}%, critico {sem.crit * 100:0.#}% | dano causado {sem.causado:N0}, dano recebido {sem.recebido:N0}");
		log.AppendLine($"COM equipamento: vida {com.vida:0}, ATK {com.atk:0}, DEF {com.def * 100:0.#}%, critico {com.crit * 100:0.#}% | dano causado {com.causado:N0}, dano recebido {com.recebido:N0}");
		log.AppendLine($"Diferenca: dano causado {(com.causado / (float)Mathf.Max(1, sem.causado) - 1f) * 100f:+0;-0}%, dano recebido {(com.recebido / (float)Mathf.Max(1, sem.recebido) - 1f) * 100f:+0;-0}%");
		string dir = "C:/Users/felip/arena-masters-re/captures";
		Directory.CreateDirectory(dir);
		File.WriteAllText($"{dir}/teste_equipamento.txt", log.ToString());
		Debug.Log(log.ToString());
	}

	static (int, int, float, float, float, float) Luta(bool equipado, StringBuilder log)
	{
		Progresso.semSalvar = true;
		Progresso.Atual = new Progresso.Dados();
		if (equipado)
		{
			foreach (string id in new[] { "lamina_relampago", "couraca_vigilia", "grevas_vigilia", "manoplas_vigilia", "anel_rainha", "colar_esfera" })
			{
				Progresso.ItemSalvo s = Progresso.Novo(Progresso.Atual, id);
				if (id == "lamina_relampago")
				{
					s.nivel = 4;
				}
				Progresso.Equipar("Cavaleiro", s.uid);
			}
		}
		BattleManager.heroiJogadorTeste = "Cavaleiro";
		BattleManager.heroiInimigoTeste = "Spark";
		Random.InitState(1234);
		EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
		BattleManager bm = new GameObject("BattleManager").AddComponent<BattleManager>();
		bm.playerControlled = false;
		bm.cavaleiroModel = AssetDatabase.LoadAssetAtPath<GameObject>(CavaleiroLutaSetup.Prefab);
		bm.bruxaModel = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prototype/KayKit/Characters/Mage.fbx");
		bm.machadinhaModel = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prototype/KayKit/Characters/Barbarian.fbx");
		bm.Setup();
		int causado = 0, recebido = 0;
		System.Action<Fighter, Fighter, SkillDef, int> antes = bm.player.onDealtHit;
		bm.player.onDealtHit = (a, b, sd, d) => { causado += d; antes?.Invoke(a, b, sd, d); };
		System.Action<Fighter, Fighter, SkillDef, int> antesE = bm.enemy.onDealtHit;
		bm.enemy.onDealtHit = (a, b, sd, d) => { recebido += d; antesE?.Invoke(a, b, sd, d); };
		CS.CharStatus st = bm.player.baseStatus;
		for (int q = 0; q < 30 * 60; q++)
		{
			bm.Step(1f / 30f);
		}
		log.AppendLine($"{(equipado ? "com" : "sem")}: placar {bm.player.kills}x{bm.enemy.kills}, causado {causado}, recebido {recebido}");
		Progresso.semSalvar = false;
		BattleManager.heroiJogadorTeste = BattleManager.heroiInimigoTeste = null;
		return (causado, recebido, st.MaxHP.Calc(), st.PhysicalDamage.Calc(), st.PhysicalDefense.Calc(), st.Critical.Calc());
	}
}
