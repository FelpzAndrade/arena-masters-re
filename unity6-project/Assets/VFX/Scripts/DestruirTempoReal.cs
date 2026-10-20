using UnityEngine;

// some com o objeto depois de 'vida' segundos reais
public class DestruirTempoReal : MonoBehaviour
{
	public float vida = 1f;

	private void Update()
	{
		vida -= Time.unscaledDeltaTime;
		if (vida <= 0f)
		{
			Destroy(gameObject);
		}
	}
}
