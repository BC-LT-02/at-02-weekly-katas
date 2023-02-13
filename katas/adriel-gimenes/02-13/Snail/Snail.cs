namespace katas.AdrielGimenes;

public class Snail
{
    public static int[] SnailSolution(int[][] array)
    {
        List<int> res = new List<int>();
        int left = 0; int right = array.First().Length - 1;
        int top = 0; int bottom = array.Last().Length - 1;
        int dir = 0;

        while (top <= bottom && left <= right)
        {
            if (dir.Equals(0))
            {
                for (int i = left; i <= right; i++)
                {
                    res.Add(array[top][i]);
                }
                top++;
            }

            if (dir.Equals(1))
            {
                for (int i = top; i <= bottom; i++)
                {
                    res.Add(array[i][right]);
                }
                right--;
            }

            if (dir.Equals(2))
            {
                for (int i = right; i >= left; i--)
                {
                    res.Add(array[bottom][i]);
                }
                bottom--;
            }

            if (dir.Equals(3))
            {
                for (int i = bottom; i >= top; i--)
                {
                    res.Add(array[i][left]);
                }
                left++;
            }

            dir = (dir + 1) % 4;
        }

        return res.ToArray();
    }
}
