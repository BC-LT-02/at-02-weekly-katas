namespace katas.AdrielGimenes;

public class SimplePigLatin
{
    public static string PigIt(string str)
    {
        return String.Join(" ", str
            .Split(" ")
            .ToList()
            .Select(e => e != "!" ? e.Substring(1) + e.First() + "ay" : e));
    }
}
