using UnityEngine;

// Cor trocavel de um efeito de skill (prefab com o shader ArenaMasters/VFX/Particula Dissolve).
// O mesmo prefab serve para qualquer heroi: so muda 'cor' (HDR) e a escala. Fica no objeto raiz do prefab.
// Cada parte guarda o proprio brilho; partes 'fixas' (nucleo escuro, respingo, clarao amarelo) nao mudam de cor.
// Usa MaterialPropertyBlock: nao cria material novo por heroi.
public class EfeitoCor : MonoBehaviour
{
	[System.Serializable]
	public class Parte
	{
		public Renderer renderer;
		public float brilho = 2f;          // multiplica a cor (acima de 1 = HDR, passa no bloom)
		public float miolo = 0.6f;         // quanto o miolo puxa para o branco (0 = mesma cor, 1 = branco)
		public bool fixa;                  // true = mantem a cor do material
	}

	[ColorUsage(false, true)] public Color cor = new Color(0.04f, 0.4f, 1f);   // azul saturado (componentes baixos = cor forte depois do tonemapping)
	public Parte[] partes = new Parte[0];

	private static readonly int s_color = Shader.PropertyToID("_Color");
	private static readonly int s_core = Shader.PropertyToID("_CoreColor");
	private static readonly int s_edge = Shader.PropertyToID("_EdgeColor");

	public void Aplicar(Color novaCor)
	{
		cor = novaCor;
		Aplicar();
	}

	public void Aplicar()
	{
		MaterialPropertyBlock b = new MaterialPropertyBlock();
		foreach (Parte p in partes)
		{
			if (p.renderer == null || p.fixa)
			{
				continue;
			}
			b.Clear();
			b.SetColor(s_color, cor * p.brilho);
			b.SetColor(s_core, Color.Lerp(cor, Color.white, p.miolo) * (p.brilho * 1.4f));
			b.SetColor(s_edge, Color.Lerp(cor, Color.white, 0.3f) * (p.brilho * 1.2f));
			p.renderer.SetPropertyBlock(b);
		}
	}

	private void OnEnable()
	{
		Aplicar();
	}

	// cria o efeito, ajusta cor e escala e destroi sozinho depois de 'vida' segundos (tempo real: o efeito anda no hit stop)
	public static GameObject Criar(GameObject prefab, Vector3 pos, Quaternion rot, Transform pai, Color cor, float escala, float vida)
	{
		GameObject go = Object.Instantiate(prefab, pos, rot, pai);
		go.transform.localScale = Vector3.one * escala;
		if (go.TryGetComponent(out EfeitoCor ec))
		{
			ec.Aplicar(cor);
		}
		go.AddComponent<DestruirTempoReal>().vida = vida;
		return go;
	}
}
