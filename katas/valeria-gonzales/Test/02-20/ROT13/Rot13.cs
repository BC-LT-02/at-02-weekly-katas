namespace Rot13Decoding;
public class Rot13
{
    public static string Decode(string input)
    {
        char[] result = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];

            if (currentChar >= 'A' && currentChar <= 'Z')
            {
                result[i] = (char)(((currentChar - 'A' + 13) % 26) + 'A');
            }
            else if (currentChar >= 'a' && currentChar <= 'z')
            {
                result[i] = (char)(((currentChar - 'a' + 13) % 26) + 'a');
            }
            else
            {
                result[i] = currentChar;
            }
        }

        return new string(result);

    }
}