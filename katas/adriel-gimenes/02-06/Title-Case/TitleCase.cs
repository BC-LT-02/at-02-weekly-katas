namespace katas.AdrielGimenes;

public class TitleCase
{
    public static string TitleCases(string title, string minorWords = "")
    {
        minorWords = minorWords == null ? "" : minorWords;
        if (String.IsNullOrEmpty(title)) return "";
        var words = title.ToLower().Split(' ');
        var exceptions = minorWords.ToLower().Split(' ');

        var newWords = words.Select((word, i) =>
        {
            return (i == 0 || !exceptions.Contains(word)) ? Capitalize(word) : word;
        });

        return String.Join(" ", newWords);
    }

    private static string Capitalize(string str)
    {
        return str.First().ToString().ToUpper() + str.Substring(1);
    }
}
