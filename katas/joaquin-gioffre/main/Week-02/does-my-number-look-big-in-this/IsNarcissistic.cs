namespace Week2;

using System;

public static class DoesMyNumberLookBigInThis
{
    const char ZERO_ASCII_CODE = '0';

    public static bool IsNarcissistic(int value)
    {
        string number = value.ToString();
        int length = number.Length;
        int sum = 0;
        foreach (char digitAsciiCode in number)
        {
            sum += (int) Math.Pow(digitAsciiCode - ZERO_ASCII_CODE, length);
        }
        return sum == value;
    }
}