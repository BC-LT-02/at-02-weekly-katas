namespace katas.JorgeChavez;

public class ROT13
{
    public static string Rot13(string message)
    {
        var alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        var code = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm";
        var answer = "";

        for (var i = 0; i < message.Length; i++)
        {
            var codeIndex = alpha.IndexOf(message[i]);

            if (codeIndex > -1)
            {
                answer += code[codeIndex];
            }
            else
            {
                answer += message[i];
            }
        }
        return answer;
    }
}
