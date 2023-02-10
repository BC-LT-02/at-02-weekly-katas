using System;
namespace Katas.MagnetParticulesInBoxes;
public class Magnets
{
    public static double Doubles(int maxk, int maxn)
    {
        double result = 0;
        for (int k = 1; k <= maxk; k++)
        {
            for (int n = 1; n <= maxn; n++)
            {
                result += 1 / (k * Math.Pow(n + 1, 2 * k));
            }
        }
        return result;
    }
}
