namespace katas.AdrielGimenes.Test;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

public class MultiplesOf3Or5Test
{
    [Fact]
    public void VerifyMethodReturnsExpectedValues()
    {
        Assert.Equal(23, MultiplesOf3Or5.Solution(10));

        Assert.Equal(45, MultiplesOf3Or5.Solution(15));

        Assert.Equal(78, MultiplesOf3Or5.Solution(20));
    }
}
