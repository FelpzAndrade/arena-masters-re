# Paletas de cor dos herois de teste, no sistema do KayKit: a textura e uma tabela de blocos de cor (128 x 256),
# e trocar a cor de uma peca = trocar o bloco dela. Nada e pintado a mao.
#   Assets/Herois/Cavaleiro/T_CavaleiroPaleta.png  blocos vermelhos (capa, brasao do escudo) viram azul-roxo
#                                                   (cor das Skills A e B); dourado e aco ficam como estao
#   Assets/Herois/Cavaleiro/T_BonecoPaleta.png      tudo em cinza neutro (boneco de treino sem cor de heroi)
# Uso: tools/venv/Scripts/python.exe -I tools/gen_hero_textures.py
from pathlib import Path

import numpy as np
from PIL import Image

ROOT = Path(__file__).resolve().parent.parent / "unity6-project/Assets"
KNIGHT = ROOT / "Prototype/KayKit/Characters/knight_texture.png"
ROGUE = ROOT / "Prototype/KayKit/Characters/rogue_texture.png"
OUT = ROOT / "Herois/Cavaleiro"
VERMELHOS = [(0, 1), (2, 2), (5, 1), (7, 0), (0, 3)]  # (coluna, linha): vermelhos (capa, peito), cobre (frente do escudo,
                                                # cabo da espada), 2o aco (ombros, pernas) e o bloco livre (0,3)
                                                # que a malha do elmo passa a usar (CavaleiroSetup.MalhaElmo)
ACO_FRIO = [(3, 0), (2, 1)]           # aco principal (elmo, peito, bracos): puxado para azul-aco, separa do boneco bege
DOURADOS = [(6, 0), (6, 1)]           # couro marrom: cintos/tiras da armadura e borda do escudo -> detalhe dourado


def hex_rgb(h):
	return np.array([int(h[i:i + 2], 16) for i in (1, 3, 5)], dtype=np.float64) / 255.0


def gradiente(lum, paradas):
	xs = np.array([p[0] for p in paradas])
	cols = np.stack([hex_rgb(p[1]) for p in paradas])
	return np.stack([np.interp(lum, xs, cols[:, k]) for k in range(3)], axis=-1)


def normalizar(lum, liso):
	faixa = lum.max() - lum.min()
	if faixa < 0.05:                  # bloco de cor lisa: um tom so do degrade (senao cairia no mais escuro)
		return np.full_like(lum, liso)
	return (lum - lum.min()) / faixa


def cavaleiro():
	img = np.asarray(Image.open(KNIGHT).convert("RGBA")).astype(np.float64) / 255.0
	out = img.copy()
	# azul-roxo: escuro arroxeado embaixo, azul royal no meio, azul claro no brilho (mesma familia das skills)
	paradas = [(0.0, "#1a0f3d"), (0.35, "#2b2a8f"), (0.6, "#2f5fd6"), (1.0, "#8fb8ff")]
	for cx, cy in VERMELHOS:
		bloco = img[cy * 256:(cy + 1) * 256, cx * 128:(cx + 1) * 128, :3]
		lum = bloco @ np.array([0.299, 0.587, 0.114])
		lum = normalizar(lum, 0.55)   # usa a faixa inteira do degrade; bloco liso vira o azul royal
		out[cy * 256:(cy + 1) * 256, cx * 128:(cx + 1) * 128, :3] = gradiente(lum, paradas)
	for cx, cy in ACO_FRIO:
		bloco = out[cy * 256:(cy + 1) * 256, cx * 128:(cx + 1) * 128, :3]
		out[cy * 256:(cy + 1) * 256, cx * 128:(cx + 1) * 128, :3] = bloco * np.array([0.82, 0.9, 1.18])
	ouro = [(0.0, "#5a3a0c"), (0.45, "#b8862a"), (0.8, "#e8c25a"), (1.0, "#fff0a8")]
	for cx, cy in DOURADOS:
		bloco = img[cy * 256:(cy + 1) * 256, cx * 128:(cx + 1) * 128, :3]
		lum = bloco @ np.array([0.299, 0.587, 0.114])
		lum = normalizar(lum, 0.6)
		out[cy * 256:(cy + 1) * 256, cx * 128:(cx + 1) * 128, :3] = gradiente(lum, ouro)
	return out


def boneco():
	img = np.asarray(Image.open(ROGUE).convert("RGBA")).astype(np.float64) / 255.0
	lum = img[..., :3] @ np.array([0.299, 0.587, 0.114])
	cinza = 0.32 + lum * 0.45          # cinza medio, contraste baixo: nada chama atencao
	out = img.copy()
	out[..., :3] = np.stack([cinza, cinza, cinza * 1.02], axis=-1)
	return out


def salvar(nome, img):
	Image.fromarray((np.clip(img, 0, 1) * 255 + 0.5).astype(np.uint8), "RGBA").save(OUT / nome)
	print("gerado", OUT / nome)


if __name__ == "__main__":
	OUT.mkdir(parents=True, exist_ok=True)
	salvar("T_CavaleiroPaleta.png", cavaleiro())
	salvar("T_BonecoPaleta.png", boneco())
