public class Intervals
{
    public static int SumIntervals((int, int)[] intervals)
    {
        List<(int, int)> newIntervals = intervals.OrderBy(x => x.Item1).ToList();
        var Count = 0;
        for (var i = 0; i < newIntervals.Count() - 1; i++)
        {
            for (var j = i + 1; j < newIntervals.Count(); j++)
            {
                if (
                    newIntervals[i].Item2 >= newIntervals[j].Item1
                    && newIntervals[i].Item1 <= newIntervals[j].Item1
                )
                {
                    newIntervals[i] = (
                        newIntervals[i].Item1,
                        Math.Max(newIntervals[i].Item2, newIntervals[j].Item2)
                    );
                    newIntervals.Remove(newIntervals[j]);
                    i--;
                    break;
                }
            }
        }
        foreach (var x in newIntervals)
        {
            Count += x.Item2 - x.Item1;
        }
        return Count;
    }
}
