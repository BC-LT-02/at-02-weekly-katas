namespace katas.JorgeChavez;

public class Hamming
{
    public static int Distance(string a, string b)
    {
        var count = 0;
        for (var i = 0; i < a.Length; i++)
        {
            count += a[i] == b[i] ? 0 : 1;
        }
        return count;
    }
}
