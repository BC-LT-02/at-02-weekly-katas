namespace katas.AdrielGimenes.Test;

using Xunit;

public class SimplePigLatinTest
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("igPay atinlay siay oolcay", SimplePigLatin.PigIt("Pig latin is cool"));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal("hisTay siay ymay tringsay", SimplePigLatin.PigIt("This is my string"));
    }

    [Fact]
    public void Test3()
    {
        Assert.Equal("elloHay orldway !", SimplePigLatin.PigIt("Hello world !"));

    }
}
