//https://www.codewars.com/kata/5287e858c6b5a9678200083c/csharp
using System.Linq;
using System;

public class Kata
{
    public static bool Narcissistic(int value)
    {
        char[] chars = value.ToString().ToArray();

        int count = 0;
        foreach (char x in chars)
        {
            count += pow((int)Char.GetNumericValue(x), chars.Count());
        }

        return count == value;
    }

    public static int pow(int nBase, int power)
    {
        int res = 1;
        for (int i = 0; i < power; i++)
        {
            res *= nBase;
        }
        return res;
    }
}
