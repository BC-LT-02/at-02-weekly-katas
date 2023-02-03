namespace katas.AdrielGimenes.Test;

using Xunit;

public class TitleCaseTest
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("A Clash of Kings", TitleCase.TitleCases("a clash of KINGS", "a an the of"));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal("The Wind in the Willows", TitleCase.TitleCases("THE WIND IN THE WILLOWS", "The In"));
    }

    [Fact]
    public void Test3()
    {
        Assert.Equal("A Clash Of Kings", TitleCase.TitleCases("a clash of KINGS", null!));
    }

    [Fact]
    public void Test4()
    {
        Assert.Equal("", TitleCase.TitleCases(""));
    }

    [Fact]
    public void Test5()
    {
        Assert.Equal("The Quick Brown Fox", TitleCase.TitleCases("the quick brown fox"));
    }
}
