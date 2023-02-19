using System;

namespace JustifyText;

public class JustifyTextClass
{
    public static string Justify(string str, int width)
    {
        try
        {
            string[] words = str.Split(' ');
            int currentLineLength = 0;
            string result = "";

            foreach (string word in words)
            {
                if (currentLineLength + word.Length + 1 > width)
                {
                    result += Environment.NewLine;
                    currentLineLength = 0;
                }
                else if (currentLineLength > 0)
                {
                    result += "  ";
                    currentLineLength++;
                }

                result += word;
                currentLineLength += word.Length;
            }

            return result;
        }
        catch (NullReferenceException e)
        {
            throw e;
        }
    }
}
