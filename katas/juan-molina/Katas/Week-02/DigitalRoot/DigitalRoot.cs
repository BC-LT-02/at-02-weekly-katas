using System;
using System.Linq;

public class Number
{
    public static int DigitalRoot(long n)
    {
        string curr = n.ToString();

        while (curr.Count() > 1)
        {
            curr = curr.Select(x => Convert.ToInt64(x.ToString())).Sum().ToString();
        }

        return Convert.ToInt32(curr);
    }
}
