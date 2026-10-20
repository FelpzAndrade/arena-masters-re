# Texturas do mapa (Assets/Map/Textures), estilo da referencia (paleta.png do Arena Masters: ambiente quente e escuro).
#   T_MasmorraQuente.png  a textura-paleta do KayKit Dungeon com as faixas de pedra cinza-azulada trocadas por
#                         marrom/ocre (luminancia -> degrade da paleta); madeira, estandartes e musgo ficam iguais
#   T_DecalRachadura.png  rachaduras escuras no chao (RGB escuro, A = rachadura)
#   T_DecalMancha.png     mancha de sujeira/queimado (RGB marrom escuro, A = mancha macia com borda irregular)
#   T_DecalSelo.png       selo circular grande do centro (aneis, cruz e runas; RGB dourado gasto, A = desenho)
# Uso: tools/venv/Scripts/python.exe -I tools/gen_map_textures.py
from pathlib import Path

import numpy as np
from PIL import Image, ImageDraw, ImageFilter

ROOT = Path(__file__).resolve().parent.parent / "unity6-project/Assets"
ATLAS = ROOT / "Prototype/Resources/KayKitDungeon/dungeon_texture.png"
OUT = ROOT / "Map/Textures"
RNG = np.random.default_rng(31)

# degrade da paleta da referencia (escuro -> claro)
STOPS = [(0.0, "#1b1313"), (0.22, "#3d251a"), (0.42, "#573e2a"), (0.62, "#8a6a48"), (0.82, "#b8915a"), (1.0, "#d0a759")]
# celulas da paleta (coluna, linha) em blocos de 128 x 256 que sao pedra cinza/azulada
STONE_CELLS = [(0, 0), (1, 0), (3, 0), (5, 0), (0, 1), (2, 1)]


def hex_rgb(h):
	return np.array([int(h[i:i + 2], 16) for i in (1, 3, 5)], dtype=np.float64) / 255.0


def gradient(lum):
	xs = np.array([s[0] for s in STOPS])
	cols = np.stack([hex_rgb(s[1]) for s in STOPS])
	return np.stack([np.interp(lum, xs, cols[:, k]) for k in range(3)], axis=-1)


def smoothstep(a, b, x):
	t = np.clip((x - a) / (b - a), 0.0, 1.0)
	return t * t * (3.0 - 2.0 * t)


def recolor_atlas():
	img = np.asarray(Image.open(ATLAS).convert("RGBA")).astype(np.float64) / 255.0
	out = img.copy()
	for cx, cy in STONE_CELLS:
		block = img[cy * 256:(cy + 1) * 256, cx * 128:(cx + 1) * 128, :3]
		lum = block @ np.array([0.299, 0.587, 0.114])
		warm = gradient(np.clip(lum * 1.05, 0, 1))
		out[cy * 256:(cy + 1) * 256, cx * 128:(cx + 1) * 128, :3] = warm * 0.88 + block * 0.12
	Image.fromarray((np.clip(out, 0, 1) * 255 + 0.5).astype(np.uint8), "RGBA").save(OUT / "T_MasmorraQuente.png")


def save(name, rgb, alpha):
	img = np.dstack([np.clip(rgb, 0, 1), np.clip(alpha, 0, 1)])
	Image.fromarray((img * 255 + 0.5).astype(np.uint8), "RGBA").save(OUT / name)
	print("gerado", OUT / name)


def periodic_noise(size, freq):
	grid = RNG.random((freq, freq))
	c = np.arange(size) * freq / size
	i0 = np.floor(c).astype(int)
	f = c - i0
	f = f * f * (3 - 2 * f)
	i1 = (i0 + 1) % freq
	top = grid[np.ix_(i0, i0)] * (1 - f[None, :]) + grid[np.ix_(i0, i1)] * f[None, :]
	bot = grid[np.ix_(i1, i0)] * (1 - f[None, :]) + grid[np.ix_(i1, i1)] * f[None, :]
	return top * (1 - f[:, None]) + bot * f[:, None]


def fbm(size):
	n = sum(periodic_noise(size, f) * a for f, a in ((4, 1), (8, 0.5), (16, 0.25), (32, 0.125)))
	return (n - n.min()) / (n.max() - n.min())


def crack(size=512):
	s = 2
	big = size * s
	img = Image.new("L", (big, big), 0)
	d = ImageDraw.Draw(img)

	def line(x, y, ang, length, width, depth):
		steps = max(3, int(length / 30))
		for _ in range(steps):
			ang += RNG.normal(0, 0.25)
			nx, ny = x + np.cos(ang) * length / steps, y + np.sin(ang) * length / steps
			d.line([(x, y), (nx, ny)], fill=255, width=max(1, int(width)))
			if depth > 0 and RNG.random() < 0.25:
				line(nx, ny, ang + RNG.choice([-1, 1]) * RNG.uniform(0.5, 1.1), length * 0.45, width * 0.6, depth - 1)
			x, y = nx, ny
			width *= 0.88

	c = big / 2
	for _ in range(3):
		ang = RNG.uniform(0, 2 * np.pi)
		line(c, c, ang, big * RNG.uniform(0.3, 0.45), 9 * s, 2)
	a = np.asarray(img.filter(ImageFilter.GaussianBlur(1.2)).resize((size, size), Image.LANCZOS)) / 255.0
	y, x = np.mgrid[0:size, 0:size]
	r = np.sqrt((x - size / 2) ** 2 + (y - size / 2) ** 2) / (size / 2)
	a *= 1 - smoothstep(0.8, 0.98, r)
	return np.full((size, size, 3), 0.06), a * 0.9


def stain(size=256):
	y, x = np.mgrid[0:size, 0:size]
	r = np.sqrt((x - size / 2) ** 2 + (y - size / 2) ** 2) / (size / 2)
	n = fbm(size)
	a = smoothstep(0.95, 0.35, r + (n - 0.5) * 0.55) * (0.55 + 0.45 * n)
	rgb = np.stack([0.13 + 0.05 * n, 0.08 + 0.03 * n, 0.05 + 0.02 * n], axis=-1)
	return rgb, a * 0.75


def seal(size=1024):
	# selo de pedra gravado: aneis, cruz com pontas, marcas de runa no anel externo
	s = 2
	big = size * s
	img = Image.new("L", (big, big), 0)
	d = ImageDraw.Draw(img)
	c = big / 2

	def ring(rad, w):
		d.ellipse([c - rad, c - rad, c + rad, c + rad], outline=255, width=int(w))

	ring(big * 0.48, 14 * s)
	ring(big * 0.44, 5 * s)
	ring(big * 0.30, 10 * s)
	ring(big * 0.13, 8 * s)
	# runas: tracos curtos entre os aneis externos
	for k in range(36):
		a = k * 2 * np.pi / 36
		r0, r1 = big * 0.36, big * 0.42
		off = RNG.uniform(-0.04, 0.04)
		d.line([(c + np.cos(a) * r0, c + np.sin(a) * r0), (c + np.cos(a + off) * r1, c + np.sin(a + off) * r1)], fill=255, width=4 * s)
		if k % 3 == 0:
			rr = big * 0.39
			d.ellipse([c + np.cos(a) * rr - 6 * s, c + np.sin(a) * rr - 6 * s, c + np.cos(a) * rr + 6 * s, c + np.sin(a) * rr + 6 * s], outline=255, width=3 * s)
	# cruz em X com pontas de seta (como o selo da referencia)
	for k in range(4):
		a = np.pi / 4 + k * np.pi / 2
		ux, uy = np.cos(a), np.sin(a)
		px, py = -uy, ux
		r0, r1 = big * 0.14, big * 0.29
		w = big * 0.035
		pts = [(c + ux * r0 + px * w, c + uy * r0 + py * w), (c + ux * (r1 - w * 2) + px * w, c + uy * (r1 - w * 2) + py * w),
		       (c + ux * (r1 - w * 2) + px * w * 2.2, c + uy * (r1 - w * 2) + py * w * 2.2), (c + ux * r1, c + uy * r1),
		       (c + ux * (r1 - w * 2) - px * w * 2.2, c + uy * (r1 - w * 2) - py * w * 2.2), (c + ux * (r1 - w * 2) - px * w, c + uy * (r1 - w * 2) - py * w),
		       (c + ux * r0 - px * w, c + uy * r0 - py * w)]
		d.polygon(pts, outline=255, width=6 * s)
	lines = np.asarray(img.filter(ImageFilter.GaussianBlur(1.5)).resize((size, size), Image.LANCZOS)) / 255.0
	y, x = np.mgrid[0:size, 0:size]
	r = np.sqrt((x - size / 2) ** 2 + (y - size / 2) ** 2) / (size / 2)
	disc = smoothstep(0.99, 0.95, r) * 0.55                 # pedra do selo mais escura que o chao
	n = fbm(size)
	wear = 0.65 + 0.35 * smoothstep(0.25, 0.75, n)          # gasto pelo tempo
	a = np.clip(np.maximum(disc, lines) * wear, 0, 1)
	gold = np.clip(hex_rgb("#d0a759") * 1.25, 0, 1)        # dourado claro: a luz da masmorra e escura
	dark = hex_rgb("#2a1a12")
	rgb = dark[None, None, :] * (1 - lines[..., None]) + gold[None, None, :] * lines[..., None]
	return rgb, a


def main():
	OUT.mkdir(parents=True, exist_ok=True)
	recolor_atlas()
	print("gerado", OUT / "T_MasmorraQuente.png")
	save("T_DecalRachadura.png", *crack())
	save("T_DecalMancha.png", *stain())
	save("T_DecalSelo.png", *seal())


if __name__ == "__main__":
	main()
