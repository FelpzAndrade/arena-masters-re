// Decompila uma lista de enderecos (RVA) e grava pseudo-C + referencias.
// Uso: -postScript ExportDecomp.java <entrada.txt> <saida.c>
// Entrada: uma linha por alvo, "0xRVA" ou "0xRVA nome"; linhas "xref 0xRVA" listam quem referencia o endereco.
//@category Il2Cpp

import java.io.PrintWriter;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import ghidra.app.decompiler.DecompInterface;
import ghidra.app.decompiler.DecompileResults;
import ghidra.app.script.GhidraScript;
import ghidra.program.model.address.Address;
import ghidra.program.model.listing.Function;
import ghidra.program.model.symbol.Reference;
import ghidra.program.model.symbol.Symbol;

public class ExportDecomp2 extends GhidraScript {

	// Acesso PIC do ARM32 aos slots de metadados do IL2CPP: *(DAT_off + DAT_got + pc).
	private static final Pattern PIC = Pattern.compile(
		"\\(DAT_([0-9a-f]{8}) \\+ DAT_([0-9a-f]{8}) \\+ 0x([0-9a-f]+)\\)");

	/** Resolve o slot apontado pela GOT e anota com o rotulo/valor aplicado pelo Il2CppImport. */
	private static final Pattern BASE = Pattern.compile("(\\w+) = (DAT_[0-9a-f]{8}) \\+ (0x[0-9a-f]+);");
	private static final Pattern USE = Pattern.compile("\\((DAT_[0-9a-f]{8}) \\+ (\\w+)\\)");

	/** Expande "iVarN = DAT_g + 0xpc; ... (DAT_o + iVarN)" para a forma que o PIC resolve. */
	private String inlineBases(String c) {
		java.util.Map<String, String> base = new java.util.HashMap<>();
		StringBuilder out = new StringBuilder();
		for (String line : c.split("\n", -1)) {
			Matcher u = USE.matcher(line);
			StringBuilder lb = new StringBuilder();
			while (u.find()) {
				String b = base.get(u.group(2));
				u.appendReplacement(lb, Matcher.quoteReplacement(b == null ? u.group(0) : "(" + u.group(1) + " + " + b + ")"));
			}
			u.appendTail(lb);
			Matcher a = BASE.matcher(line);
			if (a.find()) {
				base.put(a.group(1), a.group(2) + " + " + a.group(3));
			}
			out.append(lb).append("\n");
		}
		return out.toString();
	}

	private String annotate(String c) {
		c = inlineBases(c);
		Matcher m = PIC.matcher(c);
		StringBuilder sb = new StringBuilder();
		while (m.find()) {
			String note = "";
			try {
				long a = getInt(toAddr(Long.parseLong(m.group(1), 16))) & 0xffffffffL;
				long b = getInt(toAddr(Long.parseLong(m.group(2), 16))) & 0xffffffffL;
				long got = (a + b + Long.parseLong(m.group(3), 16)) & 0xffffffffL;
				Address slot = toAddr(getInt(toAddr(got)) & 0xffffffffL);
				Symbol s = getSymbolAt(slot);
				String eol = getEOLComment(slot);
				if (s != null && s.getName().startsWith("StringLiteral_") && eol != null) {
					note = "/*\"" + eol.replace("*/", "* /") + "\"*/";
				} else if (s != null) {
					note = "/*" + s.getName() + "*/";
				}
			} catch (Exception e) {
				// endereco fora do mapa: deixa sem anotacao
			}
			m.appendReplacement(sb, Matcher.quoteReplacement(m.group(0) + note));
		}
		m.appendTail(sb);
		return sb.toString();
	}

	@Override
	protected void run() throws Exception {
		String[] args = getScriptArgs();
		DecompInterface decomp = new DecompInterface();
		decomp.openProgram(currentProgram);
		try (PrintWriter out = new PrintWriter(Files.newBufferedWriter(Path.of(args[1]), StandardCharsets.UTF_8))) {
			for (String raw : Files.readAllLines(Path.of(args[0]), StandardCharsets.UTF_8)) {
				String line = raw.trim();
				if (line.isEmpty() || line.startsWith("#")) {
					continue;
				}
				boolean xref = line.startsWith("xref ");
				String[] parts = (xref ? line.substring(5) : line).split("\\s+", 2);
				Address a = currentProgram.getImageBase().add(Long.decode(parts[0]));
				if (xref) {
					out.println("// ==== XREFS -> " + parts[0] + (parts.length > 1 ? " " + parts[1] : ""));
					for (Reference r : getReferencesTo(a)) {
						Function f = getFunctionContaining(r.getFromAddress());
						long rva = r.getFromAddress().subtract(currentProgram.getImageBase());
						out.printf("//   from 0x%X in %s%n", rva, f == null ? "?" : f.getName() + " @0x"
							+ Long.toHexString(f.getEntryPoint().subtract(currentProgram.getImageBase())).toUpperCase());
					}
					continue;
				}
				Function f = getFunctionAt(a);
				if (f == null) {
					f = createFunction(a, null);
				}
				out.println("// ==== " + parts[0] + " " + (f == null ? "?" : f.getName()));
				if (f == null) {
					out.println("// (sem funcao)");
					continue;
				}
				DecompileResults res = decomp.decompileFunction(f, 120, monitor);
				out.println(res.decompileCompleted() ? annotate(res.getDecompiledFunction().getC()) : "// falhou: " + res.getErrorMessage());
			}
		}
		decomp.dispose();
	}
}
