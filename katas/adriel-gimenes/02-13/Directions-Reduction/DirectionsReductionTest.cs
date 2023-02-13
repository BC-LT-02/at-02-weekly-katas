namespace katas.AdrielGimenes.Test;

using Xunit;

public class DirectionsReductionTest
{
    [Fact]
    public void Test1()
    {
        string[] input1 = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
        string[] expected1 = new string[] { "WEST" };
        Assert.Equal(expected1, DirectionsReduction.DirReduc(input1));
    }

    [Fact]
    public void Test2()
    {
        string[] input2 = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
        string[] expected2 = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
        Assert.Equal(expected2, DirectionsReduction.DirReduc(input2));
    }

    [Fact]
    public void Test3()
    {
        string[] input3 = new string[] { "EAST", "NORTH", "WEST", "NORTH", "SOUTH", "NORTH", "WEST", "EAST", "SOUTH", "NORTH", "SOUTH", "EAST" };
        string[] expected3 = new string[] { "EAST", "NORTH" };
        Assert.Equal(expected3, DirectionsReduction.DirReduc(input3));
    }
}
