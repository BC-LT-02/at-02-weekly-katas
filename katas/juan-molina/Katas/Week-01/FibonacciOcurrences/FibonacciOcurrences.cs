namespace Solution
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Numerics;

    public static class Kata
    {
        public static List<Tuple<int, int>> FibDigits(int n)
        {
            List<Tuple<int, int>> FibDigit = new List<Tuple<int, int>>();
            var val = NthFib(n).ToString();

            foreach (var x in val.GroupBy(c => c.ToString()))
            {
                FibDigit.Add((x.Count(), Convert.ToInt32(x.Key)).ToTuple<int, int>());
            }

            return FibDigit
                .OrderByDescending(c => c.Item2)
                .OrderByDescending(c => c.Item1)
                .ToList();
        }

        public static BigInteger NthFib(int n)
        {
            BigInteger curr = 1;
            BigInteger prev = 0;
            for (int i = 0; i < n - 1; i++)
            {
                curr = curr + prev;
                prev = curr - prev;
            }

            return (n > 0) ? curr : 0;
        }
    }
}
