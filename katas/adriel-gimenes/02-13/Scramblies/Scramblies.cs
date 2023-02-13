namespace katas.AdrielGimenes;

public class Scramblies 
{
    public static bool Scramble(string str1, string str2) 
    {
        return str2.ToArray().All(letter => str2.Split(letter).Length <= str1.Split(letter).Length);
    }
}
