using HtmlAgilityPack;
using System.Text.RegularExpressions;
using System.Web;

namespace ProjectEuler.Core.IO
{
    public static class HtmlConverter
    {
        public static string HtmlToText(string HTMLText, bool decode = true)
        {
            Regex reg = new Regex("<[^>]+>", RegexOptions.IgnoreCase);
            var stripped = reg.Replace(HTMLText, "");
            return decode ? HttpUtility.HtmlDecode(stripped) : stripped;
        }
    }
}