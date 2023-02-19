namespace SumOfIntervals;
public class Intervals
{
    public static int SumIntervals((int, int)[] intervals)
    {
        // Sort the intervals by their start value
        Array.Sort(intervals, (a, b) => a.Item1.CompareTo(b.Item1));

        // Merge the overlapping intervals
        var mergedIntervals = new List<(int, int)>();
        foreach (var interval in intervals)
        {
            if (mergedIntervals.Count == 0 || mergedIntervals[^1].Item2 < interval.Item1)
            {
                mergedIntervals.Add(interval);
            }
            else if (mergedIntervals[^1].Item2 < interval.Item2)
            {
                mergedIntervals[^1] = (mergedIntervals[^1].Item1, interval.Item2);
            }
        }

        // Calculate the total length
        int total = 0;
        foreach (var interval in mergedIntervals)
        {
            total += interval.Item2 - interval.Item1;
        }

        return total;
    }
}