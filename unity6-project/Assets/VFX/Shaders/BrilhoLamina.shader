// Brilho da espada do Cavaleiro: 2a camada da malha da lamina (por cima do material normal do heroi), sem luz, somando brilho.
// So acende o fio (as duas bordas da lamina) e uma runa no meio; o resto da lamina continua metal (camada de baixo).
// As formas saem da posicao no espaco da espada (1H_Sword do KayKit: lamina de y 0,27 ate a ponta em 1,41, meia largura 0,157,
// afina a partir de y 1,1), entao nao precisa de textura nova.
// _Brilho (multiplicador) vem do jogo por MaterialPropertyBlock (componente EspadaBrilho): pulso parado, pico nos golpes.
// HLSL puro (Built-in e URP), sem Shader Graph.
Shader "ArenaMasters/VFX/Brilho Lamina"
{
	Properties
	{
		// cor do brilho; acima de 1 passa do limite do bloom
		[HDR] _Color ("Cor (HDR)", Color) = (0.55, 0.45, 2.4, 1)
		// multiplicador (o jogo muda por MaterialPropertyBlock)
		_Brilho ("Brilho", Float) = 1
		// largura do fio aceso, em metros da espada
		_Fio ("Largura do fio", Range(0.005, 0.08)) = 0.03
		// forca da runa em relacao ao fio
		_Runa ("Forca da runa", Range(0, 2)) = 1
	}

	SubShader
	{
		Tags { "Queue" = "Transparent" "RenderType" = "Transparent" "IgnoreProjector" = "True" }
		Blend One One
		ZWrite Off
		ZTest LEqual
		Offset -1, -1
		Cull Back
		Lighting Off

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#pragma target 3.0
			#include "HLSLSupport.cginc"
			#include "UnityCG.cginc"

			half4 _Color;
			half _Brilho;
			half _Fio;
			half _Runa;

			struct appdata
			{
				float4 vertex : POSITION;
			};

			struct v2f
			{
				float4 pos : SV_POSITION;
				float3 obj : TEXCOORD0;
			};

			v2f vert(appdata v)
			{
				v2f o;
				o.pos = UnityObjectToClipPos(v.vertex);
				o.obj = v.vertex.xyz;
				return o;
			}

			// linha fina: 1 dentro da distancia d, some em 0,006 m
			half Traco(float d, float largura)
			{
				return 1.0h - smoothstep(largura, largura + 0.006, d);
			}

			half Runa(float2 p)
			{
				float x = abs(p.x);
				half r = 0;
				// espinha no centro
				r = max(r, Traco(x, 0.006) * step(0.5, p.y) * step(p.y, 0.95));
				// losango no meio (so o contorno)
				float l = x / 0.05 + abs(p.y - 0.72) / 0.08;
				r = max(r, Traco(abs(l - 1.0) * 0.05, 0.005));
				// duas setas (v) abaixo e acima do losango
				r = max(r, Traco(abs(p.y - 0.55 - x * 0.9), 0.006) * step(x, 0.045));
				r = max(r, Traco(abs(p.y - 0.89 + x * 0.9), 0.006) * step(x, 0.045));
				return r;
			}

			half4 frag(v2f i) : SV_Target
			{
				float3 p = i.obj;
				half naLamina = smoothstep(0.26, 0.3, p.y);
				// meia largura da lamina nesta altura (reta ate 1,1, depois afina ate a ponta)
				float w = lerp(0.157, 0.0, saturate((p.y - 1.1) / 0.31));
				half fio = smoothstep(w - _Fio, w - 0.004, abs(p.x));
				fio = max(fio, smoothstep(1.33, 1.4, p.y));   // ponta inteira acesa
				half m = naLamina * max(fio, Runa(p.xy) * _Runa);
				return half4(_Color.rgb * m * _Brilho, 0);
			}
			ENDHLSL
		}
	}
}
