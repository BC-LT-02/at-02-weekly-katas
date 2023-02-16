namespace katas.JorgeChavez;

public class Manhattan
{
    public static int Distance(int[] pointA, int[] pointB)
    {
        var count = 0;
        for (var i = 0; i < pointA.Length; i++)
        {
            count += Math.Abs(pointA[i] - pointB[i]);
        }
        return count;
    }
}
