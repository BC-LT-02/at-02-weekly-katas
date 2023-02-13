namespace katas.AdrielGimenes.Test;

using Xunit;

public class Rot13Test
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("grfg", Rot13.Cipher("test"));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal("Grfg", Rot13.Cipher("Test"));
    }
}
