using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

public class RomanDecode
{
    public static int Solution(string roman)
    {
        var dictionary = new Dictionary<char, int>();
        dictionary.Add('I', 1);
        dictionary.Add('V', 5);
        dictionary.Add('X', 10);
        dictionary.Add('L', 50);
        dictionary.Add('C', 100);
        dictionary.Add('D', 500);
        dictionary.Add('M', 1000);

        var result = 0;
        for (var i = 0; i < roman.Length; i++)
        {
            int currentValue = dictionary[roman[i]];
            int nextValue = (i + 1 < roman.Length) ? dictionary[roman[i + 1]] : 0;
            if (currentValue < nextValue)
            {
                result -= currentValue;
            }
            else
            {
                result += currentValue;
            }
        }
        return (result);
    }
}
