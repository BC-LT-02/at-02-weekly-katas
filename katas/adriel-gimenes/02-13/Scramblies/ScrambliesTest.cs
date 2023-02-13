namespace katas.AdrielGimenes.Test;

using Xunit;

public class ScrambliesTest
{
    [Fact]
    public void Test1()
    {
        Assert.True(Scramblies.Scramble("rkqodlw","world"));
    }

    [Fact]
    public void Test2()
    {
        Assert.True(Scramblies.Scramble("cedewaraaossoqqyt","codewars"));
    }

    [Fact]
    public void Test3()
    {
        Assert.False(Scramblies.Scramble("katas","steak"));
    }

    [Fact]
    public void Test4()
    {
        Assert.False(Scramblies.Scramble("scriptjavx","javascript"));
    }
}
