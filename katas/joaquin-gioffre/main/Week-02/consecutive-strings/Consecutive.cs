namespace Week2;

public class Consecutive
{
    public static string GetLongestConsecutive(string[] strarr, int k)
    {
        if (strarr.Length == 0 || k > strarr.Length || k <= 0)
        {
            return "";
        }

        string longestConsec = "";

        for (int i = 0; i <= strarr.Length - k; i++)
        {
            string currentConsec = string.Join("", strarr.Skip(i).Take(k));
            if (currentConsec.Length > longestConsec.Length)
            {
                longestConsec = currentConsec;
            }
        }

        return longestConsec;
    }
}