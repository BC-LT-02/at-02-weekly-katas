public class Fibonacci
{
    public int NthFib(int n)
    {
        int curr = 1;
        int prev = 0;
        for (int i = 0; i < n - 2; i++)
        {
            curr = curr + prev;
            prev = curr - prev;
        }
        return (n > 1) ? curr : 0;
    }
}
