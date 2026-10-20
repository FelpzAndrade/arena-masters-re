# Corrige tipos de layout explicito sem ClassLayout gerados pelo Il2CppDumper
# (ex.: __StaticArrayInitTypeSize=N, $ArrayType=N), que derrubam o Mono do Unity 5.4.
param([string]$PluginsDir, [string]$BackupDir)

Add-Type -Path "C:\Users\felip\arena-masters-re\tools\Il2CppDumper\Mono.Cecil.dll"
New-Item -ItemType Directory -Force $BackupDir | Out-Null

foreach ($dll in Get-ChildItem $PluginsDir -Filter *.dll) {
    $bytes = [IO.File]::ReadAllBytes($dll.FullName)
    $ms = New-Object IO.MemoryStream(, $bytes)
    $rp = New-Object Mono.Cecil.ReaderParameters
    $rp.AssemblyResolver = New-Object Mono.Cecil.DefaultAssemblyResolver
    $asm = [Mono.Cecil.AssemblyDefinition]::ReadAssembly($ms, $rp)
    $fixed = 0
    foreach ($t in $asm.MainModule.GetTypes()) {
        if ($t.IsExplicitLayout -and $t.Fields.Count -eq 0 -and $t.ClassSize -le 0) {
            if ($t.Name -match '=(\d+)$') {
                $t.ClassSize = [int]$Matches[1]
                $t.PackingSize = 1
            } else {
                $t.IsExplicitLayout = $false
                $t.IsSequentialLayout = $true
            }
            $fixed++
        }
    }
    if ($fixed -gt 0) {
        Copy-Item $dll.FullName (Join-Path $BackupDir $dll.Name) -Force
        $asm.Write($dll.FullName)
        "{0}: {1} tipos corrigidos" -f $dll.Name, $fixed
    }
    $asm.Dispose()
}
