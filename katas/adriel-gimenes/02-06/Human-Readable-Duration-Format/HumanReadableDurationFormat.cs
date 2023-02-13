namespace katas.AdrielGimenes;

public class HumanTimeFormat
{
    public static string FormatDuration(int seconds)
    {
        if (seconds == 0) return "now";
        int[] units = new int[] { 31536000, 86400, 3600, 60, 1 };
        string[] unitNames = new string[] { "year", "day", "hour", "minute", "second" };
        string res = "";

        for (int i = 0; i < units.Length; i++)
        {
            int numberOfUnits = seconds / units[i];
            if (numberOfUnits > 0)
            {
                seconds %= units[i];
                res += numberOfUnits + " " + unitNames[i] + (numberOfUnits > 1 ? "s" : "");
                res += seconds > 0 ? ", " : "";
            }
        }
        int commaIndex = res.LastIndexOf(", ");
        return commaIndex == -1 ? res : res.Remove(commaIndex, 2).Insert(commaIndex, " and ");
    }
}
