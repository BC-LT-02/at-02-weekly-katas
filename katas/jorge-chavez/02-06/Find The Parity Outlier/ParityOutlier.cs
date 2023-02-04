namespace katas.JorgeChavez;

public class ParityOutlier
{
    public static int Find(int[] integers)
    {
        var pairs = integers.Where(num => num % 2 == 0);
        var odds = integers.Where(num => num % 2 != 0);
        return pairs.Count() == 1 ? pairs.First() : odds.First();
    }
}
