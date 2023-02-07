using System;
namespace Katas.CountingChangeCombinations;
public class CountingChangeCombinations
{
    private int recursiveCombination(int[] coins, int index, int money)
    {
        if (money == 0)
        {
            return 1;
        }
        if (money < 0)
        {
            return 0;
        }
        if (index <= 0)
        {
            return 0;
        }

        return recursiveCombination(coins, index - 1, money) + recursiveCombination(coins, index, money - coins[index - 1]);
    }
    public int CountCombinations(int money, int[] coins)
    {
        int change = recursiveCombination(coins, coins.Length, money);
        return change;
    }
}