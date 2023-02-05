using System;
using ProperFractions;
public class SolutionTest
{
    [Fact]
    public void SmallerNumbers()
    {
        Assert.Equal(0, ProperFractionsSolution.ProperFractions(1));
        Assert.Equal(1, ProperFractionsSolution.ProperFractions(2));
        Assert.Equal(4, ProperFractionsSolution.ProperFractions(5));
        Assert.Equal(8, ProperFractionsSolution.ProperFractions(15));
        Assert.Equal(20, ProperFractionsSolution.ProperFractions(25));
    }
}