namespace katas.AdrielGimenes;

public class Rot13
{
    public static string Cipher(string message)
    {
        List<char> abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToList();
        List<char> rot = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm".ToList();
        string res = "";

        for (int i = 0; i < message.Length; i++)
        {
            if (abc.Contains(message[i]))
            {
                res += rot[abc.IndexOf(message[i])];
            }
            else res += message[i];
        }
        return res;
    }
}
