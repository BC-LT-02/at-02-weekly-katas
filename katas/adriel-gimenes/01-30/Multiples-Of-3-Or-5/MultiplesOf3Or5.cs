namespace katas.AdrielGimenes;

public static class MultiplesOf3Or5
{
    public static int Solution(int value)
    {
        if (value < 0) return 0;

        int sum = 0;
        for (int i = 1; i < value; i++)
        {
            if (i % 3 == 0 || i % 5 == 0) sum += i;
        }

        return sum;
    }
}
