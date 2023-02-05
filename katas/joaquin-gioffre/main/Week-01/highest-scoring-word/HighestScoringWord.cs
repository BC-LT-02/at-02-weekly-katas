namespace Week1;

using System.Collections.Generic;

public class HighestScoringWord
{
    string Word = "";
    int HighestScore = 0;

    public int GetWordScore(string word, Dictionary<string, int> alphabet)
    {
        int score = 0;
        foreach(char character in word)
        {
            if(alphabet.ContainsKey(character.ToString()))
            {
                score += alphabet[character.ToString()];
            }
        }

        return score;
    }

    public string GetHighestScoringWord(string words, Dictionary<string, int> alphabet)
    {
        string[] allWords = words.Split(" ").ToArray();
        foreach(string w in allWords)
        {
            if(GetWordScore(w, alphabet) > HighestScore)
            {
                Word = w;
                HighestScore = GetWordScore(w, alphabet);
            }
        }
        HighestScore = 0;

        return Word;
    }
    
}