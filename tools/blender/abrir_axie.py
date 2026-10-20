# Abre o Blender com o Axie (KayKit Barbarian) e liga o servidor do BlenderMCP.
# Uso: blender.exe tools/blender/axie.blend --python tools/blender/abrir_axie.py
#   (sem o .blend, importa o Barbarian.fbx do zero)
import bpy

FBX = r"C:\Users\felip\arena-masters-re\unity6-project\Assets\Prototype\KayKit\Characters\Barbarian.fbx"


def ligar():
    try:
        bpy.ops.blendermcp.start_server()
        print("[abrir_axie] servidor MCP ligado")
    except Exception as e:
        print("[abrir_axie] nao ligou:", e)
    return None


def importar():
    if "Rig" in bpy.data.objects:
        return None                    # cena salva ja aberta
    for ob in list(bpy.data.objects):
        bpy.data.objects.remove(ob, do_unlink=True)
    bpy.ops.import_scene.fbx(filepath=FBX)
    bpy.context.scene.render.fps = 30
    print("[abrir_axie] importado:", [o.name for o in bpy.data.objects])
    return None


bpy.app.timers.register(ligar, first_interval=1.0)
bpy.app.timers.register(importar, first_interval=1.5)
