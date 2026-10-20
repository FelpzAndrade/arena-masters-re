using System.IO;
using System.Linq;
using System.Text;
using CS;
using UnityEditor;

// Verificacao da fatia 1 (country_xml e download_img_xml) contra valores calculados direto dos XMLs.
public static class Slice1Check
{
	[MenuItem("Arena Masters/Verificar fatia 1 (tabelas)")]
	public static void Run()
	{
		CSLog.Init(new CSLogger());
		StringBuilder sb = new StringBuilder();

		XProtoInfoManager_Country country = new XProtoInfoManager_Country();
		bool loaded = country.LoadFromLocalFile(new XFileLoader_UnityResource(XProtoInfoManagers.GetFilePath(ProtoInfoTypes.Country)));
		country.Cooking(null);
		sb.AppendLine($"country|loaded={loaded}|count={country.Count}"
			+ $"|default={country.GetDefaultCountry().countryCode}|br_flag={country.GetFlagIconbyCountryCode("br")}"
			+ $"|unknown_flag={country.GetFlagIconbyCountryCode("ZZ")}"
			+ $"|kr={country.RecommendRegion("KR")}|br={country.RecommendRegion("BR")}|af={country.RecommendRegion("AF")}|empty={country.RecommendRegion("")}"
			+ $"|matching={country.Values.Count(c => c.IsMatchingSupplementation)}|paylaw={country.Values.Count(c => c.IsPayLaw)}");

		XProtoInfoManager_DownloadImg img = new XProtoInfoManager_DownloadImg();
		loaded = img.LoadFromLocalFile(new XFileLoader_UnityResource(XProtoInfoManagers.GetFilePath(ProtoInfoTypes.DownloadImg)));
		string langs = string.Join(",", img.Keys.OrderBy(k => k));
		var ko = img.GetDownloadImgListsByLanguage("ko-KR");
		var fallback = img.GetDownloadImgListsByLanguage("pt-BR");
		int pages = img.Values.Sum(e => e.Values.Sum(x => x.PageCount));
		int imgs = img.Values.Sum(e => e.Values.Sum(x => Enumerable.Range(0, 1000).Select(x.GetPageInfo).Where(p => p != null).Sum(p => p.ImgCount)));
		int texts = img.Values.Sum(e => e.Values.Sum(x => Enumerable.Range(0, 1000).Select(x.GetPageInfo).Where(p => p != null).Sum(p => p.TextCount)));
		XDownloadImgDisplayInfo first = ko[1].GetPageInfo(1).GetDisplayInfos()[0];
		sb.AppendLine($"download|loaded={loaded}|langs={langs}|ko_eps={ko.Count}|fallback_eps={fallback.Count}|pages={pages}|imgs={imgs}|texts={texts}"
			+ $"|first_text={first.Text.Replace("\n", "\n")}|first_font={first.FontSize}|first_pos={first.Position.x:0.##},{first.Position.y:0.##}");

		File.WriteAllText("C:/Users/felip/arena-masters-re/decomp/slice1_result.txt", sb.ToString());
		UnityEngine.Debug.Log("Fatia 1:\n" + sb);
	}
}
