namespace Rot13Decoding;

public class SystemTests
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("ROT13 example.", Rot13.Decode("EBG13 rknzcyr."));
    }
}
