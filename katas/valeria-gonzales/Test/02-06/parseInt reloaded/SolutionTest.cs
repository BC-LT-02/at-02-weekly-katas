namespace FromStringsToNumbers;
public class SolutionTest
{
    [Fact]
    public void FixedTests()
    {
        Assert.Equal(1, Parser.ParseInt("one"));
        Assert.Equal(20, Parser.ParseInt("twenty"));
        Assert.Equal(246, Parser.ParseInt("two hundred forty-six"));
    }
}