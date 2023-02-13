using System;
using System.Collections.Generic;

namespace ipValidation;

public class SolutionTest
{
    [Fact]
    public void TestCases()
    {
        Assert.True(Kata.IsValidIp("0.0.0.0"));
        Assert.True(Kata.IsValidIp("12.255.56.1"));
        Assert.True(Kata.IsValidIp("137.255.156.100"));

        Assert.False(Kata.IsValidIp(""));
        Assert.False(Kata.IsValidIp("abc.def.ghi.jkl"));
        Assert.False(Kata.IsValidIp("123.456.789.0"));
        Assert.False(Kata.IsValidIp("12.34.56"));
        Assert.False(Kata.IsValidIp("12.34.56.00"));
        Assert.False(Kata.IsValidIp("12.34.56.7.8"));
        Assert.False(Kata.IsValidIp("12.34.256.78"));
        Assert.False(Kata.IsValidIp("1234.34.56"));
        Assert.False(Kata.IsValidIp("pr12.34.56.78"));
        Assert.False(Kata.IsValidIp("12.34.56.78sf"));
        Assert.False(Kata.IsValidIp("12.34.56 .1"));
        Assert.False(Kata.IsValidIp("12.34.56.-1"));
        Assert.False(Kata.IsValidIp("123.045.067.089"));
    }
}