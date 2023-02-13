using System.Linq;

public static class Kata
{
    public static int Solution(int value)
    {
        return value >= 0
            ? Enumerable.Range(0, value).Where(x => (x % 3 == 0 || x % 5 == 0)).Sum()
            : 0;
    }
}
