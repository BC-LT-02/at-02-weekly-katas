namespace katas.JorgeChavez;

public class Brace
{
    public static bool validBraces(String braces)
    {
        Console.WriteLine("Braces: " + braces);
        Stack<string> openBraces = new Stack<string>();
        for (int i = 0; i < braces.Length; i++)
        {
            if (braces[i] == '(' || braces[i] == '[' || braces[i] == '{')
            {
                openBraces.Push(braces[i].ToString());
            }
            switch (braces[i].ToString())
            {
                case ")":
                    if (openBraces.Count == 0 || openBraces.Pop() != "(")
                        return false;
                    continue;
                case "]":
                    if (openBraces.Count == 0 || openBraces.Pop() != "[")
                        return false;
                    continue;
                case "}":
                    if (openBraces.Count == 0 || openBraces.Pop() != "{")
                        return false;
                    continue;
                default:
                    continue;
            }
        }
        return openBraces.Count == 0;
    }
}
