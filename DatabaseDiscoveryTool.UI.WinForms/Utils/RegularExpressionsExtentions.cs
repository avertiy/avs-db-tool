using System.Text.RegularExpressions;

namespace DatabaseDiscoveryTool.UI.WinForms.Utils
{
    public static class RegularExpressionsExtentions
    {
        public static string GetValue(this Match match, string groupname)
        {
            if (match.Groups[groupname].Success)
                return match.Groups[groupname].Value;
            return string.Empty;
        }
    }
}