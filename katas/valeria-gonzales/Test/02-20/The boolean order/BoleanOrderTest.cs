using System.Numerics;
namespace TheBooleanOrder;

public class SolutionTest
{
    [Fact]
    public void SampleTests()
    {
        Assert.Equal(new BigInteger(2), new BooleanOrder("tft", "^&").Solve());
        Assert.Equal(new BigInteger(16), new BooleanOrder("ttftff", "|&^&&").Solve());
        Assert.Equal(new BigInteger(339), new BooleanOrder("ttftfftf", "|&^&&||").Solve());
        Assert.Equal(new BigInteger(851), new BooleanOrder("ttftfftft", "|&^&&||^").Solve());
        Assert.Equal(new BigInteger(2434), new BooleanOrder("ttftfftftf", "|&^&&||^&").Solve());
        Assert.Equal(new BigInteger(945766470799), new BooleanOrder("ttftfftftffttfftftftfftft", "|&^&&||^&&^^|&&||^&&||&^").Solve());
    }
}
