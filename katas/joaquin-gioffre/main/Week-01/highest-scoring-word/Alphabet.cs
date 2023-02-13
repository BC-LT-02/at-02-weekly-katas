namespace Week1;

using System.Collections.Generic;

public class Alphabet
{
    char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    int value = 1;
    public Dictionary<string,int> alphabet = new Dictionary<string, int>();

    public Alphabet()
    {
        foreach(char letter in letters)
        {
            alphabet.Add(letter.ToString(), value);
            value++;
        }
    }
}