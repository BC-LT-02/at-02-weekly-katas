namespace katas.JorgeChavez;

public class Number
{
    public static int DigitalRoot(long n)
    {
        string numText = n.ToString();
        int lengthNum = numText.Length;
        while (lengthNum >= 2)
        {
            long sum = 0;
            while (n > 0)
            {
                sum += (n % 10);
                n /= 10;
            }
            n = sum;
            numText = n.ToString();
            lengthNum = numText.Length;
        }
        return Convert.ToInt32(n);
    }
}
