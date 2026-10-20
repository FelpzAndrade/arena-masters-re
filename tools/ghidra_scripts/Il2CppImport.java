// Porte em Java do ghidra.py do Il2CppDumper, para uso headless.
// Uso: -preScript Il2CppImport.java <caminho do script.json>
//@category Il2Cpp

import java.io.FileReader;

import com.google.gson.JsonArray;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParser;

import ghidra.app.script.GhidraScript;
import ghidra.program.model.address.Address;
import ghidra.program.model.symbol.SourceType;

public class Il2CppImport extends GhidraScript {

	private Address addr(JsonElement offset) {
		return currentProgram.getImageBase().add(offset.getAsLong());
	}

	private void setName(Address a, String name) throws Exception {
		createLabel(a, name.replace(' ', '-'), true, SourceType.USER_DEFINED);
	}

	@Override
	protected void run() throws Exception {
		String path = getScriptArgs().length > 0 ? getScriptArgs()[0] : askFile("script.json", "Open").getAbsolutePath();
		JsonObject data;
		try (FileReader r = new FileReader(path, java.nio.charset.StandardCharsets.UTF_8)) {
			data = JsonParser.parseReader(r).getAsJsonObject();
		}

		if (data.has("ScriptMethod")) {
			JsonArray arr = data.getAsJsonArray("ScriptMethod");
			monitor.initialize(arr.size(), "Methods");
			for (JsonElement e : arr) {
				JsonObject m = e.getAsJsonObject();
				setName(addr(m.get("Address")), m.get("Name").getAsString());
				monitor.increment();
			}
			println("Methods: " + arr.size());
		}

		if (data.has("ScriptString")) {
			JsonArray arr = data.getAsJsonArray("ScriptString");
			monitor.initialize(arr.size(), "Strings");
			int index = 1;
			for (JsonElement e : arr) {
				JsonObject s = e.getAsJsonObject();
				Address a = addr(s.get("Address"));
				createLabel(a, "StringLiteral_" + index++, true, SourceType.USER_DEFINED);
				setEOLComment(a, s.get("Value").getAsString());
				monitor.increment();
			}
			println("Strings: " + arr.size());
		}

		for (String key : new String[] { "ScriptMetadata", "ScriptMetadataMethod" }) {
			if (!data.has(key)) {
				continue;
			}
			JsonArray arr = data.getAsJsonArray(key);
			monitor.initialize(arr.size(), key);
			for (JsonElement e : arr) {
				JsonObject m = e.getAsJsonObject();
				Address a = addr(m.get("Address"));
				String name = m.get("Name").getAsString();
				setName(a, name);
				setEOLComment(a, name);
				monitor.increment();
			}
			println(key + ": " + arr.size());
		}

		if (data.has("Addresses")) {
			JsonArray arr = data.getAsJsonArray("Addresses");
			monitor.initialize(arr.size(), "Functions");
			int created = 0;
			for (int i = 0; i < arr.size() - 1; i++) {
				Address a = addr(arr.get(i));
				if (getFunctionAt(a) == null && createFunction(a, null) != null) {
					created++;
				}
				monitor.increment();
			}
			println("Functions created: " + created + " / " + (arr.size() - 1));
		}
		println("Il2CppImport finished");
	}
}
