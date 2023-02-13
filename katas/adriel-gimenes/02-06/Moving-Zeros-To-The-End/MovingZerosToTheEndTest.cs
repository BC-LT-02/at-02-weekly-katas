namespace katas.AdrielGimenes.Test;

using Xunit;

public class MovingZerosToTheEndTest
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, MovingZerosToTheEnd.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 0, 0, 0, 0, 0 }, MovingZerosToTheEnd.MoveZeroes(new int[] { 1, 2, 3, 4, 5, 6, 0, 0, 0, 0, 0 }));
    }

    [Fact]
    public void Test3()
    {
        Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 0, 0, 0, 0 }, MovingZerosToTheEnd.MoveZeroes(new int[] { 1, 2, 0, 3, 4, 0, 5, 6, 7, 0, 0, 8 }));
    }
}
