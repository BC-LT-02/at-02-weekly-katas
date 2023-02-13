namespace katas.AdrielGimenes.Test;

using Xunit;

public class SnailTest
{
    [Fact]
    public void Test1()
    {
        int[][] array1 =
        {
           new []{1, 2, 3},
           new []{4, 5, 6},
           new []{7, 8, 9}
        };
        Assert.Equal(new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 }, Snail.SnailSolution(array1));
    }

    [Fact]
    public void Test2()
    {
        int[][] array2 =
        {
           new []{1, 2, 3},
           new []{8, 9, 4},
           new []{7, 6, 5}
        };
        Assert.Equal(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, Snail.SnailSolution(array2));
    }
}
