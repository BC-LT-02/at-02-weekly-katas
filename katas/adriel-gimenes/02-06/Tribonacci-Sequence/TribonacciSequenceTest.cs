namespace katas.AdrielGimenes.Test;

using Xunit;

public class TribonacciSequenceTest
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(new double[] { }, Xbonacci.Tribonacci(new double[] { 10, 1, 20 }, 0));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }, Xbonacci.Tribonacci(new double[] { 1, 1, 1 }, 10));
    }

    [Fact]
    public void Test3()
    {
        Assert.Equal(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }, Xbonacci.Tribonacci(new double[] { 0, 0, 1 }, 10));
    }

    [Fact]
    public void Test4()
    {
        Assert.Equal(new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 }, Xbonacci.Tribonacci(new double[] { 0, 1, 1 }, 10));
    }
}
