namespace Week2;

using System;

public static class DoesMyNumberLookBigInThis
{
    public static bool IsNarcissistic(int value)
    {
        string number = value.ToString();
        int length = number.Length;
        int sum = 0;
        foreach (char digit in number)
        {
            sum += (int) Math.Pow(digit - '0', length);
        }
        return sum == value;
    }
}