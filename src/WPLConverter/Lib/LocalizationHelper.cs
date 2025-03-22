namespace WPLConverter.Lib;

using System.Globalization;
using System.Resources;

public class LocalizationHelper
{
    private static readonly ResourceManager ResourceManager = new(
        "WPLConverter.Converter",
        typeof(LocalizationHelper).Assembly
    );

    public static string GetString(string key)
    {
        return ResourceManager.GetString(key, CultureInfo.CurrentUICulture);
    }
}
