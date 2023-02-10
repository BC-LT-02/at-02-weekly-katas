using System;
using System.Linq;

public class Kata
{
    public static string SpinWords(string sentence)
    {
        return string.Join(
            " ",
            sentence.Split().Select(x => x.Length < 5 ? x : new string(x.Reverse().ToArray()))
        );
    }
}
