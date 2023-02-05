using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace FromStringsToNumbers;
public class Parser
{
    static Dictionary<string, int> dictionary = new Dictionary<string, int>(){
                {"zero", 0},
                {"one", 1},
                {"two", 2},
                {"three", 3},
                {"four", 4},
                {"five", 5},
                {"six", 6},
                {"seven", 7},
                {"eight", 8},
                {"nine", 9},
                {"ten", 10},
                {"eleven", 11},{"twelve", 12},
                {"thirteen", 13},
                {"fourteen", 14},
                {"fifteen", 15},
                {"sixteen", 16},
                {"seventeen", 17},
                {"eighteen", 18},
                {"nineteen", 19},
                {"twenty", 20},
                {"thirty", 30},
                {"forty", 40},
                {"fifty", 50},
                {"sixty", 60},
                {"seventy", 70},
                {"eighty", 80},
                {"ninety", 90},
                {"hundred", 100},
                {"thousand", 1000},
                {"million", 1000000}
    };

    static Dictionary<string, int> spliter = new Dictionary<string, int>(){
        {"thousand" , 1000},
        {"million" , 1000000}
    };
    public static int ParseInt(string s)
    {
        s = s.Replace("-", " ");
        s = s.Replace(" and ", " ");
        string[] words = s.Split(" ");

        int result = 0;
        int current = 0;
        for (int i = 0; i < words.Length; i++)
        {
            if (spliter.ContainsKey(words[i]))
            {
                if (current == 0)
                {
                    current = 1;
                }
                current *= dictionary[words[i]];
                result += current;
                current = 0;
            }
            else
            {
                if (words[i] == "hundred")
                {
                    if (current == 0)
                    {
                        current = 1;
                    }
                    current *= dictionary[words[i]];
                }
                else
                {
                    current += dictionary[words[i]];
                }
            }
        }
        result += current;
        return result;
    }
}