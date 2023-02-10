namespace ProperFractions;
public class ProperFractionsSolution
{
    public static long ProperFractions(long n)
    {
        if (n <= 1) return 0;

        long count = 0;
        long numerator = 0;
        while (numerator < n)
        {
            long MaxComDiv = MCD(numerator, n);
            if (MaxComDiv == 1)
            {
                count++;
            }
            numerator++;
        }
        return count;
    }

    static long MCD(long n, long d) => d == 0 ? n : MCD(d, n % d);
}